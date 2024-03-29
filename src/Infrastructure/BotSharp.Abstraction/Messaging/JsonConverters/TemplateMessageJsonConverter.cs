using System.Text.Json;

namespace BotSharp.Abstraction.Messaging.JsonConverters;

public class TemplateMessageJsonConverter : JsonConverter<ITemplateMessage>
{
    public override ITemplateMessage? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        throw new NotImplementedException();
    }

    public override void Write(Utf8JsonWriter writer, ITemplateMessage value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
