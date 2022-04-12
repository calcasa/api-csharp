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
 * The version of the OpenAPI document: 1.1.4
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
    /// VorigeVerkoop
    /// </summary>
    [DataContract(Name = "VorigeVerkoop")]
    public partial class VorigeVerkoop : IEquatable<VorigeVerkoop>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VorigeVerkoop" /> class.
        /// </summary>
        /// <param name="verkoopprijs">In hele euros..</param>
        /// <param name="geindexeerdeVerkoopprijs">In hele euros..</param>
        /// <param name="vierkantemeterprijs">In hele euros per vierkante meter..</param>
        /// <param name="geindexeerdeVierkantemeterprijs">In hele euros per vierkante meter..</param>
        /// <param name="verkoopdatum">In UTC..</param>
        /// <param name="perceeloppervlak">Het perceeloppervlak in hele vierkante meters..</param>
        /// <param name="bijzonderheden">Eventuele bijzonderheden van de transactie..</param>
        public VorigeVerkoop(int verkoopprijs = default(int), int geindexeerdeVerkoopprijs = default(int), int vierkantemeterprijs = default(int), int geindexeerdeVierkantemeterprijs = default(int), DateTime verkoopdatum = default(DateTime), int perceeloppervlak = default(int), Collection<VerkoopBijzonderheden> bijzonderheden = default(Collection<VerkoopBijzonderheden>))
        {
            this.Verkoopprijs = verkoopprijs;
            this.GeindexeerdeVerkoopprijs = geindexeerdeVerkoopprijs;
            this.Vierkantemeterprijs = vierkantemeterprijs;
            this.GeindexeerdeVierkantemeterprijs = geindexeerdeVierkantemeterprijs;
            this.Verkoopdatum = verkoopdatum;
            this.Perceeloppervlak = perceeloppervlak;
            this.Bijzonderheden = bijzonderheden;
        }

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
        [DataMember(Name = "geindexeerdeVerkoopprijs", EmitDefaultValue = false)]
        public int GeindexeerdeVerkoopprijs { get; set; }

        /// <summary>
        /// In hele euros per vierkante meter.
        /// </summary>
        /// <value>In hele euros per vierkante meter.</value>
        [DataMember(Name = "vierkantemeterprijs", EmitDefaultValue = false)]
        public int Vierkantemeterprijs { get; set; }

        /// <summary>
        /// In hele euros per vierkante meter.
        /// </summary>
        /// <value>In hele euros per vierkante meter.</value>
        [DataMember(Name = "geindexeerdeVierkantemeterprijs", EmitDefaultValue = false)]
        public int GeindexeerdeVierkantemeterprijs { get; set; }

        /// <summary>
        /// In UTC.
        /// </summary>
        /// <value>In UTC.</value>
        [DataMember(Name = "verkoopdatum", EmitDefaultValue = false)]
        public DateTime Verkoopdatum { get; set; }

        /// <summary>
        /// Het perceeloppervlak in hele vierkante meters.
        /// </summary>
        /// <value>Het perceeloppervlak in hele vierkante meters.</value>
        [DataMember(Name = "perceeloppervlak", EmitDefaultValue = false)]
        public int Perceeloppervlak { get; set; }

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
            StringBuilder sb = new StringBuilder();
            sb.Append("class VorigeVerkoop {\n");
            sb.Append("  Verkoopprijs: ").Append(Verkoopprijs).Append("\n");
            sb.Append("  GeindexeerdeVerkoopprijs: ").Append(GeindexeerdeVerkoopprijs).Append("\n");
            sb.Append("  Vierkantemeterprijs: ").Append(Vierkantemeterprijs).Append("\n");
            sb.Append("  GeindexeerdeVierkantemeterprijs: ").Append(GeindexeerdeVierkantemeterprijs).Append("\n");
            sb.Append("  Verkoopdatum: ").Append(Verkoopdatum).Append("\n");
            sb.Append("  Perceeloppervlak: ").Append(Perceeloppervlak).Append("\n");
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
            return this.Equals(input as VorigeVerkoop);
        }

        /// <summary>
        /// Returns true if VorigeVerkoop instances are equal
        /// </summary>
        /// <param name="input">Instance of VorigeVerkoop to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VorigeVerkoop input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Verkoopprijs == input.Verkoopprijs ||
                    this.Verkoopprijs.Equals(input.Verkoopprijs)
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
                    this.GeindexeerdeVierkantemeterprijs == input.GeindexeerdeVierkantemeterprijs ||
                    this.GeindexeerdeVierkantemeterprijs.Equals(input.GeindexeerdeVierkantemeterprijs)
                ) && 
                (
                    this.Verkoopdatum == input.Verkoopdatum ||
                    (this.Verkoopdatum != null &&
                    this.Verkoopdatum.Equals(input.Verkoopdatum))
                ) && 
                (
                    this.Perceeloppervlak == input.Perceeloppervlak ||
                    this.Perceeloppervlak.Equals(input.Perceeloppervlak)
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
                hashCode = (hashCode * 59) + this.Verkoopprijs.GetHashCode();
                hashCode = (hashCode * 59) + this.GeindexeerdeVerkoopprijs.GetHashCode();
                hashCode = (hashCode * 59) + this.Vierkantemeterprijs.GetHashCode();
                hashCode = (hashCode * 59) + this.GeindexeerdeVierkantemeterprijs.GetHashCode();
                if (this.Verkoopdatum != null)
                {
                    hashCode = (hashCode * 59) + this.Verkoopdatum.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Perceeloppervlak.GetHashCode();
                if (this.Bijzonderheden != null)
                {
                    hashCode = (hashCode * 59) + this.Bijzonderheden.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
