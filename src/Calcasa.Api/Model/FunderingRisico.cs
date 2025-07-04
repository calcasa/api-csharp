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
    /// Informatie over een bepaald funderingrisico.
    /// </summary>
    public partial class FunderingRisico
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FunderingRisico" /> class.
        /// </summary>
        /// <param name="label">label</param>
        /// <param name="bron">bron</param>
        /// <param name="omschrijving">De omschrijving van het risico.</param>
        [JsonConstructor]
        public FunderingRisico(Option<FunderingRisicoLabel?> label = default, Option<FunderingSoortBron?> bron = default, Option<string?> omschrijving = default)
        {
            LabelOption = label;
            BronOption = bron;
            OmschrijvingOption = omschrijving;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of Label
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<FunderingRisicoLabel?> LabelOption { get; private set; }

        /// <summary>
        /// Gets or Sets Label
        /// </summary>
        [JsonPropertyName("label")]
        public FunderingRisicoLabel? Label { get { return this.LabelOption; } set { this.LabelOption = new(value); } }

        /// <summary>
        /// Used to track the state of Bron
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<FunderingSoortBron?> BronOption { get; private set; }

        /// <summary>
        /// Gets or Sets Bron
        /// </summary>
        [JsonPropertyName("bron")]
        public FunderingSoortBron? Bron { get { return this.BronOption; } set { this.BronOption = new(value); } }

        /// <summary>
        /// Used to track the state of Omschrijving
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> OmschrijvingOption { get; private set; }

        /// <summary>
        /// De omschrijving van het risico.
        /// </summary>
        /// <value>De omschrijving van het risico.</value>
        [JsonPropertyName("omschrijving")]
        public string? Omschrijving { get { return this.OmschrijvingOption; } set { this.OmschrijvingOption = new(value); } }

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
            sb.Append("class FunderingRisico {\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
            sb.Append("  Bron: ").Append(Bron).Append("\n");
            sb.Append("  Omschrijving: ").Append(Omschrijving).Append("\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="FunderingRisico" />
    /// </summary>
    public class FunderingRisicoJsonConverter : JsonConverter<FunderingRisico>
    {
        /// <summary>
        /// Deserializes json to <see cref="FunderingRisico" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override FunderingRisico Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<FunderingRisicoLabel?> label = default;
            Option<FunderingSoortBron?> bron = default;
            Option<string?> omschrijving = default;

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
                        case "label":
                            string? labelRawValue = utf8JsonReader.GetString();
                            if (labelRawValue != null)
                                label = new Option<FunderingRisicoLabel?>(FunderingRisicoLabelValueConverter.FromStringOrDefault(labelRawValue));
                            break;
                        case "bron":
                            string? bronRawValue = utf8JsonReader.GetString();
                            if (bronRawValue != null)
                                bron = new Option<FunderingSoortBron?>(FunderingSoortBronValueConverter.FromStringOrDefault(bronRawValue));
                            break;
                        case "omschrijving":
                            omschrijving = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (label.IsSet && label.Value == null)
                throw new ArgumentNullException(nameof(label), "Property is not nullable for class FunderingRisico.");

            if (bron.IsSet && bron.Value == null)
                throw new ArgumentNullException(nameof(bron), "Property is not nullable for class FunderingRisico.");

            if (omschrijving.IsSet && omschrijving.Value == null)
                throw new ArgumentNullException(nameof(omschrijving), "Property is not nullable for class FunderingRisico.");

            return new FunderingRisico(label, bron, omschrijving);
        }

        /// <summary>
        /// Serializes a <see cref="FunderingRisico" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="funderingRisico"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, FunderingRisico funderingRisico, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, funderingRisico, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="FunderingRisico" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="funderingRisico"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, FunderingRisico funderingRisico, JsonSerializerOptions jsonSerializerOptions)
        {
            if (funderingRisico.OmschrijvingOption.IsSet && funderingRisico.Omschrijving == null)
                throw new ArgumentNullException(nameof(funderingRisico.Omschrijving), "Property is required for class FunderingRisico.");

            if (funderingRisico.LabelOption.IsSet)
            {
                var labelRawValue = FunderingRisicoLabelValueConverter.ToJsonValue(funderingRisico.Label!.Value);
                writer.WriteString("label", labelRawValue);
            }
            if (funderingRisico.BronOption.IsSet)
            {
                var bronRawValue = FunderingSoortBronValueConverter.ToJsonValue(funderingRisico.Bron!.Value);
                writer.WriteString("bron", bronRawValue);
            }
            if (funderingRisico.OmschrijvingOption.IsSet)
                writer.WriteString("omschrijving", funderingRisico.Omschrijving);
        }
    }

    /// <summary>
    /// The FunderingRisicoSerializationContext
    /// </summary>
    [JsonSourceGenerationOptions(WriteIndented = true, GenerationMode = JsonSourceGenerationMode.Metadata | JsonSourceGenerationMode.Serialization)]
    [JsonSerializable(typeof(FunderingRisico))]
    public partial class FunderingRisicoSerializationContext : JsonSerializerContext { }
}
