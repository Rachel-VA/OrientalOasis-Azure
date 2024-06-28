using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Configuration;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace OrientalOasis.Utilities
{
    public class EmailSender : IEmailSender
    {
        private readonly string _smtpServer = string.Empty;
        private readonly int _smtpPort;
        private readonly string _fromEmail = string.Empty;
        private readonly string _fromEmailPassword = string.Empty;

        public EmailSender(IConfiguration configuration)
        {
            _smtpServer = configuration["EmailSettings:SmtpServer"] ?? string.Empty;
            _smtpPort = int.Parse(configuration["EmailSettings:SmtpPort"] ?? "0");
            _fromEmail = configuration["EmailSettings:FromEmail"] ?? string.Empty;
            _fromEmailPassword = configuration["EmailSettings:FromEmailPassword"] ?? string.Empty;
        }

        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            var client = new SmtpClient(_smtpServer, _smtpPort)
            {
                Credentials = new NetworkCredential(_fromEmail, _fromEmailPassword),
                EnableSsl = true
            };

            var mailMessage = new MailMessage
            {
                From = new MailAddress(_fromEmail),
                Subject = subject,
                Body = htmlMessage,
                IsBodyHtml = true
            };

            mailMessage.To.Add(email);

            return client.SendMailAsync(mailMessage);
        }
    }
}
