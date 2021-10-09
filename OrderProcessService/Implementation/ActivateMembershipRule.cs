using OrderProcessService.Interface;
using OrderProcessService.Model;

namespace OrderProcessService.Implementation
{
    public class ActivateMembershipRule : IOrderProcessRule
    {
        public bool IsRuleApplied { get; set; }

        public bool IsApplicable(Order order)
        {
            return order.ProductTypes == ProductTypes.ActivateMemberShip;
        }

        public string ProcessRules(Order order)
        {
            return "activate membership";
        }
    }
}
