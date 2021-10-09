using OrderProcessService.Interface;
using OrderProcessService.Model;

namespace OrderProcessService.Implementation
{
    public class UpgradeMemberShipRule : IOrderProcessRule
    {
        private readonly EmailNotification _emailNotification;
        public UpgradeMemberShipRule()
        {
            _emailNotification = new EmailNotification();
        }

        public bool IsApplicable(Order order)
        {
            return order != null && order.ProductTypes == ProductTypes.UpgradeMemberShip;
        }

        public string ProcessRules(Order order)
        {
            _emailNotification.SendEmail(order);
            return "apply the upgrade";
        }
    }
}
