using OrderProcessService.Model;

namespace OrderProcessService.Interface
{

    /// <summary
    /// inteface for processing order 
    /// </summary>
    public interface IOrderService
    {

        /// <summary>
        /// Process the order based on the order and apply required order rule.
        /// </summary>
        /// <param name="order">Pass the order object</param>
        /// <returns></returns>
        public string ProcessOrder(Order order);
    }
}
