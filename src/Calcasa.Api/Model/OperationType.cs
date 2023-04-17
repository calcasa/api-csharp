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
 * The version of the OpenAPI document: 1.2.1
 * Contact: info@calcasa.nl
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using FileParameter = Calcasa.Api.Client.FileParameter;
using OpenAPIDateConverter = Calcasa.Api.Client.OpenAPIDateConverter;

namespace Calcasa.Api.Model
{
    /// <summary>
    ///  | Waarde | Omschrijving | | - -- | - -- | | &#x60;add&#x60; |  | | &#x60;remove&#x60; |  | | &#x60;replace&#x60; |  | | &#x60;move&#x60; |  | | &#x60;copy&#x60; |  | | &#x60;test&#x60; |  | | &#x60;invalid&#x60; |  |   
    /// </summary>
    /// <value> | Waarde | Omschrijving | | - -- | - -- | | &#x60;add&#x60; |  | | &#x60;remove&#x60; |  | | &#x60;replace&#x60; |  | | &#x60;move&#x60; |  | | &#x60;copy&#x60; |  | | &#x60;test&#x60; |  | | &#x60;invalid&#x60; |  |   </value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum OperationType
    {
        /// <summary>
        /// Enum Add for value: add
        /// </summary>
        [EnumMember(Value = "add")]
        Add = 1,

        /// <summary>
        /// Enum Remove for value: remove
        /// </summary>
        [EnumMember(Value = "remove")]
        Remove = 2,

        /// <summary>
        /// Enum Replace for value: replace
        /// </summary>
        [EnumMember(Value = "replace")]
        Replace = 3,

        /// <summary>
        /// Enum Move for value: move
        /// </summary>
        [EnumMember(Value = "move")]
        Move = 4,

        /// <summary>
        /// Enum Copy for value: copy
        /// </summary>
        [EnumMember(Value = "copy")]
        Copy = 5,

        /// <summary>
        /// Enum Test for value: test
        /// </summary>
        [EnumMember(Value = "test")]
        Test = 6,

        /// <summary>
        /// Enum Invalid for value: invalid
        /// </summary>
        [EnumMember(Value = "invalid")]
        Invalid = 7

    }

}
