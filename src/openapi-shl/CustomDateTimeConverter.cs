using System.Text.Json;
using System.Text.Json.Serialization;

namespace Shl.Api;

public class CustomDateTimeConverter : JsonConverter<DateTime>
{
    public override DateTime Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        return DateTime.Parse(reader.GetString());
        //return DateTime.ParseExact(reader.GetString(), "yyyy-MM-ddTH:mm:ss", null);
    }

    public override void Write(Utf8JsonWriter writer, DateTime value, JsonSerializerOptions options)
    {
        //return DateTime.Parse(reader.GetString());
        throw new NotImplementedException();
    }
}