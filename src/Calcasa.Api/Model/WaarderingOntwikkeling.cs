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
    /// WaarderingOntwikkeling
    /// </summary>
    [DataContract(Name = "WaarderingOntwikkeling")]
    public partial class WaarderingOntwikkeling : IEquatable<WaarderingOntwikkeling>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WaarderingOntwikkeling" /> class.
        /// </summary>
        /// <param name="id">Id van de waardering of tracking Id..</param>
        /// <param name="objectPrijsOntwikkeling">De prijsontwikkeling van het gewaardeerde object..</param>
        /// <param name="objectPrijsOntwikkelingPerVierkantemeter">De prijsontwikkeling van het gewaardeerde object per vierkantemeter..</param>
        /// <param name="buurtPrijsOntwikkeling">De prijsontwikkeling van de buurt van het gewaardeerde object..</param>
        /// <param name="buurtPrijsOntwikkelingPerVierkantemeter">De prijsontwikkeling van de buurt van het gewaardeerde object per vierkantemeter..</param>
        /// <param name="wijkPrijsOntwikkeling">De prijsontwikkeling van de wijk van het gewaardeerde object..</param>
        /// <param name="wijkPrijsOntwikkelingPerVierkantemeter">De prijsontwikkeling van de wijk van het gewaardeerde object per vierkantemeter..</param>
        /// <param name="gemeentePrijsOntwikkeling">De prijsontwikkeling van de gemeente van het gewaardeerde object..</param>
        /// <param name="gemeentePrijsOntwikkelingPerVierkantemeter">De prijsontwikkeling van de gemeente van het gewaardeerde object per vierkantemeter..</param>
        public WaarderingOntwikkeling(Guid id = default(Guid), Collection<WaarderingOntwikkelingKwartaal> objectPrijsOntwikkeling = default(Collection<WaarderingOntwikkelingKwartaal>), Collection<WaarderingOntwikkelingKwartaal> objectPrijsOntwikkelingPerVierkantemeter = default(Collection<WaarderingOntwikkelingKwartaal>), Collection<WaarderingOntwikkelingKwartaal> buurtPrijsOntwikkeling = default(Collection<WaarderingOntwikkelingKwartaal>), Collection<WaarderingOntwikkelingKwartaal> buurtPrijsOntwikkelingPerVierkantemeter = default(Collection<WaarderingOntwikkelingKwartaal>), Collection<WaarderingOntwikkelingKwartaal> wijkPrijsOntwikkeling = default(Collection<WaarderingOntwikkelingKwartaal>), Collection<WaarderingOntwikkelingKwartaal> wijkPrijsOntwikkelingPerVierkantemeter = default(Collection<WaarderingOntwikkelingKwartaal>), Collection<WaarderingOntwikkelingKwartaal> gemeentePrijsOntwikkeling = default(Collection<WaarderingOntwikkelingKwartaal>), Collection<WaarderingOntwikkelingKwartaal> gemeentePrijsOntwikkelingPerVierkantemeter = default(Collection<WaarderingOntwikkelingKwartaal>))
        {
            this.Id = id;
            this.ObjectPrijsOntwikkeling = objectPrijsOntwikkeling;
            this.ObjectPrijsOntwikkelingPerVierkantemeter = objectPrijsOntwikkelingPerVierkantemeter;
            this.BuurtPrijsOntwikkeling = buurtPrijsOntwikkeling;
            this.BuurtPrijsOntwikkelingPerVierkantemeter = buurtPrijsOntwikkelingPerVierkantemeter;
            this.WijkPrijsOntwikkeling = wijkPrijsOntwikkeling;
            this.WijkPrijsOntwikkelingPerVierkantemeter = wijkPrijsOntwikkelingPerVierkantemeter;
            this.GemeentePrijsOntwikkeling = gemeentePrijsOntwikkeling;
            this.GemeentePrijsOntwikkelingPerVierkantemeter = gemeentePrijsOntwikkelingPerVierkantemeter;
        }

        /// <summary>
        /// Id van de waardering of tracking Id.
        /// </summary>
        /// <value>Id van de waardering of tracking Id.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public Guid Id { get; set; }

        /// <summary>
        /// De prijsontwikkeling van het gewaardeerde object.
        /// </summary>
        /// <value>De prijsontwikkeling van het gewaardeerde object.</value>
        [DataMember(Name = "objectPrijsOntwikkeling", EmitDefaultValue = false)]
        public Collection<WaarderingOntwikkelingKwartaal> ObjectPrijsOntwikkeling { get; set; }

        /// <summary>
        /// De prijsontwikkeling van het gewaardeerde object per vierkantemeter.
        /// </summary>
        /// <value>De prijsontwikkeling van het gewaardeerde object per vierkantemeter.</value>
        [DataMember(Name = "objectPrijsOntwikkelingPerVierkantemeter", EmitDefaultValue = false)]
        public Collection<WaarderingOntwikkelingKwartaal> ObjectPrijsOntwikkelingPerVierkantemeter { get; set; }

        /// <summary>
        /// De prijsontwikkeling van de buurt van het gewaardeerde object.
        /// </summary>
        /// <value>De prijsontwikkeling van de buurt van het gewaardeerde object.</value>
        [DataMember(Name = "buurtPrijsOntwikkeling", EmitDefaultValue = false)]
        public Collection<WaarderingOntwikkelingKwartaal> BuurtPrijsOntwikkeling { get; set; }

        /// <summary>
        /// De prijsontwikkeling van de buurt van het gewaardeerde object per vierkantemeter.
        /// </summary>
        /// <value>De prijsontwikkeling van de buurt van het gewaardeerde object per vierkantemeter.</value>
        [DataMember(Name = "buurtPrijsOntwikkelingPerVierkantemeter", EmitDefaultValue = false)]
        public Collection<WaarderingOntwikkelingKwartaal> BuurtPrijsOntwikkelingPerVierkantemeter { get; set; }

        /// <summary>
        /// De prijsontwikkeling van de wijk van het gewaardeerde object.
        /// </summary>
        /// <value>De prijsontwikkeling van de wijk van het gewaardeerde object.</value>
        [DataMember(Name = "wijkPrijsOntwikkeling", EmitDefaultValue = false)]
        public Collection<WaarderingOntwikkelingKwartaal> WijkPrijsOntwikkeling { get; set; }

        /// <summary>
        /// De prijsontwikkeling van de wijk van het gewaardeerde object per vierkantemeter.
        /// </summary>
        /// <value>De prijsontwikkeling van de wijk van het gewaardeerde object per vierkantemeter.</value>
        [DataMember(Name = "wijkPrijsOntwikkelingPerVierkantemeter", EmitDefaultValue = false)]
        public Collection<WaarderingOntwikkelingKwartaal> WijkPrijsOntwikkelingPerVierkantemeter { get; set; }

        /// <summary>
        /// De prijsontwikkeling van de gemeente van het gewaardeerde object.
        /// </summary>
        /// <value>De prijsontwikkeling van de gemeente van het gewaardeerde object.</value>
        [DataMember(Name = "gemeentePrijsOntwikkeling", EmitDefaultValue = false)]
        public Collection<WaarderingOntwikkelingKwartaal> GemeentePrijsOntwikkeling { get; set; }

        /// <summary>
        /// De prijsontwikkeling van de gemeente van het gewaardeerde object per vierkantemeter.
        /// </summary>
        /// <value>De prijsontwikkeling van de gemeente van het gewaardeerde object per vierkantemeter.</value>
        [DataMember(Name = "gemeentePrijsOntwikkelingPerVierkantemeter", EmitDefaultValue = false)]
        public Collection<WaarderingOntwikkelingKwartaal> GemeentePrijsOntwikkelingPerVierkantemeter { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WaarderingOntwikkeling {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ObjectPrijsOntwikkeling: ").Append(ObjectPrijsOntwikkeling).Append("\n");
            sb.Append("  ObjectPrijsOntwikkelingPerVierkantemeter: ").Append(ObjectPrijsOntwikkelingPerVierkantemeter).Append("\n");
            sb.Append("  BuurtPrijsOntwikkeling: ").Append(BuurtPrijsOntwikkeling).Append("\n");
            sb.Append("  BuurtPrijsOntwikkelingPerVierkantemeter: ").Append(BuurtPrijsOntwikkelingPerVierkantemeter).Append("\n");
            sb.Append("  WijkPrijsOntwikkeling: ").Append(WijkPrijsOntwikkeling).Append("\n");
            sb.Append("  WijkPrijsOntwikkelingPerVierkantemeter: ").Append(WijkPrijsOntwikkelingPerVierkantemeter).Append("\n");
            sb.Append("  GemeentePrijsOntwikkeling: ").Append(GemeentePrijsOntwikkeling).Append("\n");
            sb.Append("  GemeentePrijsOntwikkelingPerVierkantemeter: ").Append(GemeentePrijsOntwikkelingPerVierkantemeter).Append("\n");
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
            return this.Equals(input as WaarderingOntwikkeling);
        }

        /// <summary>
        /// Returns true if WaarderingOntwikkeling instances are equal
        /// </summary>
        /// <param name="input">Instance of WaarderingOntwikkeling to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WaarderingOntwikkeling input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.ObjectPrijsOntwikkeling == input.ObjectPrijsOntwikkeling ||
                    this.ObjectPrijsOntwikkeling != null &&
                    input.ObjectPrijsOntwikkeling != null &&
                    this.ObjectPrijsOntwikkeling.SequenceEqual(input.ObjectPrijsOntwikkeling)
                ) && 
                (
                    this.ObjectPrijsOntwikkelingPerVierkantemeter == input.ObjectPrijsOntwikkelingPerVierkantemeter ||
                    this.ObjectPrijsOntwikkelingPerVierkantemeter != null &&
                    input.ObjectPrijsOntwikkelingPerVierkantemeter != null &&
                    this.ObjectPrijsOntwikkelingPerVierkantemeter.SequenceEqual(input.ObjectPrijsOntwikkelingPerVierkantemeter)
                ) && 
                (
                    this.BuurtPrijsOntwikkeling == input.BuurtPrijsOntwikkeling ||
                    this.BuurtPrijsOntwikkeling != null &&
                    input.BuurtPrijsOntwikkeling != null &&
                    this.BuurtPrijsOntwikkeling.SequenceEqual(input.BuurtPrijsOntwikkeling)
                ) && 
                (
                    this.BuurtPrijsOntwikkelingPerVierkantemeter == input.BuurtPrijsOntwikkelingPerVierkantemeter ||
                    this.BuurtPrijsOntwikkelingPerVierkantemeter != null &&
                    input.BuurtPrijsOntwikkelingPerVierkantemeter != null &&
                    this.BuurtPrijsOntwikkelingPerVierkantemeter.SequenceEqual(input.BuurtPrijsOntwikkelingPerVierkantemeter)
                ) && 
                (
                    this.WijkPrijsOntwikkeling == input.WijkPrijsOntwikkeling ||
                    this.WijkPrijsOntwikkeling != null &&
                    input.WijkPrijsOntwikkeling != null &&
                    this.WijkPrijsOntwikkeling.SequenceEqual(input.WijkPrijsOntwikkeling)
                ) && 
                (
                    this.WijkPrijsOntwikkelingPerVierkantemeter == input.WijkPrijsOntwikkelingPerVierkantemeter ||
                    this.WijkPrijsOntwikkelingPerVierkantemeter != null &&
                    input.WijkPrijsOntwikkelingPerVierkantemeter != null &&
                    this.WijkPrijsOntwikkelingPerVierkantemeter.SequenceEqual(input.WijkPrijsOntwikkelingPerVierkantemeter)
                ) && 
                (
                    this.GemeentePrijsOntwikkeling == input.GemeentePrijsOntwikkeling ||
                    this.GemeentePrijsOntwikkeling != null &&
                    input.GemeentePrijsOntwikkeling != null &&
                    this.GemeentePrijsOntwikkeling.SequenceEqual(input.GemeentePrijsOntwikkeling)
                ) && 
                (
                    this.GemeentePrijsOntwikkelingPerVierkantemeter == input.GemeentePrijsOntwikkelingPerVierkantemeter ||
                    this.GemeentePrijsOntwikkelingPerVierkantemeter != null &&
                    input.GemeentePrijsOntwikkelingPerVierkantemeter != null &&
                    this.GemeentePrijsOntwikkelingPerVierkantemeter.SequenceEqual(input.GemeentePrijsOntwikkelingPerVierkantemeter)
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
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.ObjectPrijsOntwikkeling != null)
                {
                    hashCode = (hashCode * 59) + this.ObjectPrijsOntwikkeling.GetHashCode();
                }
                if (this.ObjectPrijsOntwikkelingPerVierkantemeter != null)
                {
                    hashCode = (hashCode * 59) + this.ObjectPrijsOntwikkelingPerVierkantemeter.GetHashCode();
                }
                if (this.BuurtPrijsOntwikkeling != null)
                {
                    hashCode = (hashCode * 59) + this.BuurtPrijsOntwikkeling.GetHashCode();
                }
                if (this.BuurtPrijsOntwikkelingPerVierkantemeter != null)
                {
                    hashCode = (hashCode * 59) + this.BuurtPrijsOntwikkelingPerVierkantemeter.GetHashCode();
                }
                if (this.WijkPrijsOntwikkeling != null)
                {
                    hashCode = (hashCode * 59) + this.WijkPrijsOntwikkeling.GetHashCode();
                }
                if (this.WijkPrijsOntwikkelingPerVierkantemeter != null)
                {
                    hashCode = (hashCode * 59) + this.WijkPrijsOntwikkelingPerVierkantemeter.GetHashCode();
                }
                if (this.GemeentePrijsOntwikkeling != null)
                {
                    hashCode = (hashCode * 59) + this.GemeentePrijsOntwikkeling.GetHashCode();
                }
                if (this.GemeentePrijsOntwikkelingPerVierkantemeter != null)
                {
                    hashCode = (hashCode * 59) + this.GemeentePrijsOntwikkelingPerVierkantemeter.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
