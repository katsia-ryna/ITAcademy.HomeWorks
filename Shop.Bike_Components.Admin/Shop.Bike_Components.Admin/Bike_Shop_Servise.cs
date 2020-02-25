using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Mail;
using System.Net;

namespace Shop.Bike_Components.Admin
{
    public class Bike_Shop_Servise
    {
        public delegate void BikeServiceDelegate(string address, int quantity/*, Bike bikeToOrder,Customer customer*/);
        public event BikeServiceDelegate SendToEmail;
        public event BikeServiceDelegate SubscriptionToUpdates;

        private BikeServiceDelegate _bikeService;

        public Bike_Shop_Servise(BikeServiceDelegate bikeService)
        {
            _bikeService = bikeService;
        }

        public void SendEmail(string status)
        {
            MailAddress from = new MailAddress("kati.18@mail.ru", "name");
            MailAddress to = new MailAddress("kati.18@mail.ru");
            MailMessage m = new MailMessage(from, to);
            m.Subject = "Your order is formed";
            m.Body = "";
            m.IsBodyHtml = true;
            SmtpClient smtp = new SmtpClient("smtp.mail.ru", 587);
            smtp.Credentials = new NetworkCredential("kati.18@mail.ru", "mypassword");
            smtp.EnableSsl = true;
            smtp.Send(m);
            Console.Read();
        }
        
        
    }
}
