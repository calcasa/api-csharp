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
    /// CallbackInschrijving
    /// </summary>
    [DataContract(Name = "CallbackInschrijving")]
    public partial class CallbackInschrijving : IEquatable<CallbackInschrijving>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CallbackInschrijving" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CallbackInschrijving() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CallbackInschrijving" /> class.
        /// </summary>
        /// <param name="bagNummeraanduidingId">Verplicht.  Het BAG (Basisregistratie Adressen en Gebouwen) nummeraanduiding id. (required).</param>
        /// <param name="geldigTot">Verplicht.  De datum tot wanneer deze inschrijving effect moet hebben. Als deze inschrijving verloopt wordt deze automatisch opgeruimt. De maximale termijn is afhankelijk van de gebruikte client. (required).</param>
        /// <param name="externeReferentie">Een vrij veld dat terug komt met de callback payload om callbacks aan de juiste callback inschrijving te koppelen..</param>
        public CallbackInschrijving(long bagNummeraanduidingId = default(long), DateTime geldigTot = default(DateTime), string externeReferentie = default(string))
        {
            this.BagNummeraanduidingId = bagNummeraanduidingId;
            this.GeldigTot = geldigTot;
            this.ExterneReferentie = externeReferentie;
        }

        /// <summary>
        /// Verplicht.  Het BAG (Basisregistratie Adressen en Gebouwen) nummeraanduiding id.
        /// </summary>
        /// <value>Verplicht.  Het BAG (Basisregistratie Adressen en Gebouwen) nummeraanduiding id.</value>
        [DataMember(Name = "bagNummeraanduidingId", IsRequired = true, EmitDefaultValue = false)]
        public long BagNummeraanduidingId { get; set; }

        /// <summary>
        /// Verplicht.  De datum tot wanneer deze inschrijving effect moet hebben. Als deze inschrijving verloopt wordt deze automatisch opgeruimt. De maximale termijn is afhankelijk van de gebruikte client.
        /// </summary>
        /// <value>Verplicht.  De datum tot wanneer deze inschrijving effect moet hebben. Als deze inschrijving verloopt wordt deze automatisch opgeruimt. De maximale termijn is afhankelijk van de gebruikte client.</value>
        [DataMember(Name = "geldigTot", IsRequired = true, EmitDefaultValue = false)]
        public DateTime GeldigTot { get; set; }

        /// <summary>
        /// Een vrij veld dat terug komt met de callback payload om callbacks aan de juiste callback inschrijving te koppelen.
        /// </summary>
        /// <value>Een vrij veld dat terug komt met de callback payload om callbacks aan de juiste callback inschrijving te koppelen.</value>
        [DataMember(Name = "externeReferentie", EmitDefaultValue = true)]
        public string ExterneReferentie { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CallbackInschrijving {\n");
            sb.Append("  BagNummeraanduidingId: ").Append(BagNummeraanduidingId).Append("\n");
            sb.Append("  GeldigTot: ").Append(GeldigTot).Append("\n");
            sb.Append("  ExterneReferentie: ").Append(ExterneReferentie).Append("\n");
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
            return this.Equals(input as CallbackInschrijving);
        }

        /// <summary>
        /// Returns true if CallbackInschrijving instances are equal
        /// </summary>
        /// <param name="input">Instance of CallbackInschrijving to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CallbackInschrijving input)
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
                    this.GeldigTot == input.GeldigTot ||
                    (this.GeldigTot != null &&
                    this.GeldigTot.Equals(input.GeldigTot))
                ) && 
                (
                    this.ExterneReferentie == input.ExterneReferentie ||
                    (this.ExterneReferentie != null &&
                    this.ExterneReferentie.Equals(input.ExterneReferentie))
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
                if (this.GeldigTot != null)
                {
                    hashCode = (hashCode * 59) + this.GeldigTot.GetHashCode();
                }
                if (this.ExterneReferentie != null)
                {
                    hashCode = (hashCode * 59) + this.ExterneReferentie.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
