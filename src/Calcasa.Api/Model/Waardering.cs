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
 * Calcasa Public API v0
 *
 * The version of the OpenAPI document: 0.0.6
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
    /// Waardering
    /// </summary>
    [DataContract(Name = "Waardering")]
    public partial class Waardering : IEquatable<Waardering>, IValidatableObject
    {

        /// <summary>
        /// De huidige status van de waardering. | Waarde | Omschrijving | | - -- | - -- | | &#x60;onbekend&#x60; | Status onbekend. | | &#x60;initialiseren&#x60; | Deze waardering is geinitialiseerd maar moet nog bevestigd worden. | | &#x60;open&#x60; | Deze waardering is bevestigd maar moet nog uitgevoerd worden. | | &#x60;voltooid&#x60; | Deze waardering is voltooid. | | &#x60;opgewaardeerd&#x60; | Deze waardering is geupgrade naar een ander waardering type. | | &#x60;ongeldig&#x60; | Deze waardering is niet geldig, bijvoorbeeld omdat hij niet door de business rules is gekomen. | | &#x60;verlopen&#x60; | Deze waardering is verlopen omdat hij niet op tijd bevestigd is. | | &#x60;error&#x60; | Er is iets mis gegaan voor deze waardering. |   
        /// </summary>
        /// <value>De huidige status van de waardering. | Waarde | Omschrijving | | - -- | - -- | | &#x60;onbekend&#x60; | Status onbekend. | | &#x60;initialiseren&#x60; | Deze waardering is geinitialiseerd maar moet nog bevestigd worden. | | &#x60;open&#x60; | Deze waardering is bevestigd maar moet nog uitgevoerd worden. | | &#x60;voltooid&#x60; | Deze waardering is voltooid. | | &#x60;opgewaardeerd&#x60; | Deze waardering is geupgrade naar een ander waardering type. | | &#x60;ongeldig&#x60; | Deze waardering is niet geldig, bijvoorbeeld omdat hij niet door de business rules is gekomen. | | &#x60;verlopen&#x60; | Deze waardering is verlopen omdat hij niet op tijd bevestigd is. | | &#x60;error&#x60; | Er is iets mis gegaan voor deze waardering. |   </value>
        [DataMember(Name = "status", EmitDefaultValue = true)]
        public WaarderingStatus? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Waardering" /> class.
        /// </summary>
        /// <param name="id">Id van de waardering of tracking Id..</param>
        /// <param name="aangemaakt">Het tijdsstempel van wanneer de waardering aangemaakt is..</param>
        /// <param name="status">De huidige status van de waardering. | Waarde | Omschrijving | | - -- | - -- | | &#x60;onbekend&#x60; | Status onbekend. | | &#x60;initialiseren&#x60; | Deze waardering is geinitialiseerd maar moet nog bevestigd worden. | | &#x60;open&#x60; | Deze waardering is bevestigd maar moet nog uitgevoerd worden. | | &#x60;voltooid&#x60; | Deze waardering is voltooid. | | &#x60;opgewaardeerd&#x60; | Deze waardering is geupgrade naar een ander waardering type. | | &#x60;ongeldig&#x60; | Deze waardering is niet geldig, bijvoorbeeld omdat hij niet door de business rules is gekomen. | | &#x60;verlopen&#x60; | Deze waardering is verlopen omdat hij niet op tijd bevestigd is. | | &#x60;error&#x60; | Er is iets mis gegaan voor deze waardering. |   .</param>
        /// <param name="origineleInput">De invoer die gebruikt is voor het aanmaken van deze waardering..</param>
        /// <param name="adres">adres.</param>
        /// <param name="model">model.</param>
        /// <param name="taxatie">taxatie.</param>
        /// <param name="_object">_object.</param>
        /// <param name="cbsIndeling">cbsIndeling.</param>
        /// <param name="fotos">fotos.</param>
        /// <param name="referenties">referenties.</param>
        /// <param name="vorigeVerkopen">vorigeVerkopen.</param>
        /// <param name="rapport">rapport.</param>
        /// <param name="factuur">factuur.</param>
        public Waardering(Guid id = default(Guid), DateTime aangemaakt = default(DateTime), WaarderingStatus? status = default(WaarderingStatus?), WaarderingInputParameters origineleInput = default(WaarderingInputParameters), Adres adres = default(Adres), Modeldata model = default(Modeldata), Taxatiedata taxatie = default(Taxatiedata), Objectdata _object = default(Objectdata), CbsIndeling cbsIndeling = default(CbsIndeling), Collection<Foto> fotos = default(Collection<Foto>), Collection<Referentieobject> referenties = default(Collection<Referentieobject>), Collection<VorigeVerkoop> vorigeVerkopen = default(Collection<VorigeVerkoop>), Rapport rapport = default(Rapport), Factuur factuur = default(Factuur))
        {
            this.Id = id;
            this.Aangemaakt = aangemaakt;
            this.Status = status;
            this.OrigineleInput = origineleInput;
            this.Adres = adres;
            this.Model = model;
            this.Taxatie = taxatie;
            this.Object = _object;
            this.CbsIndeling = cbsIndeling;
            this.Fotos = fotos;
            this.Referenties = referenties;
            this.VorigeVerkopen = vorigeVerkopen;
            this.Rapport = rapport;
            this.Factuur = factuur;
        }

        /// <summary>
        /// Id van de waardering of tracking Id.
        /// </summary>
        /// <value>Id van de waardering of tracking Id.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public Guid Id { get; set; }

        /// <summary>
        /// Het tijdsstempel van wanneer de waardering aangemaakt is.
        /// </summary>
        /// <value>Het tijdsstempel van wanneer de waardering aangemaakt is.</value>
        [DataMember(Name = "aangemaakt", EmitDefaultValue = false)]
        public DateTime Aangemaakt { get; set; }

        /// <summary>
        /// De invoer die gebruikt is voor het aanmaken van deze waardering.
        /// </summary>
        /// <value>De invoer die gebruikt is voor het aanmaken van deze waardering.</value>
        [DataMember(Name = "origineleInput", EmitDefaultValue = true)]
        public WaarderingInputParameters OrigineleInput { get; set; }

        /// <summary>
        /// Gets or Sets Adres
        /// </summary>
        [DataMember(Name = "adres", EmitDefaultValue = true)]
        public Adres Adres { get; set; }

        /// <summary>
        /// Gets or Sets Model
        /// </summary>
        [DataMember(Name = "model", EmitDefaultValue = true)]
        public Modeldata Model { get; set; }

        /// <summary>
        /// Gets or Sets Taxatie
        /// </summary>
        [DataMember(Name = "taxatie", EmitDefaultValue = true)]
        public Taxatiedata Taxatie { get; set; }

        /// <summary>
        /// Gets or Sets Object
        /// </summary>
        [DataMember(Name = "object", EmitDefaultValue = true)]
        public Objectdata Object { get; set; }

        /// <summary>
        /// Gets or Sets CbsIndeling
        /// </summary>
        [DataMember(Name = "cbsIndeling", EmitDefaultValue = true)]
        public CbsIndeling CbsIndeling { get; set; }

        /// <summary>
        /// Gets or Sets Fotos
        /// </summary>
        [DataMember(Name = "fotos", EmitDefaultValue = true)]
        public Collection<Foto> Fotos { get; set; }

        /// <summary>
        /// Gets or Sets Referenties
        /// </summary>
        [DataMember(Name = "referenties", EmitDefaultValue = true)]
        public Collection<Referentieobject> Referenties { get; set; }

        /// <summary>
        /// Gets or Sets VorigeVerkopen
        /// </summary>
        [DataMember(Name = "vorigeVerkopen", EmitDefaultValue = true)]
        public Collection<VorigeVerkoop> VorigeVerkopen { get; set; }

        /// <summary>
        /// Gets or Sets Rapport
        /// </summary>
        [DataMember(Name = "rapport", EmitDefaultValue = true)]
        public Rapport Rapport { get; set; }

        /// <summary>
        /// Gets or Sets Factuur
        /// </summary>
        [DataMember(Name = "factuur", EmitDefaultValue = true)]
        public Factuur Factuur { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Waardering {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Aangemaakt: ").Append(Aangemaakt).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  OrigineleInput: ").Append(OrigineleInput).Append("\n");
            sb.Append("  Adres: ").Append(Adres).Append("\n");
            sb.Append("  Model: ").Append(Model).Append("\n");
            sb.Append("  Taxatie: ").Append(Taxatie).Append("\n");
            sb.Append("  Object: ").Append(Object).Append("\n");
            sb.Append("  CbsIndeling: ").Append(CbsIndeling).Append("\n");
            sb.Append("  Fotos: ").Append(Fotos).Append("\n");
            sb.Append("  Referenties: ").Append(Referenties).Append("\n");
            sb.Append("  VorigeVerkopen: ").Append(VorigeVerkopen).Append("\n");
            sb.Append("  Rapport: ").Append(Rapport).Append("\n");
            sb.Append("  Factuur: ").Append(Factuur).Append("\n");
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
            return this.Equals(input as Waardering);
        }

        /// <summary>
        /// Returns true if Waardering instances are equal
        /// </summary>
        /// <param name="input">Instance of Waardering to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Waardering input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Aangemaakt == input.Aangemaakt ||
                    (this.Aangemaakt != null &&
                    this.Aangemaakt.Equals(input.Aangemaakt))
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.OrigineleInput == input.OrigineleInput ||
                    (this.OrigineleInput != null &&
                    this.OrigineleInput.Equals(input.OrigineleInput))
                ) && 
                (
                    this.Adres == input.Adres ||
                    (this.Adres != null &&
                    this.Adres.Equals(input.Adres))
                ) && 
                (
                    this.Model == input.Model ||
                    (this.Model != null &&
                    this.Model.Equals(input.Model))
                ) && 
                (
                    this.Taxatie == input.Taxatie ||
                    (this.Taxatie != null &&
                    this.Taxatie.Equals(input.Taxatie))
                ) && 
                (
                    this.Object == input.Object ||
                    (this.Object != null &&
                    this.Object.Equals(input.Object))
                ) && 
                (
                    this.CbsIndeling == input.CbsIndeling ||
                    (this.CbsIndeling != null &&
                    this.CbsIndeling.Equals(input.CbsIndeling))
                ) && 
                (
                    this.Fotos == input.Fotos ||
                    this.Fotos != null &&
                    input.Fotos != null &&
                    this.Fotos.SequenceEqual(input.Fotos)
                ) && 
                (
                    this.Referenties == input.Referenties ||
                    this.Referenties != null &&
                    input.Referenties != null &&
                    this.Referenties.SequenceEqual(input.Referenties)
                ) && 
                (
                    this.VorigeVerkopen == input.VorigeVerkopen ||
                    this.VorigeVerkopen != null &&
                    input.VorigeVerkopen != null &&
                    this.VorigeVerkopen.SequenceEqual(input.VorigeVerkopen)
                ) && 
                (
                    this.Rapport == input.Rapport ||
                    (this.Rapport != null &&
                    this.Rapport.Equals(input.Rapport))
                ) && 
                (
                    this.Factuur == input.Factuur ||
                    (this.Factuur != null &&
                    this.Factuur.Equals(input.Factuur))
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
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Aangemaakt != null)
                    hashCode = hashCode * 59 + this.Aangemaakt.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.OrigineleInput != null)
                    hashCode = hashCode * 59 + this.OrigineleInput.GetHashCode();
                if (this.Adres != null)
                    hashCode = hashCode * 59 + this.Adres.GetHashCode();
                if (this.Model != null)
                    hashCode = hashCode * 59 + this.Model.GetHashCode();
                if (this.Taxatie != null)
                    hashCode = hashCode * 59 + this.Taxatie.GetHashCode();
                if (this.Object != null)
                    hashCode = hashCode * 59 + this.Object.GetHashCode();
                if (this.CbsIndeling != null)
                    hashCode = hashCode * 59 + this.CbsIndeling.GetHashCode();
                if (this.Fotos != null)
                    hashCode = hashCode * 59 + this.Fotos.GetHashCode();
                if (this.Referenties != null)
                    hashCode = hashCode * 59 + this.Referenties.GetHashCode();
                if (this.VorigeVerkopen != null)
                    hashCode = hashCode * 59 + this.VorigeVerkopen.GetHashCode();
                if (this.Rapport != null)
                    hashCode = hashCode * 59 + this.Rapport.GetHashCode();
                if (this.Factuur != null)
                    hashCode = hashCode * 59 + this.Factuur.GetHashCode();
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
