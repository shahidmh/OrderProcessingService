using OrderProcessService.Interface;
using OrderProcessService.Model;
using System.Collections.Generic;

namespace OrderProcessService.Implementation
{

    public class OrderService : IOrderService
    {
        private readonly List<IOrderProcessRule> rules;
        public OrderService()
        {
            rules = new List<IOrderProcessRule>();
            rules.Add(new BookOrderRule());
            rules.Add(new PhysicalProductOrderRule());
            rules.Add(new ActivateMembershipRule());
            rules.Add(new UpgradeMemberShipRule());
        }

        public bool ProcessOrder()
        {
            return true;
        }

        public string ProcessOrder(Order order)
        {

            foreach (var rule in rules)
            {
                if (rule.IsApplicable(order))
                    return rule.ProcessRules(order);
            }
            return string.Empty;

        }
    }
}
