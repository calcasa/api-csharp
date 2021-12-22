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
 * The version of the OpenAPI document: 1.0.1
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
    ///  | Waarde | Omschrijving | | - -- | - -- | | &#x60;onbekend&#x60; | Bijzonderheden onbekend. | | &#x60;executieverkoop&#x60; | Een indicatie dat het object is verkocht via een executieveiling. | | &#x60;familieverkoop&#x60; | Een indicatie dat de transactie is geregistreerd als familieverkoop. | | &#x60;meerOnroerendGoed&#x60; | Een indicatie dat de transactie meerdere percelen bevat. | | &#x60;zittendeHuurder&#x60; | Een indicatie dat de transactie is geregistreerd als verkoop aan de zittende huurder. | | &#x60;verkoperNietNatuurlijk&#x60; | Een indicatie dat de verkoper een niet-natuurlijke persoon is. | | &#x60;koperNietNatuurlijk&#x60; | Een indicatie dat de koper een niet-natuurlijke persoon is. | | &#x60;nietWoning&#x60; | Een indicatie dat het object geregistreerd is als niet-woning. | | &#x60;erfdienstbaarheid&#x60; | Een indicatie dat er een erfdienstbaarheid op het object gevestigd is. |   
    /// </summary>
    /// <value> | Waarde | Omschrijving | | - -- | - -- | | &#x60;onbekend&#x60; | Bijzonderheden onbekend. | | &#x60;executieverkoop&#x60; | Een indicatie dat het object is verkocht via een executieveiling. | | &#x60;familieverkoop&#x60; | Een indicatie dat de transactie is geregistreerd als familieverkoop. | | &#x60;meerOnroerendGoed&#x60; | Een indicatie dat de transactie meerdere percelen bevat. | | &#x60;zittendeHuurder&#x60; | Een indicatie dat de transactie is geregistreerd als verkoop aan de zittende huurder. | | &#x60;verkoperNietNatuurlijk&#x60; | Een indicatie dat de verkoper een niet-natuurlijke persoon is. | | &#x60;koperNietNatuurlijk&#x60; | Een indicatie dat de koper een niet-natuurlijke persoon is. | | &#x60;nietWoning&#x60; | Een indicatie dat het object geregistreerd is als niet-woning. | | &#x60;erfdienstbaarheid&#x60; | Een indicatie dat er een erfdienstbaarheid op het object gevestigd is. |   </value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum VerkoopBijzonderheden
    {
        /// <summary>
        /// Enum Onbekend for value: onbekend
        /// </summary>
        [EnumMember(Value = "onbekend")]
        Onbekend = 1,

        /// <summary>
        /// Enum Executieverkoop for value: executieverkoop
        /// </summary>
        [EnumMember(Value = "executieverkoop")]
        Executieverkoop = 2,

        /// <summary>
        /// Enum Familieverkoop for value: familieverkoop
        /// </summary>
        [EnumMember(Value = "familieverkoop")]
        Familieverkoop = 3,

        /// <summary>
        /// Enum MeerOnroerendGoed for value: meerOnroerendGoed
        /// </summary>
        [EnumMember(Value = "meerOnroerendGoed")]
        MeerOnroerendGoed = 4,

        /// <summary>
        /// Enum ZittendeHuurder for value: zittendeHuurder
        /// </summary>
        [EnumMember(Value = "zittendeHuurder")]
        ZittendeHuurder = 5,

        /// <summary>
        /// Enum VerkoperNietNatuurlijk for value: verkoperNietNatuurlijk
        /// </summary>
        [EnumMember(Value = "verkoperNietNatuurlijk")]
        VerkoperNietNatuurlijk = 6,

        /// <summary>
        /// Enum KoperNietNatuurlijk for value: koperNietNatuurlijk
        /// </summary>
        [EnumMember(Value = "koperNietNatuurlijk")]
        KoperNietNatuurlijk = 7,

        /// <summary>
        /// Enum NietWoning for value: nietWoning
        /// </summary>
        [EnumMember(Value = "nietWoning")]
        NietWoning = 8,

        /// <summary>
        /// Enum Erfdienstbaarheid for value: erfdienstbaarheid
        /// </summary>
        [EnumMember(Value = "erfdienstbaarheid")]
        Erfdienstbaarheid = 9

    }

}
