// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    public partial class GetUserTablesOracleTaskInput : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("connectionInfo");
            writer.WriteObjectValue(ConnectionInfo);
            writer.WritePropertyName("selectedSchemas");
            writer.WriteStartArray();
            foreach (var item in SelectedSchemas)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
            writer.WriteEndObject();
        }

        internal static GetUserTablesOracleTaskInput DeserializeGetUserTablesOracleTaskInput(JsonElement element)
        {
            OracleConnectionInfo connectionInfo = default;
            IList<string> selectedSchemas = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("connectionInfo"))
                {
                    connectionInfo = OracleConnectionInfo.DeserializeOracleConnectionInfo(property.Value);
                    continue;
                }
                if (property.NameEquals("selectedSchemas"))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    selectedSchemas = array;
                    continue;
                }
            }
            return new GetUserTablesOracleTaskInput(connectionInfo, selectedSchemas);
        }
    }
}
