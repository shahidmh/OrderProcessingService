using OrderProcessService.Model;

namespace OrderProcessService.Interface
{

    /// <summary>
    /// inteface for rule logic 
    /// </summary>
    public interface IOrderProcessRule
    {

        /// <summary>
        /// To check whether the order is applicable for processing the rule
        /// </summary>
        /// <param name="order">Pass the order object to check if its applicable</param>
        /// <returns></returns>
        bool IsApplicable(Order order);

        /// <summary>
        /// Apply the rule based on the order.
        /// </summary>
        /// <param name="order">Pass the order object</param>
        /// <returns></returns>
        string ProcessRules(Order order);
    }
}
