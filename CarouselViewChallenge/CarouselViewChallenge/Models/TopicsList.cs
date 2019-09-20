using CsvHelper;
using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace CarouselViewChallenge.Models
{
    public class TopicsList
    {
        private readonly string BoWFilename;

        #region Properties

        public List<Topic> Topics { get; set; }

        #endregion

        public TopicsList(string filename)
        {
            BoWFilename = filename;
            Topics = new List<Topic>();
            GetBagOfWords();
        }

        private void GetBagOfWords()
        {
            try
            {
                Assembly assembly = GetType().GetTypeInfo().Assembly;
                using (Stream stream = assembly.GetManifestResourceStream(BoWFilename))
                {
                    using (StreamReader reader = new StreamReader(stream))
                    {
                        Configuration csvConfig = new Configuration
                        {
                            Delimiter = ",",
                            IgnoreQuotes = true
                        };
                        using (CsvReader csv = new CsvReader(reader, csvConfig))
                        {
                            while (csv.Read())
                            {
                                string name = csv.GetField<string>(0);
                                List<string> terms = new List<string>();
                                for (int i = 1; csv.TryGetField<string>(i, out string value); i++)
                                {
                                    terms.Add(value);
                                }
                                Topics.Add(new Topic(name, terms));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Unable to load Bag of Words for linguistic analysis.", ex);
            }
        }
    }
}