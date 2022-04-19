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
    /// Geldverstrekker
    /// </summary>
    [DataContract(Name = "Geldverstrekker")]
    public partial class Geldverstrekker : IEquatable<Geldverstrekker>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Geldverstrekker" /> class.
        /// </summary>
        /// <param name="slug">De slug voor deze geldverstrekker, dit is de waarde die gebruikt moet worden als input voor andere endpoints..</param>
        /// <param name="name">De volledige naam van deze geldverstrekker..</param>
        public Geldverstrekker(string slug = default(string), string name = default(string))
        {
            this.Slug = slug;
            this.Name = name;
        }

        /// <summary>
        /// De slug voor deze geldverstrekker, dit is de waarde die gebruikt moet worden als input voor andere endpoints.
        /// </summary>
        /// <value>De slug voor deze geldverstrekker, dit is de waarde die gebruikt moet worden als input voor andere endpoints.</value>
        [DataMember(Name = "slug", EmitDefaultValue = false)]
        public string Slug { get; set; }

        /// <summary>
        /// De volledige naam van deze geldverstrekker.
        /// </summary>
        /// <value>De volledige naam van deze geldverstrekker.</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Geldverstrekker {\n");
            sb.Append("  Slug: ").Append(Slug).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(input as Geldverstrekker);
        }

        /// <summary>
        /// Returns true if Geldverstrekker instances are equal
        /// </summary>
        /// <param name="input">Instance of Geldverstrekker to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Geldverstrekker input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Slug == input.Slug ||
                    (this.Slug != null &&
                    this.Slug.Equals(input.Slug))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                if (this.Slug != null)
                {
                    hashCode = (hashCode * 59) + this.Slug.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
