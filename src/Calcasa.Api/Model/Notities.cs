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
    /// Notities
    /// </summary>
    [DataContract(Name = "Notities")]
    public partial class Notities : IEquatable<Notities>, IValidatableObject
    {

        /// <summary>
        /// De straatnaamnotitie. | Waarde | Omschrijving | | - -- | - -- | | &#x60;geen&#x60; | De input was correct. | | &#x60;gecorrigeerd&#x60; | De input was gecorrigeerd. | | &#x60;onbekend&#x60; | De input is onbekend en kon niet gevonden of gecorrigeerd worden. | | &#x60;ontbreekt&#x60; | De input was leeg en is wel nodig voor een succesvolle zoekopdracht. |   
        /// </summary>
        /// <value>De straatnaamnotitie. | Waarde | Omschrijving | | - -- | - -- | | &#x60;geen&#x60; | De input was correct. | | &#x60;gecorrigeerd&#x60; | De input was gecorrigeerd. | | &#x60;onbekend&#x60; | De input is onbekend en kon niet gevonden of gecorrigeerd worden. | | &#x60;ontbreekt&#x60; | De input was leeg en is wel nodig voor een succesvolle zoekopdracht. |   </value>
        [DataMember(Name = "straat", EmitDefaultValue = true)]
        public Notitie? Straat { get; set; }

        /// <summary>
        /// De huisnummernotitie. | Waarde | Omschrijving | | - -- | - -- | | &#x60;geen&#x60; | De input was correct. | | &#x60;gecorrigeerd&#x60; | De input was gecorrigeerd. | | &#x60;onbekend&#x60; | De input is onbekend en kon niet gevonden of gecorrigeerd worden. | | &#x60;ontbreekt&#x60; | De input was leeg en is wel nodig voor een succesvolle zoekopdracht. |   
        /// </summary>
        /// <value>De huisnummernotitie. | Waarde | Omschrijving | | - -- | - -- | | &#x60;geen&#x60; | De input was correct. | | &#x60;gecorrigeerd&#x60; | De input was gecorrigeerd. | | &#x60;onbekend&#x60; | De input is onbekend en kon niet gevonden of gecorrigeerd worden. | | &#x60;ontbreekt&#x60; | De input was leeg en is wel nodig voor een succesvolle zoekopdracht. |   </value>
        [DataMember(Name = "huisnummer", EmitDefaultValue = true)]
        public Notitie? Huisnummer { get; set; }

        /// <summary>
        /// De huisnummertoevoegingnotitie. | Waarde | Omschrijving | | - -- | - -- | | &#x60;geen&#x60; | De input was correct. | | &#x60;gecorrigeerd&#x60; | De input was gecorrigeerd. | | &#x60;onbekend&#x60; | De input is onbekend en kon niet gevonden of gecorrigeerd worden. | | &#x60;ontbreekt&#x60; | De input was leeg en is wel nodig voor een succesvolle zoekopdracht. |   
        /// </summary>
        /// <value>De huisnummertoevoegingnotitie. | Waarde | Omschrijving | | - -- | - -- | | &#x60;geen&#x60; | De input was correct. | | &#x60;gecorrigeerd&#x60; | De input was gecorrigeerd. | | &#x60;onbekend&#x60; | De input is onbekend en kon niet gevonden of gecorrigeerd worden. | | &#x60;ontbreekt&#x60; | De input was leeg en is wel nodig voor een succesvolle zoekopdracht. |   </value>
        [DataMember(Name = "huisnummertoevoeging", EmitDefaultValue = true)]
        public Notitie? Huisnummertoevoeging { get; set; }

        /// <summary>
        /// De postcodenotitie. | Waarde | Omschrijving | | - -- | - -- | | &#x60;geen&#x60; | De input was correct. | | &#x60;gecorrigeerd&#x60; | De input was gecorrigeerd. | | &#x60;onbekend&#x60; | De input is onbekend en kon niet gevonden of gecorrigeerd worden. | | &#x60;ontbreekt&#x60; | De input was leeg en is wel nodig voor een succesvolle zoekopdracht. |   
        /// </summary>
        /// <value>De postcodenotitie. | Waarde | Omschrijving | | - -- | - -- | | &#x60;geen&#x60; | De input was correct. | | &#x60;gecorrigeerd&#x60; | De input was gecorrigeerd. | | &#x60;onbekend&#x60; | De input is onbekend en kon niet gevonden of gecorrigeerd worden. | | &#x60;ontbreekt&#x60; | De input was leeg en is wel nodig voor een succesvolle zoekopdracht. |   </value>
        [DataMember(Name = "postcode", EmitDefaultValue = true)]
        public Notitie? Postcode { get; set; }

        /// <summary>
        /// De woonplaatsnotitie. | Waarde | Omschrijving | | - -- | - -- | | &#x60;geen&#x60; | De input was correct. | | &#x60;gecorrigeerd&#x60; | De input was gecorrigeerd. | | &#x60;onbekend&#x60; | De input is onbekend en kon niet gevonden of gecorrigeerd worden. | | &#x60;ontbreekt&#x60; | De input was leeg en is wel nodig voor een succesvolle zoekopdracht. |   
        /// </summary>
        /// <value>De woonplaatsnotitie. | Waarde | Omschrijving | | - -- | - -- | | &#x60;geen&#x60; | De input was correct. | | &#x60;gecorrigeerd&#x60; | De input was gecorrigeerd. | | &#x60;onbekend&#x60; | De input is onbekend en kon niet gevonden of gecorrigeerd worden. | | &#x60;ontbreekt&#x60; | De input was leeg en is wel nodig voor een succesvolle zoekopdracht. |   </value>
        [DataMember(Name = "woonplaats", EmitDefaultValue = true)]
        public Notitie? Woonplaats { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Notities" /> class.
        /// </summary>
        /// <param name="straat">De straatnaamnotitie. | Waarde | Omschrijving | | - -- | - -- | | &#x60;geen&#x60; | De input was correct. | | &#x60;gecorrigeerd&#x60; | De input was gecorrigeerd. | | &#x60;onbekend&#x60; | De input is onbekend en kon niet gevonden of gecorrigeerd worden. | | &#x60;ontbreekt&#x60; | De input was leeg en is wel nodig voor een succesvolle zoekopdracht. |   .</param>
        /// <param name="huisnummer">De huisnummernotitie. | Waarde | Omschrijving | | - -- | - -- | | &#x60;geen&#x60; | De input was correct. | | &#x60;gecorrigeerd&#x60; | De input was gecorrigeerd. | | &#x60;onbekend&#x60; | De input is onbekend en kon niet gevonden of gecorrigeerd worden. | | &#x60;ontbreekt&#x60; | De input was leeg en is wel nodig voor een succesvolle zoekopdracht. |   .</param>
        /// <param name="huisnummertoevoeging">De huisnummertoevoegingnotitie. | Waarde | Omschrijving | | - -- | - -- | | &#x60;geen&#x60; | De input was correct. | | &#x60;gecorrigeerd&#x60; | De input was gecorrigeerd. | | &#x60;onbekend&#x60; | De input is onbekend en kon niet gevonden of gecorrigeerd worden. | | &#x60;ontbreekt&#x60; | De input was leeg en is wel nodig voor een succesvolle zoekopdracht. |   .</param>
        /// <param name="postcode">De postcodenotitie. | Waarde | Omschrijving | | - -- | - -- | | &#x60;geen&#x60; | De input was correct. | | &#x60;gecorrigeerd&#x60; | De input was gecorrigeerd. | | &#x60;onbekend&#x60; | De input is onbekend en kon niet gevonden of gecorrigeerd worden. | | &#x60;ontbreekt&#x60; | De input was leeg en is wel nodig voor een succesvolle zoekopdracht. |   .</param>
        /// <param name="woonplaats">De woonplaatsnotitie. | Waarde | Omschrijving | | - -- | - -- | | &#x60;geen&#x60; | De input was correct. | | &#x60;gecorrigeerd&#x60; | De input was gecorrigeerd. | | &#x60;onbekend&#x60; | De input is onbekend en kon niet gevonden of gecorrigeerd worden. | | &#x60;ontbreekt&#x60; | De input was leeg en is wel nodig voor een succesvolle zoekopdracht. |   .</param>
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
            var sb = new StringBuilder();
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
                return false;

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
                hashCode = hashCode * 59 + this.Straat.GetHashCode();
                hashCode = hashCode * 59 + this.Huisnummer.GetHashCode();
                hashCode = hashCode * 59 + this.Huisnummertoevoeging.GetHashCode();
                hashCode = hashCode * 59 + this.Postcode.GetHashCode();
                hashCode = hashCode * 59 + this.Woonplaats.GetHashCode();
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
