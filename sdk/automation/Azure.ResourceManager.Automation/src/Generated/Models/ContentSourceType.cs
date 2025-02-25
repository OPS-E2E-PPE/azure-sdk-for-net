// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Automation.Models
{
    /// <summary> Gets or sets the content source type. </summary>
    public readonly partial struct ContentSourceType : IEquatable<ContentSourceType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ContentSourceType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ContentSourceType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EmbeddedContentValue = "embeddedContent";
        private const string UriValue = "uri";

        /// <summary> embeddedContent. </summary>
        public static ContentSourceType EmbeddedContent { get; } = new ContentSourceType(EmbeddedContentValue);
        /// <summary> uri. </summary>
        public static ContentSourceType Uri { get; } = new ContentSourceType(UriValue);
        /// <summary> Determines if two <see cref="ContentSourceType"/> values are the same. </summary>
        public static bool operator ==(ContentSourceType left, ContentSourceType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ContentSourceType"/> values are not the same. </summary>
        public static bool operator !=(ContentSourceType left, ContentSourceType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ContentSourceType"/>. </summary>
        public static implicit operator ContentSourceType(string value) => new ContentSourceType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ContentSourceType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ContentSourceType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
