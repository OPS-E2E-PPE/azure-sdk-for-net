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

namespace Azure.ResourceManager.AppService
{
    /// <summary>
    /// A class representing a collection of <see cref="SiteSlotProcessResource" /> and their operations.
    /// Each <see cref="SiteSlotProcessResource" /> in the collection will belong to the same instance of <see cref="WebSiteSlotResource" />.
    /// To get a <see cref="SiteSlotProcessCollection" /> instance call the GetSiteSlotProcesses method from an instance of <see cref="WebSiteSlotResource" />.
    /// </summary>
    public partial class SiteSlotProcessCollection : ArmCollection, IEnumerable<SiteSlotProcessResource>, IAsyncEnumerable<SiteSlotProcessResource>
    {
        private readonly ClientDiagnostics _siteSlotProcessWebAppsClientDiagnostics;
        private readonly WebAppsRestOperations _siteSlotProcessWebAppsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SiteSlotProcessCollection"/> class for mocking. </summary>
        protected SiteSlotProcessCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SiteSlotProcessCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SiteSlotProcessCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _siteSlotProcessWebAppsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", SiteSlotProcessResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SiteSlotProcessResource.ResourceType, out string siteSlotProcessWebAppsApiVersion);
            _siteSlotProcessWebAppsRestClient = new WebAppsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, siteSlotProcessWebAppsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != WebSiteSlotResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, WebSiteSlotResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Description for Get process information by its ID for a specific scaled-out instance in a web site.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/processes/{processId}
        /// Operation Id: WebApps_GetProcessSlot
        /// </summary>
        /// <param name="processId"> PID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="processId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="processId"/> is null. </exception>
        public virtual async Task<Response<SiteSlotProcessResource>> GetAsync(string processId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(processId, nameof(processId));

            using var scope = _siteSlotProcessWebAppsClientDiagnostics.CreateScope("SiteSlotProcessCollection.Get");
            scope.Start();
            try
            {
                var response = await _siteSlotProcessWebAppsRestClient.GetProcessSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, processId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteSlotProcessResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Get process information by its ID for a specific scaled-out instance in a web site.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/processes/{processId}
        /// Operation Id: WebApps_GetProcessSlot
        /// </summary>
        /// <param name="processId"> PID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="processId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="processId"/> is null. </exception>
        public virtual Response<SiteSlotProcessResource> Get(string processId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(processId, nameof(processId));

            using var scope = _siteSlotProcessWebAppsClientDiagnostics.CreateScope("SiteSlotProcessCollection.Get");
            scope.Start();
            try
            {
                var response = _siteSlotProcessWebAppsRestClient.GetProcessSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, processId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteSlotProcessResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Get list of processes for a web site, or a deployment slot, or for a specific scaled-out instance in a web site.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/processes
        /// Operation Id: WebApps_ListProcessesSlot
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SiteSlotProcessResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SiteSlotProcessResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<SiteSlotProcessResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _siteSlotProcessWebAppsClientDiagnostics.CreateScope("SiteSlotProcessCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _siteSlotProcessWebAppsRestClient.ListProcessesSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteSlotProcessResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<SiteSlotProcessResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _siteSlotProcessWebAppsClientDiagnostics.CreateScope("SiteSlotProcessCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _siteSlotProcessWebAppsRestClient.ListProcessesSlotNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteSlotProcessResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Description for Get list of processes for a web site, or a deployment slot, or for a specific scaled-out instance in a web site.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/processes
        /// Operation Id: WebApps_ListProcessesSlot
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SiteSlotProcessResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SiteSlotProcessResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<SiteSlotProcessResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _siteSlotProcessWebAppsClientDiagnostics.CreateScope("SiteSlotProcessCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _siteSlotProcessWebAppsRestClient.ListProcessesSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteSlotProcessResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<SiteSlotProcessResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _siteSlotProcessWebAppsClientDiagnostics.CreateScope("SiteSlotProcessCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _siteSlotProcessWebAppsRestClient.ListProcessesSlotNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteSlotProcessResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/processes/{processId}
        /// Operation Id: WebApps_GetProcessSlot
        /// </summary>
        /// <param name="processId"> PID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="processId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="processId"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string processId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(processId, nameof(processId));

            using var scope = _siteSlotProcessWebAppsClientDiagnostics.CreateScope("SiteSlotProcessCollection.Exists");
            scope.Start();
            try
            {
                var response = await _siteSlotProcessWebAppsRestClient.GetProcessSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, processId, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/processes/{processId}
        /// Operation Id: WebApps_GetProcessSlot
        /// </summary>
        /// <param name="processId"> PID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="processId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="processId"/> is null. </exception>
        public virtual Response<bool> Exists(string processId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(processId, nameof(processId));

            using var scope = _siteSlotProcessWebAppsClientDiagnostics.CreateScope("SiteSlotProcessCollection.Exists");
            scope.Start();
            try
            {
                var response = _siteSlotProcessWebAppsRestClient.GetProcessSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, processId, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SiteSlotProcessResource> IEnumerable<SiteSlotProcessResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SiteSlotProcessResource> IAsyncEnumerable<SiteSlotProcessResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
