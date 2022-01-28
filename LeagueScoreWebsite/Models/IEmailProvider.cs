using SendGrid;
using SendGrid.Helpers.Mail;

namespace IdentityLogin.Models
{
    public interface IEmailProvider
    {
        Task SendEmailAsync(string toEmail, string fromEmail,
            string subject, string content, string htmlContent);
    }

    public class EmailProviderSendGrid : IEmailProvider
    {
        private readonly IConfiguration _config;
        public EmailProviderSendGrid(IConfiguration config)
        {
            _config = config;
        }
        public async Task SendEmailAsync(string toEmail, string fromEmail, string subject, string content, string htmlContent)
        {
            var apiKey = _config.GetSection("LeagueScore").Value;
            var client = new SendGridClient(apiKey);
            var msg = new SendGridMessage()
            {
                From = new EmailAddress("t.fox.bsns@gmail.com", "Me"),  // This MUST be changed for live rollout
                Subject = "Test Email for Send Grid",
                PlainTextContent = "hope it worked",
                HtmlContent = "<strong>trying it for the first time</strong>"
            };
            msg.AddTo(new EmailAddress("t.fox.bsns@gmail.com", "Not the Fox"));  // This MUST be changed for live rollout
            //var response = await client.SendEmailAsync(msg).ConfigureAwait(false);
            await client.SendEmailAsync(msg);
        }
    }
}