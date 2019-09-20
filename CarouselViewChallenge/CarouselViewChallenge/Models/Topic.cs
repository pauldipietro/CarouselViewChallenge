using System.Collections.Generic;

namespace CarouselViewChallenge.Models
{
    public class Topic
    {
        #region Properties

        public string Name { get; }
        public List<string> Terms { get; }
        public int Count { get; set; }

        #endregion

        public Topic(string name, List<string> terms)
        {
            Name = name;
            Terms = terms;
            Count = 0;
        }
    }
}
