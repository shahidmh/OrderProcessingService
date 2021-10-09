using OrderProcessService.Interface;
using OrderProcessService.Model;

namespace OrderProcessService.Implementation
{
    public class CommissionRule : IOrderProcessRule
    {
        public bool IsApplicable(Order order)
        {
            throw new System.NotImplementedException();
        }

        public string ProcessRules(Order order)
        {
            return "generate a commission payment to the agent";
        }
    }
}
