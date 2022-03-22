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
 * The version of the OpenAPI document: 1.1.3
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
    ///  | Waarde | Omschrijving | | - -- | - -- | | &#x60;geen&#x60; | De input was correct. | | &#x60;gecorrigeerd&#x60; | De input was gecorrigeerd. | | &#x60;onbekend&#x60; | De input is onbekend en kon niet gevonden of gecorrigeerd worden. | | &#x60;ontbreekt&#x60; | De input was leeg en is wel nodig voor een succesvolle zoekopdracht. |   
    /// </summary>
    /// <value> | Waarde | Omschrijving | | - -- | - -- | | &#x60;geen&#x60; | De input was correct. | | &#x60;gecorrigeerd&#x60; | De input was gecorrigeerd. | | &#x60;onbekend&#x60; | De input is onbekend en kon niet gevonden of gecorrigeerd worden. | | &#x60;ontbreekt&#x60; | De input was leeg en is wel nodig voor een succesvolle zoekopdracht. |   </value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Notitie
    {
        /// <summary>
        /// Enum Geen for value: geen
        /// </summary>
        [EnumMember(Value = "geen")]
        Geen = 1,

        /// <summary>
        /// Enum Gecorrigeerd for value: gecorrigeerd
        /// </summary>
        [EnumMember(Value = "gecorrigeerd")]
        Gecorrigeerd = 2,

        /// <summary>
        /// Enum Onbekend for value: onbekend
        /// </summary>
        [EnumMember(Value = "onbekend")]
        Onbekend = 3,

        /// <summary>
        /// Enum Ontbreekt for value: ontbreekt
        /// </summary>
        [EnumMember(Value = "ontbreekt")]
        Ontbreekt = 4

    }

}
