// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Storage.Models
{
    internal static partial class StorageAccountHttpProtocolExtensions
    {
        public static string ToSerialString(this StorageAccountHttpProtocol value) => value switch
        {
            StorageAccountHttpProtocol.HttpsHttp => "https,http",
            StorageAccountHttpProtocol.Https => "https",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown StorageAccountHttpProtocol value.")
        };

        public static StorageAccountHttpProtocol ToStorageAccountHttpProtocol(this string value)
        {
            if (string.Equals(value, "https,http", StringComparison.InvariantCultureIgnoreCase)) return StorageAccountHttpProtocol.HttpsHttp;
            if (string.Equals(value, "https", StringComparison.InvariantCultureIgnoreCase)) return StorageAccountHttpProtocol.Https;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown StorageAccountHttpProtocol value.");
        }
    }
}
