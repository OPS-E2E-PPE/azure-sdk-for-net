// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.SignalR.Models
{
    /// <summary> Status of the shared private link resource. </summary>
    public readonly partial struct SharedPrivateLinkResourceStatus : IEquatable<SharedPrivateLinkResourceStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SharedPrivateLinkResourceStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SharedPrivateLinkResourceStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PendingValue = "Pending";
        private const string ApprovedValue = "Approved";
        private const string RejectedValue = "Rejected";
        private const string DisconnectedValue = "Disconnected";
        private const string TimeoutValue = "Timeout";

        /// <summary> Pending. </summary>
        public static SharedPrivateLinkResourceStatus Pending { get; } = new SharedPrivateLinkResourceStatus(PendingValue);
        /// <summary> Approved. </summary>
        public static SharedPrivateLinkResourceStatus Approved { get; } = new SharedPrivateLinkResourceStatus(ApprovedValue);
        /// <summary> Rejected. </summary>
        public static SharedPrivateLinkResourceStatus Rejected { get; } = new SharedPrivateLinkResourceStatus(RejectedValue);
        /// <summary> Disconnected. </summary>
        public static SharedPrivateLinkResourceStatus Disconnected { get; } = new SharedPrivateLinkResourceStatus(DisconnectedValue);
        /// <summary> Timeout. </summary>
        public static SharedPrivateLinkResourceStatus Timeout { get; } = new SharedPrivateLinkResourceStatus(TimeoutValue);
        /// <summary> Determines if two <see cref="SharedPrivateLinkResourceStatus"/> values are the same. </summary>
        public static bool operator ==(SharedPrivateLinkResourceStatus left, SharedPrivateLinkResourceStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SharedPrivateLinkResourceStatus"/> values are not the same. </summary>
        public static bool operator !=(SharedPrivateLinkResourceStatus left, SharedPrivateLinkResourceStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SharedPrivateLinkResourceStatus"/>. </summary>
        public static implicit operator SharedPrivateLinkResourceStatus(string value) => new SharedPrivateLinkResourceStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SharedPrivateLinkResourceStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SharedPrivateLinkResourceStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
