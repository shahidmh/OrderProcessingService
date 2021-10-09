namespace OrderProcessService
{
    public interface IProductType
    {
        /// <summary>
        /// apply rule for the product as required
        /// </summary>
        /// <returns></returns>
        public string ApplyRule();

        public bool RuleSuccessFullyApplied { get; set; }

    }
}
