using Microsoft.AspNetCore.Mvc;
using System;
namespace TechReturners_APIInteractiveLab1.Controllers
{
    [ApiController]
    [Route("")]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "Welcome to the Drinks API!"; ;
        }
    }
}
