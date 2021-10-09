namespace OrderProcessService
{
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
