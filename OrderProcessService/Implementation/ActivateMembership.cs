using OrderProcessService.Interface;

namespace OrderProcessService.Implementation
{
    public class ActivateMembership : IOrderProcessRule
    {
        public bool IsRuleApplied { get; set; }

        public string ApplyOrderRule()
        {
            return "activate membership";
        }
    }
}
