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
 * The version of the OpenAPI document: 1.2.0
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
    /// Herstel-types voor funderingen. | Waarde | Omschrijving | | - -- | - -- | | &#x60;onbekendHerstelType&#x60; | Hersteltype is onbekend. | | &#x60;vergunning&#x60; | O.b.v. vergunning. | | &#x60;funderingRapport&#x60; | O.b.v. fundering-rapport. | | &#x60;archiefRapport&#x60; | O.b.v. archief-rapport. | | &#x60;eigenaarBewijs&#x60; | O.b.v. bewijs van eigenaar. |   
    /// </summary>
    /// <value>Herstel-types voor funderingen. | Waarde | Omschrijving | | - -- | - -- | | &#x60;onbekendHerstelType&#x60; | Hersteltype is onbekend. | | &#x60;vergunning&#x60; | O.b.v. vergunning. | | &#x60;funderingRapport&#x60; | O.b.v. fundering-rapport. | | &#x60;archiefRapport&#x60; | O.b.v. archief-rapport. | | &#x60;eigenaarBewijs&#x60; | O.b.v. bewijs van eigenaar. |   </value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum FunderingHerstelType
    {
        /// <summary>
        /// Enum OnbekendHerstelType for value: onbekendHerstelType
        /// </summary>
        [EnumMember(Value = "onbekendHerstelType")]
        OnbekendHerstelType = 1,

        /// <summary>
        /// Enum Vergunning for value: vergunning
        /// </summary>
        [EnumMember(Value = "vergunning")]
        Vergunning = 2,

        /// <summary>
        /// Enum FunderingRapport for value: funderingRapport
        /// </summary>
        [EnumMember(Value = "funderingRapport")]
        FunderingRapport = 3,

        /// <summary>
        /// Enum ArchiefRapport for value: archiefRapport
        /// </summary>
        [EnumMember(Value = "archiefRapport")]
        ArchiefRapport = 4,

        /// <summary>
        /// Enum EigenaarBewijs for value: eigenaarBewijs
        /// </summary>
        [EnumMember(Value = "eigenaarBewijs")]
        EigenaarBewijs = 5

    }

}
