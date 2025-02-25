// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Avs
{
    /// <summary>
    /// A class representing a collection of <see cref="WorkloadNetworkGatewayResource" /> and their operations.
    /// Each <see cref="WorkloadNetworkGatewayResource" /> in the collection will belong to the same instance of <see cref="AvsPrivateCloudResource" />.
    /// To get a <see cref="WorkloadNetworkGatewayCollection" /> instance call the GetWorkloadNetworkGateways method from an instance of <see cref="AvsPrivateCloudResource" />.
    /// </summary>
    public partial class WorkloadNetworkGatewayCollection : ArmCollection, IEnumerable<WorkloadNetworkGatewayResource>, IAsyncEnumerable<WorkloadNetworkGatewayResource>
    {
        private readonly ClientDiagnostics _workloadNetworkGatewayWorkloadNetworksClientDiagnostics;
        private readonly WorkloadNetworksRestOperations _workloadNetworkGatewayWorkloadNetworksRestClient;

        /// <summary> Initializes a new instance of the <see cref="WorkloadNetworkGatewayCollection"/> class for mocking. </summary>
        protected WorkloadNetworkGatewayCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="WorkloadNetworkGatewayCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal WorkloadNetworkGatewayCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _workloadNetworkGatewayWorkloadNetworksClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Avs", WorkloadNetworkGatewayResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(WorkloadNetworkGatewayResource.ResourceType, out string workloadNetworkGatewayWorkloadNetworksApiVersion);
            _workloadNetworkGatewayWorkloadNetworksRestClient = new WorkloadNetworksRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, workloadNetworkGatewayWorkloadNetworksApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != AvsPrivateCloudResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, AvsPrivateCloudResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Get a gateway by id in a private cloud workload network.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/workloadNetworks/default/gateways/{gatewayId}
        /// Operation Id: WorkloadNetworks_GetGateway
        /// </summary>
        /// <param name="gatewayId"> NSX Gateway identifier. Generally the same as the Gateway&apos;s display name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="gatewayId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="gatewayId"/> is null. </exception>
        public virtual async Task<Response<WorkloadNetworkGatewayResource>> GetAsync(string gatewayId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(gatewayId, nameof(gatewayId));

            using var scope = _workloadNetworkGatewayWorkloadNetworksClientDiagnostics.CreateScope("WorkloadNetworkGatewayCollection.Get");
            scope.Start();
            try
            {
                var response = await _workloadNetworkGatewayWorkloadNetworksRestClient.GetGatewayAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, gatewayId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new WorkloadNetworkGatewayResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a gateway by id in a private cloud workload network.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/workloadNetworks/default/gateways/{gatewayId}
        /// Operation Id: WorkloadNetworks_GetGateway
        /// </summary>
        /// <param name="gatewayId"> NSX Gateway identifier. Generally the same as the Gateway&apos;s display name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="gatewayId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="gatewayId"/> is null. </exception>
        public virtual Response<WorkloadNetworkGatewayResource> Get(string gatewayId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(gatewayId, nameof(gatewayId));

            using var scope = _workloadNetworkGatewayWorkloadNetworksClientDiagnostics.CreateScope("WorkloadNetworkGatewayCollection.Get");
            scope.Start();
            try
            {
                var response = _workloadNetworkGatewayWorkloadNetworksRestClient.GetGateway(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, gatewayId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new WorkloadNetworkGatewayResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List of gateways in a private cloud workload network.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/workloadNetworks/default/gateways
        /// Operation Id: WorkloadNetworks_ListGateways
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="WorkloadNetworkGatewayResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<WorkloadNetworkGatewayResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<WorkloadNetworkGatewayResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _workloadNetworkGatewayWorkloadNetworksClientDiagnostics.CreateScope("WorkloadNetworkGatewayCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _workloadNetworkGatewayWorkloadNetworksRestClient.ListGatewaysAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new WorkloadNetworkGatewayResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<WorkloadNetworkGatewayResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _workloadNetworkGatewayWorkloadNetworksClientDiagnostics.CreateScope("WorkloadNetworkGatewayCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _workloadNetworkGatewayWorkloadNetworksRestClient.ListGatewaysNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new WorkloadNetworkGatewayResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// List of gateways in a private cloud workload network.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/workloadNetworks/default/gateways
        /// Operation Id: WorkloadNetworks_ListGateways
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="WorkloadNetworkGatewayResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<WorkloadNetworkGatewayResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<WorkloadNetworkGatewayResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _workloadNetworkGatewayWorkloadNetworksClientDiagnostics.CreateScope("WorkloadNetworkGatewayCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _workloadNetworkGatewayWorkloadNetworksRestClient.ListGateways(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new WorkloadNetworkGatewayResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<WorkloadNetworkGatewayResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _workloadNetworkGatewayWorkloadNetworksClientDiagnostics.CreateScope("WorkloadNetworkGatewayCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _workloadNetworkGatewayWorkloadNetworksRestClient.ListGatewaysNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new WorkloadNetworkGatewayResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/workloadNetworks/default/gateways/{gatewayId}
        /// Operation Id: WorkloadNetworks_GetGateway
        /// </summary>
        /// <param name="gatewayId"> NSX Gateway identifier. Generally the same as the Gateway&apos;s display name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="gatewayId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="gatewayId"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string gatewayId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(gatewayId, nameof(gatewayId));

            using var scope = _workloadNetworkGatewayWorkloadNetworksClientDiagnostics.CreateScope("WorkloadNetworkGatewayCollection.Exists");
            scope.Start();
            try
            {
                var response = await _workloadNetworkGatewayWorkloadNetworksRestClient.GetGatewayAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, gatewayId, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/workloadNetworks/default/gateways/{gatewayId}
        /// Operation Id: WorkloadNetworks_GetGateway
        /// </summary>
        /// <param name="gatewayId"> NSX Gateway identifier. Generally the same as the Gateway&apos;s display name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="gatewayId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="gatewayId"/> is null. </exception>
        public virtual Response<bool> Exists(string gatewayId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(gatewayId, nameof(gatewayId));

            using var scope = _workloadNetworkGatewayWorkloadNetworksClientDiagnostics.CreateScope("WorkloadNetworkGatewayCollection.Exists");
            scope.Start();
            try
            {
                var response = _workloadNetworkGatewayWorkloadNetworksRestClient.GetGateway(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, gatewayId, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<WorkloadNetworkGatewayResource> IEnumerable<WorkloadNetworkGatewayResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<WorkloadNetworkGatewayResource> IAsyncEnumerable<WorkloadNetworkGatewayResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
