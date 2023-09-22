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
    ///  | Waarde | Omschrijving | | - -- | - -- | | &#x60;onbekend&#x60; |  | | &#x60;g&#x60; |  | | &#x60;f&#x60; |  | | &#x60;e&#x60; |  | | &#x60;d&#x60; |  | | &#x60;c&#x60; |  | | &#x60;b&#x60; |  | | &#x60;a&#x60; |  | | &#x60;a1&#x60; | A+ | | &#x60;a2&#x60; | A++ | | &#x60;a3&#x60; | A+++ | | &#x60;a4&#x60; | A++++ |   
    /// </summary>
    /// <value> | Waarde | Omschrijving | | - -- | - -- | | &#x60;onbekend&#x60; |  | | &#x60;g&#x60; |  | | &#x60;f&#x60; |  | | &#x60;e&#x60; |  | | &#x60;d&#x60; |  | | &#x60;c&#x60; |  | | &#x60;b&#x60; |  | | &#x60;a&#x60; |  | | &#x60;a1&#x60; | A+ | | &#x60;a2&#x60; | A++ | | &#x60;a3&#x60; | A+++ | | &#x60;a4&#x60; | A++++ |   </value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Energielabel
    {
        /// <summary>
        /// Enum Onbekend for value: onbekend
        /// </summary>
        [EnumMember(Value = "onbekend")]
        Onbekend = 1,

        /// <summary>
        /// Enum G for value: g
        /// </summary>
        [EnumMember(Value = "g")]
        G = 2,

        /// <summary>
        /// Enum F for value: f
        /// </summary>
        [EnumMember(Value = "f")]
        F = 3,

        /// <summary>
        /// Enum E for value: e
        /// </summary>
        [EnumMember(Value = "e")]
        E = 4,

        /// <summary>
        /// Enum D for value: d
        /// </summary>
        [EnumMember(Value = "d")]
        D = 5,

        /// <summary>
        /// Enum C for value: c
        /// </summary>
        [EnumMember(Value = "c")]
        C = 6,

        /// <summary>
        /// Enum B for value: b
        /// </summary>
        [EnumMember(Value = "b")]
        B = 7,

        /// <summary>
        /// Enum A for value: a
        /// </summary>
        [EnumMember(Value = "a")]
        A = 8,

        /// <summary>
        /// Enum A1 for value: a1
        /// </summary>
        [EnumMember(Value = "a1")]
        A1 = 9,

        /// <summary>
        /// Enum A2 for value: a2
        /// </summary>
        [EnumMember(Value = "a2")]
        A2 = 10,

        /// <summary>
        /// Enum A3 for value: a3
        /// </summary>
        [EnumMember(Value = "a3")]
        A3 = 11,

        /// <summary>
        /// Enum A4 for value: a4
        /// </summary>
        [EnumMember(Value = "a4")]
        A4 = 12

    }

}
