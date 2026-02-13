# Getting Started with PnzApi

PaymentsNZ Account and Transaction SDK. This is heavily derived from the Open Banking UK API - see www.openbanking.org.uk for details.

---

## Installation

Install this SDK into your application by adding a project reference to the SDK.

```bash
dotnet add reference <path-to-sdk>\PnzApi.csproj
```

---

## Usage

```csharp
using PnzApi;
using PnzApi.Models;
using PnzApi.Core.Exceptions;

string bearerToken = "1POdFZRZbvb...qqillRxMr2z";
PnzApiClient client = new PnzApiClient(new HttpClient(), new PnzApiClientOptions(), bearerToken);

try
{
    string accountId = "OXX-XX-XXXX-XXXXXXX-XX";
    AccountGetresponse1 resp = await client.GetAccount(accountId, null, null, null, null, null);

    // TODO: decide what happens when api call is successfully completed
}
catch (SdkException<VoidErrorResponse> ex)
{
    // TODO: decide what happens when api call is resulted in an error status code
}
```

## Client Options

The following options are configurable in your client:

| Parameter | Type | Description |
|  --- | --- | --- |
| RetryOptions | [`RetryOptions`](#retry-options) | The Retry options for the API Calls |

### Retry Options

The following fields are available in `RetryOptions`:

| Parameter | Type | Description |
|  --- | --- | --- |
| Timeout | `TimeSpan` | Per-request timeout; cancels requests exceeding this duration. <br> **Default: 100s** |
| StatusCodesToRetry | `IReadOnlyList<HttpStatusCode>` | HTTP status codes that trigger a retry. <br> **Default: 408, 429, 500, 502, 503, 504** |
| HttpMethodsToRetry | `IReadOnlyList<HttpMethod>` | HTTP methods eligible for retry. <br> **Default: GET, HEAD, PUT, OPTIONS** |
| MaxRetries | `int` | Maximum number of retry attempts. <br> **Default: 3** |
| Delay | `TimeSpan` | Base delay before each retry attempt. <br> **Default: 1s** |
| BackOffFactor | `int` | Multiplier for exponential backoff (e.g., 2 doubles each attempt's delay). <br> **Default: 2** |
| UseExponentialBackoff | `bool` | Enables exponential backoff; when false, uses constant delay. <br> **Default: true** |
| MaxJitter | `TimeSpan` | Maximum random jitter added to delay to reduce contention. <br> **Default: 500ms** |
| OnRetry | `Action<Exception, TimeSpan, int>` | Callback invoked on each retry with the error/result, applied delay, and attempt number. <br> **Default: null** |

---

## Retries and BackOff

```csharp
using PnzApi;
using PnzApi.Models;

PnzApiClientOptions options =
    new PnzApiClientOptions
    {
        RetryOptions = PnzApi.Core.Configuration.RetryOptions.Default() with
        {
            MaxRetries = 5,
            Delay = TimeSpan.FromSeconds(2)
        }
    };

string bearerToken = "1POdFZRZbvb...qqillRxMr2z";
PnzApiClient client = new PnzApiClient(new HttpClient(), options, bearerToken);

// Make any API Call with HttpMethod GET
string accountId = "OXX-XX-XXXX-XXXXXXX-XX";
AccountGetresponse1 resp = await client.GetAccount(accountId, null, null, null, null, null);
```

## Bearer Authentication

```csharp
using PnzApi;
using PnzApi.Models;

// Initialize Client with bearer authentication
string bearerToken = "1POdFZRZbvb...qqillRxMr2z";
PnzApiClient client = new PnzApiClient(new HttpClient(), new PnzApiClientOptions(), bearerToken);


// Make an API Call that requires bearer authentication
string accountId = "OXX-XX-XXXX-XXXXXXX-XX";
AccountGetresponse1 resp = await client.GetAccount(accountId, null, null, null, null, null);
```