using OrderProcessService.Model;
using System;

namespace OrderProcessService.Implementation
{
    public class CommissionRule
    {
        public void GenerateCommission(Order order)
        {

            Console.WriteLine($"Generate a commission payment to the agent for the order : {order.OrderId}");
        }
    }
}
