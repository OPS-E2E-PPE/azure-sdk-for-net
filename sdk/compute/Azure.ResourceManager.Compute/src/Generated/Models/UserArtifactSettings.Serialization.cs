// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class UserArtifactSettings : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(PackageFileName))
            {
                writer.WritePropertyName("packageFileName");
                writer.WriteStringValue(PackageFileName);
            }
            if (Optional.IsDefined(ConfigFileName))
            {
                writer.WritePropertyName("configFileName");
                writer.WriteStringValue(ConfigFileName);
            }
            writer.WriteEndObject();
        }

        internal static UserArtifactSettings DeserializeUserArtifactSettings(JsonElement element)
        {
            Optional<string> packageFileName = default;
            Optional<string> configFileName = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("packageFileName"))
                {
                    packageFileName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("configFileName"))
                {
                    configFileName = property.Value.GetString();
                    continue;
                }
            }
            return new UserArtifactSettings(packageFileName.Value, configFileName.Value);
        }
    }
}
