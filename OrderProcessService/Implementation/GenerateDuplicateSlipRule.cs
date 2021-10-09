using OrderProcessService.Interface;

namespace OrderProcessService.Implementation
{
    public class GenerateDuplicateSlipRule : IOrderProcessRule
    {
        public bool IsRuleApplied { get; set; }


        /// <summary>
        /// generate duplicate slip
        /// </summary>
        /// <returns></returns>
        public string ApplyOrderRule()
        {
            IsRuleApplied = true;
            return "Generating duplicate package slip";
        }
    }
}
