// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.WorkloadsSapVirtualInstance.Models
{
    /// <summary> The high availability type (AvailabilitySet or AvailabilityZone). </summary>
    public readonly partial struct SapHighAvailabilityType : IEquatable<SapHighAvailabilityType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SapHighAvailabilityType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SapHighAvailabilityType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AvailabilitySetValue = "AvailabilitySet";
        private const string AvailabilityZoneValue = "AvailabilityZone";

        /// <summary> HA deployment with availability sets. </summary>
        public static SapHighAvailabilityType AvailabilitySet { get; } = new SapHighAvailabilityType(AvailabilitySetValue);
        /// <summary> HA deployment with availability zones. </summary>
        public static SapHighAvailabilityType AvailabilityZone { get; } = new SapHighAvailabilityType(AvailabilityZoneValue);
        /// <summary> Determines if two <see cref="SapHighAvailabilityType"/> values are the same. </summary>
        public static bool operator ==(SapHighAvailabilityType left, SapHighAvailabilityType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SapHighAvailabilityType"/> values are not the same. </summary>
        public static bool operator !=(SapHighAvailabilityType left, SapHighAvailabilityType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="SapHighAvailabilityType"/>. </summary>
        public static implicit operator SapHighAvailabilityType(string value) => new SapHighAvailabilityType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SapHighAvailabilityType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SapHighAvailabilityType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
