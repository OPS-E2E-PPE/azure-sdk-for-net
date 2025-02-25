// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Support.Models
{
    public partial class QuotaTicketDetails : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(QuotaChangeRequestSubType))
            {
                writer.WritePropertyName("quotaChangeRequestSubType");
                writer.WriteStringValue(QuotaChangeRequestSubType);
            }
            if (Optional.IsDefined(QuotaChangeRequestVersion))
            {
                writer.WritePropertyName("quotaChangeRequestVersion");
                writer.WriteStringValue(QuotaChangeRequestVersion);
            }
            if (Optional.IsCollectionDefined(QuotaChangeRequests))
            {
                writer.WritePropertyName("quotaChangeRequests");
                writer.WriteStartArray();
                foreach (var item in QuotaChangeRequests)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static QuotaTicketDetails DeserializeQuotaTicketDetails(JsonElement element)
        {
            Optional<string> quotaChangeRequestSubType = default;
            Optional<string> quotaChangeRequestVersion = default;
            Optional<IList<SupportQuotaChangeContent>> quotaChangeRequests = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("quotaChangeRequestSubType"))
                {
                    quotaChangeRequestSubType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("quotaChangeRequestVersion"))
                {
                    quotaChangeRequestVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("quotaChangeRequests"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<SupportQuotaChangeContent> array = new List<SupportQuotaChangeContent>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SupportQuotaChangeContent.DeserializeSupportQuotaChangeContent(item));
                    }
                    quotaChangeRequests = array;
                    continue;
                }
            }
            return new QuotaTicketDetails(quotaChangeRequestSubType.Value, quotaChangeRequestVersion.Value, Optional.ToList(quotaChangeRequests));
        }
    }
}
