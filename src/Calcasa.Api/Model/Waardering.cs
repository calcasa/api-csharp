// <auto-generated>
/*
 * Copyright 2025 Calcasa B.V.
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
 * The Calcasa API is used to connect to Calcasa provided services. For more information, please visit [Documentation](https://docs.calcasa.nl) or [GitHub](https://github.com/calcasa/api).
 *
 * The version of the OpenAPI document: 1.4.0-rc1
 * Contact: info@calcasa.nl
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

#nullable enable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;
using Calcasa.Api.Client;

namespace Calcasa.Api.Model
{
    /// <summary>
    /// Waardering
    /// </summary>
    public partial class Waardering
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Waardering" /> class.
        /// </summary>
        /// <param name="id">id</param>
        /// <param name="aangemaakt">Het tijdsstempel van wanneer de waardering aangemaakt is.</param>
        /// <param name="status">status</param>
        /// <param name="origineleInput">origineleInput</param>
        /// <param name="adres">adres</param>
        /// <param name="model">model</param>
        /// <param name="taxatie">taxatie</param>
        /// <param name="object">object</param>
        /// <param name="cbsIndeling">cbsIndeling</param>
        /// <param name="fotos">fotos</param>
        /// <param name="referenties">referenties</param>
        /// <param name="vorigeVerkopen">vorigeVerkopen</param>
        /// <param name="rapport">rapport</param>
        /// <param name="factuur">factuur</param>
        [JsonConstructor]
        public Waardering(Guid id, DateTime aangemaakt, WaarderingStatus status, WaarderingInputParameters origineleInput, Adres adres, Option<Modeldata?> model = default, Option<Taxatiedata?> taxatie = default, Option<Objectdata?> @object = default, Option<CbsIndeling?> cbsIndeling = default, Option<Collection<Foto>?> fotos = default, Option<Collection<Referentieobject>?> referenties = default, Option<Collection<VorigeVerkoop>?> vorigeVerkopen = default, Option<Rapport?> rapport = default, Option<Factuur?> factuur = default)
        {
            Id = id;
            Aangemaakt = aangemaakt;
            Status = status;
            OrigineleInput = origineleInput;
            Adres = adres;
            ModelOption = model;
            TaxatieOption = taxatie;
            ObjectOption = @object;
            CbsIndelingOption = cbsIndeling;
            FotosOption = fotos;
            ReferentiesOption = referenties;
            VorigeVerkopenOption = vorigeVerkopen;
            RapportOption = rapport;
            FactuurOption = factuur;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [JsonPropertyName("status")]
        public WaarderingStatus Status { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [JsonPropertyName("id")]
        public Guid Id { get; set; }

        /// <summary>
        /// Het tijdsstempel van wanneer de waardering aangemaakt is.
        /// </summary>
        /// <value>Het tijdsstempel van wanneer de waardering aangemaakt is.</value>
        /* <example>2021-04-28T12:34:45Z</example> */
        [JsonPropertyName("aangemaakt")]
        public DateTime Aangemaakt { get; set; }

        /// <summary>
        /// Gets or Sets OrigineleInput
        /// </summary>
        [JsonPropertyName("origineleInput")]
        public WaarderingInputParameters OrigineleInput { get; set; }

        /// <summary>
        /// Gets or Sets Adres
        /// </summary>
        [JsonPropertyName("adres")]
        public Adres Adres { get; set; }

        /// <summary>
        /// Used to track the state of Model
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<Modeldata?> ModelOption { get; private set; }

        /// <summary>
        /// Gets or Sets Model
        /// </summary>
        [JsonPropertyName("model")]
        public Modeldata? Model { get { return this.ModelOption; } set { this.ModelOption = new(value); } }

        /// <summary>
        /// Used to track the state of Taxatie
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<Taxatiedata?> TaxatieOption { get; private set; }

        /// <summary>
        /// Gets or Sets Taxatie
        /// </summary>
        [JsonPropertyName("taxatie")]
        public Taxatiedata? Taxatie { get { return this.TaxatieOption; } set { this.TaxatieOption = new(value); } }

        /// <summary>
        /// Used to track the state of Object
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<Objectdata?> ObjectOption { get; private set; }

        /// <summary>
        /// Gets or Sets Object
        /// </summary>
        [JsonPropertyName("object")]
        public Objectdata? Object { get { return this.ObjectOption; } set { this.ObjectOption = new(value); } }

        /// <summary>
        /// Used to track the state of CbsIndeling
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<CbsIndeling?> CbsIndelingOption { get; private set; }

        /// <summary>
        /// Gets or Sets CbsIndeling
        /// </summary>
        [JsonPropertyName("cbsIndeling")]
        public CbsIndeling? CbsIndeling { get { return this.CbsIndelingOption; } set { this.CbsIndelingOption = new(value); } }

        /// <summary>
        /// Used to track the state of Fotos
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<Collection<Foto>?> FotosOption { get; private set; }

        /// <summary>
        /// Gets or Sets Fotos
        /// </summary>
        [JsonPropertyName("fotos")]
        public Collection<Foto>? Fotos { get { return this.FotosOption; } set { this.FotosOption = new(value); } }

        /// <summary>
        /// Used to track the state of Referenties
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<Collection<Referentieobject>?> ReferentiesOption { get; private set; }

        /// <summary>
        /// Gets or Sets Referenties
        /// </summary>
        [JsonPropertyName("referenties")]
        public Collection<Referentieobject>? Referenties { get { return this.ReferentiesOption; } set { this.ReferentiesOption = new(value); } }

        /// <summary>
        /// Used to track the state of VorigeVerkopen
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<Collection<VorigeVerkoop>?> VorigeVerkopenOption { get; private set; }

        /// <summary>
        /// Gets or Sets VorigeVerkopen
        /// </summary>
        [JsonPropertyName("vorigeVerkopen")]
        public Collection<VorigeVerkoop>? VorigeVerkopen { get { return this.VorigeVerkopenOption; } set { this.VorigeVerkopenOption = new(value); } }

        /// <summary>
        /// Used to track the state of Rapport
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<Rapport?> RapportOption { get; private set; }

        /// <summary>
        /// Gets or Sets Rapport
        /// </summary>
        [JsonPropertyName("rapport")]
        public Rapport? Rapport { get { return this.RapportOption; } set { this.RapportOption = new(value); } }

        /// <summary>
        /// Used to track the state of Factuur
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<Factuur?> FactuurOption { get; private set; }

        /// <summary>
        /// Gets or Sets Factuur
        /// </summary>
        [JsonPropertyName("factuur")]
        public Factuur? Factuur { get { return this.FactuurOption; } set { this.FactuurOption = new(value); } }

        /// <summary>
        /// Gets or Sets additional properties
        /// </summary>
        [JsonExtensionData]
        public Dictionary<string, JsonElement> AdditionalProperties { get; } = new Dictionary<string, JsonElement>();

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
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
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="Waardering" />
    /// </summary>
    public class WaarderingJsonConverter : JsonConverter<Waardering>
    {
        /// <summary>
        /// The format to use to serialize Aangemaakt
        /// </summary>
        public static string AangemaaktFormat { get; set; } = "yyyy'-'MM'-'dd'T'HH':'mm':'ssZ";

        /// <summary>
        /// Deserializes json to <see cref="Waardering" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override Waardering Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<Guid?> id = default;
            Option<DateTime?> aangemaakt = default;
            Option<WaarderingStatus?> status = default;
            Option<WaarderingInputParameters?> origineleInput = default;
            Option<Adres?> adres = default;
            Option<Modeldata?> model = default;
            Option<Taxatiedata?> taxatie = default;
            Option<Objectdata?> varObject = default;
            Option<CbsIndeling?> cbsIndeling = default;
            Option<Collection<Foto>?> fotos = default;
            Option<Collection<Referentieobject>?> referenties = default;
            Option<Collection<VorigeVerkoop>?> vorigeVerkopen = default;
            Option<Rapport?> rapport = default;
            Option<Factuur?> factuur = default;

            while (utf8JsonReader.Read())
            {
                if (startingTokenType == JsonTokenType.StartObject && utf8JsonReader.TokenType == JsonTokenType.EndObject && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (startingTokenType == JsonTokenType.StartArray && utf8JsonReader.TokenType == JsonTokenType.EndArray && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (utf8JsonReader.TokenType == JsonTokenType.PropertyName && currentDepth == utf8JsonReader.CurrentDepth - 1)
                {
                    string? localVarJsonPropertyName = utf8JsonReader.GetString();
                    utf8JsonReader.Read();

                    switch (localVarJsonPropertyName)
                    {
                        case "id":
                            id = new Option<Guid?>(utf8JsonReader.TokenType == JsonTokenType.Null ? (Guid?)null : utf8JsonReader.GetGuid());
                            break;
                        case "aangemaakt":
                            aangemaakt = new Option<DateTime?>(JsonSerializer.Deserialize<DateTime>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "status":
                            string? statusRawValue = utf8JsonReader.GetString();
                            if (statusRawValue != null)
                                status = new Option<WaarderingStatus?>(WaarderingStatusValueConverter.FromStringOrDefault(statusRawValue));
                            break;
                        case "origineleInput":
                            origineleInput = new Option<WaarderingInputParameters?>(JsonSerializer.Deserialize<WaarderingInputParameters>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "adres":
                            adres = new Option<Adres?>(JsonSerializer.Deserialize<Adres>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "model":
                            model = new Option<Modeldata?>(JsonSerializer.Deserialize<Modeldata>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "taxatie":
                            taxatie = new Option<Taxatiedata?>(JsonSerializer.Deserialize<Taxatiedata>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "object":
                            varObject = new Option<Objectdata?>(JsonSerializer.Deserialize<Objectdata>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "cbsIndeling":
                            cbsIndeling = new Option<CbsIndeling?>(JsonSerializer.Deserialize<CbsIndeling>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "fotos":
                            fotos = new Option<Collection<Foto>?>(JsonSerializer.Deserialize<Collection<Foto>>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "referenties":
                            referenties = new Option<Collection<Referentieobject>?>(JsonSerializer.Deserialize<Collection<Referentieobject>>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "vorigeVerkopen":
                            vorigeVerkopen = new Option<Collection<VorigeVerkoop>?>(JsonSerializer.Deserialize<Collection<VorigeVerkoop>>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "rapport":
                            rapport = new Option<Rapport?>(JsonSerializer.Deserialize<Rapport>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "factuur":
                            factuur = new Option<Factuur?>(JsonSerializer.Deserialize<Factuur>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!id.IsSet)
                throw new ArgumentException("Property is required for class Waardering.", nameof(id));

            if (!aangemaakt.IsSet)
                throw new ArgumentException("Property is required for class Waardering.", nameof(aangemaakt));

            if (!status.IsSet)
                throw new ArgumentException("Property is required for class Waardering.", nameof(status));

            if (!origineleInput.IsSet)
                throw new ArgumentException("Property is required for class Waardering.", nameof(origineleInput));

            if (!adres.IsSet)
                throw new ArgumentException("Property is required for class Waardering.", nameof(adres));

            if (id.IsSet && id.Value == null)
                throw new ArgumentNullException(nameof(id), "Property is not nullable for class Waardering.");

            if (aangemaakt.IsSet && aangemaakt.Value == null)
                throw new ArgumentNullException(nameof(aangemaakt), "Property is not nullable for class Waardering.");

            if (status.IsSet && status.Value == null)
                throw new ArgumentNullException(nameof(status), "Property is not nullable for class Waardering.");

            if (origineleInput.IsSet && origineleInput.Value == null)
                throw new ArgumentNullException(nameof(origineleInput), "Property is not nullable for class Waardering.");

            if (adres.IsSet && adres.Value == null)
                throw new ArgumentNullException(nameof(adres), "Property is not nullable for class Waardering.");

            if (model.IsSet && model.Value == null)
                throw new ArgumentNullException(nameof(model), "Property is not nullable for class Waardering.");

            if (taxatie.IsSet && taxatie.Value == null)
                throw new ArgumentNullException(nameof(taxatie), "Property is not nullable for class Waardering.");

            if (varObject.IsSet && varObject.Value == null)
                throw new ArgumentNullException(nameof(varObject), "Property is not nullable for class Waardering.");

            if (cbsIndeling.IsSet && cbsIndeling.Value == null)
                throw new ArgumentNullException(nameof(cbsIndeling), "Property is not nullable for class Waardering.");

            if (rapport.IsSet && rapport.Value == null)
                throw new ArgumentNullException(nameof(rapport), "Property is not nullable for class Waardering.");

            if (factuur.IsSet && factuur.Value == null)
                throw new ArgumentNullException(nameof(factuur), "Property is not nullable for class Waardering.");

            return new Waardering(id.Value!.Value!, aangemaakt.Value!.Value!, status.Value!.Value!, origineleInput.Value!, adres.Value!, model, taxatie, varObject, cbsIndeling, fotos, referenties, vorigeVerkopen, rapport, factuur);
        }

        /// <summary>
        /// Serializes a <see cref="Waardering" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="waardering"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, Waardering waardering, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, waardering, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="Waardering" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="waardering"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, Waardering waardering, JsonSerializerOptions jsonSerializerOptions)
        {
            if (waardering.OrigineleInput == null)
                throw new ArgumentNullException(nameof(waardering.OrigineleInput), "Property is required for class Waardering.");

            if (waardering.Adres == null)
                throw new ArgumentNullException(nameof(waardering.Adres), "Property is required for class Waardering.");

            if (waardering.ModelOption.IsSet && waardering.Model == null)
                throw new ArgumentNullException(nameof(waardering.Model), "Property is required for class Waardering.");

            if (waardering.TaxatieOption.IsSet && waardering.Taxatie == null)
                throw new ArgumentNullException(nameof(waardering.Taxatie), "Property is required for class Waardering.");

            if (waardering.ObjectOption.IsSet && waardering.Object == null)
                throw new ArgumentNullException(nameof(waardering.Object), "Property is required for class Waardering.");

            if (waardering.CbsIndelingOption.IsSet && waardering.CbsIndeling == null)
                throw new ArgumentNullException(nameof(waardering.CbsIndeling), "Property is required for class Waardering.");

            if (waardering.RapportOption.IsSet && waardering.Rapport == null)
                throw new ArgumentNullException(nameof(waardering.Rapport), "Property is required for class Waardering.");

            if (waardering.FactuurOption.IsSet && waardering.Factuur == null)
                throw new ArgumentNullException(nameof(waardering.Factuur), "Property is required for class Waardering.");

            writer.WriteString("id", waardering.Id);

            writer.WriteString("aangemaakt", waardering.Aangemaakt.ToString(AangemaaktFormat));

            var statusRawValue = WaarderingStatusValueConverter.ToJsonValue(waardering.Status);
            writer.WriteString("status", statusRawValue);

            writer.WritePropertyName("origineleInput");
            JsonSerializer.Serialize(writer, waardering.OrigineleInput, jsonSerializerOptions);
            writer.WritePropertyName("adres");
            JsonSerializer.Serialize(writer, waardering.Adres, jsonSerializerOptions);
            if (waardering.ModelOption.IsSet)
            {
                writer.WritePropertyName("model");
                JsonSerializer.Serialize(writer, waardering.Model, jsonSerializerOptions);
            }
            if (waardering.TaxatieOption.IsSet)
            {
                writer.WritePropertyName("taxatie");
                JsonSerializer.Serialize(writer, waardering.Taxatie, jsonSerializerOptions);
            }
            if (waardering.ObjectOption.IsSet)
            {
                writer.WritePropertyName("object");
                JsonSerializer.Serialize(writer, waardering.Object, jsonSerializerOptions);
            }
            if (waardering.CbsIndelingOption.IsSet)
            {
                writer.WritePropertyName("cbsIndeling");
                JsonSerializer.Serialize(writer, waardering.CbsIndeling, jsonSerializerOptions);
            }
            if (waardering.FotosOption.IsSet)
                if (waardering.FotosOption.Value != null)
                {
                    writer.WritePropertyName("fotos");
                    JsonSerializer.Serialize(writer, waardering.Fotos, jsonSerializerOptions);
                }
                else
                    writer.WriteNull("fotos");
            if (waardering.ReferentiesOption.IsSet)
                if (waardering.ReferentiesOption.Value != null)
                {
                    writer.WritePropertyName("referenties");
                    JsonSerializer.Serialize(writer, waardering.Referenties, jsonSerializerOptions);
                }
                else
                    writer.WriteNull("referenties");
            if (waardering.VorigeVerkopenOption.IsSet)
                if (waardering.VorigeVerkopenOption.Value != null)
                {
                    writer.WritePropertyName("vorigeVerkopen");
                    JsonSerializer.Serialize(writer, waardering.VorigeVerkopen, jsonSerializerOptions);
                }
                else
                    writer.WriteNull("vorigeVerkopen");
            if (waardering.RapportOption.IsSet)
            {
                writer.WritePropertyName("rapport");
                JsonSerializer.Serialize(writer, waardering.Rapport, jsonSerializerOptions);
            }
            if (waardering.FactuurOption.IsSet)
            {
                writer.WritePropertyName("factuur");
                JsonSerializer.Serialize(writer, waardering.Factuur, jsonSerializerOptions);
            }
        }
    }

    /// <summary>
    /// The WaarderingSerializationContext
    /// </summary>
    [JsonSourceGenerationOptions(WriteIndented = true, GenerationMode = JsonSourceGenerationMode.Metadata | JsonSourceGenerationMode.Serialization)]
    [JsonSerializable(typeof(Waardering))]
    public partial class WaarderingSerializationContext : JsonSerializerContext { }
}
