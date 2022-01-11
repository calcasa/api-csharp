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
 * Calcasa Public API v1
 *
 * The version of the OpenAPI document: 1.0.2
 * Contact: info@calcasa.nl
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Mime;
using Calcasa.Api.Client;
using Calcasa.Api.Model;

namespace Calcasa.Api.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IFunderingenApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Gegevens over de fundering op de locatie van een adres (BAG Nummeraanduiding ID).
        /// </summary>
        /// <remarks>
        /// Het funderingdata object zal gefilterd terug komen afhankelijk van het client_id wat gebruikt is voor de authenticatie.
        /// </remarks>
        /// <exception cref="Calcasa.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="bagNummeraanduidingId">Een BAG Nummeraanduiding ID om een adres te specificeren.</param>
        /// <returns>Funderingdata</returns>
        Funderingdata GetFunderingById(long bagNummeraanduidingId);

        /// <summary>
        /// Gegevens over de fundering op de locatie van een adres (BAG Nummeraanduiding ID).
        /// </summary>
        /// <remarks>
        /// Het funderingdata object zal gefilterd terug komen afhankelijk van het client_id wat gebruikt is voor de authenticatie.
        /// </remarks>
        /// <exception cref="Calcasa.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="bagNummeraanduidingId">Een BAG Nummeraanduiding ID om een adres te specificeren.</param>
        /// <returns>ApiResponse of Funderingdata</returns>
        ApiResponse<Funderingdata> GetFunderingByIdWithHttpInfo(long bagNummeraanduidingId);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IFunderingenApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Gegevens over de fundering op de locatie van een adres (BAG Nummeraanduiding ID).
        /// </summary>
        /// <remarks>
        /// Het funderingdata object zal gefilterd terug komen afhankelijk van het client_id wat gebruikt is voor de authenticatie.
        /// </remarks>
        /// <exception cref="Calcasa.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="bagNummeraanduidingId">Een BAG Nummeraanduiding ID om een adres te specificeren.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Funderingdata</returns>
        System.Threading.Tasks.Task<Funderingdata> GetFunderingByIdAsync(long bagNummeraanduidingId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Gegevens over de fundering op de locatie van een adres (BAG Nummeraanduiding ID).
        /// </summary>
        /// <remarks>
        /// Het funderingdata object zal gefilterd terug komen afhankelijk van het client_id wat gebruikt is voor de authenticatie.
        /// </remarks>
        /// <exception cref="Calcasa.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="bagNummeraanduidingId">Een BAG Nummeraanduiding ID om een adres te specificeren.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Funderingdata)</returns>
        System.Threading.Tasks.Task<ApiResponse<Funderingdata>> GetFunderingByIdWithHttpInfoAsync(long bagNummeraanduidingId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IFunderingenApi : IFunderingenApiSync, IFunderingenApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class FunderingenApi : IDisposable, IFunderingenApi
    {
        private Calcasa.Api.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="FunderingenApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <returns></returns>
        public FunderingenApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FunderingenApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="basePath">The target service's base path in URL format.</param>
        /// <exception cref="ArgumentException"></exception>
        /// <returns></returns>
        public FunderingenApi(string basePath)
        {
            this.Configuration = Calcasa.Api.Client.Configuration.MergeConfigurations(
                Calcasa.Api.Client.GlobalConfiguration.Instance,
                new Calcasa.Api.Client.Configuration { BasePath = basePath }
            );
            this.ApiClient = new Calcasa.Api.Client.ApiClient(this.Configuration.BasePath);
            this.Client =  this.ApiClient;
            this.AsynchronousClient = this.ApiClient;
            this.ExceptionFactory = Calcasa.Api.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FunderingenApi"/> class using Configuration object.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="configuration">An instance of Configuration.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        public FunderingenApi(Calcasa.Api.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = Calcasa.Api.Client.Configuration.MergeConfigurations(
                Calcasa.Api.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.ApiClient = new Calcasa.Api.Client.ApiClient(this.Configuration.BasePath);
            this.Client = this.ApiClient;
            this.AsynchronousClient = this.ApiClient;
            ExceptionFactory = Calcasa.Api.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FunderingenApi"/> class.
        /// </summary>
        /// <param name="client">An instance of HttpClient.</param>
        /// <param name="handler">An optional instance of HttpClientHandler that is used by HttpClient.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        /// <remarks>
        /// Some configuration settings will not be applied without passing an HttpClientHandler.
        /// The features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings.
        /// </remarks>
        public FunderingenApi(HttpClient client, HttpClientHandler handler = null) : this(client, (string)null, handler)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FunderingenApi"/> class.
        /// </summary>
        /// <param name="client">An instance of HttpClient.</param>
        /// <param name="basePath">The target service's base path in URL format.</param>
        /// <param name="handler">An optional instance of HttpClientHandler that is used by HttpClient.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentException"></exception>
        /// <returns></returns>
        /// <remarks>
        /// Some configuration settings will not be applied without passing an HttpClientHandler.
        /// The features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings.
        /// </remarks>
        public FunderingenApi(HttpClient client, string basePath, HttpClientHandler handler = null)
        {
            if (client == null) throw new ArgumentNullException("client");

            this.Configuration = Calcasa.Api.Client.Configuration.MergeConfigurations(
                Calcasa.Api.Client.GlobalConfiguration.Instance,
                new Calcasa.Api.Client.Configuration { BasePath = basePath }
            );
            this.ApiClient = new Calcasa.Api.Client.ApiClient(client, this.Configuration.BasePath, handler);
            this.Client =  this.ApiClient;
            this.AsynchronousClient = this.ApiClient;
            this.ExceptionFactory = Calcasa.Api.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FunderingenApi"/> class using Configuration object.
        /// </summary>
        /// <param name="client">An instance of HttpClient.</param>
        /// <param name="configuration">An instance of Configuration.</param>
        /// <param name="handler">An optional instance of HttpClientHandler that is used by HttpClient.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        /// <remarks>
        /// Some configuration settings will not be applied without passing an HttpClientHandler.
        /// The features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings.
        /// </remarks>
        public FunderingenApi(HttpClient client, Calcasa.Api.Client.Configuration configuration, HttpClientHandler handler = null)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");
            if (client == null) throw new ArgumentNullException("client");

            this.Configuration = Calcasa.Api.Client.Configuration.MergeConfigurations(
                Calcasa.Api.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.ApiClient = new Calcasa.Api.Client.ApiClient(client, this.Configuration.BasePath, handler);
            this.Client = this.ApiClient;
            this.AsynchronousClient = this.ApiClient;
            ExceptionFactory = Calcasa.Api.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FunderingenApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public FunderingenApi(Calcasa.Api.Client.ISynchronousClient client, Calcasa.Api.Client.IAsynchronousClient asyncClient, Calcasa.Api.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = Calcasa.Api.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Disposes resources if they were created by us
        /// </summary>
        public void Dispose()
        {
            this.ApiClient?.Dispose();
        }

        /// <summary>
        /// Holds the ApiClient if created
        /// </summary>
        public Calcasa.Api.Client.ApiClient ApiClient { get; set; } = null;

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public Calcasa.Api.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public Calcasa.Api.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Calcasa.Api.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Calcasa.Api.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gegevens over de fundering op de locatie van een adres (BAG Nummeraanduiding ID). Het funderingdata object zal gefilterd terug komen afhankelijk van het client_id wat gebruikt is voor de authenticatie.
        /// </summary>
        /// <exception cref="Calcasa.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="bagNummeraanduidingId">Een BAG Nummeraanduiding ID om een adres te specificeren.</param>
        /// <returns>Funderingdata</returns>
        public Funderingdata GetFunderingById(long bagNummeraanduidingId)
        {
            Calcasa.Api.Client.ApiResponse<Funderingdata> localVarResponse = GetFunderingByIdWithHttpInfo(bagNummeraanduidingId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Gegevens over de fundering op de locatie van een adres (BAG Nummeraanduiding ID). Het funderingdata object zal gefilterd terug komen afhankelijk van het client_id wat gebruikt is voor de authenticatie.
        /// </summary>
        /// <exception cref="Calcasa.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="bagNummeraanduidingId">Een BAG Nummeraanduiding ID om een adres te specificeren.</param>
        /// <returns>ApiResponse of Funderingdata</returns>
        public Calcasa.Api.Client.ApiResponse<Funderingdata> GetFunderingByIdWithHttpInfo(long bagNummeraanduidingId)
        {
            Calcasa.Api.Client.RequestOptions localVarRequestOptions = new Calcasa.Api.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/problem+json",
                "application/json"
            };

            var localVarContentType = Calcasa.Api.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Calcasa.Api.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("bagNummeraanduidingId", Calcasa.Api.Client.ClientUtils.ParameterToString(bagNummeraanduidingId)); // path parameter

            // authentication (oauth) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<Funderingdata>("/api/v1/funderingen/{bagNummeraanduidingId}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetFunderingById", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Gegevens over de fundering op de locatie van een adres (BAG Nummeraanduiding ID). Het funderingdata object zal gefilterd terug komen afhankelijk van het client_id wat gebruikt is voor de authenticatie.
        /// </summary>
        /// <exception cref="Calcasa.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="bagNummeraanduidingId">Een BAG Nummeraanduiding ID om een adres te specificeren.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Funderingdata</returns>
        public async System.Threading.Tasks.Task<Funderingdata> GetFunderingByIdAsync(long bagNummeraanduidingId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Calcasa.Api.Client.ApiResponse<Funderingdata> localVarResponse = await GetFunderingByIdWithHttpInfoAsync(bagNummeraanduidingId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Gegevens over de fundering op de locatie van een adres (BAG Nummeraanduiding ID). Het funderingdata object zal gefilterd terug komen afhankelijk van het client_id wat gebruikt is voor de authenticatie.
        /// </summary>
        /// <exception cref="Calcasa.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="bagNummeraanduidingId">Een BAG Nummeraanduiding ID om een adres te specificeren.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Funderingdata)</returns>
        public async System.Threading.Tasks.Task<Calcasa.Api.Client.ApiResponse<Funderingdata>> GetFunderingByIdWithHttpInfoAsync(long bagNummeraanduidingId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            Calcasa.Api.Client.RequestOptions localVarRequestOptions = new Calcasa.Api.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/problem+json",
                "application/json"
            };


            var localVarContentType = Calcasa.Api.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Calcasa.Api.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("bagNummeraanduidingId", Calcasa.Api.Client.ClientUtils.ParameterToString(bagNummeraanduidingId)); // path parameter

            // authentication (oauth) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<Funderingdata>("/api/v1/funderingen/{bagNummeraanduidingId}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetFunderingById", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}
