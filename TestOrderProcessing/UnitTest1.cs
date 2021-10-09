using OrderProcessService;
using OrderProcessService.Implementation;
using OrderProcessService.Model;
using Xunit;

namespace TestOrderProcessing
{
    public class UnitTest1
    {

        [Fact]
        public void TestPhysicalProductOrder()
        {
            var order = new Order();
            order.ProductTypes = ProductTypes.book;
            var ordeSservice = new OrderService();
            var orderProcessed = ordeSservice.ProcessOrder(order);
            Assert.True(orderProcessed);
        }
        [Fact]
        public void TestBookOrder()
        {
            var order = new Order();
            order.ProductTypes = ProductTypes.book;
            var ordeSservice = new OrderService();
            var orderProcessed = ordeSservice.ProcessOrder(order);
            Assert.True(orderProcessed);
        }
        [Fact]
        public void OrderSlipForShipping()
        {
            var result = new GeneratePackingSlipRule().ApplyOrderRule();
            Assert.Matches("Generating package slip", result);
        }

    }
}
