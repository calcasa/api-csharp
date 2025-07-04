// <auto-generated>
/*
 * Copyright 2025 Calcasa B.V.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 * 
 *     http://www.apache.org/licenses/LICENSE-2.0
 * 
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 *
 * Calcasa Public API
 *
 * The Calcasa API is used to connect to Calcasa provided services. For more information, please visit [Documentation](https://docs.calcasa.nl) or [GitHub](https://github.com/calcasa/api).
 *
 * The version of the OpenAPI document: 1.4.0-rc1
 * Contact: info@calcasa.nl
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

#nullable enable

using System;
using System.IO;

namespace Calcasa.Api.Client
{
    /// <summary>
    /// API Exception
    /// </summary>
    public class ApiException : Exception
    {
        /// <summary>
        /// The reason the api request failed
        /// </summary>
        public string? ReasonPhrase { get; }

        /// <summary>
        /// The HttpStatusCode
        /// </summary>
        public System.Net.HttpStatusCode StatusCode { get; }

        /// <summary>
        /// The raw data returned by the api
        /// </summary>
        public string RawContent { get; }

        /// <summary>
        /// The HttpResponseMessage object
        /// </summary>
        public System.Net.Http.HttpResponseMessage? RawResponse { get; }
        
        /// <summary>
        /// Construct the ApiException from parts of the response
        /// </summary>
        /// <param name="reasonPhrase"></param>
        /// <param name="statusCode"></param>
        /// <param name="rawContent"></param>
        public ApiException(string? reasonPhrase, System.Net.HttpStatusCode statusCode, string rawContent, System.Net.Http.HttpResponseMessage? rawResponse = null) : base(reasonPhrase ?? rawContent)
        {
            ReasonPhrase = reasonPhrase;

            StatusCode = statusCode;

            RawContent = rawContent;

            RawResponse = rawResponse;
        }
    }
}
