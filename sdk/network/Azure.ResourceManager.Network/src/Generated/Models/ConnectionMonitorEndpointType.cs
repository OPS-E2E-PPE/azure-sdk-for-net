// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> The endpoint type. </summary>
    public readonly partial struct ConnectionMonitorEndpointType : IEquatable<ConnectionMonitorEndpointType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ConnectionMonitorEndpointType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ConnectionMonitorEndpointType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AzureVmValue = "AzureVM";
        private const string AzureVNetValue = "AzureVNet";
        private const string AzureSubnetValue = "AzureSubnet";
        private const string ExternalAddressValue = "ExternalAddress";
        private const string MMAWorkspaceMachineValue = "MMAWorkspaceMachine";
        private const string MMAWorkspaceNetworkValue = "MMAWorkspaceNetwork";

        /// <summary> AzureVM. </summary>
        public static ConnectionMonitorEndpointType AzureVm { get; } = new ConnectionMonitorEndpointType(AzureVmValue);
        /// <summary> AzureVNet. </summary>
        public static ConnectionMonitorEndpointType AzureVNet { get; } = new ConnectionMonitorEndpointType(AzureVNetValue);
        /// <summary> AzureSubnet. </summary>
        public static ConnectionMonitorEndpointType AzureSubnet { get; } = new ConnectionMonitorEndpointType(AzureSubnetValue);
        /// <summary> ExternalAddress. </summary>
        public static ConnectionMonitorEndpointType ExternalAddress { get; } = new ConnectionMonitorEndpointType(ExternalAddressValue);
        /// <summary> MMAWorkspaceMachine. </summary>
        public static ConnectionMonitorEndpointType MMAWorkspaceMachine { get; } = new ConnectionMonitorEndpointType(MMAWorkspaceMachineValue);
        /// <summary> MMAWorkspaceNetwork. </summary>
        public static ConnectionMonitorEndpointType MMAWorkspaceNetwork { get; } = new ConnectionMonitorEndpointType(MMAWorkspaceNetworkValue);
        /// <summary> Determines if two <see cref="ConnectionMonitorEndpointType"/> values are the same. </summary>
        public static bool operator ==(ConnectionMonitorEndpointType left, ConnectionMonitorEndpointType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ConnectionMonitorEndpointType"/> values are not the same. </summary>
        public static bool operator !=(ConnectionMonitorEndpointType left, ConnectionMonitorEndpointType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ConnectionMonitorEndpointType"/>. </summary>
        public static implicit operator ConnectionMonitorEndpointType(string value) => new ConnectionMonitorEndpointType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ConnectionMonitorEndpointType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ConnectionMonitorEndpointType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
