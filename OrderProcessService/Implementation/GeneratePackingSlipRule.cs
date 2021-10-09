using OrderProcessService.Inteface;

namespace OrderProcessService.Implementation
{
    /// <summary>
    /// implement the logic for generating the slip for shipping 
    /// </summary>
    public class GeneratePackingSlipRule : IOrderProcessRule
    {
        public bool IsRuleApplied { get; set; }

        public string ApplyOrderRule()
        {
            IsRuleApplied = true;
            return "Generating package slip";
        }

    }
}
