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
 * The version of the OpenAPI document: 1.1.5
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
    ///  | Waarde | Omschrijving | | - -- | - -- | | &#x60;geenData&#x60; | Er is geen data beschikbaar over deze bodem. | | &#x60;onbekend&#x60; | De status van deze bodem is niet bekend. | | &#x60;nietVervuild&#x60; | De bodem is niet vervuild. | | &#x60;nietErnstig&#x60; | De bodem is niet ernstig vervuild. | | &#x60;potentieelErnstig&#x60; | De bodem is potentieel ernstig veruild. | | &#x60;ernstig&#x60; | De bodem is ernstig veruild. |   
    /// </summary>
    /// <value> | Waarde | Omschrijving | | - -- | - -- | | &#x60;geenData&#x60; | Er is geen data beschikbaar over deze bodem. | | &#x60;onbekend&#x60; | De status van deze bodem is niet bekend. | | &#x60;nietVervuild&#x60; | De bodem is niet vervuild. | | &#x60;nietErnstig&#x60; | De bodem is niet ernstig vervuild. | | &#x60;potentieelErnstig&#x60; | De bodem is potentieel ernstig veruild. | | &#x60;ernstig&#x60; | De bodem is ernstig veruild. |   </value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum BodemStatusType
    {
        /// <summary>
        /// Enum GeenData for value: geenData
        /// </summary>
        [EnumMember(Value = "geenData")]
        GeenData = 1,

        /// <summary>
        /// Enum Onbekend for value: onbekend
        /// </summary>
        [EnumMember(Value = "onbekend")]
        Onbekend = 2,

        /// <summary>
        /// Enum NietVervuild for value: nietVervuild
        /// </summary>
        [EnumMember(Value = "nietVervuild")]
        NietVervuild = 3,

        /// <summary>
        /// Enum NietErnstig for value: nietErnstig
        /// </summary>
        [EnumMember(Value = "nietErnstig")]
        NietErnstig = 4,

        /// <summary>
        /// Enum PotentieelErnstig for value: potentieelErnstig
        /// </summary>
        [EnumMember(Value = "potentieelErnstig")]
        PotentieelErnstig = 5,

        /// <summary>
        /// Enum Ernstig for value: ernstig
        /// </summary>
        [EnumMember(Value = "ernstig")]
        Ernstig = 6

    }

}
