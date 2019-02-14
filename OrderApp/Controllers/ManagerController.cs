using Microsoft.AspNetCore.Mvc;
using OrderApp.DateProvider;
using OrderApp.Models;
using System;
using System.Linq;

namespace OrderApp.Controllers
{
    [Route("api/[controller]")]
    public class ManagerController : Controller
    {
        OrderAppContext db;
        public ManagerController(OrderAppContext context)
        {
            db = context;
        }


        [HttpPost()]
        public IActionResult Post([FromBody]string request)
        {
            if (request == "CreateDemoData")
            {
                DemoData demo = new DemoData();
                demo.CreateDemoData(db);
                return Ok("Success");
            }
            if (request == "TodaysMenu")
            {
                var todaysFood = db.Orders.FirstOrDefault(o => o.Date == DateTime.Today);
                if (todaysFood != null)
                {
                    return Ok(todaysFood.Menu);
                }
                else
                {
                    return Ok("Order is not created yet!");
                }
            }
            return Ok("You didn't request anything");
            
        }
    }
}
