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

namespace Azure.ResourceManager.SecurityDevOps
{
    /// <summary>
    /// A Class representing an AzureDevOpsProject along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct an <see cref="AzureDevOpsProjectResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetAzureDevOpsProjectResource method.
    /// Otherwise you can get one from its parent resource <see cref="AzureDevOpsOrgResource" /> using the GetAzureDevOpsProject method.
    /// </summary>
    public partial class AzureDevOpsProjectResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="AzureDevOpsProjectResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string azureDevOpsConnectorName, string azureDevOpsOrgName, string azureDevOpsProjectName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SecurityDevOps/azureDevOpsConnectors/{azureDevOpsConnectorName}/orgs/{azureDevOpsOrgName}/projects/{azureDevOpsProjectName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _azureDevOpsProjectClientDiagnostics;
        private readonly AzureDevOpsProjectRestOperations _azureDevOpsProjectRestClient;
        private readonly AzureDevOpsProjectData _data;

        /// <summary> Initializes a new instance of the <see cref="AzureDevOpsProjectResource"/> class for mocking. </summary>
        protected AzureDevOpsProjectResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "AzureDevOpsProjectResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal AzureDevOpsProjectResource(ArmClient client, AzureDevOpsProjectData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="AzureDevOpsProjectResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal AzureDevOpsProjectResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _azureDevOpsProjectClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.SecurityDevOps", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string azureDevOpsProjectApiVersion);
            _azureDevOpsProjectRestClient = new AzureDevOpsProjectRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, azureDevOpsProjectApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.SecurityDevOps/azureDevOpsConnectors/orgs/projects";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual AzureDevOpsProjectData Data
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

        /// <summary> Gets a collection of AzureDevOpsRepoResources in the AzureDevOpsProject. </summary>
        /// <returns> An object representing collection of AzureDevOpsRepoResources and their operations over a AzureDevOpsRepoResource. </returns>
        public virtual AzureDevOpsRepoCollection GetAzureDevOpsRepos()
        {
            return GetCachedClient(Client => new AzureDevOpsRepoCollection(Client, Id));
        }

        /// <summary>
        /// Returns a monitored AzureDevOps Project resource for a given ID.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SecurityDevOps/azureDevOpsConnectors/{azureDevOpsConnectorName}/orgs/{azureDevOpsOrgName}/projects/{azureDevOpsProjectName}/repos/{azureDevOpsRepoName}
        /// Operation Id: AzureDevOpsRepo_Get
        /// </summary>
        /// <param name="azureDevOpsRepoName"> Name of the AzureDevOps Repo. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="azureDevOpsRepoName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="azureDevOpsRepoName"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<AzureDevOpsRepoResource>> GetAzureDevOpsRepoAsync(string azureDevOpsRepoName, CancellationToken cancellationToken = default)
        {
            return await GetAzureDevOpsRepos().GetAsync(azureDevOpsRepoName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Returns a monitored AzureDevOps Project resource for a given ID.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SecurityDevOps/azureDevOpsConnectors/{azureDevOpsConnectorName}/orgs/{azureDevOpsOrgName}/projects/{azureDevOpsProjectName}/repos/{azureDevOpsRepoName}
        /// Operation Id: AzureDevOpsRepo_Get
        /// </summary>
        /// <param name="azureDevOpsRepoName"> Name of the AzureDevOps Repo. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="azureDevOpsRepoName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="azureDevOpsRepoName"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual Response<AzureDevOpsRepoResource> GetAzureDevOpsRepo(string azureDevOpsRepoName, CancellationToken cancellationToken = default)
        {
            return GetAzureDevOpsRepos().Get(azureDevOpsRepoName, cancellationToken);
        }

        /// <summary>
        /// Returns a monitored AzureDevOps Project resource for a given ID.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SecurityDevOps/azureDevOpsConnectors/{azureDevOpsConnectorName}/orgs/{azureDevOpsOrgName}/projects/{azureDevOpsProjectName}
        /// Operation Id: AzureDevOpsProject_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<AzureDevOpsProjectResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _azureDevOpsProjectClientDiagnostics.CreateScope("AzureDevOpsProjectResource.Get");
            scope.Start();
            try
            {
                var response = await _azureDevOpsProjectRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AzureDevOpsProjectResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns a monitored AzureDevOps Project resource for a given ID.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SecurityDevOps/azureDevOpsConnectors/{azureDevOpsConnectorName}/orgs/{azureDevOpsOrgName}/projects/{azureDevOpsProjectName}
        /// Operation Id: AzureDevOpsProject_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<AzureDevOpsProjectResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _azureDevOpsProjectClientDiagnostics.CreateScope("AzureDevOpsProjectResource.Get");
            scope.Start();
            try
            {
                var response = _azureDevOpsProjectRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AzureDevOpsProjectResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Update monitored AzureDevOps Project details.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SecurityDevOps/azureDevOpsConnectors/{azureDevOpsConnectorName}/orgs/{azureDevOpsOrgName}/projects/{azureDevOpsProjectName}
        /// Operation Id: AzureDevOpsProject_Update
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Azure DevOps Org resource payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<AzureDevOpsProjectResource>> UpdateAsync(WaitUntil waitUntil, AzureDevOpsProjectData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _azureDevOpsProjectClientDiagnostics.CreateScope("AzureDevOpsProjectResource.Update");
            scope.Start();
            try
            {
                var response = await _azureDevOpsProjectRestClient.UpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new SecurityDevOpsArmOperation<AzureDevOpsProjectResource>(new AzureDevOpsProjectOperationSource(Client), _azureDevOpsProjectClientDiagnostics, Pipeline, _azureDevOpsProjectRestClient.CreateUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.Location);
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
        /// Update monitored AzureDevOps Project details.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SecurityDevOps/azureDevOpsConnectors/{azureDevOpsConnectorName}/orgs/{azureDevOpsOrgName}/projects/{azureDevOpsProjectName}
        /// Operation Id: AzureDevOpsProject_Update
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Azure DevOps Org resource payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<AzureDevOpsProjectResource> Update(WaitUntil waitUntil, AzureDevOpsProjectData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _azureDevOpsProjectClientDiagnostics.CreateScope("AzureDevOpsProjectResource.Update");
            scope.Start();
            try
            {
                var response = _azureDevOpsProjectRestClient.Update(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, data, cancellationToken);
                var operation = new SecurityDevOpsArmOperation<AzureDevOpsProjectResource>(new AzureDevOpsProjectOperationSource(Client), _azureDevOpsProjectClientDiagnostics, Pipeline, _azureDevOpsProjectRestClient.CreateUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.Location);
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
