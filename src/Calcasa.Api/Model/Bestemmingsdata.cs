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
 * The version of the OpenAPI document: 1.0.1
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
    /// Bestemmingsdata
    /// </summary>
    [DataContract(Name = "Bestemmingsdata")]
    public partial class Bestemmingsdata : IEquatable<Bestemmingsdata>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Bestemmingsdata" /> class.
        /// </summary>
        /// <param name="enkelbestemming">De enkelbestemming volgens het bestemmingsplan..</param>
        /// <param name="datumBestemmingplan">De datum waarop dit bestemmingsplan vastgelegd is..</param>
        public Bestemmingsdata(string enkelbestemming = default(string), DateTime? datumBestemmingplan = default(DateTime?))
        {
            this.Enkelbestemming = enkelbestemming;
            this.DatumBestemmingplan = datumBestemmingplan;
        }

        /// <summary>
        /// De enkelbestemming volgens het bestemmingsplan.
        /// </summary>
        /// <value>De enkelbestemming volgens het bestemmingsplan.</value>
        [DataMember(Name = "enkelbestemming", EmitDefaultValue = true)]
        public string Enkelbestemming { get; set; }

        /// <summary>
        /// De datum waarop dit bestemmingsplan vastgelegd is.
        /// </summary>
        /// <value>De datum waarop dit bestemmingsplan vastgelegd is.</value>
        [DataMember(Name = "datumBestemmingplan", EmitDefaultValue = true)]
        public DateTime? DatumBestemmingplan { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Bestemmingsdata {\n");
            sb.Append("  Enkelbestemming: ").Append(Enkelbestemming).Append("\n");
            sb.Append("  DatumBestemmingplan: ").Append(DatumBestemmingplan).Append("\n");
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
            return this.Equals(input as Bestemmingsdata);
        }

        /// <summary>
        /// Returns true if Bestemmingsdata instances are equal
        /// </summary>
        /// <param name="input">Instance of Bestemmingsdata to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Bestemmingsdata input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Enkelbestemming == input.Enkelbestemming ||
                    (this.Enkelbestemming != null &&
                    this.Enkelbestemming.Equals(input.Enkelbestemming))
                ) && 
                (
                    this.DatumBestemmingplan == input.DatumBestemmingplan ||
                    (this.DatumBestemmingplan != null &&
                    this.DatumBestemmingplan.Equals(input.DatumBestemmingplan))
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
                if (this.Enkelbestemming != null)
                    hashCode = hashCode * 59 + this.Enkelbestemming.GetHashCode();
                if (this.DatumBestemmingplan != null)
                    hashCode = hashCode * 59 + this.DatumBestemmingplan.GetHashCode();
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
