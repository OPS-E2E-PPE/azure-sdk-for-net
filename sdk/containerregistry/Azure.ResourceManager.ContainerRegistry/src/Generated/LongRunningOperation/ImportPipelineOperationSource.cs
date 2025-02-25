// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;

namespace Azure.ResourceManager.ContainerRegistry
{
    internal class ImportPipelineOperationSource : IOperationSource<ImportPipelineResource>
    {
        private readonly ArmClient _client;

        internal ImportPipelineOperationSource(ArmClient client)
        {
            _client = client;
        }

        ImportPipelineResource IOperationSource<ImportPipelineResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = ImportPipelineData.DeserializeImportPipelineData(document.RootElement);
            return new ImportPipelineResource(_client, data);
        }

        async ValueTask<ImportPipelineResource> IOperationSource<ImportPipelineResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = ImportPipelineData.DeserializeImportPipelineData(document.RootElement);
            return new ImportPipelineResource(_client, data);
        }
    }
}
