using System.Collections.Generic;
using System.Linq;

namespace OrderProcessService
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
