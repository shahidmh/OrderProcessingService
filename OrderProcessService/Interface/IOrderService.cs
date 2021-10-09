using OrderProcessService.Model;

namespace OrderProcessService.Interface
{

    /// <summary
    /// inteface for processing order 
    /// </summary>
    public interface IOrderService
    {
        public string ProcessOrder(Order productType);
    }
}
