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
 * The version of the OpenAPI document: 1.1.7
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
    /// Informatie over het type fundering.
    /// </summary>
    [DataContract(Name = "Funderingdata_typering")]
    public partial class FunderingdataTypering : IEquatable<FunderingdataTypering>
    {

        /// <summary>
        /// Het type fundering.Funderingstypes. | Waarde | Omschrijving | | - -- | - -- | | &#x60;onbekendFunderingType&#x60; | Onbekend fundering-type | | &#x60;hout&#x60; | Hout. | | &#x60;houtAmsterdam&#x60; | Hout, Amsterdamse variant. | | &#x60;houtRotterdam&#x60; | Hout, Rotterdamse variant. | | &#x60;beton&#x60; | Beton. | | &#x60;nietOnderheid&#x60; | Niet onderheid. | | &#x60;nietOnderheidGemetseld&#x60; | Niet onderheid, gemetseld. | | &#x60;nietOnderheidStroken&#x60; | Niet onderheid, stroken. | | &#x60;nietOnderheidPlaat&#x60; | Niet onderheid, plaat. | | &#x60;nietOnderheidBetonplaat&#x60; | Niet onderheid, betonplaat. | | &#x60;nietOnderheidSlieten&#x60; | Niet onderheid, slieten. | | &#x60;houtOplanger&#x60; | Hout met oplanger. | | &#x60;betonVerzwaard&#x60; | Beton verzwaard. | | &#x60;gecombineerd&#x60; | Gecombineerd. | | &#x60;staal&#x60; | Stalen buispaal. | | &#x60;houtAmsterdamRotterdam&#x60; | Houten paal, Rotterdam/Amsterdam methode. | | &#x60;houtRotterdamSpaarboog&#x60; | Houten paal, Rotterdam methode met spaarboog. | | &#x60;houtAmsterdamSpaarboog&#x60; | Houten paal, Amsterdam methode met spaarboog. |   
        /// </summary>
        /// <value>Het type fundering.Funderingstypes. | Waarde | Omschrijving | | - -- | - -- | | &#x60;onbekendFunderingType&#x60; | Onbekend fundering-type | | &#x60;hout&#x60; | Hout. | | &#x60;houtAmsterdam&#x60; | Hout, Amsterdamse variant. | | &#x60;houtRotterdam&#x60; | Hout, Rotterdamse variant. | | &#x60;beton&#x60; | Beton. | | &#x60;nietOnderheid&#x60; | Niet onderheid. | | &#x60;nietOnderheidGemetseld&#x60; | Niet onderheid, gemetseld. | | &#x60;nietOnderheidStroken&#x60; | Niet onderheid, stroken. | | &#x60;nietOnderheidPlaat&#x60; | Niet onderheid, plaat. | | &#x60;nietOnderheidBetonplaat&#x60; | Niet onderheid, betonplaat. | | &#x60;nietOnderheidSlieten&#x60; | Niet onderheid, slieten. | | &#x60;houtOplanger&#x60; | Hout met oplanger. | | &#x60;betonVerzwaard&#x60; | Beton verzwaard. | | &#x60;gecombineerd&#x60; | Gecombineerd. | | &#x60;staal&#x60; | Stalen buispaal. | | &#x60;houtAmsterdamRotterdam&#x60; | Houten paal, Rotterdam/Amsterdam methode. | | &#x60;houtRotterdamSpaarboog&#x60; | Houten paal, Rotterdam methode met spaarboog. | | &#x60;houtAmsterdamSpaarboog&#x60; | Houten paal, Amsterdam methode met spaarboog. |   </value>
        [DataMember(Name = "type", EmitDefaultValue = true)]
        public FunderingType? Type { get; set; }

        /// <summary>
        /// De bron van het funderingstype.
        /// </summary>
        /// <value>De bron van het funderingstype.</value>
        [DataMember(Name = "bron", EmitDefaultValue = true)]
        public FunderingSoortBron? Bron { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="FunderingdataTypering" /> class.
        /// </summary>
        /// <param name="type">Het type fundering.Funderingstypes. | Waarde | Omschrijving | | - -- | - -- | | &#x60;onbekendFunderingType&#x60; | Onbekend fundering-type | | &#x60;hout&#x60; | Hout. | | &#x60;houtAmsterdam&#x60; | Hout, Amsterdamse variant. | | &#x60;houtRotterdam&#x60; | Hout, Rotterdamse variant. | | &#x60;beton&#x60; | Beton. | | &#x60;nietOnderheid&#x60; | Niet onderheid. | | &#x60;nietOnderheidGemetseld&#x60; | Niet onderheid, gemetseld. | | &#x60;nietOnderheidStroken&#x60; | Niet onderheid, stroken. | | &#x60;nietOnderheidPlaat&#x60; | Niet onderheid, plaat. | | &#x60;nietOnderheidBetonplaat&#x60; | Niet onderheid, betonplaat. | | &#x60;nietOnderheidSlieten&#x60; | Niet onderheid, slieten. | | &#x60;houtOplanger&#x60; | Hout met oplanger. | | &#x60;betonVerzwaard&#x60; | Beton verzwaard. | | &#x60;gecombineerd&#x60; | Gecombineerd. | | &#x60;staal&#x60; | Stalen buispaal. | | &#x60;houtAmsterdamRotterdam&#x60; | Houten paal, Rotterdam/Amsterdam methode. | | &#x60;houtRotterdamSpaarboog&#x60; | Houten paal, Rotterdam methode met spaarboog. | | &#x60;houtAmsterdamSpaarboog&#x60; | Houten paal, Amsterdam methode met spaarboog. |   .</param>
        /// <param name="bron">De bron van het funderingstype..</param>
        /// <param name="omschrijving">De omschrijving van het funderingstype..</param>
        public FunderingdataTypering(FunderingType? type = default(FunderingType?), FunderingSoortBron? bron = default(FunderingSoortBron?), string omschrijving = default(string))
        {
            this.Type = type;
            this.Bron = bron;
            this.Omschrijving = omschrijving;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// De omschrijving van het funderingstype.
        /// </summary>
        /// <value>De omschrijving van het funderingstype.</value>
        [DataMember(Name = "omschrijving", EmitDefaultValue = false)]
        public string Omschrijving { get; set; }

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
            sb.Append("class FunderingdataTypering {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Bron: ").Append(Bron).Append("\n");
            sb.Append("  Omschrijving: ").Append(Omschrijving).Append("\n");
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
            return this.Equals(input as FunderingdataTypering);
        }

        /// <summary>
        /// Returns true if FunderingdataTypering instances are equal
        /// </summary>
        /// <param name="input">Instance of FunderingdataTypering to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FunderingdataTypering input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.Bron == input.Bron ||
                    this.Bron.Equals(input.Bron)
                ) && 
                (
                    this.Omschrijving == input.Omschrijving ||
                    (this.Omschrijving != null &&
                    this.Omschrijving.Equals(input.Omschrijving))
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
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
                hashCode = (hashCode * 59) + this.Bron.GetHashCode();
                if (this.Omschrijving != null)
                {
                    hashCode = (hashCode * 59) + this.Omschrijving.GetHashCode();
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
