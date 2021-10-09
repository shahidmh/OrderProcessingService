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
            var ordeSservice = new OrderService();
            var orderProcessed = ordeSservice.ProcessOrder(order);
            Assert.Matches("create a duplicate packing slip for the royalty department", orderProcessed);
        }
        [Fact]
        public void TestMembershipOrder()
        {
            var order = new Order();
            order.ProductTypes = ProductTypes.ActivateMemberShip;
            var ordeSservice = new OrderService();
            var orderProcessed = ordeSservice.ProcessOrder(order);
            Assert.Matches("activate membership", orderProcessed);
        }

        [Fact]
        public void TestUpgradeMembershipOrder()
        {
            var order = new Order();
            order.ProductTypes = ProductTypes.UpgradeMemberShip;
            var ordeSservice = new OrderService();
            var orderProcessed = ordeSservice.ProcessOrder(order);
            Assert.Matches("apply the upgrade", orderProcessed);
        }


    }
}
