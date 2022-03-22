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
    /// Uitvoer met funderingsinformatie.
    /// </summary>
    [DataContract(Name = "Funderingdata")]
    public partial class Funderingdata : IEquatable<Funderingdata>, IValidatableObject
    {

        /// <summary>
        /// Het herstel-type van de fundering.
        /// </summary>
        /// <value>Het herstel-type van de fundering.</value>
        [DataMember(Name = "herstelType", EmitDefaultValue = true)]
        public FunderingHerstelType? HerstelType { get; set; }

        /// <summary>
        /// De bron van de data.Bron waar de funderingsinformatie opgehaald is. | Waarde | Omschrijving | | - -- | - -- | | &#x60;calcasa&#x60; | Calcasa data. | | &#x60;fundermaps&#x60; | Fundermaps data. |   
        /// </summary>
        /// <value>De bron van de data.Bron waar de funderingsinformatie opgehaald is. | Waarde | Omschrijving | | - -- | - -- | | &#x60;calcasa&#x60; | Calcasa data. | | &#x60;fundermaps&#x60; | Fundermaps data. |   </value>
        [DataMember(Name = "bron", EmitDefaultValue = true)]
        public FunderingDataBron? Bron { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Funderingdata" /> class.
        /// </summary>
        /// <param name="typering">Informatie over het type fundering..</param>
        /// <param name="herstelType">Het herstel-type van de fundering..</param>
        /// <param name="droogstandRisico">Risico-informatie over droogstand..</param>
        /// <param name="optrekkendVochtRisico">Risico-informatie over optrekkend vocht..</param>
        /// <param name="bioInfectieRisico">Risico-informatie over bacteriële infectie..</param>
        /// <param name="herstelkosten">Indicatieve herstelkosten van de fundering..</param>
        /// <param name="bron">De bron van de data.Bron waar de funderingsinformatie opgehaald is. | Waarde | Omschrijving | | - -- | - -- | | &#x60;calcasa&#x60; | Calcasa data. | | &#x60;fundermaps&#x60; | Fundermaps data. |   .</param>
        public Funderingdata(FunderingTypering typering = default(FunderingTypering), FunderingHerstelType? herstelType = default(FunderingHerstelType?), FunderingRisico droogstandRisico = default(FunderingRisico), FunderingRisico optrekkendVochtRisico = default(FunderingRisico), FunderingRisico bioInfectieRisico = default(FunderingRisico), double? herstelkosten = default(double?), FunderingDataBron? bron = default(FunderingDataBron?))
        {
            this.Typering = typering;
            this.HerstelType = herstelType;
            this.DroogstandRisico = droogstandRisico;
            this.OptrekkendVochtRisico = optrekkendVochtRisico;
            this.BioInfectieRisico = bioInfectieRisico;
            this.Herstelkosten = herstelkosten;
            this.Bron = bron;
        }

        /// <summary>
        /// Informatie over het type fundering.
        /// </summary>
        /// <value>Informatie over het type fundering.</value>
        [DataMember(Name = "typering", EmitDefaultValue = true)]
        public FunderingTypering Typering { get; set; }

        /// <summary>
        /// Risico-informatie over droogstand.
        /// </summary>
        /// <value>Risico-informatie over droogstand.</value>
        [DataMember(Name = "droogstandRisico", EmitDefaultValue = true)]
        public FunderingRisico DroogstandRisico { get; set; }

        /// <summary>
        /// Risico-informatie over optrekkend vocht.
        /// </summary>
        /// <value>Risico-informatie over optrekkend vocht.</value>
        [DataMember(Name = "optrekkendVochtRisico", EmitDefaultValue = true)]
        public FunderingRisico OptrekkendVochtRisico { get; set; }

        /// <summary>
        /// Risico-informatie over bacteriële infectie.
        /// </summary>
        /// <value>Risico-informatie over bacteriële infectie.</value>
        [DataMember(Name = "bioInfectieRisico", EmitDefaultValue = true)]
        public FunderingRisico BioInfectieRisico { get; set; }

        /// <summary>
        /// Indicatieve herstelkosten van de fundering.
        /// </summary>
        /// <value>Indicatieve herstelkosten van de fundering.</value>
        [DataMember(Name = "herstelkosten", EmitDefaultValue = true)]
        public double? Herstelkosten { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Funderingdata {\n");
            sb.Append("  Typering: ").Append(Typering).Append("\n");
            sb.Append("  HerstelType: ").Append(HerstelType).Append("\n");
            sb.Append("  DroogstandRisico: ").Append(DroogstandRisico).Append("\n");
            sb.Append("  OptrekkendVochtRisico: ").Append(OptrekkendVochtRisico).Append("\n");
            sb.Append("  BioInfectieRisico: ").Append(BioInfectieRisico).Append("\n");
            sb.Append("  Herstelkosten: ").Append(Herstelkosten).Append("\n");
            sb.Append("  Bron: ").Append(Bron).Append("\n");
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
            return this.Equals(input as Funderingdata);
        }

        /// <summary>
        /// Returns true if Funderingdata instances are equal
        /// </summary>
        /// <param name="input">Instance of Funderingdata to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Funderingdata input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Typering == input.Typering ||
                    (this.Typering != null &&
                    this.Typering.Equals(input.Typering))
                ) && 
                (
                    this.HerstelType == input.HerstelType ||
                    this.HerstelType.Equals(input.HerstelType)
                ) && 
                (
                    this.DroogstandRisico == input.DroogstandRisico ||
                    (this.DroogstandRisico != null &&
                    this.DroogstandRisico.Equals(input.DroogstandRisico))
                ) && 
                (
                    this.OptrekkendVochtRisico == input.OptrekkendVochtRisico ||
                    (this.OptrekkendVochtRisico != null &&
                    this.OptrekkendVochtRisico.Equals(input.OptrekkendVochtRisico))
                ) && 
                (
                    this.BioInfectieRisico == input.BioInfectieRisico ||
                    (this.BioInfectieRisico != null &&
                    this.BioInfectieRisico.Equals(input.BioInfectieRisico))
                ) && 
                (
                    this.Herstelkosten == input.Herstelkosten ||
                    (this.Herstelkosten != null &&
                    this.Herstelkosten.Equals(input.Herstelkosten))
                ) && 
                (
                    this.Bron == input.Bron ||
                    this.Bron.Equals(input.Bron)
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
                if (this.Typering != null)
                {
                    hashCode = (hashCode * 59) + this.Typering.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.HerstelType.GetHashCode();
                if (this.DroogstandRisico != null)
                {
                    hashCode = (hashCode * 59) + this.DroogstandRisico.GetHashCode();
                }
                if (this.OptrekkendVochtRisico != null)
                {
                    hashCode = (hashCode * 59) + this.OptrekkendVochtRisico.GetHashCode();
                }
                if (this.BioInfectieRisico != null)
                {
                    hashCode = (hashCode * 59) + this.BioInfectieRisico.GetHashCode();
                }
                if (this.Herstelkosten != null)
                {
                    hashCode = (hashCode * 59) + this.Herstelkosten.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Bron.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
