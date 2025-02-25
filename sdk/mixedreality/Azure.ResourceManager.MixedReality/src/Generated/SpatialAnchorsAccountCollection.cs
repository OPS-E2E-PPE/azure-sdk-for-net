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

namespace Azure.ResourceManager.MixedReality
{
    /// <summary>
    /// A class representing a collection of <see cref="SpatialAnchorsAccountResource" /> and their operations.
    /// Each <see cref="SpatialAnchorsAccountResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get a <see cref="SpatialAnchorsAccountCollection" /> instance call the GetSpatialAnchorsAccounts method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class SpatialAnchorsAccountCollection : ArmCollection, IEnumerable<SpatialAnchorsAccountResource>, IAsyncEnumerable<SpatialAnchorsAccountResource>
    {
        private readonly ClientDiagnostics _spatialAnchorsAccountClientDiagnostics;
        private readonly SpatialAnchorsAccountsRestOperations _spatialAnchorsAccountRestClient;

        /// <summary> Initializes a new instance of the <see cref="SpatialAnchorsAccountCollection"/> class for mocking. </summary>
        protected SpatialAnchorsAccountCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SpatialAnchorsAccountCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SpatialAnchorsAccountCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _spatialAnchorsAccountClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.MixedReality", SpatialAnchorsAccountResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SpatialAnchorsAccountResource.ResourceType, out string spatialAnchorsAccountApiVersion);
            _spatialAnchorsAccountRestClient = new SpatialAnchorsAccountsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, spatialAnchorsAccountApiVersion);
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
        /// Creating or Updating a Spatial Anchors Account.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MixedReality/spatialAnchorsAccounts/{accountName}
        /// Operation Id: SpatialAnchorsAccounts_Create
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="accountName"> Name of an Mixed Reality Account. </param>
        /// <param name="data"> Spatial Anchors Account parameter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="accountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<SpatialAnchorsAccountResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string accountName, SpatialAnchorsAccountData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _spatialAnchorsAccountClientDiagnostics.CreateScope("SpatialAnchorsAccountCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _spatialAnchorsAccountRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, accountName, data, cancellationToken).ConfigureAwait(false);
                var operation = new MixedRealityArmOperation<SpatialAnchorsAccountResource>(Response.FromValue(new SpatialAnchorsAccountResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creating or Updating a Spatial Anchors Account.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MixedReality/spatialAnchorsAccounts/{accountName}
        /// Operation Id: SpatialAnchorsAccounts_Create
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="accountName"> Name of an Mixed Reality Account. </param>
        /// <param name="data"> Spatial Anchors Account parameter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="accountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<SpatialAnchorsAccountResource> CreateOrUpdate(WaitUntil waitUntil, string accountName, SpatialAnchorsAccountData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _spatialAnchorsAccountClientDiagnostics.CreateScope("SpatialAnchorsAccountCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _spatialAnchorsAccountRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, accountName, data, cancellationToken);
                var operation = new MixedRealityArmOperation<SpatialAnchorsAccountResource>(Response.FromValue(new SpatialAnchorsAccountResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieve a Spatial Anchors Account.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MixedReality/spatialAnchorsAccounts/{accountName}
        /// Operation Id: SpatialAnchorsAccounts_Get
        /// </summary>
        /// <param name="accountName"> Name of an Mixed Reality Account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="accountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> is null. </exception>
        public virtual async Task<Response<SpatialAnchorsAccountResource>> GetAsync(string accountName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));

            using var scope = _spatialAnchorsAccountClientDiagnostics.CreateScope("SpatialAnchorsAccountCollection.Get");
            scope.Start();
            try
            {
                var response = await _spatialAnchorsAccountRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, accountName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SpatialAnchorsAccountResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieve a Spatial Anchors Account.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MixedReality/spatialAnchorsAccounts/{accountName}
        /// Operation Id: SpatialAnchorsAccounts_Get
        /// </summary>
        /// <param name="accountName"> Name of an Mixed Reality Account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="accountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> is null. </exception>
        public virtual Response<SpatialAnchorsAccountResource> Get(string accountName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));

            using var scope = _spatialAnchorsAccountClientDiagnostics.CreateScope("SpatialAnchorsAccountCollection.Get");
            scope.Start();
            try
            {
                var response = _spatialAnchorsAccountRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, accountName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SpatialAnchorsAccountResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List Resources by Resource Group
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MixedReality/spatialAnchorsAccounts
        /// Operation Id: SpatialAnchorsAccounts_ListByResourceGroup
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SpatialAnchorsAccountResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SpatialAnchorsAccountResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<SpatialAnchorsAccountResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _spatialAnchorsAccountClientDiagnostics.CreateScope("SpatialAnchorsAccountCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _spatialAnchorsAccountRestClient.ListByResourceGroupAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SpatialAnchorsAccountResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<SpatialAnchorsAccountResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _spatialAnchorsAccountClientDiagnostics.CreateScope("SpatialAnchorsAccountCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _spatialAnchorsAccountRestClient.ListByResourceGroupNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SpatialAnchorsAccountResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// List Resources by Resource Group
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MixedReality/spatialAnchorsAccounts
        /// Operation Id: SpatialAnchorsAccounts_ListByResourceGroup
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SpatialAnchorsAccountResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SpatialAnchorsAccountResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<SpatialAnchorsAccountResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _spatialAnchorsAccountClientDiagnostics.CreateScope("SpatialAnchorsAccountCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _spatialAnchorsAccountRestClient.ListByResourceGroup(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SpatialAnchorsAccountResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<SpatialAnchorsAccountResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _spatialAnchorsAccountClientDiagnostics.CreateScope("SpatialAnchorsAccountCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _spatialAnchorsAccountRestClient.ListByResourceGroupNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SpatialAnchorsAccountResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MixedReality/spatialAnchorsAccounts/{accountName}
        /// Operation Id: SpatialAnchorsAccounts_Get
        /// </summary>
        /// <param name="accountName"> Name of an Mixed Reality Account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="accountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string accountName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));

            using var scope = _spatialAnchorsAccountClientDiagnostics.CreateScope("SpatialAnchorsAccountCollection.Exists");
            scope.Start();
            try
            {
                var response = await _spatialAnchorsAccountRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, accountName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MixedReality/spatialAnchorsAccounts/{accountName}
        /// Operation Id: SpatialAnchorsAccounts_Get
        /// </summary>
        /// <param name="accountName"> Name of an Mixed Reality Account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="accountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> is null. </exception>
        public virtual Response<bool> Exists(string accountName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));

            using var scope = _spatialAnchorsAccountClientDiagnostics.CreateScope("SpatialAnchorsAccountCollection.Exists");
            scope.Start();
            try
            {
                var response = _spatialAnchorsAccountRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, accountName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SpatialAnchorsAccountResource> IEnumerable<SpatialAnchorsAccountResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SpatialAnchorsAccountResource> IAsyncEnumerable<SpatialAnchorsAccountResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
