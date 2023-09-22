/*
 * Copyright 2023 Calcasa B.V.
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
 * The version of the OpenAPI document: 1.3.0
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
    /// Indicatie voor een funderingsrisico. | Waarde | Omschrijving | | - -- | - -- | | &#x60;onbekend&#x60; | Risico klasse onbekend. | | &#x60;laag&#x60; | Laagste risico. | | &#x60;gemiddeld&#x60; | Gemiddeld risico. | | &#x60;hoog&#x60; | Hoogste risico. |   
    /// </summary>
    /// <value>Indicatie voor een funderingsrisico. | Waarde | Omschrijving | | - -- | - -- | | &#x60;onbekend&#x60; | Risico klasse onbekend. | | &#x60;laag&#x60; | Laagste risico. | | &#x60;gemiddeld&#x60; | Gemiddeld risico. | | &#x60;hoog&#x60; | Hoogste risico. |   </value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum FunderingRisicoLabel
    {
        /// <summary>
        /// Enum Onbekend for value: onbekend
        /// </summary>
        [EnumMember(Value = "onbekend")]
        Onbekend = 1,

        /// <summary>
        /// Enum Laag for value: laag
        /// </summary>
        [EnumMember(Value = "laag")]
        Laag = 2,

        /// <summary>
        /// Enum Gemiddeld for value: gemiddeld
        /// </summary>
        [EnumMember(Value = "gemiddeld")]
        Gemiddeld = 3,

        /// <summary>
        /// Enum Hoog for value: hoog
        /// </summary>
        [EnumMember(Value = "hoog")]
        Hoog = 4

    }

}
