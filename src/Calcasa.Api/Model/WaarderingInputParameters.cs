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
 * Calcasa Public API
 *
 * The version of the OpenAPI document: v0
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
    /// WaarderingInputParameters
    /// </summary>
    [DataContract(Name = "WaarderingInputParameters")]
    public partial class WaarderingInputParameters : IEquatable<WaarderingInputParameters>, IValidatableObject
    {

        /// <summary>
        ///  | Waarde | Omschrijving | | - -- | - -- | | &#x60;onbekend&#x60; | Onbekend product type. Geen geldige invoer. | | &#x60;modelwaardeCalcasa&#x60; | Modelwaarde aanvraag met Calcasa Waardebepalingrapport. | | &#x60;modelwaardeRisico&#x60; | Modelwaarde aanvraag met risicorapport. | | &#x60;modelwaardeDesktopTaxatie&#x60; | Modelwaarde aanvraag met Desktop Taxatie Beknoptwaarderapport. | | &#x60;desktopTaxatie&#x60; | Desktop taxatie aanvraag Desktop Taxatie rapport. |   
        /// </summary>
        /// <value> | Waarde | Omschrijving | | - -- | - -- | | &#x60;onbekend&#x60; | Onbekend product type. Geen geldige invoer. | | &#x60;modelwaardeCalcasa&#x60; | Modelwaarde aanvraag met Calcasa Waardebepalingrapport. | | &#x60;modelwaardeRisico&#x60; | Modelwaarde aanvraag met risicorapport. | | &#x60;modelwaardeDesktopTaxatie&#x60; | Modelwaarde aanvraag met Desktop Taxatie Beknoptwaarderapport. | | &#x60;desktopTaxatie&#x60; | Desktop taxatie aanvraag Desktop Taxatie rapport. |   </value>
        [DataMember(Name = "productType", EmitDefaultValue = true)]
        public ProductType? ProductType { get; set; }

        /// <summary>
        /// English: Request GoalEnglish: Request Goal | Waarde | Omschrijving | | - -- | - -- | | &#x60;onbekend&#x60; | English: Unknown | | &#x60;aankoopNieuweWoning&#x60; | English: New Home Purchase | | &#x60;overbruggingsfinanciering&#x60; | English: Bridge Financing | | &#x60;hypotheekOversluiten&#x60; | English: Refinancing Mortgage | | &#x60;hypotheekOphogen&#x60; | English: Increasing Mortage | | &#x60;hypotheekWijziging&#x60; | English: Changing Mortgage | | &#x60;hypotheekrenteWijzigen&#x60; | English: Change Mortgage Intrest |   
        /// </summary>
        /// <value>English: Request GoalEnglish: Request Goal | Waarde | Omschrijving | | - -- | - -- | | &#x60;onbekend&#x60; | English: Unknown | | &#x60;aankoopNieuweWoning&#x60; | English: New Home Purchase | | &#x60;overbruggingsfinanciering&#x60; | English: Bridge Financing | | &#x60;hypotheekOversluiten&#x60; | English: Refinancing Mortgage | | &#x60;hypotheekOphogen&#x60; | English: Increasing Mortage | | &#x60;hypotheekWijziging&#x60; | English: Changing Mortgage | | &#x60;hypotheekrenteWijzigen&#x60; | English: Change Mortgage Intrest |   </value>
        [DataMember(Name = "aanvraagdoel", EmitDefaultValue = true)]
        public Aanvraagdoel? Aanvraagdoel { get; set; }

        /// <summary>
        ///  | Waarde | Omschrijving | | - -- | - -- | | &#x60;onbekend&#x60; |  | | &#x60;koopsom&#x60; |  | | &#x60;taxatiewaarde&#x60; |  | | &#x60;wozWaarde&#x60; |  | | &#x60;eigenWaardeinschatting&#x60; |  |   
        /// </summary>
        /// <value> | Waarde | Omschrijving | | - -- | - -- | | &#x60;onbekend&#x60; |  | | &#x60;koopsom&#x60; |  | | &#x60;taxatiewaarde&#x60; |  | | &#x60;wozWaarde&#x60; |  | | &#x60;eigenWaardeinschatting&#x60; |  |   </value>
        [DataMember(Name = "klantwaardeType", EmitDefaultValue = true)]
        public KlantwaardeType? KlantwaardeType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="WaarderingInputParameters" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WaarderingInputParameters() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WaarderingInputParameters" /> class.
        /// </summary>
        /// <param name="geldverstrekker">geldverstrekker.</param>
        /// <param name="productType"> | Waarde | Omschrijving | | - -- | - -- | | &#x60;onbekend&#x60; | Onbekend product type. Geen geldige invoer. | | &#x60;modelwaardeCalcasa&#x60; | Modelwaarde aanvraag met Calcasa Waardebepalingrapport. | | &#x60;modelwaardeRisico&#x60; | Modelwaarde aanvraag met risicorapport. | | &#x60;modelwaardeDesktopTaxatie&#x60; | Modelwaarde aanvraag met Desktop Taxatie Beknoptwaarderapport. | | &#x60;desktopTaxatie&#x60; | Desktop taxatie aanvraag Desktop Taxatie rapport. |   .</param>
        /// <param name="hypotheekwaarde">In hele euros..</param>
        /// <param name="aanvraagdoel">English: Request GoalEnglish: Request Goal | Waarde | Omschrijving | | - -- | - -- | | &#x60;onbekend&#x60; | English: Unknown | | &#x60;aankoopNieuweWoning&#x60; | English: New Home Purchase | | &#x60;overbruggingsfinanciering&#x60; | English: Bridge Financing | | &#x60;hypotheekOversluiten&#x60; | English: Refinancing Mortgage | | &#x60;hypotheekOphogen&#x60; | English: Increasing Mortage | | &#x60;hypotheekWijziging&#x60; | English: Changing Mortgage | | &#x60;hypotheekrenteWijzigen&#x60; | English: Change Mortgage Intrest |   .</param>
        /// <param name="klantwaarde">In hele euros..</param>
        /// <param name="klantwaardeType"> | Waarde | Omschrijving | | - -- | - -- | | &#x60;onbekend&#x60; |  | | &#x60;koopsom&#x60; |  | | &#x60;taxatiewaarde&#x60; |  | | &#x60;wozWaarde&#x60; |  | | &#x60;eigenWaardeinschatting&#x60; |  |   .</param>
        /// <param name="isBestaandeWoning">isBestaandeWoning.</param>
        /// <param name="bagNummeraanduidingId">bagNummeraanduidingId (required).</param>
        /// <param name="isNhg">isNhg.</param>
        /// <param name="isBestaandeNhgHypotheek">isBestaandeNhgHypotheek.</param>
        /// <param name="benodigdeOverbrugging">In hele euros..</param>
        public WaarderingInputParameters(string geldverstrekker = default(string), ProductType? productType = default(ProductType?), int hypotheekwaarde = default(int), Aanvraagdoel? aanvraagdoel = default(Aanvraagdoel?), int klantwaarde = default(int), KlantwaardeType? klantwaardeType = default(KlantwaardeType?), bool isBestaandeWoning = default(bool), long bagNummeraanduidingId = default(long), bool isNhg = default(bool), bool isBestaandeNhgHypotheek = default(bool), int benodigdeOverbrugging = default(int))
        {
            this.BagNummeraanduidingId = bagNummeraanduidingId;
            this.Geldverstrekker = geldverstrekker;
            this.ProductType = productType;
            this.Hypotheekwaarde = hypotheekwaarde;
            this.Aanvraagdoel = aanvraagdoel;
            this.Klantwaarde = klantwaarde;
            this.KlantwaardeType = klantwaardeType;
            this.IsBestaandeWoning = isBestaandeWoning;
            this.IsNhg = isNhg;
            this.IsBestaandeNhgHypotheek = isBestaandeNhgHypotheek;
            this.BenodigdeOverbrugging = benodigdeOverbrugging;
        }

        /// <summary>
        /// Gets or Sets Geldverstrekker
        /// </summary>
        [DataMember(Name = "geldverstrekker", EmitDefaultValue = false)]
        public string Geldverstrekker { get; set; }

        /// <summary>
        /// In hele euros.
        /// </summary>
        /// <value>In hele euros.</value>
        [DataMember(Name = "hypotheekwaarde", EmitDefaultValue = false)]
        public int Hypotheekwaarde { get; set; }

        /// <summary>
        /// In hele euros.
        /// </summary>
        /// <value>In hele euros.</value>
        [DataMember(Name = "klantwaarde", EmitDefaultValue = false)]
        public int Klantwaarde { get; set; }

        /// <summary>
        /// Gets or Sets IsBestaandeWoning
        /// </summary>
        [DataMember(Name = "isBestaandeWoning", EmitDefaultValue = true)]
        public bool IsBestaandeWoning { get; set; }

        /// <summary>
        /// Gets or Sets BagNummeraanduidingId
        /// </summary>
        [DataMember(Name = "bagNummeraanduidingId", IsRequired = true, EmitDefaultValue = false)]
        public long BagNummeraanduidingId { get; set; }

        /// <summary>
        /// Gets or Sets IsNhg
        /// </summary>
        [DataMember(Name = "isNhg", EmitDefaultValue = true)]
        public bool IsNhg { get; set; }

        /// <summary>
        /// Gets or Sets IsBestaandeNhgHypotheek
        /// </summary>
        [DataMember(Name = "isBestaandeNhgHypotheek", EmitDefaultValue = true)]
        public bool IsBestaandeNhgHypotheek { get; set; }

        /// <summary>
        /// In hele euros.
        /// </summary>
        /// <value>In hele euros.</value>
        [DataMember(Name = "benodigdeOverbrugging", EmitDefaultValue = false)]
        public int BenodigdeOverbrugging { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WaarderingInputParameters {\n");
            sb.Append("  Geldverstrekker: ").Append(Geldverstrekker).Append("\n");
            sb.Append("  ProductType: ").Append(ProductType).Append("\n");
            sb.Append("  Hypotheekwaarde: ").Append(Hypotheekwaarde).Append("\n");
            sb.Append("  Aanvraagdoel: ").Append(Aanvraagdoel).Append("\n");
            sb.Append("  Klantwaarde: ").Append(Klantwaarde).Append("\n");
            sb.Append("  KlantwaardeType: ").Append(KlantwaardeType).Append("\n");
            sb.Append("  IsBestaandeWoning: ").Append(IsBestaandeWoning).Append("\n");
            sb.Append("  BagNummeraanduidingId: ").Append(BagNummeraanduidingId).Append("\n");
            sb.Append("  IsNhg: ").Append(IsNhg).Append("\n");
            sb.Append("  IsBestaandeNhgHypotheek: ").Append(IsBestaandeNhgHypotheek).Append("\n");
            sb.Append("  BenodigdeOverbrugging: ").Append(BenodigdeOverbrugging).Append("\n");
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
            return this.Equals(input as WaarderingInputParameters);
        }

        /// <summary>
        /// Returns true if WaarderingInputParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of WaarderingInputParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WaarderingInputParameters input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Geldverstrekker == input.Geldverstrekker ||
                    (this.Geldverstrekker != null &&
                    this.Geldverstrekker.Equals(input.Geldverstrekker))
                ) && 
                (
                    this.ProductType == input.ProductType ||
                    this.ProductType.Equals(input.ProductType)
                ) && 
                (
                    this.Hypotheekwaarde == input.Hypotheekwaarde ||
                    this.Hypotheekwaarde.Equals(input.Hypotheekwaarde)
                ) && 
                (
                    this.Aanvraagdoel == input.Aanvraagdoel ||
                    this.Aanvraagdoel.Equals(input.Aanvraagdoel)
                ) && 
                (
                    this.Klantwaarde == input.Klantwaarde ||
                    this.Klantwaarde.Equals(input.Klantwaarde)
                ) && 
                (
                    this.KlantwaardeType == input.KlantwaardeType ||
                    this.KlantwaardeType.Equals(input.KlantwaardeType)
                ) && 
                (
                    this.IsBestaandeWoning == input.IsBestaandeWoning ||
                    this.IsBestaandeWoning.Equals(input.IsBestaandeWoning)
                ) && 
                (
                    this.BagNummeraanduidingId == input.BagNummeraanduidingId ||
                    this.BagNummeraanduidingId.Equals(input.BagNummeraanduidingId)
                ) && 
                (
                    this.IsNhg == input.IsNhg ||
                    this.IsNhg.Equals(input.IsNhg)
                ) && 
                (
                    this.IsBestaandeNhgHypotheek == input.IsBestaandeNhgHypotheek ||
                    this.IsBestaandeNhgHypotheek.Equals(input.IsBestaandeNhgHypotheek)
                ) && 
                (
                    this.BenodigdeOverbrugging == input.BenodigdeOverbrugging ||
                    this.BenodigdeOverbrugging.Equals(input.BenodigdeOverbrugging)
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
                if (this.Geldverstrekker != null)
                    hashCode = hashCode * 59 + this.Geldverstrekker.GetHashCode();
                hashCode = hashCode * 59 + this.ProductType.GetHashCode();
                hashCode = hashCode * 59 + this.Hypotheekwaarde.GetHashCode();
                hashCode = hashCode * 59 + this.Aanvraagdoel.GetHashCode();
                hashCode = hashCode * 59 + this.Klantwaarde.GetHashCode();
                hashCode = hashCode * 59 + this.KlantwaardeType.GetHashCode();
                hashCode = hashCode * 59 + this.IsBestaandeWoning.GetHashCode();
                hashCode = hashCode * 59 + this.BagNummeraanduidingId.GetHashCode();
                hashCode = hashCode * 59 + this.IsNhg.GetHashCode();
                hashCode = hashCode * 59 + this.IsBestaandeNhgHypotheek.GetHashCode();
                hashCode = hashCode * 59 + this.BenodigdeOverbrugging.GetHashCode();
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