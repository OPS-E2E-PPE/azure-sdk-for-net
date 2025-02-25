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

namespace Azure.ResourceManager.AppComplianceAutomation
{
    /// <summary>
    /// A class representing a collection of <see cref="SnapshotResource" /> and their operations.
    /// Each <see cref="SnapshotResource" /> in the collection will belong to the same instance of <see cref="ReportResource" />.
    /// To get a <see cref="SnapshotResourceCollection" /> instance call the GetSnapshotResources method from an instance of <see cref="ReportResource" />.
    /// </summary>
    public partial class SnapshotResourceCollection : ArmCollection, IEnumerable<SnapshotResource>, IAsyncEnumerable<SnapshotResource>
    {
        private readonly ClientDiagnostics _snapshotResourceSnapshotClientDiagnostics;
        private readonly SnapshotRestOperations _snapshotResourceSnapshotRestClient;
        private readonly ClientDiagnostics _snapshotResourceSnapshotsClientDiagnostics;
        private readonly SnapshotsRestOperations _snapshotResourceSnapshotsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SnapshotResourceCollection"/> class for mocking. </summary>
        protected SnapshotResourceCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SnapshotResourceCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SnapshotResourceCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _snapshotResourceSnapshotClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppComplianceAutomation", SnapshotResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SnapshotResource.ResourceType, out string snapshotResourceSnapshotApiVersion);
            _snapshotResourceSnapshotRestClient = new SnapshotRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, snapshotResourceSnapshotApiVersion);
            _snapshotResourceSnapshotsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppComplianceAutomation", SnapshotResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SnapshotResource.ResourceType, out string snapshotResourceSnapshotsApiVersion);
            _snapshotResourceSnapshotsRestClient = new SnapshotsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, snapshotResourceSnapshotsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ReportResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ReportResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Get the AppComplianceAutomation snapshot and its properties.
        /// Request Path: /providers/Microsoft.AppComplianceAutomation/reports/{reportName}/snapshots/{snapshotName}
        /// Operation Id: Snapshot_Get
        /// </summary>
        /// <param name="snapshotName"> Snapshot Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="snapshotName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="snapshotName"/> is null. </exception>
        public virtual async Task<Response<SnapshotResource>> GetAsync(string snapshotName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(snapshotName, nameof(snapshotName));

            using var scope = _snapshotResourceSnapshotClientDiagnostics.CreateScope("SnapshotResourceCollection.Get");
            scope.Start();
            try
            {
                var response = await _snapshotResourceSnapshotRestClient.GetAsync(Id.Name, snapshotName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SnapshotResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the AppComplianceAutomation snapshot and its properties.
        /// Request Path: /providers/Microsoft.AppComplianceAutomation/reports/{reportName}/snapshots/{snapshotName}
        /// Operation Id: Snapshot_Get
        /// </summary>
        /// <param name="snapshotName"> Snapshot Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="snapshotName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="snapshotName"/> is null. </exception>
        public virtual Response<SnapshotResource> Get(string snapshotName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(snapshotName, nameof(snapshotName));

            using var scope = _snapshotResourceSnapshotClientDiagnostics.CreateScope("SnapshotResourceCollection.Get");
            scope.Start();
            try
            {
                var response = _snapshotResourceSnapshotRestClient.Get(Id.Name, snapshotName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SnapshotResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the AppComplianceAutomation snapshot list.
        /// Request Path: /providers/Microsoft.AppComplianceAutomation/reports/{reportName}/snapshots
        /// Operation Id: Snapshots_List
        /// </summary>
        /// <param name="skipToken"> Skip over when retrieving results. </param>
        /// <param name="top"> Number of elements to return when retrieving results. </param>
        /// <param name="select"> OData Select statement. Limits the properties on each entry to just those requested, e.g. ?$select=reportName,id. </param>
        /// <param name="reportCreatorTenantId"> The tenant id of the report creator. </param>
        /// <param name="offerGuid"> The offerGuid which mapping to the reports. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SnapshotResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SnapshotResource> GetAllAsync(string skipToken = null, int? top = null, string select = null, string reportCreatorTenantId = null, string offerGuid = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<SnapshotResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _snapshotResourceSnapshotsClientDiagnostics.CreateScope("SnapshotResourceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _snapshotResourceSnapshotsRestClient.ListAsync(Id.Name, skipToken, top, select, reportCreatorTenantId, offerGuid, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SnapshotResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<SnapshotResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _snapshotResourceSnapshotsClientDiagnostics.CreateScope("SnapshotResourceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _snapshotResourceSnapshotsRestClient.ListNextPageAsync(nextLink, Id.Name, skipToken, top, select, reportCreatorTenantId, offerGuid, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SnapshotResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Get the AppComplianceAutomation snapshot list.
        /// Request Path: /providers/Microsoft.AppComplianceAutomation/reports/{reportName}/snapshots
        /// Operation Id: Snapshots_List
        /// </summary>
        /// <param name="skipToken"> Skip over when retrieving results. </param>
        /// <param name="top"> Number of elements to return when retrieving results. </param>
        /// <param name="select"> OData Select statement. Limits the properties on each entry to just those requested, e.g. ?$select=reportName,id. </param>
        /// <param name="reportCreatorTenantId"> The tenant id of the report creator. </param>
        /// <param name="offerGuid"> The offerGuid which mapping to the reports. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SnapshotResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SnapshotResource> GetAll(string skipToken = null, int? top = null, string select = null, string reportCreatorTenantId = null, string offerGuid = null, CancellationToken cancellationToken = default)
        {
            Page<SnapshotResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _snapshotResourceSnapshotsClientDiagnostics.CreateScope("SnapshotResourceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _snapshotResourceSnapshotsRestClient.List(Id.Name, skipToken, top, select, reportCreatorTenantId, offerGuid, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SnapshotResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<SnapshotResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _snapshotResourceSnapshotsClientDiagnostics.CreateScope("SnapshotResourceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _snapshotResourceSnapshotsRestClient.ListNextPage(nextLink, Id.Name, skipToken, top, select, reportCreatorTenantId, offerGuid, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SnapshotResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /providers/Microsoft.AppComplianceAutomation/reports/{reportName}/snapshots/{snapshotName}
        /// Operation Id: Snapshot_Get
        /// </summary>
        /// <param name="snapshotName"> Snapshot Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="snapshotName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="snapshotName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string snapshotName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(snapshotName, nameof(snapshotName));

            using var scope = _snapshotResourceSnapshotClientDiagnostics.CreateScope("SnapshotResourceCollection.Exists");
            scope.Start();
            try
            {
                var response = await _snapshotResourceSnapshotRestClient.GetAsync(Id.Name, snapshotName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /providers/Microsoft.AppComplianceAutomation/reports/{reportName}/snapshots/{snapshotName}
        /// Operation Id: Snapshot_Get
        /// </summary>
        /// <param name="snapshotName"> Snapshot Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="snapshotName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="snapshotName"/> is null. </exception>
        public virtual Response<bool> Exists(string snapshotName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(snapshotName, nameof(snapshotName));

            using var scope = _snapshotResourceSnapshotClientDiagnostics.CreateScope("SnapshotResourceCollection.Exists");
            scope.Start();
            try
            {
                var response = _snapshotResourceSnapshotRestClient.Get(Id.Name, snapshotName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SnapshotResource> IEnumerable<SnapshotResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SnapshotResource> IAsyncEnumerable<SnapshotResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
