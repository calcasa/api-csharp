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
    /// Omgevingsdata
    /// </summary>
    [DataContract(Name = "Omgevingsdata")]
    public partial class Omgevingsdata : IEquatable<Omgevingsdata>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Omgevingsdata" /> class.
        /// </summary>
        /// <param name="buurt">Statistieken op buurt-niveau..</param>
        /// <param name="wijk">Statistieken op wijk-niveau..</param>
        /// <param name="gemeente">Statistieken op gemeente-niveau..</param>
        /// <param name="provincie">Statistieken op provincie-niveau..</param>
        /// <param name="land">Statistieken op landelijk-niveau..</param>
        public Omgevingsdata(Gebiedsdata buurt = default(Gebiedsdata), Gebiedsdata wijk = default(Gebiedsdata), Gebiedsdata gemeente = default(Gebiedsdata), Gebiedsdata provincie = default(Gebiedsdata), Gebiedsdata land = default(Gebiedsdata))
        {
            this.Buurt = buurt;
            this.Wijk = wijk;
            this.Gemeente = gemeente;
            this.Provincie = provincie;
            this.Land = land;
        }

        /// <summary>
        /// Statistieken op buurt-niveau.
        /// </summary>
        /// <value>Statistieken op buurt-niveau.</value>
        [DataMember(Name = "buurt", EmitDefaultValue = true)]
        public Gebiedsdata Buurt { get; set; }

        /// <summary>
        /// Statistieken op wijk-niveau.
        /// </summary>
        /// <value>Statistieken op wijk-niveau.</value>
        [DataMember(Name = "wijk", EmitDefaultValue = true)]
        public Gebiedsdata Wijk { get; set; }

        /// <summary>
        /// Statistieken op gemeente-niveau.
        /// </summary>
        /// <value>Statistieken op gemeente-niveau.</value>
        [DataMember(Name = "gemeente", EmitDefaultValue = true)]
        public Gebiedsdata Gemeente { get; set; }

        /// <summary>
        /// Statistieken op provincie-niveau.
        /// </summary>
        /// <value>Statistieken op provincie-niveau.</value>
        [DataMember(Name = "provincie", EmitDefaultValue = true)]
        public Gebiedsdata Provincie { get; set; }

        /// <summary>
        /// Statistieken op landelijk-niveau.
        /// </summary>
        /// <value>Statistieken op landelijk-niveau.</value>
        [DataMember(Name = "land", EmitDefaultValue = true)]
        public Gebiedsdata Land { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Omgevingsdata {\n");
            sb.Append("  Buurt: ").Append(Buurt).Append("\n");
            sb.Append("  Wijk: ").Append(Wijk).Append("\n");
            sb.Append("  Gemeente: ").Append(Gemeente).Append("\n");
            sb.Append("  Provincie: ").Append(Provincie).Append("\n");
            sb.Append("  Land: ").Append(Land).Append("\n");
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
            return this.Equals(input as Omgevingsdata);
        }

        /// <summary>
        /// Returns true if Omgevingsdata instances are equal
        /// </summary>
        /// <param name="input">Instance of Omgevingsdata to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Omgevingsdata input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Buurt == input.Buurt ||
                    (this.Buurt != null &&
                    this.Buurt.Equals(input.Buurt))
                ) && 
                (
                    this.Wijk == input.Wijk ||
                    (this.Wijk != null &&
                    this.Wijk.Equals(input.Wijk))
                ) && 
                (
                    this.Gemeente == input.Gemeente ||
                    (this.Gemeente != null &&
                    this.Gemeente.Equals(input.Gemeente))
                ) && 
                (
                    this.Provincie == input.Provincie ||
                    (this.Provincie != null &&
                    this.Provincie.Equals(input.Provincie))
                ) && 
                (
                    this.Land == input.Land ||
                    (this.Land != null &&
                    this.Land.Equals(input.Land))
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
                if (this.Buurt != null)
                {
                    hashCode = (hashCode * 59) + this.Buurt.GetHashCode();
                }
                if (this.Wijk != null)
                {
                    hashCode = (hashCode * 59) + this.Wijk.GetHashCode();
                }
                if (this.Gemeente != null)
                {
                    hashCode = (hashCode * 59) + this.Gemeente.GetHashCode();
                }
                if (this.Provincie != null)
                {
                    hashCode = (hashCode * 59) + this.Provincie.GetHashCode();
                }
                if (this.Land != null)
                {
                    hashCode = (hashCode * 59) + this.Land.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
