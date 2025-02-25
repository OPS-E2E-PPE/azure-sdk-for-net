// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Support.Models
{
    internal static partial class SupportResourceTypeExtensions
    {
        public static string ToSerialString(this SupportResourceType value) => value switch
        {
            SupportResourceType.MicrosoftSupportSupportTickets => "Microsoft.Support/supportTickets",
            SupportResourceType.MicrosoftSupportCommunications => "Microsoft.Support/communications",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown SupportResourceType value.")
        };

        public static SupportResourceType ToSupportResourceType(this string value)
        {
            if (string.Equals(value, "Microsoft.Support/supportTickets", StringComparison.InvariantCultureIgnoreCase)) return SupportResourceType.MicrosoftSupportSupportTickets;
            if (string.Equals(value, "Microsoft.Support/communications", StringComparison.InvariantCultureIgnoreCase)) return SupportResourceType.MicrosoftSupportCommunications;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown SupportResourceType value.");
        }
    }
}
