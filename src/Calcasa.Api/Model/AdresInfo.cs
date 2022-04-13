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
 * The version of the OpenAPI document: 1.1.5
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
    /// AdresInfo
    /// </summary>
    [DataContract(Name = "AdresInfo")]
    public partial class AdresInfo : IEquatable<AdresInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdresInfo" /> class.
        /// </summary>
        /// <param name="bagNummeraanduidingId">Het BAG nummeraanduiding Id van het adres.  Normaal aangevuld met nullen tot 16 karakters..</param>
        /// <param name="adres">Het adres object..</param>
        /// <param name="notities">Informatie over de adres zoekopdracht en eventueel gecorrigeerde velden..</param>
        /// <param name="adresGevonden">Geeft aan of er een correct adres is gevonden voor deze zoekopdracht..</param>
        public AdresInfo(long bagNummeraanduidingId = default(long), Adres adres = default(Adres), Notities notities = default(Notities), bool? adresGevonden = default(bool?))
        {
            this.BagNummeraanduidingId = bagNummeraanduidingId;
            this.Adres = adres;
            this.Notities = notities;
            this.AdresGevonden = adresGevonden;
        }

        /// <summary>
        /// Het BAG nummeraanduiding Id van het adres.  Normaal aangevuld met nullen tot 16 karakters.
        /// </summary>
        /// <value>Het BAG nummeraanduiding Id van het adres.  Normaal aangevuld met nullen tot 16 karakters.</value>
        [DataMember(Name = "bagNummeraanduidingId", EmitDefaultValue = false)]
        public long BagNummeraanduidingId { get; set; }

        /// <summary>
        /// Het adres object.
        /// </summary>
        /// <value>Het adres object.</value>
        [DataMember(Name = "adres", EmitDefaultValue = true)]
        public Adres Adres { get; set; }

        /// <summary>
        /// Informatie over de adres zoekopdracht en eventueel gecorrigeerde velden.
        /// </summary>
        /// <value>Informatie over de adres zoekopdracht en eventueel gecorrigeerde velden.</value>
        [DataMember(Name = "notities", EmitDefaultValue = true)]
        public Notities Notities { get; set; }

        /// <summary>
        /// Geeft aan of er een correct adres is gevonden voor deze zoekopdracht.
        /// </summary>
        /// <value>Geeft aan of er een correct adres is gevonden voor deze zoekopdracht.</value>
        [DataMember(Name = "adresGevonden", EmitDefaultValue = true)]
        public bool? AdresGevonden { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AdresInfo {\n");
            sb.Append("  BagNummeraanduidingId: ").Append(BagNummeraanduidingId).Append("\n");
            sb.Append("  Adres: ").Append(Adres).Append("\n");
            sb.Append("  Notities: ").Append(Notities).Append("\n");
            sb.Append("  AdresGevonden: ").Append(AdresGevonden).Append("\n");
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
            return this.Equals(input as AdresInfo);
        }

        /// <summary>
        /// Returns true if AdresInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of AdresInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AdresInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.BagNummeraanduidingId == input.BagNummeraanduidingId ||
                    this.BagNummeraanduidingId.Equals(input.BagNummeraanduidingId)
                ) && 
                (
                    this.Adres == input.Adres ||
                    (this.Adres != null &&
                    this.Adres.Equals(input.Adres))
                ) && 
                (
                    this.Notities == input.Notities ||
                    (this.Notities != null &&
                    this.Notities.Equals(input.Notities))
                ) && 
                (
                    this.AdresGevonden == input.AdresGevonden ||
                    (this.AdresGevonden != null &&
                    this.AdresGevonden.Equals(input.AdresGevonden))
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
                hashCode = (hashCode * 59) + this.BagNummeraanduidingId.GetHashCode();
                if (this.Adres != null)
                {
                    hashCode = (hashCode * 59) + this.Adres.GetHashCode();
                }
                if (this.Notities != null)
                {
                    hashCode = (hashCode * 59) + this.Notities.GetHashCode();
                }
                if (this.AdresGevonden != null)
                {
                    hashCode = (hashCode * 59) + this.AdresGevonden.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
