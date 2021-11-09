using System;
using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace UnlockedData.Mapael
{
    public class JsonStringEnumCamelCaseConverter : JsonConverter<string>
    {
        public override string? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {            
            // Split the string into words.
            string[] words = reader.GetString().Split(
                new char[] { },
                StringSplitOptions.RemoveEmptyEntries);

            // Combine the words.
            string result = words[0].ToLower();
            for (int i = 1; i < words.Length; i++)
            {
                result +=
                    words[i].Substring(0, 1).ToUpper() +
                    words[i].Substring(1);
            }

            return result;
        }

        public override void Write(Utf8JsonWriter writer, string value, JsonSerializerOptions options)
        {
            
        }

        
    }
}