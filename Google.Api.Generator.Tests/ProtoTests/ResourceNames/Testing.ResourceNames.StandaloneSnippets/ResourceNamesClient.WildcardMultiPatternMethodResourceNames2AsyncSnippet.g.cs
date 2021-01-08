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

namespace Testing.ResourceNames.Snippets
{
    using Google.Api.Gax;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public sealed partial class GeneratedResourceNamesClientStandaloneSnippets
    {
        /// <summary>Snippet for WildcardMultiPatternMethodAsync</summary>
        public async Task WildcardMultiPatternMethodResourceNames2Async()
        {
            // Snippet: WildcardMultiPatternMethodAsync(WildcardMultiPatternName, WildcardMultiPatternName, IEnumerable<IResourceName>, CallSettings)
            // Additional: WildcardMultiPatternMethodAsync(WildcardMultiPatternName, WildcardMultiPatternName, IEnumerable<IResourceName>, CancellationToken)
            // Create client
            ResourceNamesClient resourceNamesClient = await ResourceNamesClient.CreateAsync();
            // Initialize request argument(s)
            WildcardMultiPatternName name = WildcardMultiPatternName.FromSingularItem();
            WildcardMultiPatternName @ref = WildcardMultiPatternName.FromSingularItem();
            IEnumerable<IResourceName> repeatedRef = new IResourceName[]
            {
                new UnparsedResourceName("a/wildcard/resource"),
            };
            // Make the request
            Response response = await resourceNamesClient.WildcardMultiPatternMethodAsync(name, @ref, repeatedRef);
            // End snippet
        }
    }
}
