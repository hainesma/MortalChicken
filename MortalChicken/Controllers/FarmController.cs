using MortalChicken.Context;
using MortalChicken.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace MortalChicken.Controllers{
    [ApiController]
    [Route("[controller]")]

    public class FarmController: Controller
    {
        
        ChickenDbContext db = new ChickenDbContext();
        
        [HttpGet]
        [Route("all")]
        public List<Farm> GetFarms()
        {
            List<Farm> farms = db.Farms.ToList(); ;
            return farms;
        }
        
    }
}