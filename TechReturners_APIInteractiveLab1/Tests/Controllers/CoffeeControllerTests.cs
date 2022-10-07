using System;
using NUnit.Framework;
using TechReturners_APIInteractiveLab1;
using TechReturners_APIInteractiveLab1.Controllers;
using TechReturners_APIInteractiveLab1.Models;

namespace TechReturners_APIInteractiveLab1.Tests.Controllers
{
    public class CoffeeControllerTests
    {
        [Test]
        public void TestGetHome()
        {

            string expectedContent = "I like coffee!";
            var controller = new CoffeeController();
            var result = controller.GetCoffeeLover();
            Assert.AreEqual(expectedContent, result);
        }
        [Test]
        public void Get_Coffee_No_Parameter()
        {
            Coffee expected = new Coffee
            { Name = "latte",
                Id = "-1"
            };

            var controller = new CoffeeController();
            var result = controller.Get(null);

            Assert.AreEqual(expected.Name, result.Name);
            Assert.AreEqual(expected.Id, result.Id);
        }
        [Test]
        public void Get_Coffee_By_Name()
        {
            string name = "cappuccino";
            Coffee expected = new Coffee
            {
                Name = name,
                Id = "2"

            };

            var controller = new CoffeeController();
            var result = controller.Get(name);
            Assert.AreEqual(expected.Name, result.Name);
            Assert.AreEqual(expected.Id, result.Id);
        }
    }
}
