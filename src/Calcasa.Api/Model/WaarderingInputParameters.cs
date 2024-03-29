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
    /// WaarderingInputParameters
    /// </summary>
    [DataContract(Name = "WaarderingInputParameters")]
    public partial class WaarderingInputParameters : IEquatable<WaarderingInputParameters>
    {

        /// <summary>
        /// Gets or Sets ProductType
        /// </summary>
        [DataMember(Name = "productType", IsRequired = true, EmitDefaultValue = false)]
        public ProductType ProductType { get; set; }

        /// <summary>
        /// Gets or Sets Aanvraagdoel
        /// </summary>
        [DataMember(Name = "aanvraagdoel", EmitDefaultValue = false)]
        public Aanvraagdoel? Aanvraagdoel { get; set; }

        /// <summary>
        /// Gets or Sets KlantwaardeType
        /// </summary>
        [DataMember(Name = "klantwaardeType", EmitDefaultValue = false)]
        public KlantwaardeType? KlantwaardeType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="WaarderingInputParameters" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WaarderingInputParameters() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WaarderingInputParameters" /> class.
        /// </summary>
        /// <param name="geldverstrekker">Ongebruikt voor alle producttypen op dit moment. Deze informatie komt uit de credentials..</param>
        /// <param name="productType">productType (required).</param>
        /// <param name="hypotheekwaarde">Verplicht voor de producttypen &#x60;modelwaardeDesktopTaxatie&#x60; en &#x60;desktopTaxatie&#x60;.  Voor het aanvraagdoel &#x60;hypotheekOphogen&#x60; is dit de som van de huidige hypotheeksom en de ophoging.  In hele euros..</param>
        /// <param name="aanvraagdoel">aanvraagdoel.</param>
        /// <param name="klantwaarde">Verplicht voor de producttypen &#x60;modelwaardeDesktopTaxatie&#x60; en &#x60;desktopTaxatie&#x60;.  In hele euros. De waarde zoals bekend bij de klant met bijbehorende KlantwaardeType..</param>
        /// <param name="klantwaardeType">klantwaardeType.</param>
        /// <param name="isBestaandeWoning">Verplicht voor de producttypen &#x60;modelwaardeDesktopTaxatie&#x60; en &#x60;desktopTaxatie&#x60;.  Geeft aan of het te waarderen object een bestaande koopwoning is..</param>
        /// <param name="bagNummeraanduidingId">Verplicht voor alle producttypen.  Het BAG (Basisregistratie Adressen en Gebouwen) nummeraanduiding id. (required).</param>
        /// <param name="isNhg">Verplicht voor de producttypen &#x60;modelwaardeDesktopTaxatie&#x60; en &#x60;desktopTaxatie&#x60;.  Geeft aan of er gebruikt gemaakt wordt van de Nationale Hypotheekgarantie..</param>
        /// <param name="isBestaandeNhgHypotheek">Verplicht te gebruiken voor de combinatie van de producttypen &#x60;modelwaardeDesktopTaxatie&#x60; en &#x60;desktopTaxatie&#x60;, als er gebruikt gemaakt wordt van de Nationale Hypotheekgarantie (&#x60;isNhg&#x60;) en het aanvraagdoel niet &#x60;aankoopNieuweWoning&#x60; is.  Geeft aan of er bij de eventuele bestaande hypotheek gebruik is gemaakt van de Nationale Hypotheekgarantie..</param>
        /// <param name="benodigdeOverbrugging">Verplicht voor de combinatie van de producttypen &#x60;modelwaardeDesktopTaxatie&#x60; en &#x60;desktopTaxatie&#x60; en het aanvraagdoel &#x60;overbruggingsfinanciering&#x60;.  In hele euros..</param>
        /// <param name="peildatum">Optioneel te gebruiken voor de producttypen &#x60;modelwaardeRisico&#x60;.  Peildatum voor de aanvraag. Standaard de datum van vandaag.  Supports yyyy-MM-dd or optionally yyyy-MM-ddTHH:mm:ssZ (ISO) with the time stamp assumed to be in UTC and the time is dropped before using the value..</param>
        /// <param name="isErfpacht">Potentieel verplicht voor de product typen &#x60;modelwaardeDesktopTaxatie&#x60; en &#x60;desktopTaxatie&#x60; afhankelijk van de geldverstrekker- en accountconfiguratie..</param>
        /// <param name="klantkenmerk">Vrij veld voor het opslaan van een klantkenmerk, zoals bijvoorbeeld een dossiernummer of andere interne referentie. Dit veld komt later weer terug in het &#x60;origineleInput&#x60; veld in het &#x60;waardering&#x60; object..</param>
        public WaarderingInputParameters(string geldverstrekker = default(string), ProductType productType = default(ProductType), int hypotheekwaarde = default(int), Aanvraagdoel? aanvraagdoel = default(Aanvraagdoel?), int klantwaarde = default(int), KlantwaardeType? klantwaardeType = default(KlantwaardeType?), bool isBestaandeWoning = default(bool), long bagNummeraanduidingId = default(long), bool isNhg = default(bool), bool isBestaandeNhgHypotheek = default(bool), int benodigdeOverbrugging = default(int), DateTime? peildatum = default(DateTime?), bool? isErfpacht = default(bool?), string klantkenmerk = default(string))
        {
            this.ProductType = productType;
            this.BagNummeraanduidingId = bagNummeraanduidingId;
            this.Geldverstrekker = geldverstrekker;
            this.Hypotheekwaarde = hypotheekwaarde;
            this.Aanvraagdoel = aanvraagdoel;
            this.Klantwaarde = klantwaarde;
            this.KlantwaardeType = klantwaardeType;
            this.IsBestaandeWoning = isBestaandeWoning;
            this.IsNhg = isNhg;
            this.IsBestaandeNhgHypotheek = isBestaandeNhgHypotheek;
            this.BenodigdeOverbrugging = benodigdeOverbrugging;
            this.Peildatum = peildatum;
            this.IsErfpacht = isErfpacht;
            this.Klantkenmerk = klantkenmerk;
        }

        /// <summary>
        /// Ongebruikt voor alle producttypen op dit moment. Deze informatie komt uit de credentials.
        /// </summary>
        /// <value>Ongebruikt voor alle producttypen op dit moment. Deze informatie komt uit de credentials.</value>
        [DataMember(Name = "geldverstrekker", EmitDefaultValue = false)]
        public string Geldverstrekker { get; set; }

        /// <summary>
        /// Verplicht voor de producttypen &#x60;modelwaardeDesktopTaxatie&#x60; en &#x60;desktopTaxatie&#x60;.  Voor het aanvraagdoel &#x60;hypotheekOphogen&#x60; is dit de som van de huidige hypotheeksom en de ophoging.  In hele euros.
        /// </summary>
        /// <value>Verplicht voor de producttypen &#x60;modelwaardeDesktopTaxatie&#x60; en &#x60;desktopTaxatie&#x60;.  Voor het aanvraagdoel &#x60;hypotheekOphogen&#x60; is dit de som van de huidige hypotheeksom en de ophoging.  In hele euros.</value>
        [DataMember(Name = "hypotheekwaarde", EmitDefaultValue = false)]
        public int Hypotheekwaarde { get; set; }

        /// <summary>
        /// Verplicht voor de producttypen &#x60;modelwaardeDesktopTaxatie&#x60; en &#x60;desktopTaxatie&#x60;.  In hele euros. De waarde zoals bekend bij de klant met bijbehorende KlantwaardeType.
        /// </summary>
        /// <value>Verplicht voor de producttypen &#x60;modelwaardeDesktopTaxatie&#x60; en &#x60;desktopTaxatie&#x60;.  In hele euros. De waarde zoals bekend bij de klant met bijbehorende KlantwaardeType.</value>
        [DataMember(Name = "klantwaarde", EmitDefaultValue = false)]
        public int Klantwaarde { get; set; }

        /// <summary>
        /// Verplicht voor de producttypen &#x60;modelwaardeDesktopTaxatie&#x60; en &#x60;desktopTaxatie&#x60;.  Geeft aan of het te waarderen object een bestaande koopwoning is.
        /// </summary>
        /// <value>Verplicht voor de producttypen &#x60;modelwaardeDesktopTaxatie&#x60; en &#x60;desktopTaxatie&#x60;.  Geeft aan of het te waarderen object een bestaande koopwoning is.</value>
        [DataMember(Name = "isBestaandeWoning", EmitDefaultValue = true)]
        public bool IsBestaandeWoning { get; set; }

        /// <summary>
        /// Verplicht voor alle producttypen.  Het BAG (Basisregistratie Adressen en Gebouwen) nummeraanduiding id.
        /// </summary>
        /// <value>Verplicht voor alle producttypen.  Het BAG (Basisregistratie Adressen en Gebouwen) nummeraanduiding id.</value>
        [DataMember(Name = "bagNummeraanduidingId", IsRequired = true, EmitDefaultValue = false)]
        public long BagNummeraanduidingId { get; set; }

        /// <summary>
        /// Verplicht voor de producttypen &#x60;modelwaardeDesktopTaxatie&#x60; en &#x60;desktopTaxatie&#x60;.  Geeft aan of er gebruikt gemaakt wordt van de Nationale Hypotheekgarantie.
        /// </summary>
        /// <value>Verplicht voor de producttypen &#x60;modelwaardeDesktopTaxatie&#x60; en &#x60;desktopTaxatie&#x60;.  Geeft aan of er gebruikt gemaakt wordt van de Nationale Hypotheekgarantie.</value>
        [DataMember(Name = "isNhg", EmitDefaultValue = true)]
        public bool IsNhg { get; set; }

        /// <summary>
        /// Verplicht te gebruiken voor de combinatie van de producttypen &#x60;modelwaardeDesktopTaxatie&#x60; en &#x60;desktopTaxatie&#x60;, als er gebruikt gemaakt wordt van de Nationale Hypotheekgarantie (&#x60;isNhg&#x60;) en het aanvraagdoel niet &#x60;aankoopNieuweWoning&#x60; is.  Geeft aan of er bij de eventuele bestaande hypotheek gebruik is gemaakt van de Nationale Hypotheekgarantie.
        /// </summary>
        /// <value>Verplicht te gebruiken voor de combinatie van de producttypen &#x60;modelwaardeDesktopTaxatie&#x60; en &#x60;desktopTaxatie&#x60;, als er gebruikt gemaakt wordt van de Nationale Hypotheekgarantie (&#x60;isNhg&#x60;) en het aanvraagdoel niet &#x60;aankoopNieuweWoning&#x60; is.  Geeft aan of er bij de eventuele bestaande hypotheek gebruik is gemaakt van de Nationale Hypotheekgarantie.</value>
        [DataMember(Name = "isBestaandeNhgHypotheek", EmitDefaultValue = true)]
        public bool IsBestaandeNhgHypotheek { get; set; }

        /// <summary>
        /// Verplicht voor de combinatie van de producttypen &#x60;modelwaardeDesktopTaxatie&#x60; en &#x60;desktopTaxatie&#x60; en het aanvraagdoel &#x60;overbruggingsfinanciering&#x60;.  In hele euros.
        /// </summary>
        /// <value>Verplicht voor de combinatie van de producttypen &#x60;modelwaardeDesktopTaxatie&#x60; en &#x60;desktopTaxatie&#x60; en het aanvraagdoel &#x60;overbruggingsfinanciering&#x60;.  In hele euros.</value>
        [DataMember(Name = "benodigdeOverbrugging", EmitDefaultValue = false)]
        public int BenodigdeOverbrugging { get; set; }

        /// <summary>
        /// Optioneel te gebruiken voor de producttypen &#x60;modelwaardeRisico&#x60;.  Peildatum voor de aanvraag. Standaard de datum van vandaag.  Supports yyyy-MM-dd or optionally yyyy-MM-ddTHH:mm:ssZ (ISO) with the time stamp assumed to be in UTC and the time is dropped before using the value.
        /// </summary>
        /// <value>Optioneel te gebruiken voor de producttypen &#x60;modelwaardeRisico&#x60;.  Peildatum voor de aanvraag. Standaard de datum van vandaag.  Supports yyyy-MM-dd or optionally yyyy-MM-ddTHH:mm:ssZ (ISO) with the time stamp assumed to be in UTC and the time is dropped before using the value.</value>
        [DataMember(Name = "peildatum", EmitDefaultValue = true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? Peildatum { get; set; }

        /// <summary>
        /// Potentieel verplicht voor de product typen &#x60;modelwaardeDesktopTaxatie&#x60; en &#x60;desktopTaxatie&#x60; afhankelijk van de geldverstrekker- en accountconfiguratie.
        /// </summary>
        /// <value>Potentieel verplicht voor de product typen &#x60;modelwaardeDesktopTaxatie&#x60; en &#x60;desktopTaxatie&#x60; afhankelijk van de geldverstrekker- en accountconfiguratie.</value>
        [DataMember(Name = "isErfpacht", EmitDefaultValue = true)]
        public bool? IsErfpacht { get; set; }

        /// <summary>
        /// Vrij veld voor het opslaan van een klantkenmerk, zoals bijvoorbeeld een dossiernummer of andere interne referentie. Dit veld komt later weer terug in het &#x60;origineleInput&#x60; veld in het &#x60;waardering&#x60; object.
        /// </summary>
        /// <value>Vrij veld voor het opslaan van een klantkenmerk, zoals bijvoorbeeld een dossiernummer of andere interne referentie. Dit veld komt later weer terug in het &#x60;origineleInput&#x60; veld in het &#x60;waardering&#x60; object.</value>
        [DataMember(Name = "klantkenmerk", EmitDefaultValue = false)]
        public string Klantkenmerk { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
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
            sb.Append("  Peildatum: ").Append(Peildatum).Append("\n");
            sb.Append("  IsErfpacht: ").Append(IsErfpacht).Append("\n");
            sb.Append("  Klantkenmerk: ").Append(Klantkenmerk).Append("\n");
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
            {
                return false;
            }
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
                ) && 
                (
                    this.Peildatum == input.Peildatum ||
                    (this.Peildatum != null &&
                    this.Peildatum.Equals(input.Peildatum))
                ) && 
                (
                    this.IsErfpacht == input.IsErfpacht ||
                    (this.IsErfpacht != null &&
                    this.IsErfpacht.Equals(input.IsErfpacht))
                ) && 
                (
                    this.Klantkenmerk == input.Klantkenmerk ||
                    (this.Klantkenmerk != null &&
                    this.Klantkenmerk.Equals(input.Klantkenmerk))
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
                {
                    hashCode = (hashCode * 59) + this.Geldverstrekker.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ProductType.GetHashCode();
                hashCode = (hashCode * 59) + this.Hypotheekwaarde.GetHashCode();
                hashCode = (hashCode * 59) + this.Aanvraagdoel.GetHashCode();
                hashCode = (hashCode * 59) + this.Klantwaarde.GetHashCode();
                hashCode = (hashCode * 59) + this.KlantwaardeType.GetHashCode();
                hashCode = (hashCode * 59) + this.IsBestaandeWoning.GetHashCode();
                hashCode = (hashCode * 59) + this.BagNummeraanduidingId.GetHashCode();
                hashCode = (hashCode * 59) + this.IsNhg.GetHashCode();
                hashCode = (hashCode * 59) + this.IsBestaandeNhgHypotheek.GetHashCode();
                hashCode = (hashCode * 59) + this.BenodigdeOverbrugging.GetHashCode();
                if (this.Peildatum != null)
                {
                    hashCode = (hashCode * 59) + this.Peildatum.GetHashCode();
                }
                if (this.IsErfpacht != null)
                {
                    hashCode = (hashCode * 59) + this.IsErfpacht.GetHashCode();
                }
                if (this.Klantkenmerk != null)
                {
                    hashCode = (hashCode * 59) + this.Klantkenmerk.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
