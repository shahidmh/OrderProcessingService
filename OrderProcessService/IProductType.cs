namespace OrderProcessService
{
    public interface IProductType
    {
        public string ApplyRule();

        public bool RuleSuccessFullyApplied { get; set; }

    }
}
