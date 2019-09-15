using CarouselViewChallenge.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace CarouselViewChallenge.Converters
{
    public class NewsItemConverter : JsonConverter
    {
        public static readonly NewsItemConverter Instance = new NewsItemConverter();

        private static readonly Type NewsItemType = typeof(ICollection<NewsItem>);

        public override bool CanConvert(Type objectType)
        {
            return NewsItemType.IsAssignableFrom(objectType);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var collection = new List<NewsItem>();
            NewsItem item = null;
            while (reader.Read())
            {
                switch (reader.TokenType)
                {
                    case JsonToken.StartObject:
                        item = new NewsItem();
                        collection.Add(item);
                        break;
                    case JsonToken.PropertyName:
                        SetProperty(reader, item);
                        break;
                    case JsonToken.EndArray:
                        return collection;
                }
            }
            return collection;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        private static void SetProperty(JsonReader reader, NewsItem item)
        {
            var name = (string)reader.Value;
            reader.Read();
            switch (name)
            {
                case "title":
                    item.Title = (string)reader.Value;
                    break;
                case "body":
                    item.Body = (string)reader.Value;
                    break;
                case "date":
                    item.PublishDateTime = Convert.ToDateTime(reader.Value);
                    break;
                case "nid":
                    item.Id = Convert.ToInt32(reader.Value);
                    break;
                case "image":
                    item.FDImageName = (string)reader.Value;
                    break;
                case "slug":
                    item.Slug = (string)reader.Value;
                    break;
            }
        }
    }
}
