using OrderProcessService.Interface;
using OrderProcessService.Model;

namespace OrderProcessService.Implementation
{
    public class PhysicalProductOrderRule : IOrderProcessRule
    {
        private CommissionRule commission;



        public bool IsApplicable(Order order)
        {
            return order.ProductTypes == ProductTypes.PhysicalProduct;
        }

        public string ProcessRules(Order order)
        {
            commission.GenerateCommission(order);
            return $"Generating package slip for shipping";
        }
    }
}
