// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    /// <summary> Available roles for the network device. </summary>
    public readonly partial struct NetworkDeviceRoleType : IEquatable<NetworkDeviceRoleType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="NetworkDeviceRoleType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public NetworkDeviceRoleType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string CEValue = "CE";
        private const string ToRValue = "ToR";
        private const string NPBValue = "NPB";
        private const string TSValue = "TS";
        private const string ManagementValue = "Management";

        /// <summary> CE. </summary>
        public static NetworkDeviceRoleType CE { get; } = new NetworkDeviceRoleType(CEValue);
        /// <summary> ToR. </summary>
        public static NetworkDeviceRoleType ToR { get; } = new NetworkDeviceRoleType(ToRValue);
        /// <summary> NPB. </summary>
        public static NetworkDeviceRoleType NPB { get; } = new NetworkDeviceRoleType(NPBValue);
        /// <summary> TS. </summary>
        public static NetworkDeviceRoleType TS { get; } = new NetworkDeviceRoleType(TSValue);
        /// <summary> Management. </summary>
        public static NetworkDeviceRoleType Management { get; } = new NetworkDeviceRoleType(ManagementValue);
        /// <summary> Determines if two <see cref="NetworkDeviceRoleType"/> values are the same. </summary>
        public static bool operator ==(NetworkDeviceRoleType left, NetworkDeviceRoleType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="NetworkDeviceRoleType"/> values are not the same. </summary>
        public static bool operator !=(NetworkDeviceRoleType left, NetworkDeviceRoleType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="NetworkDeviceRoleType"/>. </summary>
        public static implicit operator NetworkDeviceRoleType(string value) => new NetworkDeviceRoleType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is NetworkDeviceRoleType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(NetworkDeviceRoleType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
