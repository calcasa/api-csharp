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
 * The version of the OpenAPI document: 1.1.5
 * Contact: info@calcasa.nl
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Calcasa.Api.Client
{

    /// <summary>
    /// Represents a File passed to the API as a Parameter, allows using different backends for files
    /// </summary>
    public class FileParameter
    {
        /// <summary>
        /// The filename
        /// </summary>
        public string Name { get; set; } = "no_name_provided";

        /// <summary>
        /// The content type of the file
        /// </summary>
        public string ContentType { get; set; } = "application/octet-stream";

        /// <summary>
        /// The content of the file
        /// </summary>
        public Stream Content { get; set; }

        /// <summary>
        /// Construct a FileParameter just from the contents, will extract the filename from a filestream
        /// </summary>
        /// <param name="content"> The file content </param>
        public FileParameter(Stream content)
        {
            if (content is FileStream fs)
            {
                Name = fs.Name;
            }
            Content = content;
        }

        /// <summary>
        /// Construct a FileParameter from name and content
        /// </summary>
        /// <param name="filename">The filename</param>
        /// <param name="content">The file content</param>
        public FileParameter(string filename, Stream content)
        {
            Name = filename;
            Content = content;
        }

        /// <summary>
        /// Construct a FileParameter from name and content
        /// </summary>
        /// <param name="filename">The filename</param>
        /// <param name="contentType">The content type of the file</param>
        /// <param name="content">The file content</param>
        public FileParameter(string filename, string contentType, Stream content)
        {
            Name = filename;
            ContentType = contentType;
            Content = content;
        }

        /// <summary>
        /// Implicit conversion of stream to file parameter. Useful for backwards compatibility.
        /// </summary>
        /// <param name="s">Stream to convert</param>
        /// <returns>FileParameter</returns>
        public static implicit operator FileParameter(Stream s) => new FileParameter(s);
    }

    public static class FileParameterExtensions
    {
        /// <summary>
        /// Construct a FileParameter from <see cref="HttpContent"/>
        /// </summary>
        /// <param name="httpContent">The HTTP Content object.</param>
        /// <returns>The constructed FileParamter object.</returns>
        public static async Task<FileParameter> ToFileParameter(this HttpContent httpContent)
        {
            var fp = new FileParameter(await httpContent.ReadAsStreamAsync());
            if (httpContent.Headers.ContentDisposition != null)
            {
                if (!string.IsNullOrWhiteSpace(httpContent.Headers.ContentDisposition.FileNameStar))
                {
                    fp.Name = httpContent.Headers.ContentDisposition.FileNameStar;
                } 
                else if (!string.IsNullOrWhiteSpace(httpContent.Headers.ContentDisposition.FileName))
                {
                    fp.Name = httpContent.Headers.ContentDisposition.FileName;
                }                
            }
            if (httpContent.Headers.ContentType != null)
            {
                fp.ContentType = httpContent.Headers.ContentType.ToString();
            }

            return fp;
        }
    }
}