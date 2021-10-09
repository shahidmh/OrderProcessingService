namespace OrderProcessService.Model
{
    public class Order
    {
        public string Department { get; set; }

        public int OrderId { get; set; }

        public ProductTypes ProductTypes { get; set; }
    }
}
