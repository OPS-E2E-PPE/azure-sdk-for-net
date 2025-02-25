// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    /// <summary> The UnknownDataProtectionBasePolicyRule. </summary>
    internal partial class UnknownDataProtectionBasePolicyRule : DataProtectionBasePolicyRule
    {
        /// <summary> Initializes a new instance of UnknownDataProtectionBasePolicyRule. </summary>
        /// <param name="name"></param>
        /// <param name="objectType"></param>
        internal UnknownDataProtectionBasePolicyRule(string name, string objectType) : base(name, objectType)
        {
            ObjectType = objectType ?? "Unknown";
        }
    }
}
