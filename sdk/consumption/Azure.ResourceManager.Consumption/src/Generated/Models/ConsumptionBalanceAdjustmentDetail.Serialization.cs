// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Consumption.Models
{
    public partial class ConsumptionBalanceAdjustmentDetail
    {
        internal static ConsumptionBalanceAdjustmentDetail DeserializeConsumptionBalanceAdjustmentDetail(JsonElement element)
        {
            Optional<string> name = default;
            Optional<decimal> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    value = property.Value.GetDecimal();
                    continue;
                }
            }
            return new ConsumptionBalanceAdjustmentDetail(name.Value, Optional.ToNullable(value));
        }
    }
}
