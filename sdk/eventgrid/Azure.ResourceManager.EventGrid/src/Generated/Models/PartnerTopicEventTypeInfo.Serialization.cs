// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.EventGrid.Models
{
    public partial class PartnerTopicEventTypeInfo : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind");
                writer.WriteStringValue(Kind.Value.ToString());
            }
            if (Optional.IsCollectionDefined(InlineEventTypes))
            {
                writer.WritePropertyName("inlineEventTypes");
                writer.WriteStartObject();
                foreach (var item in InlineEventTypes)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WriteEndObject();
        }

        internal static PartnerTopicEventTypeInfo DeserializePartnerTopicEventTypeInfo(JsonElement element)
        {
            Optional<EventDefinitionKind> kind = default;
            Optional<IDictionary<string, InlineEventProperties>> inlineEventTypes = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    kind = new EventDefinitionKind(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("inlineEventTypes"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, InlineEventProperties> dictionary = new Dictionary<string, InlineEventProperties>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, InlineEventProperties.DeserializeInlineEventProperties(property0.Value));
                    }
                    inlineEventTypes = dictionary;
                    continue;
                }
            }
            return new PartnerTopicEventTypeInfo(Optional.ToNullable(kind), Optional.ToDictionary(inlineEventTypes));
        }
    }
}
