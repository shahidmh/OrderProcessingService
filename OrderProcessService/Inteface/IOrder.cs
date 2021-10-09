namespace OrderProcessService.Inteface
{

    /// <summary
    /// inteface for processing order 
    /// </summary>
    public interface IOrder
    {
        public bool ProcessOrder(ProductTypes productType);
    }
}
