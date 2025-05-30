// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Communication.Messages
{
    /// <summary> The kind of Interactive message content. </summary>
    internal readonly partial struct MessageContentKind : IEquatable<MessageContentKind>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="MessageContentKind"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MessageContentKind(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string TextValue = "text";
        private const string ImageValue = "image";
        private const string VideoValue = "video";
        private const string DocumentValue = "document";
        private const string GroupValue = "group";
        private const string ButtonSetValue = "buttonSet";
        private const string UrlValue = "url";

        /// <summary> The text content type. </summary>
        public static MessageContentKind Text { get; } = new MessageContentKind(TextValue);
        /// <summary> The image content type. </summary>
        public static MessageContentKind Image { get; } = new MessageContentKind(ImageValue);
        /// <summary> The video content type. </summary>
        public static MessageContentKind Video { get; } = new MessageContentKind(VideoValue);
        /// <summary> The document content type. </summary>
        public static MessageContentKind Document { get; } = new MessageContentKind(DocumentValue);
        /// <summary> The ActionSet content type. </summary>
        public static MessageContentKind Group { get; } = new MessageContentKind(GroupValue);
        /// <summary> The ButtonSet content type. </summary>
        public static MessageContentKind ButtonSet { get; } = new MessageContentKind(ButtonSetValue);
        /// <summary> The Url content type. </summary>
        public static MessageContentKind Url { get; } = new MessageContentKind(UrlValue);
        /// <summary> Determines if two <see cref="MessageContentKind"/> values are the same. </summary>
        public static bool operator ==(MessageContentKind left, MessageContentKind right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MessageContentKind"/> values are not the same. </summary>
        public static bool operator !=(MessageContentKind left, MessageContentKind right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="MessageContentKind"/>. </summary>
        public static implicit operator MessageContentKind(string value) => new MessageContentKind(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MessageContentKind other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MessageContentKind other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
