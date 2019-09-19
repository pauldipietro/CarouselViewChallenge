using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using CarouselViewChallenge.Models;

namespace CarouselViewChallenge.Services
{
    public class FakeMonsterService
    {
        public List<Monster> GetMonsters()
        {
            return File.ReadAllLines("Monsters.csv").Skip(1).Select(Monster.FromCsv).ToList();
        }
    }
}