// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.HealthcareApis.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.HealthcareApis
{
    /// <summary> A class representing the DicomService data model. </summary>
    public partial class DicomServiceData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of DicomServiceData. </summary>
        /// <param name="location"> The location. </param>
        public DicomServiceData(AzureLocation location) : base(location)
        {
            PrivateEndpointConnections = new ChangeTrackingList<HealthcareApisPrivateEndpointConnectionData>();
        }

        /// <summary> Initializes a new instance of DicomServiceData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="provisioningState"> The provisioning state. </param>
        /// <param name="authenticationConfiguration"> Dicom Service authentication configuration. </param>
        /// <param name="corsConfiguration"> Dicom Service Cors configuration. </param>
        /// <param name="serviceUri"> The url of the Dicom Services. </param>
        /// <param name="privateEndpointConnections"> The list of private endpoint connections that are set up for this resource. </param>
        /// <param name="publicNetworkAccess"> Control permission for data plane traffic coming from public networks while private endpoint is enabled. </param>
        /// <param name="identity"> Setting indicating whether the service has a managed identity associated with it. </param>
        /// <param name="etag"> An etag associated with the resource, used for optimistic concurrency when editing it. </param>
        internal DicomServiceData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, HealthcareApisProvisioningState? provisioningState, DicomServiceAuthenticationConfiguration authenticationConfiguration, DicomServiceCorsConfiguration corsConfiguration, Uri serviceUri, IReadOnlyList<HealthcareApisPrivateEndpointConnectionData> privateEndpointConnections, HealthcareApisPublicNetworkAccess? publicNetworkAccess, ManagedServiceIdentity identity, ETag? etag) : base(id, name, resourceType, systemData, tags, location)
        {
            ProvisioningState = provisioningState;
            AuthenticationConfiguration = authenticationConfiguration;
            CorsConfiguration = corsConfiguration;
            ServiceUri = serviceUri;
            PrivateEndpointConnections = privateEndpointConnections;
            PublicNetworkAccess = publicNetworkAccess;
            Identity = identity;
            ETag = etag;
        }

        /// <summary> The provisioning state. </summary>
        public HealthcareApisProvisioningState? ProvisioningState { get; }
        /// <summary> Dicom Service authentication configuration. </summary>
        public DicomServiceAuthenticationConfiguration AuthenticationConfiguration { get; set; }
        /// <summary> Dicom Service Cors configuration. </summary>
        public DicomServiceCorsConfiguration CorsConfiguration { get; set; }
        /// <summary> The url of the Dicom Services. </summary>
        public Uri ServiceUri { get; }
        /// <summary> The list of private endpoint connections that are set up for this resource. </summary>
        public IReadOnlyList<HealthcareApisPrivateEndpointConnectionData> PrivateEndpointConnections { get; }
        /// <summary> Control permission for data plane traffic coming from public networks while private endpoint is enabled. </summary>
        public HealthcareApisPublicNetworkAccess? PublicNetworkAccess { get; set; }
        /// <summary> Setting indicating whether the service has a managed identity associated with it. </summary>
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> An etag associated with the resource, used for optimistic concurrency when editing it. </summary>
        public ETag? ETag { get; set; }
    }
}
