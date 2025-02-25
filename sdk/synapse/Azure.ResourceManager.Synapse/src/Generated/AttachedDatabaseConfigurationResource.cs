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

namespace Azure.ResourceManager.Synapse
{
    /// <summary>
    /// A Class representing an AttachedDatabaseConfiguration along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct an <see cref="AttachedDatabaseConfigurationResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetAttachedDatabaseConfigurationResource method.
    /// Otherwise you can get one from its parent resource <see cref="KustoPoolResource" /> using the GetAttachedDatabaseConfiguration method.
    /// </summary>
    public partial class AttachedDatabaseConfigurationResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="AttachedDatabaseConfigurationResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string workspaceName, string kustoPoolName, string attachedDatabaseConfigurationName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/kustoPools/{kustoPoolName}/attachedDatabaseConfigurations/{attachedDatabaseConfigurationName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _attachedDatabaseConfigurationKustoPoolAttachedDatabaseConfigurationsClientDiagnostics;
        private readonly KustoPoolAttachedDatabaseConfigurationsRestOperations _attachedDatabaseConfigurationKustoPoolAttachedDatabaseConfigurationsRestClient;
        private readonly AttachedDatabaseConfigurationData _data;

        /// <summary> Initializes a new instance of the <see cref="AttachedDatabaseConfigurationResource"/> class for mocking. </summary>
        protected AttachedDatabaseConfigurationResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "AttachedDatabaseConfigurationResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal AttachedDatabaseConfigurationResource(ArmClient client, AttachedDatabaseConfigurationData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="AttachedDatabaseConfigurationResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal AttachedDatabaseConfigurationResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _attachedDatabaseConfigurationKustoPoolAttachedDatabaseConfigurationsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Synapse", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string attachedDatabaseConfigurationKustoPoolAttachedDatabaseConfigurationsApiVersion);
            _attachedDatabaseConfigurationKustoPoolAttachedDatabaseConfigurationsRestClient = new KustoPoolAttachedDatabaseConfigurationsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, attachedDatabaseConfigurationKustoPoolAttachedDatabaseConfigurationsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Synapse/workspaces/kustoPools/attachedDatabaseConfigurations";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual AttachedDatabaseConfigurationData Data
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

        /// <summary>
        /// Returns an attached database configuration.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/kustoPools/{kustoPoolName}/attachedDatabaseConfigurations/{attachedDatabaseConfigurationName}
        /// Operation Id: KustoPoolAttachedDatabaseConfigurations_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<AttachedDatabaseConfigurationResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _attachedDatabaseConfigurationKustoPoolAttachedDatabaseConfigurationsClientDiagnostics.CreateScope("AttachedDatabaseConfigurationResource.Get");
            scope.Start();
            try
            {
                var response = await _attachedDatabaseConfigurationKustoPoolAttachedDatabaseConfigurationsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AttachedDatabaseConfigurationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns an attached database configuration.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/kustoPools/{kustoPoolName}/attachedDatabaseConfigurations/{attachedDatabaseConfigurationName}
        /// Operation Id: KustoPoolAttachedDatabaseConfigurations_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<AttachedDatabaseConfigurationResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _attachedDatabaseConfigurationKustoPoolAttachedDatabaseConfigurationsClientDiagnostics.CreateScope("AttachedDatabaseConfigurationResource.Get");
            scope.Start();
            try
            {
                var response = _attachedDatabaseConfigurationKustoPoolAttachedDatabaseConfigurationsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AttachedDatabaseConfigurationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes the attached database configuration with the given name.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/kustoPools/{kustoPoolName}/attachedDatabaseConfigurations/{attachedDatabaseConfigurationName}
        /// Operation Id: KustoPoolAttachedDatabaseConfigurations_Delete
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _attachedDatabaseConfigurationKustoPoolAttachedDatabaseConfigurationsClientDiagnostics.CreateScope("AttachedDatabaseConfigurationResource.Delete");
            scope.Start();
            try
            {
                var response = await _attachedDatabaseConfigurationKustoPoolAttachedDatabaseConfigurationsRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new SynapseArmOperation(_attachedDatabaseConfigurationKustoPoolAttachedDatabaseConfigurationsClientDiagnostics, Pipeline, _attachedDatabaseConfigurationKustoPoolAttachedDatabaseConfigurationsRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes the attached database configuration with the given name.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/kustoPools/{kustoPoolName}/attachedDatabaseConfigurations/{attachedDatabaseConfigurationName}
        /// Operation Id: KustoPoolAttachedDatabaseConfigurations_Delete
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _attachedDatabaseConfigurationKustoPoolAttachedDatabaseConfigurationsClientDiagnostics.CreateScope("AttachedDatabaseConfigurationResource.Delete");
            scope.Start();
            try
            {
                var response = _attachedDatabaseConfigurationKustoPoolAttachedDatabaseConfigurationsRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new SynapseArmOperation(_attachedDatabaseConfigurationKustoPoolAttachedDatabaseConfigurationsClientDiagnostics, Pipeline, _attachedDatabaseConfigurationKustoPoolAttachedDatabaseConfigurationsRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates or updates an attached database configuration.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/kustoPools/{kustoPoolName}/attachedDatabaseConfigurations/{attachedDatabaseConfigurationName}
        /// Operation Id: KustoPoolAttachedDatabaseConfigurations_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The database parameters supplied to the CreateOrUpdate operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<AttachedDatabaseConfigurationResource>> UpdateAsync(WaitUntil waitUntil, AttachedDatabaseConfigurationData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _attachedDatabaseConfigurationKustoPoolAttachedDatabaseConfigurationsClientDiagnostics.CreateScope("AttachedDatabaseConfigurationResource.Update");
            scope.Start();
            try
            {
                var response = await _attachedDatabaseConfigurationKustoPoolAttachedDatabaseConfigurationsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new SynapseArmOperation<AttachedDatabaseConfigurationResource>(new AttachedDatabaseConfigurationOperationSource(Client), _attachedDatabaseConfigurationKustoPoolAttachedDatabaseConfigurationsClientDiagnostics, Pipeline, _attachedDatabaseConfigurationKustoPoolAttachedDatabaseConfigurationsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.Location);
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
        /// Creates or updates an attached database configuration.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/kustoPools/{kustoPoolName}/attachedDatabaseConfigurations/{attachedDatabaseConfigurationName}
        /// Operation Id: KustoPoolAttachedDatabaseConfigurations_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The database parameters supplied to the CreateOrUpdate operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<AttachedDatabaseConfigurationResource> Update(WaitUntil waitUntil, AttachedDatabaseConfigurationData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _attachedDatabaseConfigurationKustoPoolAttachedDatabaseConfigurationsClientDiagnostics.CreateScope("AttachedDatabaseConfigurationResource.Update");
            scope.Start();
            try
            {
                var response = _attachedDatabaseConfigurationKustoPoolAttachedDatabaseConfigurationsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, data, cancellationToken);
                var operation = new SynapseArmOperation<AttachedDatabaseConfigurationResource>(new AttachedDatabaseConfigurationOperationSource(Client), _attachedDatabaseConfigurationKustoPoolAttachedDatabaseConfigurationsClientDiagnostics, Pipeline, _attachedDatabaseConfigurationKustoPoolAttachedDatabaseConfigurationsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.Location);
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
    }
}
