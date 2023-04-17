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
 * The version of the OpenAPI document: 1.2.1
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
    /// Statistieken op gemeente-niveau.
    /// </summary>
    [DataContract(Name = "Omgevingsdata_gemeente")]
    public partial class OmgevingsdataGemeente : IEquatable<OmgevingsdataGemeente>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OmgevingsdataGemeente" /> class.
        /// </summary>
        /// <param name="naam">naam.</param>
        /// <param name="gemiddeldePrijsEengezinswoningen">In hele euros..</param>
        /// <param name="gemiddeldePrijsMeergezinswoningen">In hele euros..</param>
        /// <param name="gemiddeldeVierkantemeterPrijsEengezinswoningen">In hele euros per vierkante meter..</param>
        /// <param name="gemiddeldeVierkantemeterPrijsMeergezinswoningen">In hele euros per vierkante meter..</param>
        /// <param name="prijsveranderingAfgelopenJaar">In hele procenten..</param>
        /// <param name="prijsveranderingAfgelopen3Jaar">In hele procenten..</param>
        /// <param name="prijsveranderingAfgelopen5Jaar">In hele procenten..</param>
        /// <param name="prijsveranderingAfgelopen10Jaar">In hele procenten..</param>
        public OmgevingsdataGemeente(string naam = default(string), int? gemiddeldePrijsEengezinswoningen = default(int?), int? gemiddeldePrijsMeergezinswoningen = default(int?), int? gemiddeldeVierkantemeterPrijsEengezinswoningen = default(int?), int? gemiddeldeVierkantemeterPrijsMeergezinswoningen = default(int?), int? prijsveranderingAfgelopenJaar = default(int?), int? prijsveranderingAfgelopen3Jaar = default(int?), int? prijsveranderingAfgelopen5Jaar = default(int?), int? prijsveranderingAfgelopen10Jaar = default(int?))
        {
            this.Naam = naam;
            this.GemiddeldePrijsEengezinswoningen = gemiddeldePrijsEengezinswoningen;
            this.GemiddeldePrijsMeergezinswoningen = gemiddeldePrijsMeergezinswoningen;
            this.GemiddeldeVierkantemeterPrijsEengezinswoningen = gemiddeldeVierkantemeterPrijsEengezinswoningen;
            this.GemiddeldeVierkantemeterPrijsMeergezinswoningen = gemiddeldeVierkantemeterPrijsMeergezinswoningen;
            this.PrijsveranderingAfgelopenJaar = prijsveranderingAfgelopenJaar;
            this.PrijsveranderingAfgelopen3Jaar = prijsveranderingAfgelopen3Jaar;
            this.PrijsveranderingAfgelopen5Jaar = prijsveranderingAfgelopen5Jaar;
            this.PrijsveranderingAfgelopen10Jaar = prijsveranderingAfgelopen10Jaar;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Gets or Sets Naam
        /// </summary>
        [DataMember(Name = "naam", EmitDefaultValue = false)]
        public string Naam { get; set; }

        /// <summary>
        /// In hele euros.
        /// </summary>
        /// <value>In hele euros.</value>
        [DataMember(Name = "gemiddeldePrijsEengezinswoningen", EmitDefaultValue = true)]
        public int? GemiddeldePrijsEengezinswoningen { get; set; }

        /// <summary>
        /// In hele euros.
        /// </summary>
        /// <value>In hele euros.</value>
        [DataMember(Name = "gemiddeldePrijsMeergezinswoningen", EmitDefaultValue = true)]
        public int? GemiddeldePrijsMeergezinswoningen { get; set; }

        /// <summary>
        /// In hele euros per vierkante meter.
        /// </summary>
        /// <value>In hele euros per vierkante meter.</value>
        [DataMember(Name = "gemiddeldeVierkantemeterPrijsEengezinswoningen", EmitDefaultValue = true)]
        public int? GemiddeldeVierkantemeterPrijsEengezinswoningen { get; set; }

        /// <summary>
        /// In hele euros per vierkante meter.
        /// </summary>
        /// <value>In hele euros per vierkante meter.</value>
        [DataMember(Name = "gemiddeldeVierkantemeterPrijsMeergezinswoningen", EmitDefaultValue = true)]
        public int? GemiddeldeVierkantemeterPrijsMeergezinswoningen { get; set; }

        /// <summary>
        /// In hele procenten.
        /// </summary>
        /// <value>In hele procenten.</value>
        [DataMember(Name = "prijsveranderingAfgelopenJaar", EmitDefaultValue = true)]
        public int? PrijsveranderingAfgelopenJaar { get; set; }

        /// <summary>
        /// In hele procenten.
        /// </summary>
        /// <value>In hele procenten.</value>
        [DataMember(Name = "prijsveranderingAfgelopen3Jaar", EmitDefaultValue = true)]
        public int? PrijsveranderingAfgelopen3Jaar { get; set; }

        /// <summary>
        /// In hele procenten.
        /// </summary>
        /// <value>In hele procenten.</value>
        [DataMember(Name = "prijsveranderingAfgelopen5Jaar", EmitDefaultValue = true)]
        public int? PrijsveranderingAfgelopen5Jaar { get; set; }

        /// <summary>
        /// In hele procenten.
        /// </summary>
        /// <value>In hele procenten.</value>
        [DataMember(Name = "prijsveranderingAfgelopen10Jaar", EmitDefaultValue = true)]
        public int? PrijsveranderingAfgelopen10Jaar { get; set; }

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
            sb.Append("class OmgevingsdataGemeente {\n");
            sb.Append("  Naam: ").Append(Naam).Append("\n");
            sb.Append("  GemiddeldePrijsEengezinswoningen: ").Append(GemiddeldePrijsEengezinswoningen).Append("\n");
            sb.Append("  GemiddeldePrijsMeergezinswoningen: ").Append(GemiddeldePrijsMeergezinswoningen).Append("\n");
            sb.Append("  GemiddeldeVierkantemeterPrijsEengezinswoningen: ").Append(GemiddeldeVierkantemeterPrijsEengezinswoningen).Append("\n");
            sb.Append("  GemiddeldeVierkantemeterPrijsMeergezinswoningen: ").Append(GemiddeldeVierkantemeterPrijsMeergezinswoningen).Append("\n");
            sb.Append("  PrijsveranderingAfgelopenJaar: ").Append(PrijsveranderingAfgelopenJaar).Append("\n");
            sb.Append("  PrijsveranderingAfgelopen3Jaar: ").Append(PrijsveranderingAfgelopen3Jaar).Append("\n");
            sb.Append("  PrijsveranderingAfgelopen5Jaar: ").Append(PrijsveranderingAfgelopen5Jaar).Append("\n");
            sb.Append("  PrijsveranderingAfgelopen10Jaar: ").Append(PrijsveranderingAfgelopen10Jaar).Append("\n");
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
            return this.Equals(input as OmgevingsdataGemeente);
        }

        /// <summary>
        /// Returns true if OmgevingsdataGemeente instances are equal
        /// </summary>
        /// <param name="input">Instance of OmgevingsdataGemeente to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OmgevingsdataGemeente input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Naam == input.Naam ||
                    (this.Naam != null &&
                    this.Naam.Equals(input.Naam))
                ) && 
                (
                    this.GemiddeldePrijsEengezinswoningen == input.GemiddeldePrijsEengezinswoningen ||
                    (this.GemiddeldePrijsEengezinswoningen != null &&
                    this.GemiddeldePrijsEengezinswoningen.Equals(input.GemiddeldePrijsEengezinswoningen))
                ) && 
                (
                    this.GemiddeldePrijsMeergezinswoningen == input.GemiddeldePrijsMeergezinswoningen ||
                    (this.GemiddeldePrijsMeergezinswoningen != null &&
                    this.GemiddeldePrijsMeergezinswoningen.Equals(input.GemiddeldePrijsMeergezinswoningen))
                ) && 
                (
                    this.GemiddeldeVierkantemeterPrijsEengezinswoningen == input.GemiddeldeVierkantemeterPrijsEengezinswoningen ||
                    (this.GemiddeldeVierkantemeterPrijsEengezinswoningen != null &&
                    this.GemiddeldeVierkantemeterPrijsEengezinswoningen.Equals(input.GemiddeldeVierkantemeterPrijsEengezinswoningen))
                ) && 
                (
                    this.GemiddeldeVierkantemeterPrijsMeergezinswoningen == input.GemiddeldeVierkantemeterPrijsMeergezinswoningen ||
                    (this.GemiddeldeVierkantemeterPrijsMeergezinswoningen != null &&
                    this.GemiddeldeVierkantemeterPrijsMeergezinswoningen.Equals(input.GemiddeldeVierkantemeterPrijsMeergezinswoningen))
                ) && 
                (
                    this.PrijsveranderingAfgelopenJaar == input.PrijsveranderingAfgelopenJaar ||
                    (this.PrijsveranderingAfgelopenJaar != null &&
                    this.PrijsveranderingAfgelopenJaar.Equals(input.PrijsveranderingAfgelopenJaar))
                ) && 
                (
                    this.PrijsveranderingAfgelopen3Jaar == input.PrijsveranderingAfgelopen3Jaar ||
                    (this.PrijsveranderingAfgelopen3Jaar != null &&
                    this.PrijsveranderingAfgelopen3Jaar.Equals(input.PrijsveranderingAfgelopen3Jaar))
                ) && 
                (
                    this.PrijsveranderingAfgelopen5Jaar == input.PrijsveranderingAfgelopen5Jaar ||
                    (this.PrijsveranderingAfgelopen5Jaar != null &&
                    this.PrijsveranderingAfgelopen5Jaar.Equals(input.PrijsveranderingAfgelopen5Jaar))
                ) && 
                (
                    this.PrijsveranderingAfgelopen10Jaar == input.PrijsveranderingAfgelopen10Jaar ||
                    (this.PrijsveranderingAfgelopen10Jaar != null &&
                    this.PrijsveranderingAfgelopen10Jaar.Equals(input.PrijsveranderingAfgelopen10Jaar))
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
                if (this.Naam != null)
                {
                    hashCode = (hashCode * 59) + this.Naam.GetHashCode();
                }
                if (this.GemiddeldePrijsEengezinswoningen != null)
                {
                    hashCode = (hashCode * 59) + this.GemiddeldePrijsEengezinswoningen.GetHashCode();
                }
                if (this.GemiddeldePrijsMeergezinswoningen != null)
                {
                    hashCode = (hashCode * 59) + this.GemiddeldePrijsMeergezinswoningen.GetHashCode();
                }
                if (this.GemiddeldeVierkantemeterPrijsEengezinswoningen != null)
                {
                    hashCode = (hashCode * 59) + this.GemiddeldeVierkantemeterPrijsEengezinswoningen.GetHashCode();
                }
                if (this.GemiddeldeVierkantemeterPrijsMeergezinswoningen != null)
                {
                    hashCode = (hashCode * 59) + this.GemiddeldeVierkantemeterPrijsMeergezinswoningen.GetHashCode();
                }
                if (this.PrijsveranderingAfgelopenJaar != null)
                {
                    hashCode = (hashCode * 59) + this.PrijsveranderingAfgelopenJaar.GetHashCode();
                }
                if (this.PrijsveranderingAfgelopen3Jaar != null)
                {
                    hashCode = (hashCode * 59) + this.PrijsveranderingAfgelopen3Jaar.GetHashCode();
                }
                if (this.PrijsveranderingAfgelopen5Jaar != null)
                {
                    hashCode = (hashCode * 59) + this.PrijsveranderingAfgelopen5Jaar.GetHashCode();
                }
                if (this.PrijsveranderingAfgelopen10Jaar != null)
                {
                    hashCode = (hashCode * 59) + this.PrijsveranderingAfgelopen10Jaar.GetHashCode();
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
