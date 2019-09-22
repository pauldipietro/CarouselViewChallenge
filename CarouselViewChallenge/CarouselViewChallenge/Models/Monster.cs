using System;
using TinyCsvParser.Mapping;

namespace CarouselViewChallenge.Models
{
    public class Monster
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Alignment { get; set; }
        public string Size { get; set; }
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Constitution { get; set; }
        public int Intelligence { get; set; }
        public int Wisdom { get; set; }
        public int Charisma { get; set; }
        public string Image { get; set; }

        public bool HasImage => !string.IsNullOrEmpty(Image);
        public string SubHeader => $"{Size} {Type}, {Alignment}";
    }

    public class CsvMonsterMapping : CsvMapping<Monster>
    {
        public CsvMonsterMapping()
            : base()
        {
            MapProperty(0, x => x.Name);
            MapProperty(1, x => x.Type);
            MapProperty(2, x => x.Alignment);
            MapProperty(3, x => x.Size);
            MapProperty(4, x => x.Strength);
            MapProperty(5, x => x.Dexterity);
            MapProperty(6, x => x.Constitution);
            MapProperty(7, x => x.Intelligence);
            MapProperty(8, x => x.Wisdom);
            MapProperty(9, x => x.Charisma);
            MapProperty(10, x => x.Image);
        }
    }
}