using Microsoft.AspNetCore.Mvc;
using System;
using TechReturners_APIInteractiveLab1.Models;

namespace TechReturners_APIInteractiveLab1.Controllers
{
    [ApiController]

    [Route("[controller]")]
    public class CoffeeController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "Welcome to the coffee api"; ;
        }
        [HttpGet("lover")]
        public string GetCoffeeLover()
        {
            return "I like coffee!"; ;
        }
        [HttpGet("{name}")]
        public Coffee Get(string name)
        {
            return new Coffee
            {
                Id = (name != null ? "2" : "-1"),

                Name = (name == null ? "latte" : name)
            };

        }
    }
}
