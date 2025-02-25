// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.SecurityInsights;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> The incident related entities response. </summary>
    public partial class IncidentEntitiesResponse
    {
        /// <summary> Initializes a new instance of IncidentEntitiesResponse. </summary>
        internal IncidentEntitiesResponse()
        {
            Entities = new ChangeTrackingList<EntityData>();
            MetaData = new ChangeTrackingList<IncidentEntitiesResultsMetadata>();
        }

        /// <summary> Initializes a new instance of IncidentEntitiesResponse. </summary>
        /// <param name="entities">
        /// Array of the incident related entities.
        /// Please note <see cref="EntityData"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AccountEntity"/>, <see cref="AzureResourceEntity"/>, <see cref="HuntingBookmark"/>, <see cref="CloudApplicationEntity"/>, <see cref="DnsEntity"/>, <see cref="FileEntity"/>, <see cref="FileHashEntity"/>, <see cref="HostEntity"/>, <see cref="IoTDeviceEntity"/>, <see cref="IPEntity"/>, <see cref="MailClusterEntity"/>, <see cref="MailMessageEntity"/>, <see cref="MailboxEntity"/>, <see cref="MalwareEntity"/>, <see cref="NicEntity"/>, <see cref="ProcessEntity"/>, <see cref="RegistryKeyEntity"/>, <see cref="RegistryValueEntity"/>, <see cref="SecurityAlert"/>, <see cref="SecurityGroupEntity"/>, <see cref="SubmissionMailEntity"/> and <see cref="UrlEntity"/>.
        /// </param>
        /// <param name="metaData"> The metadata from the incident related entities results. </param>
        internal IncidentEntitiesResponse(IReadOnlyList<EntityData> entities, IReadOnlyList<IncidentEntitiesResultsMetadata> metaData)
        {
            Entities = entities;
            MetaData = metaData;
        }

        /// <summary>
        /// Array of the incident related entities.
        /// Please note <see cref="EntityData"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AccountEntity"/>, <see cref="AzureResourceEntity"/>, <see cref="HuntingBookmark"/>, <see cref="CloudApplicationEntity"/>, <see cref="DnsEntity"/>, <see cref="FileEntity"/>, <see cref="FileHashEntity"/>, <see cref="HostEntity"/>, <see cref="IoTDeviceEntity"/>, <see cref="IPEntity"/>, <see cref="MailClusterEntity"/>, <see cref="MailMessageEntity"/>, <see cref="MailboxEntity"/>, <see cref="MalwareEntity"/>, <see cref="NicEntity"/>, <see cref="ProcessEntity"/>, <see cref="RegistryKeyEntity"/>, <see cref="RegistryValueEntity"/>, <see cref="SecurityAlert"/>, <see cref="SecurityGroupEntity"/>, <see cref="SubmissionMailEntity"/> and <see cref="UrlEntity"/>.
        /// </summary>
        public IReadOnlyList<EntityData> Entities { get; }
        /// <summary> The metadata from the incident related entities results. </summary>
        public IReadOnlyList<IncidentEntitiesResultsMetadata> MetaData { get; }
    }
}
