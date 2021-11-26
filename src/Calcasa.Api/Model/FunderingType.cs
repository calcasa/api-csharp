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
 * Calcasa Public API v0
 *
 * The version of the OpenAPI document: 0.0.5
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
    /// Funderingstypes. | Waarde | Omschrijving | | - -- | - -- | | &#x60;onbekendFunderingType&#x60; | Onbekend fundering-type | | &#x60;hout&#x60; | Hout. | | &#x60;houtAmsterdam&#x60; | Hout, Amsterdamse variant. | | &#x60;houtRotterdam&#x60; | Hout, Rotterdamse variant. | | &#x60;beton&#x60; | Beton. | | &#x60;nietOnderheid&#x60; | Niet onderheid. | | &#x60;nietOnderheidGemetseld&#x60; | Niet onderheid, gemetseld. | | &#x60;nietOnderheidStroken&#x60; | Niet onderheid, stroken. | | &#x60;nietOnderheidPlaat&#x60; | Niet onderheid, plaat. | | &#x60;nietOnderheidBetonplaat&#x60; | Niet onderheid, betonplaat. | | &#x60;nietOnderheidSlieten&#x60; | Niet onderheid, slieten. | | &#x60;houtOplanger&#x60; | Hout met oplanger. | | &#x60;betonVerzwaard&#x60; | Beton verzwaard. | | &#x60;gecombineerd&#x60; | Gecombineerd. | | &#x60;staal&#x60; | Stalen buispaal. | | &#x60;houtAmsterdamRotterdam&#x60; | Houten paal, Rotterdam/Amsterdam methode. | | &#x60;houtRotterdamSpaarboog&#x60; | Houten paal, Rotterdam methode met spaarboog. | | &#x60;houtAmsterdamSpaarboog&#x60; | Houten paal, Amsterdam methode met spaarboog. |   
    /// </summary>
    /// <value>Funderingstypes. | Waarde | Omschrijving | | - -- | - -- | | &#x60;onbekendFunderingType&#x60; | Onbekend fundering-type | | &#x60;hout&#x60; | Hout. | | &#x60;houtAmsterdam&#x60; | Hout, Amsterdamse variant. | | &#x60;houtRotterdam&#x60; | Hout, Rotterdamse variant. | | &#x60;beton&#x60; | Beton. | | &#x60;nietOnderheid&#x60; | Niet onderheid. | | &#x60;nietOnderheidGemetseld&#x60; | Niet onderheid, gemetseld. | | &#x60;nietOnderheidStroken&#x60; | Niet onderheid, stroken. | | &#x60;nietOnderheidPlaat&#x60; | Niet onderheid, plaat. | | &#x60;nietOnderheidBetonplaat&#x60; | Niet onderheid, betonplaat. | | &#x60;nietOnderheidSlieten&#x60; | Niet onderheid, slieten. | | &#x60;houtOplanger&#x60; | Hout met oplanger. | | &#x60;betonVerzwaard&#x60; | Beton verzwaard. | | &#x60;gecombineerd&#x60; | Gecombineerd. | | &#x60;staal&#x60; | Stalen buispaal. | | &#x60;houtAmsterdamRotterdam&#x60; | Houten paal, Rotterdam/Amsterdam methode. | | &#x60;houtRotterdamSpaarboog&#x60; | Houten paal, Rotterdam methode met spaarboog. | | &#x60;houtAmsterdamSpaarboog&#x60; | Houten paal, Amsterdam methode met spaarboog. |   </value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum FunderingType
    {
        /// <summary>
        /// Enum OnbekendFunderingType for value: onbekendFunderingType
        /// </summary>
        [EnumMember(Value = "onbekendFunderingType")]
        OnbekendFunderingType = 1,

        /// <summary>
        /// Enum Hout for value: hout
        /// </summary>
        [EnumMember(Value = "hout")]
        Hout = 2,

        /// <summary>
        /// Enum HoutAmsterdam for value: houtAmsterdam
        /// </summary>
        [EnumMember(Value = "houtAmsterdam")]
        HoutAmsterdam = 3,

        /// <summary>
        /// Enum HoutRotterdam for value: houtRotterdam
        /// </summary>
        [EnumMember(Value = "houtRotterdam")]
        HoutRotterdam = 4,

        /// <summary>
        /// Enum Beton for value: beton
        /// </summary>
        [EnumMember(Value = "beton")]
        Beton = 5,

        /// <summary>
        /// Enum NietOnderheid for value: nietOnderheid
        /// </summary>
        [EnumMember(Value = "nietOnderheid")]
        NietOnderheid = 6,

        /// <summary>
        /// Enum NietOnderheidGemetseld for value: nietOnderheidGemetseld
        /// </summary>
        [EnumMember(Value = "nietOnderheidGemetseld")]
        NietOnderheidGemetseld = 7,

        /// <summary>
        /// Enum NietOnderheidStroken for value: nietOnderheidStroken
        /// </summary>
        [EnumMember(Value = "nietOnderheidStroken")]
        NietOnderheidStroken = 8,

        /// <summary>
        /// Enum NietOnderheidPlaat for value: nietOnderheidPlaat
        /// </summary>
        [EnumMember(Value = "nietOnderheidPlaat")]
        NietOnderheidPlaat = 9,

        /// <summary>
        /// Enum NietOnderheidBetonplaat for value: nietOnderheidBetonplaat
        /// </summary>
        [EnumMember(Value = "nietOnderheidBetonplaat")]
        NietOnderheidBetonplaat = 10,

        /// <summary>
        /// Enum NietOnderheidSlieten for value: nietOnderheidSlieten
        /// </summary>
        [EnumMember(Value = "nietOnderheidSlieten")]
        NietOnderheidSlieten = 11,

        /// <summary>
        /// Enum HoutOplanger for value: houtOplanger
        /// </summary>
        [EnumMember(Value = "houtOplanger")]
        HoutOplanger = 12,

        /// <summary>
        /// Enum BetonVerzwaard for value: betonVerzwaard
        /// </summary>
        [EnumMember(Value = "betonVerzwaard")]
        BetonVerzwaard = 13,

        /// <summary>
        /// Enum Gecombineerd for value: gecombineerd
        /// </summary>
        [EnumMember(Value = "gecombineerd")]
        Gecombineerd = 14,

        /// <summary>
        /// Enum Staal for value: staal
        /// </summary>
        [EnumMember(Value = "staal")]
        Staal = 15,

        /// <summary>
        /// Enum HoutAmsterdamRotterdam for value: houtAmsterdamRotterdam
        /// </summary>
        [EnumMember(Value = "houtAmsterdamRotterdam")]
        HoutAmsterdamRotterdam = 16,

        /// <summary>
        /// Enum HoutRotterdamSpaarboog for value: houtRotterdamSpaarboog
        /// </summary>
        [EnumMember(Value = "houtRotterdamSpaarboog")]
        HoutRotterdamSpaarboog = 17,

        /// <summary>
        /// Enum HoutAmsterdamSpaarboog for value: houtAmsterdamSpaarboog
        /// </summary>
        [EnumMember(Value = "houtAmsterdamSpaarboog")]
        HoutAmsterdamSpaarboog = 18

    }

}
