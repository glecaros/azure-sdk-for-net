// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.AppService;

namespace Azure.ResourceManager.AppService.Models
{
    internal partial class DiagnosticCategoryCollection
    {
        internal static DiagnosticCategoryCollection DeserializeDiagnosticCategoryCollection(JsonElement element)
        {
            IReadOnlyList<DiagnosticCategoryData> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    List<DiagnosticCategoryData> array = new List<DiagnosticCategoryData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DiagnosticCategoryData.DeserializeDiagnosticCategoryData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new DiagnosticCategoryCollection(value, nextLink.Value);
        }
    }
}
