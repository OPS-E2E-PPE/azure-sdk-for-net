// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Models
{
    public partial class HDInsightBillingSpecsListResult
    {
        internal static HDInsightBillingSpecsListResult DeserializeHDInsightBillingSpecsListResult(JsonElement element)
        {
            Optional<IReadOnlyList<string>> vmSizes = default;
            Optional<IReadOnlyList<string>> vmSizesWithEncryptionAtHost = default;
            Optional<IReadOnlyList<HDInsightVmSizeCompatibilityFilterV2>> vmSizeFilters = default;
            Optional<IReadOnlyList<HDInsightVmSizeProperty>> vmSizeProperties = default;
            Optional<IReadOnlyList<HDInsightBillingResources>> billingResources = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("vmSizes"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    vmSizes = array;
                    continue;
                }
                if (property.NameEquals("vmSizesWithEncryptionAtHost"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    vmSizesWithEncryptionAtHost = array;
                    continue;
                }
                if (property.NameEquals("vmSizeFilters"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<HDInsightVmSizeCompatibilityFilterV2> array = new List<HDInsightVmSizeCompatibilityFilterV2>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(HDInsightVmSizeCompatibilityFilterV2.DeserializeHDInsightVmSizeCompatibilityFilterV2(item));
                    }
                    vmSizeFilters = array;
                    continue;
                }
                if (property.NameEquals("vmSizeProperties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<HDInsightVmSizeProperty> array = new List<HDInsightVmSizeProperty>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(HDInsightVmSizeProperty.DeserializeHDInsightVmSizeProperty(item));
                    }
                    vmSizeProperties = array;
                    continue;
                }
                if (property.NameEquals("billingResources"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<HDInsightBillingResources> array = new List<HDInsightBillingResources>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(HDInsightBillingResources.DeserializeHDInsightBillingResources(item));
                    }
                    billingResources = array;
                    continue;
                }
            }
            return new HDInsightBillingSpecsListResult(Optional.ToList(vmSizes), Optional.ToList(vmSizesWithEncryptionAtHost), Optional.ToList(vmSizeFilters), Optional.ToList(vmSizeProperties), Optional.ToList(billingResources));
        }
    }
}
