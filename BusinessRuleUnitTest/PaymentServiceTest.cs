using BusinessRuleEngine.Controllers;
using BusinessRuleEngine.Models;
using BusinessRuleEngine.Service.Interface;
using Moq;
using System;
using Xunit;

namespace BusinessRuleUnitTest
{
    public class PaymentServiceTest
    {
       
        public Mock<IPaymentService> mock = new Mock<IPaymentService>();


        [Fact]
        public void ProcessOrderTest()
        {
            mock.Setup(p => p.ProcessOrder("Physical")).Returns("Success");
            HomeController home = new HomeController(null,mock.Object);
            Payment paymentModel = new Payment();
            paymentModel.Product = Product.Physical;
            var result = home.ProcessPayment(paymentModel);
            Assert.True(result != null);
        }


       
    }
}
