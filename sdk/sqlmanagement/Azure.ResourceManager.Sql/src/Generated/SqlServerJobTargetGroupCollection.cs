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

namespace Azure.ResourceManager.Sql
{
    /// <summary>
    /// A class representing a collection of <see cref="SqlServerJobTargetGroupResource" /> and their operations.
    /// Each <see cref="SqlServerJobTargetGroupResource" /> in the collection will belong to the same instance of <see cref="SqlServerJobAgentResource" />.
    /// To get a <see cref="SqlServerJobTargetGroupCollection" /> instance call the GetSqlServerJobTargetGroups method from an instance of <see cref="SqlServerJobAgentResource" />.
    /// </summary>
    public partial class SqlServerJobTargetGroupCollection : ArmCollection, IEnumerable<SqlServerJobTargetGroupResource>, IAsyncEnumerable<SqlServerJobTargetGroupResource>
    {
        private readonly ClientDiagnostics _sqlServerJobTargetGroupJobTargetGroupsClientDiagnostics;
        private readonly JobTargetGroupsRestOperations _sqlServerJobTargetGroupJobTargetGroupsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SqlServerJobTargetGroupCollection"/> class for mocking. </summary>
        protected SqlServerJobTargetGroupCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SqlServerJobTargetGroupCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SqlServerJobTargetGroupCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _sqlServerJobTargetGroupJobTargetGroupsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", SqlServerJobTargetGroupResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SqlServerJobTargetGroupResource.ResourceType, out string sqlServerJobTargetGroupJobTargetGroupsApiVersion);
            _sqlServerJobTargetGroupJobTargetGroupsRestClient = new JobTargetGroupsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, sqlServerJobTargetGroupJobTargetGroupsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SqlServerJobAgentResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SqlServerJobAgentResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates a target group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/targetGroups/{targetGroupName}
        /// Operation Id: JobTargetGroups_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="targetGroupName"> The name of the target group. </param>
        /// <param name="data"> The requested state of the target group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="targetGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="targetGroupName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<SqlServerJobTargetGroupResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string targetGroupName, SqlServerJobTargetGroupData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(targetGroupName, nameof(targetGroupName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _sqlServerJobTargetGroupJobTargetGroupsClientDiagnostics.CreateScope("SqlServerJobTargetGroupCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _sqlServerJobTargetGroupJobTargetGroupsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, targetGroupName, data, cancellationToken).ConfigureAwait(false);
                var operation = new SqlArmOperation<SqlServerJobTargetGroupResource>(Response.FromValue(new SqlServerJobTargetGroupResource(Client, response), response.GetRawResponse()));
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
        /// Creates or updates a target group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/targetGroups/{targetGroupName}
        /// Operation Id: JobTargetGroups_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="targetGroupName"> The name of the target group. </param>
        /// <param name="data"> The requested state of the target group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="targetGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="targetGroupName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<SqlServerJobTargetGroupResource> CreateOrUpdate(WaitUntil waitUntil, string targetGroupName, SqlServerJobTargetGroupData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(targetGroupName, nameof(targetGroupName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _sqlServerJobTargetGroupJobTargetGroupsClientDiagnostics.CreateScope("SqlServerJobTargetGroupCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _sqlServerJobTargetGroupJobTargetGroupsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, targetGroupName, data, cancellationToken);
                var operation = new SqlArmOperation<SqlServerJobTargetGroupResource>(Response.FromValue(new SqlServerJobTargetGroupResource(Client, response), response.GetRawResponse()));
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
        /// Gets a target group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/targetGroups/{targetGroupName}
        /// Operation Id: JobTargetGroups_Get
        /// </summary>
        /// <param name="targetGroupName"> The name of the target group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="targetGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="targetGroupName"/> is null. </exception>
        public virtual async Task<Response<SqlServerJobTargetGroupResource>> GetAsync(string targetGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(targetGroupName, nameof(targetGroupName));

            using var scope = _sqlServerJobTargetGroupJobTargetGroupsClientDiagnostics.CreateScope("SqlServerJobTargetGroupCollection.Get");
            scope.Start();
            try
            {
                var response = await _sqlServerJobTargetGroupJobTargetGroupsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, targetGroupName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SqlServerJobTargetGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a target group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/targetGroups/{targetGroupName}
        /// Operation Id: JobTargetGroups_Get
        /// </summary>
        /// <param name="targetGroupName"> The name of the target group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="targetGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="targetGroupName"/> is null. </exception>
        public virtual Response<SqlServerJobTargetGroupResource> Get(string targetGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(targetGroupName, nameof(targetGroupName));

            using var scope = _sqlServerJobTargetGroupJobTargetGroupsClientDiagnostics.CreateScope("SqlServerJobTargetGroupCollection.Get");
            scope.Start();
            try
            {
                var response = _sqlServerJobTargetGroupJobTargetGroupsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, targetGroupName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SqlServerJobTargetGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets all target groups in an agent.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/targetGroups
        /// Operation Id: JobTargetGroups_ListByAgent
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SqlServerJobTargetGroupResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SqlServerJobTargetGroupResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<SqlServerJobTargetGroupResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _sqlServerJobTargetGroupJobTargetGroupsClientDiagnostics.CreateScope("SqlServerJobTargetGroupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _sqlServerJobTargetGroupJobTargetGroupsRestClient.ListByAgentAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SqlServerJobTargetGroupResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<SqlServerJobTargetGroupResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _sqlServerJobTargetGroupJobTargetGroupsClientDiagnostics.CreateScope("SqlServerJobTargetGroupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _sqlServerJobTargetGroupJobTargetGroupsRestClient.ListByAgentNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SqlServerJobTargetGroupResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Gets all target groups in an agent.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/targetGroups
        /// Operation Id: JobTargetGroups_ListByAgent
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SqlServerJobTargetGroupResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SqlServerJobTargetGroupResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<SqlServerJobTargetGroupResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _sqlServerJobTargetGroupJobTargetGroupsClientDiagnostics.CreateScope("SqlServerJobTargetGroupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _sqlServerJobTargetGroupJobTargetGroupsRestClient.ListByAgent(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SqlServerJobTargetGroupResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<SqlServerJobTargetGroupResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _sqlServerJobTargetGroupJobTargetGroupsClientDiagnostics.CreateScope("SqlServerJobTargetGroupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _sqlServerJobTargetGroupJobTargetGroupsRestClient.ListByAgentNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SqlServerJobTargetGroupResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/targetGroups/{targetGroupName}
        /// Operation Id: JobTargetGroups_Get
        /// </summary>
        /// <param name="targetGroupName"> The name of the target group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="targetGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="targetGroupName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string targetGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(targetGroupName, nameof(targetGroupName));

            using var scope = _sqlServerJobTargetGroupJobTargetGroupsClientDiagnostics.CreateScope("SqlServerJobTargetGroupCollection.Exists");
            scope.Start();
            try
            {
                var response = await _sqlServerJobTargetGroupJobTargetGroupsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, targetGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/targetGroups/{targetGroupName}
        /// Operation Id: JobTargetGroups_Get
        /// </summary>
        /// <param name="targetGroupName"> The name of the target group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="targetGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="targetGroupName"/> is null. </exception>
        public virtual Response<bool> Exists(string targetGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(targetGroupName, nameof(targetGroupName));

            using var scope = _sqlServerJobTargetGroupJobTargetGroupsClientDiagnostics.CreateScope("SqlServerJobTargetGroupCollection.Exists");
            scope.Start();
            try
            {
                var response = _sqlServerJobTargetGroupJobTargetGroupsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, targetGroupName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SqlServerJobTargetGroupResource> IEnumerable<SqlServerJobTargetGroupResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SqlServerJobTargetGroupResource> IAsyncEnumerable<SqlServerJobTargetGroupResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
