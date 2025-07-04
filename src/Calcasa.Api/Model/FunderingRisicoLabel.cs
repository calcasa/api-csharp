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
    /// Indicatie voor een funderingsrisico. | Waarde | Omschrijving | | - -- | - -- | | &#x60;onbekend&#x60; | Risico klasse onbekend. | | &#x60;laag&#x60; | Laagste risico. | | &#x60;gemiddeld&#x60; | Gemiddeld risico. | | &#x60;hoog&#x60; | Hoogste risico. |
    /// </summary>
    /// <value>Indicatie voor een funderingsrisico. | Waarde | Omschrijving | | - -- | - -- | | &#x60;onbekend&#x60; | Risico klasse onbekend. | | &#x60;laag&#x60; | Laagste risico. | | &#x60;gemiddeld&#x60; | Gemiddeld risico. | | &#x60;hoog&#x60; | Hoogste risico. |</value>
    public enum FunderingRisicoLabel
    {
        /// <summary>
        /// Enum Onbekend for value: onbekend
        /// </summary>
        Onbekend,

        /// <summary>
        /// Enum Laag for value: laag
        /// </summary>
        Laag,

        /// <summary>
        /// Enum Gemiddeld for value: gemiddeld
        /// </summary>
        Gemiddeld,

        /// <summary>
        /// Enum Hoog for value: hoog
        /// </summary>
        Hoog
    }

    /// <summary>
    /// Converts <see cref="FunderingRisicoLabel"/> to and from the JSON value
    /// </summary>
    public static class FunderingRisicoLabelValueConverter
    {
        /// <summary>
        /// Parses a given value to <see cref="FunderingRisicoLabel"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static FunderingRisicoLabel FromString(string value)
        {
            if (value.Equals("onbekend"))
                return FunderingRisicoLabel.Onbekend;

            if (value.Equals("laag"))
                return FunderingRisicoLabel.Laag;

            if (value.Equals("gemiddeld"))
                return FunderingRisicoLabel.Gemiddeld;

            if (value.Equals("hoog"))
                return FunderingRisicoLabel.Hoog;

            throw new NotImplementedException($"Could not convert value to type FunderingRisicoLabel: '{value}'");
        }

        /// <summary>
        /// Parses a given value to <see cref="FunderingRisicoLabel"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static FunderingRisicoLabel? FromStringOrDefault(string value)
        {
            if (value.Equals("onbekend"))
                return FunderingRisicoLabel.Onbekend;

            if (value.Equals("laag"))
                return FunderingRisicoLabel.Laag;

            if (value.Equals("gemiddeld"))
                return FunderingRisicoLabel.Gemiddeld;

            if (value.Equals("hoog"))
                return FunderingRisicoLabel.Hoog;

            return null;
        }

        /// <summary>
        /// Converts the <see cref="FunderingRisicoLabel"/> to the json value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static string ToJsonValue(FunderingRisicoLabel value)
        {
            if (value == FunderingRisicoLabel.Onbekend)
                return "onbekend";

            if (value == FunderingRisicoLabel.Laag)
                return "laag";

            if (value == FunderingRisicoLabel.Gemiddeld)
                return "gemiddeld";

            if (value == FunderingRisicoLabel.Hoog)
                return "hoog";

            throw new NotImplementedException($"Value could not be handled: '{value}'");
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="FunderingRisicoLabel"/>
    /// </summary>
    /// <exception cref="NotImplementedException"></exception>
    public class FunderingRisicoLabelJsonConverter : JsonConverter<FunderingRisicoLabel>
    {
        /// <summary>
        /// Returns a  from the Json object
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public override FunderingRisicoLabel Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string? rawValue = reader.GetString();

            FunderingRisicoLabel? result = rawValue == null
                ? null
                : FunderingRisicoLabelValueConverter.FromStringOrDefault(rawValue);

            if (result != null)
                return result.Value;

            throw new JsonException();
        }

        /// <summary>
        /// Writes the FunderingRisicoLabel to the json writer
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="funderingRisicoLabel"></param>
        /// <param name="options"></param>
        public override void Write(Utf8JsonWriter writer, FunderingRisicoLabel funderingRisicoLabel, JsonSerializerOptions options)
        {
            writer.WriteStringValue(funderingRisicoLabel.ToString());
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="FunderingRisicoLabel"/>
    /// </summary>
    public class FunderingRisicoLabelNullableJsonConverter : JsonConverter<FunderingRisicoLabel?>
    {
        /// <summary>
        /// Returns a FunderingRisicoLabel from the Json object
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public override FunderingRisicoLabel? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string? rawValue = reader.GetString();

            FunderingRisicoLabel? result = rawValue == null
                ? null
                : FunderingRisicoLabelValueConverter.FromStringOrDefault(rawValue);

            if (result != null)
                return result.Value;

            throw new JsonException();
        }

        /// <summary>
        /// Writes the DateTime to the json writer
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="funderingRisicoLabel"></param>
        /// <param name="options"></param>
        public override void Write(Utf8JsonWriter writer, FunderingRisicoLabel? funderingRisicoLabel, JsonSerializerOptions options)
        {
            writer.WriteStringValue(funderingRisicoLabel?.ToString() ?? "null");
        }
    }


    /// <summary>
    /// The FunderingRisicoLabelSerializationContext
    /// </summary>
    [JsonSourceGenerationOptions(WriteIndented = true, GenerationMode = JsonSourceGenerationMode.Metadata | JsonSourceGenerationMode.Serialization)]
    [JsonSerializable(typeof(FunderingRisicoLabel))]
    public partial class FunderingRisicoLabelSerializationContext : JsonSerializerContext { }
}
