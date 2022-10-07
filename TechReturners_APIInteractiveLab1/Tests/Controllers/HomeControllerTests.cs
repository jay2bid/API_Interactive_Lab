using System;
using NUnit.Framework;
using TechReturners_APIInteractiveLab1;
using TechReturners_APIInteractiveLab1.Controllers;

namespace TechReturners_APIInteractiveLab1.Tests.Controllers
{
    public class HomeControllerTests
    {
        [Test]
        public void TestGetHome()
        {

            string expectedContent = "Welcome to the Drinks API!";
            var controller = new HomeController();
            var result = controller.Get();
            Assert.AreEqual(expectedContent, result);
        }
    }
}
