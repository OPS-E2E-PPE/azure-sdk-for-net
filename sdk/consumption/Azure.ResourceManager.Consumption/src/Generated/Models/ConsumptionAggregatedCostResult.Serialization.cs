// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Consumption.Models
{
    public partial class ConsumptionAggregatedCostResult
    {
        internal static ConsumptionAggregatedCostResult DeserializeConsumptionAggregatedCostResult(JsonElement element)
        {
            Optional<ETag> etag = default;
            Optional<IReadOnlyDictionary<string, string>> tags = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> billingPeriodId = default;
            Optional<DateTimeOffset> usageStart = default;
            Optional<DateTimeOffset> usageEnd = default;
            Optional<decimal> azureCharges = default;
            Optional<decimal> marketplaceCharges = default;
            Optional<decimal> chargesBilledSeparately = default;
            Optional<string> currency = default;
            Optional<IReadOnlyList<ConsumptionAggregatedCostResult>> children = default;
            Optional<IReadOnlyList<string>> includedSubscriptions = default;
            Optional<IReadOnlyList<string>> excludedSubscriptions = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("etag"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    etag = new ETag(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("tags"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.ToString());
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("billingPeriodId"))
                        {
                            billingPeriodId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("usageStart"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            usageStart = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("usageEnd"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            usageEnd = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("azureCharges"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            azureCharges = property0.Value.GetDecimal();
                            continue;
                        }
                        if (property0.NameEquals("marketplaceCharges"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            marketplaceCharges = property0.Value.GetDecimal();
                            continue;
                        }
                        if (property0.NameEquals("chargesBilledSeparately"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            chargesBilledSeparately = property0.Value.GetDecimal();
                            continue;
                        }
                        if (property0.NameEquals("currency"))
                        {
                            currency = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("children"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<ConsumptionAggregatedCostResult> array = new List<ConsumptionAggregatedCostResult>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DeserializeConsumptionAggregatedCostResult(item));
                            }
                            children = array;
                            continue;
                        }
                        if (property0.NameEquals("includedSubscriptions"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            includedSubscriptions = array;
                            continue;
                        }
                        if (property0.NameEquals("excludedSubscriptions"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            excludedSubscriptions = array;
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ConsumptionAggregatedCostResult(id, name, type, systemData.Value, billingPeriodId.Value, Optional.ToNullable(usageStart), Optional.ToNullable(usageEnd), Optional.ToNullable(azureCharges), Optional.ToNullable(marketplaceCharges), Optional.ToNullable(chargesBilledSeparately), currency.Value, Optional.ToList(children), Optional.ToList(includedSubscriptions), Optional.ToList(excludedSubscriptions), Optional.ToNullable(etag), Optional.ToDictionary(tags));
        }
    }
}
