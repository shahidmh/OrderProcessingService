using OrderProcessService.Interface;
using OrderProcessService.Model;
using System.Collections.Generic;
using System.Linq;

namespace OrderProcessService.Implementation
{
    public class OrderService : IOrder
    {

        public bool ProcessOrder()
        {
            return true;
        }

        public bool ProcessOrder(Order order)
        {
            List<IOrderProcessRule> rules = new List<IOrderProcessRule>();
            switch (order.ProductTypes)
            {
                case ProductTypes.PhysicalProduct:
                    rules.Add(new GeneratePackingSlipRule());
                    break;
                case ProductTypes.book:
                    rules.Add(new GeneratePackingSlipRule());
                    rules.Add(new GenerateDuplicateSlipRule(order.Department));
                    break;
                case ProductTypes.ActivateMemberShip:
                    rules.Add(new ActivateMembershipRule());
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
