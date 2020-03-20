using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Mail;
using System.Net;
using System.Threading.Tasks;

namespace Shop.Bike_Components.Admin
{
    public class EmailService
    {
        private const string ServiceEmail = "kati.18@mail.ru";
        private const string Host = "smtp.mail.ru";
        private const int Port = 465;
        private const string Password = "mypassword";

        public async Task SendEmailAsync(string email, string subject, string message)
        {
            var from = new MailAddress(ServiceEmail);
            var to = new MailAddress(email);
            var mes = new MailMessage(from, to)
            {
                Subject = subject,
                Body = message
            };
            var smtp = new SmtpClient(Host, Port)
            {
                Credentials = new NetworkCredential(ServiceEmail, Password),
                EnableSsl = true
            };
            await smtp.SendMailAsync(mes);
            Console.Read();
        }
    }
}
