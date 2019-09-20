using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using Acr.UserDialogs;
using CarouselViewChallenge.Models;
using TinyCsvParser;

namespace CarouselViewChallenge.Services
{
    public class FakeMonsterService
    {
        public List<Monster> GetMonsters()
        {
            return Deserialize("Monsters.csv");
        }

        private List<Monster> Deserialize(string name)
        {
            List<Monster> monsters = new List<Monster>();
            var assembly = this.GetType().GetTypeInfo().Assembly;
            var resources = assembly.GetManifestResourceNames();
            var resourceName = resources.Single(r => r.EndsWith(name, StringComparison.OrdinalIgnoreCase));
            var stream = assembly.GetManifestResourceStream(resourceName);
            var rowCount = 0;

            try
            {
                CsvParserOptions csvParserOptions = new CsvParserOptions(false, ',');
                CsvMonsterMapping csvMapper = new CsvMonsterMapping();
                CsvParser<Monster> csvParser = new CsvParser<Monster>(csvParserOptions, csvMapper);

                var result = csvParser
                    .ReadFromStream(stream, Encoding.ASCII)
                    .ToList();
                monsters = result.Select(x => x.Result).ToList();
                return monsters;
            }
            catch (Exception ex)
            {
                UserDialogs.Instance.AlertAsync($"Couldn't load file at line {rowCount}", "Error", "OK");
            }

            return monsters;
        }
    }
}