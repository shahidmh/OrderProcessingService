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
            order.ProductTypes = ProductTypes.PhysicalProduct;
            var ordeSservice = new OrderService();
            var orderProcessed = ordeSservice.ProcessOrder(order);
            Assert.Matches("Generating package slip for shipping", orderProcessed);
        }
        [Fact]
        public void TestBookOrder()
        {
            var order = new Order();
            order.ProductTypes = ProductTypes.Book;
            var orderService = new OrderService();
            var orderProcessed = orderService.ProcessOrder(order);
            Assert.Equal("create a duplicate packing slip for the royalty department", orderProcessed);
        }
        [Fact]
        public void TestMembershipOrder()
        {
            var order = new Order();
            order.ProductTypes = ProductTypes.ActivateMemberShip;
            var orderService = new OrderService();
            var orderProcessed = orderService.ProcessOrder(order);
            Assert.Equal("activate membership", orderProcessed);
        }

        [Fact]
        public void TestUpgradeMembershipOrder()
        {
            var order = new Order();
            order.ProductTypes = ProductTypes.UpgradeMemberShip;
            var orderService = new OrderService();
            var orderProcessed = orderService.ProcessOrder(order);
            Assert.Equal("apply the upgrade", orderProcessed);
        }
        [Fact]
        public void TestVideoOrder()
        {
            var order = new Order();
            order.ProductTypes = ProductTypes.Video;
            var orderService = new OrderService();
            var orderProcessed = orderService.ProcessOrder(order);
            Assert.Equal("Add a free “First Aid” video to the packing slip (the result of a court decision in 1997).", orderProcessed);
        }

    }
}
