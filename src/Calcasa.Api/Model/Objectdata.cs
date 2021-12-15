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
 * The version of the OpenAPI document: 0.0.6
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
    /// Objectdata
    /// </summary>
    [DataContract(Name = "Objectdata")]
    public partial class Objectdata : IEquatable<Objectdata>, IValidatableObject
    {

        /// <summary>
        /// Woningtypes zoals gedefinieerd in het Calcasa-model.Woningtypes zoals gedefinieerd in het Calcasa-model. | Waarde | Omschrijving | | - -- | - -- | | &#x60;onbekend&#x60; | Onbekend woning type. | | &#x60;vrijstaand&#x60; | Vrijstaande woning. | | &#x60;halfVrijstaand&#x60; | Half-vrijstaande woning / twee-onder-een-kap.&lt;br&gt;            Heel speciaal type | | &#x60;hoekwoning&#x60; | Hoekwoning. | | &#x60;tussenwoning&#x60; | Tussenwoning. | | &#x60;galerijflat&#x60; | Galerijflat. | | &#x60;portiekflat&#x60; | Portiekflat. | | &#x60;maisonnette&#x60; | Maisonette. | | &#x60;bovenwoning&#x60; | Bovenwoning. | | &#x60;benedenwoning&#x60; | Benedenwoning. |   
        /// </summary>
        /// <value>Woningtypes zoals gedefinieerd in het Calcasa-model.Woningtypes zoals gedefinieerd in het Calcasa-model. | Waarde | Omschrijving | | - -- | - -- | | &#x60;onbekend&#x60; | Onbekend woning type. | | &#x60;vrijstaand&#x60; | Vrijstaande woning. | | &#x60;halfVrijstaand&#x60; | Half-vrijstaande woning / twee-onder-een-kap.&lt;br&gt;            Heel speciaal type | | &#x60;hoekwoning&#x60; | Hoekwoning. | | &#x60;tussenwoning&#x60; | Tussenwoning. | | &#x60;galerijflat&#x60; | Galerijflat. | | &#x60;portiekflat&#x60; | Portiekflat. | | &#x60;maisonnette&#x60; | Maisonette. | | &#x60;bovenwoning&#x60; | Bovenwoning. | | &#x60;benedenwoning&#x60; | Benedenwoning. |   </value>
        [DataMember(Name = "woningType", EmitDefaultValue = true)]
        public WoningType? WoningType { get; set; }

        /// <summary>
        ///  | Waarde | Omschrijving | | - -- | - -- | | &#x60;onbekend&#x60; |  | | &#x60;g&#x60; |  | | &#x60;f&#x60; |  | | &#x60;e&#x60; |  | | &#x60;d&#x60; |  | | &#x60;c&#x60; |  | | &#x60;b&#x60; |  | | &#x60;a&#x60; |  | | &#x60;a1&#x60; | A+ | | &#x60;a2&#x60; | A++ | | &#x60;a3&#x60; | A+++ | | &#x60;a4&#x60; | A++++ |   
        /// </summary>
        /// <value> | Waarde | Omschrijving | | - -- | - -- | | &#x60;onbekend&#x60; |  | | &#x60;g&#x60; |  | | &#x60;f&#x60; |  | | &#x60;e&#x60; |  | | &#x60;d&#x60; |  | | &#x60;c&#x60; |  | | &#x60;b&#x60; |  | | &#x60;a&#x60; |  | | &#x60;a1&#x60; | A+ | | &#x60;a2&#x60; | A++ | | &#x60;a3&#x60; | A+++ | | &#x60;a4&#x60; | A++++ |   </value>
        [DataMember(Name = "energielabel", EmitDefaultValue = true)]
        public Energielabel? Energielabel { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Objectdata" /> class.
        /// </summary>
        /// <param name="woningType">Woningtypes zoals gedefinieerd in het Calcasa-model.Woningtypes zoals gedefinieerd in het Calcasa-model. | Waarde | Omschrijving | | - -- | - -- | | &#x60;onbekend&#x60; | Onbekend woning type. | | &#x60;vrijstaand&#x60; | Vrijstaande woning. | | &#x60;halfVrijstaand&#x60; | Half-vrijstaande woning / twee-onder-een-kap.&lt;br&gt;            Heel speciaal type | | &#x60;hoekwoning&#x60; | Hoekwoning. | | &#x60;tussenwoning&#x60; | Tussenwoning. | | &#x60;galerijflat&#x60; | Galerijflat. | | &#x60;portiekflat&#x60; | Portiekflat. | | &#x60;maisonnette&#x60; | Maisonette. | | &#x60;bovenwoning&#x60; | Bovenwoning. | | &#x60;benedenwoning&#x60; | Benedenwoning. |   .</param>
        /// <param name="bouwjaar">bouwjaar.</param>
        /// <param name="oppervlak">Het woonoppervlak in hele vierkante meters..</param>
        /// <param name="perceeloppervlak">Het perceeloppervlak in hele vierkante meters..</param>
        /// <param name="inhoud">De inhoud in hele kubieke meters..</param>
        /// <param name="energielabel"> | Waarde | Omschrijving | | - -- | - -- | | &#x60;onbekend&#x60; |  | | &#x60;g&#x60; |  | | &#x60;f&#x60; |  | | &#x60;e&#x60; |  | | &#x60;d&#x60; |  | | &#x60;c&#x60; |  | | &#x60;b&#x60; |  | | &#x60;a&#x60; |  | | &#x60;a1&#x60; | A+ | | &#x60;a2&#x60; | A++ | | &#x60;a3&#x60; | A+++ | | &#x60;a4&#x60; | A++++ |   .</param>
        public Objectdata(WoningType? woningType = default(WoningType?), int bouwjaar = default(int), int oppervlak = default(int), int perceeloppervlak = default(int), int inhoud = default(int), Energielabel? energielabel = default(Energielabel?))
        {
            this.WoningType = woningType;
            this.Bouwjaar = bouwjaar;
            this.Oppervlak = oppervlak;
            this.Perceeloppervlak = perceeloppervlak;
            this.Inhoud = inhoud;
            this.Energielabel = energielabel;
        }

        /// <summary>
        /// Gets or Sets Bouwjaar
        /// </summary>
        [DataMember(Name = "bouwjaar", EmitDefaultValue = false)]
        public int Bouwjaar { get; set; }

        /// <summary>
        /// Het woonoppervlak in hele vierkante meters.
        /// </summary>
        /// <value>Het woonoppervlak in hele vierkante meters.</value>
        [DataMember(Name = "oppervlak", EmitDefaultValue = false)]
        public int Oppervlak { get; set; }

        /// <summary>
        /// Het perceeloppervlak in hele vierkante meters.
        /// </summary>
        /// <value>Het perceeloppervlak in hele vierkante meters.</value>
        [DataMember(Name = "perceeloppervlak", EmitDefaultValue = false)]
        public int Perceeloppervlak { get; set; }

        /// <summary>
        /// De inhoud in hele kubieke meters.
        /// </summary>
        /// <value>De inhoud in hele kubieke meters.</value>
        [DataMember(Name = "inhoud", EmitDefaultValue = false)]
        public int Inhoud { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Objectdata {\n");
            sb.Append("  WoningType: ").Append(WoningType).Append("\n");
            sb.Append("  Bouwjaar: ").Append(Bouwjaar).Append("\n");
            sb.Append("  Oppervlak: ").Append(Oppervlak).Append("\n");
            sb.Append("  Perceeloppervlak: ").Append(Perceeloppervlak).Append("\n");
            sb.Append("  Inhoud: ").Append(Inhoud).Append("\n");
            sb.Append("  Energielabel: ").Append(Energielabel).Append("\n");
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
            return this.Equals(input as Objectdata);
        }

        /// <summary>
        /// Returns true if Objectdata instances are equal
        /// </summary>
        /// <param name="input">Instance of Objectdata to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Objectdata input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.WoningType == input.WoningType ||
                    this.WoningType.Equals(input.WoningType)
                ) && 
                (
                    this.Bouwjaar == input.Bouwjaar ||
                    this.Bouwjaar.Equals(input.Bouwjaar)
                ) && 
                (
                    this.Oppervlak == input.Oppervlak ||
                    this.Oppervlak.Equals(input.Oppervlak)
                ) && 
                (
                    this.Perceeloppervlak == input.Perceeloppervlak ||
                    this.Perceeloppervlak.Equals(input.Perceeloppervlak)
                ) && 
                (
                    this.Inhoud == input.Inhoud ||
                    this.Inhoud.Equals(input.Inhoud)
                ) && 
                (
                    this.Energielabel == input.Energielabel ||
                    this.Energielabel.Equals(input.Energielabel)
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
                hashCode = hashCode * 59 + this.WoningType.GetHashCode();
                hashCode = hashCode * 59 + this.Bouwjaar.GetHashCode();
                hashCode = hashCode * 59 + this.Oppervlak.GetHashCode();
                hashCode = hashCode * 59 + this.Perceeloppervlak.GetHashCode();
                hashCode = hashCode * 59 + this.Inhoud.GetHashCode();
                hashCode = hashCode * 59 + this.Energielabel.GetHashCode();
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
