using Newtonsoft.Json.Linq;

namespace WWB.Paylink.HsqPay.Attributes;

public class ObjToStringConverter : JsonConverter
{
    public override bool CanRead { get; } = false;

    public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
    {
        writer.WriteValue(JsonConvert.SerializeObject(value));
    }

    public override object? ReadJson(JsonReader reader, Type objectType, object? existingValue, JsonSerializer serializer)
    {
        throw new NotImplementedException();
    }

    public override bool CanConvert(Type objectType)
    {
        return true;
    }
}