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
 * The version of the OpenAPI document: 1.2.0
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
    /// WaarderingFactuur
    /// </summary>
    [DataContract(Name = "Waardering_factuur")]
    public partial class WaarderingFactuur : IEquatable<WaarderingFactuur>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WaarderingFactuur" /> class.
        /// </summary>
        /// <param name="id">Het factuur Id..</param>
        /// <param name="factuurnummer">Het factuurnummer van de factuur..</param>
        public WaarderingFactuur(Guid id = default(Guid), string factuurnummer = default(string))
        {
            this.Id = id;
            this.Factuurnummer = factuurnummer;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Het factuur Id.
        /// </summary>
        /// <value>Het factuur Id.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public Guid Id { get; set; }

        /// <summary>
        /// Het factuurnummer van de factuur.
        /// </summary>
        /// <value>Het factuurnummer van de factuur.</value>
        [DataMember(Name = "factuurnummer", EmitDefaultValue = false)]
        public string Factuurnummer { get; set; }

        /// <summary>
        /// Gets or Sets additional properties
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WaarderingFactuur {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Factuurnummer: ").Append(Factuurnummer).Append("\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
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
            return this.Equals(input as WaarderingFactuur);
        }

        /// <summary>
        /// Returns true if WaarderingFactuur instances are equal
        /// </summary>
        /// <param name="input">Instance of WaarderingFactuur to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WaarderingFactuur input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Factuurnummer == input.Factuurnummer ||
                    (this.Factuurnummer != null &&
                    this.Factuurnummer.Equals(input.Factuurnummer))
                )
                && (this.AdditionalProperties.Count == input.AdditionalProperties.Count && !this.AdditionalProperties.Except(input.AdditionalProperties).Any());
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
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.Factuurnummer != null)
                {
                    hashCode = (hashCode * 59) + this.Factuurnummer.GetHashCode();
                }
                if (this.AdditionalProperties != null)
                {
                    hashCode = (hashCode * 59) + this.AdditionalProperties.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
