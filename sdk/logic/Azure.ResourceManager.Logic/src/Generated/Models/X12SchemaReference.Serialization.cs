// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Logic.Models
{
    public partial class X12SchemaReference : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("messageId");
            writer.WriteStringValue(MessageId);
            if (Optional.IsDefined(SenderApplicationId))
            {
                writer.WritePropertyName("senderApplicationId");
                writer.WriteStringValue(SenderApplicationId);
            }
            writer.WritePropertyName("schemaVersion");
            writer.WriteStringValue(SchemaVersion);
            writer.WritePropertyName("schemaName");
            writer.WriteStringValue(SchemaName);
            writer.WriteEndObject();
        }

        internal static X12SchemaReference DeserializeX12SchemaReference(JsonElement element)
        {
            string messageId = default;
            Optional<string> senderApplicationId = default;
            string schemaVersion = default;
            string schemaName = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("messageId"))
                {
                    messageId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("senderApplicationId"))
                {
                    senderApplicationId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("schemaVersion"))
                {
                    schemaVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("schemaName"))
                {
                    schemaName = property.Value.GetString();
                    continue;
                }
            }
            return new X12SchemaReference(messageId, senderApplicationId.Value, schemaVersion, schemaName);
        }
    }
}
