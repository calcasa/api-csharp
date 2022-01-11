/*
 * Copyright 2021 Calcasa B.V.
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
 * The version of the OpenAPI document: 1.0.2
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
using System.ComponentModel.DataAnnotations;
using FileParameter = Calcasa.Api.Client.FileParameter;
using OpenAPIDateConverter = Calcasa.Api.Client.OpenAPIDateConverter;

namespace Calcasa.Api.Model
{
    /// <summary>
    /// English: Request Goal | Waarde | Omschrijving | | - -- | - -- | | &#x60;onbekend&#x60; | English: Unknown | | &#x60;aankoopNieuweWoning&#x60; | English: New Home Purchase | | &#x60;overbruggingsfinanciering&#x60; | English: Bridge Financing | | &#x60;hypotheekOversluiten&#x60; | English: Refinancing Mortgage | | &#x60;hypotheekOphogen&#x60; | English: Increasing Mortage | | &#x60;hypotheekWijziging&#x60; | English: Changing Mortgage | | &#x60;hypotheekrenteWijzigen&#x60; | English: Change Mortgage Intrest |   
    /// </summary>
    /// <value>English: Request Goal | Waarde | Omschrijving | | - -- | - -- | | &#x60;onbekend&#x60; | English: Unknown | | &#x60;aankoopNieuweWoning&#x60; | English: New Home Purchase | | &#x60;overbruggingsfinanciering&#x60; | English: Bridge Financing | | &#x60;hypotheekOversluiten&#x60; | English: Refinancing Mortgage | | &#x60;hypotheekOphogen&#x60; | English: Increasing Mortage | | &#x60;hypotheekWijziging&#x60; | English: Changing Mortgage | | &#x60;hypotheekrenteWijzigen&#x60; | English: Change Mortgage Intrest |   </value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Aanvraagdoel
    {
        /// <summary>
        /// Enum Onbekend for value: onbekend
        /// </summary>
        [EnumMember(Value = "onbekend")]
        Onbekend = 1,

        /// <summary>
        /// Enum AankoopNieuweWoning for value: aankoopNieuweWoning
        /// </summary>
        [EnumMember(Value = "aankoopNieuweWoning")]
        AankoopNieuweWoning = 2,

        /// <summary>
        /// Enum Overbruggingsfinanciering for value: overbruggingsfinanciering
        /// </summary>
        [EnumMember(Value = "overbruggingsfinanciering")]
        Overbruggingsfinanciering = 3,

        /// <summary>
        /// Enum HypotheekOversluiten for value: hypotheekOversluiten
        /// </summary>
        [EnumMember(Value = "hypotheekOversluiten")]
        HypotheekOversluiten = 4,

        /// <summary>
        /// Enum HypotheekOphogen for value: hypotheekOphogen
        /// </summary>
        [EnumMember(Value = "hypotheekOphogen")]
        HypotheekOphogen = 5,

        /// <summary>
        /// Enum HypotheekWijziging for value: hypotheekWijziging
        /// </summary>
        [EnumMember(Value = "hypotheekWijziging")]
        HypotheekWijziging = 6,

        /// <summary>
        /// Enum HypotheekrenteWijzigen for value: hypotheekrenteWijzigen
        /// </summary>
        [EnumMember(Value = "hypotheekrenteWijzigen")]
        HypotheekrenteWijzigen = 7

    }

}
