using OrderProcessService.Interface;
using OrderProcessService.Model;

namespace OrderProcessService.Implementation
{

    /// <summary>
    /// Used for applying the rule for ordering videos 
    /// </summary>
    public class VideoOrderRule : IOrderProcessRule
    {
        public bool IsApplicable(Order order)
        {
            return order != null && order.ProductTypes == ProductTypes.Video;
        }

        public string ProcessRules(Order order)
        {
            return "Add a free “First Aid” video to the packing slip (the result of a court decision in 1997).";
        }
    }
}
