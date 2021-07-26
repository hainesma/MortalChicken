using Microsoft.AspNetCore.Mvc;
using MortalChicken.Context;
using MortalChicken.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MortalChicken.Controllers
{
    [ApiController]
    [Route("[controller]")]
    
    public class ChickenController : Controller
    {
        ChickenDbContext db = new ChickenDbContext();
        
        [HttpGet]
        [Route("AllChickens")]
        public List<Chicken> GetChickens()
        {
            List<Chicken> chickens = db.Chickens.ToList();
            return chickens;
        }

        [HttpGet]
        [Route("id={id}")]
        public Chicken GetChicken(int id)
        {
            
            foreach (Chicken c in db.Chickens)
            {
                if(c.Id == id)
                {
                    return c;
                }
            }
            return null;
        }

        [HttpGet]
        [Route("Farm={farmId}")]
        public List<Chicken> GetChickensByFarm(int farmId)
        {
            List<Chicken> chickensAtFarm = new List<Chicken>();
            foreach(Chicken c in db.Chickens)
            {
                if(c.Farm.Id == farmId)
                {
                    chickensAtFarm.Add(c);
                }
            }
            return chickensAtFarm;
        }

        [HttpPost]
        [Route("Add/name={name}/farm={farmId}")]
        public void AddChicken(string name, int farmId)
        {
            Random r = new Random();
            int numberColors = Enum.GetValues(typeof(Color)).Length;
            Chicken c = new Chicken();
            c.Name = name;
            c.Age = 0;
            c.Smarts = r.Next(1, 11);
            c.Strength = r.Next(1, 11);
            c.Speed = r.Next(1, 11);
            c.Luck = r.NextDouble() * 10;
            c.Color = (Color)r.Next(0, numberColors - 1);
            c.Farm.Id = farmId;
        }
    }
}
