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
    /// Modeldata
    /// </summary>
    [DataContract(Name = "Modeldata")]
    public partial class Modeldata : IEquatable<Modeldata>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Modeldata" /> class.
        /// </summary>
        /// <param name="marktwaarde">In hele euros..</param>
        /// <param name="marktwaardeOndergrens">In hele euros..</param>
        /// <param name="marktwaardeBovengrens">In hele euros..</param>
        /// <param name="confidenceLevel">Op een schaal van 0 tot 7..</param>
        /// <param name="waardebepalingsdatum">In UTC..</param>
        /// <param name="executiewaarde">In hele euros..</param>
        public Modeldata(int marktwaarde = default(int), int marktwaardeOndergrens = default(int), int marktwaardeBovengrens = default(int), float confidenceLevel = default(float), DateTime waardebepalingsdatum = default(DateTime), int executiewaarde = default(int))
        {
            this.Marktwaarde = marktwaarde;
            this.MarktwaardeOndergrens = marktwaardeOndergrens;
            this.MarktwaardeBovengrens = marktwaardeBovengrens;
            this.ConfidenceLevel = confidenceLevel;
            this.Waardebepalingsdatum = waardebepalingsdatum;
            this.Executiewaarde = executiewaarde;
        }

        /// <summary>
        /// In hele euros.
        /// </summary>
        /// <value>In hele euros.</value>
        [DataMember(Name = "marktwaarde", EmitDefaultValue = false)]
        public int Marktwaarde { get; set; }

        /// <summary>
        /// In hele euros.
        /// </summary>
        /// <value>In hele euros.</value>
        [DataMember(Name = "marktwaardeOndergrens", EmitDefaultValue = false)]
        public int MarktwaardeOndergrens { get; set; }

        /// <summary>
        /// In hele euros.
        /// </summary>
        /// <value>In hele euros.</value>
        [DataMember(Name = "marktwaardeBovengrens", EmitDefaultValue = false)]
        public int MarktwaardeBovengrens { get; set; }

        /// <summary>
        /// Op een schaal van 0 tot 7.
        /// </summary>
        /// <value>Op een schaal van 0 tot 7.</value>
        [DataMember(Name = "confidenceLevel", EmitDefaultValue = false)]
        public float ConfidenceLevel { get; set; }

        /// <summary>
        /// In UTC.
        /// </summary>
        /// <value>In UTC.</value>
        [DataMember(Name = "waardebepalingsdatum", EmitDefaultValue = false)]
        public DateTime Waardebepalingsdatum { get; set; }

        /// <summary>
        /// In hele euros.
        /// </summary>
        /// <value>In hele euros.</value>
        [DataMember(Name = "executiewaarde", EmitDefaultValue = false)]
        public int Executiewaarde { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Modeldata {\n");
            sb.Append("  Marktwaarde: ").Append(Marktwaarde).Append("\n");
            sb.Append("  MarktwaardeOndergrens: ").Append(MarktwaardeOndergrens).Append("\n");
            sb.Append("  MarktwaardeBovengrens: ").Append(MarktwaardeBovengrens).Append("\n");
            sb.Append("  ConfidenceLevel: ").Append(ConfidenceLevel).Append("\n");
            sb.Append("  Waardebepalingsdatum: ").Append(Waardebepalingsdatum).Append("\n");
            sb.Append("  Executiewaarde: ").Append(Executiewaarde).Append("\n");
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
            return this.Equals(input as Modeldata);
        }

        /// <summary>
        /// Returns true if Modeldata instances are equal
        /// </summary>
        /// <param name="input">Instance of Modeldata to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Modeldata input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Marktwaarde == input.Marktwaarde ||
                    this.Marktwaarde.Equals(input.Marktwaarde)
                ) && 
                (
                    this.MarktwaardeOndergrens == input.MarktwaardeOndergrens ||
                    this.MarktwaardeOndergrens.Equals(input.MarktwaardeOndergrens)
                ) && 
                (
                    this.MarktwaardeBovengrens == input.MarktwaardeBovengrens ||
                    this.MarktwaardeBovengrens.Equals(input.MarktwaardeBovengrens)
                ) && 
                (
                    this.ConfidenceLevel == input.ConfidenceLevel ||
                    this.ConfidenceLevel.Equals(input.ConfidenceLevel)
                ) && 
                (
                    this.Waardebepalingsdatum == input.Waardebepalingsdatum ||
                    (this.Waardebepalingsdatum != null &&
                    this.Waardebepalingsdatum.Equals(input.Waardebepalingsdatum))
                ) && 
                (
                    this.Executiewaarde == input.Executiewaarde ||
                    this.Executiewaarde.Equals(input.Executiewaarde)
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
                hashCode = (hashCode * 59) + this.Marktwaarde.GetHashCode();
                hashCode = (hashCode * 59) + this.MarktwaardeOndergrens.GetHashCode();
                hashCode = (hashCode * 59) + this.MarktwaardeBovengrens.GetHashCode();
                hashCode = (hashCode * 59) + this.ConfidenceLevel.GetHashCode();
                if (this.Waardebepalingsdatum != null)
                {
                    hashCode = (hashCode * 59) + this.Waardebepalingsdatum.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Executiewaarde.GetHashCode();
                return hashCode;
            }
        }

    }

}
