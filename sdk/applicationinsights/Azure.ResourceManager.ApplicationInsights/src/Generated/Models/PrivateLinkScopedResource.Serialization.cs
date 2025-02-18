// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ApplicationInsights.Models
{
    public partial class PrivateLinkScopedResource
    {
        internal static PrivateLinkScopedResource DeserializePrivateLinkScopedResource(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> resourceId = default;
            Optional<string> scopeId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ResourceId"u8))
                {
                    resourceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ScopeId"u8))
                {
                    scopeId = property.Value.GetString();
                    continue;
                }
            }
            return new PrivateLinkScopedResource(resourceId.Value, scopeId.Value);
        }
    }
}
