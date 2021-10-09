namespace OrderProcessService
{
    public interface IOrder
    {
        public bool ProcessOrder(ProductTypes productType);
    }
}
