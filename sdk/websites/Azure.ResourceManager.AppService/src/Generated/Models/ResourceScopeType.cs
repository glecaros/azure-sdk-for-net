// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Name of a resource type this recommendation applies, e.g. Subscription, ServerFarm, Site. </summary>
    public readonly partial struct ResourceScopeType : IEquatable<ResourceScopeType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ResourceScopeType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ResourceScopeType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ServerFarmValue = "ServerFarm";
        private const string SubscriptionValue = "Subscription";
        private const string WebSiteValue = "WebSite";

        /// <summary> ServerFarm. </summary>
        public static ResourceScopeType ServerFarm { get; } = new ResourceScopeType(ServerFarmValue);
        /// <summary> Subscription. </summary>
        public static ResourceScopeType Subscription { get; } = new ResourceScopeType(SubscriptionValue);
        /// <summary> WebSite. </summary>
        public static ResourceScopeType WebSite { get; } = new ResourceScopeType(WebSiteValue);
        /// <summary> Determines if two <see cref="ResourceScopeType"/> values are the same. </summary>
        public static bool operator ==(ResourceScopeType left, ResourceScopeType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ResourceScopeType"/> values are not the same. </summary>
        public static bool operator !=(ResourceScopeType left, ResourceScopeType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ResourceScopeType"/>. </summary>
        public static implicit operator ResourceScopeType(string value) => new ResourceScopeType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ResourceScopeType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ResourceScopeType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
