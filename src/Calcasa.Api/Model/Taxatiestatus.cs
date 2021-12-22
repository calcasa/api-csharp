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
    ///  | Waarde | Omschrijving | | - -- | - -- | | &#x60;nietGecontroleerd&#x60; | Status is onbekend of niet van toepassing. | | &#x60;goedgekeurd&#x60; | De waardering is geaccepteerd door een taxateur. | | &#x60;afgekeurd&#x60; | De waardering is afgewezen door een taxateur. |   
    /// </summary>
    /// <value> | Waarde | Omschrijving | | - -- | - -- | | &#x60;nietGecontroleerd&#x60; | Status is onbekend of niet van toepassing. | | &#x60;goedgekeurd&#x60; | De waardering is geaccepteerd door een taxateur. | | &#x60;afgekeurd&#x60; | De waardering is afgewezen door een taxateur. |   </value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Taxatiestatus
    {
        /// <summary>
        /// Enum NietGecontroleerd for value: nietGecontroleerd
        /// </summary>
        [EnumMember(Value = "nietGecontroleerd")]
        NietGecontroleerd = 1,

        /// <summary>
        /// Enum Goedgekeurd for value: goedgekeurd
        /// </summary>
        [EnumMember(Value = "goedgekeurd")]
        Goedgekeurd = 2,

        /// <summary>
        /// Enum Afgekeurd for value: afgekeurd
        /// </summary>
        [EnumMember(Value = "afgekeurd")]
        Afgekeurd = 3

    }

}
