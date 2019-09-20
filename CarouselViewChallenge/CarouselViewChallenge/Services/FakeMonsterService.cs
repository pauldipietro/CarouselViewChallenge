using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        public ObservableCollection<Monster> GetMonsters()
        {
            return Deserialize("Monsters.csv");
        }

        private ObservableCollection<Monster> Deserialize(string name)
        {
            ObservableCollection<Monster> monsters = new ObservableCollection<Monster>();
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

                monsters = new ObservableCollection<Monster>(result.Select(x => x.Result));
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