using OrderProcessService.Model;

namespace OrderProcessService.Interface
{

    /// <summary
    /// inteface for processing order 
    /// </summary>
    public interface IOrder
    {
        public bool ProcessOrder(Order productType);
    }
}
