using OrderProcessService.Interface;
using OrderProcessService.Model;

namespace OrderProcessService.Implementation
{
    public class UpgradeMemberShipRule : IOrderProcessRule
    {

        public bool IsApplicable(Order order)
        {
            return order.ProductTypes == ProductTypes.UpgradeMemberShip;
        }

        public string ProcessRules(Order order)
        {
            return "apply the upgrade";
        }
    }
}
