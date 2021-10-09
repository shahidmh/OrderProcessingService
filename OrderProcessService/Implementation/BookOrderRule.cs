using OrderProcessService.Interface;
using OrderProcessService.Model;

namespace OrderProcessService.Implementation
{
    /// <summary>
    /// Used for applying the rule for ordering activate membership 
    /// </summary>
    public class BookOrderRule : IOrderProcessRule
    {
        private readonly CommissionRule _commissionRule;
        public BookOrderRule()
        {
            _commissionRule = new CommissionRule();
        }
        public bool IsRuleApplied { get; set; }



        public bool IsApplicable(Order order)
        {
            return order != null && order.ProductTypes == ProductTypes.Book;
        }

        public string ProcessRules(Order order)
        {
            _commissionRule.GenerateCommission(order);
            return "create a duplicate packing slip for the royalty department";
        }
    }
}
