using OrderProcessService.Model;

namespace OrderProcessService.Interface
{

    /// <summary
    /// inteface for processing order 
    /// </summary>
    public interface IOrder
    {
        public string ProcessOrder(Order productType);
    }
}
