using OrderProcessService.Model;
using System;

namespace OrderProcessService.Implementation
{

    /// <summary>
    /// Email class to manage the Email
    /// </summary>
    public class EmailNotification
    {

        /// <summary>
        /// Sending Email based on the Order
        /// </summary>
        /// <param name="order"></param>
        public void SendEmail(Order order)
        {

            switch (order.ProductTypes)
            {
                case ProductTypes.ActivateMemberShip:
                    Console.WriteLine($"Sending Email(orderId :{order.OrderId}): Your account is activated now");
                    break;
                case ProductTypes.UpgradeMemberShip:
                    Console.WriteLine($"Sending Email(orderId :{order.OrderId}) :Your account is upgraded now");
                    break;
                default:
                    Console.WriteLine($"Email not send");
                    break;

            }
        }
    }
}
