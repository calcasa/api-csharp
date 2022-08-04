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
    /// Callback
    /// </summary>
    [DataContract(Name = "Callback")]
    public partial class Callback : IEquatable<Callback>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Callback" /> class.
        /// </summary>
        /// <param name="version">De API versie waarvoor deze callback aangeroepen wordt..</param>
        /// <param name="url">De URL van de callback. Bij het aanroepen zal de CallbackName hier achter geplaatst worden. Null of lege string om te verwijderen. English: when making the call, the CallbackName will be appended to this Url. Null or empty string to remove..</param>
        public Callback(string version = default(string), string url = default(string))
        {
            this._Version = version;
            this.Url = url;
        }

        /// <summary>
        /// De API versie waarvoor deze callback aangeroepen wordt.
        /// </summary>
        /// <value>De API versie waarvoor deze callback aangeroepen wordt.</value>
        [DataMember(Name = "version", EmitDefaultValue = false)]
        public string _Version { get; set; }

        /// <summary>
        /// De URL van de callback. Bij het aanroepen zal de CallbackName hier achter geplaatst worden. Null of lege string om te verwijderen. English: when making the call, the CallbackName will be appended to this Url. Null or empty string to remove.
        /// </summary>
        /// <value>De URL van de callback. Bij het aanroepen zal de CallbackName hier achter geplaatst worden. Null of lege string om te verwijderen. English: when making the call, the CallbackName will be appended to this Url. Null or empty string to remove.</value>
        [DataMember(Name = "url", EmitDefaultValue = false)]
        public string Url { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Callback {\n");
            sb.Append("  _Version: ").Append(_Version).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
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
            return this.Equals(input as Callback);
        }

        /// <summary>
        /// Returns true if Callback instances are equal
        /// </summary>
        /// <param name="input">Instance of Callback to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Callback input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this._Version == input._Version ||
                    (this._Version != null &&
                    this._Version.Equals(input._Version))
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
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
                if (this._Version != null)
                {
                    hashCode = (hashCode * 59) + this._Version.GetHashCode();
                }
                if (this.Url != null)
                {
                    hashCode = (hashCode * 59) + this.Url.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
