﻿using SendGrid;
using SendGrid.Helpers.Mail;

namespace IdentityLogin.Models
{
    public interface IEmailProvider
    {
        Task SendEmailAsync(string toEmail, string fromEmail,
            string subject, string content, string name);
    }

    public class EmailProviderSendGrid : IEmailProvider
    {
        private readonly IConfiguration _config;
        public EmailProviderSendGrid(IConfiguration config)
        {
            _config = config;
        }
        public async Task SendEmailAsync(string toEmail, string fromEmail, string subject, string content, string name)
        {
            var apiKey = _config.GetSection("LeagueApiKey").Value;
            var coEmail = _config.GetSection("coEmail").Value; // fromEmail
            var client = new SendGridClient(apiKey);
            var msg = new SendGridMessage()
            {
                From = new EmailAddress(coEmail, "League Team"),
                Subject = subject,
                PlainTextContent = "From: "  + name + " at email: " + toEmail + ",\n\n" + content,
            };
            msg.AddTo(new EmailAddress(coEmail, "League Team"));
            var response = await client.SendEmailAsync(msg); // see if the email is going through
       
        }
    }
}