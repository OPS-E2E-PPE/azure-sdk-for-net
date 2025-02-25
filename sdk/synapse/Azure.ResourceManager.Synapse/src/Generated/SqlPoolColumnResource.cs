// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Synapse.Models;

namespace Azure.ResourceManager.Synapse
{
    /// <summary>
    /// A Class representing a SqlPoolColumn along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="SqlPoolColumnResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetSqlPoolColumnResource method.
    /// Otherwise you can get one from its parent resource <see cref="SqlPoolTableResource" /> using the GetSqlPoolColumn method.
    /// </summary>
    public partial class SqlPoolColumnResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="SqlPoolColumnResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string workspaceName, string sqlPoolName, string schemaName, string tableName, string columnName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/sqlPools/{sqlPoolName}/schemas/{schemaName}/tables/{tableName}/columns/{columnName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _sqlPoolColumnClientDiagnostics;
        private readonly SqlPoolColumnsRestOperations _sqlPoolColumnRestClient;
        private readonly ClientDiagnostics _sensitivityLabelSqlPoolSensitivityLabelsClientDiagnostics;
        private readonly SqlPoolSensitivityLabelsRestOperations _sensitivityLabelSqlPoolSensitivityLabelsRestClient;
        private readonly SqlPoolColumnData _data;

        /// <summary> Initializes a new instance of the <see cref="SqlPoolColumnResource"/> class for mocking. </summary>
        protected SqlPoolColumnResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "SqlPoolColumnResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal SqlPoolColumnResource(ArmClient client, SqlPoolColumnData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="SqlPoolColumnResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SqlPoolColumnResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _sqlPoolColumnClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Synapse", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string sqlPoolColumnApiVersion);
            _sqlPoolColumnRestClient = new SqlPoolColumnsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, sqlPoolColumnApiVersion);
            _sensitivityLabelSqlPoolSensitivityLabelsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Synapse", SensitivityLabelResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SensitivityLabelResource.ResourceType, out string sensitivityLabelSqlPoolSensitivityLabelsApiVersion);
            _sensitivityLabelSqlPoolSensitivityLabelsRestClient = new SqlPoolSensitivityLabelsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, sensitivityLabelSqlPoolSensitivityLabelsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Synapse/workspaces/sqlPools/schemas/tables/columns";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual SqlPoolColumnData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary> Gets a collection of SensitivityLabelResources in the SqlPoolColumn. </summary>
        /// <returns> An object representing collection of SensitivityLabelResources and their operations over a SensitivityLabelResource. </returns>
        public virtual SensitivityLabelCollection GetSensitivityLabels()
        {
            return GetCachedClient(Client => new SensitivityLabelCollection(Client, Id));
        }

        /// <summary>
        /// Gets the sensitivity label of a given column
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/sqlPools/{sqlPoolName}/schemas/{schemaName}/tables/{tableName}/columns/{columnName}/sensitivityLabels/{sensitivityLabelSource}
        /// Operation Id: SqlPoolSensitivityLabels_Get
        /// </summary>
        /// <param name="sensitivityLabelSource"> The source of the sensitivity label. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public virtual async Task<Response<SensitivityLabelResource>> GetSensitivityLabelAsync(SensitivityLabelSource sensitivityLabelSource, CancellationToken cancellationToken = default)
        {
            return await GetSensitivityLabels().GetAsync(sensitivityLabelSource, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the sensitivity label of a given column
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/sqlPools/{sqlPoolName}/schemas/{schemaName}/tables/{tableName}/columns/{columnName}/sensitivityLabels/{sensitivityLabelSource}
        /// Operation Id: SqlPoolSensitivityLabels_Get
        /// </summary>
        /// <param name="sensitivityLabelSource"> The source of the sensitivity label. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public virtual Response<SensitivityLabelResource> GetSensitivityLabel(SensitivityLabelSource sensitivityLabelSource, CancellationToken cancellationToken = default)
        {
            return GetSensitivityLabels().Get(sensitivityLabelSource, cancellationToken);
        }

        /// <summary>
        /// Get Sql pool column
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/sqlPools/{sqlPoolName}/schemas/{schemaName}/tables/{tableName}/columns/{columnName}
        /// Operation Id: SqlPoolColumns_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SqlPoolColumnResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _sqlPoolColumnClientDiagnostics.CreateScope("SqlPoolColumnResource.Get");
            scope.Start();
            try
            {
                var response = await _sqlPoolColumnRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SqlPoolColumnResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get Sql pool column
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/sqlPools/{sqlPoolName}/schemas/{schemaName}/tables/{tableName}/columns/{columnName}
        /// Operation Id: SqlPoolColumns_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SqlPoolColumnResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _sqlPoolColumnClientDiagnostics.CreateScope("SqlPoolColumnResource.Get");
            scope.Start();
            try
            {
                var response = _sqlPoolColumnRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SqlPoolColumnResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Enables sensitivity recommendations on a given column (recommendations are enabled by default on all columns)
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/sqlPools/{sqlPoolName}/schemas/{schemaName}/tables/{tableName}/columns/{columnName}/sensitivityLabels/{sensitivityLabelSource}/enable
        /// Operation Id: SqlPoolSensitivityLabels_EnableRecommendation
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> EnableRecommendationSqlPoolSensitivityLabelAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _sensitivityLabelSqlPoolSensitivityLabelsClientDiagnostics.CreateScope("SqlPoolColumnResource.EnableRecommendationSqlPoolSensitivityLabel");
            scope.Start();
            try
            {
                var response = await _sensitivityLabelSqlPoolSensitivityLabelsRestClient.EnableRecommendationAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Enables sensitivity recommendations on a given column (recommendations are enabled by default on all columns)
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/sqlPools/{sqlPoolName}/schemas/{schemaName}/tables/{tableName}/columns/{columnName}/sensitivityLabels/{sensitivityLabelSource}/enable
        /// Operation Id: SqlPoolSensitivityLabels_EnableRecommendation
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response EnableRecommendationSqlPoolSensitivityLabel(CancellationToken cancellationToken = default)
        {
            using var scope = _sensitivityLabelSqlPoolSensitivityLabelsClientDiagnostics.CreateScope("SqlPoolColumnResource.EnableRecommendationSqlPoolSensitivityLabel");
            scope.Start();
            try
            {
                var response = _sensitivityLabelSqlPoolSensitivityLabelsRestClient.EnableRecommendation(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Disables sensitivity recommendations on a given column
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/sqlPools/{sqlPoolName}/schemas/{schemaName}/tables/{tableName}/columns/{columnName}/sensitivityLabels/{sensitivityLabelSource}/disable
        /// Operation Id: SqlPoolSensitivityLabels_DisableRecommendation
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> DisableRecommendationSqlPoolSensitivityLabelAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _sensitivityLabelSqlPoolSensitivityLabelsClientDiagnostics.CreateScope("SqlPoolColumnResource.DisableRecommendationSqlPoolSensitivityLabel");
            scope.Start();
            try
            {
                var response = await _sensitivityLabelSqlPoolSensitivityLabelsRestClient.DisableRecommendationAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Disables sensitivity recommendations on a given column
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/sqlPools/{sqlPoolName}/schemas/{schemaName}/tables/{tableName}/columns/{columnName}/sensitivityLabels/{sensitivityLabelSource}/disable
        /// Operation Id: SqlPoolSensitivityLabels_DisableRecommendation
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response DisableRecommendationSqlPoolSensitivityLabel(CancellationToken cancellationToken = default)
        {
            using var scope = _sensitivityLabelSqlPoolSensitivityLabelsClientDiagnostics.CreateScope("SqlPoolColumnResource.DisableRecommendationSqlPoolSensitivityLabel");
            scope.Start();
            try
            {
                var response = _sensitivityLabelSqlPoolSensitivityLabelsRestClient.DisableRecommendation(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
