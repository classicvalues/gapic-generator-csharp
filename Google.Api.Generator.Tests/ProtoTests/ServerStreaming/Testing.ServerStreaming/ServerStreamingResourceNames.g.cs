﻿// Copyright 2019 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Generated code. DO NOT EDIT!

using gax = Google.Api.Gax;
using sys = System;
using ts = Testing.ServerStreaming;

namespace Testing.ServerStreaming
{
    /// <summary>Resource name for the <c>Resource</c> resource.</summary>
    public sealed partial class ResourceName : gax::IResourceName, sys::IEquatable<ResourceName>
    {
        /// <summary>The possible contents of <see cref="ResourceName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>A resource of an unknown type.</summary>
            Unknown = 0,

            /// <summary>A resource name with pattern <c>items/{item_id}</c>.</summary>
            Item = 1
        }

        private static gax::PathTemplate s_item = new gax::PathTemplate("items/{item_id}");

        /// <summary>Creates a <see cref="ResourceName"/> containing an unknown resource name.</summary>
        /// <param name="unknownResourceName">The unknown resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ResourceName"/> containing the provided <paramref name="unknownResourceName"/>.
        /// </returns>
        public static ResourceName FromUnknown(gax::UnknownResourceName unknownResourceName) =>
            new ResourceName(ResourceNameType.Unknown, gax::GaxPreconditions.CheckNotNull(unknownResourceName, nameof(unknownResourceName)));

        /// <summary>Creates a <see cref="ResourceName"/> with the pattern <c>items/{item_id}</c>.</summary>
        /// <param name="itemId">The <c>Item</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ResourceName"/> constructed from the provided ids.</returns>
        public static ResourceName FromItem(string itemId) =>
            new ResourceName(ResourceNameType.Item, itemId: gax::GaxPreconditions.CheckNotNullOrEmpty(itemId, nameof(itemId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ResourceName"/> with pattern
        /// <c>items/{item_id}</c>.
        /// </summary>
        /// <param name="itemId">The <c>Item</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ResourceName"/> with pattern <c>items/{item_id}</c>.
        /// </returns>
        public static string Format(string itemId) => FormatItem(itemId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ResourceName"/> with pattern
        /// <c>items/{item_id}</c>.
        /// </summary>
        /// <param name="itemId">The <c>Item</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ResourceName"/> with pattern <c>items/{item_id}</c>.
        /// </returns>
        public static string FormatItem(string itemId) =>
            s_item.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(itemId, nameof(itemId)));

        /// <summary>Parses the given resource name string into a new <see cref="ResourceName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>items/{item_id}</c></description></item></list>
        /// </remarks>
        /// <param name="resourceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ResourceName"/> if successful.</returns>
        public static ResourceName Parse(string resourceName) => Parse(resourceName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ResourceName"/> instance; optionally allowing an
        /// unknown resource name to be successfully parsed
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>items/{item_id}</c></description></item></list>
        /// Or may be in any format if <paramref name="allowUnknown"/> is <c>true</c>.
        /// </remarks>
        /// <param name="resourceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnknown">
        /// If <c>true</c> will successfully parse an unknown resource name into the <see cref="UnknownResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unknown resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ResourceName"/> if successful.</returns>
        public static ResourceName Parse(string resourceName, bool allowUnknown) =>
            TryParse(resourceName, allowUnknown, out ResourceName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ResourceName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>items/{item_id}</c></description></item></list>
        /// </remarks>
        /// <param name="resourceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ResourceName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string resourceName, out ResourceName result) => TryParse(resourceName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ResourceName"/> instance; optionally
        /// allowing an unknown resource name to be successfully parsed.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>items/{item_id}</c></description></item></list>
        /// Or may be in any format if <paramref name="allowUnknown"/> is <c>true</c>.
        /// </remarks>
        /// <param name="resourceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnknown">
        /// If <c>true</c> will successfully parse an unknown resource name into the <see cref="UnknownResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unknown resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ResourceName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string resourceName, bool allowUnknown, out ResourceName result)
        {
            gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName));
            gax::TemplatedResourceName resourceName2;
            if (s_item.TryParseName(resourceName, out resourceName2))
            {
                result = FromItem(resourceName2[0]);
                return true;
            }
            if (allowUnknown)
            {
                if (gax::UnknownResourceName.TryParse(resourceName, out gax::UnknownResourceName unknownResourceName))
                {
                    result = FromUnknown(unknownResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ResourceName(ResourceNameType type, gax::UnknownResourceName unknownResourceName = null, string itemId = null)
        {
            Type = type;
            UnknownResource = unknownResourceName;
            ItemId = itemId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ResourceName"/> class from the component parts of pattern
        /// <c>items/{item_id}</c>
        /// </summary>
        /// <param name="itemId">The <c>Item</c> ID. Must not be <c>null</c> or empty.</param>
        public ResourceName(string itemId) : this(ResourceNameType.Item, itemId: gax::GaxPreconditions.CheckNotNullOrEmpty(itemId, nameof(itemId)))
        {
        }

        /// <summary>The <see cref="ResourceNameType"/> of the contained resource name.</summary>
        public ResourceNameType Type { get; }

        /// <summary>
        /// The contained <see cref="gax::UnknownResourceName"/>. Only non-<c>null</c>if this instance contains an
        /// unknown resource name.
        /// </summary>
        public gax::UnknownResourceName UnknownResource { get; }

        /// <summary>
        /// The <c>Item</c> ID. Will not be <c>null</c>, unless this instance contains an unknown resource name.
        /// </summary>
        public string ItemId { get; }

        /// <inheritdoc/>
        public gax::ResourceNameKind Kind => Type == ResourceNameType.Unknown ? gax::ResourceNameKind.Unknown : gax::ResourceNameKind.Simple;

        /// <inheritdoc/>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unknown: return UnknownResource.ToString();
                case ResourceNameType.Item: return s_item.Expand(ItemId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <inheritdoc/>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ResourceName);

        /// <inheritdoc/>
        public bool Equals(ResourceName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(ResourceName a, ResourceName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(ResourceName a, ResourceName b) => !(a == b);
    }

    public partial class Resource
    {
        /// <summary>
        /// <see cref="ts::ResourceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public ts::ResourceName ResourceName
        {
            get => string.IsNullOrEmpty(Name) ? null : ts::ResourceName.Parse(Name);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ResourceRequest
    {
        /// <summary>
        /// <see cref="ts::ResourceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public ts::ResourceName ResourceName
        {
            get => string.IsNullOrEmpty(Name) ? null : ts::ResourceName.Parse(Name);
            set => Name = value?.ToString() ?? "";
        }
    }
}
