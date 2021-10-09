using OrderProcessService.Interface;

namespace OrderProcessService.Implementation
{
    public class ActivateMembershipRule : IOrderProcessRule
    {
        public bool IsRuleApplied { get; set; }

        public string ApplyOrderRule()
        {
            return "activate membership";
        }
    }
}
