# Calcasa.Api - the C# library for the Calcasa Public API v1

The Calcasa API is used to connect to Calcasa provided services. This is the first production version of the service

## Client packages
[Nuget](https://www.nuget.org/packages/Calcasa.Api) - [Packagist](https://packagist.org/packages/calcasa/api) - [PyPI](https://pypi.org/project/calcasa.api)
## Client implementation notes
Clients should at all times be tolerant to the following:

- Extra fields in responses
- Empty or hidden fields in responses
- Extra values in enumerations
- Unexpected error responses in the form of [Problem Details](https://rfc-editor.org/rfc/rfc7807)

## OpenAPI Specification
This API is documented in **OpenAPI format version 3** you can use tools like the [OpenAPI Generator](https://github.com/OpenAPITools/openapi-generator) to generate API clients for for example the languages we don't provide a pre-built client for. This is documented [here](/api/v1/articles/clients/generation).

## Changelog

### 2023-10-24 (v1.3.0)
- Add `geldverstrekker` field to the `CallbackInschrijving` model.
- Add support for mTLS on the callback service.
    - By default when requested by the target server the public CA signed TLS certificate with the appropriate domain as Common Name will be offered as the client certificate. 
    - Public TLS Certificates rotate every couple of months.
- Change a couple of `date-time` fields that only contained a date to pure `date` fields. This might result is a different type in the generated clients and the service-side validation will be more strict. Times included in values will no longer be silently dropped, but will generate an error.
    - Change `Modeldata` model `waardebepalingsdatum` field to type `date` in OpenAPI spec.
    - Change `Bestemmingsdata` model `datumBestemmingplan` field to type `date` in OpenAPI spec.
    - Change `Bodemdata` model `datumLaatsteOnderzoek` field to type `date` in OpenAPI spec.
    - Change `Referentieobject` model `verkoopdatum` field to type `date` in OpenAPI spec.
    - Change `VorigeVerkoop` model `verkoopdatum` field to type `date` in OpenAPI spec.
    - Change `waarderingInputParameters` model `peildatum` field to type `date` in OpenAPI spec. This is an input field and will now require a date without a time.
- Add `desktopTaxatieHerwaardering` product to enumeration `ProductType`.
- The service no longer returns CORS headers.
- Actions now correctly report the 'application/problem+json' Content-Type in the documentation for the `HTTP 422 Unprocessable Entity` responses.
- Added `energielabelData` field to `Objectdata` model to contain the extra information about the energy label.
- The OpenAPI spec generation was changed slightly and thus the generated and published clients might be affected. There might be some slight breaking changes at compile time, but the functionality remains the same.
    - For example for C# and PHP `AdresInfoAdres` is now just covered by `Adres`
    - Likewise for the `Omgevingsdata*` models that are now all covered by `Gebiedsdata`
    - For a lot of the `Waardering*` models they are now using the correct model names, like `WaarderingModel` -> `Modeldata`


### 2023-04-17 (v1.2.1)
- Add `externeReferentie` field to the `CallbackInschrijving` and `WaarderingWebhookPayload` models.

### 2022-08-04 (v1.2.0)
- Add support for managing `CallbackSubscription`'s, this allows you to subscribe to callbacks for valuations that were not created with your API client.
    - `GET /v1/callbacks/inschrijvingen`
    - `POST /v1/callbacks/inschrijvingen`
    - `GET /v1/callbacks/inschrijvingen/{bagNummeraanduidingId}`
    - `DELETE /v1/callbacks/inschrijvingen/{bagNummeraanduidingId}`
- Add `taxateurnaam` field to the `Taxatiedata` model.
- Callback URIs should now end in `/` not just contain it to help stop common errors (ending in `=` is also still allowed when using a query string).
- Updating configuration in the `POST /v1/configuratie/callbacks` endpoint now clears stored but decommissioned versions from the configuration object.
- Add `klantkenmerk` to the `WaarderingInputParameters` and `Waardering` models.

### 2022-07-12 (v1.1.7)
- Added support for the OAuth 2.0 authorization code flow for use of the API with user accounts.
- Add `bouweenheid` to `FunderingSoortBron` enumeration.

### 2022-05-19 (v1.1.6)
- Added `ltvTeHoogOverbrugging` value to the `BusinessRulesCode` enumeration.

### 2022-04-13 (v1.1.5)
- Fix the schema for `Operation` `value` field for the benefit of the PHP and Python code generators, these will now correctly support any value type.

### 2022-04-12 (v1.1.4)
- Added proper Content-Disposition headers to the `GET /v1/rapporten/{id}` and `GET /v1/facturen/{id}` endpoints with the correct filename.
- Fix Mime Types for the `POST /v1/configuratie/callbacks` endpoint to only accept `application/json`.
- Fix C# API client to correctly use the `application/json-patch+json` content type in requests that require it.
- Fix C# client's `FileParameter` type correct handling of response headers like `Content-Disposition` and `Content-Type`.
- Removed C# client's useless implementation of `IValidatableObject`.
- Fix Python client's internal namespace name being illegal `calcasa-api` -> `calcasa.api`.

### 2022-03-22 (v1.1.3)
- Add 402 (Payment required) and 422 (Unprocessable entity) as potential response for `PATCH /v1/waarderingen/{id}`.

### 2022-03-17 (v1.1.2)
- Fixed response type for `GET /v1/geldverstrekkers/{productType}` endpoint.

### 2022-03-08 (v1.1.1)
- Added `GET /v1/geldverstrekkers/{productType}` endpoint.
- Restored all `ProblemDetails` models.

### 2022-03-07 (v1.1.0)
- Added `isErfpacht` to `WaarderingInputParameters`.
- Cleaned up serialization of null values, they should no longer appear in the output.

### 2021-02-04
- Added extra clarification to the documentation pertaining to the `WaarderingInputParameters` and which fields are required for the different input parameter combinations.

### 2022-01-11 (v1.0.2)
- Fixed `GET /api/v1/bodem/{id}` endpoint path parameter description, query parameter was never meant to be there.

### 2021-12-23
- Clarified the documentation pertaining to the `WaarderingInputParameters` and which fields are required for the different product types.

### 2021-12-22 (v1.0.1)
- Dates are now serialized in the ISO date-only format `yyyy-MM-dd` to stop any confusion around timezones and are all assumed to be in UTC.
    - `peildatum` in `WaarderingsInputParameters`
    - `datum_bestemmingplan` in `Bestemmingsdata`
    - `datum_laatste_onderzoek` in `Bodemdata`
    - `verkoopdatum` in `Referentieobject`
    - `verkoopdatum` in `VorigeVerkoop`
    - `waardebepalingsdatum` in `Modeldata`
- Reintroduced the `WaarderingWebhookPayload` model that was omitted.

### 2021-12-21
- Patching the status of a `Waardering` object will now immediatly reflect its new status in the response object.

### 2021-12-13 (v1.0.0)
- Initial release of `v1` based on `v0.0.6`

## Cross-Origin Resource Sharing
This API features Cross-Origin Resource Sharing (CORS) implemented in compliance with [W3C spec](https://www.w3.org/TR/cors/).
And that allows cross-domain communication from the browser.
All responses have a wildcard same-origin which makes them completely public and accessible to everyone, including any code on any site.

## Authentication
Authentication is done via [OAuth2](https://oauth.net/2/) and the [client credentials](https://oauth.net/2/grant-types/client-credentials/) grant type.

## Previous versions changelogs

### 2022-02-02
- API version `v0` was removed from service.

### 2021-12-23
- Mark `v0` as officially deprecated. No further versions will be released. Every implementation should move to `v1`

### 2021-12-10 (v0.0.6)
- Added extra field `peildatum` to the `WaarderingInputParameters` model.

### 2021-11-25 (v0.0.5)
- Updated all reported OAuth2 scopes and reduced the superflous scope information on each endpoint.

### 2021-11-23 (v0.0.4)
- Added per square meter developments to the `WaarderingOntwikkeling` object (fields with the `PerVierkantemeter` suffix).

### 2021-11-15 (v0.0.3)
- Added callback update and read endpoints and models.
- Updated documentation.

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
- Initial release of `v0`

This C# SDK is automatically generated by the [OpenAPI Generator](https://openapi-generator.tech) project:

- API version: 1.3.0
- SDK version: 1.3.0
- Build package: org.openapitools.codegen.languages.CSharpNetCoreClientCodegen
    For more information, please visit [https://www.calcasa.nl/contact](https://www.calcasa.nl/contact)

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET Core >=1.0
- .NET Framework >=4.6
- Mono/Xamarin >=vNext

<a name="dependencies"></a>
## Dependencies

- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 13.0.1 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.8.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
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
            // Configure OAuth2 access token for authorization: oauth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new AdressenApi(httpClient, config, httpClientHandler);
            var bagNummeraanduidingId = 789L;  // long | Een BAG Nummeraanduiding ID om een adres te specificeren.

            try
            {
                // Adres info op basis van BAG Nummeraanduiding Id.
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
*AdressenApi* | [**GetAdres**](docs/AdressenApi.md#getadres) | **GET** /api/v1/adressen/{bagNummeraanduidingId} | Adres info op basis van BAG Nummeraanduiding Id.
*AdressenApi* | [**SearchAdres**](docs/AdressenApi.md#searchadres) | **POST** /api/v1/adressen/zoeken | Zoek adres info op basis van het gegeven adres.
*BestemmingsplannenApi* | [**GetBestemmingById**](docs/BestemmingsplannenApi.md#getbestemmingbyid) | **GET** /api/v1/bestemmingsplannen/{bagNummeraanduidingId} | Gegevens over de bestemmingsplannen op de locatie van een adres (BAG Nummeraanduiding ID).
*BodemApi* | [**GetBodemById**](docs/BodemApi.md#getbodembyid) | **GET** /api/v1/bodem/{bagNummeraanduidingId} | Gegevens over de bodemkwaliteit op de locatie van een adres (BAG Nummeraanduiding ID).
*BuurtApi* | [**GetBuurt**](docs/BuurtApi.md#getbuurt) | **GET** /api/v1/buurt/{buurtId} | Gegevens over een buurt en de wijk, gemeente en land waarin deze buurt gesitueerd is.
*CallbacksApi* | [**AddOrUpdateCallbackSubscription**](docs/CallbacksApi.md#addorupdatecallbacksubscription) | **POST** /api/v1/callbacks/inschrijvingen | Voeg een callback inschrijving toe (of werk bij) voor de huidige client voor een adres.
*CallbacksApi* | [**DeleteNotificationSubscription**](docs/CallbacksApi.md#deletenotificationsubscription) | **DELETE** /api/v1/callbacks/inschrijvingen/{bagNummeraanduidingId} | Verwijder de callback inschrijving voor deze client, dit adres en optioneel een geldverstrekker.
*CallbacksApi* | [**GetNotificationSubscription**](docs/CallbacksApi.md#getnotificationsubscription) | **GET** /api/v1/callbacks/inschrijvingen/{bagNummeraanduidingId} | Haal de callback inschrijving op voor deze client, dit adres en eventueel opgegeven geldverstrekker.
*CallbacksApi* | [**GetNotificationSubscriptions**](docs/CallbacksApi.md#getnotificationsubscriptions) | **GET** /api/v1/callbacks/inschrijvingen | Haal de callback inschrijvingen binnen voor deze client.
*ConfiguratieApi* | [**GetCallbacks**](docs/ConfiguratieApi.md#getcallbacks) | **GET** /api/v1/configuratie/callbacks | Haal de geconfigureerde callback URL's op voor de huidige client.
*ConfiguratieApi* | [**UpdateCallbacks**](docs/ConfiguratieApi.md#updatecallbacks) | **POST** /api/v1/configuratie/callbacks | Configureer callback URL voor een specifieke API versie voor de huidige client.
*FacturenApi* | [**GetFactuur**](docs/FacturenApi.md#getfactuur) | **GET** /api/v1/facturen/{id} | Factuur op basis van een waardering Id.
*FotosApi* | [**GetFoto**](docs/FotosApi.md#getfoto) | **GET** /api/v1/fotos/{id} | Foto op basis van een foto Id.
*FunderingenApi* | [**GetFunderingById**](docs/FunderingenApi.md#getfunderingbyid) | **GET** /api/v1/funderingen/{bagNummeraanduidingId} | Gegevens over de fundering op de locatie van een adres (BAG Nummeraanduiding ID).
*GeldverstrekkersApi* | [**GetGeldverstrekkers**](docs/GeldverstrekkersApi.md#getgeldverstrekkers) | **GET** /api/v1/geldverstrekkers/{productType} | Alle geldverstrekkers die te gebruiken zijn voor aanvragen.
*RapportenApi* | [**GetRapport**](docs/RapportenApi.md#getrapport) | **GET** /api/v1/rapporten/{id} | Rapport op basis van waardering Id.
*WaarderingenApi* | [**CreateWaardering**](docs/WaarderingenApi.md#createwaardering) | **POST** /api/v1/waarderingen | Creërt een waardering.
*WaarderingenApi* | [**GetWaardering**](docs/WaarderingenApi.md#getwaardering) | **GET** /api/v1/waarderingen/{id} | Waardering op basis van Id.
*WaarderingenApi* | [**GetWaarderingOntwikkeling**](docs/WaarderingenApi.md#getwaarderingontwikkeling) | **GET** /api/v1/waarderingen/{id}/ontwikkeling | Waardering ontwikkeling op basis van waardering Id.
*WaarderingenApi* | [**PatchWaarderingen**](docs/WaarderingenApi.md#patchwaarderingen) | **PATCH** /api/v1/waarderingen/{id} | Patcht een waardering.
*WaarderingenApi* | [**SearchWaarderingen**](docs/WaarderingenApi.md#searchwaarderingen) | **POST** /api/v1/waarderingen/zoeken | Zoek waardering op basis van input parameters.


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
 - [Model.Callback](docs/Callback.md)
 - [Model.CallbackInschrijving](docs/CallbackInschrijving.md)
 - [Model.CbsIndeling](docs/CbsIndeling.md)
 - [Model.Energielabel](docs/Energielabel.md)
 - [Model.EnergielabelData](docs/EnergielabelData.md)
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
 - [Model.Geldverstrekker](docs/Geldverstrekker.md)
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
 - [Model.ResourceExhaustedProblemDetails](docs/ResourceExhaustedProblemDetails.md)
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
  - all: Full permissions for all areas.
  - api:all: Full permissions for all areas of the public API.
  - api:bestemmingsplannen:all: Full permissions for the bestemmingsplannen area of the public API.
  - api:bodem:all: Full permissions for the bodem area of the public API.
  - api:buurt:all: Full permissions for the buurt area of the public API.
  - api:configuratie:all: Full permissions for the configuratie area of the public API.
  - api:callback:all: Full permissions for the callback area of the public API.
  - api:facturen:all: Full permissions for the facturen area of the public API.
  - api:fotos:all: Full permissions for the fotos area of the public API.
  - api:funderingen:all: Full permissions for the funderingen area of the public API.
  - api:rapporten:all: Full permissions for the rapporten area of the public API.
  - api:waarderingen:all: Full permissions for the waarderingen area of the public API.
  - api:adressen:read: Read permissions for the adressen area of the public API.
  - api:bestemmingsplannen:read: Read permissions for the bestemmingsplannen area of the public API.
  - api:bodem:read: Read permissions for the bodem area of the public API.
  - api:buurt:read: Read permissions for the buurt area of the public API.
  - api:configuratie:read: Read permissions for the configuratie area of the public API.
  - api:configuratie:write: Write permissions for the configuratie area of the public API.
  - api:callback:read: Read permissions for the callback area of the public API.
  - api:callback:write: Write permissions for the callback area of the public API.
  - api:facturen:read: Read permissions for the facturen area of the public API.
  - api:fotos:read: Read permissions for the fotos area of the public API.
  - api:funderingen:read: Read permissions for the funderingen area of the public API.
  - api:geldverstrekkers:read: Read permissions for the geldverstrekkers area of the public API.
  - api:rapporten:read: Read permissions for the rapporten area of the public API.
  - api:waarderingen:create: Create permissions for the waarderingen area of the public API.
  - api:waarderingen:patch: Patch permissions for the waarderingen area of the public API.
  - api:waarderingen:read: Read permissions for the waarderingen area of the public API.
  - api:waarderingen:ontwikkeling: Read permissions for the ontwikkelingen endpoint in the waarderingen area of the public API.

<a name="oauth"></a>
### oauth

- **Type**: OAuth
- **Flow**: accessCode
- **Authorization URL**: https://authentication.calcasa.nl/oauth2/v2.0/authorize
- **Scopes**: 
  - all: Full permissions for all areas.
  - api:all: Full permissions for all areas of the public API.
  - api:bestemmingsplannen:all: Full permissions for the bestemmingsplannen area of the public API.
  - api:bodem:all: Full permissions for the bodem area of the public API.
  - api:buurt:all: Full permissions for the buurt area of the public API.
  - api:configuratie:all: Full permissions for the configuratie area of the public API.
  - api:callback:all: Full permissions for the callback area of the public API.
  - api:facturen:all: Full permissions for the facturen area of the public API.
  - api:fotos:all: Full permissions for the fotos area of the public API.
  - api:funderingen:all: Full permissions for the funderingen area of the public API.
  - api:rapporten:all: Full permissions for the rapporten area of the public API.
  - api:waarderingen:all: Full permissions for the waarderingen area of the public API.
  - api:adressen:read: Read permissions for the adressen area of the public API.
  - api:bestemmingsplannen:read: Read permissions for the bestemmingsplannen area of the public API.
  - api:bodem:read: Read permissions for the bodem area of the public API.
  - api:buurt:read: Read permissions for the buurt area of the public API.
  - api:configuratie:read: Read permissions for the configuratie area of the public API.
  - api:configuratie:write: Write permissions for the configuratie area of the public API.
  - api:callback:read: Read permissions for the callback area of the public API.
  - api:callback:write: Write permissions for the callback area of the public API.
  - api:facturen:read: Read permissions for the facturen area of the public API.
  - api:fotos:read: Read permissions for the fotos area of the public API.
  - api:funderingen:read: Read permissions for the funderingen area of the public API.
  - api:geldverstrekkers:read: Read permissions for the geldverstrekkers area of the public API.
  - api:rapporten:read: Read permissions for the rapporten area of the public API.
  - api:waarderingen:create: Create permissions for the waarderingen area of the public API.
  - api:waarderingen:patch: Patch permissions for the waarderingen area of the public API.
  - api:waarderingen:read: Read permissions for the waarderingen area of the public API.
  - api:waarderingen:ontwikkeling: Read permissions for the ontwikkelingen endpoint in the waarderingen area of the public API.

