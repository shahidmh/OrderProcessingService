using OrderProcessService.Interface;
using OrderProcessService.Model;

namespace OrderProcessService.Implementation
{
    /// <summary>
    /// implement the logic for generating the slip for shipping 
    /// </summary>
    public class BookOrderRule : IOrderProcessRule
    {
        public bool IsRuleApplied { get; set; }



        public bool IsApplicable(Order order)
        {
            return order.ProductTypes == ProductTypes.Book;
        }

        public string ProcessRules(Order order)
        {
            return "create a duplicate packing slip for the royalty department";
        }
    }
}
