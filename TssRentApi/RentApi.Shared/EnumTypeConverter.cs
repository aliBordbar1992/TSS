using System;
using Newtonsoft.Json;
using RentApi.Shared.Dto;

namespace RentApi.Shared
{
    public class EnumTypeConverter<T> : JsonConverter where T : EnumType<T>, IDomainType
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value.GetType() == typeof(T))
            {
                var t = (T)value;
                string code = t.GetCode();
                writer.WriteValue(code);
            }
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (objectType == typeof(T))
            {
                string value = (string)reader.Value;
                return EnumType<T>.FromCode(value);
            }

            return null;
        }

        public override bool CanConvert(Type objectType)
        {
            throw new NotImplementedException();
        }
    }

    public class AreaTypeConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
                var t = (AreaType)value;
                string code = t.GetCode();
                writer.WriteValue(code);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
                string value = (string)reader.Value;
                return AreaType.FromCode(value);
        }

        public override bool CanConvert(Type objectType)
        {
            throw new NotImplementedException();
        }
    }
}