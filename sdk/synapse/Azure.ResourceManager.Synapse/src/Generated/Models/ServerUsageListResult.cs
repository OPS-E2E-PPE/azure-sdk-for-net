// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.Synapse.Models
{
    /// <summary> Represents the response to a list server metrics request. </summary>
    internal partial class ServerUsageListResult
    {
        /// <summary> Initializes a new instance of ServerUsageListResult. </summary>
        /// <param name="value"> The list of server metrics for the server. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal ServerUsageListResult(IEnumerable<ServerUsage> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of ServerUsageListResult. </summary>
        /// <param name="value"> The list of server metrics for the server. </param>
        /// <param name="nextLink"> Link to retrieve next page of results. </param>
        internal ServerUsageListResult(IReadOnlyList<ServerUsage> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The list of server metrics for the server. </summary>
        public IReadOnlyList<ServerUsage> Value { get; }
        /// <summary> Link to retrieve next page of results. </summary>
        public string NextLink { get; }
    }
}
