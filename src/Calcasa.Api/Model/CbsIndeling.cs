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
    /// CbsIndeling
    /// </summary>
    [DataContract(Name = "CbsIndeling")]
    public partial class CbsIndeling : IEquatable<CbsIndeling>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CbsIndeling" /> class.
        /// </summary>
        /// <param name="buurtId">Het buurt id zoals bekend bij het CBS (Centraal Bureau voor de Statistiek)..</param>
        /// <param name="buurtnaam">De naam van de buurt..</param>
        /// <param name="wijknaam">De naam van de wijk..</param>
        /// <param name="gemeentenaam">De naam van de gemeente..</param>
        public CbsIndeling(int buurtId = default(int), string buurtnaam = default(string), string wijknaam = default(string), string gemeentenaam = default(string))
        {
            this.BuurtId = buurtId;
            this.Buurtnaam = buurtnaam;
            this.Wijknaam = wijknaam;
            this.Gemeentenaam = gemeentenaam;
        }

        /// <summary>
        /// Het buurt id zoals bekend bij het CBS (Centraal Bureau voor de Statistiek).
        /// </summary>
        /// <value>Het buurt id zoals bekend bij het CBS (Centraal Bureau voor de Statistiek).</value>
        [DataMember(Name = "buurtId", EmitDefaultValue = false)]
        public int BuurtId { get; set; }

        /// <summary>
        /// De naam van de buurt.
        /// </summary>
        /// <value>De naam van de buurt.</value>
        [DataMember(Name = "buurtnaam", EmitDefaultValue = false)]
        public string Buurtnaam { get; set; }

        /// <summary>
        /// De naam van de wijk.
        /// </summary>
        /// <value>De naam van de wijk.</value>
        [DataMember(Name = "wijknaam", EmitDefaultValue = false)]
        public string Wijknaam { get; set; }

        /// <summary>
        /// De naam van de gemeente.
        /// </summary>
        /// <value>De naam van de gemeente.</value>
        [DataMember(Name = "gemeentenaam", EmitDefaultValue = false)]
        public string Gemeentenaam { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CbsIndeling {\n");
            sb.Append("  BuurtId: ").Append(BuurtId).Append("\n");
            sb.Append("  Buurtnaam: ").Append(Buurtnaam).Append("\n");
            sb.Append("  Wijknaam: ").Append(Wijknaam).Append("\n");
            sb.Append("  Gemeentenaam: ").Append(Gemeentenaam).Append("\n");
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
            return this.Equals(input as CbsIndeling);
        }

        /// <summary>
        /// Returns true if CbsIndeling instances are equal
        /// </summary>
        /// <param name="input">Instance of CbsIndeling to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CbsIndeling input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.BuurtId == input.BuurtId ||
                    this.BuurtId.Equals(input.BuurtId)
                ) && 
                (
                    this.Buurtnaam == input.Buurtnaam ||
                    (this.Buurtnaam != null &&
                    this.Buurtnaam.Equals(input.Buurtnaam))
                ) && 
                (
                    this.Wijknaam == input.Wijknaam ||
                    (this.Wijknaam != null &&
                    this.Wijknaam.Equals(input.Wijknaam))
                ) && 
                (
                    this.Gemeentenaam == input.Gemeentenaam ||
                    (this.Gemeentenaam != null &&
                    this.Gemeentenaam.Equals(input.Gemeentenaam))
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
                hashCode = (hashCode * 59) + this.BuurtId.GetHashCode();
                if (this.Buurtnaam != null)
                {
                    hashCode = (hashCode * 59) + this.Buurtnaam.GetHashCode();
                }
                if (this.Wijknaam != null)
                {
                    hashCode = (hashCode * 59) + this.Wijknaam.GetHashCode();
                }
                if (this.Gemeentenaam != null)
                {
                    hashCode = (hashCode * 59) + this.Gemeentenaam.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
