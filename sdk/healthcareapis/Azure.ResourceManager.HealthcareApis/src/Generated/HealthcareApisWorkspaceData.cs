// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.HealthcareApis.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.HealthcareApis
{
    /// <summary> A class representing the HealthcareApisWorkspace data model. </summary>
    public partial class HealthcareApisWorkspaceData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of HealthcareApisWorkspaceData. </summary>
        /// <param name="location"> The location. </param>
        public HealthcareApisWorkspaceData(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of HealthcareApisWorkspaceData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="properties"> Workspaces resource specific properties. </param>
        /// <param name="etag"> An etag associated with the resource, used for optimistic concurrency when editing it. </param>
        internal HealthcareApisWorkspaceData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, HealthcareApisWorkspaceProperties properties, ETag? etag) : base(id, name, resourceType, systemData, tags, location)
        {
            Properties = properties;
            ETag = etag;
        }

        /// <summary> Workspaces resource specific properties. </summary>
        public HealthcareApisWorkspaceProperties Properties { get; set; }
        /// <summary> An etag associated with the resource, used for optimistic concurrency when editing it. </summary>
        public ETag? ETag { get; set; }
    }
}
