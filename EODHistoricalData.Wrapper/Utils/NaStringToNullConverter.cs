using System;

namespace EODHistoricalData.Wrapper.Utils
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public sealed class NaStringToNullConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            Type type = Nullable.GetUnderlyingType(objectType) ?? objectType;

            return type != typeof(string)
                   && !type.IsPrimitive
                   && !type.IsEnum
                   && type != typeof(decimal)
                   && type != typeof(DateTime)
                   && type != typeof(Guid);
        }

        public override object ReadJson(
            JsonReader reader,
            Type objectType,
            object existingValue,
            JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null)
                return null;

            if (reader.TokenType == JsonToken.String)
            {
                string value = reader.Value?.ToString();

                if (string.Equals(value, "NA", StringComparison.OrdinalIgnoreCase))
                    return null;
            }

            JToken token = JToken.Load(reader);
            return token.ToObject(objectType, serializer);
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            serializer.Serialize(writer, value);
        }
    }
}