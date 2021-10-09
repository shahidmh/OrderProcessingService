using OrderProcessService;
using OrderProcessService.Implementation;
using Xunit;

namespace TestOrderProcessing
{
    public class UnitTest1
    {

        [Fact]
        public void TestPhysicalProductOrder()
        {
            var order = new Order();
            var orderProcessed = order.ProcessOrder(ProductTypes.PhysicalProduct);
            Assert.True(orderProcessed);
        }
        [Fact]
        public void TestBookOrder()
        {
            var order = new Order();
            var orderProcessed = order.ProcessOrder(ProductTypes.book);
            Assert.True(orderProcessed);
        }
    }
}
