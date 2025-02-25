// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ProviderHub.Models
{
    /// <summary> The RoutingType. </summary>
    public readonly partial struct RoutingType : IEquatable<RoutingType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="RoutingType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public RoutingType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DefaultValue = "Default";
        private const string ProxyOnlyValue = "ProxyOnly";
        private const string HostBasedValue = "HostBased";
        private const string ExtensionValue = "Extension";
        private const string TenantValue = "Tenant";
        private const string FanoutValue = "Fanout";
        private const string LocationBasedValue = "LocationBased";
        private const string FailoverValue = "Failover";
        private const string CascadeExtensionValue = "CascadeExtension";

        /// <summary> Default. </summary>
        public static RoutingType Default { get; } = new RoutingType(DefaultValue);
        /// <summary> ProxyOnly. </summary>
        public static RoutingType ProxyOnly { get; } = new RoutingType(ProxyOnlyValue);
        /// <summary> HostBased. </summary>
        public static RoutingType HostBased { get; } = new RoutingType(HostBasedValue);
        /// <summary> Extension. </summary>
        public static RoutingType Extension { get; } = new RoutingType(ExtensionValue);
        /// <summary> Tenant. </summary>
        public static RoutingType Tenant { get; } = new RoutingType(TenantValue);
        /// <summary> Fanout. </summary>
        public static RoutingType Fanout { get; } = new RoutingType(FanoutValue);
        /// <summary> LocationBased. </summary>
        public static RoutingType LocationBased { get; } = new RoutingType(LocationBasedValue);
        /// <summary> Failover. </summary>
        public static RoutingType Failover { get; } = new RoutingType(FailoverValue);
        /// <summary> CascadeExtension. </summary>
        public static RoutingType CascadeExtension { get; } = new RoutingType(CascadeExtensionValue);
        /// <summary> Determines if two <see cref="RoutingType"/> values are the same. </summary>
        public static bool operator ==(RoutingType left, RoutingType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="RoutingType"/> values are not the same. </summary>
        public static bool operator !=(RoutingType left, RoutingType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="RoutingType"/>. </summary>
        public static implicit operator RoutingType(string value) => new RoutingType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is RoutingType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(RoutingType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
