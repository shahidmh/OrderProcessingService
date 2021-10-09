using OrderProcessService.Interface;
using System.Collections.Generic;
using System.Linq;

namespace OrderProcessService.Implementation
{
    public class Order : IOrder
    {

        public bool ProcessOrder()
        {
            return true;
        }

        public bool ProcessOrder(ProductTypes productType)
        {
            List<IOrderProcessRule> rules = new List<IOrderProcessRule>();
            switch (productType)
            {
                case ProductTypes.PhysicalProduct:
                    rules.Add(new GeneratePackingSlipRule());
                    break;
                case ProductTypes.book:
                    rules.Add(new GeneratePackingSlipRule());
                    rules.Add(new GenerateDuplicateSlipRule());
                    break;
                default:
                    break;

            }
            foreach (var rule in rules)
            {
                rule.ApplyOrderRule();
            }
            if (rules.Any())
                return rules.All(rule => rule.IsRuleApplied == true);
            else
                return false;
        }
    }
}
