using OrderProcessService.Model;

namespace OrderProcessService.Interface
{

    /// <summary>
    /// inteface for rule logic 
    /// </summary>
    public interface IOrderProcessRule
    {

        bool IsApplicable(Order order);
        string ProcessRules(Order order);
    }
}
