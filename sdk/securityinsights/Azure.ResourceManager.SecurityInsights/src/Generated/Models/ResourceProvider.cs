// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> Resource provider permissions required for the connector. </summary>
    public partial class ResourceProvider
    {
        /// <summary> Initializes a new instance of ResourceProvider. </summary>
        public ResourceProvider()
        {
        }

        /// <summary> Initializes a new instance of ResourceProvider. </summary>
        /// <param name="provider"> Provider name. </param>
        /// <param name="permissionsDisplayText"> Permission description text. </param>
        /// <param name="providerDisplayName"> Permission provider display name. </param>
        /// <param name="scope"> Permission provider scope. </param>
        /// <param name="requiredPermissions"> Required permissions for the connector. </param>
        internal ResourceProvider(ProviderName? provider, string permissionsDisplayText, string providerDisplayName, PermissionProviderScope? scope, RequiredPermissions requiredPermissions)
        {
            Provider = provider;
            PermissionsDisplayText = permissionsDisplayText;
            ProviderDisplayName = providerDisplayName;
            Scope = scope;
            RequiredPermissions = requiredPermissions;
        }

        /// <summary> Provider name. </summary>
        public ProviderName? Provider { get; set; }
        /// <summary> Permission description text. </summary>
        public string PermissionsDisplayText { get; set; }
        /// <summary> Permission provider display name. </summary>
        public string ProviderDisplayName { get; set; }
        /// <summary> Permission provider scope. </summary>
        public PermissionProviderScope? Scope { get; set; }
        /// <summary> Required permissions for the connector. </summary>
        public RequiredPermissions RequiredPermissions { get; set; }
    }
}
