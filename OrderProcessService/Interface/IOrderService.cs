using OrderProcessService.Model;

namespace OrderProcessService.Interface
{

    /// <summary
    /// inteface for processing order 
    /// </summary>
    public interface IOrderService
    {

        /// <summary>
        /// Execute the order rule if its applicable to the order.
        /// </summary>
        /// <param name="order">Pass the order object</param>
        /// <returns></returns>
        public string ProcessOrder(Order order);
    }
}
