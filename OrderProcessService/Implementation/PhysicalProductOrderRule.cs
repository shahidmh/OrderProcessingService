using OrderProcessService.Interface;
using OrderProcessService.Model;

namespace OrderProcessService.Implementation
{
    public class PhysicalProductOrderRule : IOrderProcessRule
    {


        public bool IsApplicable(Order order)
        {
            return order.ProductTypes == ProductTypes.PhysicalProduct;
        }

        public string ProcessRules(Order order)
        {
            return $"Generating package slip for shipping";
        }
    }
}
