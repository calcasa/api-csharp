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
    /// Taxatiedata
    /// </summary>
    [DataContract(Name = "Taxatiedata")]
    public partial class Taxatiedata : IEquatable<Taxatiedata>
    {

        /// <summary>
        /// De status van een taxatie (alleen van toepassing voor desktop taxaties). | Waarde | Omschrijving | | - -- | - -- | | &#x60;nietGecontroleerd&#x60; | Status is onbekend of niet van toepassing. | | &#x60;goedgekeurd&#x60; | De waardering is geaccepteerd door een taxateur. | | &#x60;afgekeurd&#x60; | De waardering is afgewezen door een taxateur. |   
        /// </summary>
        /// <value>De status van een taxatie (alleen van toepassing voor desktop taxaties). | Waarde | Omschrijving | | - -- | - -- | | &#x60;nietGecontroleerd&#x60; | Status is onbekend of niet van toepassing. | | &#x60;goedgekeurd&#x60; | De waardering is geaccepteerd door een taxateur. | | &#x60;afgekeurd&#x60; | De waardering is afgewezen door een taxateur. |   </value>
        [DataMember(Name = "status", EmitDefaultValue = true)]
        public Taxatiestatus? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Taxatiedata" /> class.
        /// </summary>
        /// <param name="taxatieorganisatie">De naam van de taxatieorganisatie..</param>
        /// <param name="status">De status van een taxatie (alleen van toepassing voor desktop taxaties). | Waarde | Omschrijving | | - -- | - -- | | &#x60;nietGecontroleerd&#x60; | Status is onbekend of niet van toepassing. | | &#x60;goedgekeurd&#x60; | De waardering is geaccepteerd door een taxateur. | | &#x60;afgekeurd&#x60; | De waardering is afgewezen door een taxateur. |   .</param>
        /// <param name="taxatiedatum">De datum/tijd waarop de waardering getaxeerd is, in UTC..</param>
        public Taxatiedata(string taxatieorganisatie = default(string), Taxatiestatus? status = default(Taxatiestatus?), DateTime taxatiedatum = default(DateTime))
        {
            this.Taxatieorganisatie = taxatieorganisatie;
            this.Status = status;
            this.Taxatiedatum = taxatiedatum;
        }

        /// <summary>
        /// De naam van de taxatieorganisatie.
        /// </summary>
        /// <value>De naam van de taxatieorganisatie.</value>
        [DataMember(Name = "taxatieorganisatie", EmitDefaultValue = false)]
        public string Taxatieorganisatie { get; set; }

        /// <summary>
        /// De datum/tijd waarop de waardering getaxeerd is, in UTC.
        /// </summary>
        /// <value>De datum/tijd waarop de waardering getaxeerd is, in UTC.</value>
        [DataMember(Name = "taxatiedatum", EmitDefaultValue = false)]
        public DateTime Taxatiedatum { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Taxatiedata {\n");
            sb.Append("  Taxatieorganisatie: ").Append(Taxatieorganisatie).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Taxatiedatum: ").Append(Taxatiedatum).Append("\n");
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
            return this.Equals(input as Taxatiedata);
        }

        /// <summary>
        /// Returns true if Taxatiedata instances are equal
        /// </summary>
        /// <param name="input">Instance of Taxatiedata to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Taxatiedata input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Taxatieorganisatie == input.Taxatieorganisatie ||
                    (this.Taxatieorganisatie != null &&
                    this.Taxatieorganisatie.Equals(input.Taxatieorganisatie))
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.Taxatiedatum == input.Taxatiedatum ||
                    (this.Taxatiedatum != null &&
                    this.Taxatiedatum.Equals(input.Taxatiedatum))
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
                if (this.Taxatieorganisatie != null)
                {
                    hashCode = (hashCode * 59) + this.Taxatieorganisatie.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Status.GetHashCode();
                if (this.Taxatiedatum != null)
                {
                    hashCode = (hashCode * 59) + this.Taxatiedatum.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
