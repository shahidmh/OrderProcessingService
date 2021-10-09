using OrderProcessService;
using Xunit;

namespace TestOrderProcessing
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal("1", "1");
        }
        [Fact]
        public void TestPhysicalProductOrder()
        {
            var order = new Order();
            var orderProcessed = order.ProcessOrder(ProductTypes.book);
            Assert.True(orderProcessed);
        }

    }
}
