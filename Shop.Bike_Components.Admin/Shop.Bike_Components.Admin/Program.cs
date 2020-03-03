using System;
using Project.Shop.Bike_Components;

namespace Shop.Bike_Components.Admin
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IOrderRepository orderRepository = new OrderRepository("orders.json");

            EmailService emailService = new EmailService();

            Console.WriteLine("Order list:");
            foreach (var item in orderRepository.GetAll())
            {
                item.PrintOrderInfo();
            }

            Console.WriteLine("Enter order Id:");
            int id = Convert.ToInt32(Console.ReadLine());
            var order = orderRepository.GetById(id);

            //order.OrderStatus = OrderStatus.ReadyToDispatch;

            //emailService.SendEmailAsync(email, "Order", order);

            Console.ReadKey();
        }
            
        
    }
}
