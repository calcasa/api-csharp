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
    /// Bron waar de funderingsinformatie opgehaald is. | Waarde | Omschrijving | | - -- | - -- | | &#x60;calcasa&#x60; | Calcasa data. | | &#x60;fundermaps&#x60; | Fundermaps data. |
    /// </summary>
    /// <value>Bron waar de funderingsinformatie opgehaald is. | Waarde | Omschrijving | | - -- | - -- | | &#x60;calcasa&#x60; | Calcasa data. | | &#x60;fundermaps&#x60; | Fundermaps data. |</value>
    public enum FunderingDataBron
    {
        /// <summary>
        /// Enum Calcasa for value: calcasa
        /// </summary>
        Calcasa,

        /// <summary>
        /// Enum Fundermaps for value: fundermaps
        /// </summary>
        Fundermaps
    }

    /// <summary>
    /// Converts <see cref="FunderingDataBron"/> to and from the JSON value
    /// </summary>
    public static class FunderingDataBronValueConverter
    {
        /// <summary>
        /// Parses a given value to <see cref="FunderingDataBron"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static FunderingDataBron FromString(string value)
        {
            if (value.Equals("calcasa"))
                return FunderingDataBron.Calcasa;

            if (value.Equals("fundermaps"))
                return FunderingDataBron.Fundermaps;

            throw new NotImplementedException($"Could not convert value to type FunderingDataBron: '{value}'");
        }

        /// <summary>
        /// Parses a given value to <see cref="FunderingDataBron"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static FunderingDataBron? FromStringOrDefault(string value)
        {
            if (value.Equals("calcasa"))
                return FunderingDataBron.Calcasa;

            if (value.Equals("fundermaps"))
                return FunderingDataBron.Fundermaps;

            return null;
        }

        /// <summary>
        /// Converts the <see cref="FunderingDataBron"/> to the json value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static string ToJsonValue(FunderingDataBron value)
        {
            if (value == FunderingDataBron.Calcasa)
                return "calcasa";

            if (value == FunderingDataBron.Fundermaps)
                return "fundermaps";

            throw new NotImplementedException($"Value could not be handled: '{value}'");
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="FunderingDataBron"/>
    /// </summary>
    /// <exception cref="NotImplementedException"></exception>
    public class FunderingDataBronJsonConverter : JsonConverter<FunderingDataBron>
    {
        /// <summary>
        /// Returns a  from the Json object
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public override FunderingDataBron Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string? rawValue = reader.GetString();

            FunderingDataBron? result = rawValue == null
                ? null
                : FunderingDataBronValueConverter.FromStringOrDefault(rawValue);

            if (result != null)
                return result.Value;

            throw new JsonException();
        }

        /// <summary>
        /// Writes the FunderingDataBron to the json writer
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="funderingDataBron"></param>
        /// <param name="options"></param>
        public override void Write(Utf8JsonWriter writer, FunderingDataBron funderingDataBron, JsonSerializerOptions options)
        {
            writer.WriteStringValue(funderingDataBron.ToString());
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="FunderingDataBron"/>
    /// </summary>
    public class FunderingDataBronNullableJsonConverter : JsonConverter<FunderingDataBron?>
    {
        /// <summary>
        /// Returns a FunderingDataBron from the Json object
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public override FunderingDataBron? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string? rawValue = reader.GetString();

            FunderingDataBron? result = rawValue == null
                ? null
                : FunderingDataBronValueConverter.FromStringOrDefault(rawValue);

            if (result != null)
                return result.Value;

            throw new JsonException();
        }

        /// <summary>
        /// Writes the DateTime to the json writer
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="funderingDataBron"></param>
        /// <param name="options"></param>
        public override void Write(Utf8JsonWriter writer, FunderingDataBron? funderingDataBron, JsonSerializerOptions options)
        {
            writer.WriteStringValue(funderingDataBron?.ToString() ?? "null");
        }
    }


    /// <summary>
    /// The FunderingDataBronSerializationContext
    /// </summary>
    [JsonSourceGenerationOptions(WriteIndented = true, GenerationMode = JsonSourceGenerationMode.Metadata | JsonSourceGenerationMode.Serialization)]
    [JsonSerializable(typeof(FunderingDataBron))]
    public partial class FunderingDataBronSerializationContext : JsonSerializerContext { }
}
