using OrderProcessService;
using OrderProcessService.Implementation;
using OrderProcessService.Interface;
using OrderProcessService.Model;
using System;

namespace OrderApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var order = new Order()
            {
                OrderId = 1232,
                ProductTypes = ProductTypes.UpgradeMemberShip
            };

            IOrderService orderService = new OrderService();
            var res = orderService.ProcessOrder(order);
            Console.WriteLine(res);
            Console.ReadLine();
        }
    }
}
