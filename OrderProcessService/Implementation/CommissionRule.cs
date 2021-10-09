using OrderProcessService.Model;

namespace OrderProcessService.Implementation
{
    public class CommissionRule
    {
        public string GenerateCommission(Order order)
        {

            return $"Generate a commission payment to the agent for the order : {order.OrderId}";
        }
    }
}
