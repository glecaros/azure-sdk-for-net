// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.ApplicationInsights;

namespace Azure.ResourceManager.ApplicationInsights.Models
{
    /// <summary> Describes the list of Application Insights Resources. </summary>
    internal partial class ApplicationInsightsComponentListResult
    {
        /// <summary> Initializes a new instance of ApplicationInsightsComponentListResult. </summary>
        /// <param name="value"> List of Application Insights component definitions. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal ApplicationInsightsComponentListResult(IEnumerable<ApplicationInsightsComponentData> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of ApplicationInsightsComponentListResult. </summary>
        /// <param name="value"> List of Application Insights component definitions. </param>
        /// <param name="nextLink"> The URI to get the next set of Application Insights component definitions if too many components where returned in the result set. </param>
        internal ApplicationInsightsComponentListResult(IReadOnlyList<ApplicationInsightsComponentData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> List of Application Insights component definitions. </summary>
        public IReadOnlyList<ApplicationInsightsComponentData> Value { get; }
        /// <summary> The URI to get the next set of Application Insights component definitions if too many components where returned in the result set. </summary>
        public string NextLink { get; }
    }
}
