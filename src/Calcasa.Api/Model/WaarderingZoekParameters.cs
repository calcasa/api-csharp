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
 * The version of the OpenAPI document: 1.1.6
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
    /// WaarderingZoekParameters
    /// </summary>
    [DataContract(Name = "WaarderingZoekParameters")]
    public partial class WaarderingZoekParameters : IEquatable<WaarderingZoekParameters>
    {

        /// <summary>
        /// Verplicht.Het product type voor een waardering. Deze moeten handmatig aangezet worden voor de gebruikte credentails. | Waarde | Omschrijving | | - -- | - -- | | &#x60;onbekend&#x60; | Geen geldige invoer. Onbekend product type. | | &#x60;modelwaardeCalcasa&#x60; | Niet beschikbaar op dit moment.&lt;br&gt;            Modelwaarde aanvraag met Calcasa Waardebepalingrapport. | | &#x60;modelwaardeRisico&#x60; | Modelwaarde aanvraag met risicorapport. | | &#x60;modelwaardeDesktopTaxatie&#x60; | Modelwaarde aanvraag met Desktop Taxatie Beknoptwaarderapport. | | &#x60;desktopTaxatie&#x60; | Desktop taxatie aanvraag met Desktop Taxatie rapport. |   
        /// </summary>
        /// <value>Verplicht.Het product type voor een waardering. Deze moeten handmatig aangezet worden voor de gebruikte credentails. | Waarde | Omschrijving | | - -- | - -- | | &#x60;onbekend&#x60; | Geen geldige invoer. Onbekend product type. | | &#x60;modelwaardeCalcasa&#x60; | Niet beschikbaar op dit moment.&lt;br&gt;            Modelwaarde aanvraag met Calcasa Waardebepalingrapport. | | &#x60;modelwaardeRisico&#x60; | Modelwaarde aanvraag met risicorapport. | | &#x60;modelwaardeDesktopTaxatie&#x60; | Modelwaarde aanvraag met Desktop Taxatie Beknoptwaarderapport. | | &#x60;desktopTaxatie&#x60; | Desktop taxatie aanvraag met Desktop Taxatie rapport. |   </value>
        [DataMember(Name = "productType", IsRequired = true, EmitDefaultValue = true)]
        public ProductType ProductType { get; set; }

        /// <summary>
        /// Gets or Sets Aanvraagdoel
        /// </summary>
        [DataMember(Name = "aanvraagdoel", EmitDefaultValue = true)]
        public Aanvraagdoel? Aanvraagdoel { get; set; }

        /// <summary>
        /// Gets or Sets WaarderingStatus
        /// </summary>
        [DataMember(Name = "waarderingStatus", EmitDefaultValue = true)]
        public WaarderingStatus? WaarderingStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="WaarderingZoekParameters" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WaarderingZoekParameters() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WaarderingZoekParameters" /> class.
        /// </summary>
        /// <param name="aangemaakt">De datum/tijd waarop de waardering is aangemaakt, in UTC..</param>
        /// <param name="geldverstrekker">De naam van de geldverstrekker voor de waardering..</param>
        /// <param name="productType">Verplicht.Het product type voor een waardering. Deze moeten handmatig aangezet worden voor de gebruikte credentails. | Waarde | Omschrijving | | - -- | - -- | | &#x60;onbekend&#x60; | Geen geldige invoer. Onbekend product type. | | &#x60;modelwaardeCalcasa&#x60; | Niet beschikbaar op dit moment.&lt;br&gt;            Modelwaarde aanvraag met Calcasa Waardebepalingrapport. | | &#x60;modelwaardeRisico&#x60; | Modelwaarde aanvraag met risicorapport. | | &#x60;modelwaardeDesktopTaxatie&#x60; | Modelwaarde aanvraag met Desktop Taxatie Beknoptwaarderapport. | | &#x60;desktopTaxatie&#x60; | Desktop taxatie aanvraag met Desktop Taxatie rapport. |    (required).</param>
        /// <param name="aanvraagdoel">aanvraagdoel.</param>
        /// <param name="waarderingStatus">waarderingStatus.</param>
        /// <param name="bagNummeraanduidingId">Verplicht. (required).</param>
        public WaarderingZoekParameters(DateTime? aangemaakt = default(DateTime?), string geldverstrekker = default(string), ProductType productType = default(ProductType), Aanvraagdoel? aanvraagdoel = default(Aanvraagdoel?), WaarderingStatus? waarderingStatus = default(WaarderingStatus?), long bagNummeraanduidingId = default(long))
        {
            this.ProductType = productType;
            this.BagNummeraanduidingId = bagNummeraanduidingId;
            this.Aangemaakt = aangemaakt;
            this.Geldverstrekker = geldverstrekker;
            this.Aanvraagdoel = aanvraagdoel;
            this.WaarderingStatus = waarderingStatus;
        }

        /// <summary>
        /// De datum/tijd waarop de waardering is aangemaakt, in UTC.
        /// </summary>
        /// <value>De datum/tijd waarop de waardering is aangemaakt, in UTC.</value>
        [DataMember(Name = "aangemaakt", EmitDefaultValue = true)]
        public DateTime? Aangemaakt { get; set; }

        /// <summary>
        /// De naam van de geldverstrekker voor de waardering.
        /// </summary>
        /// <value>De naam van de geldverstrekker voor de waardering.</value>
        [DataMember(Name = "geldverstrekker", EmitDefaultValue = true)]
        public string Geldverstrekker { get; set; }

        /// <summary>
        /// Verplicht.
        /// </summary>
        /// <value>Verplicht.</value>
        [DataMember(Name = "bagNummeraanduidingId", IsRequired = true, EmitDefaultValue = false)]
        public long BagNummeraanduidingId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WaarderingZoekParameters {\n");
            sb.Append("  Aangemaakt: ").Append(Aangemaakt).Append("\n");
            sb.Append("  Geldverstrekker: ").Append(Geldverstrekker).Append("\n");
            sb.Append("  ProductType: ").Append(ProductType).Append("\n");
            sb.Append("  Aanvraagdoel: ").Append(Aanvraagdoel).Append("\n");
            sb.Append("  WaarderingStatus: ").Append(WaarderingStatus).Append("\n");
            sb.Append("  BagNummeraanduidingId: ").Append(BagNummeraanduidingId).Append("\n");
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
            return this.Equals(input as WaarderingZoekParameters);
        }

        /// <summary>
        /// Returns true if WaarderingZoekParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of WaarderingZoekParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WaarderingZoekParameters input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Aangemaakt == input.Aangemaakt ||
                    (this.Aangemaakt != null &&
                    this.Aangemaakt.Equals(input.Aangemaakt))
                ) && 
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
                    this.Aanvraagdoel == input.Aanvraagdoel ||
                    this.Aanvraagdoel.Equals(input.Aanvraagdoel)
                ) && 
                (
                    this.WaarderingStatus == input.WaarderingStatus ||
                    this.WaarderingStatus.Equals(input.WaarderingStatus)
                ) && 
                (
                    this.BagNummeraanduidingId == input.BagNummeraanduidingId ||
                    this.BagNummeraanduidingId.Equals(input.BagNummeraanduidingId)
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
                if (this.Aangemaakt != null)
                {
                    hashCode = (hashCode * 59) + this.Aangemaakt.GetHashCode();
                }
                if (this.Geldverstrekker != null)
                {
                    hashCode = (hashCode * 59) + this.Geldverstrekker.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ProductType.GetHashCode();
                hashCode = (hashCode * 59) + this.Aanvraagdoel.GetHashCode();
                hashCode = (hashCode * 59) + this.WaarderingStatus.GetHashCode();
                hashCode = (hashCode * 59) + this.BagNummeraanduidingId.GetHashCode();
                return hashCode;
            }
        }

    }

}
