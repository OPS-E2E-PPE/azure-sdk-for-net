// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Workloads.Models
{
    public partial class SapSupportedResourceSkusResult
    {
        internal static SapSupportedResourceSkusResult DeserializeSapSupportedResourceSkusResult(JsonElement element)
        {
            Optional<IReadOnlyList<SapSupportedSku>> supportedSkus = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("supportedSkus"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<SapSupportedSku> array = new List<SapSupportedSku>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SapSupportedSku.DeserializeSapSupportedSku(item));
                    }
                    supportedSkus = array;
                    continue;
                }
            }
            return new SapSupportedResourceSkusResult(Optional.ToList(supportedSkus));
        }
    }
}
