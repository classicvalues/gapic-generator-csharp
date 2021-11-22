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

namespace Testing.Keywords.Snippets
{
    // [START unknown_generated_Keywords_Method1_async_flattened]
    using System.Threading.Tasks;
    using Testing.Keywords;

    public sealed partial class GeneratedKeywordsClientStandaloneSnippets
    {
        /// <summary>Snippet for Method1Async</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public async Task Method1Async()
        {
            // Create client
            KeywordsClient keywordsClient = await KeywordsClient.CreateAsync();
            // Initialize request argument(s)
            string @event = "items/[ITEM_ID]";
            int @switch = 0;
            Enum @void = Enum.Void;
            string request = "";
            string types = "";
            // Make the request
            Response response = await keywordsClient.Method1Async(@event, @switch, @void, request, types);
        }
    }
    // [END unknown_generated_Keywords_Method1_async_flattened]
}
