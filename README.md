# Calcasa.Api - the C# library for the Calcasa Public API

This is a preliminary version of the Calcasa Public API. This service is currently in development.

## Changelog

### 2021-11-11
- Renamed /fundering endpoint to /funderingen to be more in line with other endpoints
- Renamed `HerstelType` to `FunderingHerstelType`.
- Added `FunderingType` values.

### 2021-11-10
- Adjusted OpenAPI Spec generation to fix some issues with certain generators. This also means that the nullable nature of certain fields is now correctly represented. Please refer to the Generation article for more information, the config files were updated aswell.
### 2021-11-09
- Added `Status` and `Taxatiedatum` to `Taxatiedata` model.

### 2021-11-08

- Renamed `id` field in `AdresInfo` model to `bagNummeraanduidingId`.
- Added `GET /v0/fundering/{id}` endpoint with corresponding models.
- Changed HTTP response code for the `BusinessRulesProblemDetails` error return type of `POST /v0/waardering` from `422 Unprocessable Entity` to `406 Not Acceptable` to fix a duplicate.

### 2021-10-13

- Added `taxatie` field to `Waardering` model.
- Added `Taxatiedata` model containing the `taxatieorganisatie` field for desktop valuations.

### 2021-09-29

- Added `aangemaakt` timestamp field to `Waardering` model.
- Added `WaarderingZoekParameters` model to replace `WaarderingInputParameters` in the `POST /v0/waarderingen/zoeken` endpoint.
- Split `Omgevingsdata` model into a set of separate `Gebiedsdata` models that also contain extra statistics.
- Added `bijzonderheden` field to `VorigeVerkoop` model.
- Renamed `ReferentieBijzonderheden` model to `VerkoopBijzonderheden`.

### 2021-09-22

- Initial release of v0

## Client packages
![Nuget](https://img.shields.io/nuget/v/Calcasa.Api?label=Nuget) - ![Packagist Downloads](https://img.shields.io/packagist/v/calcasa/api?label=Packagist) - ![PyPI - Downloads](https://img.shields.io/pypi/v/calcasa-api?label=PyPi)
## Client implementation notes
Clients should at all times be tolerant to the following:

- Extra fields in responses
- Empty or hidden fields in responses
- Extra values in enumerations
- Unexpected error responses in the form of [Problem Details](https://rfc-editor.org/rfc/rfc7807)

## OpenAPI Specification
This API is documented in **OpenAPI format version 3** you can use tools like the [OpenAPI Generator](https://github.com/OpenAPITools/openapi-generator) to generate API clients.

## Cross-Origin Resource Sharing
This API features Cross-Origin Resource Sharing (CORS) implemented in compliance with [W3C spec](https://www.w3.org/TR/cors/).
And that allows cross-domain communication from the browser.
All responses have a wildcard same-origin which makes them completely public and accessible to everyone, including any code on any site.

## Authentication

Authentication is done via [OAuth2](https://oauth.net/2/) and the [client credentials](https://oauth.net/2/grant-types/client-credentials/) grant type.


This C# SDK is automatically generated by the [OpenAPI Generator](https://openapi-generator.tech) project:

- API version: v0
- SDK version: 0.0.2
- Build package: org.openapitools.codegen.languages.CSharpNetCoreClientCodegen
    For more information, please visit [https://www.calcasa.nl/contact](https://www.calcasa.nl/contact)

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET Core >=1.0
- .NET Framework >=4.6
- Mono/Xamarin >=vNext

<a name="dependencies"></a>
## Dependencies

- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 12.0.3 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.8.0 or later
- [System.ComponentModel.Annotations](https://www.nuget.org/packages/System.ComponentModel.Annotations) - 5.0.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
Install-Package System.ComponentModel.Annotations
```
<a name="installation"></a>
## Installation
Generate the DLL using your preferred tool (e.g. `dotnet build`)

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using Calcasa.Api.Api;
using Calcasa.Api.Client;
using Calcasa.Api.Model;
```
<a name="usage"></a>
## Usage

To use the API client with a HTTP proxy, setup a `System.Net.WebProxy`
```csharp
Configuration c = new Configuration();
System.Net.WebProxy webProxy = new System.Net.WebProxy("http://myProxyUrl:80/");
webProxy.Credentials = System.Net.CredentialCache.DefaultCredentials;
c.Proxy = webProxy;
```

### Connections
Each ApiClass (properly the ApiClient inside it) will create an instance of HttpClient. It will use that for the entire lifecycle and dispose it when called the Dispose method.

To better manager the connections it's a common practice to reuse the HttpClient and HttpClientHandler (see [here](https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net) for details). To use your own HttpClient instance just pass it to the ApiClass constructor.

```csharp
HttpClientHandler yourHandler = new HttpClientHandler();
HttpClient yourHttpClient = new HttpClient(yourHandler);
var api = new YourApiClass(yourHttpClient, yourHandler);
```

If you want to use an HttpClient and don't have access to the handler, for example in a DI context in Asp.net Core when using IHttpClientFactory.

```csharp
HttpClient yourHttpClient = new HttpClient();
var api = new YourApiClass(yourHttpClient);
```
You'll loose some configuration settings, the features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings. You need to either manually handle those in your setup of the HttpClient or they won't be available.

Here an example of DI setup in a sample web project:

```csharp
services.AddHttpClient<YourApiClass>(httpClient =>
   new PetApi(httpClient));
```


<a name="getting-started"></a>
## Getting Started

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Calcasa.Api.Api;
using Calcasa.Api.Client;
using Calcasa.Api.Model;

namespace Example
{
    public class Example
    {
        public static void Main()
        {

            Configuration config = new Configuration();
            config.BasePath = "https://api.calcasa.nl";
            // Configure OAuth2 access token for authorization: oauth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new AdressenApi(httpClient, config, httpClientHandler);
            var bagNummeraanduidingId = 789;  // long | 

            try
            {
                // Adres info op met het BAG Nummeraanduiding Id.
                AdresInfo result = apiInstance.GetAdres(bagNummeraanduidingId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AdressenApi.GetAdres: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }

        }
    }
}
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://api.calcasa.nl*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*AdressenApi* | [**GetAdres**](docs/AdressenApi.md#getadres) | **GET** /api/v0/adressen/{bagNummeraanduidingId} | Adres info op met het BAG Nummeraanduiding Id.
*AdressenApi* | [**SearchAdres**](docs/AdressenApi.md#searchadres) | **POST** /api/v0/adressen/zoeken | Zoek adres info op basis van het gegeven adres.
*BestemmingsplannenApi* | [**GetBestemmingById**](docs/BestemmingsplannenApi.md#getbestemmingbyid) | **GET** /api/v0/bestemmingsplannen/{id} | Gegevens over de bestemmingsplannen op de locatie van een adres (BAG Nummeraanduiding ID).
*BodemApi* | [**GetBodemById**](docs/BodemApi.md#getbodembyid) | **GET** /api/v0/bodem/{id} | Gegevens over de bodemkwaliteit op de locatie van een adres (BAG Nummeraanduiding ID).
*BuurtApi* | [**GetBuurt**](docs/BuurtApi.md#getbuurt) | **GET** /api/v0/buurt/{id} | Gegevens over een buurt en de wijk, gemeente en land waarin deze buurt gesitueerd is.
*FacturenApi* | [**GetFactuur**](docs/FacturenApi.md#getfactuur) | **GET** /api/v0/facturen/{id} | Factuur op basis van een Id.
*FotosApi* | [**GetFoto**](docs/FotosApi.md#getfoto) | **GET** /api/v0/fotos/{id} | Foto op basis van Id.
*FunderingenApi* | [**GetFunderingById**](docs/FunderingenApi.md#getfunderingbyid) | **GET** /api/v0/funderingen/{id} | Gegevens over de fundering op de locatie van een adres (BAG Nummeraanduiding ID).
*RapportenApi* | [**GetRapport**](docs/RapportenApi.md#getrapport) | **GET** /api/v0/rapporten/{id} | Rapport op basis van Id.
*WaarderingenApi* | [**CreateWaardering**](docs/WaarderingenApi.md#createwaardering) | **POST** /api/v0/waarderingen | Creërt een waardering.
*WaarderingenApi* | [**GetWaardering**](docs/WaarderingenApi.md#getwaardering) | **GET** /api/v0/waarderingen/{id} | Waardering op basis van Id.
*WaarderingenApi* | [**GetWaarderingOntwikkeling**](docs/WaarderingenApi.md#getwaarderingontwikkeling) | **GET** /api/v0/waarderingen/{id}/ontwikkeling | Waardering ontwikkeling op basis van Id.
*WaarderingenApi* | [**PatchWaarderingen**](docs/WaarderingenApi.md#patchwaarderingen) | **PATCH** /api/v0/waarderingen/{id} | Patcht een waardering.
*WaarderingenApi* | [**SearchWaarderingen**](docs/WaarderingenApi.md#searchwaarderingen) | **POST** /api/v0/waarderingen/zoeken | Zoek waardering op basis van input parameters.


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.Aanvraagdoel](docs/Aanvraagdoel.md)
 - [Model.Adres](docs/Adres.md)
 - [Model.AdresInfo](docs/AdresInfo.md)
 - [Model.Bestemmingsdata](docs/Bestemmingsdata.md)
 - [Model.BodemStatusType](docs/BodemStatusType.md)
 - [Model.Bodemdata](docs/Bodemdata.md)
 - [Model.BusinessRulesCode](docs/BusinessRulesCode.md)
 - [Model.BusinessRulesProblemDetails](docs/BusinessRulesProblemDetails.md)
 - [Model.CbsIndeling](docs/CbsIndeling.md)
 - [Model.Energielabel](docs/Energielabel.md)
 - [Model.Factuur](docs/Factuur.md)
 - [Model.Foto](docs/Foto.md)
 - [Model.FunderingDataBron](docs/FunderingDataBron.md)
 - [Model.FunderingHerstelType](docs/FunderingHerstelType.md)
 - [Model.FunderingRisico](docs/FunderingRisico.md)
 - [Model.FunderingRisicoLabel](docs/FunderingRisicoLabel.md)
 - [Model.FunderingSoortBron](docs/FunderingSoortBron.md)
 - [Model.FunderingType](docs/FunderingType.md)
 - [Model.FunderingTypering](docs/FunderingTypering.md)
 - [Model.Funderingdata](docs/Funderingdata.md)
 - [Model.Gebiedsdata](docs/Gebiedsdata.md)
 - [Model.InvalidArgumentProblemDetails](docs/InvalidArgumentProblemDetails.md)
 - [Model.JsonPatchDocument](docs/JsonPatchDocument.md)
 - [Model.KlantwaardeType](docs/KlantwaardeType.md)
 - [Model.Kwartaal](docs/Kwartaal.md)
 - [Model.Modeldata](docs/Modeldata.md)
 - [Model.NotFoundProblemDetails](docs/NotFoundProblemDetails.md)
 - [Model.Notitie](docs/Notitie.md)
 - [Model.Notities](docs/Notities.md)
 - [Model.Objectdata](docs/Objectdata.md)
 - [Model.Omgevingsdata](docs/Omgevingsdata.md)
 - [Model.Operation](docs/Operation.md)
 - [Model.OperationType](docs/OperationType.md)
 - [Model.PermissionsDeniedProblemDetails](docs/PermissionsDeniedProblemDetails.md)
 - [Model.ProblemDetails](docs/ProblemDetails.md)
 - [Model.ProductType](docs/ProductType.md)
 - [Model.Rapport](docs/Rapport.md)
 - [Model.Referentieobject](docs/Referentieobject.md)
 - [Model.Taxatiedata](docs/Taxatiedata.md)
 - [Model.Taxatiestatus](docs/Taxatiestatus.md)
 - [Model.ValidationProblemDetails](docs/ValidationProblemDetails.md)
 - [Model.VerkoopBijzonderheden](docs/VerkoopBijzonderheden.md)
 - [Model.VorigeVerkoop](docs/VorigeVerkoop.md)
 - [Model.Waardering](docs/Waardering.md)
 - [Model.WaarderingInputParameters](docs/WaarderingInputParameters.md)
 - [Model.WaarderingOntwikkeling](docs/WaarderingOntwikkeling.md)
 - [Model.WaarderingOntwikkelingKwartaal](docs/WaarderingOntwikkelingKwartaal.md)
 - [Model.WaarderingStatus](docs/WaarderingStatus.md)
 - [Model.WaarderingWebhookPayload](docs/WaarderingWebhookPayload.md)
 - [Model.WaarderingZoekParameters](docs/WaarderingZoekParameters.md)
 - [Model.WoningType](docs/WoningType.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="oauth"></a>
### oauth

- **Type**: OAuth
- **Flow**: application
- **Authorization URL**: 
- **Scopes**: 
  - api:all: Full permissions for all areas of the public API
  - api:waarderingen:all: Full permissions for the valuations area of the public API
  - api:rapporten:all: Full permissions for the reports area of the public API
  - api:facturen:all: Full permissions for the invoices area of the public API
  - api:adressen:all: Full permissions for the addresses area of the public API
  - api:fotos:all: Full permissions for the photos area of the public API

