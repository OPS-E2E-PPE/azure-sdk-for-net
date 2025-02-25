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

namespace Azure.ResourceManager.DataMigration
{
    internal class SqlMigrationServiceOperationSource : IOperationSource<SqlMigrationServiceResource>
    {
        private readonly ArmClient _client;

        internal SqlMigrationServiceOperationSource(ArmClient client)
        {
            _client = client;
        }

        SqlMigrationServiceResource IOperationSource<SqlMigrationServiceResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = SqlMigrationServiceData.DeserializeSqlMigrationServiceData(document.RootElement);
            return new SqlMigrationServiceResource(_client, data);
        }

        async ValueTask<SqlMigrationServiceResource> IOperationSource<SqlMigrationServiceResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = SqlMigrationServiceData.DeserializeSqlMigrationServiceData(document.RootElement);
            return new SqlMigrationServiceResource(_client, data);
        }
    }
}
