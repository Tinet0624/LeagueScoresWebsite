using System.ComponentModel.DataAnnotations;

namespace LeagueScoreWebsite.Models
{
    public class ContactUsModel
    {
        public string name { get; set; }
        public string toEmail { get; set; }
        public string subject { get; set; }
        public string content { get; set; }
    }
}
