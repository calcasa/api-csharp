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
    /// Referentieobject
    /// </summary>
    [DataContract(Name = "Referentieobject")]
    public partial class Referentieobject : IEquatable<Referentieobject>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Referentieobject" /> class.
        /// </summary>
        /// <param name="afstand">Afstand tot het waarderingsobject in meters..</param>
        /// <param name="verkoopprijs">In hele euros..</param>
        /// <param name="gecorrigeerdeVerkoopprijs">In hele euros..</param>
        /// <param name="geindexeerdeVerkoopprijs">In hele euros..</param>
        /// <param name="vierkantemeterprijs">In hele euros per vierkante meters..</param>
        /// <param name="gecorrigeerdeVierkantemeterprijs">In hele euros per vierkante meters..</param>
        /// <param name="geindexeerdeVierkantemeterprijs">In hele euros per vierkante meters..</param>
        /// <param name="verkoopdatum">In UTC..</param>
        /// <param name="adres">adres.</param>
        /// <param name="_object">_object.</param>
        /// <param name="cbsIndeling">cbsIndeling.</param>
        /// <param name="fotos">Fotos van het referentieobject..</param>
        /// <param name="bijzonderheden">Eventuele bijzonderheden van de transactie..</param>
        public Referentieobject(int afstand = default(int), int verkoopprijs = default(int), int gecorrigeerdeVerkoopprijs = default(int), int geindexeerdeVerkoopprijs = default(int), int vierkantemeterprijs = default(int), int gecorrigeerdeVierkantemeterprijs = default(int), int geindexeerdeVierkantemeterprijs = default(int), DateTime verkoopdatum = default(DateTime), Adres adres = default(Adres), Objectdata _object = default(Objectdata), CbsIndeling cbsIndeling = default(CbsIndeling), Collection<Foto> fotos = default(Collection<Foto>), Collection<VerkoopBijzonderheden> bijzonderheden = default(Collection<VerkoopBijzonderheden>))
        {
            this.Afstand = afstand;
            this.Verkoopprijs = verkoopprijs;
            this.GecorrigeerdeVerkoopprijs = gecorrigeerdeVerkoopprijs;
            this.GeindexeerdeVerkoopprijs = geindexeerdeVerkoopprijs;
            this.Vierkantemeterprijs = vierkantemeterprijs;
            this.GecorrigeerdeVierkantemeterprijs = gecorrigeerdeVierkantemeterprijs;
            this.GeindexeerdeVierkantemeterprijs = geindexeerdeVierkantemeterprijs;
            this.Verkoopdatum = verkoopdatum;
            this.Adres = adres;
            this.Object = _object;
            this.CbsIndeling = cbsIndeling;
            this.Fotos = fotos;
            this.Bijzonderheden = bijzonderheden;
        }

        /// <summary>
        /// Afstand tot het waarderingsobject in meters.
        /// </summary>
        /// <value>Afstand tot het waarderingsobject in meters.</value>
        [DataMember(Name = "afstand", EmitDefaultValue = false)]
        public int Afstand { get; set; }

        /// <summary>
        /// In hele euros.
        /// </summary>
        /// <value>In hele euros.</value>
        [DataMember(Name = "verkoopprijs", EmitDefaultValue = false)]
        public int Verkoopprijs { get; set; }

        /// <summary>
        /// In hele euros.
        /// </summary>
        /// <value>In hele euros.</value>
        [DataMember(Name = "gecorrigeerdeVerkoopprijs", EmitDefaultValue = false)]
        public int GecorrigeerdeVerkoopprijs { get; set; }

        /// <summary>
        /// In hele euros.
        /// </summary>
        /// <value>In hele euros.</value>
        [DataMember(Name = "geindexeerdeVerkoopprijs", EmitDefaultValue = false)]
        public int GeindexeerdeVerkoopprijs { get; set; }

        /// <summary>
        /// In hele euros per vierkante meters.
        /// </summary>
        /// <value>In hele euros per vierkante meters.</value>
        [DataMember(Name = "vierkantemeterprijs", EmitDefaultValue = false)]
        public int Vierkantemeterprijs { get; set; }

        /// <summary>
        /// In hele euros per vierkante meters.
        /// </summary>
        /// <value>In hele euros per vierkante meters.</value>
        [DataMember(Name = "gecorrigeerdeVierkantemeterprijs", EmitDefaultValue = false)]
        public int GecorrigeerdeVierkantemeterprijs { get; set; }

        /// <summary>
        /// In hele euros per vierkante meters.
        /// </summary>
        /// <value>In hele euros per vierkante meters.</value>
        [DataMember(Name = "geindexeerdeVierkantemeterprijs", EmitDefaultValue = false)]
        public int GeindexeerdeVierkantemeterprijs { get; set; }

        /// <summary>
        /// In UTC.
        /// </summary>
        /// <value>In UTC.</value>
        [DataMember(Name = "verkoopdatum", EmitDefaultValue = false)]
        public DateTime Verkoopdatum { get; set; }

        /// <summary>
        /// Gets or Sets Adres
        /// </summary>
        [DataMember(Name = "adres", EmitDefaultValue = true)]
        public Adres Adres { get; set; }

        /// <summary>
        /// Gets or Sets Object
        /// </summary>
        [DataMember(Name = "object", EmitDefaultValue = true)]
        public Objectdata Object { get; set; }

        /// <summary>
        /// Gets or Sets CbsIndeling
        /// </summary>
        [DataMember(Name = "cbsIndeling", EmitDefaultValue = true)]
        public CbsIndeling CbsIndeling { get; set; }

        /// <summary>
        /// Fotos van het referentieobject.
        /// </summary>
        /// <value>Fotos van het referentieobject.</value>
        [DataMember(Name = "fotos", EmitDefaultValue = false)]
        public Collection<Foto> Fotos { get; set; }

        /// <summary>
        /// Eventuele bijzonderheden van de transactie.
        /// </summary>
        /// <value>Eventuele bijzonderheden van de transactie.</value>
        [DataMember(Name = "bijzonderheden", EmitDefaultValue = false)]
        public Collection<VerkoopBijzonderheden> Bijzonderheden { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Referentieobject {\n");
            sb.Append("  Afstand: ").Append(Afstand).Append("\n");
            sb.Append("  Verkoopprijs: ").Append(Verkoopprijs).Append("\n");
            sb.Append("  GecorrigeerdeVerkoopprijs: ").Append(GecorrigeerdeVerkoopprijs).Append("\n");
            sb.Append("  GeindexeerdeVerkoopprijs: ").Append(GeindexeerdeVerkoopprijs).Append("\n");
            sb.Append("  Vierkantemeterprijs: ").Append(Vierkantemeterprijs).Append("\n");
            sb.Append("  GecorrigeerdeVierkantemeterprijs: ").Append(GecorrigeerdeVierkantemeterprijs).Append("\n");
            sb.Append("  GeindexeerdeVierkantemeterprijs: ").Append(GeindexeerdeVierkantemeterprijs).Append("\n");
            sb.Append("  Verkoopdatum: ").Append(Verkoopdatum).Append("\n");
            sb.Append("  Adres: ").Append(Adres).Append("\n");
            sb.Append("  Object: ").Append(Object).Append("\n");
            sb.Append("  CbsIndeling: ").Append(CbsIndeling).Append("\n");
            sb.Append("  Fotos: ").Append(Fotos).Append("\n");
            sb.Append("  Bijzonderheden: ").Append(Bijzonderheden).Append("\n");
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
            return this.Equals(input as Referentieobject);
        }

        /// <summary>
        /// Returns true if Referentieobject instances are equal
        /// </summary>
        /// <param name="input">Instance of Referentieobject to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Referentieobject input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Afstand == input.Afstand ||
                    this.Afstand.Equals(input.Afstand)
                ) && 
                (
                    this.Verkoopprijs == input.Verkoopprijs ||
                    this.Verkoopprijs.Equals(input.Verkoopprijs)
                ) && 
                (
                    this.GecorrigeerdeVerkoopprijs == input.GecorrigeerdeVerkoopprijs ||
                    this.GecorrigeerdeVerkoopprijs.Equals(input.GecorrigeerdeVerkoopprijs)
                ) && 
                (
                    this.GeindexeerdeVerkoopprijs == input.GeindexeerdeVerkoopprijs ||
                    this.GeindexeerdeVerkoopprijs.Equals(input.GeindexeerdeVerkoopprijs)
                ) && 
                (
                    this.Vierkantemeterprijs == input.Vierkantemeterprijs ||
                    this.Vierkantemeterprijs.Equals(input.Vierkantemeterprijs)
                ) && 
                (
                    this.GecorrigeerdeVierkantemeterprijs == input.GecorrigeerdeVierkantemeterprijs ||
                    this.GecorrigeerdeVierkantemeterprijs.Equals(input.GecorrigeerdeVierkantemeterprijs)
                ) && 
                (
                    this.GeindexeerdeVierkantemeterprijs == input.GeindexeerdeVierkantemeterprijs ||
                    this.GeindexeerdeVierkantemeterprijs.Equals(input.GeindexeerdeVierkantemeterprijs)
                ) && 
                (
                    this.Verkoopdatum == input.Verkoopdatum ||
                    (this.Verkoopdatum != null &&
                    this.Verkoopdatum.Equals(input.Verkoopdatum))
                ) && 
                (
                    this.Adres == input.Adres ||
                    (this.Adres != null &&
                    this.Adres.Equals(input.Adres))
                ) && 
                (
                    this.Object == input.Object ||
                    (this.Object != null &&
                    this.Object.Equals(input.Object))
                ) && 
                (
                    this.CbsIndeling == input.CbsIndeling ||
                    (this.CbsIndeling != null &&
                    this.CbsIndeling.Equals(input.CbsIndeling))
                ) && 
                (
                    this.Fotos == input.Fotos ||
                    this.Fotos != null &&
                    input.Fotos != null &&
                    this.Fotos.SequenceEqual(input.Fotos)
                ) && 
                (
                    this.Bijzonderheden == input.Bijzonderheden ||
                    this.Bijzonderheden != null &&
                    input.Bijzonderheden != null &&
                    this.Bijzonderheden.SequenceEqual(input.Bijzonderheden)
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
                hashCode = hashCode * 59 + this.Afstand.GetHashCode();
                hashCode = hashCode * 59 + this.Verkoopprijs.GetHashCode();
                hashCode = hashCode * 59 + this.GecorrigeerdeVerkoopprijs.GetHashCode();
                hashCode = hashCode * 59 + this.GeindexeerdeVerkoopprijs.GetHashCode();
                hashCode = hashCode * 59 + this.Vierkantemeterprijs.GetHashCode();
                hashCode = hashCode * 59 + this.GecorrigeerdeVierkantemeterprijs.GetHashCode();
                hashCode = hashCode * 59 + this.GeindexeerdeVierkantemeterprijs.GetHashCode();
                if (this.Verkoopdatum != null)
                    hashCode = hashCode * 59 + this.Verkoopdatum.GetHashCode();
                if (this.Adres != null)
                    hashCode = hashCode * 59 + this.Adres.GetHashCode();
                if (this.Object != null)
                    hashCode = hashCode * 59 + this.Object.GetHashCode();
                if (this.CbsIndeling != null)
                    hashCode = hashCode * 59 + this.CbsIndeling.GetHashCode();
                if (this.Fotos != null)
                    hashCode = hashCode * 59 + this.Fotos.GetHashCode();
                if (this.Bijzonderheden != null)
                    hashCode = hashCode * 59 + this.Bijzonderheden.GetHashCode();
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
