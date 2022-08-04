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
    /// Bodemdata
    /// </summary>
    [DataContract(Name = "Bodemdata")]
    public partial class Bodemdata : IEquatable<Bodemdata>
    {

        /// <summary>
        /// De staat van de bodem, geeft aan of en in welke mate er sprake is van vervuiling. | Waarde | Omschrijving | | - -- | - -- | | &#x60;geenData&#x60; | Er is geen data beschikbaar over deze bodem. | | &#x60;onbekend&#x60; | De status van deze bodem is niet bekend. | | &#x60;nietVervuild&#x60; | De bodem is niet vervuild. | | &#x60;nietErnstig&#x60; | De bodem is niet ernstig vervuild. | | &#x60;potentieelErnstig&#x60; | De bodem is potentieel ernstig veruild. | | &#x60;ernstig&#x60; | De bodem is ernstig veruild. |   
        /// </summary>
        /// <value>De staat van de bodem, geeft aan of en in welke mate er sprake is van vervuiling. | Waarde | Omschrijving | | - -- | - -- | | &#x60;geenData&#x60; | Er is geen data beschikbaar over deze bodem. | | &#x60;onbekend&#x60; | De status van deze bodem is niet bekend. | | &#x60;nietVervuild&#x60; | De bodem is niet vervuild. | | &#x60;nietErnstig&#x60; | De bodem is niet ernstig vervuild. | | &#x60;potentieelErnstig&#x60; | De bodem is potentieel ernstig veruild. | | &#x60;ernstig&#x60; | De bodem is ernstig veruild. |   </value>
        [DataMember(Name = "status", EmitDefaultValue = true)]
        public BodemStatusType? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Bodemdata" /> class.
        /// </summary>
        /// <param name="status">De staat van de bodem, geeft aan of en in welke mate er sprake is van vervuiling. | Waarde | Omschrijving | | - -- | - -- | | &#x60;geenData&#x60; | Er is geen data beschikbaar over deze bodem. | | &#x60;onbekend&#x60; | De status van deze bodem is niet bekend. | | &#x60;nietVervuild&#x60; | De bodem is niet vervuild. | | &#x60;nietErnstig&#x60; | De bodem is niet ernstig vervuild. | | &#x60;potentieelErnstig&#x60; | De bodem is potentieel ernstig veruild. | | &#x60;ernstig&#x60; | De bodem is ernstig veruild. |   .</param>
        /// <param name="datumLaatsteOnderzoek">De datum van het laatste bodemonderzoek..</param>
        /// <param name="url">De url met informatie over het bodemonderzoek..</param>
        public Bodemdata(BodemStatusType? status = default(BodemStatusType?), DateTime? datumLaatsteOnderzoek = default(DateTime?), string url = default(string))
        {
            this.Status = status;
            this.DatumLaatsteOnderzoek = datumLaatsteOnderzoek;
            this.Url = url;
        }

        /// <summary>
        /// De datum van het laatste bodemonderzoek.
        /// </summary>
        /// <value>De datum van het laatste bodemonderzoek.</value>
        [DataMember(Name = "datumLaatsteOnderzoek", EmitDefaultValue = true)]
        public DateTime? DatumLaatsteOnderzoek { get; set; }

        /// <summary>
        /// De url met informatie over het bodemonderzoek.
        /// </summary>
        /// <value>De url met informatie over het bodemonderzoek.</value>
        [DataMember(Name = "url", EmitDefaultValue = true)]
        public string Url { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Bodemdata {\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  DatumLaatsteOnderzoek: ").Append(DatumLaatsteOnderzoek).Append("\n");
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
            return this.Equals(input as Bodemdata);
        }

        /// <summary>
        /// Returns true if Bodemdata instances are equal
        /// </summary>
        /// <param name="input">Instance of Bodemdata to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Bodemdata input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.DatumLaatsteOnderzoek == input.DatumLaatsteOnderzoek ||
                    (this.DatumLaatsteOnderzoek != null &&
                    this.DatumLaatsteOnderzoek.Equals(input.DatumLaatsteOnderzoek))
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
                hashCode = (hashCode * 59) + this.Status.GetHashCode();
                if (this.DatumLaatsteOnderzoek != null)
                {
                    hashCode = (hashCode * 59) + this.DatumLaatsteOnderzoek.GetHashCode();
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
