// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    /// <summary> Retrieves properties and media profiles of an ONVIF device. </summary>
    public partial class OnvifDeviceGetRequest : MethodRequest
    {
        /// <summary> Initializes a new instance of OnvifDeviceGetRequest. </summary>
        /// <param name="endpoint"> Base class for endpoints. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/> is null. </exception>
        public OnvifDeviceGetRequest(EndpointBase endpoint)
        {
            Argument.AssertNotNull(endpoint, nameof(endpoint));

            Endpoint = endpoint;
            MethodName = "onvifDeviceGet";
        }

        /// <summary> Initializes a new instance of OnvifDeviceGetRequest. </summary>
        /// <param name="methodName"> Direct method method name. </param>
        /// <param name="apiVersion"> Video Analyzer API version. </param>
        /// <param name="endpoint"> Base class for endpoints. </param>
        internal OnvifDeviceGetRequest(string methodName, string apiVersion, EndpointBase endpoint) : base(methodName, apiVersion)
        {
            Endpoint = endpoint;
            MethodName = methodName ?? "onvifDeviceGet";
        }

        /// <summary> Base class for endpoints. </summary>
        public EndpointBase Endpoint { get; set; }
    }
}
