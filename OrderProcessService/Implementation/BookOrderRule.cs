using OrderProcessService.Interface;
using OrderProcessService.Model;

namespace OrderProcessService.Implementation
{
    /// <summary>
    /// implement the logic for generating the slip for shipping 
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
            return order.ProductTypes == ProductTypes.Book;
        }

        public string ProcessRules(Order order)
        {
            _commissionRule.GenerateCommission(order);
            return "create a duplicate packing slip for the royalty department";
        }
    }
}
