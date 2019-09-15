using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace CarouselViewChallenge.Models
{
    public class NewsItem
    {
        #region Properties

        private string _title;
        [JsonProperty(PropertyName = "title")]
        public string Title
        {
            get { return _title; }
            internal set
            {
                if (_title != value)
                {
                    _title = value.Trim();
                }
            }
        }

        private string _body;
        [JsonProperty(PropertyName = "body")]
        public string Body
        {
            get { return _body; }
            internal set
            {
                if (_body != value)
                {
                    _body = value.Replace("<p>", "").Replace("</p>", "\n").Replace("<br />", "\n").Replace("&#039;", "'").Replace("&quot;", "\u201d").Trim();
                }
            }
        }

        [JsonProperty(PropertyName = "date")]
        public DateTime PublishDateTime { get; internal set; }

        [JsonProperty(PropertyName = "nid")]
        public int Id { get; internal set; }

        [JsonProperty(PropertyName = "image")]
        public string FDImageName { get; internal set; }

        [JsonProperty(PropertyName = "slug")]
        public string Slug { get; internal set; }

        public string Topic { get; private set; }
        public List<string> Tags { get; private set; }

        public string PublishDate
        {
            get
            {
                // return the date part of PublishDateTime
                string date = PublishDateTime.ToString();
                return date.Substring(0, date.IndexOf(" "));
            }
        }

        #endregion

        public override string ToString()
        {
            return String.Format("{0}: {1}", Title, Body);
        }

        private List<string> SplitSentences()
        {
            List<string> sentences = new List<string>
            {
                Title.Trim().ToLower(),
                Slug.Replace("-", " ").Trim().ToLower()
            };
            foreach (string sentence in Regex.Split(Body, @"(?<=[\w\s](?:[\.\!\? ]+[\x20]*[\x22\xBB]*))(?:\s+(?![\x22\xBB](?!\w)))"))
            {
                sentences.Add(sentence.Trim().ToLower());
            }
            return sentences;
        }

        public void ClassifyArticle()
        {
            Tags = new List<string>();
            // analyse article using Bag of Words technique
            TopicsList topicsList = new TopicsList("CarouselViewChallenge.Resources.NewsBoW.csv");
            foreach (string sentence in SplitSentences())
            {
                foreach (Topic topic in topicsList.Topics)
                {
                    foreach (string term in topic.Terms)
                    {
                        if (sentence.Contains(term.ToLower()))
                        {
                            topic.Count++;
                        }
                    }
                }
            }
            // select topic + tags
            Topic tempTopic = topicsList.Topics.OrderByDescending(o => o.Count).First();
            if (tempTopic.Count < 2 || string.Equals(Title, "week in review", StringComparison.OrdinalIgnoreCase))
            {
                Topic = "Unclassified";
            }
            else
            {
                Topic = tempTopic.Name;
            }
            foreach (Topic topic in topicsList.Topics.OrderByDescending(o => o.Count).Take(5))
            {
                if (topic.Count > 0)
                {
                    Tags.Add(topic.Name);
                }
            }
        }
    }
}
