using OrderProcessService.Model;
using System;

namespace OrderProcessService.Implementation
{
    public class CommissionRule
    {
        /// <summary>
        /// Generate the commsion for the order
        /// </summary>
        /// <param name="order"></param>
        public void GenerateCommission(Order order)
        {

            Console.WriteLine($"Generate a commission payment to the agent for the order : {order.OrderId}");
        }
    }
}
