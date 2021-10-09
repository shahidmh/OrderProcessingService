namespace OrderProcessService
{
    public interface IOrderProcessRule
    {
        public bool IsRuleApplied { get; set; }
        public string ApplyOrderRule();
    }
}
