/*
 * Copyright 2022 Calcasa B.V.
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
 * Calcasa Public API v1
 *
 * The version of the OpenAPI document: 1.1.6
 * Contact: info@calcasa.nl
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */
using System.Collections.Generic;
using System.Web;

namespace Calcasa.Api.Client
{
    /// <summary>
    /// A URI builder
    /// </summary>
    class WebRequestPathBuilder
    {
            private string _baseUrl;
            private string _path;
            private string _query = "?";
            public WebRequestPathBuilder(string baseUrl, string path)
            {
                _baseUrl = baseUrl;
                _path = path;
            }

            public void AddPathParameters(Dictionary<string, string> parameters)
            {
                foreach (var parameter in parameters)
                {
                    _path = _path.Replace("{" + parameter.Key + "}", HttpUtility.UrlEncode(parameter.Value));
                }
            }

            public void AddQueryParameters(Multimap<string, string> parameters)
            {
                foreach (var parameter in parameters)
                {
                    foreach (var value in parameter.Value)
                    {
                        _query = _query + parameter.Key + "=" + HttpUtility.UrlEncode(value) + "&";
                    }
                }
            }

            public string GetFullUri()
            {
                return _baseUrl + _path + _query.Substring(0, _query.Length - 1);
            }
    }
}
