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

namespace Azure.ResourceManager.AppPlatform
{
    /// <summary>
    /// A Class representing a GatewayCustomDomainResource along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="GatewayCustomDomainResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetGatewayCustomDomainResource method.
    /// Otherwise you can get one from its parent resource <see cref="GatewayResource" /> using the GetGatewayCustomDomainResource method.
    /// </summary>
    public partial class GatewayCustomDomainResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="GatewayCustomDomainResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string serviceName, string gatewayName, string domainName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/gateways/{gatewayName}/domains/{domainName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _gatewayCustomDomainResourceGatewayCustomDomainsClientDiagnostics;
        private readonly GatewayCustomDomainsRestOperations _gatewayCustomDomainResourceGatewayCustomDomainsRestClient;
        private readonly GatewayCustomDomainResourceData _data;

        /// <summary> Initializes a new instance of the <see cref="GatewayCustomDomainResource"/> class for mocking. </summary>
        protected GatewayCustomDomainResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "GatewayCustomDomainResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal GatewayCustomDomainResource(ArmClient client, GatewayCustomDomainResourceData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="GatewayCustomDomainResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal GatewayCustomDomainResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _gatewayCustomDomainResourceGatewayCustomDomainsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppPlatform", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string gatewayCustomDomainResourceGatewayCustomDomainsApiVersion);
            _gatewayCustomDomainResourceGatewayCustomDomainsRestClient = new GatewayCustomDomainsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, gatewayCustomDomainResourceGatewayCustomDomainsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.AppPlatform/Spring/gateways/domains";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual GatewayCustomDomainResourceData Data
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
        /// Get the Spring Cloud Gateway custom domain.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/gateways/{gatewayName}/domains/{domainName}
        /// Operation Id: GatewayCustomDomains_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<GatewayCustomDomainResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _gatewayCustomDomainResourceGatewayCustomDomainsClientDiagnostics.CreateScope("GatewayCustomDomainResource.Get");
            scope.Start();
            try
            {
                var response = await _gatewayCustomDomainResourceGatewayCustomDomainsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new GatewayCustomDomainResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the Spring Cloud Gateway custom domain.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/gateways/{gatewayName}/domains/{domainName}
        /// Operation Id: GatewayCustomDomains_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<GatewayCustomDomainResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _gatewayCustomDomainResourceGatewayCustomDomainsClientDiagnostics.CreateScope("GatewayCustomDomainResource.Get");
            scope.Start();
            try
            {
                var response = _gatewayCustomDomainResourceGatewayCustomDomainsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new GatewayCustomDomainResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Delete the Spring Cloud Gateway custom domain.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/gateways/{gatewayName}/domains/{domainName}
        /// Operation Id: GatewayCustomDomains_Delete
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _gatewayCustomDomainResourceGatewayCustomDomainsClientDiagnostics.CreateScope("GatewayCustomDomainResource.Delete");
            scope.Start();
            try
            {
                var response = await _gatewayCustomDomainResourceGatewayCustomDomainsRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new AppPlatformArmOperation(_gatewayCustomDomainResourceGatewayCustomDomainsClientDiagnostics, Pipeline, _gatewayCustomDomainResourceGatewayCustomDomainsRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Delete the Spring Cloud Gateway custom domain.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/gateways/{gatewayName}/domains/{domainName}
        /// Operation Id: GatewayCustomDomains_Delete
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _gatewayCustomDomainResourceGatewayCustomDomainsClientDiagnostics.CreateScope("GatewayCustomDomainResource.Delete");
            scope.Start();
            try
            {
                var response = _gatewayCustomDomainResourceGatewayCustomDomainsRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new AppPlatformArmOperation(_gatewayCustomDomainResourceGatewayCustomDomainsClientDiagnostics, Pipeline, _gatewayCustomDomainResourceGatewayCustomDomainsRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Create or update the Spring Cloud Gateway custom domain.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/gateways/{gatewayName}/domains/{domainName}
        /// Operation Id: GatewayCustomDomains_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The gateway custom domain resource for the create or update operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<GatewayCustomDomainResource>> UpdateAsync(WaitUntil waitUntil, GatewayCustomDomainResourceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _gatewayCustomDomainResourceGatewayCustomDomainsClientDiagnostics.CreateScope("GatewayCustomDomainResource.Update");
            scope.Start();
            try
            {
                var response = await _gatewayCustomDomainResourceGatewayCustomDomainsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new AppPlatformArmOperation<GatewayCustomDomainResource>(new GatewayCustomDomainResourceOperationSource(Client), _gatewayCustomDomainResourceGatewayCustomDomainsClientDiagnostics, Pipeline, _gatewayCustomDomainResourceGatewayCustomDomainsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Create or update the Spring Cloud Gateway custom domain.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/gateways/{gatewayName}/domains/{domainName}
        /// Operation Id: GatewayCustomDomains_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The gateway custom domain resource for the create or update operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<GatewayCustomDomainResource> Update(WaitUntil waitUntil, GatewayCustomDomainResourceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _gatewayCustomDomainResourceGatewayCustomDomainsClientDiagnostics.CreateScope("GatewayCustomDomainResource.Update");
            scope.Start();
            try
            {
                var response = _gatewayCustomDomainResourceGatewayCustomDomainsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, data, cancellationToken);
                var operation = new AppPlatformArmOperation<GatewayCustomDomainResource>(new GatewayCustomDomainResourceOperationSource(Client), _gatewayCustomDomainResourceGatewayCustomDomainsClientDiagnostics, Pipeline, _gatewayCustomDomainResourceGatewayCustomDomainsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
