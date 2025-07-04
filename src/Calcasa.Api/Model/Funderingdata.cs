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
    /// Uitvoer met funderingsinformatie.
    /// </summary>
    public partial class Funderingdata
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Funderingdata" /> class.
        /// </summary>
        /// <param name="typering">typering</param>
        /// <param name="herstelType">herstelType</param>
        /// <param name="droogstandRisico">droogstandRisico</param>
        /// <param name="optrekkendVochtRisico">optrekkendVochtRisico</param>
        /// <param name="bioInfectieRisico">bioInfectieRisico</param>
        /// <param name="herstelkosten">Indicatieve herstelkosten van de fundering.</param>
        /// <param name="bron">bron</param>
        [JsonConstructor]
        public Funderingdata(Option<FunderingTypering?> typering = default, Option<FunderingHerstelType?> herstelType = default, Option<FunderingRisico?> droogstandRisico = default, Option<FunderingRisico?> optrekkendVochtRisico = default, Option<FunderingRisico?> bioInfectieRisico = default, Option<double?> herstelkosten = default, Option<FunderingDataBron?> bron = default)
        {
            TyperingOption = typering;
            HerstelTypeOption = herstelType;
            DroogstandRisicoOption = droogstandRisico;
            OptrekkendVochtRisicoOption = optrekkendVochtRisico;
            BioInfectieRisicoOption = bioInfectieRisico;
            HerstelkostenOption = herstelkosten;
            BronOption = bron;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of HerstelType
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<FunderingHerstelType?> HerstelTypeOption { get; private set; }

        /// <summary>
        /// Gets or Sets HerstelType
        /// </summary>
        [JsonPropertyName("herstelType")]
        public FunderingHerstelType? HerstelType { get { return this.HerstelTypeOption; } set { this.HerstelTypeOption = new(value); } }

        /// <summary>
        /// Used to track the state of Bron
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<FunderingDataBron?> BronOption { get; private set; }

        /// <summary>
        /// Gets or Sets Bron
        /// </summary>
        [JsonPropertyName("bron")]
        public FunderingDataBron? Bron { get { return this.BronOption; } set { this.BronOption = new(value); } }

        /// <summary>
        /// Used to track the state of Typering
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<FunderingTypering?> TyperingOption { get; private set; }

        /// <summary>
        /// Gets or Sets Typering
        /// </summary>
        [JsonPropertyName("typering")]
        public FunderingTypering? Typering { get { return this.TyperingOption; } set { this.TyperingOption = new(value); } }

        /// <summary>
        /// Used to track the state of DroogstandRisico
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<FunderingRisico?> DroogstandRisicoOption { get; private set; }

        /// <summary>
        /// Gets or Sets DroogstandRisico
        /// </summary>
        [JsonPropertyName("droogstandRisico")]
        public FunderingRisico? DroogstandRisico { get { return this.DroogstandRisicoOption; } set { this.DroogstandRisicoOption = new(value); } }

        /// <summary>
        /// Used to track the state of OptrekkendVochtRisico
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<FunderingRisico?> OptrekkendVochtRisicoOption { get; private set; }

        /// <summary>
        /// Gets or Sets OptrekkendVochtRisico
        /// </summary>
        [JsonPropertyName("optrekkendVochtRisico")]
        public FunderingRisico? OptrekkendVochtRisico { get { return this.OptrekkendVochtRisicoOption; } set { this.OptrekkendVochtRisicoOption = new(value); } }

        /// <summary>
        /// Used to track the state of BioInfectieRisico
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<FunderingRisico?> BioInfectieRisicoOption { get; private set; }

        /// <summary>
        /// Gets or Sets BioInfectieRisico
        /// </summary>
        [JsonPropertyName("bioInfectieRisico")]
        public FunderingRisico? BioInfectieRisico { get { return this.BioInfectieRisicoOption; } set { this.BioInfectieRisicoOption = new(value); } }

        /// <summary>
        /// Used to track the state of Herstelkosten
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<double?> HerstelkostenOption { get; private set; }

        /// <summary>
        /// Indicatieve herstelkosten van de fundering.
        /// </summary>
        /// <value>Indicatieve herstelkosten van de fundering.</value>
        [JsonPropertyName("herstelkosten")]
        public double? Herstelkosten { get { return this.HerstelkostenOption; } set { this.HerstelkostenOption = new(value); } }

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
            sb.Append("class Funderingdata {\n");
            sb.Append("  Typering: ").Append(Typering).Append("\n");
            sb.Append("  HerstelType: ").Append(HerstelType).Append("\n");
            sb.Append("  DroogstandRisico: ").Append(DroogstandRisico).Append("\n");
            sb.Append("  OptrekkendVochtRisico: ").Append(OptrekkendVochtRisico).Append("\n");
            sb.Append("  BioInfectieRisico: ").Append(BioInfectieRisico).Append("\n");
            sb.Append("  Herstelkosten: ").Append(Herstelkosten).Append("\n");
            sb.Append("  Bron: ").Append(Bron).Append("\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="Funderingdata" />
    /// </summary>
    public class FunderingdataJsonConverter : JsonConverter<Funderingdata>
    {
        /// <summary>
        /// Deserializes json to <see cref="Funderingdata" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override Funderingdata Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<FunderingTypering?> typering = default;
            Option<FunderingHerstelType?> herstelType = default;
            Option<FunderingRisico?> droogstandRisico = default;
            Option<FunderingRisico?> optrekkendVochtRisico = default;
            Option<FunderingRisico?> bioInfectieRisico = default;
            Option<double?> herstelkosten = default;
            Option<FunderingDataBron?> bron = default;

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
                        case "typering":
                            typering = new Option<FunderingTypering?>(JsonSerializer.Deserialize<FunderingTypering>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "herstelType":
                            string? herstelTypeRawValue = utf8JsonReader.GetString();
                            if (herstelTypeRawValue != null)
                                herstelType = new Option<FunderingHerstelType?>(FunderingHerstelTypeValueConverter.FromStringOrDefault(herstelTypeRawValue));
                            break;
                        case "droogstandRisico":
                            droogstandRisico = new Option<FunderingRisico?>(JsonSerializer.Deserialize<FunderingRisico>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "optrekkendVochtRisico":
                            optrekkendVochtRisico = new Option<FunderingRisico?>(JsonSerializer.Deserialize<FunderingRisico>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "bioInfectieRisico":
                            bioInfectieRisico = new Option<FunderingRisico?>(JsonSerializer.Deserialize<FunderingRisico>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "herstelkosten":
                            herstelkosten = new Option<double?>(utf8JsonReader.TokenType == JsonTokenType.Null ? (double?)null : utf8JsonReader.GetDouble());
                            break;
                        case "bron":
                            string? bronRawValue = utf8JsonReader.GetString();
                            if (bronRawValue != null)
                                bron = new Option<FunderingDataBron?>(FunderingDataBronValueConverter.FromStringOrDefault(bronRawValue));
                            break;
                        default:
                            break;
                    }
                }
            }

            if (typering.IsSet && typering.Value == null)
                throw new ArgumentNullException(nameof(typering), "Property is not nullable for class Funderingdata.");

            if (herstelType.IsSet && herstelType.Value == null)
                throw new ArgumentNullException(nameof(herstelType), "Property is not nullable for class Funderingdata.");

            if (droogstandRisico.IsSet && droogstandRisico.Value == null)
                throw new ArgumentNullException(nameof(droogstandRisico), "Property is not nullable for class Funderingdata.");

            if (optrekkendVochtRisico.IsSet && optrekkendVochtRisico.Value == null)
                throw new ArgumentNullException(nameof(optrekkendVochtRisico), "Property is not nullable for class Funderingdata.");

            if (bioInfectieRisico.IsSet && bioInfectieRisico.Value == null)
                throw new ArgumentNullException(nameof(bioInfectieRisico), "Property is not nullable for class Funderingdata.");

            if (bron.IsSet && bron.Value == null)
                throw new ArgumentNullException(nameof(bron), "Property is not nullable for class Funderingdata.");

            return new Funderingdata(typering, herstelType, droogstandRisico, optrekkendVochtRisico, bioInfectieRisico, herstelkosten, bron);
        }

        /// <summary>
        /// Serializes a <see cref="Funderingdata" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="funderingdata"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, Funderingdata funderingdata, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, funderingdata, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="Funderingdata" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="funderingdata"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, Funderingdata funderingdata, JsonSerializerOptions jsonSerializerOptions)
        {
            if (funderingdata.TyperingOption.IsSet && funderingdata.Typering == null)
                throw new ArgumentNullException(nameof(funderingdata.Typering), "Property is required for class Funderingdata.");

            if (funderingdata.DroogstandRisicoOption.IsSet && funderingdata.DroogstandRisico == null)
                throw new ArgumentNullException(nameof(funderingdata.DroogstandRisico), "Property is required for class Funderingdata.");

            if (funderingdata.OptrekkendVochtRisicoOption.IsSet && funderingdata.OptrekkendVochtRisico == null)
                throw new ArgumentNullException(nameof(funderingdata.OptrekkendVochtRisico), "Property is required for class Funderingdata.");

            if (funderingdata.BioInfectieRisicoOption.IsSet && funderingdata.BioInfectieRisico == null)
                throw new ArgumentNullException(nameof(funderingdata.BioInfectieRisico), "Property is required for class Funderingdata.");

            if (funderingdata.TyperingOption.IsSet)
            {
                writer.WritePropertyName("typering");
                JsonSerializer.Serialize(writer, funderingdata.Typering, jsonSerializerOptions);
            }
            if (funderingdata.HerstelTypeOption.IsSet)
            {
                var herstelTypeRawValue = FunderingHerstelTypeValueConverter.ToJsonValue(funderingdata.HerstelType!.Value);
                writer.WriteString("herstelType", herstelTypeRawValue);
            }
            if (funderingdata.DroogstandRisicoOption.IsSet)
            {
                writer.WritePropertyName("droogstandRisico");
                JsonSerializer.Serialize(writer, funderingdata.DroogstandRisico, jsonSerializerOptions);
            }
            if (funderingdata.OptrekkendVochtRisicoOption.IsSet)
            {
                writer.WritePropertyName("optrekkendVochtRisico");
                JsonSerializer.Serialize(writer, funderingdata.OptrekkendVochtRisico, jsonSerializerOptions);
            }
            if (funderingdata.BioInfectieRisicoOption.IsSet)
            {
                writer.WritePropertyName("bioInfectieRisico");
                JsonSerializer.Serialize(writer, funderingdata.BioInfectieRisico, jsonSerializerOptions);
            }
            if (funderingdata.HerstelkostenOption.IsSet)
                if (funderingdata.HerstelkostenOption.Value != null)
                    writer.WriteNumber("herstelkosten", funderingdata.HerstelkostenOption.Value!.Value);
                else
                    writer.WriteNull("herstelkosten");

            if (funderingdata.BronOption.IsSet)
            {
                var bronRawValue = FunderingDataBronValueConverter.ToJsonValue(funderingdata.Bron!.Value);
                writer.WriteString("bron", bronRawValue);
            }
        }
    }

    /// <summary>
    /// The FunderingdataSerializationContext
    /// </summary>
    [JsonSourceGenerationOptions(WriteIndented = true, GenerationMode = JsonSourceGenerationMode.Metadata | JsonSourceGenerationMode.Serialization)]
    [JsonSerializable(typeof(Funderingdata))]
    public partial class FunderingdataSerializationContext : JsonSerializerContext { }
}
