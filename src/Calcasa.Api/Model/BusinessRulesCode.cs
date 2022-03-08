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
 * The version of the OpenAPI document: 1.1.1
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
    /// Reden voor het niet voldoen aan de business rules. | Waarde | Omschrijving | | - -- | - -- | | &#x60;geenWaardebepalingMogelijk&#x60; | De ingevoerde woning kan modelmatig niet goed genoeg worden vastgesteld. | | &#x60;geenBestaandeWoning&#x60; | Geen bestaande koopwoning. | | &#x60;fouteOfOntbrekendeInvoer&#x60; | Noodzakelijke invoer ontbreekt of is foutief ingevoerd. | | &#x60;calcasaWaardeTeHoog&#x60; | Calcasa-waarde is te hoog volgens de business rules. | | &#x60;ltvTeHoog&#x60; | Loan-to-value is te hoog volgens de business rules. | | &#x60;hypotheekTeHoog&#x60; | Hypotheekbedrag is te hoog volgens de business rules. | | &#x60;woningtypeIncorrect&#x60; | Woningtype is incorrect volgens de business rules. | | &#x60;calcasaWaardeTeLaag&#x60; | Calcasa-waarde is te laag volgens de business rules. | | &#x60;calcasaWaardeTeHoogVoorNhg&#x60; | Calcasa-waarde is te hoog voor een NHG-waardering volgens de business rules. | | &#x60;calcasaWaardeEnKoopsomTeHoogVoorNhg&#x60; | Calcasa-waarde en ingevoerde koopsom zijn te hoog voor een NHG-waardering volgens de business rules. |   
    /// </summary>
    /// <value>Reden voor het niet voldoen aan de business rules. | Waarde | Omschrijving | | - -- | - -- | | &#x60;geenWaardebepalingMogelijk&#x60; | De ingevoerde woning kan modelmatig niet goed genoeg worden vastgesteld. | | &#x60;geenBestaandeWoning&#x60; | Geen bestaande koopwoning. | | &#x60;fouteOfOntbrekendeInvoer&#x60; | Noodzakelijke invoer ontbreekt of is foutief ingevoerd. | | &#x60;calcasaWaardeTeHoog&#x60; | Calcasa-waarde is te hoog volgens de business rules. | | &#x60;ltvTeHoog&#x60; | Loan-to-value is te hoog volgens de business rules. | | &#x60;hypotheekTeHoog&#x60; | Hypotheekbedrag is te hoog volgens de business rules. | | &#x60;woningtypeIncorrect&#x60; | Woningtype is incorrect volgens de business rules. | | &#x60;calcasaWaardeTeLaag&#x60; | Calcasa-waarde is te laag volgens de business rules. | | &#x60;calcasaWaardeTeHoogVoorNhg&#x60; | Calcasa-waarde is te hoog voor een NHG-waardering volgens de business rules. | | &#x60;calcasaWaardeEnKoopsomTeHoogVoorNhg&#x60; | Calcasa-waarde en ingevoerde koopsom zijn te hoog voor een NHG-waardering volgens de business rules. |   </value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum BusinessRulesCode
    {
        /// <summary>
        /// Enum GeenWaardebepalingMogelijk for value: geenWaardebepalingMogelijk
        /// </summary>
        [EnumMember(Value = "geenWaardebepalingMogelijk")]
        GeenWaardebepalingMogelijk = 1,

        /// <summary>
        /// Enum GeenBestaandeWoning for value: geenBestaandeWoning
        /// </summary>
        [EnumMember(Value = "geenBestaandeWoning")]
        GeenBestaandeWoning = 2,

        /// <summary>
        /// Enum FouteOfOntbrekendeInvoer for value: fouteOfOntbrekendeInvoer
        /// </summary>
        [EnumMember(Value = "fouteOfOntbrekendeInvoer")]
        FouteOfOntbrekendeInvoer = 3,

        /// <summary>
        /// Enum CalcasaWaardeTeHoog for value: calcasaWaardeTeHoog
        /// </summary>
        [EnumMember(Value = "calcasaWaardeTeHoog")]
        CalcasaWaardeTeHoog = 4,

        /// <summary>
        /// Enum LtvTeHoog for value: ltvTeHoog
        /// </summary>
        [EnumMember(Value = "ltvTeHoog")]
        LtvTeHoog = 5,

        /// <summary>
        /// Enum HypotheekTeHoog for value: hypotheekTeHoog
        /// </summary>
        [EnumMember(Value = "hypotheekTeHoog")]
        HypotheekTeHoog = 6,

        /// <summary>
        /// Enum WoningtypeIncorrect for value: woningtypeIncorrect
        /// </summary>
        [EnumMember(Value = "woningtypeIncorrect")]
        WoningtypeIncorrect = 7,

        /// <summary>
        /// Enum CalcasaWaardeTeLaag for value: calcasaWaardeTeLaag
        /// </summary>
        [EnumMember(Value = "calcasaWaardeTeLaag")]
        CalcasaWaardeTeLaag = 8,

        /// <summary>
        /// Enum CalcasaWaardeTeHoogVoorNhg for value: calcasaWaardeTeHoogVoorNhg
        /// </summary>
        [EnumMember(Value = "calcasaWaardeTeHoogVoorNhg")]
        CalcasaWaardeTeHoogVoorNhg = 9,

        /// <summary>
        /// Enum CalcasaWaardeEnKoopsomTeHoogVoorNhg for value: calcasaWaardeEnKoopsomTeHoogVoorNhg
        /// </summary>
        [EnumMember(Value = "calcasaWaardeEnKoopsomTeHoogVoorNhg")]
        CalcasaWaardeEnKoopsomTeHoogVoorNhg = 10

    }

}
