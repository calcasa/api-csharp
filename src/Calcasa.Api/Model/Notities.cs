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
    /// Notities
    /// </summary>
    [DataContract(Name = "Notities")]
    public partial class Notities : IEquatable<Notities>
    {

        /// <summary>
        /// Gets or Sets Straat
        /// </summary>
        [DataMember(Name = "straat", EmitDefaultValue = false)]
        public Notitie? Straat { get; set; }

        /// <summary>
        /// Gets or Sets Huisnummer
        /// </summary>
        [DataMember(Name = "huisnummer", EmitDefaultValue = false)]
        public Notitie? Huisnummer { get; set; }

        /// <summary>
        /// Gets or Sets Huisnummertoevoeging
        /// </summary>
        [DataMember(Name = "huisnummertoevoeging", EmitDefaultValue = false)]
        public Notitie? Huisnummertoevoeging { get; set; }

        /// <summary>
        /// Gets or Sets Postcode
        /// </summary>
        [DataMember(Name = "postcode", EmitDefaultValue = false)]
        public Notitie? Postcode { get; set; }

        /// <summary>
        /// Gets or Sets Woonplaats
        /// </summary>
        [DataMember(Name = "woonplaats", EmitDefaultValue = false)]
        public Notitie? Woonplaats { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Notities" /> class.
        /// </summary>
        /// <param name="straat">straat.</param>
        /// <param name="huisnummer">huisnummer.</param>
        /// <param name="huisnummertoevoeging">huisnummertoevoeging.</param>
        /// <param name="postcode">postcode.</param>
        /// <param name="woonplaats">woonplaats.</param>
        public Notities(Notitie? straat = default(Notitie?), Notitie? huisnummer = default(Notitie?), Notitie? huisnummertoevoeging = default(Notitie?), Notitie? postcode = default(Notitie?), Notitie? woonplaats = default(Notitie?))
        {
            this.Straat = straat;
            this.Huisnummer = huisnummer;
            this.Huisnummertoevoeging = huisnummertoevoeging;
            this.Postcode = postcode;
            this.Woonplaats = woonplaats;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Notities {\n");
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
            return this.Equals(input as Notities);
        }

        /// <summary>
        /// Returns true if Notities instances are equal
        /// </summary>
        /// <param name="input">Instance of Notities to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Notities input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Straat == input.Straat ||
                    this.Straat.Equals(input.Straat)
                ) && 
                (
                    this.Huisnummer == input.Huisnummer ||
                    this.Huisnummer.Equals(input.Huisnummer)
                ) && 
                (
                    this.Huisnummertoevoeging == input.Huisnummertoevoeging ||
                    this.Huisnummertoevoeging.Equals(input.Huisnummertoevoeging)
                ) && 
                (
                    this.Postcode == input.Postcode ||
                    this.Postcode.Equals(input.Postcode)
                ) && 
                (
                    this.Woonplaats == input.Woonplaats ||
                    this.Woonplaats.Equals(input.Woonplaats)
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
                hashCode = (hashCode * 59) + this.Straat.GetHashCode();
                hashCode = (hashCode * 59) + this.Huisnummer.GetHashCode();
                hashCode = (hashCode * 59) + this.Huisnummertoevoeging.GetHashCode();
                hashCode = (hashCode * 59) + this.Postcode.GetHashCode();
                hashCode = (hashCode * 59) + this.Woonplaats.GetHashCode();
                return hashCode;
            }
        }

    }

}
