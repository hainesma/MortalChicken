using MortalChicken.Context;
using MortalChicken.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace MortalChicken.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class FarmController : Controller
    {

        ChickenDbContext db = new ChickenDbContext();

        [HttpGet]
        [Route("AllFarms")]
        public List<Farm> GetFarms()
        {
            List<Farm> farms = db.Farms.ToList(); ;
            return farms;
        }

        [HttpPost]
        [Route("Add/Name={name}")]
        public void AddFarm(string name){
            Farm f = new Farm();
            f.Name = name;
            f.Chickens = null;
            f.Seeds = 100;

            db.Farms.Add(f);
            db.SaveChanges();

        }

        [HttpGet]
        [Route("Id={farmId}")]
        public Farm GetFarm(int farmId){
            foreach (Farm f in db.Farms){
                if(f.Id == farmId){
                    return f;
                }
            }
            return null;
        }
    }


}