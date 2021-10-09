using OrderProcessService.Interface;
using OrderProcessService.Model;

namespace OrderProcessService.Implementation
{
    public class ActivateMembershipRule : IOrderProcessRule
    {
        private readonly EmailNotification _emailNotification;
        public ActivateMembershipRule()
        {
            _emailNotification = new EmailNotification();
        }
        public bool IsApplicable(Order order)
        {
            return order.ProductTypes == ProductTypes.ActivateMemberShip;
        }

        public string ProcessRules(Order order)
        {
            _emailNotification.SendEmail(order);
            return "activate membership";
        }
    }
}
