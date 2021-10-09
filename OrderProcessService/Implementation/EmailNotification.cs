using OrderProcessService.Model;
using System;

namespace OrderProcessService.Implementation
{
    public class EmailNotification
    {
        public void SendEmail(Order order)
        {
            if (order.ProductTypes == ProductTypes.ActivateMemberShip)
                Console.WriteLine($"Your account is activated now");
            else if (order.ProductTypes == ProductTypes.ActivateMemberShip)
                Console.WriteLine($"Your account is upgraded now");

        }
    }
}
