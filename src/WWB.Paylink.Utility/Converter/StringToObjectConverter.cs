using Newtonsoft.Json;
using System;

namespace WWB.Paylink.Utility.Converter
{
    public class StringToObjectConverter : JsonConverter
    {
        public override bool CanWrite { get; } = false;

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            return JsonConvert.DeserializeObject(reader.Value.ToString(), objectType);
        }

        public override bool CanConvert(Type objectType)
        {
            return true;
        }
    }
}