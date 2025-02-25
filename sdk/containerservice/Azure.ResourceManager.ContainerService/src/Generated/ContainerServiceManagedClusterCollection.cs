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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.ContainerService
{
    /// <summary>
    /// A class representing a collection of <see cref="ContainerServiceManagedClusterResource" /> and their operations.
    /// Each <see cref="ContainerServiceManagedClusterResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get a <see cref="ContainerServiceManagedClusterCollection" /> instance call the GetContainerServiceManagedClusters method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class ContainerServiceManagedClusterCollection : ArmCollection, IEnumerable<ContainerServiceManagedClusterResource>, IAsyncEnumerable<ContainerServiceManagedClusterResource>
    {
        private readonly ClientDiagnostics _containerServiceManagedClusterManagedClustersClientDiagnostics;
        private readonly ManagedClustersRestOperations _containerServiceManagedClusterManagedClustersRestClient;

        /// <summary> Initializes a new instance of the <see cref="ContainerServiceManagedClusterCollection"/> class for mocking. </summary>
        protected ContainerServiceManagedClusterCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ContainerServiceManagedClusterCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ContainerServiceManagedClusterCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _containerServiceManagedClusterManagedClustersClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ContainerService", ContainerServiceManagedClusterResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ContainerServiceManagedClusterResource.ResourceType, out string containerServiceManagedClusterManagedClustersApiVersion);
            _containerServiceManagedClusterManagedClustersRestClient = new ManagedClustersRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, containerServiceManagedClusterManagedClustersApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets a managed cluster.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/managedClusters/{resourceName}
        /// Operation Id: ManagedClusters_Get
        /// </summary>
        /// <param name="resourceName"> The name of the managed cluster resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> is null. </exception>
        public virtual async Task<Response<ContainerServiceManagedClusterResource>> GetAsync(string resourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resourceName, nameof(resourceName));

            using var scope = _containerServiceManagedClusterManagedClustersClientDiagnostics.CreateScope("ContainerServiceManagedClusterCollection.Get");
            scope.Start();
            try
            {
                var response = await _containerServiceManagedClusterManagedClustersRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, resourceName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ContainerServiceManagedClusterResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a managed cluster.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/managedClusters/{resourceName}
        /// Operation Id: ManagedClusters_Get
        /// </summary>
        /// <param name="resourceName"> The name of the managed cluster resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> is null. </exception>
        public virtual Response<ContainerServiceManagedClusterResource> Get(string resourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resourceName, nameof(resourceName));

            using var scope = _containerServiceManagedClusterManagedClustersClientDiagnostics.CreateScope("ContainerServiceManagedClusterCollection.Get");
            scope.Start();
            try
            {
                var response = _containerServiceManagedClusterManagedClustersRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, resourceName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ContainerServiceManagedClusterResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists managed clusters in the specified subscription and resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/managedClusters
        /// Operation Id: ManagedClusters_ListByResourceGroup
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ContainerServiceManagedClusterResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ContainerServiceManagedClusterResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<ContainerServiceManagedClusterResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _containerServiceManagedClusterManagedClustersClientDiagnostics.CreateScope("ContainerServiceManagedClusterCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _containerServiceManagedClusterManagedClustersRestClient.ListByResourceGroupAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ContainerServiceManagedClusterResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ContainerServiceManagedClusterResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _containerServiceManagedClusterManagedClustersClientDiagnostics.CreateScope("ContainerServiceManagedClusterCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _containerServiceManagedClusterManagedClustersRestClient.ListByResourceGroupNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ContainerServiceManagedClusterResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Lists managed clusters in the specified subscription and resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/managedClusters
        /// Operation Id: ManagedClusters_ListByResourceGroup
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ContainerServiceManagedClusterResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ContainerServiceManagedClusterResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<ContainerServiceManagedClusterResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _containerServiceManagedClusterManagedClustersClientDiagnostics.CreateScope("ContainerServiceManagedClusterCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _containerServiceManagedClusterManagedClustersRestClient.ListByResourceGroup(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ContainerServiceManagedClusterResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ContainerServiceManagedClusterResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _containerServiceManagedClusterManagedClustersClientDiagnostics.CreateScope("ContainerServiceManagedClusterCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _containerServiceManagedClusterManagedClustersRestClient.ListByResourceGroupNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ContainerServiceManagedClusterResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/managedClusters/{resourceName}
        /// Operation Id: ManagedClusters_Get
        /// </summary>
        /// <param name="resourceName"> The name of the managed cluster resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string resourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resourceName, nameof(resourceName));

            using var scope = _containerServiceManagedClusterManagedClustersClientDiagnostics.CreateScope("ContainerServiceManagedClusterCollection.Exists");
            scope.Start();
            try
            {
                var response = await _containerServiceManagedClusterManagedClustersRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, resourceName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/managedClusters/{resourceName}
        /// Operation Id: ManagedClusters_Get
        /// </summary>
        /// <param name="resourceName"> The name of the managed cluster resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> is null. </exception>
        public virtual Response<bool> Exists(string resourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resourceName, nameof(resourceName));

            using var scope = _containerServiceManagedClusterManagedClustersClientDiagnostics.CreateScope("ContainerServiceManagedClusterCollection.Exists");
            scope.Start();
            try
            {
                var response = _containerServiceManagedClusterManagedClustersRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, resourceName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ContainerServiceManagedClusterResource> IEnumerable<ContainerServiceManagedClusterResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ContainerServiceManagedClusterResource> IAsyncEnumerable<ContainerServiceManagedClusterResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
