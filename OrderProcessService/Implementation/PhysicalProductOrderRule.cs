using OrderProcessService.Interface;
using OrderProcessService.Model;

namespace OrderProcessService.Implementation
{
    public class PhysicalProductOrderRule : IOrderProcessRule
    {
        private readonly CommissionRule _commissionRule;

        public PhysicalProductOrderRule()
        {
            _commissionRule = new CommissionRule();
        }



        public bool IsApplicable(Order order)
        {
            return order != null && order.ProductTypes == ProductTypes.PhysicalProduct;
        }

        public string ProcessRules(Order order)
        {
            _commissionRule.GenerateCommission(order);
            return $"Generating package slip for shipping";
        }
    }
}
