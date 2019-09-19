using System;

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

        public static Monster FromCsv(string csvLine)
        {
            string[] values = csvLine.Split(',');
            Monster monster = new Monster();
            monster.Name = Convert.ToString(values[0]);
            monster.Type = Convert.ToString(values[1]);
            monster.Alignment = Convert.ToString(values[2]);
            monster.Size = Convert.ToString(values[3]);
            monster.Strength = Convert.ToInt32(values[4]);
            monster.Dexterity = Convert.ToInt32(values[5]);
            monster.Constitution = Convert.ToInt32(values[6]);
            monster.Intelligence = Convert.ToInt32(values[7]);
            monster.Wisdom = Convert.ToInt32(values[8]);
            monster.Charisma = Convert.ToInt32(values[9]);
            monster.Image = Convert.ToString(values[10]);
            return monster;
        }
    }
}