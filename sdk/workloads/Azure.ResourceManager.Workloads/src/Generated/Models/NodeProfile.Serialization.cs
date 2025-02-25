// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Workloads.Models
{
    public partial class NodeProfile : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            writer.WritePropertyName("nodeSku");
            writer.WriteStringValue(NodeSku);
            writer.WritePropertyName("osImage");
            writer.WriteObjectValue(OSImage);
            writer.WritePropertyName("osDisk");
            writer.WriteObjectValue(OSDisk);
            if (Optional.IsCollectionDefined(DataDisks))
            {
                writer.WritePropertyName("dataDisks");
                writer.WriteStartArray();
                foreach (var item in DataDisks)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static NodeProfile DeserializeNodeProfile(JsonElement element)
        {
            Optional<string> name = default;
            string nodeSku = default;
            OSImageProfile osImage = default;
            DiskInfo osDisk = default;
            Optional<IList<DiskInfo>> dataDisks = default;
            Optional<IReadOnlyList<ResourceIdentifier>> nodeResourceIds = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("nodeSku"))
                {
                    nodeSku = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("osImage"))
                {
                    osImage = OSImageProfile.DeserializeOSImageProfile(property.Value);
                    continue;
                }
                if (property.NameEquals("osDisk"))
                {
                    osDisk = DiskInfo.DeserializeDiskInfo(property.Value);
                    continue;
                }
                if (property.NameEquals("dataDisks"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<DiskInfo> array = new List<DiskInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DiskInfo.DeserializeDiskInfo(item));
                    }
                    dataDisks = array;
                    continue;
                }
                if (property.NameEquals("nodeResourceIds"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ResourceIdentifier> array = new List<ResourceIdentifier>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new ResourceIdentifier(item.GetString()));
                    }
                    nodeResourceIds = array;
                    continue;
                }
            }
            return new NodeProfile(name.Value, nodeSku, osImage, osDisk, Optional.ToList(dataDisks), Optional.ToList(nodeResourceIds));
        }
    }
}
