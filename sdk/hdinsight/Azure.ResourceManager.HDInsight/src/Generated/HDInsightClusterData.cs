// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.HDInsight.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.HDInsight
{
    /// <summary> A class representing the HDInsightCluster data model. </summary>
    public partial class HDInsightClusterData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of HDInsightClusterData. </summary>
        /// <param name="location"> The location. </param>
        public HDInsightClusterData(AzureLocation location) : base(location)
        {
            Zones = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of HDInsightClusterData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="etag"> The ETag for the resource. </param>
        /// <param name="zones"> The availability zones. </param>
        /// <param name="properties"> The properties of the cluster. </param>
        /// <param name="identity"> The identity of the cluster, if configured. </param>
        internal HDInsightClusterData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, ETag? etag, IList<string> zones, HDInsightClusterProperties properties, ManagedServiceIdentity identity) : base(id, name, resourceType, systemData, tags, location)
        {
            ETag = etag;
            Zones = zones;
            Properties = properties;
            Identity = identity;
        }

        /// <summary> The ETag for the resource. </summary>
        public ETag? ETag { get; set; }
        /// <summary> The availability zones. </summary>
        public IList<string> Zones { get; }
        /// <summary> The properties of the cluster. </summary>
        public HDInsightClusterProperties Properties { get; set; }
        /// <summary> The identity of the cluster, if configured. </summary>
        public ManagedServiceIdentity Identity { get; set; }
    }
}
