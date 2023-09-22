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
    /// Adres
    /// </summary>
    [DataContract(Name = "Adres")]
    public partial class Adres : IEquatable<Adres>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Adres" /> class.
        /// </summary>
        /// <param name="straat">De straatnaam zoals geschreven in de BAG (Basisregistratie Adressen en Gebouwen)..</param>
        /// <param name="huisnummer">Het huisnummer..</param>
        /// <param name="huisnummertoevoeging">De huisnummertoevoeging..</param>
        /// <param name="postcode">De postcode met 4 cijfers en 2 letters zonder spatie..</param>
        /// <param name="woonplaats">De woonplaats zoals geschreven in de BAG (Basisregistratie Adressen en Gebouwen)..</param>
        public Adres(string straat = default(string), int huisnummer = default(int), string huisnummertoevoeging = default(string), string postcode = default(string), string woonplaats = default(string))
        {
            this.Straat = straat;
            this.Huisnummer = huisnummer;
            this.Huisnummertoevoeging = huisnummertoevoeging;
            this.Postcode = postcode;
            this.Woonplaats = woonplaats;
        }

        /// <summary>
        /// De straatnaam zoals geschreven in de BAG (Basisregistratie Adressen en Gebouwen).
        /// </summary>
        /// <value>De straatnaam zoals geschreven in de BAG (Basisregistratie Adressen en Gebouwen).</value>
        [DataMember(Name = "straat", EmitDefaultValue = false)]
        public string Straat { get; set; }

        /// <summary>
        /// Het huisnummer.
        /// </summary>
        /// <value>Het huisnummer.</value>
        [DataMember(Name = "huisnummer", EmitDefaultValue = false)]
        public int Huisnummer { get; set; }

        /// <summary>
        /// De huisnummertoevoeging.
        /// </summary>
        /// <value>De huisnummertoevoeging.</value>
        [DataMember(Name = "huisnummertoevoeging", EmitDefaultValue = true)]
        public string Huisnummertoevoeging { get; set; }

        /// <summary>
        /// De postcode met 4 cijfers en 2 letters zonder spatie.
        /// </summary>
        /// <value>De postcode met 4 cijfers en 2 letters zonder spatie.</value>
        [DataMember(Name = "postcode", EmitDefaultValue = false)]
        public string Postcode { get; set; }

        /// <summary>
        /// De woonplaats zoals geschreven in de BAG (Basisregistratie Adressen en Gebouwen).
        /// </summary>
        /// <value>De woonplaats zoals geschreven in de BAG (Basisregistratie Adressen en Gebouwen).</value>
        [DataMember(Name = "woonplaats", EmitDefaultValue = false)]
        public string Woonplaats { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Adres {\n");
            sb.Append("  Straat: ").Append(Straat).Append("\n");
            sb.Append("  Huisnummer: ").Append(Huisnummer).Append("\n");
            sb.Append("  Huisnummertoevoeging: ").Append(Huisnummertoevoeging).Append("\n");
            sb.Append("  Postcode: ").Append(Postcode).Append("\n");
            sb.Append("  Woonplaats: ").Append(Woonplaats).Append("\n");
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
            return this.Equals(input as Adres);
        }

        /// <summary>
        /// Returns true if Adres instances are equal
        /// </summary>
        /// <param name="input">Instance of Adres to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Adres input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Straat == input.Straat ||
                    (this.Straat != null &&
                    this.Straat.Equals(input.Straat))
                ) && 
                (
                    this.Huisnummer == input.Huisnummer ||
                    this.Huisnummer.Equals(input.Huisnummer)
                ) && 
                (
                    this.Huisnummertoevoeging == input.Huisnummertoevoeging ||
                    (this.Huisnummertoevoeging != null &&
                    this.Huisnummertoevoeging.Equals(input.Huisnummertoevoeging))
                ) && 
                (
                    this.Postcode == input.Postcode ||
                    (this.Postcode != null &&
                    this.Postcode.Equals(input.Postcode))
                ) && 
                (
                    this.Woonplaats == input.Woonplaats ||
                    (this.Woonplaats != null &&
                    this.Woonplaats.Equals(input.Woonplaats))
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
                if (this.Straat != null)
                {
                    hashCode = (hashCode * 59) + this.Straat.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Huisnummer.GetHashCode();
                if (this.Huisnummertoevoeging != null)
                {
                    hashCode = (hashCode * 59) + this.Huisnummertoevoeging.GetHashCode();
                }
                if (this.Postcode != null)
                {
                    hashCode = (hashCode * 59) + this.Postcode.GetHashCode();
                }
                if (this.Woonplaats != null)
                {
                    hashCode = (hashCode * 59) + this.Woonplaats.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
