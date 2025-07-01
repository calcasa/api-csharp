# Created with Openapi Generator

<a id="cli"></a>
## Run the following powershell command to generate the library

```ps1
$properties = @(
    'apiName=Api',
    'targetFramework=net8.0;net9.0',
    'validatable=false',
    'nullableReferenceTypes=true',
    'hideGenerationTimestamp=true',
    'packageVersion=1.4.0-rc1',
    'packageAuthors=Calcasa',
    'packageCompany=Calcasa',
    'packageCopyright=Copyright 2025 Calcasa B.V.',
    'packageDescription=API client for the Calcasa Public API.',
    'licenseId=Apache-2.0',
    'packageName=Calcasa.Api',
    'packageTags=',
    'packageTitle=Calcasa API Client'
) -join ","

$global = @(
    'apiDocs=true',
    'modelDocs=true',
    'apiTests=true',
    'modelTests=true'
) -join ","

java -jar "<path>/openapi-generator/modules/openapi-generator-cli/target/openapi-generator-cli.jar" generate `
    -g csharp-netcore `
    -i <your-swagger-file>.yaml `
    -o <your-output-folder> `
    --library generichost `
    --additional-properties $properties `
    --global-property $global `
    --git-host "github.com" `
    --git-repo-id "api-csharp" `
    --git-user-id "calcasa" `
    --release-note "Minor update"
    # -t templates
```

<a id="usage"></a>
## Using the library in your project

```cs
using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Calcasa.Api.Api;
using Calcasa.Api.Client;
using Calcasa.Api.Model;

namespace YourProject
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();
            var api = host.Services.GetRequiredService<IAdressenApi>();
            GetAdresApiResponse apiResponse = await api.GetAdresAsync("todo");
            AdresInfo model = apiResponse.Ok();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) => Host.CreateDefaultBuilder(args)
          .ConfigureApi((context, options) =>
          {
              // the type of token here depends on the api security specifications
              ApiKeyToken token = new("<your token>", ClientUtils.ApiKeyHeader.Authorization);
              options.AddTokens(token);

              // optionally choose the method the tokens will be provided with, default is RateLimitProvider
              options.UseProvider<RateLimitProvider<ApiKeyToken>, ApiKeyToken>();

              options.ConfigureJsonOptions((jsonOptions) =>
              {
                  // your custom converters if any
              });

              options.AddApiHttpClients(builder: builder => builder
                .AddRetryPolicy(2)
                .AddTimeoutPolicy(TimeSpan.FromSeconds(5))
                .AddCircuitBreakerPolicy(10, TimeSpan.FromSeconds(30))
                // add whatever middleware you prefer
              );
          });
    }
}
```
<a id="questions"></a>
## Questions

- What about HttpRequest failures and retries?
  If supportsRetry is enabled, you can configure Polly in the ConfigureClients method.
- How are tokens used?
  Tokens are provided by a TokenProvider class. The default is RateLimitProvider which will perform client side rate limiting.
  Other providers can be used with the UseProvider method.
- Does an HttpRequest throw an error when the server response is not Ok?
  It depends how you made the request. If the return type is ApiResponse<T> no error will be thrown, though the Content property will be null. 
  StatusCode and ReasonPhrase will contain information about the error.
  If the return type is T, then it will throw. If the return type is TOrDefault, it will return null.
- How do I validate requests and process responses?
  Use the provided On and After methods in the Api class from the namespace Calcasa.Api.Rest.DefaultApi.
  Or provide your own class by using the generic ConfigureApi method.

<a id="dependencies"></a>
## Dependencies

- [Microsoft.Extensions.Hosting](https://www.nuget.org/packages/Microsoft.Extensions.Hosting/) - 5.0.0 or later
- [Microsoft.Extensions.Http](https://www.nuget.org/packages/Microsoft.Extensions.Http/) - 5.0.0 or later
- [Microsoft.Extensions.Http.Polly](https://www.nuget.org/packages/Microsoft.Extensions.Http.Polly/) - 5.0.1 or later

<a id="documentation-for-authorization"></a>
## Documentation for Authorization


Authentication schemes defined for the API:
<a id="oauth"></a>
### oauth

- **Type**: OAuth
- **Flow**: application
- **Authorization URL**: 
- **Scopes**:   
- api:adressen:read:   
- api:bestemmingsplannen:read:   
- api:bodem:read:   
- api:buurt:read:   
- api:callback:read:   
- api:callback:write:   
- api:configuratie:read:   
- api:configuratie:write:   
- api:facturen:read:   
- api:fotos:read:   
- api:funderingen:read:   
- api:geldverstrekkers:read:   
- api:rapporten:read:   
- api:waarderingen:read:   
- api:waarderingen:patch:   
- api:waarderingen:ontwikkeling:   
- api:waarderingen:create: 


## Build
- SDK version: 1.4.0-rc1
- Generator version: 7.13.0
- Build package: org.openapitools.codegen.languages.CSharpClientCodegen

## Api Information
- appName: Calcasa Public API
- appVersion: 1.4.0-rc1
- appDescription: The Calcasa API is used to connect to Calcasa provided services. For more information, please visit [Documentation](https://docs.calcasa.nl) or [GitHub](https://github.com/calcasa/api).

## [OpenApi Global properties](https://openapi-generator.tech/docs/globals)
- generateAliasAsModel: 
- supportingFiles: 
- models: omitted for brevity
- apis: omitted for brevity
- apiDocs: true
- modelDocs: true
- apiTests: true
- modelTests: true

## [OpenApi Generator Parameters](https://openapi-generator.tech/docs/generators/csharp-netcore)
- allowUnicodeIdentifiers: 
- apiName: Api
- caseInsensitiveResponseHeaders: 
- conditionalSerialization: false
- disallowAdditionalPropertiesIfNotPresent: false
- gitHost: github.com
- gitRepoId: api-csharp
- gitUserId: calcasa
- hideGenerationTimestamp: true
- interfacePrefix: I
- library: generichost
- licenseId: Apache-2.0
- modelPropertyNaming: PascalCase
- netCoreProjectFile: true
- nonPublicApi: false
- nullableReferenceTypes: true
- optionalAssemblyInfo: 
- optionalEmitDefaultValues: false
- optionalMethodArgument: true
- optionalProjectFile: 
- packageAuthors: Calcasa
- packageCompany: Calcasa
- packageCopyright: Copyright 2025 Calcasa B.V.
- packageDescription: API client for the Calcasa Public API.
- packageGuid: {3F2DDA54-9CA2-469D-BD77-84A532BE324D}
- packageName: Calcasa.Api
- packageTags: 
- packageTitle: Calcasa API Client
- packageVersion: 1.4.0-rc1
- releaseNote: Minor update
- returnICollection: false
- sortParamsByRequiredFlag: 
- sourceFolder: src
- targetFramework: net8.0;net9.0
- useCollection: true
- useDateTimeOffset: false
- useOneOfDiscriminatorLookup: false
- validatable: false
For more information, please visit [https://www.calcasa.nl/contact](https://www.calcasa.nl/contact)

This C# SDK is automatically generated by the [OpenAPI Generator](https://openapi-generator.tech) project.
