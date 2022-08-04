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
    /// Informatie over een bepaald funderingrisico.
    /// </summary>
    [DataContract(Name = "FunderingRisico")]
    public partial class FunderingRisico : IEquatable<FunderingRisico>
    {

        /// <summary>
        /// Het risicolabel van de fundering.Indicatie voor een funderingsrisico. | Waarde | Omschrijving | | - -- | - -- | | &#x60;onbekend&#x60; | Risico klasse onbekend. | | &#x60;laag&#x60; | Laagste risico. | | &#x60;gemiddeld&#x60; | Gemiddeld risico. | | &#x60;hoog&#x60; | Hoogste risico. |   
        /// </summary>
        /// <value>Het risicolabel van de fundering.Indicatie voor een funderingsrisico. | Waarde | Omschrijving | | - -- | - -- | | &#x60;onbekend&#x60; | Risico klasse onbekend. | | &#x60;laag&#x60; | Laagste risico. | | &#x60;gemiddeld&#x60; | Gemiddeld risico. | | &#x60;hoog&#x60; | Hoogste risico. |   </value>
        [DataMember(Name = "label", EmitDefaultValue = true)]
        public FunderingRisicoLabel? Label { get; set; }

        /// <summary>
        /// De bron voor de bepaalde risico-klasse.
        /// </summary>
        /// <value>De bron voor de bepaalde risico-klasse.</value>
        [DataMember(Name = "bron", EmitDefaultValue = true)]
        public FunderingSoortBron? Bron { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="FunderingRisico" /> class.
        /// </summary>
        /// <param name="label">Het risicolabel van de fundering.Indicatie voor een funderingsrisico. | Waarde | Omschrijving | | - -- | - -- | | &#x60;onbekend&#x60; | Risico klasse onbekend. | | &#x60;laag&#x60; | Laagste risico. | | &#x60;gemiddeld&#x60; | Gemiddeld risico. | | &#x60;hoog&#x60; | Hoogste risico. |   .</param>
        /// <param name="bron">De bron voor de bepaalde risico-klasse..</param>
        /// <param name="omschrijving">De omschrijving van het risico..</param>
        public FunderingRisico(FunderingRisicoLabel? label = default(FunderingRisicoLabel?), FunderingSoortBron? bron = default(FunderingSoortBron?), string omschrijving = default(string))
        {
            this.Label = label;
            this.Bron = bron;
            this.Omschrijving = omschrijving;
        }

        /// <summary>
        /// De omschrijving van het risico.
        /// </summary>
        /// <value>De omschrijving van het risico.</value>
        [DataMember(Name = "omschrijving", EmitDefaultValue = false)]
        public string Omschrijving { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class FunderingRisico {\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
            sb.Append("  Bron: ").Append(Bron).Append("\n");
            sb.Append("  Omschrijving: ").Append(Omschrijving).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as FunderingRisico);
        }

        /// <summary>
        /// Returns true if FunderingRisico instances are equal
        /// </summary>
        /// <param name="input">Instance of FunderingRisico to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FunderingRisico input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Label == input.Label ||
                    this.Label.Equals(input.Label)
                ) && 
                (
                    this.Bron == input.Bron ||
                    this.Bron.Equals(input.Bron)
                ) && 
                (
                    this.Omschrijving == input.Omschrijving ||
                    (this.Omschrijving != null &&
                    this.Omschrijving.Equals(input.Omschrijving))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                hashCode = (hashCode * 59) + this.Label.GetHashCode();
                hashCode = (hashCode * 59) + this.Bron.GetHashCode();
                if (this.Omschrijving != null)
                {
                    hashCode = (hashCode * 59) + this.Omschrijving.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
