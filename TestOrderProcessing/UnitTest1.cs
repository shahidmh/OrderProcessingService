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
            Assert.Matches("Generating package slip", orderProcessed);
        }
        [Fact]
        public void TestBookOrder()
        {
            var order = new Order();
            order.ProductTypes = ProductTypes.Book;
            var ordeSservice = new OrderService();
            var orderProcessed = ordeSservice.ProcessOrder(order);
            Assert.Matches("Generating package slip", orderProcessed);
        }
        //[Fact]
        //public void OrderSlipForShipping()
        //{
        //    var order = new Order();
        //    order.ProductTypes = ProductTypes.Book;
        //    var result = new BookOrderRule().ProcessRules(order);
        //    Assert.Matches("Generating package slip", result);
        //}

        //[Fact]
        //public void DuplocateSlipForDepartment()
        //{
        //    string department = "royalty";
        //    var result = new PhysicalProductOrderRule().ProcessRules(order);
        //    Assert.Matches($"Generating duplicate package slip for {department}", result);
        //}


    }
}
