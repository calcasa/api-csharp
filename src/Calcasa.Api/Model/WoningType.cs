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
    /// Woningtypes zoals gedefinieerd in het Calcasa-model. | Waarde | Omschrijving | | - -- | - -- | | &#x60;onbekend&#x60; | Onbekend woning type. | | &#x60;vrijstaand&#x60; | Vrijstaande woning. | | &#x60;halfVrijstaand&#x60; | Half-vrijstaande woning / twee-onder-een-kap.&lt;br&gt;            Heel speciaal type | | &#x60;hoekwoning&#x60; | Hoekwoning. | | &#x60;tussenwoning&#x60; | Tussenwoning. | | &#x60;galerijflat&#x60; | Galerijflat. | | &#x60;portiekflat&#x60; | Portiekflat. | | &#x60;maisonnette&#x60; | Maisonette. | | &#x60;bovenwoning&#x60; | Bovenwoning. | | &#x60;benedenwoning&#x60; | Benedenwoning. |   
    /// </summary>
    /// <value>Woningtypes zoals gedefinieerd in het Calcasa-model. | Waarde | Omschrijving | | - -- | - -- | | &#x60;onbekend&#x60; | Onbekend woning type. | | &#x60;vrijstaand&#x60; | Vrijstaande woning. | | &#x60;halfVrijstaand&#x60; | Half-vrijstaande woning / twee-onder-een-kap.&lt;br&gt;            Heel speciaal type | | &#x60;hoekwoning&#x60; | Hoekwoning. | | &#x60;tussenwoning&#x60; | Tussenwoning. | | &#x60;galerijflat&#x60; | Galerijflat. | | &#x60;portiekflat&#x60; | Portiekflat. | | &#x60;maisonnette&#x60; | Maisonette. | | &#x60;bovenwoning&#x60; | Bovenwoning. | | &#x60;benedenwoning&#x60; | Benedenwoning. |   </value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum WoningType
    {
        /// <summary>
        /// Enum Onbekend for value: onbekend
        /// </summary>
        [EnumMember(Value = "onbekend")]
        Onbekend = 1,

        /// <summary>
        /// Enum Vrijstaand for value: vrijstaand
        /// </summary>
        [EnumMember(Value = "vrijstaand")]
        Vrijstaand = 2,

        /// <summary>
        /// Enum HalfVrijstaand for value: halfVrijstaand
        /// </summary>
        [EnumMember(Value = "halfVrijstaand")]
        HalfVrijstaand = 3,

        /// <summary>
        /// Enum Hoekwoning for value: hoekwoning
        /// </summary>
        [EnumMember(Value = "hoekwoning")]
        Hoekwoning = 4,

        /// <summary>
        /// Enum Tussenwoning for value: tussenwoning
        /// </summary>
        [EnumMember(Value = "tussenwoning")]
        Tussenwoning = 5,

        /// <summary>
        /// Enum Galerijflat for value: galerijflat
        /// </summary>
        [EnumMember(Value = "galerijflat")]
        Galerijflat = 6,

        /// <summary>
        /// Enum Portiekflat for value: portiekflat
        /// </summary>
        [EnumMember(Value = "portiekflat")]
        Portiekflat = 7,

        /// <summary>
        /// Enum Maisonnette for value: maisonnette
        /// </summary>
        [EnumMember(Value = "maisonnette")]
        Maisonnette = 8,

        /// <summary>
        /// Enum Bovenwoning for value: bovenwoning
        /// </summary>
        [EnumMember(Value = "bovenwoning")]
        Bovenwoning = 9,

        /// <summary>
        /// Enum Benedenwoning for value: benedenwoning
        /// </summary>
        [EnumMember(Value = "benedenwoning")]
        Benedenwoning = 10

    }

}
