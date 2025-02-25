// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    /// <summary> The UnknownDataProtectionBackupTriggerContext. </summary>
    internal partial class UnknownDataProtectionBackupTriggerContext : DataProtectionBackupTriggerContext
    {
        /// <summary> Initializes a new instance of UnknownDataProtectionBackupTriggerContext. </summary>
        /// <param name="objectType"> Type of the specific object - used for deserializing. </param>
        internal UnknownDataProtectionBackupTriggerContext(string objectType) : base(objectType)
        {
            ObjectType = objectType ?? "Unknown";
        }
    }
}
