/*
 * Copyright 2021 Calcasa B.V.
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
 * Calcasa Public API
 *
 * The version of the OpenAPI document: v0
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
using System.ComponentModel.DataAnnotations;
using FileParameter = Calcasa.Api.Client.FileParameter;
using OpenAPIDateConverter = Calcasa.Api.Client.OpenAPIDateConverter;

namespace Calcasa.Api.Model
{
    /// <summary>
    /// De payload van de webhooks voor de waarderingen.
    /// </summary>
    [DataContract(Name = "WaarderingWebhookPayload")]
    public partial class WaarderingWebhookPayload : IEquatable<WaarderingWebhookPayload>, IValidatableObject
    {

        /// <summary>
        /// De oude status van de waardering. | Waarde | Omschrijving | | - -- | - -- | | &#x60;onbekend&#x60; | Status onbekend. | | &#x60;initialiseren&#x60; | Deze waardering is geinitialiseerd maar moet nog bevestigd worden. | | &#x60;open&#x60; | Deze waardering is bevestigd maar moet nog uitgevoerd worden. | | &#x60;voltooid&#x60; | Deze waardering is voltooid. | | &#x60;opgewaardeerd&#x60; | Deze waardering is geupgrade naar een ander waardering type. | | &#x60;ongeldig&#x60; | Deze waardering is niet geldig, bijvoorbeeld omdat hij niet door de business rules is gekomen. | | &#x60;verlopen&#x60; | Deze waardering is verlopen omdat hij niet op tijd bevestigd is. | | &#x60;error&#x60; | Er is iets mis gegaan voor deze waardering. |   
        /// </summary>
        /// <value>De oude status van de waardering. | Waarde | Omschrijving | | - -- | - -- | | &#x60;onbekend&#x60; | Status onbekend. | | &#x60;initialiseren&#x60; | Deze waardering is geinitialiseerd maar moet nog bevestigd worden. | | &#x60;open&#x60; | Deze waardering is bevestigd maar moet nog uitgevoerd worden. | | &#x60;voltooid&#x60; | Deze waardering is voltooid. | | &#x60;opgewaardeerd&#x60; | Deze waardering is geupgrade naar een ander waardering type. | | &#x60;ongeldig&#x60; | Deze waardering is niet geldig, bijvoorbeeld omdat hij niet door de business rules is gekomen. | | &#x60;verlopen&#x60; | Deze waardering is verlopen omdat hij niet op tijd bevestigd is. | | &#x60;error&#x60; | Er is iets mis gegaan voor deze waardering. |   </value>
        [DataMember(Name = "oldStatus", EmitDefaultValue = true)]
        public WaarderingStatus? OldStatus { get; set; }

        /// <summary>
        /// De nieuwe status van de waardering. | Waarde | Omschrijving | | - -- | - -- | | &#x60;onbekend&#x60; | Status onbekend. | | &#x60;initialiseren&#x60; | Deze waardering is geinitialiseerd maar moet nog bevestigd worden. | | &#x60;open&#x60; | Deze waardering is bevestigd maar moet nog uitgevoerd worden. | | &#x60;voltooid&#x60; | Deze waardering is voltooid. | | &#x60;opgewaardeerd&#x60; | Deze waardering is geupgrade naar een ander waardering type. | | &#x60;ongeldig&#x60; | Deze waardering is niet geldig, bijvoorbeeld omdat hij niet door de business rules is gekomen. | | &#x60;verlopen&#x60; | Deze waardering is verlopen omdat hij niet op tijd bevestigd is. | | &#x60;error&#x60; | Er is iets mis gegaan voor deze waardering. |   
        /// </summary>
        /// <value>De nieuwe status van de waardering. | Waarde | Omschrijving | | - -- | - -- | | &#x60;onbekend&#x60; | Status onbekend. | | &#x60;initialiseren&#x60; | Deze waardering is geinitialiseerd maar moet nog bevestigd worden. | | &#x60;open&#x60; | Deze waardering is bevestigd maar moet nog uitgevoerd worden. | | &#x60;voltooid&#x60; | Deze waardering is voltooid. | | &#x60;opgewaardeerd&#x60; | Deze waardering is geupgrade naar een ander waardering type. | | &#x60;ongeldig&#x60; | Deze waardering is niet geldig, bijvoorbeeld omdat hij niet door de business rules is gekomen. | | &#x60;verlopen&#x60; | Deze waardering is verlopen omdat hij niet op tijd bevestigd is. | | &#x60;error&#x60; | Er is iets mis gegaan voor deze waardering. |   </value>
        [DataMember(Name = "newStatus", EmitDefaultValue = true)]
        public WaarderingStatus? NewStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="WaarderingWebhookPayload" /> class.
        /// </summary>
        /// <param name="eventId">Uniek Id voor deze callback..</param>
        /// <param name="waarderingId">Het Id van de waardering waarop deze callback betrekking heeft..</param>
        /// <param name="oldStatus">De oude status van de waardering. | Waarde | Omschrijving | | - -- | - -- | | &#x60;onbekend&#x60; | Status onbekend. | | &#x60;initialiseren&#x60; | Deze waardering is geinitialiseerd maar moet nog bevestigd worden. | | &#x60;open&#x60; | Deze waardering is bevestigd maar moet nog uitgevoerd worden. | | &#x60;voltooid&#x60; | Deze waardering is voltooid. | | &#x60;opgewaardeerd&#x60; | Deze waardering is geupgrade naar een ander waardering type. | | &#x60;ongeldig&#x60; | Deze waardering is niet geldig, bijvoorbeeld omdat hij niet door de business rules is gekomen. | | &#x60;verlopen&#x60; | Deze waardering is verlopen omdat hij niet op tijd bevestigd is. | | &#x60;error&#x60; | Er is iets mis gegaan voor deze waardering. |   .</param>
        /// <param name="newStatus">De nieuwe status van de waardering. | Waarde | Omschrijving | | - -- | - -- | | &#x60;onbekend&#x60; | Status onbekend. | | &#x60;initialiseren&#x60; | Deze waardering is geinitialiseerd maar moet nog bevestigd worden. | | &#x60;open&#x60; | Deze waardering is bevestigd maar moet nog uitgevoerd worden. | | &#x60;voltooid&#x60; | Deze waardering is voltooid. | | &#x60;opgewaardeerd&#x60; | Deze waardering is geupgrade naar een ander waardering type. | | &#x60;ongeldig&#x60; | Deze waardering is niet geldig, bijvoorbeeld omdat hij niet door de business rules is gekomen. | | &#x60;verlopen&#x60; | Deze waardering is verlopen omdat hij niet op tijd bevestigd is. | | &#x60;error&#x60; | Er is iets mis gegaan voor deze waardering. |   .</param>
        /// <param name="timestamp">Het tijdstip van het event, in UTC..</param>
        /// <param name="isTest">Geeft aan of de betreffende waardering aangevraagd is met een test token..</param>
        public WaarderingWebhookPayload(Guid eventId = default(Guid), Guid waarderingId = default(Guid), WaarderingStatus? oldStatus = default(WaarderingStatus?), WaarderingStatus? newStatus = default(WaarderingStatus?), DateTime timestamp = default(DateTime), bool isTest = default(bool))
        {
            this.EventId = eventId;
            this.WaarderingId = waarderingId;
            this.OldStatus = oldStatus;
            this.NewStatus = newStatus;
            this.Timestamp = timestamp;
            this.IsTest = isTest;
        }

        /// <summary>
        /// Gets or Sets CallbackName
        /// </summary>
        [DataMember(Name = "callbackName", EmitDefaultValue = false)]
        public string CallbackName { get; private set; }

        /// <summary>
        /// Returns false as CallbackName should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCallbackName()
        {
            return false;
        }
        /// <summary>
        /// Uniek Id voor deze callback.
        /// </summary>
        /// <value>Uniek Id voor deze callback.</value>
        [DataMember(Name = "eventId", EmitDefaultValue = false)]
        public Guid EventId { get; set; }

        /// <summary>
        /// Het Id van de waardering waarop deze callback betrekking heeft.
        /// </summary>
        /// <value>Het Id van de waardering waarop deze callback betrekking heeft.</value>
        [DataMember(Name = "waarderingId", EmitDefaultValue = false)]
        public Guid WaarderingId { get; set; }

        /// <summary>
        /// Het tijdstip van het event, in UTC.
        /// </summary>
        /// <value>Het tijdstip van het event, in UTC.</value>
        [DataMember(Name = "timestamp", EmitDefaultValue = false)]
        public DateTime Timestamp { get; set; }

        /// <summary>
        /// Geeft aan of de betreffende waardering aangevraagd is met een test token.
        /// </summary>
        /// <value>Geeft aan of de betreffende waardering aangevraagd is met een test token.</value>
        [DataMember(Name = "isTest", EmitDefaultValue = true)]
        public bool IsTest { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WaarderingWebhookPayload {\n");
            sb.Append("  CallbackName: ").Append(CallbackName).Append("\n");
            sb.Append("  EventId: ").Append(EventId).Append("\n");
            sb.Append("  WaarderingId: ").Append(WaarderingId).Append("\n");
            sb.Append("  OldStatus: ").Append(OldStatus).Append("\n");
            sb.Append("  NewStatus: ").Append(NewStatus).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  IsTest: ").Append(IsTest).Append("\n");
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
            return this.Equals(input as WaarderingWebhookPayload);
        }

        /// <summary>
        /// Returns true if WaarderingWebhookPayload instances are equal
        /// </summary>
        /// <param name="input">Instance of WaarderingWebhookPayload to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WaarderingWebhookPayload input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CallbackName == input.CallbackName ||
                    (this.CallbackName != null &&
                    this.CallbackName.Equals(input.CallbackName))
                ) && 
                (
                    this.EventId == input.EventId ||
                    (this.EventId != null &&
                    this.EventId.Equals(input.EventId))
                ) && 
                (
                    this.WaarderingId == input.WaarderingId ||
                    (this.WaarderingId != null &&
                    this.WaarderingId.Equals(input.WaarderingId))
                ) && 
                (
                    this.OldStatus == input.OldStatus ||
                    this.OldStatus.Equals(input.OldStatus)
                ) && 
                (
                    this.NewStatus == input.NewStatus ||
                    this.NewStatus.Equals(input.NewStatus)
                ) && 
                (
                    this.Timestamp == input.Timestamp ||
                    (this.Timestamp != null &&
                    this.Timestamp.Equals(input.Timestamp))
                ) && 
                (
                    this.IsTest == input.IsTest ||
                    this.IsTest.Equals(input.IsTest)
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
                if (this.CallbackName != null)
                    hashCode = hashCode * 59 + this.CallbackName.GetHashCode();
                if (this.EventId != null)
                    hashCode = hashCode * 59 + this.EventId.GetHashCode();
                if (this.WaarderingId != null)
                    hashCode = hashCode * 59 + this.WaarderingId.GetHashCode();
                hashCode = hashCode * 59 + this.OldStatus.GetHashCode();
                hashCode = hashCode * 59 + this.NewStatus.GetHashCode();
                if (this.Timestamp != null)
                    hashCode = hashCode * 59 + this.Timestamp.GetHashCode();
                hashCode = hashCode * 59 + this.IsTest.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
