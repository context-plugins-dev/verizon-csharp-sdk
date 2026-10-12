# Reference

Every operation below is shown in its throwing form. On an error status it throws `ApiException<TError>` — the status code, headers, content type and the operation's error type, `RawError` (the raw body) when the spec declares none — and where an operation offers an `…AsResult` sibling, that sibling returns `ApiResult<TResponse, TError>` instead. A request that produces no usable response surfaces as `SdkConnectionException` or `SdkTimeoutException`, a body that does not match the documented response type as `ResponseDeserializationException`, and a credential that cannot be applied as `AuthSchemeException`; all of them derive from `SdkException` and name the failed call. See [README → Error Handling](README.md#error-handling).

> Source: [VerizonClient](src/Verizon/VerizonClient.cs)

## GbiDeviceActions5

> Source: [GbiDeviceActions5](src/Verizon/Api/GbiDeviceActions5.cs)

<details>
<summary><code>Task&lt;GbiRequestResponse5&gt; BusinessInternetServiceplanchange(BusinessInternetServiceplanchangeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Change a device's service plan to use 5G BI.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.GbiDeviceActions5.BusinessInternetServiceplanchange(
        new BusinessInternetServiceplanchangeRequest
        {
            Body = new GbichangeRequest5
            {
                AccountName = "0000123456-00001",
                ServicePlan = "5G BI service plan name being changed to",
                DeviceListWithServiceAddress = [
                    new GbideviceIdarray25 { DeviceId = [new GbideviceId15 { Id = "15-digit IMEI", Kind = "imei" }] },
                    new GbiaddressAndcustomerinfo25 { PrimaryPlaceofuse = new GbiaddressAndcustomerinfo5() },
                ],
                CurrentServicePlan = "Optional name of the plan being changed from",
            },
        });
    // TODO: Handle 'response' of type GbiRequestResponse5
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[BusinessInternetServiceplanchangeRequest](src/Verizon/Requests/GbiDeviceActions5/BusinessInternetServiceplanchangeRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GbiRequestResponse5](src/Verizon/Models/GbiRequestResponse5.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Verizon/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GbiRequestResponse5&gt; BusinessInternetactivateUsingPost(BusinessInternetactivateUsingPostRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Uses the device's ICCID and IMEI to activate service.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.GbiDeviceActions5.BusinessInternetactivateUsingPost(
        new BusinessInternetactivateUsingPostRequest
        {
            Body = new GbiactivateRequest5
            {
                AccountName = "0000123456-00001",
                ServicePlan = "service plan name",
                DeviceListWithServiceAddress = [
                    new GbideviceIdarray5
                    {
                        DeviceId = [
                            new ESimDeviceId { Id = "15-digit IMEI", Kind = "imei" },
                            new ESimDeviceId { Id = "20-digit ICCID", Kind = "iccid" },
                        ],
                    },
                    new GbiaddressAndcustomerinfo5
                    {
                        PrimaryPlaceofuse = new GbiprimaryPlaceofuse5
                        {
                            Address = new GbiAddress5(),
                            CustomerName = new GbiCustomerName5(),
                        },
                    },
                ],
                SkuNumber = "VZW Stock Keeping Unit number",
                PublicIpRestriction = "Unrestricted",
                CarrierName = "Verizon Wireless",
                MdnZipCode = "the 5-digit ZIP code of the Mobile Directory Number (MDN)",
            },
        });
    // TODO: Handle 'response' of type GbiRequestResponse5
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[BusinessInternetactivateUsingPostRequest](src/Verizon/Requests/GbiDeviceActions5/BusinessInternetactivateUsingPostRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GbiRequestResponse5](src/Verizon/Models/GbiRequestResponse5.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Verizon/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GbideviceDetailsresponse5&gt; BusinessInternetlistDeviceInformation(BusinessInternetlistDeviceInformationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Uses the decive's Integrated Circuit Card Identification Number (ICCID) to retrive and display the device's properties.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.GbiDeviceActions5.BusinessInternetlistDeviceInformation(
        new BusinessInternetlistDeviceInformationRequest
        {
            Body = new GbideviceId5 { DeviceId = new GbideviceId15 { Id = "20-digit ICCID", Kind = "iccid" } },
        });
    // TODO: Handle 'response' of type GbideviceDetailsresponse5
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[BusinessInternetlistDeviceInformationRequest](src/Verizon/Requests/GbiDeviceActions5/BusinessInternetlistDeviceInformationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GbideviceDetailsresponse5](src/Verizon/Models/GbideviceDetailsresponse5.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Verizon/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## AccountDevices

> Source: [AccountDevices](src/Verizon/Api/AccountDevices.cs)

<details>
<summary><code>Task&lt;V3AccountDeviceList&gt; GetAccountDeviceInformation(GetAccountDeviceInformationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieve account device information such as reported firmware on the devices.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AccountDevices.GetAccountDeviceInformation(new GetAccountDeviceInformationRequest
    {
        Acc = "0000123456-00001",
        LastSeenDeviceId = "0",
        Protocol = DevicesProtocol.Lwm2M,
    });
    // TODO: Handle 'response' of type V3AccountDeviceList
}
catch (ApiException<GetAccountDeviceInformationError> ex)
{
    if (ex.Error.TryGetFotaV3Result(out var error))
    {
        // TODO: Handle 'error' of type FotaV3Result
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetAccountDeviceInformationRequest](src/Verizon/Requests/AccountDevices/GetAccountDeviceInformationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V3AccountDeviceList](src/Verizon/Models/V3AccountDeviceList.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[GetAccountDeviceInformationError](src/Verizon/Errors/GetAccountDeviceInformationError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeviceListResult&gt; ListAccountDevicesInformation(ListAccountDevicesInformationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieve device information for a list of devices on an account.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AccountDevices.ListAccountDevicesInformation(new ListAccountDevicesInformationRequest
    {
        Acc = "0000123456-00001",
        Body = new DeviceImei { DeviceList = ["15-digit IMEI"] },
    });
    // TODO: Handle 'response' of type DeviceListResult
}
catch (ApiException<ListAccountDevicesInformationError> ex)
{
    if (ex.Error.TryGetFotaV3Result(out var error))
    {
        // TODO: Handle 'error' of type FotaV3Result
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ListAccountDevicesInformationRequest](src/Verizon/Requests/AccountDevices/ListAccountDevicesInformationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeviceListResult](src/Verizon/Models/DeviceListResult.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[ListAccountDevicesInformationError](src/Verizon/Errors/ListAccountDevicesInformationError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## AccountRequests

> Source: [AccountRequests](src/Verizon/Api/AccountRequests.cs)

<details>
<summary><code>Task&lt;AsynchronousRequestResult&gt; GetCurrentAsynchronousRequestStatus(GetCurrentAsynchronousRequestStatusRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the current status of an asynchronous request that was made for a single device.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AccountRequests.GetCurrentAsynchronousRequestStatus(
        new GetCurrentAsynchronousRequestStatusRequest
        {
            Aname = "0252012345-00001",
            RequestId = "86c83330-4bf5-4235-9c4e-a83f93aeae4c",
        });
    // TODO: Handle 'response' of type AsynchronousRequestResult
}
catch (ApiException<GetCurrentAsynchronousRequestStatusError> ex)
{
    if (ex.Error.TryGetConnectivityManagementResult(out var error))
    {
        // TODO: Handle 'error' of type ConnectivityManagementResult
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetCurrentAsynchronousRequestStatusRequest](src/Verizon/Requests/AccountRequests/GetCurrentAsynchronousRequestStatusRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AsynchronousRequestResult](src/Verizon/Models/AsynchronousRequestResult.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[GetCurrentAsynchronousRequestStatusError](src/Verizon/Errors/GetCurrentAsynchronousRequestStatusError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## AccountServiceController

> Source: [AccountServiceController](src/Verizon/Api/AccountServiceController.cs)

<details>
<summary><code>Task&lt;GetAccountInformationResponseforplanner&gt; GetAccountInformationUsingGet(GetAccountInformationUsingGetRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns aaccount information associated with a specified account.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AccountServiceController.GetAccountInformationUsingGet(
        new GetAccountInformationUsingGetRequest { AccountName = "0000123456-00002" });
    // TODO: Handle 'response' of type GetAccountInformationResponseforplanner
}
catch (ApiException<GetAccountInformationUsingGetError> ex)
{
    if (ex.Error.TryGetRestErrorResponseforplanner(out var error))
    {
        // TODO: Handle 'error' of type RestErrorResponseforplanner
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetAccountInformationUsingGetRequest](src/Verizon/Requests/AccountServiceController/GetAccountInformationUsingGetRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GetAccountInformationResponseforplanner](src/Verizon/Models/GetAccountInformationResponseforplanner.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[GetAccountInformationUsingGetError](src/Verizon/Errors/GetAccountInformationUsingGetError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## AccountSubscriptions

> Source: [AccountSubscriptions](src/Verizon/Api/AccountSubscriptions.cs)

<details>
<summary><code>Task&lt;SecuritySubscriptionResult&gt; ListAccountSubscriptions(ListAccountSubscriptionsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves the total number of SIM-Secure for IoT subscription licenses purchased for your account by license type, and lists the number of licenses assigned and available for each license type.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AccountSubscriptions.ListAccountSubscriptions(new ListAccountSubscriptionsRequest
    {
        Body = new SecuritySubscriptionRequest { AccountName = "000012345600001", SkuNumber = "SIMSec-IoT-Lt" },
    });
    // TODO: Handle 'response' of type SecuritySubscriptionResult
}
catch (ApiException<ListAccountSubscriptionsError> ex)
{
    if (ex.Error.TryGetSecurityResult(out var error))
    {
        // TODO: Handle 'error' of type SecurityResult
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ListAccountSubscriptionsRequest](src/Verizon/Requests/AccountSubscriptions/ListAccountSubscriptionsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SecuritySubscriptionResult](src/Verizon/Models/SecuritySubscriptionResult.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[ListAccountSubscriptionsError](src/Verizon/Errors/ListAccountSubscriptionsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Accounts

> Source: [Accounts](src/Verizon/Api/Accounts.cs)

<details>
<summary><code>Task&lt;Account&gt; GetAccountInformation(GetAccountInformationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns information about a specified account.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Accounts.GetAccountInformation(new GetAccountInformationRequest
    {
        Aname = "Chintan_CPNStaticBulk",
    });
    // TODO: Handle 'response' of type Account
}
catch (ApiException<GetAccountInformationError> ex)
{
    if (ex.Error.TryGetConnectivityManagementResult(out var error))
    {
        // TODO: Handle 'error' of type ConnectivityManagementResult
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetAccountInformationRequest](src/Verizon/Requests/Accounts/GetAccountInformationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Account](src/Verizon/Models/Account.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[GetAccountInformationError](src/Verizon/Errors/GetAccountInformationError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AccountLeadsResult&gt; ListAccountLeads(ListAccountLeadsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

When HTTP status is 202, a URL will be returned in the Location header of the form /leads/{aname}?next={token}. This URL can be used to request the next set of leads.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Accounts.ListAccountLeads(new ListAccountLeadsRequest { Aname = "0252012345-00001" });
    // TODO: Handle 'response' of type AccountLeadsResult
}
catch (ApiException<ListAccountLeadsError> ex)
{
    if (ex.Error.TryGetConnectivityManagementResult(out var error))
    {
        // TODO: Handle 'error' of type ConnectivityManagementResult
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ListAccountLeadsRequest](src/Verizon/Requests/Accounts/ListAccountLeadsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AccountLeadsResult](src/Verizon/Models/AccountLeadsResult.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[ListAccountLeadsError](src/Verizon/Errors/ListAccountLeadsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AccountStatesAndServices&gt; ListAccountStatesAndServices(ListAccountStatesAndServicesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a list and details of all custom services and states defined for a specified account.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Accounts.ListAccountStatesAndServices(new ListAccountStatesAndServicesRequest
    {
        Aname = "0252012345-00001",
    });
    // TODO: Handle 'response' of type AccountStatesAndServices
}
catch (ApiException<ListAccountStatesAndServicesError> ex)
{
    if (ex.Error.TryGetConnectivityManagementResult(out var error))
    {
        // TODO: Handle 'error' of type ConnectivityManagementResult
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ListAccountStatesAndServicesRequest](src/Verizon/Requests/Accounts/ListAccountStatesAndServicesRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AccountStatesAndServices](src/Verizon/Models/AccountStatesAndServices.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[ListAccountStatesAndServicesError](src/Verizon/Errors/ListAccountStatesAndServicesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## AnomalySettings

> Source: [AnomalySettings](src/Verizon/Api/AnomalySettings.cs)

<details>
<summary><code>Task&lt;IntelligenceSuccessResult&gt; ActivateAnomalyDetection(ActivateAnomalyDetectionRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Uses the subscribed account ID to activate anomaly detection and set threshold values.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AnomalySettings.ActivateAnomalyDetection(new ActivateAnomalyDetectionRequest
    {
        Body = new AnomalyDetectionRequest
        {
            AccountName = "0000123456-00001",
            RequestType = "anomaly",
            SensitivityParameter = new SensitivityParameters
            {
                AbnormalMaxValue = 1.1d,
                EnableAbnormal = true,
                EnableVeryAbnormal = true,
                VeryAbnormalMaxValue = 0.55d,
            },
        },
    });
    // TODO: Handle 'response' of type IntelligenceSuccessResult
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ActivateAnomalyDetectionRequest](src/Verizon/Requests/AnomalySettings/ActivateAnomalyDetectionRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[IntelligenceSuccessResult](src/Verizon/Models/IntelligenceSuccessResult.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Verizon/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AnomalyDetectionSettings&gt; ListAnomalyDetectionSettings(ListAnomalyDetectionSettingsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves the current anomaly detection settings for an account.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AnomalySettings.ListAnomalyDetectionSettings(new ListAnomalyDetectionSettingsRequest
    {
        AccountName = "0000123456-00001",
    });
    // TODO: Handle 'response' of type AnomalyDetectionSettings
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ListAnomalyDetectionSettingsRequest](src/Verizon/Requests/AnomalySettings/ListAnomalyDetectionSettingsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AnomalyDetectionSettings](src/Verizon/Models/AnomalyDetectionSettings.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Verizon/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IntelligenceSuccessResult&gt; ResetAnomalyDetectionParameters(ResetAnomalyDetectionParametersRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Resets the thresholds to zero.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AnomalySettings.ResetAnomalyDetectionParameters(
        new ResetAnomalyDetectionParametersRequest { AccountName = "0000123456-00001" });
    // TODO: Handle 'response' of type IntelligenceSuccessResult
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ResetAnomalyDetectionParametersRequest](src/Verizon/Requests/AnomalySettings/ResetAnomalyDetectionParametersRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[IntelligenceSuccessResult](src/Verizon/Models/IntelligenceSuccessResult.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Verizon/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## AnomalyTriggers

> Source: [AnomalyTriggers](src/Verizon/Api/AnomalyTriggers.cs)

<details>
<summary><code>Task&lt;AnomalyDetectionTrigger&gt; CreateAnomalyDetectionTrigger(CreateAnomalyDetectionTriggerRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This corresponds to the M2M-MC SOAP interface, ```CreateTrigger```.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AnomalyTriggers.CreateAnomalyDetectionTrigger(new CreateAnomalyDetectionTriggerRequest
    {
        Body = new CreateTriggerRequest(),
    });
    // TODO: Handle 'response' of type AnomalyDetectionTrigger
}
catch (ApiException<CreateAnomalyDetectionTriggerError> ex)
{
    if (ex.Error.TryGetIntelligenceResult(out var error))
    {
        // TODO: Handle 'error' of type IntelligenceResult
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CreateAnomalyDetectionTriggerRequest](src/Verizon/Requests/AnomalyTriggers/CreateAnomalyDetectionTriggerRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AnomalyDetectionTrigger](src/Verizon/Models/AnomalyDetectionTrigger.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[CreateAnomalyDetectionTriggerError](src/Verizon/Errors/CreateAnomalyDetectionTriggerError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AnomalyDetectionTrigger&gt; DeleteAnomalyDetectionTrigger(DeleteAnomalyDetectionTriggerRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Deletes a specific trigger ID

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AnomalyTriggers.DeleteAnomalyDetectionTrigger(new DeleteAnomalyDetectionTriggerRequest
    {
        TriggerId = "be1b5958-3e11-41db-9abd-b1b7618c0035",
    });
    // TODO: Handle 'response' of type AnomalyDetectionTrigger
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeleteAnomalyDetectionTriggerRequest](src/Verizon/Requests/AnomalyTriggers/DeleteAnomalyDetectionTriggerRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AnomalyDetectionTrigger](src/Verizon/Models/AnomalyDetectionTrigger.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Verizon/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;GetTriggerResponseList&gt;&gt; ListAnomalyDetectionTriggerSettings(ListAnomalyDetectionTriggerSettingsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This corresponds to the M2M-MC SOAP interface, ```GetTriggers```.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AnomalyTriggers.ListAnomalyDetectionTriggerSettings(
        new ListAnomalyDetectionTriggerSettingsRequest { TriggerId = "be1b5958-3e11-41db-9abd-b1b7618c0035" });
    // TODO: Handle 'response' of type IReadOnlyList<GetTriggerResponseList>
}
catch (ApiException<ListAnomalyDetectionTriggerSettingsError> ex)
{
    if (ex.Error.TryGetIntelligenceResult(out var error))
    {
        // TODO: Handle 'error' of type IntelligenceResult
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ListAnomalyDetectionTriggerSettingsRequest](src/Verizon/Requests/AnomalyTriggers/ListAnomalyDetectionTriggerSettingsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[GetTriggerResponseList](src/Verizon/Models/GetTriggerResponseList.cs)&gt;</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[ListAnomalyDetectionTriggerSettingsError](src/Verizon/Errors/ListAnomalyDetectionTriggerSettingsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;GetTriggerResponseList&gt;&gt; ListAnomalyDetectionTriggers(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This corresponds to the M2M-MC SOAP interface, ```GetTriggers```.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AnomalyTriggers.ListAnomalyDetectionTriggers();
    // TODO: Handle 'response' of type IReadOnlyList<GetTriggerResponseList>
}
catch (ApiException<ListAnomalyDetectionTriggersError> ex)
{
    if (ex.Error.TryGetIntelligenceResult(out var error))
    {
        // TODO: Handle 'error' of type IntelligenceResult
    }
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[GetTriggerResponseList](src/Verizon/Models/GetTriggerResponseList.cs)&gt;</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[ListAnomalyDetectionTriggersError](src/Verizon/Errors/ListAnomalyDetectionTriggersError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AnomalyDetectionTrigger&gt; UpdateAnomalyDetectionTrigger(UpdateAnomalyDetectionTriggerRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This corresponds to the M2M-MC SOAP interface, ```UpdateTriggerRequest```.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AnomalyTriggers.UpdateAnomalyDetectionTrigger(new UpdateAnomalyDetectionTriggerRequest
    {
        Body = new UpdateTriggerRequest(),
    });
    // TODO: Handle 'response' of type AnomalyDetectionTrigger
}
catch (ApiException<UpdateAnomalyDetectionTriggerError> ex)
{
    if (ex.Error.TryGetIntelligenceResult(out var error))
    {
        // TODO: Handle 'error' of type IntelligenceResult
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UpdateAnomalyDetectionTriggerRequest](src/Verizon/Requests/AnomalyTriggers/UpdateAnomalyDetectionTriggerRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AnomalyDetectionTrigger](src/Verizon/Models/AnomalyDetectionTrigger.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[UpdateAnomalyDetectionTriggerError](src/Verizon/Errors/UpdateAnomalyDetectionTriggerError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## AnomalyTriggersV2

> Source: [AnomalyTriggersV2](src/Verizon/Api/AnomalyTriggersV2.cs)

<details>
<summary><code>Task&lt;AnomalyDetectionTrigger&gt; CreateAnomalyDetectionTriggerV2(CreateAnomalyDetectionTriggerV2Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates the trigger to identify an anomaly.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AnomalyTriggersV2.CreateAnomalyDetectionTriggerV2(
        new CreateAnomalyDetectionTriggerV2Request
        {
            Body = [
                new TriggerType1
                {
                    Name = "Anomaly Daily Usage REST Test-Patch 1",
                    TriggerCategory = "UsageAnomaly",
                    AccountName = "0000123456-00001",
                    AnomalyTriggerRequest = new AnomalyTriggerRequest
                    {
                        AccountNames = "0000123456-00001",
                        IncludeAbnormal = true,
                        IncludeVeryAbnormal = true,
                        IncludeUnderExpectedUsage = true,
                        IncludeOverExpectedUsage = true,
                    },
                    Notification = new TriggerNotification
                    {
                        NotificationType = "DailySummary",
                        Callback = true,
                        EmailNotification = false,
                        NotificationGroupName = "Anomaly Test API",
                        NotificationFrequencyFactor = 3,
                        NotificationFrequencyInterval = "Hourly",
                        ExternalEmailRecipients = "placeholder@verizon.com",
                        SmsNotification = true,
                        SmsNumbers = [new SmsNumber { Carrier = "US Cellular", Number = "9299280711" }],
                        Reminder = true,
                        Severity = "Critical",
                    },
                },
            ],
        });
    // TODO: Handle 'response' of type AnomalyDetectionTrigger
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CreateAnomalyDetectionTriggerV2Request](src/Verizon/Requests/AnomalyTriggersV2/CreateAnomalyDetectionTriggerV2Request.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AnomalyDetectionTrigger](src/Verizon/Models/AnomalyDetectionTrigger.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Verizon/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AnomalyTriggerResult&gt; ListAnomalyDetectionTriggerSettingsV2(ListAnomalyDetectionTriggerSettingsV2Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves the values for a specific trigger ID.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AnomalyTriggersV2.ListAnomalyDetectionTriggerSettingsV2(
        new ListAnomalyDetectionTriggerSettingsV2Request { TriggerId = "be1b5958-3e11-41db-9abd-b1b7618c0035" });
    // TODO: Handle 'response' of type AnomalyTriggerResult
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ListAnomalyDetectionTriggerSettingsV2Request](src/Verizon/Requests/AnomalyTriggersV2/ListAnomalyDetectionTriggerSettingsV2Request.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AnomalyTriggerResult](src/Verizon/Models/AnomalyTriggerResult.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Verizon/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IntelligenceSuccessResult&gt; UpdateAnomalyDetectionTriggerV2(UpdateAnomalyDetectionTriggerV2Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates an existing trigger using the account name.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AnomalyTriggersV2.UpdateAnomalyDetectionTriggerV2(
        new UpdateAnomalyDetectionTriggerV2Request
        {
            Body = [
                new TriggerType3
                {
                    TriggerId = "595f5c44-c31c-4552-8670-020a1545a84d",
                    TriggerName = "Anomaly Daily Usage REST Test-Patch Update 4",
                    TriggerCategory = "UsageAnomaly",
                    AccountName = "0000123456-00001",
                    AnomalyTriggerRequest = new AnomalyTriggerRequest
                    {
                        AccountNames = "0000123456-00001",
                        IncludeAbnormal = true,
                        IncludeVeryAbnormal = true,
                        IncludeUnderExpectedUsage = false,
                        IncludeOverExpectedUsage = true,
                    },
                    Notification = new TriggerNotification
                    {
                        NotificationType = "DailySummary",
                        Callback = true,
                        EmailNotification = false,
                        NotificationGroupName = "Anomaly Test API",
                        NotificationFrequencyFactor = 3,
                        NotificationFrequencyInterval = "Hourly",
                        ExternalEmailRecipients = "placeholder@verizon.com",
                        SmsNotification = true,
                        SmsNumbers = [new SmsNumber { Carrier = "US Cellular", Number = "9299280711" }],
                        Reminder = true,
                        Severity = "Critical",
                    },
                },
            ],
        });
    // TODO: Handle 'response' of type IntelligenceSuccessResult
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UpdateAnomalyDetectionTriggerV2Request](src/Verizon/Requests/AnomalyTriggersV2/UpdateAnomalyDetectionTriggerV2Request.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[IntelligenceSuccessResult](src/Verizon/Models/IntelligenceSuccessResult.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Verizon/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Billing

> Source: [Billing](src/Verizon/Api/Billing.cs)

<details>
<summary><code>Task&lt;ManagedAccountsAddResponse&gt; AddAccount(AddAccountRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This endpoint allows user to add managed accounts to a primary account.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Billing.AddAccount(new AddAccountRequest
    {
        Body = new ManagedAccountsAddRequest
        {
            AccountName = "1234567890-00001",
            ServiceName = ServiceName.Location,
            Type = "TS-LOC-COARSE-CellID-Aggr",
            ManagedAccList = ["1223334444-00001", "2334445555-00001", "3445556666-00001"],
        },
    });
    // TODO: Handle 'response' of type ManagedAccountsAddResponse
}
catch (ApiException<AddAccountError> ex)
{
    if (ex.Error.TryGetDeviceLocationResult(out var error))
    {
        // TODO: Handle 'error' of type DeviceLocationResult
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AddAccountRequest](src/Verizon/Requests/Billing/AddAccountRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ManagedAccountsAddResponse](src/Verizon/Models/ManagedAccountsAddResponse.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[AddAccountError](src/Verizon/Errors/AddAccountError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ManagedAccountCancelResponse&gt; CancelManagedAccountAction(CancelManagedAccountActionRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Deactivates a managed billing service relationship between a managed account and the primary account.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Billing.CancelManagedAccountAction(new CancelManagedAccountActionRequest
    {
        Body = new ManagedAccountCancelRequest
        {
            AccountName = "1223334444-00001",
            PaccountName = "1234567890-00001",
            ServiceName = ServiceName.Location,
            Type = "TS-LOC-COARSE-CellID-5K",
            Txid = "d4fbff33-eeee-ffff-gggg-2c90bd287e3b",
        },
    });
    // TODO: Handle 'response' of type ManagedAccountCancelResponse
}
catch (ApiException<CancelManagedAccountActionError> ex)
{
    if (ex.Error.TryGetDeviceLocationResult(out var error))
    {
        // TODO: Handle 'error' of type DeviceLocationResult
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CancelManagedAccountActionRequest](src/Verizon/Requests/Billing/CancelManagedAccountActionRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ManagedAccountCancelResponse](src/Verizon/Models/ManagedAccountCancelResponse.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[CancelManagedAccountActionError](src/Verizon/Errors/CancelManagedAccountActionError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ManagedAccountsGetAllResponse&gt; ListManagedAccount(ListManagedAccountRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This endpoint allows user to retrieve the list of all accounts managed by a primary account.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Billing.ListManagedAccount(new ListManagedAccountRequest
    {
        AccountName = "1223334444-00001",
        ServiceName = "some example string",
    });
    // TODO: Handle 'response' of type ManagedAccountsGetAllResponse
}
catch (ApiException<ListManagedAccountError> ex)
{
    if (ex.Error.TryGetDeviceLocationResult(out var error))
    {
        // TODO: Handle 'error' of type DeviceLocationResult
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ListManagedAccountRequest](src/Verizon/Requests/Billing/ListManagedAccountRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ManagedAccountsGetAllResponse](src/Verizon/Models/ManagedAccountsGetAllResponse.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[ListManagedAccountError](src/Verizon/Errors/ListManagedAccountError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ManagedAccountsProvisionResponse&gt; ManagedAccountAction(ManagedAccountActionRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Activates a managed billing service relationship between a managed account and the primary account.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Billing.ManagedAccountAction(new ManagedAccountActionRequest
    {
        Body = new ManagedAccountsProvisionRequest
        {
            AccountName = "1223334444-00001",
            PaccountName = "1234567890-00001",
            ServiceName = ServiceName.Location,
            Type = "TS-LOC-COARSE-CellID-5K",
            Txid = "d4fbff33-eeee-ffff-gggg-2c90bd287e3b",
        },
    });
    // TODO: Handle 'response' of type ManagedAccountsProvisionResponse
}
catch (ApiException<ManagedAccountActionError> ex)
{
    if (ex.Error.TryGetDeviceLocationResult(out var error))
    {
        // TODO: Handle 'error' of type DeviceLocationResult
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ManagedAccountActionRequest](src/Verizon/Requests/Billing/ManagedAccountActionRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ManagedAccountsProvisionResponse](src/Verizon/Models/ManagedAccountsProvisionResponse.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[ManagedAccountActionError](src/Verizon/Errors/ManagedAccountActionError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## CampaignsV2

> Source: [CampaignsV2](src/Verizon/Api/CampaignsV2.cs)

<details>
<summary><code>Task&lt;FotaV2SuccessResult&gt; CancelCampaign(CancelCampaignRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This endpoint allows user to cancel software upgrade. A software upgrade already started can not be cancelled.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CampaignsV2.CancelCampaign(new CancelCampaignRequest
    {
        Account = "0000123456-00001",
        CampaignId = "60b5d639-ccdc-4db8-8824-069bd94c95bf",
    });
    // TODO: Handle 'response' of type FotaV2SuccessResult
}
catch (ApiException<CancelCampaignError> ex)
{
    if (ex.Error.TryGetFotaV2Result(out var error))
    {
        // TODO: Handle 'error' of type FotaV2Result
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CancelCampaignRequest](src/Verizon/Requests/CampaignsV2/CancelCampaignRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[FotaV2SuccessResult](src/Verizon/Models/FotaV2SuccessResult.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[CancelCampaignError](src/Verizon/Errors/CancelCampaignError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CampaignSoftware&gt; GetCampaignInformation(GetCampaignInformationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This endpoint allows user to get information of a software upgrade.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CampaignsV2.GetCampaignInformation(new GetCampaignInformationRequest
    {
        Account = "0000123456-00001",
        CampaignId = "60b5d639-ccdc-4db8-8824-069bd94c95bf",
    });
    // TODO: Handle 'response' of type CampaignSoftware
}
catch (ApiException<GetCampaignInformationError> ex)
{
    if (ex.Error.TryGetFotaV2Result(out var error))
    {
        // TODO: Handle 'error' of type FotaV2Result
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetCampaignInformationRequest](src/Verizon/Requests/CampaignsV2/GetCampaignInformationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CampaignSoftware](src/Verizon/Models/CampaignSoftware.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[GetCampaignInformationError](src/Verizon/Errors/GetCampaignInformationError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CampaignSoftware&gt; ScheduleCampaignFirmwareUpgrade(ScheduleCampaignFirmwareUpgradeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This endpoint allows user to schedule a software upgrade.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CampaignsV2.ScheduleCampaignFirmwareUpgrade(new ScheduleCampaignFirmwareUpgradeRequest
    {
        Account = "0000123456-00001",
    });
    // TODO: Handle 'response' of type CampaignSoftware
}
catch (ApiException<ScheduleCampaignFirmwareUpgradeError> ex)
{
    if (ex.Error.TryGetFotaV2Result(out var error))
    {
        // TODO: Handle 'error' of type FotaV2Result
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ScheduleCampaignFirmwareUpgradeRequest](src/Verizon/Requests/CampaignsV2/ScheduleCampaignFirmwareUpgradeRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CampaignSoftware](src/Verizon/Models/CampaignSoftware.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[ScheduleCampaignFirmwareUpgradeError](src/Verizon/Errors/ScheduleCampaignFirmwareUpgradeError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UploadAndScheduleFileResponse&gt; ScheduleFileUpgrade(ScheduleFileUpgradeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

You can upload configuration files and schedule them in a campaign to devices.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CampaignsV2.ScheduleFileUpgrade(new ScheduleFileUpgradeRequest
    {
        Acc = "0402196254-00001",
        Body = new UploadAndScheduleFileRequest(),
    });
    // TODO: Handle 'response' of type UploadAndScheduleFileResponse
}
catch (ApiException<ScheduleFileUpgradeError> ex)
{
    if (ex.Error.TryGetFotaV2Result(out var error))
    {
        // TODO: Handle 'error' of type FotaV2Result
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ScheduleFileUpgradeRequest](src/Verizon/Requests/CampaignsV2/ScheduleFileUpgradeRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UploadAndScheduleFileResponse](src/Verizon/Models/UploadAndScheduleFileResponse.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[ScheduleFileUpgradeError](src/Verizon/Errors/ScheduleFileUpgradeError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UploadAndScheduleFileResponse&gt; ScheduleSwUpgradeHttpDevices(ScheduleSwUpgradeHttpDevicesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Campaign time windows for downloading and installing software are available as long as the device OEM supports this.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CampaignsV2.ScheduleSwUpgradeHttpDevices(new ScheduleSwUpgradeHttpDevicesRequest
    {
        Acc = "0402196254-00001",
        Body = new SchedulesSoftwareUpgradeRequest
        {
            CampaignName = "FOTA_Verizon_Upgrade",
            SoftwareName = "FOTA_Verizon_Model-A_02To03_HF",
            SoftwareFrom = "FOTA_Verizon_Model-A_00To01_HF",
            SoftwareTo = "FOTA_Verizon_Model-A_02To03_HF",
            DistributionType = "HTTP",
            StartDate = "2020-08-21",
            EndDate = "2020-08-22",
            DownloadAfterDate = "2020-08-21",
            DownloadTimeWindowList = [new DownloadTimeWindow { StartTime = "20", EndTime = "21" }],
            InstallAfterDate = "2020-08-21",
            InstallTimeWindowList = [new DownloadTimeWindow { StartTime = "22", EndTime = "23" }],
            DeviceList = ["990013907835573", "990013907884259"],
        },
    });
    // TODO: Handle 'response' of type UploadAndScheduleFileResponse
}
catch (ApiException<ScheduleSwUpgradeHttpDevicesError> ex)
{
    if (ex.Error.TryGetFotaV2Result(out var error))
    {
        // TODO: Handle 'error' of type FotaV2Result
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ScheduleSwUpgradeHttpDevicesRequest](src/Verizon/Requests/CampaignsV2/ScheduleSwUpgradeHttpDevicesRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UploadAndScheduleFileResponse](src/Verizon/Models/UploadAndScheduleFileResponse.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[ScheduleSwUpgradeHttpDevicesError](src/Verizon/Errors/ScheduleSwUpgradeHttpDevicesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CampaignSoftware&gt; UpdateCampaignDates(UpdateCampaignDatesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This endpoint allows user to change campaign dates and time windows. Fields which need to remain unchanged should be also provided.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CampaignsV2.UpdateCampaignDates(new UpdateCampaignDatesRequest
    {
        Account = "0000123456-00001",
        CampaignId = "60b5d639-ccdc-4db8-8824-069bd94c95bf",
    });
    // TODO: Handle 'response' of type CampaignSoftware
}
catch (ApiException<UpdateCampaignDatesError> ex)
{
    if (ex.Error.TryGetFotaV2Result(out var error))
    {
        // TODO: Handle 'error' of type FotaV2Result
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UpdateCampaignDatesRequest](src/Verizon/Requests/CampaignsV2/UpdateCampaignDatesRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CampaignSoftware](src/Verizon/Models/CampaignSoftware.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[UpdateCampaignDatesError](src/Verizon/Errors/UpdateCampaignDatesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V2AddOrRemoveDeviceResult&gt; UpdateCampaignFirmwareDevices(UpdateCampaignFirmwareDevicesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This endpoint allows user to Add or Remove devices to an existing software upgrade.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CampaignsV2.UpdateCampaignFirmwareDevices(new UpdateCampaignFirmwareDevicesRequest
    {
        Account = "0000123456-00001",
        CampaignId = "60b5d639-ccdc-4db8-8824-069bd94c95bf",
    });
    // TODO: Handle 'response' of type V2AddOrRemoveDeviceResult
}
catch (ApiException<UpdateCampaignFirmwareDevicesError> ex)
{
    if (ex.Error.TryGetFotaV2Result(out var error))
    {
        // TODO: Handle 'error' of type FotaV2Result
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UpdateCampaignFirmwareDevicesRequest](src/Verizon/Requests/CampaignsV2/UpdateCampaignFirmwareDevicesRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V2AddOrRemoveDeviceResult](src/Verizon/Models/V2AddOrRemoveDeviceResult.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[UpdateCampaignFirmwareDevicesError](src/Verizon/Errors/UpdateCampaignFirmwareDevicesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## CampaignsV3

> Source: [CampaignsV3](src/Verizon/Api/CampaignsV3.cs)

<details>
<summary><code>Task&lt;FotaV3SuccessResult&gt; CancelCampaign2(CancelCampaign2Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This endpoint allows user to cancel a firmware campaign. A firmware campaign already started can not be cancelled.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CampaignsV3.CancelCampaign2(new CancelCampaign2Request
    {
        AccountName = "0000123456-00001",
        CampaignId = "f858b8c4-2153-11ec-8c44-aeb16d1aa652",
    });
    // TODO: Handle 'response' of type FotaV3SuccessResult
}
catch (ApiException<CancelCampaign2Error> ex)
{
    if (ex.Error.TryGetFotaV3Result(out var error))
    {
        // TODO: Handle 'error' of type FotaV3Result
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CancelCampaign2Request](src/Verizon/Requests/CampaignsV3/CancelCampaign2Request.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[FotaV3SuccessResult](src/Verizon/Models/FotaV3SuccessResult.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[CancelCampaign2Error](src/Verizon/Errors/CancelCampaign2Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Campaign&gt; GetCampaignInformation2(GetCampaignInformation2Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This endpoint allows the user to retrieve campaign level information for a specified campaign.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CampaignsV3.GetCampaignInformation2(new GetCampaignInformation2Request
    {
        AccountName = "0000123456-00001",
        CampaignId = "f858b8c4-2153-11ec-8c44-aeb16d1aa652",
    });
    // TODO: Handle 'response' of type Campaign
}
catch (ApiException<GetCampaignInformation2Error> ex)
{
    if (ex.Error.TryGetFotaV3Result(out var error))
    {
        // TODO: Handle 'error' of type FotaV3Result
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetCampaignInformation2Request](src/Verizon/Requests/CampaignsV3/GetCampaignInformation2Request.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Campaign](src/Verizon/Models/Campaign.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[GetCampaignInformation2Error](src/Verizon/Errors/GetCampaignInformation2Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;FirmwareCampaign&gt; ScheduleCampaignFirmwareUpgrade2(ScheduleCampaignFirmwareUpgrade2Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This endpoint allows a user to schedule a firmware upgrade for a list of devices.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CampaignsV3.ScheduleCampaignFirmwareUpgrade2(new ScheduleCampaignFirmwareUpgrade2Request
    {
        AccountName = "0000123456-00001",
        Body = new CampaignFirmwareUpgrade
        {
            CampaignName = "Smart FOTA - test 4",
            FirmwareName = "SEQUANSCommunications_GM01Q_SR1.2.0.0-10512_SR1.2.0.0-10657",
            FirmwareFrom = "SR1.2.0.0-10512",
            FirmwareTo = "SR1.2.0.0-10657",
            Protocol = "LWM2M",
            StartDate = DateTimeOffset.Parse("2021-09-29T00:00:00Z"),
            EndDate = DateTimeOffset.Parse("2021-10-01T00:00:00Z"),
            CampaignTimeWindowList = [new V3TimeWindow { StartTime = 18, EndTime = 22 }],
            DeviceList = ["15-digit IMEI"],
            AutoAssignLicenseFlag = false,
            AutoAddDevicesFlag = false,
        },
    });
    // TODO: Handle 'response' of type FirmwareCampaign
}
catch (ApiException<ScheduleCampaignFirmwareUpgrade2Error> ex)
{
    if (ex.Error.TryGetFotaV3Result(out var error))
    {
        // TODO: Handle 'error' of type FotaV3Result
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ScheduleCampaignFirmwareUpgrade2Request](src/Verizon/Requests/CampaignsV3/ScheduleCampaignFirmwareUpgrade2Request.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[FirmwareCampaign](src/Verizon/Models/FirmwareCampaign.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[ScheduleCampaignFirmwareUpgrade2Error](src/Verizon/Errors/ScheduleCampaignFirmwareUpgrade2Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;FirmwareCampaign&gt; UpdateCampaignDates2(UpdateCampaignDates2Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This endpoint allows user to change campaign dates and time windows. Fields which need to remain unchanged should be also provided.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CampaignsV3.UpdateCampaignDates2(new UpdateCampaignDates2Request
    {
        Acc = "0000123456-00001",
        CampaignId = "f858b8c4-2153-11ec-8c44-aeb16d1aa652",
        Body = new V3ChangeCampaignDatesRequest
        {
            StartDate = DateTimeOffset.Parse("2022-02-23T00:00:00Z"),
            EndDate = DateTimeOffset.Parse("2022-02-24T00:00:00Z"),
            CampaignTimeWindowList = [new V3TimeWindow { StartTime = 14, EndTime = 18 }],
        },
    });
    // TODO: Handle 'response' of type FirmwareCampaign
}
catch (ApiException<UpdateCampaignDates2Error> ex)
{
    if (ex.Error.TryGetFotaV3Result(out var error))
    {
        // TODO: Handle 'error' of type FotaV3Result
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UpdateCampaignDates2Request](src/Verizon/Requests/CampaignsV3/UpdateCampaignDates2Request.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[FirmwareCampaign](src/Verizon/Models/FirmwareCampaign.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[UpdateCampaignDates2Error](src/Verizon/Errors/UpdateCampaignDates2Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V3AddOrRemoveDeviceResult&gt; UpdateCampaignFirmwareDevices2(UpdateCampaignFirmwareDevices2Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This endpoint allows user to Add or Remove devices to an existing campaign.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CampaignsV3.UpdateCampaignFirmwareDevices2(new UpdateCampaignFirmwareDevices2Request
    {
        Acc = "0000123456-00001",
        CampaignId = "f858b8c4-2153-11ec-8c44-aeb16d1aa652",
        Body = new V3AddOrRemoveDeviceRequest { Type = "remove", DeviceList = ["15-digit IMEI"] },
    });
    // TODO: Handle 'response' of type V3AddOrRemoveDeviceResult
}
catch (ApiException<UpdateCampaignFirmwareDevices2Error> ex)
{
    if (ex.Error.TryGetFotaV3Result(out var error))
    {
        // TODO: Handle 'error' of type FotaV3Result
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UpdateCampaignFirmwareDevices2Request](src/Verizon/Requests/CampaignsV3/UpdateCampaignFirmwareDevices2Request.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V3AddOrRemoveDeviceResult](src/Verizon/Models/V3AddOrRemoveDeviceResult.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[UpdateCampaignFirmwareDevices2Error](src/Verizon/Errors/UpdateCampaignFirmwareDevices2Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## ClientLogging

> Source: [ClientLogging](src/Verizon/Api/ClientLogging.cs)

<details>
<summary><code>Task DisableDeviceLogging(DisableDeviceLoggingRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Disables logging for a specific device.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.ClientLogging.DisableDeviceLogging(new DisableDeviceLoggingRequest
    {
        Account = "0000123456-00001",
        DeviceId = "990013907835573",
    });
}
catch (ApiException<DisableDeviceLoggingError> ex)
{
    if (ex.Error.TryGetFotaV2Result(out var error))
    {
        // TODO: Handle 'error' of type FotaV2Result
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DisableDeviceLoggingRequest](src/Verizon/Requests/ClientLogging/DisableDeviceLoggingRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[DisableDeviceLoggingError](src/Verizon/Errors/DisableDeviceLoggingError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task DisableLoggingForDevices(DisableLoggingForDevicesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Turn logging off for a list of devices.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.ClientLogging.DisableLoggingForDevices(new DisableLoggingForDevicesRequest
    {
        Account = "0000123456-00001",
        DeviceIds = "990013907835573",
    });
}
catch (ApiException<DisableLoggingForDevicesError> ex)
{
    if (ex.Error.TryGetFotaV2Result(out var error))
    {
        // TODO: Handle 'error' of type FotaV2Result
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DisableLoggingForDevicesRequest](src/Verizon/Requests/ClientLogging/DisableLoggingForDevicesRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[DisableLoggingForDevicesError](src/Verizon/Errors/DisableLoggingForDevicesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeviceLoggingStatus&gt; EnableDeviceLogging(EnableDeviceLoggingRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Enables logging for a specific device.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ClientLogging.EnableDeviceLogging(new EnableDeviceLoggingRequest
    {
        Account = "0000123456-00001",
        DeviceId = "990013907835573",
    });
    // TODO: Handle 'response' of type DeviceLoggingStatus
}
catch (ApiException<EnableDeviceLoggingError> ex)
{
    if (ex.Error.TryGetFotaV2Result(out var error))
    {
        // TODO: Handle 'error' of type FotaV2Result
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[EnableDeviceLoggingRequest](src/Verizon/Requests/ClientLogging/EnableDeviceLoggingRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeviceLoggingStatus](src/Verizon/Models/DeviceLoggingStatus.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[EnableDeviceLoggingError](src/Verizon/Errors/EnableDeviceLoggingError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;DeviceLoggingStatus&gt;&gt; EnableLoggingForDevices(EnableLoggingForDevicesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Each customer may have a maximum of 20 devices enabled for logging.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ClientLogging.EnableLoggingForDevices(new EnableLoggingForDevicesRequest
    {
        Account = "0000123456-00001",
    });
    // TODO: Handle 'response' of type IReadOnlyList<DeviceLoggingStatus>
}
catch (ApiException<EnableLoggingForDevicesError> ex)
{
    if (ex.Error.TryGetFotaV2Result(out var error))
    {
        // TODO: Handle 'error' of type FotaV2Result
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[EnableLoggingForDevicesRequest](src/Verizon/Requests/ClientLogging/EnableLoggingForDevicesRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[DeviceLoggingStatus](src/Verizon/Models/DeviceLoggingStatus.cs)&gt;</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[EnableLoggingForDevicesError](src/Verizon/Errors/EnableLoggingForDevicesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;DeviceLog&gt;&gt; ListDeviceLogs(ListDeviceLogsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Gets logs for a specific device.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ClientLogging.ListDeviceLogs(new ListDeviceLogsRequest
    {
        Account = "0000123456-00001",
        DeviceId = "990013907835573",
    });
    // TODO: Handle 'response' of type IReadOnlyList<DeviceLog>
}
catch (ApiException<ListDeviceLogsError> ex)
{
    if (ex.Error.TryGetFotaV2Result(out var error))
    {
        // TODO: Handle 'error' of type FotaV2Result
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ListDeviceLogsRequest](src/Verizon/Requests/ClientLogging/ListDeviceLogsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[DeviceLog](src/Verizon/Models/DeviceLog.cs)&gt;</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[ListDeviceLogsError](src/Verizon/Errors/ListDeviceLogsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;DeviceLoggingStatus&gt;&gt; ListDevicesWithLoggingEnabled(ListDevicesWithLoggingEnabledRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns an array of all devices in the specified account for which logging is enabled.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ClientLogging.ListDevicesWithLoggingEnabled(new ListDevicesWithLoggingEnabledRequest
    {
        Account = "0000123456-00001",
    });
    // TODO: Handle 'response' of type IReadOnlyList<DeviceLoggingStatus>
}
catch (ApiException<ListDevicesWithLoggingEnabledError> ex)
{
    if (ex.Error.TryGetFotaV2Result(out var error))
    {
        // TODO: Handle 'error' of type FotaV2Result
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ListDevicesWithLoggingEnabledRequest](src/Verizon/Requests/ClientLogging/ListDevicesWithLoggingEnabledRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[DeviceLoggingStatus](src/Verizon/Models/DeviceLoggingStatus.cs)&gt;</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[ListDevicesWithLoggingEnabledError](src/Verizon/Errors/ListDevicesWithLoggingEnabledError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## CloudConnectorDevices

> Source: [CloudConnectorDevices](src/Verizon/Api/CloudConnectorDevices.cs)

<details>
<summary><code>Task DeleteDeviceFromAccount(DeleteDeviceFromAccountRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Remove a device from a ThingSpace account.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.CloudConnectorDevices.DeleteDeviceFromAccount(new DeleteDeviceFromAccountRequest
    {
        Body = new RemoveDeviceRequest
        {
            Accountidentifier = new AccountIdentifier { Billingaccountid = "1223334444-00001" },
            Resourceidentifier = new ResourceIdentifier { Imei = "864508030084997" },
        },
    });
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeleteDeviceFromAccountRequest](src/Verizon/Requests/CloudConnectorDevices/DeleteDeviceFromAccountRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Verizon/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;FindDeviceByPropertyResponseList&gt; FindDeviceByPropertyValues(FindDeviceByPropertyValuesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Find devices by property values. Returns an array of all matching device resources.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CloudConnectorDevices.FindDeviceByPropertyValues(new FindDeviceByPropertyValuesRequest
    {
        Body = new QuerySubscriptionRequest
        {
            Accountidentifier = new AccountIdentifier { Billingaccountid = "1223334444-00001" },
            Resourceidentifier = new ResourceIdentifier { Imei = "159495694333703" },
        },
    });
    // TODO: Handle 'response' of type FindDeviceByPropertyResponseList
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[FindDeviceByPropertyValuesRequest](src/Verizon/Requests/CloudConnectorDevices/FindDeviceByPropertyValuesRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[FindDeviceByPropertyResponseList](src/Verizon/Models/FindDeviceByPropertyResponseList.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Verizon/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SearchDeviceEventHistoryResponseList&gt; SearchDeviceEventHistory(SearchDeviceEventHistoryOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Search device event history to find events that match criteria.Sensor readings, configuration changes, and other device data are all stored as events.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CloudConnectorDevices.SearchDeviceEventHistory(
        new SearchDeviceEventHistoryOperationRequest
        {
            Body = new SearchDeviceEventHistoryRequest
            {
                Accountidentifier = new AccountIdentifier { Billingaccountid = "1223334444-00001" },
                Selection = new Dictionary<string, string> { ["kind"] = "ts.event.configuration" },
                Resourceidentifier = new ResourceIdentifier { Imei = "864508030084997" },
                Limitnumber = 2,
            },
        });
    // TODO: Handle 'response' of type SearchDeviceEventHistoryResponseList
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SearchDeviceEventHistoryOperationRequest](src/Verizon/Requests/CloudConnectorDevices/SearchDeviceEventHistoryOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SearchDeviceEventHistoryResponseList](src/Verizon/Models/SearchDeviceEventHistoryResponseList.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Verizon/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SearchDeviceByPropertyResponseList&gt; SearchDevicesResourcesByPropertyValues(SearchDevicesResourcesByPropertyValuesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Search for devices by property values. Returns an array of all matching device resources.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CloudConnectorDevices.SearchDevicesResourcesByPropertyValues(
        new SearchDevicesResourcesByPropertyValuesRequest
        {
            Body = new QuerySubscriptionRequest
            {
                Accountidentifier = new AccountIdentifier { Billingaccountid = "1223334444-00001" },
                Selection = new Dictionary<string, string> { ["iccid"] = "89148000003499233389" },
            },
        });
    // TODO: Handle 'response' of type SearchDeviceByPropertyResponseList
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SearchDevicesResourcesByPropertyValuesRequest](src/Verizon/Requests/CloudConnectorDevices/SearchDevicesResourcesByPropertyValuesRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SearchDeviceByPropertyResponseList](src/Verizon/Models/SearchDeviceByPropertyResponseList.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Verizon/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SearchSensorHistoryResponseList&gt; SearchSensorReadings(SearchSensorReadingsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the readings of a specified sensor, with the most recent reading first. Sensor readings are stored as events; this request an array of events.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CloudConnectorDevices.SearchSensorReadings(new SearchSensorReadingsRequest
    {
        Fieldname = "some example string",
        Body = new SearchSensorHistoryRequest
        {
            Accountidentifier = new AccountIdentifier { Billingaccountid = "1223334444-00001" },
            Resourceidentifier = new ResourceIdentifier { Imei = "864508030084997" },
            Limitnumber = 2,
        },
    });
    // TODO: Handle 'response' of type SearchSensorHistoryResponseList
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SearchSensorReadingsRequest](src/Verizon/Requests/CloudConnectorDevices/SearchSensorReadingsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SearchSensorHistoryResponseList](src/Verizon/Models/SearchSensorHistoryResponseList.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Verizon/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ChangeConfigurationResponse&gt; UpdateDevicesConfigurationValue(UpdateDevicesConfigurationValueRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Change configuration values on a device, such as setting how often a device records and reports sensor readings.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CloudConnectorDevices.UpdateDevicesConfigurationValue(
        new UpdateDevicesConfigurationValueRequest
        {
            Body = new ChangeConfigurationRequest
            {
                Accountidentifier = new AccountIdentifier { Billingaccountid = "1223334444-00001" },
                Resourceidentifier = new ResourceIdentifier { Imei = "864508030147323" },
                Configuration = new ConfigurationModel { Frequency = "Low" },
            },
        });
    // TODO: Handle 'response' of type ChangeConfigurationResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UpdateDevicesConfigurationValueRequest](src/Verizon/Requests/CloudConnectorDevices/UpdateDevicesConfigurationValueRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ChangeConfigurationResponse](src/Verizon/Models/ChangeConfigurationResponse.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Verizon/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## CloudConnectorSubscriptions

> Source: [CloudConnectorSubscriptions](src/Verizon/Api/CloudConnectorSubscriptions.cs)

<details>
<summary><code>Task&lt;Subscription&gt; CreateSubscription(CreateSubscriptionOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Create a subscription to define a streaming channel that sends data from devices in the account to an endpoint defined in a target resource.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CloudConnectorSubscriptions.CreateSubscription(new CreateSubscriptionOperationRequest
    {
        Body = new CreateSubscriptionRequest
        {
            Accountidentifier = new AccountIdentifier { Billingaccountid = "1223334444-00001" },
            Email = "me@mycompany.com",
            Billingaccountid = "1223334444-00001",
            Streamkind = "ts.event",
            Targetid = "{target ID}",
            Name = "Account subscription 1",
            Allowaggregation = false,
        },
    });
    // TODO: Handle 'response' of type Subscription
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CreateSubscriptionOperationRequest](src/Verizon/Requests/CloudConnectorSubscriptions/CreateSubscriptionOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Subscription](src/Verizon/Models/Subscription.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Verizon/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task DeleteSubscription(DeleteSubscriptionOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Remove a subscription from a ThingSpace account.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.CloudConnectorSubscriptions.DeleteSubscription(new DeleteSubscriptionOperationRequest
    {
        Body = new DeleteSubscriptionRequest
        {
            Accountidentifier = new AccountIdentifier { Billingaccountid = "1223334444-00001" },
            Resourceidentifier = new ResourceIdentifier { Id = "f8b112df-739c-6236-f059-106c67bafd99" },
        },
    });
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeleteSubscriptionOperationRequest](src/Verizon/Requests/CloudConnectorSubscriptions/DeleteSubscriptionOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Verizon/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;Subscription&gt;&gt; QuerySubscription(QuerySubscriptionOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Search for subscriptions by property values. Returns an array of all matching subscription resources.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CloudConnectorSubscriptions.QuerySubscription(new QuerySubscriptionOperationRequest
    {
        Body = new QuerySubscriptionRequest
        {
            Accountidentifier = new AccountIdentifier { Billingaccountid = "1223334444-00001" },
            Resourceidentifier = new ResourceIdentifier { Id = "dd1682d3-2d80-cefc-f3ee-25154800beff" },
        },
    });
    // TODO: Handle 'response' of type IReadOnlyList<Subscription>
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[QuerySubscriptionOperationRequest](src/Verizon/Requests/CloudConnectorSubscriptions/QuerySubscriptionOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[Subscription](src/Verizon/Models/Subscription.cs)&gt;</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Verizon/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## ConfigurationFiles

> Source: [ConfigurationFiles](src/Verizon/Api/ConfigurationFiles.cs)

<details>
<summary><code>Task&lt;RetrievesAvailableFilesResponseList&gt; GetListOfFiles(GetListOfFilesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

You can retrieve a list of configuration or supplementary of files for an account.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ConfigurationFiles.GetListOfFiles(new GetListOfFilesRequest
    {
        Acc = "0402196254-00001",
        DistributionType = "HTTP",
    });
    // TODO: Handle 'response' of type RetrievesAvailableFilesResponseList
}
catch (ApiException<GetListOfFilesError> ex)
{
    if (ex.Error.TryGetFotaV2Result(out var error))
    {
        // TODO: Handle 'error' of type FotaV2Result
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetListOfFilesRequest](src/Verizon/Requests/ConfigurationFiles/GetListOfFilesRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RetrievesAvailableFilesResponseList](src/Verizon/Models/RetrievesAvailableFilesResponseList.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[GetListOfFilesError](src/Verizon/Errors/GetListOfFilesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UploadConfigurationFilesResponse&gt; UploadConfigFile(UploadConfigFileRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Uploads a configuration/supplementary file for an account. ThingSpace generates a fileName after the upload and is returned in the response.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ConfigurationFiles.UploadConfigFile(new UploadConfigFileRequest
    {
        Acc = "0402196254-00001",
        FileVersion = "1.0",
        Make = "Verizon",
        Model = "VZW1",
        LocalTargetPath = "/VZWFOTA/hello-world.txt",
    });
    // TODO: Handle 'response' of type UploadConfigurationFilesResponse
}
catch (ApiException<UploadConfigFileError> ex)
{
    if (ex.Error.TryGetFotaV2Result(out var error))
    {
        // TODO: Handle 'error' of type FotaV2Result
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UploadConfigFileRequest](src/Verizon/Requests/ConfigurationFiles/UploadConfigFileRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UploadConfigurationFilesResponse](src/Verizon/Models/UploadConfigurationFilesResponse.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[UploadConfigFileError](src/Verizon/Errors/UploadConfigFileError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## ConnectivityCallbacks

> Source: [ConnectivityCallbacks](src/Verizon/Api/ConnectivityCallbacks.cs)

<details>
<summary><code>Task&lt;CallbackActionResult&gt; DeregisterCallback(DeregisterCallbackRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Stops ThingSpace from sending callback messages for the specified account and service.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ConnectivityCallbacks.DeregisterCallback(new DeregisterCallbackRequest
    {
        Aname = "1223334444-00001",
        Sname = "CarrierService",
    });
    // TODO: Handle 'response' of type CallbackActionResult
}
catch (ApiException<DeregisterCallbackError> ex)
{
    if (ex.Error.TryGetConnectivityManagementResult(out var error))
    {
        // TODO: Handle 'error' of type ConnectivityManagementResult
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeregisterCallbackRequest](src/Verizon/Requests/ConnectivityCallbacks/DeregisterCallbackRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CallbackActionResult](src/Verizon/Models/CallbackActionResult.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[DeregisterCallbackError](src/Verizon/Errors/DeregisterCallbackError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;ConnectivityManagementCallback&gt;&gt; ListRegisteredCallbacks(ListRegisteredCallbacksRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the name and endpoint URL of the callback listening services registered for a given account.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ConnectivityCallbacks.ListRegisteredCallbacks(new ListRegisteredCallbacksRequest
    {
        Aname = "0252012345-00001",
    });
    // TODO: Handle 'response' of type IReadOnlyList<ConnectivityManagementCallback>
}
catch (ApiException<ListRegisteredCallbacksError> ex)
{
    if (ex.Error.TryGetConnectivityManagementResult(out var error))
    {
        // TODO: Handle 'error' of type ConnectivityManagementResult
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ListRegisteredCallbacksRequest](src/Verizon/Requests/ConnectivityCallbacks/ListRegisteredCallbacksRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[ConnectivityManagementCallback](src/Verizon/Models/ConnectivityManagementCallback.cs)&gt;</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[ListRegisteredCallbacksError](src/Verizon/Errors/ListRegisteredCallbacksError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CallbackActionResult&gt; RegisterCallback(RegisterCallbackOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

You are responsible for creating and running a listening process on your server at that URL.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ConnectivityCallbacks.RegisterCallback(new RegisterCallbackOperationRequest
    {
        Aname = "TestAccount-2",
        Body = new RegisterCallbackRequest
        {
            Name = "CarrierService",
            Url = "https://mock.thingspace.verizon.com/webhook",
        },
    });
    // TODO: Handle 'response' of type CallbackActionResult
}
catch (ApiException<RegisterCallbackError> ex)
{
    if (ex.Error.TryGetConnectivityManagementResult(out var error))
    {
        // TODO: Handle 'error' of type ConnectivityManagementResult
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[RegisterCallbackOperationRequest](src/Verizon/Requests/ConnectivityCallbacks/RegisterCallbackOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CallbackActionResult](src/Verizon/Models/CallbackActionResult.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[RegisterCallbackError](src/Verizon/Errors/RegisterCallbackError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## CreatePricePlanTriggers

> Source: [CreatePricePlanTriggers](src/Verizon/Api/CreatePricePlanTriggers.cs)

<details>
<summary><code>Task&lt;TriggerResponse&gt; CreateTriggerRules(CreateTriggerRulesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Create a usage trigger at the account level, device level or a price plan trigger for all devices on the account

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CreatePricePlanTriggers.CreateTriggerRules(new CreateTriggerRulesRequest
    {
        Body = new AccountLevelCreateTriggerRequest
        {
            TriggerName = "name of the trigger",
            EcpdId = "Verizon profile ID",
            TriggerCategory = TriggerCategory.AccountUsage,
            DataTrigger = new DataTrigger
            {
                AccountLevel = new AccountLevelObject
                {
                    FilterCriteria = new AccountLevelFilter(),
                    Condition = new ConditionObjectCall(),
                    Action = AccountLevelAction.Notify,
                },
            },
            Notification = new Notificationarray
            {
                NotificationType = "PerEvent",
                Callback = true,
                EmailNotification = false,
                NotificationGroupName = "NotificationGroupName",
                NotificationFrequencyFactor = 3,
                NotificationFrequencyInterval = "Daily",
                ExternalEmailRecipients = "ExternalEmailRecipients",
                SmsNotification = true,
                SmsNumbers = [
                    new Cellphonenumber { Number = "10-digit mobile number", Carrier = "mobile service provider" },
                    new Cellphonenumber { Number = "10-digit mobile number", Carrier = "mobile service provider" },
                ],
                Reminder = true,
                Severity = "Notice",
            },
            Active = Active.True,
        },
    });
    // TODO: Handle 'response' of type TriggerResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CreateTriggerRulesRequest](src/Verizon/Requests/CreatePricePlanTriggers/CreateTriggerRulesRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TriggerResponse](src/Verizon/Models/TriggerResponse.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Verizon/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## DeviceActions

> Source: [DeviceActions](src/Verizon/Api/DeviceActions.cs)

<details>
<summary><code>Task&lt;AccountDetails&gt; AccountInformation(AccountInformationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieve all of the service plans, features and carriers associated with the account specified.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DeviceActions.AccountInformation(new AccountInformationRequest
    {
        AccountName = "some example string",
    });
    // TODO: Handle 'response' of type AccountDetails
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AccountInformationRequest](src/Verizon/Requests/DeviceActions/AccountInformationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AccountDetails](src/Verizon/Models/AccountDetails.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Verizon/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GioRequestResponse&gt; AggregateUsage(AggregateUsageRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieve the aggregate usage for a device or a number of devices.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DeviceActions.AggregateUsage(new AggregateUsageRequest { Body = new AggregateUsage() });
    // TODO: Handle 'response' of type GioRequestResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AggregateUsageRequest](src/Verizon/Requests/DeviceActions/AggregateUsageRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GioRequestResponse](src/Verizon/Models/GioRequestResponse.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Verizon/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DailyUsageResponse&gt; DailyUsage(DailyUsageRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieve the daily usage for a device, for a specified period of time, segmented by day

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DeviceActions.DailyUsage(new DailyUsageRequest { Body = new DailyUsage() });
    // TODO: Handle 'response' of type DailyUsageResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DailyUsageRequest](src/Verizon/Requests/DeviceActions/DailyUsageRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DailyUsageResponse](src/Verizon/Models/DailyUsageResponse.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Verizon/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;StatusResponse&gt; GetAsynchronousRequestStatus(GetAsynchronousRequestStatusRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Get the status of an asynchronous request made with the Device Actions.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DeviceActions.GetAsynchronousRequestStatus(new GetAsynchronousRequestStatusRequest
    {
        AccountName = "0000123456-00001",
        RequestId = "d1f08526-5443-4054-9a29-4456490ea9f8",
    });
    // TODO: Handle 'response' of type StatusResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetAsynchronousRequestStatusRequest](src/Verizon/Requests/DeviceActions/GetAsynchronousRequestStatusRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[StatusResponse](src/Verizon/Models/StatusResponse.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Verizon/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GioRequestResponse&gt; RetrieveDeviceProvisioningHistory(RetrieveDeviceProvisioningHistoryRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieve the provisioning history of a specific device or devices.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DeviceActions.RetrieveDeviceProvisioningHistory(
        new RetrieveDeviceProvisioningHistoryRequest { Body = new ProvhistoryRequest() });
    // TODO: Handle 'response' of type GioRequestResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[RetrieveDeviceProvisioningHistoryRequest](src/Verizon/Requests/DeviceActions/RetrieveDeviceProvisioningHistoryRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GioRequestResponse](src/Verizon/Models/GioRequestResponse.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Verizon/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GioRequestResponse&gt; RetrieveTheGlobalDeviceList(RetrieveTheGlobalDeviceListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Allows the profile to fetch the complete device list. This works with Verizon US and Global profiles.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DeviceActions.RetrieveTheGlobalDeviceList(new RetrieveTheGlobalDeviceListRequest
    {
        Body = new GetDeviceListWithProfilesRequest { AccountName = "some example string" },
    });
    // TODO: Handle 'response' of type GioRequestResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[RetrieveTheGlobalDeviceListRequest](src/Verizon/Requests/DeviceActions/RetrieveTheGlobalDeviceListRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GioRequestResponse](src/Verizon/Models/GioRequestResponse.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Verizon/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AccountDetails&gt; ServicePlanList(ServicePlanListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieve all of the service plans, features and carriers associated with the account specified.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DeviceActions.ServicePlanList(new ServicePlanListRequest
    {
        AccountName = "some example string",
    });
    // TODO: Handle 'response' of type AccountDetails
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ServicePlanListRequest](src/Verizon/Requests/DeviceActions/ServicePlanListRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AccountDetails](src/Verizon/Models/AccountDetails.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Verizon/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## DeviceCredentialManagement

> Source: [DeviceCredentialManagement](src/Verizon/Api/DeviceCredentialManagement.cs)

<details>
<summary><code>Task&lt;DropResponse&gt; DropCredentials(DropCredentialsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DeviceCredentialManagement.DropCredentials(new DropCredentialsRequest
    {
        Body = new CredentialsRequest
        {
            Ecpd = "some example string",
            AccountNumber = "some example string",
            Items = [new DeviceCredentialRequestItem { Imei = "some example string" }],
        },
    });
    // TODO: Handle 'response' of type DropResponse
}
catch (ApiException<DropCredentialsError> ex)
{
    if (ex.Error.TryGetErrorResponseModel(out var error))
    {
        // TODO: Handle 'error' of type ErrorResponseModel
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DropCredentialsRequest](src/Verizon/Requests/DeviceCredentialManagement/DropCredentialsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DropResponse](src/Verizon/Models/DropResponse.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[DropCredentialsError](src/Verizon/Errors/DropCredentialsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GenerateResponse&gt; GenerateCredentials(GenerateCredentialsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DeviceCredentialManagement.GenerateCredentials(new GenerateCredentialsRequest
    {
        Body = new CredentialsRequest
        {
            Ecpd = "some example string",
            AccountNumber = "some example string",
            Items = [new DeviceCredentialRequestItem { Imei = "some example string" }],
        },
    });
    // TODO: Handle 'response' of type GenerateResponse
}
catch (ApiException<GenerateCredentialsError> ex)
{
    if (ex.Error.TryGetErrorResponseModel(out var error))
    {
        // TODO: Handle 'error' of type ErrorResponseModel
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GenerateCredentialsRequest](src/Verizon/Requests/DeviceCredentialManagement/GenerateCredentialsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GenerateResponse](src/Verizon/Models/GenerateResponse.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[GenerateCredentialsError](src/Verizon/Errors/GenerateCredentialsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GenerateResponse&gt; ResetCredentials(ResetCredentialsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DeviceCredentialManagement.ResetCredentials(new ResetCredentialsRequest
    {
        Body = new CredentialsRequest
        {
            Ecpd = "some example string",
            AccountNumber = "some example string",
            Items = [new DeviceCredentialRequestItem { Imei = "some example string" }],
        },
    });
    // TODO: Handle 'response' of type GenerateResponse
}
catch (ApiException<ResetCredentialsError> ex)
{
    if (ex.Error.TryGetErrorResponseModel(out var error))
    {
        // TODO: Handle 'error' of type ErrorResponseModel
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ResetCredentialsRequest](src/Verizon/Requests/DeviceCredentialManagement/ResetCredentialsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GenerateResponse](src/Verizon/Models/GenerateResponse.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[ResetCredentialsError](src/Verizon/Errors/ResetCredentialsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RetrieveResponse&gt; RetrieveCredentials(RetrieveCredentialsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DeviceCredentialManagement.RetrieveCredentials(new RetrieveCredentialsRequest
    {
        Body = new CredentialsRequest
        {
            Ecpd = "some example string",
            AccountNumber = "some example string",
            Items = [new DeviceCredentialRequestItem { Imei = "some example string" }],
        },
    });
    // TODO: Handle 'response' of type RetrieveResponse
}
catch (ApiException<RetrieveCredentialsError> ex)
{
    if (ex.Error.TryGetErrorResponseModel(out var error))
    {
        // TODO: Handle 'error' of type ErrorResponseModel
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[RetrieveCredentialsRequest](src/Verizon/Requests/DeviceCredentialManagement/RetrieveCredentialsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RetrieveResponse](src/Verizon/Models/RetrieveResponse.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[RetrieveCredentialsError](src/Verizon/Errors/RetrieveCredentialsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## DeviceDiagnostics

> Source: [DeviceDiagnostics](src/Verizon/Api/DeviceDiagnostics.cs)

<details>
<summary><code>Task&lt;DeviceManagementResult&gt; DeviceReachabilityStatusUsingPost(DeviceReachabilityStatusUsingPostRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

If the devices do not already exist in the account, this API resource adds them before activation.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DeviceDiagnostics.DeviceReachabilityStatusUsingPost(
        new DeviceReachabilityStatusUsingPostRequest
        {
            Body = new NotificationReportStatusRequest
            {
                AccountName = "some example string",
                Device = new DeviceId { Id = "some example string", Kind = "some example string" },
                RequestType = "some example string",
            },
        });
    // TODO: Handle 'response' of type DeviceManagementResult
}
catch (ApiException<DeviceReachabilityStatusUsingPostError> ex)
{
    if (ex.Error.TryGetConnectivityManagementResult(out var error))
    {
        // TODO: Handle 'error' of type ConnectivityManagementResult
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeviceReachabilityStatusUsingPostRequest](src/Verizon/Requests/DeviceDiagnostics/DeviceReachabilityStatusUsingPostRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeviceManagementResult](src/Verizon/Models/DeviceManagementResult.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[DeviceReachabilityStatusUsingPostError](src/Verizon/Errors/DeviceReachabilityStatusUsingPostError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeviceManagementResult&gt; RetrieveActiveMonitorsUsingPost(RetrieveActiveMonitorsUsingPostRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieve all the active monitors.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DeviceDiagnostics.RetrieveActiveMonitorsUsingPost(
        new RetrieveActiveMonitorsUsingPostRequest
        {
            Body = new RetrieveMonitorsRequest
            {
                AccountName = "0242123520-00001",
                Devices = [
                    new AccountDeviceList { DeviceIds = [new DeviceId { Id = "12016560696", Kind = "msisdn" }] },
                ],
            },
        });
    // TODO: Handle 'response' of type DeviceManagementResult
}
catch (ApiException<RetrieveActiveMonitorsUsingPostError> ex)
{
    if (ex.Error.TryGetConnectivityManagementResult(out var error))
    {
        // TODO: Handle 'error' of type ConnectivityManagementResult
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[RetrieveActiveMonitorsUsingPostRequest](src/Verizon/Requests/DeviceDiagnostics/RetrieveActiveMonitorsUsingPostRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeviceManagementResult](src/Verizon/Models/DeviceManagementResult.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[RetrieveActiveMonitorsUsingPostError](src/Verizon/Errors/RetrieveActiveMonitorsUsingPostError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## DeviceGroups

> Source: [DeviceGroups](src/Verizon/Api/DeviceGroups.cs)

<details>
<summary><code>Task&lt;ConnectivityManagementSuccessResult&gt; CreateDeviceGroup(CreateDeviceGroupOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Create a new device group and optionally add devices to the group. Device groups can make it easier to manage similar devices and to get reports on their usage.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DeviceGroups.CreateDeviceGroup(new CreateDeviceGroupOperationRequest
    {
        Body = new CreateDeviceGroupRequest
        {
            AccountName = "0000123456-00001",
            GroupDescription = "descriptive string",
            GroupName = "group name",
            DevicesToAdd = [new DeviceId { Id = "15-digit IMEI", Kind = "imei" }],
        },
    });
    // TODO: Handle 'response' of type ConnectivityManagementSuccessResult
}
catch (ApiException<CreateDeviceGroupError> ex)
{
    if (ex.Error.TryGetConnectivityManagementResult(out var error))
    {
        // TODO: Handle 'error' of type ConnectivityManagementResult
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CreateDeviceGroupOperationRequest](src/Verizon/Requests/DeviceGroups/CreateDeviceGroupOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ConnectivityManagementSuccessResult](src/Verizon/Models/ConnectivityManagementSuccessResult.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[CreateDeviceGroupError](src/Verizon/Errors/CreateDeviceGroupError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ConnectivityManagementSuccessResult&gt; DeleteDeviceGroup(DeleteDeviceGroupRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Deletes a device group from the account. Devices in the group are moved to the default device group and are not deleted from the account.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DeviceGroups.DeleteDeviceGroup(new DeleteDeviceGroupRequest
    {
        Aname = "0252012345-00001",
        Gname = "some example string",
    });
    // TODO: Handle 'response' of type ConnectivityManagementSuccessResult
}
catch (ApiException<DeleteDeviceGroupError> ex)
{
    if (ex.Error.TryGetConnectivityManagementResult(out var error))
    {
        // TODO: Handle 'error' of type ConnectivityManagementResult
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeleteDeviceGroupRequest](src/Verizon/Requests/DeviceGroups/DeleteDeviceGroupRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ConnectivityManagementSuccessResult](src/Verizon/Models/ConnectivityManagementSuccessResult.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[DeleteDeviceGroupError](src/Verizon/Errors/DeleteDeviceGroupError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeviceGroupDevicesData&gt; GetDeviceGroupInformation(GetDeviceGroupInformationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

When HTTP status is 202, a URL will be returned in the Location header of the form /groups/{aname}/name/{gname}/?next={token}. This URL can be used to request the next set of groups.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DeviceGroups.GetDeviceGroupInformation(new GetDeviceGroupInformationRequest
    {
        Aname = "0252012345-00001",
        Gname = "some example string",
    });
    // TODO: Handle 'response' of type DeviceGroupDevicesData
}
catch (ApiException<GetDeviceGroupInformationError> ex)
{
    if (ex.Error.TryGetConnectivityManagementResult(out var error))
    {
        // TODO: Handle 'error' of type ConnectivityManagementResult
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetDeviceGroupInformationRequest](src/Verizon/Requests/DeviceGroups/GetDeviceGroupInformationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeviceGroupDevicesData](src/Verizon/Models/DeviceGroupDevicesData.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[GetDeviceGroupInformationError](src/Verizon/Errors/GetDeviceGroupInformationError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;DeviceGroup&gt;&gt; ListDeviceGroups(ListDeviceGroupsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a list of all device groups in a specified account.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DeviceGroups.ListDeviceGroups(new ListDeviceGroupsRequest
    {
        Aname = "0252012345-00001",
    });
    // TODO: Handle 'response' of type IReadOnlyList<DeviceGroup>
}
catch (ApiException<ListDeviceGroupsError> ex)
{
    if (ex.Error.TryGetConnectivityManagementResult(out var error))
    {
        // TODO: Handle 'error' of type ConnectivityManagementResult
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ListDeviceGroupsRequest](src/Verizon/Requests/DeviceGroups/ListDeviceGroupsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[DeviceGroup](src/Verizon/Models/DeviceGroup.cs)&gt;</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[ListDeviceGroupsError](src/Verizon/Errors/ListDeviceGroupsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ConnectivityManagementSuccessResult&gt; UpdateDeviceGroup(UpdateDeviceGroupRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Make changes to a device group, including changing the name and description, and adding or removing devices.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DeviceGroups.UpdateDeviceGroup(new UpdateDeviceGroupRequest
    {
        Aname = "0252012345-00001",
        Gname = "some example string",
        Body = new DeviceGroupUpdateRequest
        {
            DevicesToAdd = [new DeviceId { Id = "990003420535537", Kind = "imei" }],
            NewGroupDescription = "All western region tank level monitors.",
            NewGroupName = "Western region tanks",
        },
    });
    // TODO: Handle 'response' of type ConnectivityManagementSuccessResult
}
catch (ApiException<UpdateDeviceGroupError> ex)
{
    if (ex.Error.TryGetConnectivityManagementResult(out var error))
    {
        // TODO: Handle 'error' of type ConnectivityManagementResult
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UpdateDeviceGroupRequest](src/Verizon/Requests/DeviceGroups/UpdateDeviceGroupRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ConnectivityManagementSuccessResult](src/Verizon/Models/ConnectivityManagementSuccessResult.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[UpdateDeviceGroupError](src/Verizon/Errors/UpdateDeviceGroupError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## DeviceLocationCallbacks

> Source: [DeviceLocationCallbacks](src/Verizon/Api/DeviceLocationCallbacks.cs)

<details>
<summary><code>Task&lt;TransactionId&gt; CancelAsyncReport(CancelAsyncReportRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Cancel an asynchronous report request.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DeviceLocationCallbacks.CancelAsyncReport(new CancelAsyncReportRequest
    {
        Txid = "2c90bd28-eeee-ffff-gggg-7e3bd4fbff33",
        AccountName = "0000123456-00001",
    });
    // TODO: Handle 'response' of type TransactionId
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CancelAsyncReportRequest](src/Verizon/Requests/DeviceLocationCallbacks/CancelAsyncReportRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TransactionId](src/Verizon/Models/TransactionId.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Verizon/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeviceLocationSuccessResult&gt; DeregisterCallback2(DeregisterCallback2Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Deregister a URL to stop receiving callback messages.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DeviceLocationCallbacks.DeregisterCallback2(new DeregisterCallback2Request
    {
        AccountName = "0000123456-00001",
        Service = CallbackServiceName.Location,
    });
    // TODO: Handle 'response' of type DeviceLocationSuccessResult
}
catch (ApiException<DeregisterCallback2Error> ex)
{
    if (ex.Error.TryGetDeviceLocationResult(out var error))
    {
        // TODO: Handle 'error' of type DeviceLocationResult
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeregisterCallback2Request](src/Verizon/Requests/DeviceLocationCallbacks/DeregisterCallback2Request.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeviceLocationSuccessResult](src/Verizon/Models/DeviceLocationSuccessResult.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[DeregisterCallback2Error](src/Verizon/Errors/DeregisterCallback2Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;DeviceLocationCallback&gt;&gt; ListRegisteredCallbacks2(ListRegisteredCallbacks2Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a list of all registered callback URLs for the account.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DeviceLocationCallbacks.ListRegisteredCallbacks2(new ListRegisteredCallbacks2Request
    {
        AccountName = "0000123456-00001",
    });
    // TODO: Handle 'response' of type IReadOnlyList<DeviceLocationCallback>
}
catch (ApiException<ListRegisteredCallbacks2Error> ex)
{
    if (ex.Error.TryGetDeviceLocationResult(out var error))
    {
        // TODO: Handle 'error' of type DeviceLocationResult
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ListRegisteredCallbacks2Request](src/Verizon/Requests/DeviceLocationCallbacks/ListRegisteredCallbacks2Request.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[DeviceLocationCallback](src/Verizon/Models/DeviceLocationCallback.cs)&gt;</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[ListRegisteredCallbacks2Error](src/Verizon/Errors/ListRegisteredCallbacks2Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CallbackRegistrationResult&gt; RegisterCallback2(RegisterCallback2Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Provide a URL to receive messages from a ThingSpace callback service.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DeviceLocationCallbacks.RegisterCallback2(new RegisterCallback2Request
    {
        AccountName = "0000123456-00001",
    });
    // TODO: Handle 'response' of type CallbackRegistrationResult
}
catch (ApiException<RegisterCallback2Error> ex)
{
    if (ex.Error.TryGetDeviceLocationResult(out var error))
    {
        // TODO: Handle 'error' of type DeviceLocationResult
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[RegisterCallback2Request](src/Verizon/Requests/DeviceLocationCallbacks/RegisterCallback2Request.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CallbackRegistrationResult](src/Verizon/Models/CallbackRegistrationResult.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[RegisterCallback2Error](src/Verizon/Errors/RegisterCallback2Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## DeviceManagement

> Source: [DeviceManagement](src/Verizon/Api/DeviceManagement.cs)

<details>
<summary><code>Task&lt;DeviceManagementResult&gt; ActivateServiceForDevices(ActivateServiceForDevicesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

If the devices do not already exist in the account, this API resource adds them before activation.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DeviceManagement.ActivateServiceForDevices(new ActivateServiceForDevicesRequest
    {
        Body = new CarrierActivateRequest
        {
            Devices = [
                new AccountDeviceList
                {
                    DeviceIds = [
                        new DeviceId { Id = "990013907835573", Kind = "imei" },
                        new DeviceId { Id = "89141390780800784259", Kind = "iccid" },
                    ],
                    IpAddress = "1.2.3.456",
                },
                new AccountDeviceList
                {
                    DeviceIds = [
                        new DeviceId { Id = "990013907884259", Kind = "imei" },
                        new DeviceId { Id = "89141390780800735573", Kind = "iccid" },
                    ],
                    IpAddress = "1.2.3.456",
                },
            ],
            ServicePlan = "the service plan name",
            MdnZipCode = "98801",
            AccountName = "0868924207-00001",
            CustomFields = [new CustomFields { Key = "CustomField2", Value = "SuperVend" }],
            GroupName = "4G West",
            PrimaryPlaceOfUse = new PlaceOfUse
            {
                Address = new Address
                {
                    AddressLine1 = "1600 Pennsylvania Ave NW",
                    City = "Washington",
                    State = "DC",
                    Zip = "20500",
                    Country = "USA",
                },
                CustomerName = new CustomerName { Title = "President", FirstName = "Zaffod", LastName = "Beeblebrox" },
            },
        },
    });
    // TODO: Handle 'response' of type DeviceManagementResult
}
catch (ApiException<ActivateServiceForDevicesError> ex)
{
    if (ex.Error.TryGetConnectivityManagementResult(out var error))
    {
        // TODO: Handle 'error' of type ConnectivityManagementResult
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ActivateServiceForDevicesRequest](src/Verizon/Requests/DeviceManagement/ActivateServiceForDevicesRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeviceManagementResult](src/Verizon/Models/DeviceManagementResult.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[ActivateServiceForDevicesError](src/Verizon/Errors/ActivateServiceForDevicesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;AddDevicesResult&gt;&gt; AddDevices(AddDevicesOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Use this API if you want to manage some device settings before you are ready to activate service for the devices.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DeviceManagement.AddDevices(new AddDevicesOperationRequest
    {
        Body = new AddDevicesRequest
        {
            State = "Pre-active",
            DevicesToAdd = [
                new AccountDeviceList
                {
                    DeviceIds = [
                        new DeviceId { Id = "15-digit IMEI", Kind = "imei" },
                        new DeviceId { Id = "20-digit ICCID", Kind = "iccid" },
                    ],
                },
                new AccountDeviceList
                {
                    DeviceIds = [
                        new DeviceId { Id = "15-digit IMEI", Kind = "imei" },
                        new DeviceId { Id = "20-digit ICCID", Kind = "iccid" },
                    ],
                },
            ],
            AccountName = "0000123456-00001",
            CustomFields = [new CustomFields { Key = "CustomField2", Value = "SuperVend" }],
            GroupName = "West Region",
        },
    });
    // TODO: Handle 'response' of type IReadOnlyList<AddDevicesResult>
}
catch (ApiException<AddDevicesError> ex)
{
    if (ex.Error.TryGetConnectivityManagementResult(out var error))
    {
        // TODO: Handle 'error' of type ConnectivityManagementResult
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AddDevicesOperationRequest](src/Verizon/Requests/DeviceManagement/AddDevicesOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[AddDevicesResult](src/Verizon/Models/AddDevicesResult.cs)&gt;</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[AddDevicesError](src/Verizon/Errors/AddDevicesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeviceManagementResult&gt; BilledUsageInfo(BilledUsageInfoRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Gets billed usage for for either multiple devices or an entire billing account.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DeviceManagement.BilledUsageInfo(new BilledUsageInfoRequest
    {
        Body = new BilledusageListRequest { AccountName = "0342077109-00001" },
    });
    // TODO: Handle 'response' of type DeviceManagementResult
}
catch (ApiException<BilledUsageInfoError> ex)
{
    if (ex.Error.TryGetConnectivityManagementResult(out var error))
    {
        // TODO: Handle 'error' of type ConnectivityManagementResult
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[BilledUsageInfoRequest](src/Verizon/Requests/DeviceManagement/BilledUsageInfoRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeviceManagementResult](src/Verizon/Models/DeviceManagementResult.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[BilledUsageInfoError](src/Verizon/Errors/BilledUsageInfoError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeviceManagementResult&gt; ChangeDevicesServicePlan(ChangeDevicesServicePlanRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Changes the service plan for one or more devices.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DeviceManagement.ChangeDevicesServicePlan(new ChangeDevicesServicePlanRequest
    {
        Body = new ServicePlanUpdateRequest
        {
            ServicePlan = "Tablet5GB",
            Devices = [new AccountDeviceList { DeviceIds = [new DeviceId { Id = "A100003685E561", Kind = "meid" }] }],
            CarrierIpPoolName = "IPPool",
        },
    });
    // TODO: Handle 'response' of type DeviceManagementResult
}
catch (ApiException<ChangeDevicesServicePlanError> ex)
{
    if (ex.Error.TryGetConnectivityManagementResult(out var error))
    {
        // TODO: Handle 'error' of type ConnectivityManagementResult
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ChangeDevicesServicePlanRequest](src/Verizon/Requests/DeviceManagement/ChangeDevicesServicePlanRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeviceManagementResult](src/Verizon/Models/DeviceManagementResult.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[ChangeDevicesServicePlanError](src/Verizon/Errors/ChangeDevicesServicePlanError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeviceManagementResult&gt; CheckDevicesAvailabilityForActivation(CheckDevicesAvailabilityForActivationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Checks whether specified devices are registered by the manufacturer with the Verizon network and are available to be activated.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DeviceManagement.CheckDevicesAvailabilityForActivation(
        new CheckDevicesAvailabilityForActivationRequest
        {
            Body = new DeviceActivationRequest
            {
                AccountName = "0212345678-00001",
                Devices = [
                    new AccountDeviceList { DeviceIds = [new DeviceId { Id = "A100008385E561", Kind = "meid" }] },
                ],
            },
        });
    // TODO: Handle 'response' of type DeviceManagementResult
}
catch (ApiException<CheckDevicesAvailabilityForActivationError> ex)
{
    if (ex.Error.TryGetConnectivityManagementResult(out var error))
    {
        // TODO: Handle 'error' of type ConnectivityManagementResult
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CheckDevicesAvailabilityForActivationRequest](src/Verizon/Requests/DeviceManagement/CheckDevicesAvailabilityForActivationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeviceManagementResult](src/Verizon/Models/DeviceManagementResult.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[CheckDevicesAvailabilityForActivationError](src/Verizon/Errors/CheckDevicesAvailabilityForActivationError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeviceManagementResult&gt; DeactivateServiceForDevices(DeactivateServiceForDevicesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Deactivating service for a device may result in an early termination fee (ETF) being charged to the account, depending on the terms of the contract with Verizon. If your contract allows ETF waivers and if you want to use one for a particular deactivation, set the etfWaiver value to True.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DeviceManagement.DeactivateServiceForDevices(new DeactivateServiceForDevicesRequest
    {
        Body = new CarrierDeactivateRequest
        {
            AccountName = "0000123456-00001",
            Devices = [new AccountDeviceList { DeviceIds = [new DeviceId { Id = "20-digit ICCID", Kind = "iccid" }] }],
            ReasonCode = "FF",
            EtfWaiver = true,
            DeleteAfterDeactivation = true,
        },
    });
    // TODO: Handle 'response' of type DeviceManagementResult
}
catch (ApiException<DeactivateServiceForDevicesError> ex)
{
    if (ex.Error.TryGetConnectivityManagementResult(out var error))
    {
        // TODO: Handle 'error' of type ConnectivityManagementResult
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeactivateServiceForDevicesRequest](src/Verizon/Requests/DeviceManagement/DeactivateServiceForDevicesRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeviceManagementResult](src/Verizon/Models/DeviceManagementResult.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[DeactivateServiceForDevicesError](src/Verizon/Errors/DeactivateServiceForDevicesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;DeleteDevicesResult&gt;&gt; DeleteDeactivatedDevices(DeleteDeactivatedDevicesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Use this API to remove unneeded devices from an account.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DeviceManagement.DeleteDeactivatedDevices(new DeleteDeactivatedDevicesRequest
    {
        Body = new DeleteDevicesRequest
        {
            DevicesToDelete = [
                new AccountDeviceList { DeviceIds = [new DeviceId { Id = "09005470263", Kind = "esn" }] },
                new AccountDeviceList { DeviceIds = [new DeviceId { Id = "85000022411113460014", Kind = "iccid" }] },
                new AccountDeviceList { DeviceIds = [new DeviceId { Id = "85000022412313460016", Kind = "iccid" }] },
            ],
        },
    });
    // TODO: Handle 'response' of type IReadOnlyList<DeleteDevicesResult>
}
catch (ApiException<DeleteDeactivatedDevicesError> ex)
{
    if (ex.Error.TryGetConnectivityManagementResult(out var error))
    {
        // TODO: Handle 'error' of type ConnectivityManagementResult
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeleteDeactivatedDevicesRequest](src/Verizon/Requests/DeviceManagement/DeleteDeactivatedDevicesRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[DeleteDevicesResult](src/Verizon/Models/DeleteDevicesResult.cs)&gt;</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[DeleteDeactivatedDevicesError](src/Verizon/Errors/DeleteDeactivatedDevicesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RequestResponse&gt; DeviceUpload(DeviceUploadOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Upload a device record

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DeviceManagement.DeviceUpload(new DeviceUploadOperationRequest
    {
        Body = new DeviceUploadRequest
        {
            AccountName = "1223334444-00001",
            Devices = [
                new DeviceList { DeviceIds = [new DeviceId { Id = "15-digit IMEI", Kind = "IMEI" }] },
                new DeviceList { DeviceIds = [new DeviceId { Id = "15-digit IMEI", Kind = "IMEI" }] },
                new DeviceList { DeviceIds = [new DeviceId { Id = "15-digit IMEI", Kind = "IMEI" }] },
            ],
            EmailAddress = "bob@mycompany.com",
            DeviceSku = "VZW123456",
            UploadType = "IMEI",
        },
    });
    // TODO: Handle 'response' of type RequestResponse
}
catch (ApiException<DeviceUploadError> ex)
{
    if (ex.Error.TryGetRestErrorResponse(out var error))
    {
        // TODO: Handle 'error' of type RestErrorResponse
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeviceUploadOperationRequest](src/Verizon/Requests/DeviceManagement/DeviceUploadOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RequestResponse](src/Verizon/Models/RequestResponse.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[DeviceUploadError](src/Verizon/Errors/DeviceUploadError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeviceManagementResult&gt; DeviceUploadStatus(DeviceUploadStatusRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Checks the status of an activation order and lists where the order is in the provisioning process.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DeviceManagement.DeviceUploadStatus(new DeviceUploadStatusRequest
    {
        Body = new CheckOrderStatusRequest
        {
            AccountName = "4Gpublicaccount ",
            OrderRequestId = " f55fea16-3664-4a32-ae9d-c0cbe3eedf1d ",
            Devices = [new DeviceList { DeviceIds = [new DeviceId { Id = "20112019672551234613", Kind = "iccid" }] }],
        },
    });
    // TODO: Handle 'response' of type DeviceManagementResult
}
catch (ApiException<DeviceUploadStatusError> ex)
{
    if (ex.Error.TryGetConnectivityManagementResult(out var error))
    {
        // TODO: Handle 'error' of type ConnectivityManagementResult
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeviceUploadStatusRequest](src/Verizon/Requests/DeviceManagement/DeviceUploadStatusRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeviceManagementResult](src/Verizon/Models/DeviceManagementResult.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[DeviceUploadStatusError](src/Verizon/Errors/DeviceUploadStatusError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeviceExtendedDiagnosticsResult&gt; GetDeviceExtendedDiagnosticInformation(GetDeviceExtendedDiagnosticInformationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns extended diagnostic information about a specified device, including connectivity, provisioning, billing and location status.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DeviceManagement.GetDeviceExtendedDiagnosticInformation(
        new GetDeviceExtendedDiagnosticInformationRequest
        {
            Body = new DeviceExtendedDiagnosticsRequest
            {
                AccountName = "0000123456-00001",
                DeviceList = [new DeviceId { Id = "10-digit MDN", Kind = "mdn" }],
            },
        });
    // TODO: Handle 'response' of type DeviceExtendedDiagnosticsResult
}
catch (ApiException<GetDeviceExtendedDiagnosticInformationError> ex)
{
    if (ex.Error.TryGetConnectivityManagementResult(out var error))
    {
        // TODO: Handle 'error' of type ConnectivityManagementResult
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetDeviceExtendedDiagnosticInformationRequest](src/Verizon/Requests/DeviceManagement/GetDeviceExtendedDiagnosticInformationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeviceExtendedDiagnosticsResult](src/Verizon/Models/DeviceExtendedDiagnosticsResult.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[GetDeviceExtendedDiagnosticInformationError](src/Verizon/Errors/GetDeviceExtendedDiagnosticInformationError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeviceManagementResult&gt; GetDeviceServiceSuspensionStatus(GetDeviceServiceSuspensionStatusRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns DeviceSuspensionStatus callback messages containing the current device state and information on how many days a device has been suspended and can continue to be suspended.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DeviceManagement.GetDeviceServiceSuspensionStatus(
        new GetDeviceServiceSuspensionStatusRequest
        {
            Body = new DeviceSuspensionStatusRequest
            {
                DeviceIds = [
                    new DeviceId { Id = "A10085E5003861", Kind = "meid" },
                    new DeviceId { Id = "A10085E5003186", Kind = "meid" },
                ],
            },
        });
    // TODO: Handle 'response' of type DeviceManagementResult
}
catch (ApiException<GetDeviceServiceSuspensionStatusError> ex)
{
    if (ex.Error.TryGetConnectivityManagementResult(out var error))
    {
        // TODO: Handle 'error' of type ConnectivityManagementResult
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetDeviceServiceSuspensionStatusRequest](src/Verizon/Requests/DeviceManagement/GetDeviceServiceSuspensionStatusRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeviceManagementResult](src/Verizon/Models/DeviceManagementResult.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[GetDeviceServiceSuspensionStatusError](src/Verizon/Errors/GetDeviceServiceSuspensionStatusError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeviceManagementResult&gt; ListCurrentDevicesPrlVersion(ListCurrentDevicesPrlVersionRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

4G and GSM devices do not have a PRL.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DeviceManagement.ListCurrentDevicesPrlVersion(new ListCurrentDevicesPrlVersionRequest
    {
        Body = new DevicePrlListRequest
        {
            DeviceIds = [
                new DeviceId { Id = "A10085E5003861", Kind = "meid" },
                new DeviceId { Id = "A10085E5003186", Kind = "meid" },
            ],
        },
    });
    // TODO: Handle 'response' of type DeviceManagementResult
}
catch (ApiException<ListCurrentDevicesPrlVersionError> ex)
{
    if (ex.Error.TryGetConnectivityManagementResult(out var error))
    {
        // TODO: Handle 'error' of type ConnectivityManagementResult
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ListCurrentDevicesPrlVersionRequest](src/Verizon/Requests/DeviceManagement/ListCurrentDevicesPrlVersionRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeviceManagementResult](src/Verizon/Models/DeviceManagementResult.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[ListCurrentDevicesPrlVersionError](src/Verizon/Errors/ListCurrentDevicesPrlVersionError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AccountDeviceListResult&gt; ListDevicesInformation(ListDevicesInformationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns information about a single device or information about all devices that match the given parameters. Returned information includes device provisioning state, service plan, MDN, MIN, and IP address.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DeviceManagement.ListDevicesInformation(new ListDevicesInformationRequest
    {
        Body = new AccountDeviceListRequest { DeviceId = new DeviceId { Id = "20-digit ICCID", Kind = "iccid" } },
    });
    // TODO: Handle 'response' of type AccountDeviceListResult
}
catch (ApiException<ListDevicesInformationError> ex)
{
    if (ex.Error.TryGetConnectivityManagementResult(out var error))
    {
        // TODO: Handle 'error' of type ConnectivityManagementResult
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ListDevicesInformationRequest](src/Verizon/Requests/DeviceManagement/ListDevicesInformationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AccountDeviceListResult](src/Verizon/Models/AccountDeviceListResult.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[ListDevicesInformationError](src/Verizon/Errors/ListDevicesInformationError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;DeviceProvisioningHistoryListResult&gt;&gt; ListDevicesProvisioningHistory(ListDevicesProvisioningHistoryRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the provisioning history of a specified device during a specified time period.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DeviceManagement.ListDevicesProvisioningHistory(
        new ListDevicesProvisioningHistoryRequest
        {
            Body = new DeviceProvisioningHistoryListRequest
            {
                DeviceId = new DeviceId { Id = "89141390780800784259", Kind = "iccid" },
                Earliest = "2015-09-16T00:00:01Z",
                Latest = "2015-09-18T00:00:01Z",
            },
        });
    // TODO: Handle 'response' of type IReadOnlyList<DeviceProvisioningHistoryListResult>
}
catch (ApiException<ListDevicesProvisioningHistoryError> ex)
{
    if (ex.Error.TryGetConnectivityManagementResult(out var error))
    {
        // TODO: Handle 'error' of type ConnectivityManagementResult
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ListDevicesProvisioningHistoryRequest](src/Verizon/Requests/DeviceManagement/ListDevicesProvisioningHistoryRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[DeviceProvisioningHistoryListResult](src/Verizon/Models/DeviceProvisioningHistoryListResult.cs)&gt;</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[ListDevicesProvisioningHistoryError](src/Verizon/Errors/ListDevicesProvisioningHistoryError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeviceUsageListResult&gt; ListDevicesUsageHistory(ListDevicesUsageHistoryRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the network data usage history of a device during a specified time period.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DeviceManagement.ListDevicesUsageHistory(new ListDevicesUsageHistoryRequest
    {
        Body = new DeviceUsageListRequest
        {
            Earliest = "2018-03-20T00:00:01Z",
            Latest = "2020-12-31T00:00:01Z",
            DeviceId = new DeviceId { Id = "50684915885088839315521399821675", Kind = "eid" },
        },
    });
    // TODO: Handle 'response' of type DeviceUsageListResult
}
catch (ApiException<ListDevicesUsageHistoryError> ex)
{
    if (ex.Error.TryGetConnectivityManagementResult(out var error))
    {
        // TODO: Handle 'error' of type ConnectivityManagementResult
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ListDevicesUsageHistoryRequest](src/Verizon/Requests/DeviceManagement/ListDevicesUsageHistoryRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeviceUsageListResult](src/Verizon/Models/DeviceUsageListResult.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[ListDevicesUsageHistoryError](src/Verizon/Errors/ListDevicesUsageHistoryError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeviceMismatchListResult&gt; ListDevicesWithImeiIccidMismatch(ListDevicesWithImeiIccidMismatchRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a list of all 4G devices with an ICCID (SIM) that was not activated with the expected IMEI (hardware) during a specified time frame.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DeviceManagement.ListDevicesWithImeiIccidMismatch(
        new ListDevicesWithImeiIccidMismatchRequest
        {
            Body = new DeviceMismatchListRequest
            {
                Filter = new DateFilter
                {
                    Earliest = "2020-05-01T15:00:00-08:00Z",
                    Latest = "2020-07-30T15:00:00-08:00Z",
                },
                Devices = [
                    new AccountDeviceList
                    {
                        DeviceIds = [
                            new DeviceId { Id = "8914800000080078", Kind = "ICCID" },
                            new DeviceId { Id = "5096300587", Kind = "MDN" },
                        ],
                    },
                ],
                AccountName = "0342077109-00001",
            },
        });
    // TODO: Handle 'response' of type DeviceMismatchListResult
}
catch (ApiException<ListDevicesWithImeiIccidMismatchError> ex)
{
    if (ex.Error.TryGetConnectivityManagementResult(out var error))
    {
        // TODO: Handle 'error' of type ConnectivityManagementResult
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ListDevicesWithImeiIccidMismatchRequest](src/Verizon/Requests/DeviceManagement/ListDevicesWithImeiIccidMismatchRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeviceMismatchListResult](src/Verizon/Models/DeviceMismatchListResult.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[ListDevicesWithImeiIccidMismatchError](src/Verizon/Errors/ListDevicesWithImeiIccidMismatchError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeviceManagementResult&gt; MoveDevicesWithinAccountsOfProfile(MoveDevicesWithinAccountsOfProfileRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Move active devices from one billing account to another within a customer profile.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DeviceManagement.MoveDevicesWithinAccountsOfProfile(
        new MoveDevicesWithinAccountsOfProfileRequest
        {
            Body = new MoveDeviceRequest
            {
                AccountName = "0212345678-00001",
                Devices = [new AccountDeviceList { DeviceIds = [new DeviceId { Id = "19110173057", Kind = "ESN" }] }],
                ServicePlan = "M2M5GB",
            },
        });
    // TODO: Handle 'response' of type DeviceManagementResult
}
catch (ApiException<MoveDevicesWithinAccountsOfProfileError> ex)
{
    if (ex.Error.TryGetConnectivityManagementResult(out var error))
    {
        // TODO: Handle 'error' of type ConnectivityManagementResult
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[MoveDevicesWithinAccountsOfProfileRequest](src/Verizon/Requests/DeviceManagement/MoveDevicesWithinAccountsOfProfileRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeviceManagementResult](src/Verizon/Models/DeviceManagementResult.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[MoveDevicesWithinAccountsOfProfileError](src/Verizon/Errors/MoveDevicesWithinAccountsOfProfileError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeviceManagementResult&gt; RestoreServiceForSuspendedDevices(RestoreServiceForSuspendedDevicesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Restores service to one or more suspended devices.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DeviceManagement.RestoreServiceForSuspendedDevices(
        new RestoreServiceForSuspendedDevicesRequest
        {
            Body = new CarrierActionsRequest
            {
                Devices = [
                    new AccountDeviceList
                    {
                        DeviceIds = [new DeviceId { Id = "89148000000800139708", Kind = "iccid" }],
                    },
                ],
            },
        });
    // TODO: Handle 'response' of type DeviceManagementResult
}
catch (ApiException<RestoreServiceForSuspendedDevicesError> ex)
{
    if (ex.Error.TryGetConnectivityManagementResult(out var error))
    {
        // TODO: Handle 'error' of type ConnectivityManagementResult
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[RestoreServiceForSuspendedDevicesRequest](src/Verizon/Requests/DeviceManagement/RestoreServiceForSuspendedDevicesRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeviceManagementResult](src/Verizon/Models/DeviceManagementResult.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[RestoreServiceForSuspendedDevicesError](src/Verizon/Errors/RestoreServiceForSuspendedDevicesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeviceManagementResult&gt; RetrieveAggregateDeviceUsageHistory(RetrieveAggregateDeviceUsageHistoryRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The information is returned in a callback response, so you must register a URL for DeviceUsage callback messages using the POST /callbacks API.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DeviceManagement.RetrieveAggregateDeviceUsageHistory(
        new RetrieveAggregateDeviceUsageHistoryRequest
        {
            Body = new DeviceAggregateUsageListRequest
            {
                StartTime = "2021-08-01T00:00:00-06:00",
                EndTime = "2021-08-30T00:00:00-06:00",
                DeviceIds = [new DeviceId { Id = "84258000000891490087", Kind = "ICCID" }],
                AccountName = "9992330389-00001",
            },
        });
    // TODO: Handle 'response' of type DeviceManagementResult
}
catch (ApiException<RetrieveAggregateDeviceUsageHistoryError> ex)
{
    if (ex.Error.TryGetConnectivityManagementResult(out var error))
    {
        // TODO: Handle 'error' of type ConnectivityManagementResult
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[RetrieveAggregateDeviceUsageHistoryRequest](src/Verizon/Requests/DeviceManagement/RetrieveAggregateDeviceUsageHistoryRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeviceManagementResult](src/Verizon/Models/DeviceManagementResult.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[RetrieveAggregateDeviceUsageHistoryError](src/Verizon/Errors/RetrieveAggregateDeviceUsageHistoryError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ConnectionHistoryResult&gt; RetrieveDeviceConnectionHistory(RetrieveDeviceConnectionHistoryRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Each response includes a maximum of 500 records. To obtain more records, you can call the API multiple times, adjusting the earliest value each time to start where the previous request finished.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DeviceManagement.RetrieveDeviceConnectionHistory(
        new RetrieveDeviceConnectionHistoryRequest
        {
            Body = new DeviceConnectionListRequest
            {
                DeviceId = new DeviceId { Id = "89141390780800784259", Kind = "iccid" },
                Earliest = "2015-09-16T00:00:01Z",
                Latest = "2010-09-18T00:00:01Z",
            },
        });
    // TODO: Handle 'response' of type ConnectionHistoryResult
}
catch (ApiException<RetrieveDeviceConnectionHistoryError> ex)
{
    if (ex.Error.TryGetConnectivityManagementResult(out var error))
    {
        // TODO: Handle 'error' of type ConnectivityManagementResult
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[RetrieveDeviceConnectionHistoryRequest](src/Verizon/Requests/DeviceManagement/RetrieveDeviceConnectionHistoryRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ConnectionHistoryResult](src/Verizon/Models/ConnectionHistoryResult.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[RetrieveDeviceConnectionHistoryError](src/Verizon/Errors/RetrieveDeviceConnectionHistoryError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeviceManagementResult&gt; SuspendServiceForDevices(SuspendServiceForDevicesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Suspends service for one or more devices.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DeviceManagement.SuspendServiceForDevices(new SuspendServiceForDevicesRequest
    {
        Body = new CarrierActionsRequest
        {
            Devices = [
                new AccountDeviceList { DeviceIds = [new DeviceId { Id = "89148000000800139708", Kind = "iccid" }] },
            ],
        },
    });
    // TODO: Handle 'response' of type DeviceManagementResult
}
catch (ApiException<SuspendServiceForDevicesError> ex)
{
    if (ex.Error.TryGetConnectivityManagementResult(out var error))
    {
        // TODO: Handle 'error' of type ConnectivityManagementResult
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SuspendServiceForDevicesRequest](src/Verizon/Requests/DeviceManagement/SuspendServiceForDevicesRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeviceManagementResult](src/Verizon/Models/DeviceManagementResult.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[SuspendServiceForDevicesError](src/Verizon/Errors/SuspendServiceForDevicesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeviceManagementResult&gt; UpdateDeviceId(UpdateDeviceIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Changes the identifier of a 3G or 4G device to match hardware changes made for a line of service. Use this request to transfer the line of service and the MDN to new hardware, or to change the MDN.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DeviceManagement.UpdateDeviceId(new UpdateDeviceIdRequest
    {
        ServiceType = "some example string",
        Body = new ChangeDeviceIdRequest
        {
            Change4GOption = "ChangeICCID",
            DeviceIds = [new DeviceId { Id = "42590078891480000008", Kind = "iccid" }],
            DeviceIdsTo = [new DeviceId { Id = "89148000000842590078", Kind = "iccid" }],
            ServicePlan = "4G 2GB",
            ZipCode = "98802",
        },
    });
    // TODO: Handle 'response' of type DeviceManagementResult
}
catch (ApiException<UpdateDeviceIdError> ex)
{
    if (ex.Error.TryGetConnectivityManagementResult(out var error))
    {
        // TODO: Handle 'error' of type ConnectivityManagementResult
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UpdateDeviceIdRequest](src/Verizon/Requests/DeviceManagement/UpdateDeviceIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeviceManagementResult](src/Verizon/Models/DeviceManagementResult.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[UpdateDeviceIdError](src/Verizon/Errors/UpdateDeviceIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeviceManagementResult&gt; UpdateDevicesContactInformation(UpdateDevicesContactInformationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Sends a CarrierService callback message for each device in the request when the contact information has been changed, or if there was a problem and the change could not be completed.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DeviceManagement.UpdateDevicesContactInformation(
        new UpdateDevicesContactInformationRequest
        {
            Body = new ContactInfoUpdateRequest
            {
                PrimaryPlaceOfUse = new PlaceOfUse
                {
                    Address = new Address
                    {
                        AddressLine1 = "9868 Scranton Rd",
                        AddressLine2 = "Suite A",
                        City = "San Diego",
                        State = "CA",
                        Zip = "92121",
                        Zip4 = "0001",
                        Country = "USA",
                        Phone = "1234567890",
                        PhoneType = "H",
                        EmailAddress = "zaffod@theinternet.com",
                    },
                    CustomerName = new CustomerName
                    {
                        Title = "President",
                        FirstName = "Zaffod",
                        MiddleName = "P",
                        LastName = "Beeblebrox",
                        Suffix = "I",
                    },
                },
                AccountName = "0000123456-00001",
                Devices = [
                    new AccountDeviceList
                    {
                        DeviceIds = [
                            new DeviceId { Id = "19110173057", Kind = "ESN" },
                            new DeviceId { Id = "19110173057", Kind = "ESN" },
                        ],
                    },
                ],
            },
        });
    // TODO: Handle 'response' of type DeviceManagementResult
}
catch (ApiException<UpdateDevicesContactInformationError> ex)
{
    if (ex.Error.TryGetConnectivityManagementResult(out var error))
    {
        // TODO: Handle 'error' of type ConnectivityManagementResult
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UpdateDevicesContactInformationRequest](src/Verizon/Requests/DeviceManagement/UpdateDevicesContactInformationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeviceManagementResult](src/Verizon/Models/DeviceManagementResult.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[UpdateDevicesContactInformationError](src/Verizon/Errors/UpdateDevicesContactInformationError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeviceManagementResult&gt; UpdateDevicesCostCenterCode(UpdateDevicesCostCenterCodeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Changes or removes the CostCenterCode value or customer name and address (Primary Place of Use) for one or more devices.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DeviceManagement.UpdateDevicesCostCenterCode(new UpdateDevicesCostCenterCodeRequest
    {
        Body = new DeviceCostCenterRequest
        {
            CostCenter = "cc12345",
            Devices = [
                new AccountDeviceList { DeviceIds = [new DeviceId { Id = "89148000000800139708", Kind = "iccid" }] },
            ],
        },
    });
    // TODO: Handle 'response' of type DeviceManagementResult
}
catch (ApiException<UpdateDevicesCostCenterCodeError> ex)
{
    if (ex.Error.TryGetConnectivityManagementResult(out var error))
    {
        // TODO: Handle 'error' of type ConnectivityManagementResult
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UpdateDevicesCostCenterCodeRequest](src/Verizon/Requests/DeviceManagement/UpdateDevicesCostCenterCodeRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeviceManagementResult](src/Verizon/Models/DeviceManagementResult.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[UpdateDevicesCostCenterCodeError](src/Verizon/Errors/UpdateDevicesCostCenterCodeError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeviceManagementResult&gt; UpdateDevicesCustomFields(UpdateDevicesCustomFieldsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Sends a CarrierService callback message for each device in the request when the custom fields have been changed, or if there was a problem and the change could not be completed.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DeviceManagement.UpdateDevicesCustomFields(new UpdateDevicesCustomFieldsRequest
    {
        Body = new CustomFieldsUpdateRequest
        {
            CustomFieldsToUpdate = [
                new CustomFields { Key = "CustomField1", Value = "West Region" },
                new CustomFields { Key = "CustomField2", Value = "Distribution" },
            ],
            Devices = [
                new AccountDeviceList { DeviceIds = [new DeviceId { Id = "89148000000800139708", Kind = "iccid" }] },
            ],
        },
    });
    // TODO: Handle 'response' of type DeviceManagementResult
}
catch (ApiException<UpdateDevicesCustomFieldsError> ex)
{
    if (ex.Error.TryGetConnectivityManagementResult(out var error))
    {
        // TODO: Handle 'error' of type ConnectivityManagementResult
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UpdateDevicesCustomFieldsRequest](src/Verizon/Requests/DeviceManagement/UpdateDevicesCustomFieldsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeviceManagementResult](src/Verizon/Models/DeviceManagementResult.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[UpdateDevicesCustomFieldsError](src/Verizon/Errors/UpdateDevicesCustomFieldsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeviceManagementResult&gt; UpdateDevicesState(UpdateDevicesStateRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Changes the provisioning state of one or more devices to a specified customer-defined service and state.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DeviceManagement.UpdateDevicesState(new UpdateDevicesStateRequest
    {
        Body = new GoToStateRequest
        {
            ServiceName = "some example string",
            StateName = "some example string",
            ServicePlan = "some example string",
            MdnZipCode = "some example string",
        },
    });
    // TODO: Handle 'response' of type DeviceManagementResult
}
catch (ApiException<UpdateDevicesStateError> ex)
{
    if (ex.Error.TryGetConnectivityManagementResult(out var error))
    {
        // TODO: Handle 'error' of type ConnectivityManagementResult
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UpdateDevicesStateRequest](src/Verizon/Requests/DeviceManagement/UpdateDevicesStateRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeviceManagementResult](src/Verizon/Models/DeviceManagementResult.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[UpdateDevicesStateError](src/Verizon/Errors/UpdateDevicesStateError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeviceManagementResult&gt; UploadActivateDevice(UploadActivateDeviceRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Uploads and activates device identifiers and SKUs for new devices from OEMs to Verizon.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DeviceManagement.UploadActivateDevice(new UploadActivateDeviceRequest
    {
        Body = new UploadsActivatesDeviceRequest
        {
            AccountName = "1223334444-00001",
            EmailAddress = "bob@mycompany.com",
            DeviceSku = "VZW123456",
            UploadType = "IMEI ICCID Pair",
            ServicePlan = "15MBShr",
            CarrierIpPoolName = "",
            MdnZipCode = "92222",
            Devices = [
                new DeviceList
                {
                    DeviceIds = [
                        new DeviceId { Id = "990013907835573", Kind = "imei" },
                        new DeviceId { Id = "89141390780800784259", Kind = "iccid" },
                    ],
                },
            ],
        },
    });
    // TODO: Handle 'response' of type DeviceManagementResult
}
catch (ApiException<UploadActivateDeviceError> ex)
{
    if (ex.Error.TryGetConnectivityManagementResult(out var error))
    {
        // TODO: Handle 'error' of type ConnectivityManagementResult
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UploadActivateDeviceRequest](src/Verizon/Requests/DeviceManagement/UploadActivateDeviceRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeviceManagementResult](src/Verizon/Models/DeviceManagementResult.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[UploadActivateDeviceError](src/Verizon/Errors/UploadActivateDeviceError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeviceManagementResult&gt; UsageSegmentationLabelAssociation(UsageSegmentationLabelAssociationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Allows you to associate your own usage segmentation label with a device.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DeviceManagement.UsageSegmentationLabelAssociation(
        new UsageSegmentationLabelAssociationRequest
        {
            Body = new AssociateLabelRequest
            {
                AccountName = "some example string",
                Labels = new AccountLabels { Devices = [new DeviceList()] },
            },
        });
    // TODO: Handle 'response' of type DeviceManagementResult
}
catch (ApiException<UsageSegmentationLabelAssociationError> ex)
{
    if (ex.Error.TryGetConnectivityManagementResult(out var error))
    {
        // TODO: Handle 'error' of type ConnectivityManagementResult
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UsageSegmentationLabelAssociationRequest](src/Verizon/Requests/DeviceManagement/UsageSegmentationLabelAssociationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeviceManagementResult](src/Verizon/Models/DeviceManagementResult.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[UsageSegmentationLabelAssociationError](src/Verizon/Errors/UsageSegmentationLabelAssociationError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeviceManagementResult&gt; UsageSegmentationLabelDeletion(UsageSegmentationLabelDeletionRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Allow customers to remove the associated label from a device.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DeviceManagement.UsageSegmentationLabelDeletion(
        new UsageSegmentationLabelDeletionRequest { AccountName = "0000123456-00001", LabelList = new LabelsList() });
    // TODO: Handle 'response' of type DeviceManagementResult
}
catch (ApiException<UsageSegmentationLabelDeletionError> ex)
{
    if (ex.Error.TryGetConnectivityManagementResult(out var error))
    {
        // TODO: Handle 'error' of type ConnectivityManagementResult
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UsageSegmentationLabelDeletionRequest](src/Verizon/Requests/DeviceManagement/UsageSegmentationLabelDeletionRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeviceManagementResult](src/Verizon/Models/DeviceManagementResult.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[UsageSegmentationLabelDeletionError](src/Verizon/Errors/UsageSegmentationLabelDeletionError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## DeviceMonitoring

> Source: [DeviceMonitoring](src/Verizon/Api/DeviceMonitoring.cs)

<details>
<summary><code>Task&lt;RequestResponse&gt; DeviceReachability(DeviceReachabilityRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DeviceMonitoring.DeviceReachability(new DeviceReachabilityRequest
    {
        Body = new NotificationReportRequest
        {
            AccountName = "0000123456-00001",
            RequestType = "REACHABLE_FOR_DATA",
            Devices = [
                new DeviceList
                {
                    DeviceIds = [
                        new DeviceId { Id = "20-digit ICCID", Kind = "iccid" },
                        new DeviceId { Id = "20-digit ICCID", Kind = "iccid" },
                    ],
                },
            ],
            MonitorExpirationTime = "2019-12-02T15:00:00-08:00Z",
        },
    });
    // TODO: Handle 'response' of type RequestResponse
}
catch (ApiException<DeviceReachabilityError> ex)
{
    if (ex.Error.TryGetRestErrorResponse(out var error))
    {
        // TODO: Handle 'error' of type RestErrorResponse
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeviceReachabilityRequest](src/Verizon/Requests/DeviceMonitoring/DeviceReachabilityRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RequestResponse](src/Verizon/Models/RequestResponse.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[DeviceReachabilityError](src/Verizon/Errors/DeviceReachabilityError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RequestResponse&gt; StopDeviceReachability(StopDeviceReachabilityRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DeviceMonitoring.StopDeviceReachability(new StopDeviceReachabilityRequest
    {
        Stopreachabilitypayload = new StopMonitorRequest
        {
            AccountName = "0000123456-00001",
            Devices = [
                new DeviceList { DeviceIds = [new DeviceId { Id = "1+ 10-digit phone number", Kind = "msisdn" }] },
            ],
        },
    });
    // TODO: Handle 'response' of type RequestResponse
}
catch (ApiException<StopDeviceReachabilityError> ex)
{
    if (ex.Error.TryGetRestErrorResponse(out var error))
    {
        // TODO: Handle 'error' of type RestErrorResponse
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[StopDeviceReachabilityRequest](src/Verizon/Requests/DeviceMonitoring/StopDeviceReachabilityRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RequestResponse](src/Verizon/Models/RequestResponse.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[StopDeviceReachabilityError](src/Verizon/Errors/StopDeviceReachabilityError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## DeviceProfileManagement

> Source: [DeviceProfileManagement](src/Verizon/Api/DeviceProfileManagement.cs)

<details>
<summary><code>Task&lt;RequestResponse&gt; ActivateDeviceThroughProfile(ActivateDeviceThroughProfileRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Uses the profile to bring the device under management.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DeviceProfileManagement.ActivateDeviceThroughProfile(
        new ActivateDeviceThroughProfileRequest
        {
            Body = new ActivateDeviceProfileRequest
            {
                Devices = [
                    new DeviceList
                    {
                        DeviceIds = [
                            new DeviceId { Id = "32-digit EID", Kind = "eid" },
                            new DeviceId { Id = "15-digit IMEI", Kind = "imei" },
                        ],
                    },
                ],
                AccountName = "0000123456-00001",
                ServicePlan = "The service plan name",
                MdnZipCode = "five digit zip code",
            },
        });
    // TODO: Handle 'response' of type RequestResponse
}
catch (ApiException<ActivateDeviceThroughProfileError> ex)
{
    if (ex.Error.TryGetRestErrorResponse(out var error))
    {
        // TODO: Handle 'error' of type RestErrorResponse
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ActivateDeviceThroughProfileRequest](src/Verizon/Requests/DeviceProfileManagement/ActivateDeviceThroughProfileRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RequestResponse](src/Verizon/Models/RequestResponse.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[ActivateDeviceThroughProfileError](src/Verizon/Errors/ActivateDeviceThroughProfileError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RequestResponse&gt; ProfileToActivateDevice(ProfileToActivateDeviceRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Uses the profile to activate the device.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DeviceProfileManagement.ProfileToActivateDevice(new ProfileToActivateDeviceRequest
    {
        Body = new ProfileRequest { AccountName = "some example string", Devices = [new DeviceList()] },
    });
    // TODO: Handle 'response' of type RequestResponse
}
catch (ApiException<ProfileToActivateDeviceError> ex)
{
    if (ex.Error.TryGetRestErrorResponse(out var error))
    {
        // TODO: Handle 'error' of type RestErrorResponse
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ProfileToActivateDeviceRequest](src/Verizon/Requests/DeviceProfileManagement/ProfileToActivateDeviceRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RequestResponse](src/Verizon/Models/RequestResponse.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[ProfileToActivateDeviceError](src/Verizon/Errors/ProfileToActivateDeviceError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RequestResponse&gt; ProfileToDeactivateDevice(ProfileToDeactivateDeviceRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Uses the profile to deactivate the device.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DeviceProfileManagement.ProfileToDeactivateDevice(new ProfileToDeactivateDeviceRequest
    {
        Body = new DeactivateDeviceProfileRequest
        {
            AccountName = "some example string",
            ReasonCode = "some example string",
        },
    });
    // TODO: Handle 'response' of type RequestResponse
}
catch (ApiException<ProfileToDeactivateDeviceError> ex)
{
    if (ex.Error.TryGetRestErrorResponse(out var error))
    {
        // TODO: Handle 'error' of type RestErrorResponse
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ProfileToDeactivateDeviceRequest](src/Verizon/Requests/DeviceProfileManagement/ProfileToDeactivateDeviceRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RequestResponse](src/Verizon/Models/RequestResponse.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[ProfileToDeactivateDeviceError](src/Verizon/Errors/ProfileToDeactivateDeviceError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RequestResponse&gt; ProfileToSetFallbackAttribute(ProfileToSetFallbackAttributeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Allows the profile to set the fallback attribute to the device.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DeviceProfileManagement.ProfileToSetFallbackAttribute(
        new ProfileToSetFallbackAttributeRequest
        {
            Body = new SetFallbackAttributeRequest
            {
                Devices = [new DeviceList()],
                AccountName = "some example string",
            },
        });
    // TODO: Handle 'response' of type RequestResponse
}
catch (ApiException<ProfileToSetFallbackAttributeError> ex)
{
    if (ex.Error.TryGetRestErrorResponse(out var error))
    {
        // TODO: Handle 'error' of type RestErrorResponse
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ProfileToSetFallbackAttributeRequest](src/Verizon/Requests/DeviceProfileManagement/ProfileToSetFallbackAttributeRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RequestResponse](src/Verizon/Models/RequestResponse.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[ProfileToSetFallbackAttributeError](src/Verizon/Errors/ProfileToSetFallbackAttributeError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## DeviceReports

> Source: [DeviceReports](src/Verizon/Api/DeviceReports.cs)

<details>
<summary><code>Task&lt;AggregatedReportCallbackResult&gt; CalculateAggregatedReportAsynchronous(CalculateAggregatedReportAsynchronousRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Calculate aggregated report per day with number of sessions and usage information. User will receive an asynchronous callback for the specified list of devices (Max 10000) and date range (Max 180 days).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DeviceReports.CalculateAggregatedReportAsynchronous(
        new CalculateAggregatedReportAsynchronousRequest
        {
            Body = new AggregateSessionReportRequest
            {
                AccountNumber = "0000123456-00001",
                StartDate = "2022-12-09T22:01:06.217Z",
                EndDate = "2022-12-09T22:01:08.734Z",
                Imei = ["15-digit IMEI"],
                DeviceGroup = "string",
                DataPlan = "string",
                NoSessionFlag = false,
            },
        });
    // TODO: Handle 'response' of type AggregatedReportCallbackResult
}
catch (ApiException<CalculateAggregatedReportAsynchronousError> ex)
{
    if (ex.Error.TryGetHyperPreciseLocationResult(out var error))
    {
        // TODO: Handle 'error' of type HyperPreciseLocationResult
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CalculateAggregatedReportAsynchronousRequest](src/Verizon/Requests/DeviceReports/CalculateAggregatedReportAsynchronousRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AggregatedReportCallbackResult](src/Verizon/Models/AggregatedReportCallbackResult.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[CalculateAggregatedReportAsynchronousError](src/Verizon/Errors/CalculateAggregatedReportAsynchronousError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AggregateSessionReport&gt; CalculateAggregatedReportSynchronous(CalculateAggregatedReportSynchronousRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Calculate aggregated report per day with number of sessions and usage information. User will receive synchronous response for specified list of devices (Max 10) and date range (Max 180 days).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DeviceReports.CalculateAggregatedReportSynchronous(
        new CalculateAggregatedReportSynchronousRequest
        {
            Body = new AggregateSessionReportRequest
            {
                AccountNumber = "0000123456-00001",
                StartDate = "2022-12-09T22:01:06.217Z",
                EndDate = "2022-12-09T22:01:08.734Z",
                Imei = ["15-digit IMEI"],
                DeviceGroup = "string",
                DataPlan = "string",
                NoSessionFlag = false,
            },
        });
    // TODO: Handle 'response' of type AggregateSessionReport
}
catch (ApiException<CalculateAggregatedReportSynchronousError> ex)
{
    if (ex.Error.TryGetHyperPreciseLocationResult(out var error))
    {
        // TODO: Handle 'error' of type HyperPreciseLocationResult
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CalculateAggregatedReportSynchronousRequest](src/Verizon/Requests/DeviceReports/CalculateAggregatedReportSynchronousRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AggregateSessionReport](src/Verizon/Models/AggregateSessionReport.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[CalculateAggregatedReportSynchronousError](src/Verizon/Errors/CalculateAggregatedReportSynchronousError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SessionReport&gt; GetSessionsReport(GetSessionsReportRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Detailed report of session duration and number of bytes transferred per day.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DeviceReports.GetSessionsReport(new GetSessionsReportRequest
    {
        Body = new SessionReportRequest
        {
            AccountNumber = "0000123456-00001",
            Imei = "15-digit IMEI",
            StartDate = "2022-12-09T22:01:06.217Z",
            EndDate = "2022-12-09T22:01:08.734Z",
            DurationLow = 0,
            DurationHigh = 0,
        },
    });
    // TODO: Handle 'response' of type SessionReport
}
catch (ApiException<GetSessionsReportError> ex)
{
    if (ex.Error.TryGetHyperPreciseLocationResult(out var error))
    {
        // TODO: Handle 'error' of type HyperPreciseLocationResult
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetSessionsReportRequest](src/Verizon/Requests/DeviceReports/GetSessionsReportRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SessionReport](src/Verizon/Models/SessionReport.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[GetSessionsReportError](src/Verizon/Errors/GetSessionsReportError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## DeviceSmsMessaging

> Source: [DeviceSmsMessaging](src/Verizon/Api/DeviceSmsMessaging.cs)

<details>
<summary><code>Task&lt;SmsMessagesResponse&gt; GetSmsMessages(GetSmsMessagesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves queued SMS messages sent by all M2M MC devices associated with an account.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DeviceSmsMessaging.GetSmsMessages(new GetSmsMessagesRequest
    {
        AccountName = "0000123456-00001",
        Next = "TheURLForTheNextQuery",
    });
    // TODO: Handle 'response' of type SmsMessagesResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetSmsMessagesRequest](src/Verizon/Requests/DeviceSmsMessaging/GetSmsMessagesRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SmsMessagesResponse](src/Verizon/Models/SmsMessagesResponse.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Verizon/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GioRequestResponse&gt; ListSmsMessageHistory(ListSmsMessageHistoryRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a list of sms history for a given device during a specified time frame.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DeviceSmsMessaging.ListSmsMessageHistory(new ListSmsMessageHistoryRequest
    {
        Body = new SmsEventHistoryRequest
        {
            DeviceId = new GioDeviceId { Kind = "some example string", Id = "some example string" },
        },
    });
    // TODO: Handle 'response' of type GioRequestResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ListSmsMessageHistoryRequest](src/Verizon/Requests/DeviceSmsMessaging/ListSmsMessageHistoryRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GioRequestResponse](src/Verizon/Models/GioRequestResponse.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Verizon/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GioRequestResponse&gt; SendAnSmsMessage(SendAnSmsMessageRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Sends an SMS message to one device. Messages are queued on the M2M MC Platform and sent as soon as possible, but they may be delayed due to traffic and routing considerations.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DeviceSmsMessaging.SendAnSmsMessage(new SendAnSmsMessageRequest
    {
        Body = new GiosmsSendRequest
        {
            AccountName = "0000123456-00001",
            CustomFields = [new KvPair { Key = "CustomField1", Value = "value of the field" }],
            DataEncoding = "optional 7 or 8-bit encoding",
            TimeToLive = "000000010000000R",
            DeviceIds = [new GioDeviceId { Kind = "iccid", Id = "20-digit ICCID" }],
            SmsMessage = "the body or text of the message itself",
        },
    });
    // TODO: Handle 'response' of type GioRequestResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SendAnSmsMessageRequest](src/Verizon/Requests/DeviceSmsMessaging/SendAnSmsMessageRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GioRequestResponse](src/Verizon/Models/GioRequestResponse.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Verizon/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SuccessResponse&gt; StartSmsMessageDelivery(StartSmsMessageDeliveryRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Starts delivery of SMS messages for the specified account.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DeviceSmsMessaging.StartSmsMessageDelivery(new StartSmsMessageDeliveryRequest
    {
        AccountName = "0000123456-00001",
    });
    // TODO: Handle 'response' of type SuccessResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[StartSmsMessageDeliveryRequest](src/Verizon/Requests/DeviceSmsMessaging/StartSmsMessageDeliveryRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SuccessResponse](src/Verizon/Models/SuccessResponse.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Verizon/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## DeviceServiceManagement

> Source: [DeviceServiceManagement](src/Verizon/Api/DeviceServiceManagement.cs)

<details>
<summary><code>Task&lt;BullseyeServiceResult&gt; GetDeviceHyperPreciseStatus(GetDeviceHyperPreciseStatusRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Gets the list of a status for hyper-precise location devices.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DeviceServiceManagement.GetDeviceHyperPreciseStatus(
        new GetDeviceHyperPreciseStatusRequest { Imei = "15-digit IMEI", AccountNumber = "0000123456-00001" });
    // TODO: Handle 'response' of type BullseyeServiceResult
}
catch (ApiException<GetDeviceHyperPreciseStatusError> ex)
{
    if (ex.Error.TryGetHyperPreciseLocationResult(out var error))
    {
        // TODO: Handle 'error' of type HyperPreciseLocationResult
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetDeviceHyperPreciseStatusRequest](src/Verizon/Requests/DeviceServiceManagement/GetDeviceHyperPreciseStatusRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BullseyeServiceResult](src/Verizon/Models/BullseyeServiceResult.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[GetDeviceHyperPreciseStatusError](src/Verizon/Errors/GetDeviceHyperPreciseStatusError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;BullseyeServiceResult&gt; UpdateDeviceHyperPreciseStatus(UpdateDeviceHyperPreciseStatusRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Enable/disable hyper-precise service for a device.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DeviceServiceManagement.UpdateDeviceHyperPreciseStatus(
        new UpdateDeviceHyperPreciseStatusRequest
        {
            Body = new BullseyeServiceRequest
            {
                DeviceList = [
                    new DeviceServiceRequest { Imei = "some example string", BullseyeEnable = new HplBullseyeEnable() },
                ],
                AccountNumber = "some example string",
            },
        });
    // TODO: Handle 'response' of type BullseyeServiceResult
}
catch (ApiException<UpdateDeviceHyperPreciseStatusError> ex)
{
    if (ex.Error.TryGetHyperPreciseLocationResult(out var error))
    {
        // TODO: Handle 'error' of type HyperPreciseLocationResult
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UpdateDeviceHyperPreciseStatusRequest](src/Verizon/Requests/DeviceServiceManagement/UpdateDeviceHyperPreciseStatusRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BullseyeServiceResult](src/Verizon/Models/BullseyeServiceResult.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[UpdateDeviceHyperPreciseStatusError](src/Verizon/Errors/UpdateDeviceHyperPreciseStatusError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## DevicesLocationSubscriptions

> Source: [DevicesLocationSubscriptions](src/Verizon/Api/DevicesLocationSubscriptions.cs)

<details>
<summary><code>Task&lt;DeviceLocationSubscription&gt; GetLocationServiceSubscriptionStatus(GetLocationServiceSubscriptionStatusRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This subscriptions endpoint retrieves an account's current location subscription status.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DevicesLocationSubscriptions.GetLocationServiceSubscriptionStatus(
        new GetLocationServiceSubscriptionStatusRequest { AccountName = "0000123456-00001" });
    // TODO: Handle 'response' of type DeviceLocationSubscription
}
catch (ApiException<GetLocationServiceSubscriptionStatusError> ex)
{
    if (ex.Error.TryGetDeviceLocationResult(out var error))
    {
        // TODO: Handle 'error' of type DeviceLocationResult
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetLocationServiceSubscriptionStatusRequest](src/Verizon/Requests/DevicesLocationSubscriptions/GetLocationServiceSubscriptionStatusRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeviceLocationSubscription](src/Verizon/Models/DeviceLocationSubscription.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[GetLocationServiceSubscriptionStatusError](src/Verizon/Errors/GetLocationServiceSubscriptionStatusError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;object&gt; GetLocationServiceUsage(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This endpoint allows user to search for billable usage for accounts based on the provided date range.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DevicesLocationSubscriptions.GetLocationServiceUsage();
    // TODO: Handle 'response' of type object
}
catch (ApiException<GetLocationServiceUsageError> ex)
{
    if (ex.Error.TryGetDeviceLocationResult(out var error))
    {
        // TODO: Handle 'error' of type DeviceLocationResult
    }
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>object</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[GetLocationServiceUsageError](src/Verizon/Errors/GetLocationServiceUsageError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## DevicesLocations

> Source: [DevicesLocations](src/Verizon/Api/DevicesLocations.cs)

<details>
<summary><code>Task&lt;TransactionId&gt; CancelQueuedLocationReportGeneration(CancelQueuedLocationReportGenerationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Cancel a queued device location report.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DevicesLocations.CancelQueuedLocationReportGeneration(
        new CancelQueuedLocationReportGenerationRequest
        {
            AccountName = "0252012345-00001",
            Txid = "2c90bd28-eeee-ffff-gggg-7e3bd4fbff33",
        });
    // TODO: Handle 'response' of type TransactionId
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CancelQueuedLocationReportGenerationRequest](src/Verizon/Requests/DevicesLocations/CancelQueuedLocationReportGenerationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TransactionId](src/Verizon/Models/TransactionId.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Verizon/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AsynchronousLocationRequestResult&gt; CreateLocationReport(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Request an asynchronous device location report.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DevicesLocations.CreateLocationReport();
    // TODO: Handle 'response' of type AsynchronousLocationRequestResult
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AsynchronousLocationRequestResult](src/Verizon/Models/AsynchronousLocationRequestResult.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Verizon/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;LocationReportStatus&gt; GetLocationReportStatus(GetLocationReportStatusRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the current status of a requested device location report.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DevicesLocations.GetLocationReportStatus(new GetLocationReportStatusRequest
    {
        AccountName = "0252012345-00001",
        Txid = "2c90bd28-eeee-ffff-gggg-7e3bd4fbff33",
    });
    // TODO: Handle 'response' of type LocationReportStatus
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetLocationReportStatusRequest](src/Verizon/Requests/DevicesLocations/GetLocationReportStatusRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[LocationReportStatus](src/Verizon/Models/LocationReportStatus.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Verizon/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SynchronousLocationRequestResult&gt; ListDevicesLocationsAsynchronous(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Requests the current or cached location of up to 10,000 IoT or consumer devices (phones, tablets. etc.). This request returns a synchronous transaction ID, and the location information for each device is returned asynchronously as a DeviceLocation callback message.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DevicesLocations.ListDevicesLocationsAsynchronous();
    // TODO: Handle 'response' of type SynchronousLocationRequestResult
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SynchronousLocationRequestResult](src/Verizon/Models/SynchronousLocationRequestResult.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Verizon/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;Location&gt;&gt; ListDevicesLocationsSynchronous(ListDevicesLocationsSynchronousRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This locations endpoint retrieves the locations for a list of devices.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DevicesLocations.ListDevicesLocationsSynchronous(
        new ListDevicesLocationsSynchronousRequest
        {
            Body = new LocationRequest
            {
                AccountName = "1234567890-00001",
                DeviceList = [
                    new DeviceInfo { Id = "980003420535573", Kind = "imei", Mdn = "7892345678" },
                    new DeviceInfo { Id = "375535024300089", Kind = "imei", Mdn = "7897654321" },
                ],
                AccuracyMode = AccuracyMode._0,
                CacheMode = CacheMode._1,
            },
        });
    // TODO: Handle 'response' of type IReadOnlyList<Location>
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ListDevicesLocationsSynchronousRequest](src/Verizon/Requests/DevicesLocations/ListDevicesLocationsSynchronousRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[Location](src/Verizon/Models/Location.cs)&gt;</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Verizon/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;LocationReport&gt; RetrieveLocationReport(RetrieveLocationReportRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Download a completed asynchronous device location report.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DevicesLocations.RetrieveLocationReport(new RetrieveLocationReportRequest
    {
        AccountName = "0000123456-00001",
        Txid = "2017-12-11Te8b47da2-eeee-ffff-gggg-61815e1e97e9",
        Startindex = 0,
    });
    // TODO: Handle 'response' of type LocationReport
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[RetrieveLocationReportRequest](src/Verizon/Requests/DevicesLocations/RetrieveLocationReportRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[LocationReport](src/Verizon/Models/LocationReport.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Verizon/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## DiagnosticsCallbacks

> Source: [DiagnosticsCallbacks](src/Verizon/Api/DiagnosticsCallbacks.cs)

<details>
<summary><code>Task&lt;IReadOnlyList&lt;DeviceDiagnosticsCallback&gt;&gt; GetDiagnosticsSubscriptionCallbackInfo(GetDiagnosticsSubscriptionCallbackInfoRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This endpoint allows user to get the registered callback information of an existing diagnostics subscription.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DiagnosticsCallbacks.GetDiagnosticsSubscriptionCallbackInfo(
        new GetDiagnosticsSubscriptionCallbackInfoRequest { AccountName = "0000123456-00001" });
    // TODO: Handle 'response' of type IReadOnlyList<DeviceDiagnosticsCallback>
}
catch (ApiException<GetDiagnosticsSubscriptionCallbackInfoError> ex)
{
    if (ex.Error.TryGetDeviceDiagnosticsResult(out var error))
    {
        // TODO: Handle 'error' of type DeviceDiagnosticsResult
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetDiagnosticsSubscriptionCallbackInfoRequest](src/Verizon/Requests/DiagnosticsCallbacks/GetDiagnosticsSubscriptionCallbackInfoRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[DeviceDiagnosticsCallback](src/Verizon/Models/DeviceDiagnosticsCallback.cs)&gt;</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[GetDiagnosticsSubscriptionCallbackInfoError](src/Verizon/Errors/GetDiagnosticsSubscriptionCallbackInfoError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeviceDiagnosticsCallback&gt; RegisterDiagnosticsCallbackUrl(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This endpoint allows user update the callback HTTPS address of an existing diagnostics subscription.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DiagnosticsCallbacks.RegisterDiagnosticsCallbackUrl();
    // TODO: Handle 'response' of type DeviceDiagnosticsCallback
}
catch (ApiException<RegisterDiagnosticsCallbackUrlError> ex)
{
    if (ex.Error.TryGetDeviceDiagnosticsResult(out var error))
    {
        // TODO: Handle 'error' of type DeviceDiagnosticsResult
    }
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeviceDiagnosticsCallback](src/Verizon/Models/DeviceDiagnosticsCallback.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[RegisterDiagnosticsCallbackUrlError](src/Verizon/Errors/RegisterDiagnosticsCallbackUrlError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeviceDiagnosticsCallback&gt; UnregisterDiagnosticsCallback(UnregisterDiagnosticsCallbackRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This endpoint allows user to delete a registered callback URL and credential.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DiagnosticsCallbacks.UnregisterDiagnosticsCallback(
        new UnregisterDiagnosticsCallbackRequest { AccountName = "0000123456-00001", ServiceName = "string" });
    // TODO: Handle 'response' of type DeviceDiagnosticsCallback
}
catch (ApiException<UnregisterDiagnosticsCallbackError> ex)
{
    if (ex.Error.TryGetDeviceDiagnosticsResult(out var error))
    {
        // TODO: Handle 'error' of type DeviceDiagnosticsResult
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UnregisterDiagnosticsCallbackRequest](src/Verizon/Requests/DiagnosticsCallbacks/UnregisterDiagnosticsCallbackRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeviceDiagnosticsCallback](src/Verizon/Models/DeviceDiagnosticsCallback.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[UnregisterDiagnosticsCallbackError](src/Verizon/Errors/UnregisterDiagnosticsCallbackError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## DiagnosticsFactoryReset

> Source: [DiagnosticsFactoryReset](src/Verizon/Api/DiagnosticsFactoryReset.cs)

<details>
<summary><code>Task&lt;DiagnosticsObservationResult&gt; DecivesRestart(DecivesRestartRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Performs a device reboot or a factory reset on the modem portion of the device.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DiagnosticsFactoryReset.DecivesRestart(new DecivesRestartRequest
    {
        Body = new DeviceResetRequest
        {
            AccountName = "0642233522-00003",
            Action = "reboot",
            Devices = [new Device { Id = "355154080648401", Kind = "IMEI" }],
        },
    });
    // TODO: Handle 'response' of type DiagnosticsObservationResult
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DecivesRestartRequest](src/Verizon/Requests/DiagnosticsFactoryReset/DecivesRestartRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DiagnosticsObservationResult](src/Verizon/Models/DiagnosticsObservationResult.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Verizon/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## DiagnosticsHistory

> Source: [DiagnosticsHistory](src/Verizon/Api/DiagnosticsHistory.cs)

<details>
<summary><code>Task&lt;IReadOnlyList&lt;History&gt;&gt; GetDiagnosticsHistory(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This endpoint allows the user to get the history data.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DiagnosticsHistory.GetDiagnosticsHistory();
    // TODO: Handle 'response' of type IReadOnlyList<History>
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[History](src/Verizon/Models/History.cs)&gt;</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Verizon/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## DiagnosticsObservations

> Source: [DiagnosticsObservations](src/Verizon/Api/DiagnosticsObservations.cs)

<details>
<summary><code>Task&lt;DiagnosticsObservationResult&gt; StartDiagnosticsObservation(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This endpoint allows the user to start or change observe diagnostics.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DiagnosticsObservations.StartDiagnosticsObservation();
    // TODO: Handle 'response' of type DiagnosticsObservationResult
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DiagnosticsObservationResult](src/Verizon/Models/DiagnosticsObservationResult.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Verizon/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DiagnosticsObservationResult&gt; StopDiagnosticsObservation(StopDiagnosticsObservationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This endpoint allows the user to stop or reset observe diagnostics.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DiagnosticsObservations.StopDiagnosticsObservation(new StopDiagnosticsObservationRequest
    {
        TransactionId = "5f4bd2ff-5d7f-444d-af17-3f6a80bb2a94",
        AccountName = "0000123456-00001",
    });
    // TODO: Handle 'response' of type DiagnosticsObservationResult
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[StopDiagnosticsObservationRequest](src/Verizon/Requests/DiagnosticsObservations/StopDiagnosticsObservationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DiagnosticsObservationResult](src/Verizon/Models/DiagnosticsObservationResult.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Verizon/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## DiagnosticsSettings

> Source: [DiagnosticsSettings](src/Verizon/Api/DiagnosticsSettings.cs)

<details>
<summary><code>Task&lt;IReadOnlyList&lt;DiagnosticObservationSetting&gt;&gt; ListDiagnosticsSettings(ListDiagnosticsSettingsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This endpoint retrieves diagnostics settings synchronously.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DiagnosticsSettings.ListDiagnosticsSettings(new ListDiagnosticsSettingsRequest
    {
        AccountName = "0000123456-00001",
        Devices = "864508030026238,IMEI",
    });
    // TODO: Handle 'response' of type IReadOnlyList<DiagnosticObservationSetting>
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ListDiagnosticsSettingsRequest](src/Verizon/Requests/DiagnosticsSettings/ListDiagnosticsSettingsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[DiagnosticObservationSetting](src/Verizon/Models/DiagnosticObservationSetting.cs)&gt;</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Verizon/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## DiagnosticsSubscriptions

> Source: [DiagnosticsSubscriptions](src/Verizon/Api/DiagnosticsSubscriptions.cs)

<details>
<summary><code>Task&lt;DiagnosticsSubscription&gt; GetDiagnosticsSubscription(GetDiagnosticsSubscriptionRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This endpoint retrieves a diagnostics subscription by account.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DiagnosticsSubscriptions.GetDiagnosticsSubscription(
        new GetDiagnosticsSubscriptionRequest { AccountName = "0000123456-00001" });
    // TODO: Handle 'response' of type DiagnosticsSubscription
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetDiagnosticsSubscriptionRequest](src/Verizon/Requests/DiagnosticsSubscriptions/GetDiagnosticsSubscriptionRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DiagnosticsSubscription](src/Verizon/Models/DiagnosticsSubscription.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Verizon/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## EtxAppConfiguration

> Source: [EtxAppConfiguration](src/Verizon/Api/EtxAppConfiguration.cs)

<details>
<summary><code>Task&lt;GeoFenceConfigurationResponse&gt; CreateConfiguration(CreateConfigurationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This endpoint creates a new configuration in the system. The data for the new configuration should be provided as JSON in the body of the POST request. The system will return with a unique ID for the configuration, which is needed for any further manipulation (update or delete) of the configuration.

Note: The user needs to authenticate with their ThingSpace credentials using the Access/Bearer and Session/M2M tokens in order to call this API.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.EtxAppConfiguration.CreateConfiguration(new CreateConfigurationRequest
    {
        VendorId = "VerizonETX",
        Body = new GeoFenceConfigurationRequest
        {
            GeoFence = new GeoFence
            {
                Type = TypeEnum.FeatureCollection,
                Features = [
                    new FeatureItem
                    {
                        Type = Type1.Feature,
                        Geometry = new LineString { Type = type, Coordinates = coordinates },
                        Properties = properties,
                    },
                ],
            },
            Messages = [
                new Message
                {
                    IsPrivate = true,
                    RoadUserType = [RoadUserTypes.VulnerableRoadUser],
                    TriggerConditions = [TriggerCondition.Enter],
                    Generic = new GenericPayload
                    {
                        MessageType = "some example string",
                        MessageFormat = "some example string",
                        Payload = "some example string",
                    },
                },
            ],
            IsActive = true,
        },
    });
    // TODO: Handle 'response' of type GeoFenceConfigurationResponse
}
catch (ApiException<CreateConfigurationError> ex)
{
    if (ex.Error.TryGetResponseError(out var error))
    {
        // TODO: Handle 'error' of type ResponseError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CreateConfigurationRequest](src/Verizon/Requests/EtxAppConfiguration/CreateConfigurationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GeoFenceConfigurationResponse](src/Verizon/Models/GeoFenceConfigurationResponse.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[CreateConfigurationError](src/Verizon/Errors/CreateConfigurationError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task DeleteConfiguration(DeleteConfigurationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This endpoint deletes a specific configuration from the system. It requires the configuration ID parameter, which was provided by the POST (create) operation.

Note: The user needs to authenticate with their ThingSpace credentials using the Access/Bearer and Session/M2M tokens in order to call this API.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.EtxAppConfiguration.DeleteConfiguration(new DeleteConfigurationRequest
    {
        Id = "18bac1ff-c7bd-44d9-a7ad-06a093a94713",
        VendorId = "VerizonETX",
    });
}
catch (ApiException<DeleteConfigurationError> ex)
{
    if (ex.Error.TryGetResponseError(out var error))
    {
        // TODO: Handle 'error' of type ResponseError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeleteConfigurationRequest](src/Verizon/Requests/EtxAppConfiguration/DeleteConfigurationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[DeleteConfigurationError](src/Verizon/Errors/DeleteConfigurationError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GeoFenceConfigurationResponse&gt; GetConfiguration(GetConfigurationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This endpoint fetches and returns a specific configuration's details. The configuration ID parameter, which was provided when the configuration was created through the POST request, is need to retrieve the configuration details.

Note: The user needs to authenticate with their ThingSpace credentials using the Access/Bearer and Session/M2M tokens in order to call this API.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.EtxAppConfiguration.GetConfiguration(new GetConfigurationRequest
    {
        Id = "18bac1ff-c7bd-44d9-a7ad-06a093a94713",
        VendorId = "VerizonETX",
    });
    // TODO: Handle 'response' of type GeoFenceConfigurationResponse
}
catch (ApiException<GetConfigurationError> ex)
{
    if (ex.Error.TryGetResponseError(out var error))
    {
        // TODO: Handle 'error' of type ResponseError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetConfigurationRequest](src/Verizon/Requests/EtxAppConfiguration/GetConfigurationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GeoFenceConfigurationResponse](src/Verizon/Models/GeoFenceConfigurationResponse.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[GetConfigurationError](src/Verizon/Errors/GetConfigurationError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;ConfigurationListItem&gt;&gt; GetConfigurationList(GetConfigurationListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This endpoint fetches and returns the list of configurations defined by the Vendor. The list contains the configurations' identifier, name, description, and active flag. The vendor ID is provided when the configuration is created through the POST request.

Note: The user needs to authenticate with their ThingSpace credentials using the Access/Bearer and Session/M2M tokens in order to call this API.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.EtxAppConfiguration.GetConfigurationList(new GetConfigurationListRequest
    {
        VendorId = "VerizonETX",
    });
    // TODO: Handle 'response' of type IReadOnlyList<ConfigurationListItem>
}
catch (ApiException<GetConfigurationListError> ex)
{
    if (ex.Error.TryGetResponseError(out var error))
    {
        // TODO: Handle 'error' of type ResponseError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetConfigurationListRequest](src/Verizon/Requests/EtxAppConfiguration/GetConfigurationListRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[ConfigurationListItem](src/Verizon/Models/ConfigurationListItem.cs)&gt;</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[GetConfigurationListError](src/Verizon/Errors/GetConfigurationListError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task UpdateConfiguration(UpdateConfigurationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This endpoint updates an existing configuration. Similar to POST, the updated data for the configuration should be provided as JSON in the body of the PUT request. The configuration ID parameter, which was provided by the POST (create) operation, is required to do any updates on the configuration.

Note: The user needs to authenticate with their ThingSpace credentials using the Access/Bearer and Session/M2M tokens in order to call this API.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.EtxAppConfiguration.UpdateConfiguration(new UpdateConfigurationRequest
    {
        Id = "18bac1ff-c7bd-44d9-a7ad-06a093a94713",
        VendorId = "VerizonETX",
        Body = new GeoFenceConfigurationUpdateRequest(),
    });
}
catch (ApiException<UpdateConfigurationError> ex)
{
    if (ex.Error.TryGetResponseError(out var error))
    {
        // TODO: Handle 'error' of type ResponseError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UpdateConfigurationRequest](src/Verizon/Requests/EtxAppConfiguration/UpdateConfigurationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[UpdateConfigurationError](src/Verizon/Errors/UpdateConfigurationError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## EtxRegistration

> Source: [EtxRegistration](src/Verizon/Api/EtxRegistration.cs)

<details>
<summary><code>Task&lt;ClientPersistenceResponse&gt; GetEtxClientCertificate(GetEtxClientCertificateRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

With this API call the user can check the certificate of the device. At least one of the DeviceID, IMEI, ICCID or IMSI is required to make the call.

Note: The user needs to authenticate with their ThingSpace credentials using the Access/Bearer and Session/M2M tokens in order to call this API.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.EtxRegistration.GetEtxClientCertificate(new GetEtxClientCertificateRequest
    {
        Id = new EtxClientIdLookup(),
        VendorId = "VerizonETX",
        XTransactionId = Guid.Parse("123e4567-e89b-12d3-a456-426614174000"),
    });
    // TODO: Handle 'response' of type ClientPersistenceResponse
}
catch (ApiException<GetEtxClientCertificateError> ex)
{
    if (ex.Error.TryGetEtxRespondingError(out var error))
    {
        // TODO: Handle 'error' of type EtxRespondingError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetEtxClientCertificateRequest](src/Verizon/Requests/EtxRegistration/GetEtxClientCertificateRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ClientPersistenceResponse](src/Verizon/Models/ClientPersistenceResponse.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[GetEtxClientCertificateError](src/Verizon/Errors/GetEtxClientCertificateError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ConnectionResponse&gt; GetEtxConnectionUrl(GetEtxConnectionUrlRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

With this API call the device or software service requests the MQTT URL for the location that it needs to connect. To determine the proper URL the device or software service needs to provide its ID (the one that was provided in the registration request), location (GPS coordinates), and whether it is on the Verizon cellular network or not.

Note: The user needs to authenticate with their ThingSpace credentials using the Access/Bearer and Session/M2M tokens in order to call this API.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.EtxRegistration.GetEtxConnectionUrl(new GetEtxConnectionUrlRequest
    {
        VendorId = "VerizonETX",
        XTransactionId = Guid.Parse("123e4567-e89b-12d3-a456-426614174000"),
        Body = new ConnectionRequest
        {
            DeviceId = Guid.Parse("00000000-0000-0000-0000-000000000000"),
            Geolocation = new Geolocation { Latitude = 1.5d, Longitude = 1.5d },
            NetworkType = NetworkType.Vz,
        },
    });
    // TODO: Handle 'response' of type ConnectionResponse
}
catch (ApiException<GetEtxConnectionUrlError> ex)
{
    if (ex.Error.TryGetEtxRespondingError(out var error))
    {
        // TODO: Handle 'error' of type EtxRespondingError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetEtxConnectionUrlRequest](src/Verizon/Requests/EtxRegistration/GetEtxConnectionUrlRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ConnectionResponse](src/Verizon/Models/ConnectionResponse.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[GetEtxConnectionUrlError](src/Verizon/Errors/GetEtxConnectionUrlError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ConnectionResponseV3&gt; GetEtxConnectionUrlMultiMec(GetEtxConnectionUrlMultiMecRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

With this API call the device or software service requests the MQTT URL for the location that it needs to connect. To determine the proper URL the device or software service needs to provide its ID (the one that was provided in the registration request), location (GPS coordinates), and whether it is on the Verizon cellular network or not.

If there are multiple MECs that serve the location of the client all options are provided in the response, and the client is free to choose which MEC they want to connect.

Note: The user needs to authenticate with their ThingSpace credentials using the Access/Bearer and Session/M2M tokens in order to call this API.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.EtxRegistration.GetEtxConnectionUrlMultiMec(new GetEtxConnectionUrlMultiMecRequest
    {
        VendorId = "VerizonETX",
        XTransactionId = Guid.Parse("123e4567-e89b-12d3-a456-426614174000"),
        Body = new ConnectionRequest
        {
            DeviceId = Guid.Parse("00000000-0000-0000-0000-000000000000"),
            Geolocation = new Geolocation { Latitude = 1.5d, Longitude = 1.5d },
            NetworkType = NetworkType.Vz,
        },
    });
    // TODO: Handle 'response' of type ConnectionResponseV3
}
catch (ApiException<GetEtxConnectionUrlMultiMecError> ex)
{
    if (ex.Error.TryGetEtxRespondingError(out var error))
    {
        // TODO: Handle 'error' of type EtxRespondingError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetEtxConnectionUrlMultiMecRequest](src/Verizon/Requests/EtxRegistration/GetEtxConnectionUrlMultiMecRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ConnectionResponseV3](src/Verizon/Models/ConnectionResponseV3.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[GetEtxConnectionUrlMultiMecError](src/Verizon/Errors/GetEtxConnectionUrlMultiMecError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;DevicesResponse&gt;&gt; QueryEtxDevices(QueryEtxDevicesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This API allows retrieving devices by vendor ID and optional filters. The request should include the VendorID and any filters to apply.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.EtxRegistration.QueryEtxDevices(new QueryEtxDevicesRequest
    {
        XTransactionId = Guid.Parse("123e4567-e89b-12d3-a456-426614174000"),
        Body = new DevicesRequest { VendorId = "some example string" },
    });
    // TODO: Handle 'response' of type IReadOnlyList<DevicesResponse>
}
catch (ApiException<QueryEtxDevicesError> ex)
{
    if (ex.Error.TryGetEtxRespondingError(out var error))
    {
        // TODO: Handle 'error' of type EtxRespondingError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[QueryEtxDevicesRequest](src/Verizon/Requests/EtxRegistration/QueryEtxDevicesRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[DevicesResponse](src/Verizon/Models/DevicesResponse.cs)&gt;</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[QueryEtxDevicesError](src/Verizon/Errors/QueryEtxDevicesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ClientRegistrationResponse&gt; RegisterEtxClient(RegisterEtxClientRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

With this API call the user (client) registers its device or software service to the ETX system. Therefore, when a connection is initiated from the device or software service to the ETX system along with the credential provided by this registration call, then the connection will be authorized.

- The user can register multiple devices or software services, which can all be used at the same time.
- There rules set in the system that limit the type and subtype of the clients that are allowed to be registered under the VendorID. The rules are created based ont he agreement between the Vendor and Verizon.
- The user will only be able to register a limited number of devices or software services under the same VendorID. This registration limit is specified by the agreement between the Vendor and Verizon.

Note: The user needs to authenticate with their ThingSpace credentials using the Access/Bearer and Session/M2M tokens in order to call this API.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.EtxRegistration.RegisterEtxClient(new RegisterEtxClientRequest
    {
        XTransactionId = Guid.Parse("123e4567-e89b-12d3-a456-426614174000"),
        Body = new ClientRegistrationRequestV2
        {
            ClientType = EtxClientType.Vehicle,
            ClientSubtype = ClientSubtype.PassengerCar,
            VendorId = "some example string",
        },
    });
    // TODO: Handle 'response' of type ClientRegistrationResponse
}
catch (ApiException<RegisterEtxClientError> ex)
{
    if (ex.Error.TryGetEtxRespondingError(out var error))
    {
        // TODO: Handle 'error' of type EtxRespondingError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[RegisterEtxClientRequest](src/Verizon/Requests/EtxRegistration/RegisterEtxClientRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ClientRegistrationResponse](src/Verizon/Models/ClientRegistrationResponse.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[RegisterEtxClientError](src/Verizon/Errors/RegisterEtxClientError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ClientRegistrationResponse&gt; RenewEtxClientCertificate(RenewEtxClientCertificateRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

With this API call the user (client) can:
- renew the certificate of a device or software service in the ETX system if the original certificate has expired. If the client's certificate expired or going to expire within 30 days and new certificate will be issued. If the certificate expires more than 30 days, the current certificate will be returned to the client.
- complete its device or software service registration to the ETX system if the original registration request was not successful because of a pending certificate generation. Whenever the user receives a "client registration is pending" response (HTTP 202) from POST /clients/registration call. The client should initiate this PUT API call to finish the registration process and get the required certificate.

Note: The user needs to authenticate with their ThingSpace credentials using the Access/Bearer and Session/M2M tokens in order to call this API.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.EtxRegistration.RenewEtxClientCertificate(new RenewEtxClientCertificateRequest
    {
        DeviceId = Guid.Parse("a4fcd16a-343d-4527-8203-2f46e3e4ff4b"),
        VendorId = "VerizonETX",
        XTransactionId = Guid.Parse("123e4567-e89b-12d3-a456-426614174000"),
    });
    // TODO: Handle 'response' of type ClientRegistrationResponse
}
catch (ApiException<RenewEtxClientCertificateError> ex)
{
    if (ex.Error.TryGetEtxRespondingError(out var error))
    {
        // TODO: Handle 'error' of type EtxRespondingError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[RenewEtxClientCertificateRequest](src/Verizon/Requests/EtxRegistration/RenewEtxClientCertificateRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ClientRegistrationResponse](src/Verizon/Models/ClientRegistrationResponse.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[RenewEtxClientCertificateError](src/Verizon/Errors/RenewEtxClientCertificateError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task UnregisterEtxClients(UnregisterEtxClientsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

With this API call the user (client) can unregister its devices and software services from the ETX system. The unregistered devices and services will no longer be able to use the ETX Message Exchange.

Note: The user needs to authenticate with their ThingSpace credentials using the Access/Bearer and Session/M2M tokens in order to call this API.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.EtxRegistration.UnregisterEtxClients(new UnregisterEtxClientsRequest
    {
        DeviceIDs = [Guid.Parse("00000000-0000-0000-0000-000000000000")],
        VendorId = "VerizonETX",
        XTransactionId = Guid.Parse("123e4567-e89b-12d3-a456-426614174000"),
    });
}
catch (ApiException<UnregisterEtxClientsError> ex)
{
    if (ex.Error.TryGetEtxRespondingError(out var error))
    {
        // TODO: Handle 'error' of type EtxRespondingError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UnregisterEtxClientsRequest](src/Verizon/Requests/EtxRegistration/UnregisterEtxClientsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[UnregisterEtxClientsError](src/Verizon/Errors/UnregisterEtxClientsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Exclusions

> Source: [Exclusions](src/Verizon/Api/Exclusions.cs)

<details>
<summary><code>Task&lt;GetAccountDeviceConsent&gt; DevicesLocationGetConsentAsync(DevicesLocationGetConsentAsyncRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Get the consent settings for the entire account or device list in an account.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Exclusions.DevicesLocationGetConsentAsync(new DevicesLocationGetConsentAsyncRequest
    {
        AccountName = "0000123456-00001",
        DeviceId = "900000000000009",
    });
    // TODO: Handle 'response' of type GetAccountDeviceConsent
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DevicesLocationGetConsentAsyncRequest](src/Verizon/Requests/Exclusions/DevicesLocationGetConsentAsyncRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GetAccountDeviceConsent](src/Verizon/Models/GetAccountDeviceConsent.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Verizon/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ConsentTransactionId&gt; DevicesLocationGiveConsentAsync(DevicesLocationGiveConsentAsyncRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Create a consent record to use location services as an asynchronous request.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Exclusions.DevicesLocationGiveConsentAsync(
        new DevicesLocationGiveConsentAsyncRequest());
    // TODO: Handle 'response' of type ConsentTransactionId
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DevicesLocationGiveConsentAsyncRequest](src/Verizon/Requests/Exclusions/DevicesLocationGiveConsentAsyncRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ConsentTransactionId](src/Verizon/Models/ConsentTransactionId.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Verizon/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ConsentTransactionId&gt; DevicesLocationUpdateConsent(DevicesLocationUpdateConsentRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Update the location services consent record for an entire account.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Exclusions.DevicesLocationUpdateConsent(new DevicesLocationUpdateConsentRequest());
    // TODO: Handle 'response' of type ConsentTransactionId
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DevicesLocationUpdateConsentRequest](src/Verizon/Requests/Exclusions/DevicesLocationUpdateConsentRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ConsentTransactionId](src/Verizon/Models/ConsentTransactionId.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Verizon/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeviceLocationSuccessResult&gt; ExcludeDevices(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This consents endpoint sets a new exclusion list.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Exclusions.ExcludeDevices();
    // TODO: Handle 'response' of type DeviceLocationSuccessResult
}
catch (ApiException<ExcludeDevicesError> ex)
{
    if (ex.Error.TryGetDeviceLocationResult(out var error))
    {
        // TODO: Handle 'error' of type DeviceLocationResult
    }
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeviceLocationSuccessResult](src/Verizon/Models/DeviceLocationSuccessResult.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[ExcludeDevicesError](src/Verizon/Errors/ExcludeDevicesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DevicesConsentResult&gt; ListExcludedDevices(ListExcludedDevicesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This consents endpoint retrieves a list of excluded devices in an account.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Exclusions.ListExcludedDevices(new ListExcludedDevicesRequest
    {
        AccountName = "0252012345-00001",
        StartIndex = "0",
    });
    // TODO: Handle 'response' of type DevicesConsentResult
}
catch (ApiException<ListExcludedDevicesError> ex)
{
    if (ex.Error.TryGetDeviceLocationResult(out var error))
    {
        // TODO: Handle 'error' of type DeviceLocationResult
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ListExcludedDevicesRequest](src/Verizon/Requests/Exclusions/ListExcludedDevicesRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DevicesConsentResult](src/Verizon/Models/DevicesConsentResult.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[ListExcludedDevicesError](src/Verizon/Errors/ListExcludedDevicesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeviceLocationSuccessResult&gt; RemoveDevicesFromExclusionList(RemoveDevicesFromExclusionListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Removes devices from the exclusion list so that they can be located with Device Location Services requests.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Exclusions.RemoveDevicesFromExclusionList(new RemoveDevicesFromExclusionListRequest
    {
        AccountName = "0000123456-00001",
        DeviceList = "IMEI",
    });
    // TODO: Handle 'response' of type DeviceLocationSuccessResult
}
catch (ApiException<RemoveDevicesFromExclusionListError> ex)
{
    if (ex.Error.TryGetDeviceLocationResult(out var error))
    {
        // TODO: Handle 'error' of type DeviceLocationResult
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[RemoveDevicesFromExclusionListRequest](src/Verizon/Requests/Exclusions/RemoveDevicesFromExclusionListRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeviceLocationSuccessResult](src/Verizon/Models/DeviceLocationSuccessResult.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[RemoveDevicesFromExclusionListError](src/Verizon/Errors/RemoveDevicesFromExclusionListError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## FirmwareV1

> Source: [FirmwareV1](src/Verizon/Api/FirmwareV1.cs)

<details>
<summary><code>Task&lt;FotaV1SuccessResult&gt; CancelScheduledFirmwareUpgrade(CancelScheduledFirmwareUpgradeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Cancel a scheduled firmware upgrade.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.FirmwareV1.CancelScheduledFirmwareUpgrade(new CancelScheduledFirmwareUpgradeRequest
    {
        AccountName = "0242078689-00001",
        UpgradeId = "e3a8d88a-04c6-4ef3-b039-89b62f91e962",
    });
    // TODO: Handle 'response' of type FotaV1SuccessResult
}
catch (ApiException<CancelScheduledFirmwareUpgradeError> ex)
{
    if (ex.Error.TryGetFotaV1Result(out var error))
    {
        // TODO: Handle 'error' of type FotaV1Result
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CancelScheduledFirmwareUpgradeRequest](src/Verizon/Requests/FirmwareV1/CancelScheduledFirmwareUpgradeRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[FotaV1SuccessResult](src/Verizon/Models/FotaV1SuccessResult.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[CancelScheduledFirmwareUpgradeError](src/Verizon/Errors/CancelScheduledFirmwareUpgradeError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;Firmware&gt;&gt; ListAvailableFirmware(ListAvailableFirmwareRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Lists all device firmware images available for an account, based on the devices registered to that account.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.FirmwareV1.ListAvailableFirmware(new ListAvailableFirmwareRequest
    {
        Account = "0242078689-00001",
    });
    // TODO: Handle 'response' of type IReadOnlyList<Firmware>
}
catch (ApiException<ListAvailableFirmwareError> ex)
{
    if (ex.Error.TryGetFotaV1Result(out var error))
    {
        // TODO: Handle 'error' of type FotaV1Result
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ListAvailableFirmwareRequest](src/Verizon/Requests/FirmwareV1/ListAvailableFirmwareRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[Firmware](src/Verizon/Models/Firmware.cs)&gt;</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[ListAvailableFirmwareError](src/Verizon/Errors/ListAvailableFirmwareError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;FirmwareUpgrade&gt; ListFirmwareUpgradeDetails(ListFirmwareUpgradeDetailsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns information about a specified upgrade, include the target date of the upgrade, the list of devices in the upgrade, and the status of the upgrade for each device.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.FirmwareV1.ListFirmwareUpgradeDetails(new ListFirmwareUpgradeDetailsRequest
    {
        AccountName = "0242078689-00001",
        UpgradeId = "e3a8d88a-04c6-4ef3-b039-89b62f91e962",
    });
    // TODO: Handle 'response' of type FirmwareUpgrade
}
catch (ApiException<ListFirmwareUpgradeDetailsError> ex)
{
    if (ex.Error.TryGetFotaV1Result(out var error))
    {
        // TODO: Handle 'error' of type FotaV1Result
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ListFirmwareUpgradeDetailsRequest](src/Verizon/Requests/FirmwareV1/ListFirmwareUpgradeDetailsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[FirmwareUpgrade](src/Verizon/Models/FirmwareUpgrade.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[ListFirmwareUpgradeDetailsError](src/Verizon/Errors/ListFirmwareUpgradeDetailsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;FirmwareUpgrade&gt; ScheduleFirmwareUpgrade(ScheduleFirmwareUpgradeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Schedules a firmware upgrade for devices.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.FirmwareV1.ScheduleFirmwareUpgrade(new ScheduleFirmwareUpgradeRequest
    {
        Body = new FirmwareUpgradeRequest
        {
            AccountName = "0402196254-00001",
            FirmwareName = "FOTA_Verizon_Model-A_01To02_HF",
            FirmwareTo = "VerizonFirmwareVersion-02",
            StartDate = DateTimeOffset.Parse("2018-04-01T00:00:00Z"),
            EndDate = DateTimeOffset.Parse("2018-04-05T00:00:00Z"),
            DeviceList = ["990003425730535", "990000473475989"],
        },
    });
    // TODO: Handle 'response' of type FirmwareUpgrade
}
catch (ApiException<ScheduleFirmwareUpgradeError> ex)
{
    if (ex.Error.TryGetFotaV1Result(out var error))
    {
        // TODO: Handle 'error' of type FotaV1Result
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ScheduleFirmwareUpgradeRequest](src/Verizon/Requests/FirmwareV1/ScheduleFirmwareUpgradeRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[FirmwareUpgrade](src/Verizon/Models/FirmwareUpgrade.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[ScheduleFirmwareUpgradeError](src/Verizon/Errors/ScheduleFirmwareUpgradeError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;FirmwareUpgradeChangeResult&gt; UpdateFirmwareUpgradeDevices(UpdateFirmwareUpgradeDevicesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Add or remove devices from a scheduled upgrade.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.FirmwareV1.UpdateFirmwareUpgradeDevices(new UpdateFirmwareUpgradeDevicesRequest
    {
        AccountName = "0242078689-00001",
        UpgradeId = "e3a8d88a-04c6-4ef3-b039-89b62f91e962",
    });
    // TODO: Handle 'response' of type FirmwareUpgradeChangeResult
}
catch (ApiException<UpdateFirmwareUpgradeDevicesError> ex)
{
    if (ex.Error.TryGetFotaV1Result(out var error))
    {
        // TODO: Handle 'error' of type FotaV1Result
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UpdateFirmwareUpgradeDevicesRequest](src/Verizon/Requests/FirmwareV1/UpdateFirmwareUpgradeDevicesRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[FirmwareUpgradeChangeResult](src/Verizon/Models/FirmwareUpgradeChangeResult.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[UpdateFirmwareUpgradeDevicesError](src/Verizon/Errors/UpdateFirmwareUpgradeDevicesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## FirmwareV3

> Source: [FirmwareV3](src/Verizon/Api/FirmwareV3.cs)

<details>
<summary><code>Task&lt;IReadOnlyList&lt;FirmwarePackage&gt;&gt; ListAvailableFirmware2(ListAvailableFirmware2Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This endpoint allows user to list the firmware of an account.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.FirmwareV3.ListAvailableFirmware2(new ListAvailableFirmware2Request
    {
        Acc = "0000123456-00001",
        Protocol = FirmwareProtocol.Lwm2M,
    });
    // TODO: Handle 'response' of type IReadOnlyList<FirmwarePackage>
}
catch (ApiException<ListAvailableFirmware2Error> ex)
{
    if (ex.Error.TryGetFotaV3Result(out var error))
    {
        // TODO: Handle 'error' of type FotaV3Result
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ListAvailableFirmware2Request](src/Verizon/Requests/FirmwareV3/ListAvailableFirmware2Request.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[FirmwarePackage](src/Verizon/Models/FirmwarePackage.cs)&gt;</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[ListAvailableFirmware2Error](src/Verizon/Errors/ListAvailableFirmware2Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeviceFirmwareVersionUpdateResult&gt; ReportDeviceFirmware(ReportDeviceFirmwareRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Ask a device to report its firmware version asynchronously.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.FirmwareV3.ReportDeviceFirmware(new ReportDeviceFirmwareRequest
    {
        Acc = "0000123456-00001",
        DeviceId = "15-digit IMEI",
    });
    // TODO: Handle 'response' of type DeviceFirmwareVersionUpdateResult
}
catch (ApiException<ReportDeviceFirmwareError> ex)
{
    if (ex.Error.TryGetFotaV3Result(out var error))
    {
        // TODO: Handle 'error' of type FotaV3Result
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ReportDeviceFirmwareRequest](src/Verizon/Requests/FirmwareV3/ReportDeviceFirmwareRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeviceFirmwareVersionUpdateResult](src/Verizon/Models/DeviceFirmwareVersionUpdateResult.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[ReportDeviceFirmwareError](src/Verizon/Errors/ReportDeviceFirmwareError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeviceFirmwareList&gt; SynchronizeDeviceFirmware(SynchronizeDeviceFirmwareRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Synchronize ThingSpace with the FOTA server for up to 100 devices.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.FirmwareV3.SynchronizeDeviceFirmware(new SynchronizeDeviceFirmwareRequest
    {
        Acc = "0000123456-00001",
        Body = new FirmwareImei { DeviceList = ["15-digit IMEI"] },
    });
    // TODO: Handle 'response' of type DeviceFirmwareList
}
catch (ApiException<SynchronizeDeviceFirmwareError> ex)
{
    if (ex.Error.TryGetFotaV3Result(out var error))
    {
        // TODO: Handle 'error' of type FotaV3Result
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SynchronizeDeviceFirmwareRequest](src/Verizon/Requests/FirmwareV3/SynchronizeDeviceFirmwareRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeviceFirmwareList](src/Verizon/Models/DeviceFirmwareList.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[SynchronizeDeviceFirmwareError](src/Verizon/Errors/SynchronizeDeviceFirmwareError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## GlobalReporting

> Source: [GlobalReporting](src/Verizon/Api/GlobalReporting.cs)

<details>
<summary><code>Task&lt;ESimRequestResponse&gt; RetrieveGlobalList(RetrieveGlobalListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieve a list of all devices associated with an account.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.GlobalReporting.RetrieveGlobalList(new RetrieveGlobalListRequest
    {
        Body = new ESimGlobalDeviceList(),
    });
    // TODO: Handle 'response' of type ESimRequestResponse
}
catch (ApiException<RetrieveGlobalListError> ex)
{
    if (ex.Error.TryGetESimRestErrorResponse(out var error))
    {
        // TODO: Handle 'error' of type ESimRestErrorResponse
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[RetrieveGlobalListRequest](src/Verizon/Requests/GlobalReporting/RetrieveGlobalListRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ESimRequestResponse](src/Verizon/Models/ESimRequestResponse.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[RetrieveGlobalListError](src/Verizon/Errors/RetrieveGlobalListError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ESimRequestResponse&gt; DeviceprovhistoryUsingPost(DeviceprovhistoryUsingPostRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieve the provisioning history of a specific device or devices.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.GlobalReporting.DeviceprovhistoryUsingPost(new DeviceprovhistoryUsingPostRequest
    {
        Body = new ESimProvhistoryRequest(),
    });
    // TODO: Handle 'response' of type ESimRequestResponse
}
catch (ApiException<DeviceprovhistoryUsingPostError> ex)
{
    if (ex.Error.TryGetESimRestErrorResponse(out var error))
    {
        // TODO: Handle 'error' of type ESimRestErrorResponse
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeviceprovhistoryUsingPostRequest](src/Verizon/Requests/GlobalReporting/DeviceprovhistoryUsingPostRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ESimRequestResponse](src/Verizon/Models/ESimRequestResponse.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[DeviceprovhistoryUsingPostError](src/Verizon/Errors/DeviceprovhistoryUsingPostError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## HplDeviceManagement

> Source: [HplDeviceManagement](src/Verizon/Api/HplDeviceManagement.cs)

<details>
<summary><code>Task&lt;IReadOnlyList&lt;HplAddDevicesRequest&gt;&gt; AddDevicesHyperPrecise(AddDevicesHyperPreciseRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Use this API if you want to manage some device settings before you are ready to activate service for the devices.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.HplDeviceManagement.AddDevicesHyperPrecise(new AddDevicesHyperPreciseRequest
    {
        Body = new HplAddDevicesRequest
        {
            State = "preactive",
            DevicesToAdd = [
                new HplAccountDeviceList
                {
                    DeviceIds = [
                        new HplDeviceId { Kind = "imei", Id = "15-digit IMEI" },
                        new HplDeviceId { Kind = "iccid", Id = "20-digit ICCID" },
                    ],
                },
                new HplAccountDeviceList
                {
                    DeviceIds = [
                        new HplDeviceId { Kind = "imei", Id = "15-digit IMEI" },
                        new HplDeviceId { Kind = "iccid", Id = "20-digit ICCID" },
                    ],
                },
            ],
            AccountName = "0000123456-00001",
            CustomFields = [new HplCustomFields { Key = "CustomField2", Value = "SuperVend" }],
            GroupName = "West Region",
        },
    });
    // TODO: Handle 'response' of type IReadOnlyList<HplAddDevicesRequest>
}
catch (ApiException<AddDevicesHyperPreciseError> ex)
{
    if (ex.Error.TryGetHyperPreciseLocationResult(out var error))
    {
        // TODO: Handle 'error' of type HyperPreciseLocationResult
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AddDevicesHyperPreciseRequest](src/Verizon/Requests/HplDeviceManagement/AddDevicesHyperPreciseRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[HplAddDevicesRequest](src/Verizon/Models/HplAddDevicesRequest.cs)&gt;</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[AddDevicesHyperPreciseError](src/Verizon/Errors/AddDevicesHyperPreciseError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## HyperPreciseLocationCallbacks

> Source: [HyperPreciseLocationCallbacks](src/Verizon/Api/HyperPreciseLocationCallbacks.cs)

<details>
<summary><code>Task DeregisterCallback6(DeregisterCallback6Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Stops ThingSpace from sending callback messages for the specified account and listener name.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.HyperPreciseLocationCallbacks.DeregisterCallback6(new DeregisterCallback6Request
    {
        AccountNumber = "0000123456-00001",
        Service = "BullseyeReporting",
    });
}
catch (ApiException<DeregisterCallback6Error> ex)
{
    if (ex.Error.TryGetHyperPreciseLocationResult(out var error))
    {
        // TODO: Handle 'error' of type HyperPreciseLocationResult
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeregisterCallback6Request](src/Verizon/Requests/HyperPreciseLocationCallbacks/DeregisterCallback6Request.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[DeregisterCallback6Error](src/Verizon/Errors/DeregisterCallback6Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;CallbackCreated&gt;&gt; ListRegisteredCallbacks6(ListRegisteredCallbacks6Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Find registered callback listener for account by account number.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.HyperPreciseLocationCallbacks.ListRegisteredCallbacks6(
        new ListRegisteredCallbacks6Request { AccountNumber = "0000123456-00001" });
    // TODO: Handle 'response' of type IReadOnlyList<CallbackCreated>
}
catch (ApiException<ListRegisteredCallbacks6Error> ex)
{
    if (ex.Error.TryGetHyperPreciseLocationResult(out var error))
    {
        // TODO: Handle 'error' of type HyperPreciseLocationResult
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ListRegisteredCallbacks6Request](src/Verizon/Requests/HyperPreciseLocationCallbacks/ListRegisteredCallbacks6Request.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[CallbackCreated](src/Verizon/Models/CallbackCreated.cs)&gt;</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[ListRegisteredCallbacks6Error](src/Verizon/Errors/ListRegisteredCallbacks6Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CallbackRegistered&gt; RegisterCallback6(RegisterCallback6Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Registers a URL at which an account receives asynchronous responses and other messages from a ThingSpace Platform callback service. The messages are REST messages. You are responsible for creating and running a listening process on your server at that URL to receive and parse the messages.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.HyperPreciseLocationCallbacks.RegisterCallback6(new RegisterCallback6Request
    {
        AccountNumber = "0000123456-00001",
        Body = new HyperPreciseLocationCallback
        {
            Name = "BullseyeReporting",
            Url = "https://tsustgtests.mocklab.io/notifications/bullseye",
        },
    });
    // TODO: Handle 'response' of type CallbackRegistered
}
catch (ApiException<RegisterCallback6Error> ex)
{
    if (ex.Error.TryGetHyperPreciseLocationResult(out var error))
    {
        // TODO: Handle 'error' of type HyperPreciseLocationResult
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[RegisterCallback6Request](src/Verizon/Requests/HyperPreciseLocationCallbacks/RegisterCallback6Request.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CallbackRegistered](src/Verizon/Models/CallbackRegistered.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[RegisterCallback6Error](src/Verizon/Errors/RegisterCallback6Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## IntelligenceServiceController

> Source: [IntelligenceServiceController](src/Verizon/Api/IntelligenceServiceController.cs)

<details>
<summary><code>Task&lt;AsynchronousRequestResultforplanner&gt; SetConnectionPlanner(SetConnectionPlannerRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves available device windows for Connection Planner.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.IntelligenceServiceController.SetConnectionPlanner(new SetConnectionPlannerRequest
    {
        Body = new GetDevicesWindowsRequestforplanner
        {
            AccountNumber = "0000123456-00001",
            Filter = "All or Best or Worst",
            Devices = [
                new DeviceListforplanner
                {
                    DeviceIds = [new DeviceIdforplanner { Kind = "imei", Id = "15-digit IMEI value" }],
                },
            ],
        },
    });
    // TODO: Handle 'response' of type AsynchronousRequestResultforplanner
}
catch (ApiException<SetConnectionPlannerError> ex)
{
    if (ex.Error.TryGetRestErrorResponseforplanner(out var error))
    {
        // TODO: Handle 'error' of type RestErrorResponseforplanner
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SetConnectionPlannerRequest](src/Verizon/Requests/IntelligenceServiceController/SetConnectionPlannerRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AsynchronousRequestResultforplanner](src/Verizon/Models/AsynchronousRequestResultforplanner.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[SetConnectionPlannerError](src/Verizon/Errors/SetConnectionPlannerError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GetDeviceStatusesResponseforplanner&gt; StatusConnectionPlanner(StatusConnectionPlannerRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves the device status for the Connection Planner service.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.IntelligenceServiceController.StatusConnectionPlanner(
        new StatusConnectionPlannerRequest());
    // TODO: Handle 'response' of type GetDeviceStatusesResponseforplanner
}
catch (ApiException<StatusConnectionPlannerError> ex)
{
    if (ex.Error.TryGetRestErrorResponseforplanner(out var error))
    {
        // TODO: Handle 'error' of type RestErrorResponseforplanner
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[StatusConnectionPlannerRequest](src/Verizon/Requests/IntelligenceServiceController/StatusConnectionPlannerRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GetDeviceStatusesResponseforplanner](src/Verizon/Models/GetDeviceStatusesResponseforplanner.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[StatusConnectionPlannerError](src/Verizon/Errors/StatusConnectionPlannerError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## ManagingESimProfiles

> Source: [ManagingESimProfiles](src/Verizon/Api/ManagingESimProfiles.cs)

<details>
<summary><code>Task&lt;GioRequestResponse&gt; ActivateADeviceProfile(ActivateADeviceProfileRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Activate a device with either a lead or local profile.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ManagingESimProfiles.ActivateADeviceProfile(new ActivateADeviceProfileRequest
    {
        Body = new GioProfileRequest { Devices = [new GioDeviceList()], AccountName = "some example string" },
    });
    // TODO: Handle 'response' of type GioRequestResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ActivateADeviceProfileRequest](src/Verizon/Requests/ManagingESimProfiles/ActivateADeviceProfileRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GioRequestResponse](src/Verizon/Models/GioRequestResponse.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Verizon/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GioRequestResponse&gt; DeactivateADeviceProfile(DeactivateADeviceProfileRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Deactivate the lead or local profile. **Note:** to reactivate the profile, use the **Activate** endpoint above.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ManagingESimProfiles.DeactivateADeviceProfile(new DeactivateADeviceProfileRequest
    {
        Body = new GioDeactivateDeviceProfileRequest(),
    });
    // TODO: Handle 'response' of type GioRequestResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeactivateADeviceProfileRequest](src/Verizon/Requests/ManagingESimProfiles/DeactivateADeviceProfileRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GioRequestResponse](src/Verizon/Models/GioRequestResponse.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Verizon/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GioRequestResponse&gt; DeleteADeviceProfile(DeleteADeviceProfileRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Delete a device profile for Global IoT Orchestration. **Note:** the profile must be deactivated first!

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ManagingESimProfiles.DeleteADeviceProfile(new DeleteADeviceProfileRequest
    {
        Body = new DeviceProfileRequest(),
    });
    // TODO: Handle 'response' of type GioRequestResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeleteADeviceProfileRequest](src/Verizon/Requests/ManagingESimProfiles/DeleteADeviceProfileRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GioRequestResponse](src/Verizon/Models/GioRequestResponse.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Verizon/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GioRequestResponse&gt; DeviceSuspend(DeviceSuspendRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Suspend all service to an eUICC device, including the lead and local profile.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ManagingESimProfiles.DeviceSuspend(new DeviceSuspendRequest
    {
        Body = new GioProfileRequest { Devices = [new GioDeviceList()], AccountName = "some example string" },
    });
    // TODO: Handle 'response' of type GioRequestResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeviceSuspendRequest](src/Verizon/Requests/ManagingESimProfiles/DeviceSuspendRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GioRequestResponse](src/Verizon/Models/GioRequestResponse.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Verizon/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GioRequestResponse&gt; DownloadADeviceProfile(DownloadADeviceProfileRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Download a Global IoT Orchestration device profile.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ManagingESimProfiles.DownloadADeviceProfile(new DownloadADeviceProfileRequest
    {
        Body = new DeviceProfileRequest(),
    });
    // TODO: Handle 'response' of type GioRequestResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DownloadADeviceProfileRequest](src/Verizon/Requests/ManagingESimProfiles/DownloadADeviceProfileRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GioRequestResponse](src/Verizon/Models/GioRequestResponse.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Verizon/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GioRequestResponse&gt; EnableADeviceProfile(EnableADeviceProfileRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Enable a device lead or local profile.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ManagingESimProfiles.EnableADeviceProfile(new EnableADeviceProfileRequest
    {
        Body = new DeviceProfileRequest(),
    });
    // TODO: Handle 'response' of type GioRequestResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[EnableADeviceProfileRequest](src/Verizon/Requests/ManagingESimProfiles/EnableADeviceProfileRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GioRequestResponse](src/Verizon/Models/GioRequestResponse.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Verizon/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GioRequestResponse&gt; EnableADeviceProfileForDownload(EnableADeviceProfileForDownloadRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Enable the Global IoT Orchestration device profile for download.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ManagingESimProfiles.EnableADeviceProfileForDownload(
        new EnableADeviceProfileForDownloadRequest { Body = new DeviceProfileRequest() });
    // TODO: Handle 'response' of type GioRequestResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[EnableADeviceProfileForDownloadRequest](src/Verizon/Requests/ManagingESimProfiles/EnableADeviceProfileForDownloadRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GioRequestResponse](src/Verizon/Models/GioRequestResponse.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Verizon/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GioRequestResponse&gt; ProfileSuspend(ProfileSuspendRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Suspend a device's Global profile.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ManagingESimProfiles.ProfileSuspend(new ProfileSuspendRequest
    {
        Body = new GioProfileRequest
        {
            Devices = [
                new GioDeviceList
                {
                    DeviceIds = [new GioDeviceId { Kind = "eid", Id = "12345678901234567890123456789012" }],
                },
            ],
            AccountName = "0000123456-00001",
            SmrsOid = "1.3.6.1.4.1.#####.1.500.200.101.5",
            MdnZipCode = "12345",
            ServicePlan = "service plan name",
        },
    });
    // TODO: Handle 'response' of type GioRequestResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ProfileSuspendRequest](src/Verizon/Requests/ManagingESimProfiles/ProfileSuspendRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GioRequestResponse](src/Verizon/Models/GioRequestResponse.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Verizon/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GioRequestResponse&gt; ResumeProfile(ResumeProfileRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Resume service to a device with either a lead or local profile.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ManagingESimProfiles.ResumeProfile(new ResumeProfileRequest
    {
        Body = new GioProfileRequest
        {
            Devices = [
                new GioDeviceList
                {
                    DeviceIds = [new GioDeviceId { Kind = "eid", Id = "12345678901234567890123456789012" }],
                },
            ],
            AccountName = "0000123456-00001",
            SmrsOid = "1.3.6.1.4.1.#####.1.500.200.101.5",
            MdnZipCode = "12345",
            ServicePlan = "service plan name",
        },
    });
    // TODO: Handle 'response' of type GioRequestResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ResumeProfileRequest](src/Verizon/Requests/ManagingESimProfiles/ResumeProfileRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GioRequestResponse](src/Verizon/Models/GioRequestResponse.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Verizon/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GioRequestResponse&gt; SetFallback(SetFallbackRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Enable a fallback profile to be set.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ManagingESimProfiles.SetFallback(new SetFallbackRequest { Body = new FallBack() });
    // TODO: Handle 'response' of type GioRequestResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SetFallbackRequest](src/Verizon/Requests/ManagingESimProfiles/SetFallbackRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GioRequestResponse](src/Verizon/Models/GioRequestResponse.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Verizon/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Pwn

> Source: [Pwn](src/Verizon/Api/Pwn.cs)

<details>
<summary><code>Task&lt;ChangePwnDeviceIpAddressResponse&gt; ChangePwnDeviceIPaddress(ChangePwnDeviceIPaddressOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Pwn.ChangePwnDeviceIPaddress(new ChangePwnDeviceIPaddressOperationRequest
    {
        Body = new ChangePwnDeviceIPaddressRequest
        {
            AccountName = "some example string",
            DeviceList = [
                new DeviceListIp
                {
                    DeviceIds = [new PwnDeviceId { Id = "some example string", Kind = "some example string" }],
                    IpAddress = "some example string",
                },
            ],
        },
    });
    // TODO: Handle 'response' of type ChangePwnDeviceIpAddressResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ChangePwnDeviceIPaddressOperationRequest](src/Verizon/Requests/Pwn/ChangePwnDeviceIPaddressOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ChangePwnDeviceIpAddressResponse](src/Verizon/Models/ChangePwnDeviceIpAddressResponse.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Verizon/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ChangePwnDeviceProfileResponse&gt; ChangePwnDeviceProfile(ChangePwnDeviceProfileOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Pwn.ChangePwnDeviceProfile(new ChangePwnDeviceProfileOperationRequest
    {
        Body = new ChangePwnDeviceProfileRequest
        {
            AccountName = "0342351414-00001",
            DeviceList = [
                new PwnDeviceList { DeviceIds = [new PwnDeviceId { Id = "99948099913024600000", Kind = "iccid" }] },
            ],
            NewProfile = "HSS EsmProfile Enterprise 5G internet",
        },
    });
    // TODO: Handle 'response' of type ChangePwnDeviceProfileResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ChangePwnDeviceProfileOperationRequest](src/Verizon/Requests/Pwn/ChangePwnDeviceProfileOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ChangePwnDeviceProfileResponse](src/Verizon/Models/ChangePwnDeviceProfileResponse.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Verizon/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ChangePwnDeviceStateResponse&gt; ChangePwnDeviceStateActivate(ChangePwnDeviceStateActivateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Pwn.ChangePwnDeviceStateActivate(new ChangePwnDeviceStateActivateOperationRequest
    {
        Body = new ChangePwnDeviceStateActivateRequest
        {
            AccountName = "0342351414-00001",
            DeviceList = [
                new PwnDeviceList { DeviceIds = [new PwnDeviceId { Id = "99948099913024600001", Kind = "iccid" }] },
            ],
            Activate = new Activate { Profile = "HSS EsmProfile Enterprise 5G" },
        },
    });
    // TODO: Handle 'response' of type ChangePwnDeviceStateResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ChangePwnDeviceStateActivateOperationRequest](src/Verizon/Requests/Pwn/ChangePwnDeviceStateActivateOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ChangePwnDeviceStateResponse](src/Verizon/Models/ChangePwnDeviceStateResponse.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Verizon/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ChangePwnDeviceStateResponse&gt; ChangePwnDeviceStateDeactivate(ChangePwnDeviceStateDeactivateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Pwn.ChangePwnDeviceStateDeactivate(new ChangePwnDeviceStateDeactivateOperationRequest
    {
        Body = new ChangePwnDeviceStateDeactivateRequest
        {
            AccountName = "0342351414-00001",
            DeviceList = [
                new PwnDeviceList { DeviceIds = [new PwnDeviceId { Id = "99948099913031600000", Kind = "iccid" }] },
                new PwnDeviceList { DeviceIds = [new PwnDeviceId { Id = "99948099913031700000", Kind = "iccid" }] },
            ],
        },
    });
    // TODO: Handle 'response' of type ChangePwnDeviceStateResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ChangePwnDeviceStateDeactivateOperationRequest](src/Verizon/Requests/Pwn/ChangePwnDeviceStateDeactivateOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ChangePwnDeviceStateResponse](src/Verizon/Models/ChangePwnDeviceStateResponse.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Verizon/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GetPwnPerformanceConsentResponse&gt; GetPwnPerformanceConsent(GetPwnPerformanceConsentRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Pwn.GetPwnPerformanceConsent(new GetPwnPerformanceConsentRequest
    {
        Aname = "1533445500-00088",
    });
    // TODO: Handle 'response' of type GetPwnPerformanceConsentResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetPwnPerformanceConsentRequest](src/Verizon/Requests/Pwn/GetPwnPerformanceConsentRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GetPwnPerformanceConsentResponse](src/Verizon/Models/GetPwnPerformanceConsentResponse.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Verizon/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PwnProfileList&gt; GetProfileList(GetProfileListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Pwn.GetProfileList(new GetProfileListRequest { Aname = "0342351414-00001" });
    // TODO: Handle 'response' of type PwnProfileList
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetProfileListRequest](src/Verizon/Requests/Pwn/GetProfileListRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PwnProfileList](src/Verizon/Models/PwnProfileList.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Verizon/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;KpiInfoList&gt; KpiList(KpiListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Pwn.KpiList(new KpiListRequest { Aname = "0342351414-00001" });
    // TODO: Handle 'response' of type KpiInfoList
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[KpiListRequest](src/Verizon/Requests/Pwn/KpiListRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[KpiInfoList](src/Verizon/Models/KpiInfoList.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Verizon/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## PromotionPeriodInformation

> Source: [PromotionPeriodInformation](src/Verizon/Api/PromotionPeriodInformation.cs)

<details>
<summary><code>Task&lt;UsageRequestResponse&gt; GetPromoDeviceAggregateUsageHistory(GetPromoDeviceAggregateUsageHistoryRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves the aggregate usage for an account using pseudo-MDN during the promotional period using a callback.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PromotionPeriodInformation.GetPromoDeviceAggregateUsageHistory(
        new GetPromoDeviceAggregateUsageHistoryRequest { Body = new RequestBodyForUsage() });
    // TODO: Handle 'response' of type UsageRequestResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetPromoDeviceAggregateUsageHistoryRequest](src/Verizon/Requests/PromotionPeriodInformation/GetPromoDeviceAggregateUsageHistoryRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UsageRequestResponse](src/Verizon/Models/UsageRequestResponse.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Verizon/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ResponseToUsageQuery&gt; GetPromoDeviceUsageHistory(GetPromoDeviceUsageHistoryRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves the usage history of a device during the promotion period.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PromotionPeriodInformation.GetPromoDeviceUsageHistory(
        new GetPromoDeviceUsageHistoryRequest { Body = new ARequestBodyForUsage() });
    // TODO: Handle 'response' of type ResponseToUsageQuery
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetPromoDeviceUsageHistoryRequest](src/Verizon/Requests/PromotionPeriodInformation/GetPromoDeviceUsageHistoryRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ResponseToUsageQuery](src/Verizon/Models/ResponseToUsageQuery.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Verizon/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## RetrieveRatePlanList

> Source: [RetrieveRatePlanList](src/Verizon/Api/RetrieveRatePlanList.cs)

<details>
<summary><code>Task&lt;Rateplan&gt; GetRatePlanList(GetRatePlanListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves the rate plans and rate plan details for a profile ID.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.RetrieveRatePlanList.GetRatePlanList(new GetRatePlanListRequest
    {
        EcpdId = "0000123456-00001",
    });
    // TODO: Handle 'response' of type Rateplan
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetRatePlanListRequest](src/Verizon/Requests/RetrieveRatePlanList/GetRatePlanListRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Rateplan](src/Verizon/Models/Rateplan.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Verizon/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## RetrieveTheTriggers

> Source: [RetrieveTheTriggers](src/Verizon/Api/RetrieveTheTriggers.cs)

<details>
<summary><code>Task&lt;TriggerValueResponse&gt; GetAllAvailableTriggers(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves all of the available triggers for pseudo-MDN.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.RetrieveTheTriggers.GetAllAvailableTriggers();
    // TODO: Handle 'response' of type TriggerValueResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TriggerValueResponse](src/Verizon/Models/TriggerValueResponse.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Verizon/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TriggerValueResponse&gt; GetAllTriggersByAccountName(GetAllTriggersByAccountNameRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieve the triggers associated with an account name.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.RetrieveTheTriggers.GetAllTriggersByAccountName(new GetAllTriggersByAccountNameRequest
    {
        AccountName = "0000123456-000001",
    });
    // TODO: Handle 'response' of type TriggerValueResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetAllTriggersByAccountNameRequest](src/Verizon/Requests/RetrieveTheTriggers/GetAllTriggersByAccountNameRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TriggerValueResponse](src/Verizon/Models/TriggerValueResponse.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Verizon/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TriggerValueResponse2&gt; GetAllTriggersByTriggerCategory(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves all of the triggers for the specified account associated with the PromoAlert category

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.RetrieveTheTriggers.GetAllTriggersByTriggerCategory();
    // TODO: Handle 'response' of type TriggerValueResponse2
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TriggerValueResponse2](src/Verizon/Models/TriggerValueResponse2.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Verizon/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TriggerValueResponse2&gt; GetTriggersById(GetTriggersByIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrives a specific trigger by its ID.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.RetrieveTheTriggers.GetTriggersById(new GetTriggersByIdRequest
    {
        TriggerId = "2874DEC7-26CF-4797-9C6A-B5A2AC72D526",
    });
    // TODO: Handle 'response' of type TriggerValueResponse2
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetTriggersByIdRequest](src/Verizon/Requests/RetrieveTheTriggers/GetTriggersByIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TriggerValueResponse2](src/Verizon/Models/TriggerValueResponse2.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Verizon/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## SimActions

> Source: [SimActions](src/Verizon/Api/SimActions.cs)

<details>
<summary><code>Task&lt;ESimRequestResponse&gt; Newactivatecode(NewactivatecodeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

System assign a new activation code to reactivate a deactivated device. **Note:** the previously assigned ICCID must be used to request a new activation code.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SimActions.Newactivatecode(new NewactivatecodeRequest
    {
        Body = new ESimProfileRequest2
        {
            Devices = [
                new ESimDeviceList
                {
                    DeviceIds = [
                        new ESimDeviceId { Id = "15-digit IMEI", Kind = "imei" },
                        new ESimDeviceId { Id = "20-digit ICCID", Kind = "iccid" },
                    ],
                },
            ],
            AccountName = "0000123456-00001",
            ServicePlan = "the service plan name",
            MdnZipCode = "five digit zip code",
        },
    });
    // TODO: Handle 'response' of type ESimRequestResponse
}
catch (ApiException<NewactivatecodeError> ex)
{
    if (ex.Error.TryGetESimRestErrorResponse(out var error))
    {
        // TODO: Handle 'error' of type ESimRestErrorResponse
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[NewactivatecodeRequest](src/Verizon/Requests/SimActions/NewactivatecodeRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ESimRequestResponse](src/Verizon/Models/ESimRequestResponse.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[NewactivatecodeError](src/Verizon/Errors/NewactivatecodeError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ESimRequestResponse&gt; SetactivateUsingPost(SetactivateUsingPostRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Uses the profile to activate the SIM.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SimActions.SetactivateUsingPost(new SetactivateUsingPostRequest
    {
        Body = new ESimProfileRequest
        {
            Devices = [
                new ESimDeviceList
                {
                    DeviceIds = [
                        new ESimDeviceId { Id = "32-digit EID", Kind = "eid" },
                        new ESimDeviceId { Id = "15-digit IMEI", Kind = "imei" },
                        new ESimDeviceId
                        {
                            Id = "20-digit ICCID",
                            Kind = "iccid (ICCID is only used for reactivation)",
                        },
                    ],
                },
            ],
            CarrierName = "Verizon Wireless",
            AccountName = "0000123456-00001",
            ServicePlan = "the service plan name",
            MdnZipCode = "five digit zip code",
        },
    });
    // TODO: Handle 'response' of type ESimRequestResponse
}
catch (ApiException<SetactivateUsingPostError> ex)
{
    if (ex.Error.TryGetESimRestErrorResponse(out var error))
    {
        // TODO: Handle 'error' of type ESimRestErrorResponse
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SetactivateUsingPostRequest](src/Verizon/Requests/SimActions/SetactivateUsingPostRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ESimRequestResponse](src/Verizon/Models/ESimRequestResponse.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[SetactivateUsingPostError](src/Verizon/Errors/SetactivateUsingPostError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ESimRequestResponse&gt; SetdeactivateUsingPost(SetdeactivateUsingPostRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Uses the profile to deactivate the SIM.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SimActions.SetdeactivateUsingPost(new SetdeactivateUsingPostRequest
    {
        Body = new ProfileRequest2(),
    });
    // TODO: Handle 'response' of type ESimRequestResponse
}
catch (ApiException<SetdeactivateUsingPostError> ex)
{
    if (ex.Error.TryGetESimRestErrorResponse(out var error))
    {
        // TODO: Handle 'error' of type ESimRestErrorResponse
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SetdeactivateUsingPostRequest](src/Verizon/Requests/SimActions/SetdeactivateUsingPostRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ESimRequestResponse](src/Verizon/Models/ESimRequestResponse.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[SetdeactivateUsingPostError](src/Verizon/Errors/SetdeactivateUsingPostError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## SimSecureForIoTLicenses

> Source: [SimSecureForIoTLicenses](src/Verizon/Api/SimSecureForIoTLicenses.cs)

<details>
<summary><code>Task&lt;SecuritySuccessResult&gt; AssignLicenseToDevices(AssignLicenseToDevicesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Assigns SIM-Secure for IoT licenses to SIMs.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SimSecureForIoTLicenses.AssignLicenseToDevices(new AssignLicenseToDevicesRequest
    {
        Body = new AssignLicenseRequest
        {
            AccountName = "0000123456-00001",
            Devices = [
                new LicenseDeviceList { DeviceIds = [new LicenseDeviceId { Id = "864508030109877", Kind = "IMEI" }] },
            ],
            SkuNumber = "SIMSec-IoT-Lt",
        },
    });
    // TODO: Handle 'response' of type SecuritySuccessResult
}
catch (ApiException<AssignLicenseToDevicesError> ex)
{
    if (ex.Error.TryGetSecurityResult(out var error))
    {
        // TODO: Handle 'error' of type SecurityResult
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AssignLicenseToDevicesRequest](src/Verizon/Requests/SimSecureForIoTLicenses/AssignLicenseToDevicesRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SecuritySuccessResult](src/Verizon/Models/SecuritySuccessResult.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[AssignLicenseToDevicesError](src/Verizon/Errors/AssignLicenseToDevicesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SecuritySuccessResult&gt; UnassignLicenseToDevices(UnassignLicenseToDevicesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Unassigns SIM-Secure for IoT Flexible and Flexible Bundle license from SIMs.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SimSecureForIoTLicenses.UnassignLicenseToDevices(new UnassignLicenseToDevicesRequest
    {
        XRequestId = "some example string",
    });
    // TODO: Handle 'response' of type SecuritySuccessResult
}
catch (ApiException<UnassignLicenseToDevicesError> ex)
{
    if (ex.Error.TryGetSecurityResult(out var error))
    {
        // TODO: Handle 'error' of type SecurityResult
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UnassignLicenseToDevicesRequest](src/Verizon/Requests/SimSecureForIoTLicenses/UnassignLicenseToDevicesRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SecuritySuccessResult](src/Verizon/Models/SecuritySuccessResult.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[UnassignLicenseToDevicesError](src/Verizon/Errors/UnassignLicenseToDevicesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Sms

> Source: [Sms](src/Verizon/Api/Sms.cs)

<details>
<summary><code>Task&lt;SmsMessagesQueryResult&gt; ListDevicesSmsMessages(ListDevicesSmsMessagesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

When HTTP status is 202, a URL will be returned in the Location header of the form /sms/{aname}/history?next={token}. This URL can be used to request the next set of messages.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Sms.ListDevicesSmsMessages(new ListDevicesSmsMessagesRequest
    {
        Aname = "0252012345-00001",
    });
    // TODO: Handle 'response' of type SmsMessagesQueryResult
}
catch (ApiException<ListDevicesSmsMessagesError> ex)
{
    if (ex.Error.TryGetConnectivityManagementResult(out var error))
    {
        // TODO: Handle 'error' of type ConnectivityManagementResult
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ListDevicesSmsMessagesRequest](src/Verizon/Requests/Sms/ListDevicesSmsMessagesRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SmsMessagesQueryResult](src/Verizon/Models/SmsMessagesQueryResult.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[ListDevicesSmsMessagesError](src/Verizon/Errors/ListDevicesSmsMessagesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeviceManagementResult&gt; SendSmsToDevice(SendSmsToDeviceRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The messages are queued on the ThingSpace Platform and sent as soon as possible, but they may be delayed due to traffic and routing considerations.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Sms.SendSmsToDevice(new SendSmsToDeviceRequest
    {
        Body = new SmsSendRequest
        {
            AccountName = "0000123456-00001",
            SmsMessage = "the body or text of the message itself",
            CustomFields = [new CustomFields { Key = "CustomField1", Value = "value of the field" }],
            DataEncoding = "optional 7 or 8-bit encoding",
            DeviceIds = [new DeviceId { Id = "20-digit ICCID", Kind = "iccid" }],
            TimeToLive = "a000000010000000R",
        },
    });
    // TODO: Handle 'response' of type DeviceManagementResult
}
catch (ApiException<SendSmsToDeviceError> ex)
{
    if (ex.Error.TryGetConnectivityManagementResult(out var error))
    {
        // TODO: Handle 'error' of type ConnectivityManagementResult
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SendSmsToDeviceRequest](src/Verizon/Requests/Sms/SendSmsToDeviceRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeviceManagementResult](src/Verizon/Models/DeviceManagementResult.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[SendSmsToDeviceError](src/Verizon/Errors/SendSmsToDeviceError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ConnectivityManagementSuccessResult&gt; StartQueuedSmsDelivery(StartQueuedSmsDeliveryRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Tells the ThingSpace Platform to start sending mobile-originated SMS messages through the EnhancedConnectivityService callback service. SMS messages from devices are queued until they are retrieved by your application, either by callback or synchronously with GET /sms/{accountName}/history.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Sms.StartQueuedSmsDelivery(new StartQueuedSmsDeliveryRequest
    {
        Aname = "0252012345-00001",
    });
    // TODO: Handle 'response' of type ConnectivityManagementSuccessResult
}
catch (ApiException<StartQueuedSmsDeliveryError> ex)
{
    if (ex.Error.TryGetConnectivityManagementResult(out var error))
    {
        // TODO: Handle 'error' of type ConnectivityManagementResult
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[StartQueuedSmsDeliveryRequest](src/Verizon/Requests/Sms/StartQueuedSmsDeliveryRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ConnectivityManagementSuccessResult](src/Verizon/Models/ConnectivityManagementSuccessResult.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[StartQueuedSmsDeliveryError](src/Verizon/Errors/StartQueuedSmsDeliveryError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## SensorInsightsDeviceProfile

> Source: [SensorInsightsDeviceProfile](src/Verizon/Api/SensorInsightsDeviceProfile.cs)

<details>
<summary><code>Task&lt;IReadOnlyList&lt;DtoProfileResponse&gt;&gt; CreateAProfile(CreateAProfileRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Create a device profile

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SensorInsightsDeviceProfile.CreateAProfile(new CreateAProfileRequest
    {
        Body = new DtoConfigurationProfile
        {
            Accountname = "0000123456-00001",
            Profiles = [
                new DtoProfile
                {
                    Kind = "the kind of profile being created",
                    Version = "1.0",
                    Modelid = "00000000-0000-0000-0000-000000000019",
                    Name = "Demo Entry sensor 1730928792",
                },
            ],
        },
    });
    // TODO: Handle 'response' of type IReadOnlyList<DtoProfileResponse>
}
catch (ApiException<CreateAProfileError> ex)
{
    if (ex.Error.TryGetManagementError400(out var error))
    {
        // TODO: Handle 'error' of type ManagementError400
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CreateAProfileRequest](src/Verizon/Requests/SensorInsightsDeviceProfile/CreateAProfileRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[DtoProfileResponse](src/Verizon/Models/DtoProfileResponse.cs)&gt;</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[CreateAProfileError](src/Verizon/Errors/CreateAProfileError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;DtoProfileResponse&gt;&gt; DeleteAProfile(DeleteAProfileRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Delete a device profile

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SensorInsightsDeviceProfile.DeleteAProfile(new DeleteAProfileRequest
    {
        Deleterequest = new DtoConfigurationProfileDelete(),
    });
    // TODO: Handle 'response' of type IReadOnlyList<DtoProfileResponse>
}
catch (ApiException<DeleteAProfileError> ex)
{
    if (ex.Error.TryGetManagementError400(out var error))
    {
        // TODO: Handle 'error' of type ManagementError400
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeleteAProfileRequest](src/Verizon/Requests/SensorInsightsDeviceProfile/DeleteAProfileRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[DtoProfileResponse](src/Verizon/Models/DtoProfileResponse.cs)&gt;</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[DeleteAProfileError](src/Verizon/Errors/DeleteAProfileError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;DtoProfileResponse&gt;&gt; QueryAProfile(QueryAProfileRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query a device profile for an individual device

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SensorInsightsDeviceProfile.QueryAProfile(new QueryAProfileRequest
    {
        Body = new ResourceResourceQuery
        {
            Filter = new Devicepropertyfilter
            {
                Selection = new Devicepropertyselection { Modelid = "00000000-0000-0000-0000-000000000019" },
                Querytotalcount = true,
            },
        },
    });
    // TODO: Handle 'response' of type IReadOnlyList<DtoProfileResponse>
}
catch (ApiException<QueryAProfileError> ex)
{
    if (ex.Error.TryGetManagementError400(out var error))
    {
        // TODO: Handle 'error' of type ManagementError400
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[QueryAProfileRequest](src/Verizon/Requests/SensorInsightsDeviceProfile/QueryAProfileRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[DtoProfileResponse](src/Verizon/Models/DtoProfileResponse.cs)&gt;</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[QueryAProfileError](src/Verizon/Errors/QueryAProfileError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;DtoProfileResponse&gt;&gt; UpdateAProfile(UpdateAProfileRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Partially update a device profile

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SensorInsightsDeviceProfile.UpdateAProfile(new UpdateAProfileRequest
    {
        Body = new DtoConfigurationProfilePath(),
    });
    // TODO: Handle 'response' of type IReadOnlyList<DtoProfileResponse>
}
catch (ApiException<UpdateAProfileError> ex)
{
    if (ex.Error.TryGetManagementError400(out var error))
    {
        // TODO: Handle 'error' of type ManagementError400
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UpdateAProfileRequest](src/Verizon/Requests/SensorInsightsDeviceProfile/UpdateAProfileRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[DtoProfileResponse](src/Verizon/Models/DtoProfileResponse.cs)&gt;</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[UpdateAProfileError](src/Verizon/Errors/UpdateAProfileError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## SensorInsightsDevices

> Source: [SensorInsightsDevices](src/Verizon/Api/SensorInsightsDevices.cs)

<details>
<summary><code>Task&lt;DtoDeviceActionSetResponse&gt; SensorInsightsDeviceActionSetRequest(SensorInsightsDeviceActionSetRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SensorInsightsDevices.SensorInsightsDeviceActionSetRequest(
        new SensorInsightsDeviceActionSetRequest
        {
            Body = new DtoDeviceActionSetRequest
            {
                Accountname = "0000123456-00001",
                Configuration = new DtoDeviceActionSetConfiguration
                {
                    DeviceConfig = new DtoDeviceConfig { Ble = new SensorInsightsBle() },
                },
                Resourceidentifier = new DtoDeviceResourceIdentifier
                {
                    Deveui = "The unique EUI64 address of the device",
                    Deviceid = "The UUID of the device",
                    Iccid = "The 20-digit Integrated Circuit Card ID (SIM card ID)",
                    Mac = "The Media Access Control address of the device, listed on the device in the format XX-XX-XX-XX-XX-XX or XX:XX:XX:XX:XX:XX",
                    Manufacturer = "REOLINK",
                    Meid = "The 56-bit Mobile Equipment ID",
                    Msisdn = "The Mobile Station International Subscriber Directory Number. In the USA, this is 1+ a 10-digit phone number",
                    NodeUuid = "The UUID of the node the device is associated with",
                    Qrcode = "The Quick Response (QR) code",
                    Serial = "The device's serial number",
                },
            },
        });
    // TODO: Handle 'response' of type DtoDeviceActionSetResponse
}
catch (ApiException<SensorInsightsDeviceActionSetRequestError> ex)
{
    if (ex.Error.TryGetManagementError400(out var error))
    {
        // TODO: Handle 'error' of type ManagementError400
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SensorInsightsDeviceActionSetRequest](src/Verizon/Requests/SensorInsightsDevices/SensorInsightsDeviceActionSetRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DtoDeviceActionSetResponse](src/Verizon/Models/DtoDeviceActionSetResponse.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[SensorInsightsDeviceActionSetRequestError](src/Verizon/Errors/SensorInsightsDeviceActionSetRequestError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DtoLastReportedTimeResponse&gt; SensorInsightsLastReportedTimeRequest(SensorInsightsLastReportedTimeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SensorInsightsDevices.SensorInsightsLastReportedTimeRequest(
        new SensorInsightsLastReportedTimeRequest
        {
            Body = new DtoLastReportedTimeRequest
            {
                Accountname = "0000123456-00001",
                Resourceidentifier = new DtoDeviceResourceIdentifier
                {
                    Deveui = "The unique EUI64 address of the device",
                    Deviceid = "The UUID of the device",
                    Iccid = "The 20-digit Integrated Circuit Card ID (SIM card ID)",
                    Mac = "The Media Access Control address of the device, listed on the device in the format XX-XX-XX-XX-XX-XX or XX:XX:XX:XX:XX:XX",
                    Manufacturer = "REOLINK",
                    Meid = "The 56-bit Mobile Equipment ID",
                    Msisdn = "The Mobile Station International Subscriber Directory Number. In the USA, this is 1+ a 10-digit phone number",
                    NodeUuid = "The UUID of the node the device is associated with",
                    Qrcode = "The Quick Response (QR) code",
                    Serial = "The device's serial number",
                },
            },
        });
    // TODO: Handle 'response' of type DtoLastReportedTimeResponse
}
catch (ApiException<SensorInsightsLastReportedTimeRequestError> ex)
{
    if (ex.Error.TryGetManagementError400(out var error))
    {
        // TODO: Handle 'error' of type ManagementError400
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SensorInsightsLastReportedTimeRequest](src/Verizon/Requests/SensorInsightsDevices/SensorInsightsLastReportedTimeRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DtoLastReportedTimeResponse](src/Verizon/Models/DtoLastReportedTimeResponse.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[SensorInsightsLastReportedTimeRequestError](src/Verizon/Errors/SensorInsightsLastReportedTimeRequestError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;UserDeviceExperienceHistory&gt;&gt; SensorInsightsListDeviceExperienceHistoryRequest(SensorInsightsListDeviceExperienceHistoryRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SensorInsightsDevices.SensorInsightsListDeviceExperienceHistoryRequest(
        new SensorInsightsListDeviceExperienceHistoryRequest
        {
            Body = new DtoListDeviceExperienceHistoryRequest
            {
                Accountname = "0000123456-00001",
                Filter = new DtoFilter
                {
                    Expand = "device detail(s)",
                    Limitnumber = 100,
                    Nopagination = true,
                    Page = "The number of pages",
                    Pagenumber = 100,
                    Projection = ["specific device fields requested"],
                    Selection = new Dictionary<string, object>(),
                },
            },
        });
    // TODO: Handle 'response' of type IReadOnlyList<UserDeviceExperienceHistory>
}
catch (ApiException<SensorInsightsListDeviceExperienceHistoryRequestError> ex)
{
    if (ex.Error.TryGetManagementError400(out var error))
    {
        // TODO: Handle 'error' of type ManagementError400
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SensorInsightsListDeviceExperienceHistoryRequest](src/Verizon/Requests/SensorInsightsDevices/SensorInsightsListDeviceExperienceHistoryRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[UserDeviceExperienceHistory](src/Verizon/Models/UserDeviceExperienceHistory.cs)&gt;</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[SensorInsightsListDeviceExperienceHistoryRequestError](src/Verizon/Errors/SensorInsightsListDeviceExperienceHistoryRequestError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;DtoExpandedDeviceResponse&gt;&gt; SensorInsightsListDevicesRequest(SensorInsightsListDevicesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SensorInsightsDevices.SensorInsightsListDevicesRequest(
        new SensorInsightsListDevicesRequest
        {
            Body = new DtoListDevicesRequest
            {
                Accountname = "0000123456-00001",
                Filter = new DtoFilter
                {
                    Expand = "device detail(s)",
                    Limitnumber = 100,
                    Nopagination = true,
                    Page = "The number of pages",
                    Pagenumber = 100,
                    Projection = ["specific device fields requested"],
                    Selection = new Dictionary<string, object>(),
                },
                Resourceidentifier = new DtoDeviceResourceIdentifier
                {
                    Deveui = "The unique EUI64 address of the device",
                    Deviceid = "The UUID of the device",
                    Iccid = "The 20-digit Integrated Circuit Card ID (SIM card ID)",
                    Mac = "The Media Access Control address of the device, listed on the device in the format XX-XX-XX-XX-XX-XX or XX:XX:XX:XX:XX:XX",
                    Manufacturer = "REOLINK",
                    Meid = "The 56-bit Mobile Equipment ID",
                    Msisdn = "The Mobile Station International Subscriber Directory Number. In the USA, this is 1+ a 10-digit phone number",
                    NodeUuid = "The UUID of the node the device is associated with",
                    Qrcode = "The Quick Response (QR) code",
                    Serial = "The device's serial number",
                },
            },
        });
    // TODO: Handle 'response' of type IReadOnlyList<DtoExpandedDeviceResponse>
}
catch (ApiException<SensorInsightsListDevicesRequestError> ex)
{
    if (ex.Error.TryGetManagementError(out var error))
    {
        // TODO: Handle 'error' of type ManagementError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SensorInsightsListDevicesRequest](src/Verizon/Requests/SensorInsightsDevices/SensorInsightsListDevicesRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[DtoExpandedDeviceResponse](src/Verizon/Models/DtoExpandedDeviceResponse.cs)&gt;</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[SensorInsightsListDevicesRequestError](src/Verizon/Errors/SensorInsightsListDevicesRequestError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;UserNetworkExperienceHistory&gt;&gt; SensorInsightsListNetworkExperienceHistoryRequest(SensorInsightsListNetworkExperienceHistoryRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SensorInsightsDevices.SensorInsightsListNetworkExperienceHistoryRequest(
        new SensorInsightsListNetworkExperienceHistoryRequest
        {
            Body = new DtoListNetworkExperienceHistoryRequest
            {
                Accountname = "0000123456-00001",
                Filter = new DtoFilter
                {
                    Expand = "device detail(s)",
                    Limitnumber = 100,
                    Nopagination = true,
                    Page = "The number of pages",
                    Pagenumber = 100,
                    Projection = ["specific device fields requested"],
                    Selection = new Dictionary<string, object>(),
                },
            },
        });
    // TODO: Handle 'response' of type IReadOnlyList<UserNetworkExperienceHistory>
}
catch (ApiException<SensorInsightsListNetworkExperienceHistoryRequestError> ex)
{
    if (ex.Error.TryGetManagementError400(out var error))
    {
        // TODO: Handle 'error' of type ManagementError400
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SensorInsightsListNetworkExperienceHistoryRequest](src/Verizon/Requests/SensorInsightsDevices/SensorInsightsListNetworkExperienceHistoryRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[UserNetworkExperienceHistory](src/Verizon/Models/UserNetworkExperienceHistory.cs)&gt;</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[SensorInsightsListNetworkExperienceHistoryRequestError](src/Verizon/Errors/SensorInsightsListNetworkExperienceHistoryRequestError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ResourceDevice&gt; SensorInsightsPatchDeviceRequest(SensorInsightsPatchDeviceRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SensorInsightsDevices.SensorInsightsPatchDeviceRequest(
        new SensorInsightsPatchDeviceRequest
        {
            Body = new DtoPatchDeviceRequest
            {
                Accountname = "0000123456-00001",
                Device = new ResourceDevice
                {
                    Accountclientid = "null",
                    Billingaccountid = "0000123456-00001",
                    Chipset = "The chipset used by the device",
                    Createdon = DateTimeOffset.Parse("2023-10-02T15:46:34.562Z"),
                    Customdata = new Dictionary<string, object>(),
                    Description = "The number of days to retaing the event data",
                    Fields = new DtoFields
                    {
                        AdditionalProp1 = "string",
                        AdditionalProp2 = "string",
                        AdditionalProp3 = "string",
                    },
                    Foreignid = "c1f178d3-eeee-ffff-gggg-0d6b7ae6022a",
                    Hardwareversion = "1.0",
                    Iccid = "The 20-digit Integrated Circuit Card ID (SIM card ID)",
                    Id = "33e21f61-a44a-44c9-b7a0-a63f5d19bd4f",
                    Lastupdated = DateTimeOffset.Parse("2023-10-02T15:46:34.562Z"),
                    Licenses = ["licenses assigned to the device"],
                    Mac = "The Media Access Control address of the device, listed on the device in the format XX-XX-XX-XX-XX-XX or XX:XX:XX:XX:XX:XX",
                    Manufacturer = "REOLINK",
                    Meid = "The 56-bit Mobile Equipment ID",
                    Msisdn = "The Mobile Station International Subscriber Directory Number. In the USA, this is 1+ a 10-digit phone number",
                    Name = "User defined name of the record",
                    Parentdeviceid = "BLE device ID",
                    Productmodel = "Model name of the device",
                    Providerid = "Verizon Wireless",
                    Qrcode = "The Quick Response (QR) code",
                    Refid = "P3730-1422323050860",
                    Refidtype = "The type of value represented by `refid`",
                    Serial = "The device's serial number",
                    Services = ["configuration"],
                    Sku = "The Stock Keeping Unit (SKU) number",
                    Softwareversion = "the current device software version",
                    State = "success",
                    Version = "1.0",
                    Versionid = "337bd2e8-eeee-ffff-gggg-5207992fd395",
                    Eventretention = 90,
                },
                Resourceidentifier = new DtoDeviceResourceIdentifier
                {
                    Deveui = "The unique EUI64 address of the device",
                    Deviceid = "The UUID of the device",
                    Iccid = "The 20-digit Integrated Circuit Card ID (SIM card ID)",
                    Mac = "The Media Access Control address of the device, listed on the device in the format XX-XX-XX-XX-XX-XX or XX:XX:XX:XX:XX:XX",
                    Manufacturer = "REOLINK",
                    Meid = "The 56-bit Mobile Equipment ID",
                    Msisdn = "The Mobile Station International Subscriber Directory Number. In the USA, this is 1+ a 10-digit phone number",
                    NodeUuid = "The UUID of the node the device is associated with",
                    Qrcode = "The Quick Response (QR) code",
                    Serial = "The device's serial number",
                },
            },
        });
    // TODO: Handle 'response' of type ResourceDevice
}
catch (ApiException<SensorInsightsPatchDeviceRequestError> ex)
{
    if (ex.Error.TryGetManagementError400(out var error))
    {
        // TODO: Handle 'error' of type ManagementError400
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SensorInsightsPatchDeviceRequest](src/Verizon/Requests/SensorInsightsDevices/SensorInsightsPatchDeviceRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ResourceDevice](src/Verizon/Models/ResourceDevice.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[SensorInsightsPatchDeviceRequestError](src/Verizon/Errors/SensorInsightsPatchDeviceRequestError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## SensorInsightsGateways

> Source: [SensorInsightsGateways](src/Verizon/Api/SensorInsightsGateways.cs)

<details>
<summary><code>Task&lt;IReadOnlyList&lt;ResourceDevice&gt;&gt; SensorInsightsListGatewayDevicesRequest(SensorInsightsListGatewayDevicesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SensorInsightsGateways.SensorInsightsListGatewayDevicesRequest(
        new SensorInsightsListGatewayDevicesRequest
        {
            Body = new DtoListDevicesRequest
            {
                Accountname = "0000123456-00001",
                Filter = new DtoFilter
                {
                    Expand = "device detail(s)",
                    Limitnumber = 100,
                    Nopagination = true,
                    Page = "The number of pages",
                    Pagenumber = 100,
                    Projection = ["specific device fields requested"],
                    Selection = new Dictionary<string, object>(),
                },
                Resourceidentifier = new DtoDeviceResourceIdentifier
                {
                    Deveui = "The unique EUI64 address of the device",
                    Deviceid = "The UUID of the device",
                    Iccid = "The 20-digit Integrated Circuit Card ID (SIM card ID)",
                    Mac = "The Media Access Control address of the device, listed on the device in the format XX-XX-XX-XX-XX-XX or XX:XX:XX:XX:XX:XX",
                    Manufacturer = "REOLINK",
                    Meid = "The 56-bit Mobile Equipment ID",
                    Msisdn = "The Mobile Station International Subscriber Directory Number. In the USA, this is 1+ a 10-digit phone number",
                    NodeUuid = "The UUID of the node the device is associated with",
                    Qrcode = "The Quick Response (QR) code",
                    Serial = "The device's serial number",
                },
            },
        });
    // TODO: Handle 'response' of type IReadOnlyList<ResourceDevice>
}
catch (ApiException<SensorInsightsListGatewayDevicesRequestError> ex)
{
    if (ex.Error.TryGetManagementError400(out var error))
    {
        // TODO: Handle 'error' of type ManagementError400
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SensorInsightsListGatewayDevicesRequest](src/Verizon/Requests/SensorInsightsGateways/SensorInsightsListGatewayDevicesRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[ResourceDevice](src/Verizon/Models/ResourceDevice.cs)&gt;</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[SensorInsightsListGatewayDevicesRequestError](src/Verizon/Errors/SensorInsightsListGatewayDevicesRequestError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## SensorInsightsHealthScore

> Source: [SensorInsightsHealthScore](src/Verizon/Api/SensorInsightsHealthScore.cs)

<details>
<summary><code>Task&lt;DtoGetNetworkHealthScoreResponse&gt; SensorInsightsGetNetworkHealthScoreResponse(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SensorInsightsHealthScore.SensorInsightsGetNetworkHealthScoreResponse();
    // TODO: Handle 'response' of type DtoGetNetworkHealthScoreResponse
}
catch (ApiException<SensorInsightsGetNetworkHealthScoreResponseError> ex)
{
    if (ex.Error.TryGetManagementError400(out var error))
    {
        // TODO: Handle 'error' of type ManagementError400
    }
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DtoGetNetworkHealthScoreResponse](src/Verizon/Models/DtoGetNetworkHealthScoreResponse.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[SensorInsightsGetNetworkHealthScoreResponseError](src/Verizon/Errors/SensorInsightsGetNetworkHealthScoreResponseError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DtoHealthScoreSummary&gt; SensorInsightsHealthScoreSummary(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SensorInsightsHealthScore.SensorInsightsHealthScoreSummary();
    // TODO: Handle 'response' of type DtoHealthScoreSummary
}
catch (ApiException<SensorInsightsHealthScoreSummaryError> ex)
{
    if (ex.Error.TryGetManagementError400(out var error))
    {
        // TODO: Handle 'error' of type ManagementError400
    }
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DtoHealthScoreSummary](src/Verizon/Models/DtoHealthScoreSummary.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[SensorInsightsHealthScoreSummaryError](src/Verizon/Errors/SensorInsightsHealthScoreSummaryError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## SensorInsightsNotificationGroups

> Source: [SensorInsightsNotificationGroups](src/Verizon/Api/SensorInsightsNotificationGroups.cs)

<details>
<summary><code>Task SensorInsightsAddUsersToNotificationGroupRequest(SensorInsightsAddUsersToNotificationGroupRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.SensorInsightsNotificationGroups.SensorInsightsAddUsersToNotificationGroupRequest(
        new SensorInsightsAddUsersToNotificationGroupRequest
        {
            Body = new DtoAddUsersToNotificationGroupRequest
            {
                Accountname = "0000123456-00001",
                Id = "45f1a56e-eeee-ffff-gggg-68cb994feb5f",
                Userids = ["ee70a869-eeee-ffff-gggg-07c14c31f96e", "131501ff-eeee-ffff-gggg-647d19179a12"],
            },
        });
}
catch (ApiException<SensorInsightsAddUsersToNotificationGroupRequestError> ex)
{
    if (ex.Error.TryGetManagementError400(out var error))
    {
        // TODO: Handle 'error' of type ManagementError400
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SensorInsightsAddUsersToNotificationGroupRequest](src/Verizon/Requests/SensorInsightsNotificationGroups/SensorInsightsAddUsersToNotificationGroupRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[SensorInsightsAddUsersToNotificationGroupRequestError](src/Verizon/Errors/SensorInsightsAddUsersToNotificationGroupRequestError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DtoNotificationGroupResponseEntity&gt; SensorInsightsCreateNotificationGroupRequest(SensorInsightsCreateNotificationGroupRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SensorInsightsNotificationGroups.SensorInsightsCreateNotificationGroupRequest(
        new SensorInsightsCreateNotificationGroupRequest
        {
            Body = new DtoCreateNotificationGroupRequest
            {
                Accountname = "0000123456-00001",
                Group = new DtoNotificationGroupRequestEntity
                {
                    Description = "a short description",
                    Groupemail = "email@domain.com",
                    Name = "User defined name of the record",
                },
                Userids = ["ee70a869-eeee-ffff-gggg-07c14c31f96e", "131501ff-eeee-ffff-gggg-647d19179a12"],
            },
        });
    // TODO: Handle 'response' of type DtoNotificationGroupResponseEntity
}
catch (ApiException<SensorInsightsCreateNotificationGroupRequestError> ex)
{
    if (ex.Error.TryGetManagementError400(out var error))
    {
        // TODO: Handle 'error' of type ManagementError400
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SensorInsightsCreateNotificationGroupRequest](src/Verizon/Requests/SensorInsightsNotificationGroups/SensorInsightsCreateNotificationGroupRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DtoNotificationGroupResponseEntity](src/Verizon/Models/DtoNotificationGroupResponseEntity.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[SensorInsightsCreateNotificationGroupRequestError](src/Verizon/Errors/SensorInsightsCreateNotificationGroupRequestError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task SensorInsightsDeleteNotificationGroup(SensorInsightsDeleteNotificationGroupRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.SensorInsightsNotificationGroups.SensorInsightsDeleteNotificationGroup(
        new SensorInsightsDeleteNotificationGroupRequest
        {
            Payload = new DtoDeleteNotificationGroupRequest
            {
                Accountname = "0000123456-00001",
                Force = true,
                Id = "6737ca22-eeee-ffff-gggg-84c09f2ede8e",
            },
        });
}
catch (ApiException<SensorInsightsDeleteNotificationGroupError> ex)
{
    if (ex.Error.TryGetManagementError400(out var error))
    {
        // TODO: Handle 'error' of type ManagementError400
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SensorInsightsDeleteNotificationGroupRequest](src/Verizon/Requests/SensorInsightsNotificationGroups/SensorInsightsDeleteNotificationGroupRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[SensorInsightsDeleteNotificationGroupError](src/Verizon/Errors/SensorInsightsDeleteNotificationGroupError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;DtoNotificationGroupResponseEntity&gt;&gt; SensorInsightsListNotificationGroupRequest(SensorInsightsListNotificationGroupRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SensorInsightsNotificationGroups.SensorInsightsListNotificationGroupRequest(
        new SensorInsightsListNotificationGroupRequest
        {
            Body = new DtoListNotificationGroupRequest
            {
                Accountname = "0000123456-00001",
                Filter = new DtoFilter
                {
                    Expand = "device detail(s)",
                    Limitnumber = 100,
                    Nopagination = true,
                    Page = "The number of pages",
                    Pagenumber = 100,
                    Projection = ["specific device fields requested"],
                    Selection = new Dictionary<string, object>(),
                },
            },
        });
    // TODO: Handle 'response' of type IReadOnlyList<DtoNotificationGroupResponseEntity>
}
catch (ApiException<SensorInsightsListNotificationGroupRequestError> ex)
{
    if (ex.Error.TryGetManagementError400(out var error))
    {
        // TODO: Handle 'error' of type ManagementError400
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SensorInsightsListNotificationGroupRequest](src/Verizon/Requests/SensorInsightsNotificationGroups/SensorInsightsListNotificationGroupRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[DtoNotificationGroupResponseEntity](src/Verizon/Models/DtoNotificationGroupResponseEntity.cs)&gt;</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[SensorInsightsListNotificationGroupRequestError](src/Verizon/Errors/SensorInsightsListNotificationGroupRequestError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task SensorInsightsRemoveUsersFromNotificationGroupRequest(SensorInsightsRemoveUsersFromNotificationGroupRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.SensorInsightsNotificationGroups.SensorInsightsRemoveUsersFromNotificationGroupRequest(
        new SensorInsightsRemoveUsersFromNotificationGroupRequest
        {
            Body = new DtoRemoveUsersFromNotificationGroupRequest
            {
                Accountname = "0000123456-00001",
                Id = "111538a8-eeee-ffff-gggg-3b72804403e8",
                Userids = ["ee70a869-eeee-ffff-gggg-07c14c31f96e", "131501ff-eeee-ffff-gggg-647d19179a12"],
            },
        });
}
catch (ApiException<SensorInsightsRemoveUsersFromNotificationGroupRequestError> ex)
{
    if (ex.Error.TryGetManagementError400(out var error))
    {
        // TODO: Handle 'error' of type ManagementError400
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SensorInsightsRemoveUsersFromNotificationGroupRequest](src/Verizon/Requests/SensorInsightsNotificationGroups/SensorInsightsRemoveUsersFromNotificationGroupRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[SensorInsightsRemoveUsersFromNotificationGroupRequestError](src/Verizon/Errors/SensorInsightsRemoveUsersFromNotificationGroupRequestError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DtoNotificationGroupResponseEntity&gt; SensorInsightsUpdateNotificationGroupRequest(SensorInsightsUpdateNotificationGroupRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SensorInsightsNotificationGroups.SensorInsightsUpdateNotificationGroupRequest(
        new SensorInsightsUpdateNotificationGroupRequest
        {
            Body = new DtoUpdateNotificationGroupRequest
            {
                Accountname = "0000123456-00001",
                Group = new DtoNotificationGroupRequestEntity
                {
                    Description = "a short description",
                    Groupemail = "email@domain.com",
                    Name = "User defined name of the record",
                },
                Id = "7b0b9c53-eeee-ffff-gggg-bde5e44f4b12",
                Userids = ["ee70a869-eeee-ffff-gggg-07c14c31f96e", "131501ff-eeee-ffff-gggg-647d19179a12"],
            },
        });
    // TODO: Handle 'response' of type DtoNotificationGroupResponseEntity
}
catch (ApiException<SensorInsightsUpdateNotificationGroupRequestError> ex)
{
    if (ex.Error.TryGetManagementError400(out var error))
    {
        // TODO: Handle 'error' of type ManagementError400
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SensorInsightsUpdateNotificationGroupRequest](src/Verizon/Requests/SensorInsightsNotificationGroups/SensorInsightsUpdateNotificationGroupRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DtoNotificationGroupResponseEntity](src/Verizon/Models/DtoNotificationGroupResponseEntity.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[SensorInsightsUpdateNotificationGroupRequestError](src/Verizon/Errors/SensorInsightsUpdateNotificationGroupRequestError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## SensorInsightsRules

> Source: [SensorInsightsRules](src/Verizon/Api/SensorInsightsRules.cs)

<details>
<summary><code>Task&lt;IReadOnlyList&lt;ResourceRule&gt;&gt; SensorInsightsListRulesRequest(SensorInsightsListRulesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SensorInsightsRules.SensorInsightsListRulesRequest(new SensorInsightsListRulesRequest
    {
        Body = new DtoListRulesRequest
        {
            Accountname = "0000123456-00001",
            Filter = new DtoFilter
            {
                Expand = "device detail(s)",
                Limitnumber = 100,
                Nopagination = true,
                Page = "The number of pages",
                Pagenumber = 100,
                Projection = ["specific device fields requested"],
                Selection = new Dictionary<string, object>(),
            },
            Resourceidentifier = new DtoResourceidentifier { Id = "ffb86390-eeee-ffff-gggg-9d1180882d63" },
        },
    });
    // TODO: Handle 'response' of type IReadOnlyList<ResourceRule>
}
catch (ApiException<SensorInsightsListRulesRequestError> ex)
{
    if (ex.Error.TryGetManagementError400(out var error))
    {
        // TODO: Handle 'error' of type ManagementError400
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SensorInsightsListRulesRequest](src/Verizon/Requests/SensorInsightsRules/SensorInsightsListRulesRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[ResourceRule](src/Verizon/Models/ResourceRule.cs)&gt;</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[SensorInsightsListRulesRequestError](src/Verizon/Errors/SensorInsightsListRulesRequestError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ResourceRule&gt; SensorInsightsOverwriteRuleRequest(SensorInsightsOverwriteRuleRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SensorInsightsRules.SensorInsightsOverwriteRuleRequest(
        new SensorInsightsOverwriteRuleRequest
        {
            Body = new DtoOverwriteRuleRequest
            {
                Accountname = "0000123456-00001",
                Resourceidentifier = new DtoResourceidentifier { Id = "7f5f610a-eeee-ffff-gggg-4d20cf3dcfbc" },
                Rule = new ResourceRule
                {
                    Accountclientid = "null",
                    Billingaccountid = "The billing account ID",
                    Createdon = DateTimeOffset.Parse("2023-10-02T15:46:34.562Z"),
                    Description = "a short description",
                    Deviceid = "The UUID of the device",
                    Disabled = true,
                    Foreignid = "c1f178d3-eeee-ffff-gggg-0d6b7ae6022a",
                    Id = "bc5b5b5a-eeee-ffff-gggg-cb2cb2533d47",
                    Lastupdated = DateTimeOffset.Parse("2023-10-02T15:46:34.562Z"),
                    Name = "User defined name of the record",
                    Rulechain = rulechain,
                    Rulesyntax = "The rule syntax",
                    Version = "1.0",
                    Versionid = "337bd2e8-eeee-ffff-gggg-5207992fd395",
                },
            },
        });
    // TODO: Handle 'response' of type ResourceRule
}
catch (ApiException<SensorInsightsOverwriteRuleRequestError> ex)
{
    if (ex.Error.TryGetManagementError400(out var error))
    {
        // TODO: Handle 'error' of type ManagementError400
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SensorInsightsOverwriteRuleRequest](src/Verizon/Requests/SensorInsightsRules/SensorInsightsOverwriteRuleRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ResourceRule](src/Verizon/Models/ResourceRule.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[SensorInsightsOverwriteRuleRequestError](src/Verizon/Errors/SensorInsightsOverwriteRuleRequestError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## SensorInsightsSensors

> Source: [SensorInsightsSensors](src/Verizon/Api/SensorInsightsSensors.cs)

<details>
<summary><code>Task&lt;IReadOnlyList&lt;ResourceDevice&gt;&gt; SensorInsightsListSensorDevicesRequest(SensorInsightsListSensorDevicesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SensorInsightsSensors.SensorInsightsListSensorDevicesRequest(
        new SensorInsightsListSensorDevicesRequest
        {
            Body = new DtoListSensorDevicesRequest
            {
                Accountname = "0000123456-00001",
                Filter = new DtoFilter
                {
                    Expand = "device detail(s)",
                    Limitnumber = 100,
                    Nopagination = true,
                    Page = "The number of pages",
                    Pagenumber = 1,
                    Projection = ["specific device fields requested"],
                    Selection = new Dictionary<string, object>(),
                },
                Resourceidentifier = new DtoDeviceResourceIdentifier
                {
                    Deveui = "The unique EUI64 address of the device",
                    Deviceid = "The UUID of the device",
                    Iccid = "The 20-digit Integrated Circuit Card ID (SIM card ID)",
                    Mac = "The Media Access Control address of the device, listed on the device in the format XX-XX-XX-XX-XX-XX or XX:XX:XX:XX:XX:XX",
                    Manufacturer = "REOLINK",
                    Meid = "The 56-bit Mobile Equipment ID",
                    Msisdn = "The Mobile Station International Subscriber Directory Number. In the USA, this is 1+ a 10-digit phone number",
                    NodeUuid = "The UUID of the node the device is associated with",
                    Qrcode = "The Quick Response (QR) code",
                    Serial = "The device's serial number",
                },
            },
        });
    // TODO: Handle 'response' of type IReadOnlyList<ResourceDevice>
}
catch (ApiException<SensorInsightsListSensorDevicesRequestError> ex)
{
    if (ex.Error.TryGetManagementError400(out var error))
    {
        // TODO: Handle 'error' of type ManagementError400
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SensorInsightsListSensorDevicesRequest](src/Verizon/Requests/SensorInsightsSensors/SensorInsightsListSensorDevicesRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[ResourceDevice](src/Verizon/Models/ResourceDevice.cs)&gt;</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[SensorInsightsListSensorDevicesRequestError](src/Verizon/Errors/SensorInsightsListSensorDevicesRequestError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task SensorInsightsOffBoardSensorRequest(SensorInsightsOffBoardSensorRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.SensorInsightsSensors.SensorInsightsOffBoardSensorRequest(new SensorInsightsOffBoardSensorRequest
    {
        Body = new DtoOffBoardSensorRequest
        {
            Accountname = "0000123456-00001",
            Configuration = new Sensorinsightsconfig
            {
                Removesensor = new DtoOffBoardSensor { Deveui = "The unique EUI64 address of the device" },
            },
        },
    });
}
catch (ApiException<SensorInsightsOffBoardSensorRequestError> ex)
{
    if (ex.Error.TryGetManagementError400(out var error))
    {
        // TODO: Handle 'error' of type ManagementError400
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SensorInsightsOffBoardSensorRequest](src/Verizon/Requests/SensorInsightsSensors/SensorInsightsOffBoardSensorRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[SensorInsightsOffBoardSensorRequestError](src/Verizon/Errors/SensorInsightsOffBoardSensorRequestError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task SensorInsightsOnBoardSensorRequest(SensorInsightsOnBoardSensorRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.SensorInsightsSensors.SensorInsightsOnBoardSensorRequest(new SensorInsightsOnBoardSensorRequest
    {
        Body = new DtoOnBoardSensorRequest
        {
            Accountname = "0000123456-00001",
            Payload = new Payload
            {
                Addsensor = new ResourceOnBoardSensor
                {
                    Deveui = "The unique EUI64 address of the device",
                    Appeui = "global application ID in IEEE EUI64 address space that uniquely identifies the entity able to process the JoinReq frame",
                    Appkey = "Encryption key used for messages during every over the air activation",
                    Class = "A",
                    Kind = "ts.device.sensor.lorawan.radiobridge.RBS301-DWS-US",
                    Description = "used to identify water leaks",
                    Name = "Water Leak sensor",
                    Customdata = new Dictionary<string, object>(),
                },
            },
        },
    });
}
catch (ApiException<SensorInsightsOnBoardSensorRequestError> ex)
{
    if (ex.Error.TryGetManagementError400(out var error))
    {
        // TODO: Handle 'error' of type ManagementError400
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SensorInsightsOnBoardSensorRequest](src/Verizon/Requests/SensorInsightsSensors/SensorInsightsOnBoardSensorRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[SensorInsightsOnBoardSensorRequestError](src/Verizon/Errors/SensorInsightsOnBoardSensorRequestError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DtoSensorOffBoardingStatusResponse&gt; SensorInsightsSensorOffBoardingStatusRequest(SensorInsightsSensorOffBoardingStatusRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SensorInsightsSensors.SensorInsightsSensorOffBoardingStatusRequest(
        new SensorInsightsSensorOffBoardingStatusRequest
        {
            Body = new DtoSensorOffBoardStatusRequest
            {
                Accountname = "0000123456-00001",
                Gatewayidentifier = new Gatewayidentifier { Deviceid = "UUID of the Gateway device" },
                Offboarding = new Offboarding(),
            },
        });
    // TODO: Handle 'response' of type DtoSensorOffBoardingStatusResponse
}
catch (ApiException<SensorInsightsSensorOffBoardingStatusRequestError> ex)
{
    if (ex.Error.TryGetManagementError400(out var error))
    {
        // TODO: Handle 'error' of type ManagementError400
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SensorInsightsSensorOffBoardingStatusRequest](src/Verizon/Requests/SensorInsightsSensors/SensorInsightsSensorOffBoardingStatusRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DtoSensorOffBoardingStatusResponse](src/Verizon/Models/DtoSensorOffBoardingStatusResponse.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[SensorInsightsSensorOffBoardingStatusRequestError](src/Verizon/Errors/SensorInsightsSensorOffBoardingStatusRequestError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DtoSensorOnBoardingStatusResponse&gt; SensorInsightsSensorOnBoardStatusRequest(SensorInsightsSensorOnBoardStatusRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SensorInsightsSensors.SensorInsightsSensorOnBoardStatusRequest(
        new SensorInsightsSensorOnBoardStatusRequest
        {
            Body = new DtoSensorOnBoardStatusRequest
            {
                Accountname = "0000123456-00001",
                Gatewayidentifier = new Gatewayidentifier { Deviceid = "00000000-0000-0000-0000-000000000255" },
                Onboarding = new Onboarding(),
            },
        });
    // TODO: Handle 'response' of type DtoSensorOnBoardingStatusResponse
}
catch (ApiException<SensorInsightsSensorOnBoardStatusRequestError> ex)
{
    if (ex.Error.TryGetManagementError400(out var error))
    {
        // TODO: Handle 'error' of type ManagementError400
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SensorInsightsSensorOnBoardStatusRequest](src/Verizon/Requests/SensorInsightsSensors/SensorInsightsSensorOnBoardStatusRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DtoSensorOnBoardingStatusResponse](src/Verizon/Models/DtoSensorOnBoardingStatusResponse.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[SensorInsightsSensorOnBoardStatusRequestError](src/Verizon/Errors/SensorInsightsSensorOnBoardStatusRequestError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## SensorInsightsSmartAlertMetrics

> Source: [SensorInsightsSmartAlertMetrics](src/Verizon/Api/SensorInsightsSmartAlertMetrics.cs)

<details>
<summary><code>Task&lt;DtoQueryMetricsResponse&gt; Sensorinsightsmetricsquery(SensorinsightsmetricsqueryRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Get Device Alerts for the most recent daily period, up to 30 days.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SensorInsightsSmartAlertMetrics.Sensorinsightsmetricsquery(
        new SensorinsightsmetricsqueryRequest { Body = new DtoQueryMetrics() });
    // TODO: Handle 'response' of type DtoQueryMetricsResponse
}
catch (ApiException<SensorinsightsmetricsqueryError> ex)
{
    if (ex.Error.TryGetManagementError400(out var error))
    {
        // TODO: Handle 'error' of type ManagementError400
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SensorinsightsmetricsqueryRequest](src/Verizon/Requests/SensorInsightsSmartAlertMetrics/SensorinsightsmetricsqueryRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DtoQueryMetricsResponse](src/Verizon/Models/DtoQueryMetricsResponse.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[SensorinsightsmetricsqueryError](src/Verizon/Errors/SensorinsightsmetricsqueryError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## SensorInsightsSmartAlerts

> Source: [SensorInsightsSmartAlerts](src/Verizon/Api/SensorInsightsSmartAlerts.cs)

<details>
<summary><code>Task&lt;UserSmartAlert&gt; SensorInsightsBulkUpdate(SensorInsightsBulkUpdateRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SensorInsightsSmartAlerts.SensorInsightsBulkUpdate(new SensorInsightsBulkUpdateRequest
    {
        Body = new DtoBulkUpdate
        {
            Accountname = "0000123456-00001",
            Resourceidentifiers = [
                new TheIDresourceandDeviceId { Id = "ee70a869-eeee-ffff-gggg-07c14c31f96e" },
                new TheIDresourceandDeviceId { Deviceid = "The UUID of the device" },
            ],
            Smartalert = new BulkUpdateSmartalert { Name = "User defined name of the record" },
        },
    });
    // TODO: Handle 'response' of type UserSmartAlert
}
catch (ApiException<SensorInsightsBulkUpdateError> ex)
{
    if (ex.Error.TryGetManagementError400(out var error))
    {
        // TODO: Handle 'error' of type ManagementError400
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SensorInsightsBulkUpdateRequest](src/Verizon/Requests/SensorInsightsSmartAlerts/SensorInsightsBulkUpdateRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UserSmartAlert](src/Verizon/Models/UserSmartAlert.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[SensorInsightsBulkUpdateError](src/Verizon/Errors/SensorInsightsBulkUpdateError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;UserSmartAlert&gt;&gt; SensorInsightsListSmartAlertsRequest(SensorInsightsListSmartAlertsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SensorInsightsSmartAlerts.SensorInsightsListSmartAlertsRequest(
        new SensorInsightsListSmartAlertsRequest
        {
            Body = new DtoListSmartAlertsRequest
            {
                Accountname = "0000123456-00001",
                Filter = new DtoFilter
                {
                    Expand = "device detail(s)",
                    Limitnumber = 100,
                    Nopagination = true,
                    Page = "The number of pages",
                    Pagenumber = 100,
                    Projection = ["specific device fields requested"],
                    Selection = new Dictionary<string, object>(),
                },
                Resourceidentifier = new DtoResourceidentifier { Id = "cb3eea68-eeee-ffff-gggg-ac4463ccd073" },
            },
        });
    // TODO: Handle 'response' of type IReadOnlyList<UserSmartAlert>
}
catch (ApiException<SensorInsightsListSmartAlertsRequestError> ex)
{
    if (ex.Error.TryGetManagementError400(out var error))
    {
        // TODO: Handle 'error' of type ManagementError400
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SensorInsightsListSmartAlertsRequest](src/Verizon/Requests/SensorInsightsSmartAlerts/SensorInsightsListSmartAlertsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[UserSmartAlert](src/Verizon/Models/UserSmartAlert.cs)&gt;</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[SensorInsightsListSmartAlertsRequestError](src/Verizon/Errors/SensorInsightsListSmartAlertsRequestError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UserSmartAlert&gt; SensorInsightsPatchSmartAlertRequest(SensorInsightsPatchSmartAlertRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SensorInsightsSmartAlerts.SensorInsightsPatchSmartAlertRequest(
        new SensorInsightsPatchSmartAlertRequest
        {
            Body = new DtoPatchSmartAlertRequest
            {
                Accountname = "0000123456-00001",
                Resourceidentifier = new DtoResourceidentifier { Id = "0b37ab8b-eeee-ffff-gggg-e0149af43f43" },
                Smartalert = new UserSmartAlert
                {
                    Accountclientid = "null",
                    Billingaccountid = "0000123456-00001",
                    Category = "telemetry",
                    Condition = 2592000,
                    Createdon = DateTimeOffset.Parse("2023-10-02T15:46:34.562Z"),
                    Description = "a short description",
                    Deviceid = "The UUID of the device",
                    Foreignid = "c1f178d3-eeee-ffff-gggg-0d6b7ae6022a",
                    Id = "fecbe450-eeee-ffff-gggg-aa166fd5f8e3",
                    Isacknowledged = true,
                    Iscleared = true,
                    Isdisabled = false,
                    Lastupdated = DateTimeOffset.Parse("2023-10-02T15:46:34.562Z"),
                    Name = "User defined name of the record",
                    Ruleid = "The UUID of a rule",
                    Severity = "minor",
                    State = "success",
                    Template = "The template ID",
                    Version = "1.0",
                    Versionid = "337bd2e8-eeee-ffff-gggg-5207992fd395",
                },
            },
        });
    // TODO: Handle 'response' of type UserSmartAlert
}
catch (ApiException<SensorInsightsPatchSmartAlertRequestError> ex)
{
    if (ex.Error.TryGetManagementError400(out var error))
    {
        // TODO: Handle 'error' of type ManagementError400
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SensorInsightsPatchSmartAlertRequest](src/Verizon/Requests/SensorInsightsSmartAlerts/SensorInsightsPatchSmartAlertRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UserSmartAlert](src/Verizon/Models/UserSmartAlert.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[SensorInsightsPatchSmartAlertRequestError](src/Verizon/Errors/SensorInsightsPatchSmartAlertRequestError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## SensorInsightsUsers

> Source: [SensorInsightsUsers](src/Verizon/Api/SensorInsightsUsers.cs)

<details>
<summary><code>Task&lt;ResourceUser&gt; SensorInsightsCreateUserRequest(SensorInsightsCreateUserRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SensorInsightsUsers.SensorInsightsCreateUserRequest(new SensorInsightsCreateUserRequest
    {
        Body = new DtoCreateUserRequest
        {
            Accountname = "0000123456-00001",
            User = new DtoUserDto
            {
                Email = "email@domain.com",
                Firstname = "First name",
                Lastname = "Last name or Surname",
                Mdn = "908-555-1234",
                Customdata = new Dictionary<string, object>(),
            },
        },
    });
    // TODO: Handle 'response' of type ResourceUser
}
catch (ApiException<SensorInsightsCreateUserRequestError> ex)
{
    if (ex.Error.TryGetManagementError400(out var error))
    {
        // TODO: Handle 'error' of type ManagementError400
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SensorInsightsCreateUserRequest](src/Verizon/Requests/SensorInsightsUsers/SensorInsightsCreateUserRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ResourceUser](src/Verizon/Models/ResourceUser.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[SensorInsightsCreateUserRequestError](src/Verizon/Errors/SensorInsightsCreateUserRequestError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task SensorInsightsDeleteUser(SensorInsightsDeleteUserRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.SensorInsightsUsers.SensorInsightsDeleteUser(new SensorInsightsDeleteUserRequest
    {
        Deleterequestpayload = new DtoDeleteUserRequest
        {
            Accountname = "0000123456-00001",
            Id = "8ea30999-eeee-ffff-gggg-3ea409f5fee4",
        },
    });
}
catch (ApiException<SensorInsightsDeleteUserError> ex)
{
    if (ex.Error.TryGetManagementError400(out var error))
    {
        // TODO: Handle 'error' of type ManagementError400
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SensorInsightsDeleteUserRequest](src/Verizon/Requests/SensorInsightsUsers/SensorInsightsDeleteUserRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[SensorInsightsDeleteUserError](src/Verizon/Errors/SensorInsightsDeleteUserError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;ResourceUser&gt;&gt; SensorInsightsListUserRequest(SensorInsightsListUserRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SensorInsightsUsers.SensorInsightsListUserRequest(new SensorInsightsListUserRequest
    {
        Body = new DtoListUserRequest
        {
            Accountname = "0000123456-00001",
            Filter = new DtoFilter
            {
                Expand = "device detail(s)",
                Limitnumber = 100,
                Nopagination = true,
                Page = "The number of pages",
                Pagenumber = 100,
                Projection = ["specific device fields requested"],
                Selection = new Dictionary<string, object>(),
            },
        },
    });
    // TODO: Handle 'response' of type IReadOnlyList<ResourceUser>
}
catch (ApiException<SensorInsightsListUserRequestError> ex)
{
    if (ex.Error.TryGetManagementError400(out var error))
    {
        // TODO: Handle 'error' of type ManagementError400
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SensorInsightsListUserRequest](src/Verizon/Requests/SensorInsightsUsers/SensorInsightsListUserRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[ResourceUser](src/Verizon/Models/ResourceUser.cs)&gt;</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[SensorInsightsListUserRequestError](src/Verizon/Errors/SensorInsightsListUserRequestError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ResourceUser&gt; SensorInsightsUpdateUserRequest(SensorInsightsUpdateUserRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SensorInsightsUsers.SensorInsightsUpdateUserRequest(new SensorInsightsUpdateUserRequest
    {
        Body = new DtoUpdateUserRequest
        {
            Accountname = "0000123456-00001",
            Id = "9dd573ba-eeee-ffff-gggg-8009758bcaca",
            User = new DtoUserDto
            {
                Email = "email@domain.com",
                Firstname = "First name",
                Lastname = "Last name or Surname",
                Mdn = "908-555-1234",
                Customdata = new Dictionary<string, object>(),
            },
        },
    });
    // TODO: Handle 'response' of type ResourceUser
}
catch (ApiException<SensorInsightsUpdateUserRequestError> ex)
{
    if (ex.Error.TryGetManagementError400(out var error))
    {
        // TODO: Handle 'error' of type ManagementError400
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SensorInsightsUpdateUserRequest](src/Verizon/Requests/SensorInsightsUsers/SensorInsightsUpdateUserRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ResourceUser](src/Verizon/Models/ResourceUser.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[SensorInsightsUpdateUserRequestError](src/Verizon/Errors/SensorInsightsUpdateUserRequestError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## ServerLogging

> Source: [ServerLogging](src/Verizon/Api/ServerLogging.cs)

<details>
<summary><code>Task&lt;IReadOnlyList&lt;CheckInHistoryItem&gt;&gt; GetDeviceCheckInHistory(GetDeviceCheckInHistoryRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Check-in history can be retrieved for any device belonging to the account, not necessarily with logging enabled.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ServerLogging.GetDeviceCheckInHistory(new GetDeviceCheckInHistoryRequest
    {
        Account = "0000123456-00001",
        DeviceId = "990013907835573",
    });
    // TODO: Handle 'response' of type IReadOnlyList<CheckInHistoryItem>
}
catch (ApiException<GetDeviceCheckInHistoryError> ex)
{
    if (ex.Error.TryGetFotaV2Result(out var error))
    {
        // TODO: Handle 'error' of type FotaV2Result
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetDeviceCheckInHistoryRequest](src/Verizon/Requests/ServerLogging/GetDeviceCheckInHistoryRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[CheckInHistoryItem](src/Verizon/Models/CheckInHistoryItem.cs)&gt;</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[GetDeviceCheckInHistoryError](src/Verizon/Errors/GetDeviceCheckInHistoryError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## ServicePlans

> Source: [ServicePlans](src/Verizon/Api/ServicePlans.cs)

<details>
<summary><code>Task&lt;IReadOnlyList&lt;ServicePlan&gt;&gt; ListAccountServicePlans(ListAccountServicePlansRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a list of all data service plans that are associated with a specified billing account. When you send a request to /devices/actions/activate to activate a line of service you must specify the code for one of the service plans associated with your account.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ServicePlans.ListAccountServicePlans(new ListAccountServicePlansRequest
    {
        Aname = "0252012345-00001",
    });
    // TODO: Handle 'response' of type IReadOnlyList<ServicePlan>
}
catch (ApiException<ListAccountServicePlansError> ex)
{
    if (ex.Error.TryGetConnectivityManagementResult(out var error))
    {
        // TODO: Handle 'error' of type ConnectivityManagementResult
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ListAccountServicePlansRequest](src/Verizon/Requests/ServicePlans/ListAccountServicePlansRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[ServicePlan](src/Verizon/Models/ServicePlan.cs)&gt;</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[ListAccountServicePlansError](src/Verizon/Errors/ListAccountServicePlansError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## SessionManagement

> Source: [SessionManagement](src/Verizon/Api/SessionManagement.cs)

<details>
<summary><code>Task&lt;LogOutRequest&gt; EndConnectivityManagementSession(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Ends a Connectivity Management session.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SessionManagement.EndConnectivityManagementSession();
    // TODO: Handle 'response' of type LogOutRequest
}
catch (ApiException<EndConnectivityManagementSessionError> ex)
{
    if (ex.Error.TryGetConnectivityManagementResult(out var error))
    {
        // TODO: Handle 'error' of type ConnectivityManagementResult
    }
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[LogOutRequest](src/Verizon/Models/LogOutRequest.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[EndConnectivityManagementSessionError](src/Verizon/Errors/EndConnectivityManagementSessionError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SessionResetPasswordResult&gt; ResetConnectivityManagementPassword(ResetConnectivityManagementPasswordRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The new password is effective immediately. Passwords do not expire, but Verizon recommends changing your password every 90 days.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SessionManagement.ResetConnectivityManagementPassword(
        new ResetConnectivityManagementPasswordRequest
        {
            Body = new SessionResetPasswordRequest { OldPassword = "grflbk" },
        });
    // TODO: Handle 'response' of type SessionResetPasswordResult
}
catch (ApiException<ResetConnectivityManagementPasswordError> ex)
{
    if (ex.Error.TryGetConnectivityManagementResult(out var error))
    {
        // TODO: Handle 'error' of type ConnectivityManagementResult
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ResetConnectivityManagementPasswordRequest](src/Verizon/Requests/SessionManagement/ResetConnectivityManagementPasswordRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SessionResetPasswordResult](src/Verizon/Models/SessionResetPasswordResult.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[ResetConnectivityManagementPasswordError](src/Verizon/Errors/ResetConnectivityManagementPasswordError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;LogInResult&gt; StartConnectivityManagementSession(StartConnectivityManagementSessionRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Initiates a Connectivity Management session and returns a VZ-M2M session token that is required in subsequent API requests.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SessionManagement.StartConnectivityManagementSession(
        new StartConnectivityManagementSessionRequest
        {
            Body = new LogInRequest { Username = "zbeeblebrox", Password = "IMgr8" },
        });
    // TODO: Handle 'response' of type LogInResult
}
catch (ApiException<StartConnectivityManagementSessionError> ex)
{
    if (ex.Error.TryGetConnectivityManagementResult(out var error))
    {
        // TODO: Handle 'error' of type ConnectivityManagementResult
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[StartConnectivityManagementSessionRequest](src/Verizon/Requests/SessionManagement/StartConnectivityManagementSessionRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[LogInResult](src/Verizon/Models/LogInResult.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[StartConnectivityManagementSessionError](src/Verizon/Errors/StartConnectivityManagementSessionError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## SoftwareManagementCallbacksV1

> Source: [SoftwareManagementCallbacksV1](src/Verizon/Api/SoftwareManagementCallbacksV1.cs)

<details>
<summary><code>Task DeregisterCallback3(DeregisterCallback3Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Deregisters the callback endpoint and stops ThingSpace from sending FOTA callback messages for the specified account.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.SoftwareManagementCallbacksV1.DeregisterCallback3(new DeregisterCallback3Request
    {
        Account = "0242078689-00001",
        Service = CallbackService.Fota,
    });
}
catch (ApiException<DeregisterCallback3Error> ex)
{
    if (ex.Error.TryGetNoContent(out var error))
    {
        // TODO: Handle 'error' of type RawError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeregisterCallback3Request](src/Verizon/Requests/SoftwareManagementCallbacksV1/DeregisterCallback3Request.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[DeregisterCallback3Error](src/Verizon/Errors/DeregisterCallback3Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;RegisteredCallbacks&gt;&gt; ListRegisteredCallbacks3(ListRegisteredCallbacks3Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the name and endpoint URL of the callback listening services registered for a given account.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SoftwareManagementCallbacksV1.ListRegisteredCallbacks3(
        new ListRegisteredCallbacks3Request { Account = "0242078689-00001" });
    // TODO: Handle 'response' of type IReadOnlyList<RegisteredCallbacks>
}
catch (ApiException<ListRegisteredCallbacks3Error> ex)
{
    if (ex.Error.TryGetFotaV1Result(out var error))
    {
        // TODO: Handle 'error' of type FotaV1Result
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ListRegisteredCallbacks3Request](src/Verizon/Requests/SoftwareManagementCallbacksV1/ListRegisteredCallbacks3Request.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[RegisteredCallbacks](src/Verizon/Models/RegisteredCallbacks.cs)&gt;</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[ListRegisteredCallbacks3Error](src/Verizon/Errors/ListRegisteredCallbacks3Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;FotaV1CallbackRegistrationResult&gt; RegisterCallback3(RegisterCallback3Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Registers a URL to receive RESTful messages from a callback service when new firmware versions are available and when upgrades start and finish.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SoftwareManagementCallbacksV1.RegisterCallback3(new RegisterCallback3Request
    {
        Account = "0242078689-00001",
        Body = new FotaV1CallbackRegistrationRequest
        {
            Name = "Fota",
            Url = "https://10.120.102.183:50559/CallbackListener/FirmwareServiceMessages.asmx",
        },
    });
    // TODO: Handle 'response' of type FotaV1CallbackRegistrationResult
}
catch (ApiException<RegisterCallback3Error> ex)
{
    if (ex.Error.TryGetFotaV1Result(out var error))
    {
        // TODO: Handle 'error' of type FotaV1Result
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[RegisterCallback3Request](src/Verizon/Requests/SoftwareManagementCallbacksV1/RegisterCallback3Request.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[FotaV1CallbackRegistrationResult](src/Verizon/Models/FotaV1CallbackRegistrationResult.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[RegisterCallback3Error](src/Verizon/Errors/RegisterCallback3Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## SoftwareManagementCallbacksV2

> Source: [SoftwareManagementCallbacksV2](src/Verizon/Api/SoftwareManagementCallbacksV2.cs)

<details>
<summary><code>Task&lt;FotaV2SuccessResult&gt; DeregisterCallback4(DeregisterCallback4Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This endpoint allows user to delete a previously registered callback URL.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SoftwareManagementCallbacksV2.DeregisterCallback4(new DeregisterCallback4Request
    {
        Account = "0000123456-00001",
    });
    // TODO: Handle 'response' of type FotaV2SuccessResult
}
catch (ApiException<DeregisterCallback4Error> ex)
{
    if (ex.Error.TryGetFotaV2Result(out var error))
    {
        // TODO: Handle 'error' of type FotaV2Result
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeregisterCallback4Request](src/Verizon/Requests/SoftwareManagementCallbacksV2/DeregisterCallback4Request.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[FotaV2SuccessResult](src/Verizon/Models/FotaV2SuccessResult.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[DeregisterCallback4Error](src/Verizon/Errors/DeregisterCallback4Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CallbackSummary&gt; ListRegisteredCallbacks4(ListRegisteredCallbacks4Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This endpoint allows user to get the registered callback information.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SoftwareManagementCallbacksV2.ListRegisteredCallbacks4(
        new ListRegisteredCallbacks4Request { Account = "0000123456-00001" });
    // TODO: Handle 'response' of type CallbackSummary
}
catch (ApiException<ListRegisteredCallbacks4Error> ex)
{
    if (ex.Error.TryGetFotaV2Result(out var error))
    {
        // TODO: Handle 'error' of type FotaV2Result
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ListRegisteredCallbacks4Request](src/Verizon/Requests/SoftwareManagementCallbacksV2/ListRegisteredCallbacks4Request.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CallbackSummary](src/Verizon/Models/CallbackSummary.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[ListRegisteredCallbacks4Error](src/Verizon/Errors/ListRegisteredCallbacks4Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;FotaV2CallbackRegistrationResult&gt; RegisterCallback4(RegisterCallback4Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This endpoint allows user to create the HTTPS callback address.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SoftwareManagementCallbacksV2.RegisterCallback4(new RegisterCallback4Request
    {
        Account = "0000123456-00001",
    });
    // TODO: Handle 'response' of type FotaV2CallbackRegistrationResult
}
catch (ApiException<RegisterCallback4Error> ex)
{
    if (ex.Error.TryGetFotaV2Result(out var error))
    {
        // TODO: Handle 'error' of type FotaV2Result
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[RegisterCallback4Request](src/Verizon/Requests/SoftwareManagementCallbacksV2/RegisterCallback4Request.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[FotaV2CallbackRegistrationResult](src/Verizon/Models/FotaV2CallbackRegistrationResult.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[RegisterCallback4Error](src/Verizon/Errors/RegisterCallback4Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;FotaV2CallbackRegistrationResult&gt; UpdateCallback(UpdateCallbackRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This endpoint allows user to update the HTTPS callback address.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SoftwareManagementCallbacksV2.UpdateCallback(new UpdateCallbackRequest
    {
        Account = "0000123456-00001",
    });
    // TODO: Handle 'response' of type FotaV2CallbackRegistrationResult
}
catch (ApiException<UpdateCallbackError> ex)
{
    if (ex.Error.TryGetFotaV2Result(out var error))
    {
        // TODO: Handle 'error' of type FotaV2Result
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UpdateCallbackRequest](src/Verizon/Requests/SoftwareManagementCallbacksV2/UpdateCallbackRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[FotaV2CallbackRegistrationResult](src/Verizon/Models/FotaV2CallbackRegistrationResult.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[UpdateCallbackError](src/Verizon/Errors/UpdateCallbackError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## SoftwareManagementCallbacksV3

> Source: [SoftwareManagementCallbacksV3](src/Verizon/Api/SoftwareManagementCallbacksV3.cs)

<details>
<summary><code>Task&lt;FotaV3SuccessResult&gt; DeregisterCallback5(DeregisterCallback5Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This endpoint allows user to delete a previously registered callback URL.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SoftwareManagementCallbacksV3.DeregisterCallback5(new DeregisterCallback5Request
    {
        Acc = "0000123456-00001",
    });
    // TODO: Handle 'response' of type FotaV3SuccessResult
}
catch (ApiException<DeregisterCallback5Error> ex)
{
    if (ex.Error.TryGetFotaV3Result(out var error))
    {
        // TODO: Handle 'error' of type FotaV3Result
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeregisterCallback5Request](src/Verizon/Requests/SoftwareManagementCallbacksV3/DeregisterCallback5Request.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[FotaV3SuccessResult](src/Verizon/Models/FotaV3SuccessResult.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[DeregisterCallback5Error](src/Verizon/Errors/DeregisterCallback5Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;FotaV3CallbackSummary&gt; ListRegisteredCallbacks5(ListRegisteredCallbacks5Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This endpoint allows user to get the registered callback information.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SoftwareManagementCallbacksV3.ListRegisteredCallbacks5(
        new ListRegisteredCallbacks5Request { Acc = "0000123456-00001" });
    // TODO: Handle 'response' of type FotaV3CallbackSummary
}
catch (ApiException<ListRegisteredCallbacks5Error> ex)
{
    if (ex.Error.TryGetFotaV3Result(out var error))
    {
        // TODO: Handle 'error' of type FotaV3Result
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ListRegisteredCallbacks5Request](src/Verizon/Requests/SoftwareManagementCallbacksV3/ListRegisteredCallbacks5Request.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[FotaV3CallbackSummary](src/Verizon/Models/FotaV3CallbackSummary.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[ListRegisteredCallbacks5Error](src/Verizon/Errors/ListRegisteredCallbacks5Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;FotaV3CallbackRegistrationResult&gt; RegisterCallback5(RegisterCallback5Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This endpoint allows the user to create the HTTPS callback address.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SoftwareManagementCallbacksV3.RegisterCallback5(new RegisterCallback5Request
    {
        Acc = "0000123456-00001",
        Body = new FotaV3CallbackRegistrationRequest
        {
            Url = "https://255.255.11.135:50559/CallbackListener/FirmwareServiceMessages.asmx",
        },
    });
    // TODO: Handle 'response' of type FotaV3CallbackRegistrationResult
}
catch (ApiException<RegisterCallback5Error> ex)
{
    if (ex.Error.TryGetFotaV3Result(out var error))
    {
        // TODO: Handle 'error' of type FotaV3Result
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[RegisterCallback5Request](src/Verizon/Requests/SoftwareManagementCallbacksV3/RegisterCallback5Request.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[FotaV3CallbackRegistrationResult](src/Verizon/Models/FotaV3CallbackRegistrationResult.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[RegisterCallback5Error](src/Verizon/Errors/RegisterCallback5Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;FotaV3CallbackRegistrationResult&gt; UpdateCallback2(UpdateCallback2Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This endpoint allows the user to update the HTTPS callback address.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SoftwareManagementCallbacksV3.UpdateCallback2(new UpdateCallback2Request
    {
        Acc = "0000123456-00001",
        Body = new FotaV3CallbackRegistrationRequest
        {
            Url = "https://255.255.11.135:50559/CallbackListener/FirmwareServiceMessages.asmx",
        },
    });
    // TODO: Handle 'response' of type FotaV3CallbackRegistrationResult
}
catch (ApiException<UpdateCallback2Error> ex)
{
    if (ex.Error.TryGetFotaV3Result(out var error))
    {
        // TODO: Handle 'error' of type FotaV3Result
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UpdateCallback2Request](src/Verizon/Requests/SoftwareManagementCallbacksV3/UpdateCallback2Request.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[FotaV3CallbackRegistrationResult](src/Verizon/Models/FotaV3CallbackRegistrationResult.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[UpdateCallback2Error](src/Verizon/Errors/UpdateCallback2Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## SoftwareManagementLicensesV1

> Source: [SoftwareManagementLicensesV1](src/Verizon/Api/SoftwareManagementLicensesV1.cs)

<details>
<summary><code>Task&lt;V1LicensesAssignedRemovedResult&gt; AssignLicensesToDevices(AssignLicensesToDevicesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Assigns licenses to a specified list of devices so that firmware upgrades can be scheduled for those devices.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SoftwareManagementLicensesV1.AssignLicensesToDevices(new AssignLicensesToDevicesRequest
    {
        Account = "0242078689-00001",
        Body = new V1LicensesAssignedRemovedRequest { DeviceList = ["990003425730535", "990000473475989"] },
    });
    // TODO: Handle 'response' of type V1LicensesAssignedRemovedResult
}
catch (ApiException<AssignLicensesToDevicesError> ex)
{
    if (ex.Error.TryGetFotaV1Result(out var error))
    {
        // TODO: Handle 'error' of type FotaV1Result
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AssignLicensesToDevicesRequest](src/Verizon/Requests/SoftwareManagementLicensesV1/AssignLicensesToDevicesRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1LicensesAssignedRemovedResult](src/Verizon/Models/V1LicensesAssignedRemovedResult.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[AssignLicensesToDevicesError](src/Verizon/Errors/AssignLicensesToDevicesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V1ListOfLicensesToRemoveResult&gt; CreateListOfLicensesToRemove(CreateListOfLicensesToRemoveRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates a list of devices from which licenses will be removed if the number of MRC licenses becomes less than the number of assigned licenses.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SoftwareManagementLicensesV1.CreateListOfLicensesToRemove(
        new CreateListOfLicensesToRemoveRequest
        {
            Account = "0242078689-00001",
            Body = new V1ListOfLicensesToRemoveRequest
            {
                Type = "append",
                DeviceList = ["990003425730535", "990000473475989"],
            },
        });
    // TODO: Handle 'response' of type V1ListOfLicensesToRemoveResult
}
catch (ApiException<CreateListOfLicensesToRemoveError> ex)
{
    if (ex.Error.TryGetFotaV1Result(out var error))
    {
        // TODO: Handle 'error' of type FotaV1Result
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CreateListOfLicensesToRemoveRequest](src/Verizon/Requests/SoftwareManagementLicensesV1/CreateListOfLicensesToRemoveRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1ListOfLicensesToRemoveResult](src/Verizon/Models/V1ListOfLicensesToRemoveResult.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[CreateListOfLicensesToRemoveError](src/Verizon/Errors/CreateListOfLicensesToRemoveError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task DeleteListOfLicensesToRemove(DeleteListOfLicensesToRemoveRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Deletes the entire list of cancellation candidate devices.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.SoftwareManagementLicensesV1.DeleteListOfLicensesToRemove(new DeleteListOfLicensesToRemoveRequest
    {
        Account = "0242078689-00001",
    });
}
catch (ApiException<DeleteListOfLicensesToRemoveError> ex)
{
    if (ex.Error.TryGetNoContent(out var error))
    {
        // TODO: Handle 'error' of type RawError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeleteListOfLicensesToRemoveRequest](src/Verizon/Requests/SoftwareManagementLicensesV1/DeleteListOfLicensesToRemoveRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[DeleteListOfLicensesToRemoveError](src/Verizon/Errors/DeleteListOfLicensesToRemoveError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V1ListOfLicensesToRemove&gt; ListLicensesToRemove(ListLicensesToRemoveRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a list of devices from which licenses will be removed if the number of MRC licenses becomes less than the number of assigned licenses.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SoftwareManagementLicensesV1.ListLicensesToRemove(new ListLicensesToRemoveRequest
    {
        Account = "0242078689-00001",
        StartIndex = "some example string",
    });
    // TODO: Handle 'response' of type V1ListOfLicensesToRemove
}
catch (ApiException<ListLicensesToRemoveError> ex)
{
    if (ex.Error.TryGetFotaV1Result(out var error))
    {
        // TODO: Handle 'error' of type FotaV1Result
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ListLicensesToRemoveRequest](src/Verizon/Requests/SoftwareManagementLicensesV1/ListLicensesToRemoveRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1ListOfLicensesToRemove](src/Verizon/Models/V1ListOfLicensesToRemove.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[ListLicensesToRemoveError](src/Verizon/Errors/ListLicensesToRemoveError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V1LicensesAssignedRemovedResult&gt; RemoveLicensesFromDevices(RemoveLicensesFromDevicesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Remove unused licenses from device.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SoftwareManagementLicensesV1.RemoveLicensesFromDevices(
        new RemoveLicensesFromDevicesRequest
        {
            Account = "0242078689-00001",
            Body = new V1LicensesAssignedRemovedRequest
            {
                DeviceList = ["900000000000001", "900000000000998", "900000000000999"],
            },
        });
    // TODO: Handle 'response' of type V1LicensesAssignedRemovedResult
}
catch (ApiException<RemoveLicensesFromDevicesError> ex)
{
    if (ex.Error.TryGetFotaV1Result(out var error))
    {
        // TODO: Handle 'error' of type FotaV1Result
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[RemoveLicensesFromDevicesRequest](src/Verizon/Requests/SoftwareManagementLicensesV1/RemoveLicensesFromDevicesRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1LicensesAssignedRemovedResult](src/Verizon/Models/V1LicensesAssignedRemovedResult.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[RemoveLicensesFromDevicesError](src/Verizon/Errors/RemoveLicensesFromDevicesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## SoftwareManagementLicensesV2

> Source: [SoftwareManagementLicensesV2](src/Verizon/Api/SoftwareManagementLicensesV2.cs)

<details>
<summary><code>Task&lt;V2LicensesAssignedRemovedResult&gt; AssignLicensesToDevices2(AssignLicensesToDevices2Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This endpoint allows user to assign licenses to a list of devices.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SoftwareManagementLicensesV2.AssignLicensesToDevices2(
        new AssignLicensesToDevices2Request { Account = "0242078689-00001" });
    // TODO: Handle 'response' of type V2LicensesAssignedRemovedResult
}
catch (ApiException<AssignLicensesToDevices2Error> ex)
{
    if (ex.Error.TryGetFotaV2Result(out var error))
    {
        // TODO: Handle 'error' of type FotaV2Result
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AssignLicensesToDevices2Request](src/Verizon/Requests/SoftwareManagementLicensesV2/AssignLicensesToDevices2Request.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V2LicensesAssignedRemovedResult](src/Verizon/Models/V2LicensesAssignedRemovedResult.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[AssignLicensesToDevices2Error](src/Verizon/Errors/AssignLicensesToDevices2Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V2ListOfLicensesToRemoveResult&gt; CreateListOfLicensesToRemove2(CreateListOfLicensesToRemove2Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The license cancel endpoint allows user to create a list of license cancellation candidate devices.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SoftwareManagementLicensesV2.CreateListOfLicensesToRemove2(
        new CreateListOfLicensesToRemove2Request { Account = "0242078689-00001" });
    // TODO: Handle 'response' of type V2ListOfLicensesToRemoveResult
}
catch (ApiException<CreateListOfLicensesToRemove2Error> ex)
{
    if (ex.Error.TryGetFotaV2Result(out var error))
    {
        // TODO: Handle 'error' of type FotaV2Result
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CreateListOfLicensesToRemove2Request](src/Verizon/Requests/SoftwareManagementLicensesV2/CreateListOfLicensesToRemove2Request.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V2ListOfLicensesToRemoveResult](src/Verizon/Models/V2ListOfLicensesToRemoveResult.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[CreateListOfLicensesToRemove2Error](src/Verizon/Errors/CreateListOfLicensesToRemove2Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;FotaV2SuccessResult&gt; DeleteListOfLicensesToRemove2(DeleteListOfLicensesToRemove2Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This endpoint allows user to delete a created cancel candidate device list.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SoftwareManagementLicensesV2.DeleteListOfLicensesToRemove2(
        new DeleteListOfLicensesToRemove2Request { Account = "0242078689-00001" });
    // TODO: Handle 'response' of type FotaV2SuccessResult
}
catch (ApiException<DeleteListOfLicensesToRemove2Error> ex)
{
    if (ex.Error.TryGetFotaV2Result(out var error))
    {
        // TODO: Handle 'error' of type FotaV2Result
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeleteListOfLicensesToRemove2Request](src/Verizon/Requests/SoftwareManagementLicensesV2/DeleteListOfLicensesToRemove2Request.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[FotaV2SuccessResult](src/Verizon/Models/FotaV2SuccessResult.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[DeleteListOfLicensesToRemove2Error](src/Verizon/Errors/DeleteListOfLicensesToRemove2Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V2LicenseSummary&gt; GetAccountLicenseStatus2(GetAccountLicenseStatus2Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The endpoint allows user to list license usage.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SoftwareManagementLicensesV2.GetAccountLicenseStatus2(
        new GetAccountLicenseStatus2Request { Account = "0000123456-00001", LastSeenDeviceId = "15-digit IMEI" });
    // TODO: Handle 'response' of type V2LicenseSummary
}
catch (ApiException<GetAccountLicenseStatus2Error> ex)
{
    if (ex.Error.TryGetFotaV2Result(out var error))
    {
        // TODO: Handle 'error' of type FotaV2Result
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetAccountLicenseStatus2Request](src/Verizon/Requests/SoftwareManagementLicensesV2/GetAccountLicenseStatus2Request.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V2LicenseSummary](src/Verizon/Models/V2LicenseSummary.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[GetAccountLicenseStatus2Error](src/Verizon/Errors/GetAccountLicenseStatus2Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V2ListOfLicensesToRemove&gt; ListLicensesToRemove2(ListLicensesToRemove2Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The license cancel endpoint allows user to list registered license cancellation candidate devices.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SoftwareManagementLicensesV2.ListLicensesToRemove2(new ListLicensesToRemove2Request
    {
        Account = "0242078689-00001",
    });
    // TODO: Handle 'response' of type V2ListOfLicensesToRemove
}
catch (ApiException<ListLicensesToRemove2Error> ex)
{
    if (ex.Error.TryGetFotaV2Result(out var error))
    {
        // TODO: Handle 'error' of type FotaV2Result
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ListLicensesToRemove2Request](src/Verizon/Requests/SoftwareManagementLicensesV2/ListLicensesToRemove2Request.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V2ListOfLicensesToRemove](src/Verizon/Models/V2ListOfLicensesToRemove.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[ListLicensesToRemove2Error](src/Verizon/Errors/ListLicensesToRemove2Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V2LicensesAssignedRemovedResult&gt; RemoveLicensesFromDevices2(RemoveLicensesFromDevices2Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This endpoint allows user to remove licenses from a list of devices.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SoftwareManagementLicensesV2.RemoveLicensesFromDevices2(
        new RemoveLicensesFromDevices2Request { Account = "0242078689-00001" });
    // TODO: Handle 'response' of type V2LicensesAssignedRemovedResult
}
catch (ApiException<RemoveLicensesFromDevices2Error> ex)
{
    if (ex.Error.TryGetFotaV2Result(out var error))
    {
        // TODO: Handle 'error' of type FotaV2Result
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[RemoveLicensesFromDevices2Request](src/Verizon/Requests/SoftwareManagementLicensesV2/RemoveLicensesFromDevices2Request.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V2LicensesAssignedRemovedResult](src/Verizon/Models/V2LicensesAssignedRemovedResult.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[RemoveLicensesFromDevices2Error](src/Verizon/Errors/RemoveLicensesFromDevices2Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## SoftwareManagementLicensesV3

> Source: [SoftwareManagementLicensesV3](src/Verizon/Api/SoftwareManagementLicensesV3.cs)

<details>
<summary><code>Task&lt;V3LicenseAssignedRemovedResult&gt; AssignLicensesToDevices3(AssignLicensesToDevices3Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This endpoint allows user to assign licenses to a list of devices.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SoftwareManagementLicensesV3.AssignLicensesToDevices3(
        new AssignLicensesToDevices3Request
        {
            Acc = "0000123456-00001",
            Body = new V3LicenseImei { DeviceList = ["15-digit IMEI", "15-digit IMEI"] },
        });
    // TODO: Handle 'response' of type V3LicenseAssignedRemovedResult
}
catch (ApiException<AssignLicensesToDevices3Error> ex)
{
    if (ex.Error.TryGetFotaV3Result(out var error))
    {
        // TODO: Handle 'error' of type FotaV3Result
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AssignLicensesToDevices3Request](src/Verizon/Requests/SoftwareManagementLicensesV3/AssignLicensesToDevices3Request.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V3LicenseAssignedRemovedResult](src/Verizon/Models/V3LicenseAssignedRemovedResult.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[AssignLicensesToDevices3Error](src/Verizon/Errors/AssignLicensesToDevices3Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V3LicenseSummary&gt; GetAccountLicensesStatus(GetAccountLicensesStatusRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The endpoint allows user to list license usage.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SoftwareManagementLicensesV3.GetAccountLicensesStatus(
        new GetAccountLicensesStatusRequest { Acc = "0000123456-00001", LastSeenDeviceId = "0" });
    // TODO: Handle 'response' of type V3LicenseSummary
}
catch (ApiException<GetAccountLicensesStatusError> ex)
{
    if (ex.Error.TryGetFotaV3Result(out var error))
    {
        // TODO: Handle 'error' of type FotaV3Result
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetAccountLicensesStatusRequest](src/Verizon/Requests/SoftwareManagementLicensesV3/GetAccountLicensesStatusRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V3LicenseSummary](src/Verizon/Models/V3LicenseSummary.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[GetAccountLicensesStatusError](src/Verizon/Errors/GetAccountLicensesStatusError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V3LicenseAssignedRemovedResult&gt; RemoveLicensesFromDevices3(RemoveLicensesFromDevices3Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This endpoint allows user to remove licenses from a list of devices.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SoftwareManagementLicensesV3.RemoveLicensesFromDevices3(
        new RemoveLicensesFromDevices3Request
        {
            Acc = "0000123456-00001",
            Body = new V3LicenseImei { DeviceList = ["15-digit IMEI", "15-digit IMEI", "15-digit IMEI"] },
        });
    // TODO: Handle 'response' of type V3LicenseAssignedRemovedResult
}
catch (ApiException<RemoveLicensesFromDevices3Error> ex)
{
    if (ex.Error.TryGetFotaV3Result(out var error))
    {
        // TODO: Handle 'error' of type FotaV3Result
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[RemoveLicensesFromDevices3Request](src/Verizon/Requests/SoftwareManagementLicensesV3/RemoveLicensesFromDevices3Request.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V3LicenseAssignedRemovedResult](src/Verizon/Models/V3LicenseAssignedRemovedResult.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[RemoveLicensesFromDevices3Error](src/Verizon/Errors/RemoveLicensesFromDevices3Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## SoftwareManagementReportsV1

> Source: [SoftwareManagementReportsV1](src/Verizon/Api/SoftwareManagementReportsV1.cs)

<details>
<summary><code>Task&lt;IReadOnlyList&lt;DeviceUpgradeHistory&gt;&gt; GetDeviceFirmwareUpgradeHistory(GetDeviceFirmwareUpgradeHistoryRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the upgrade history of the specified device from the previous six months.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SoftwareManagementReportsV1.GetDeviceFirmwareUpgradeHistory(
        new GetDeviceFirmwareUpgradeHistoryRequest { Account = "0242078689-00001", DeviceId = "900000000000001" });
    // TODO: Handle 'response' of type IReadOnlyList<DeviceUpgradeHistory>
}
catch (ApiException<GetDeviceFirmwareUpgradeHistoryError> ex)
{
    if (ex.Error.TryGetFotaV1Result(out var error))
    {
        // TODO: Handle 'error' of type FotaV1Result
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetDeviceFirmwareUpgradeHistoryRequest](src/Verizon/Requests/SoftwareManagementReportsV1/GetDeviceFirmwareUpgradeHistoryRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[DeviceUpgradeHistory](src/Verizon/Models/DeviceUpgradeHistory.cs)&gt;</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[GetDeviceFirmwareUpgradeHistoryError](src/Verizon/Errors/GetDeviceFirmwareUpgradeHistoryError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeviceListQueryResult&gt; ListAccountDevices(ListAccountDevicesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns an array of all devices in the specified account. Each device object includes information needed for managing firmware, including the device make and model, MDN and IMEI, and current firmware version.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SoftwareManagementReportsV1.ListAccountDevices(new ListAccountDevicesRequest
    {
        Account = "0242078689-00001",
        StartIndex = "some example string",
    });
    // TODO: Handle 'response' of type DeviceListQueryResult
}
catch (ApiException<ListAccountDevicesError> ex)
{
    if (ex.Error.TryGetFotaV1Result(out var error))
    {
        // TODO: Handle 'error' of type FotaV1Result
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ListAccountDevicesRequest](src/Verizon/Requests/SoftwareManagementReportsV1/ListAccountDevicesRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeviceListQueryResult](src/Verizon/Models/DeviceListQueryResult.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[ListAccountDevicesError](src/Verizon/Errors/ListAccountDevicesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UpgradeListQueryResult&gt; ListUpgradesForSpecifiedStatus(ListUpgradesForSpecifiedStatusRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a list of all upgrades with a specified status.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SoftwareManagementReportsV1.ListUpgradesForSpecifiedStatus(
        new ListUpgradesForSpecifiedStatusRequest
        {
            Account = "0242078689-00001",
            UpgradeStatus = UpgradeStatus.RequestPending,
            StartIndex = "some example string",
        });
    // TODO: Handle 'response' of type UpgradeListQueryResult
}
catch (ApiException<ListUpgradesForSpecifiedStatusError> ex)
{
    if (ex.Error.TryGetFotaV1Result(out var error))
    {
        // TODO: Handle 'error' of type FotaV1Result
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ListUpgradesForSpecifiedStatusRequest](src/Verizon/Requests/SoftwareManagementReportsV1/ListUpgradesForSpecifiedStatusRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UpgradeListQueryResult](src/Verizon/Models/UpgradeListQueryResult.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[ListUpgradesForSpecifiedStatusError](src/Verizon/Errors/ListUpgradesForSpecifiedStatusError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## SoftwareManagementReportsV2

> Source: [SoftwareManagementReportsV2](src/Verizon/Api/SoftwareManagementReportsV2.cs)

<details>
<summary><code>Task&lt;V2CampaignDevice&gt; GetCampaignDeviceStatus(GetCampaignDeviceStatusRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The report endpoint allows user to get the full list of device of a campaign.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SoftwareManagementReportsV2.GetCampaignDeviceStatus(new GetCampaignDeviceStatusRequest
    {
        Account = "0000123456-00001",
        CampaignId = "60b5d639-ccdc-4db8-8824-069bd94c95bf",
        LastSeenDeviceId = "15-digit IMEI",
    });
    // TODO: Handle 'response' of type V2CampaignDevice
}
catch (ApiException<GetCampaignDeviceStatusError> ex)
{
    if (ex.Error.TryGetFotaV2Result(out var error))
    {
        // TODO: Handle 'error' of type FotaV2Result
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetCampaignDeviceStatusRequest](src/Verizon/Requests/SoftwareManagementReportsV2/GetCampaignDeviceStatusRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V2CampaignDevice](src/Verizon/Models/V2CampaignDevice.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[GetCampaignDeviceStatusError](src/Verizon/Errors/GetCampaignDeviceStatusError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V2CampaignHistory&gt; GetCampaignHistoryByStatus(GetCampaignHistoryByStatusRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The report endpoint allows user to get campaign history of an account for specified status.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SoftwareManagementReportsV2.GetCampaignHistoryByStatus(
        new GetCampaignHistoryByStatusRequest
        {
            Account = "0000123456-00001",
            CampaignStatus = "some example string",
            LastSeenCampaignId = "60b5d639-ccdc-4db8-8824-069bd94c95bf",
        });
    // TODO: Handle 'response' of type V2CampaignHistory
}
catch (ApiException<GetCampaignHistoryByStatusError> ex)
{
    if (ex.Error.TryGetFotaV2Result(out var error))
    {
        // TODO: Handle 'error' of type FotaV2Result
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetCampaignHistoryByStatusRequest](src/Verizon/Requests/SoftwareManagementReportsV2/GetCampaignHistoryByStatusRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V2CampaignHistory](src/Verizon/Models/V2CampaignHistory.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[GetCampaignHistoryByStatusError](src/Verizon/Errors/GetCampaignHistoryByStatusError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;DeviceSoftwareUpgrade&gt;&gt; GetDeviceFirmwareUpgradeHistory2(GetDeviceFirmwareUpgradeHistory2Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The endpoint allows user to get software upgrade history of a device based on device IMEI.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SoftwareManagementReportsV2.GetDeviceFirmwareUpgradeHistory2(
        new GetDeviceFirmwareUpgradeHistory2Request { Account = "0000123456-00001", DeviceId = "990013907835573" });
    // TODO: Handle 'response' of type IReadOnlyList<DeviceSoftwareUpgrade>
}
catch (ApiException<GetDeviceFirmwareUpgradeHistory2Error> ex)
{
    if (ex.Error.TryGetFotaV2Result(out var error))
    {
        // TODO: Handle 'error' of type FotaV2Result
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetDeviceFirmwareUpgradeHistory2Request](src/Verizon/Requests/SoftwareManagementReportsV2/GetDeviceFirmwareUpgradeHistory2Request.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[DeviceSoftwareUpgrade](src/Verizon/Models/DeviceSoftwareUpgrade.cs)&gt;</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[GetDeviceFirmwareUpgradeHistory2Error](src/Verizon/Errors/GetDeviceFirmwareUpgradeHistory2Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V2AccountDeviceList&gt; ListAccountDevices2(ListAccountDevices2Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The device endpoint gets devices information of an account.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SoftwareManagementReportsV2.ListAccountDevices2(new ListAccountDevices2Request
    {
        Account = "0000123456-00001",
        LastSeenDeviceId = "15-digit IMEI",
        DistributionType = "HTTP",
    });
    // TODO: Handle 'response' of type V2AccountDeviceList
}
catch (ApiException<ListAccountDevices2Error> ex)
{
    if (ex.Error.TryGetFotaV2Result(out var error))
    {
        // TODO: Handle 'error' of type FotaV2Result
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ListAccountDevices2Request](src/Verizon/Requests/SoftwareManagementReportsV2/ListAccountDevices2Request.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V2AccountDeviceList](src/Verizon/Models/V2AccountDeviceList.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[ListAccountDevices2Error](src/Verizon/Errors/ListAccountDevices2Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;SoftwarePackage&gt;&gt; ListAvailableSoftware(ListAvailableSoftwareRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This endpoint allows user to list a certain type of software of an account.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SoftwareManagementReportsV2.ListAvailableSoftware(new ListAvailableSoftwareRequest
    {
        Account = "0000123456-00001",
        DistributionType = "HTTP",
    });
    // TODO: Handle 'response' of type IReadOnlyList<SoftwarePackage>
}
catch (ApiException<ListAvailableSoftwareError> ex)
{
    if (ex.Error.TryGetFotaV2Result(out var error))
    {
        // TODO: Handle 'error' of type FotaV2Result
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ListAvailableSoftwareRequest](src/Verizon/Requests/SoftwareManagementReportsV2/ListAvailableSoftwareRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[SoftwarePackage](src/Verizon/Models/SoftwarePackage.cs)&gt;</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[ListAvailableSoftwareError](src/Verizon/Errors/ListAvailableSoftwareError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## SoftwareManagementReportsV3

> Source: [SoftwareManagementReportsV3](src/Verizon/Api/SoftwareManagementReportsV3.cs)

<details>
<summary><code>Task&lt;V3CampaignDevice&gt; GetCampaignDeviceStatus2(GetCampaignDeviceStatus2Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieve a list of all devices in a campaign and the status of each device.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SoftwareManagementReportsV3.GetCampaignDeviceStatus2(new GetCampaignDeviceStatus2Request
    {
        Acc = "0000123456-00001",
        CampaignId = "f858b8c4-2153-11ec-8c44-aeb16d1aa652",
        LastSeenDeviceId = "15-digit IMEI",
    });
    // TODO: Handle 'response' of type V3CampaignDevice
}
catch (ApiException<GetCampaignDeviceStatus2Error> ex)
{
    if (ex.Error.TryGetFotaV3Result(out var error))
    {
        // TODO: Handle 'error' of type FotaV3Result
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetCampaignDeviceStatus2Request](src/Verizon/Requests/SoftwareManagementReportsV3/GetCampaignDeviceStatus2Request.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V3CampaignDevice](src/Verizon/Models/V3CampaignDevice.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[GetCampaignDeviceStatus2Error](src/Verizon/Errors/GetCampaignDeviceStatus2Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V3CampaignHistory&gt; GetCampaignHistoryByStatus2(GetCampaignHistoryByStatus2Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieve a list of campaigns for an account that have a specified campaign status.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SoftwareManagementReportsV3.GetCampaignHistoryByStatus2(
        new GetCampaignHistoryByStatus2Request
        {
            Acc = "0000123456-00001",
            CampaignStatus = CampaignStatus.CampaignRequestPending,
            LastSeenCampaignId = "60b5d639-ccdc-4db8-8824-069bd94c95bf",
        });
    // TODO: Handle 'response' of type V3CampaignHistory
}
catch (ApiException<GetCampaignHistoryByStatus2Error> ex)
{
    if (ex.Error.TryGetFotaV3Result(out var error))
    {
        // TODO: Handle 'error' of type FotaV3Result
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetCampaignHistoryByStatus2Request](src/Verizon/Requests/SoftwareManagementReportsV3/GetCampaignHistoryByStatus2Request.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V3CampaignHistory](src/Verizon/Models/V3CampaignHistory.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[GetCampaignHistoryByStatus2Error](src/Verizon/Errors/GetCampaignHistoryByStatus2Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;DeviceFirmwareUpgrade&gt;&gt; GetDeviceFirmwareUpgradeHistory3(GetDeviceFirmwareUpgradeHistory3Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieve campaign history for a specific device.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SoftwareManagementReportsV3.GetDeviceFirmwareUpgradeHistory3(
        new GetDeviceFirmwareUpgradeHistory3Request { Acc = "0000123456-00001", DeviceId = "15-digit IMEI" });
    // TODO: Handle 'response' of type IReadOnlyList<DeviceFirmwareUpgrade>
}
catch (ApiException<GetDeviceFirmwareUpgradeHistory3Error> ex)
{
    if (ex.Error.TryGetFotaV3Result(out var error))
    {
        // TODO: Handle 'error' of type FotaV3Result
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetDeviceFirmwareUpgradeHistory3Request](src/Verizon/Requests/SoftwareManagementReportsV3/GetDeviceFirmwareUpgradeHistory3Request.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[DeviceFirmwareUpgrade](src/Verizon/Models/DeviceFirmwareUpgrade.cs)&gt;</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[GetDeviceFirmwareUpgradeHistory3Error](src/Verizon/Errors/GetDeviceFirmwareUpgradeHistory3Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## SoftwareManagementSubscriptionsV1

> Source: [SoftwareManagementSubscriptionsV1](src/Verizon/Api/SoftwareManagementSubscriptionsV1.cs)

<details>
<summary><code>Task&lt;AccountLicenseInfo&gt; GetAccountLicenseStatus(GetAccountLicenseStatusRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns information about an account's Software Management Services licenses and a list of licensed devices.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SoftwareManagementSubscriptionsV1.GetAccountLicenseStatus(
        new GetAccountLicenseStatusRequest { Account = "0402196254-00001", StartIndex = "0" });
    // TODO: Handle 'response' of type AccountLicenseInfo
}
catch (ApiException<GetAccountLicenseStatusError> ex)
{
    if (ex.Error.TryGetFotaV1Result(out var error))
    {
        // TODO: Handle 'error' of type FotaV1Result
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetAccountLicenseStatusRequest](src/Verizon/Requests/SoftwareManagementSubscriptionsV1/GetAccountLicenseStatusRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AccountLicenseInfo](src/Verizon/Models/AccountLicenseInfo.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[GetAccountLicenseStatusError](src/Verizon/Errors/GetAccountLicenseStatusError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V1AccountSubscription&gt; GetAccountSubscriptionStatus(GetAccountSubscriptionStatusRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This subscriptions endpoint retrieves an account's current Software Management Service subscription status.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SoftwareManagementSubscriptionsV1.GetAccountSubscriptionStatus(
        new GetAccountSubscriptionStatusRequest { Account = "0402196254-00001" });
    // TODO: Handle 'response' of type V1AccountSubscription
}
catch (ApiException<GetAccountSubscriptionStatusError> ex)
{
    if (ex.Error.TryGetFotaV1Result(out var error))
    {
        // TODO: Handle 'error' of type FotaV1Result
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetAccountSubscriptionStatusRequest](src/Verizon/Requests/SoftwareManagementSubscriptionsV1/GetAccountSubscriptionStatusRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1AccountSubscription](src/Verizon/Models/V1AccountSubscription.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[GetAccountSubscriptionStatusError](src/Verizon/Errors/GetAccountSubscriptionStatusError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## SoftwareManagementSubscriptionsV2

> Source: [SoftwareManagementSubscriptionsV2](src/Verizon/Api/SoftwareManagementSubscriptionsV2.cs)

<details>
<summary><code>Task&lt;FotaV2Subscription&gt; GetAccountSubscriptionStatus2(GetAccountSubscriptionStatus2Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This endpoint retrieves a FOTA subscription by account.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SoftwareManagementSubscriptionsV2.GetAccountSubscriptionStatus2(
        new GetAccountSubscriptionStatus2Request { Account = "0000123456-00001" });
    // TODO: Handle 'response' of type FotaV2Subscription
}
catch (ApiException<GetAccountSubscriptionStatus2Error> ex)
{
    if (ex.Error.TryGetFotaV2Result(out var error))
    {
        // TODO: Handle 'error' of type FotaV2Result
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetAccountSubscriptionStatus2Request](src/Verizon/Requests/SoftwareManagementSubscriptionsV2/GetAccountSubscriptionStatus2Request.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[FotaV2Subscription](src/Verizon/Models/FotaV2Subscription.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[GetAccountSubscriptionStatus2Error](src/Verizon/Errors/GetAccountSubscriptionStatus2Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## SoftwareManagementSubscriptionsV3

> Source: [SoftwareManagementSubscriptionsV3](src/Verizon/Api/SoftwareManagementSubscriptionsV3.cs)

<details>
<summary><code>Task&lt;FotaV3Subscription&gt; GetAccountSubscriptionStatus3(GetAccountSubscriptionStatus3Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This endpoint retrieves a FOTA subscription by account.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SoftwareManagementSubscriptionsV3.GetAccountSubscriptionStatus3(
        new GetAccountSubscriptionStatus3Request { Acc = "0000123456-00001" });
    // TODO: Handle 'response' of type FotaV3Subscription
}
catch (ApiException<GetAccountSubscriptionStatus3Error> ex)
{
    if (ex.Error.TryGetFotaV3Result(out var error))
    {
        // TODO: Handle 'error' of type FotaV3Result
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetAccountSubscriptionStatus3Request](src/Verizon/Requests/SoftwareManagementSubscriptionsV3/GetAccountSubscriptionStatus3Request.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[FotaV3Subscription](src/Verizon/Models/FotaV3Subscription.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[GetAccountSubscriptionStatus3Error](src/Verizon/Errors/GetAccountSubscriptionStatus3Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Targets

> Source: [Targets](src/Verizon/Api/Targets.cs)

<details>
<summary><code>Task&lt;CreateIoTApplicationResponse&gt; CreateAzureCentralIoTApplication(CreateAzureCentralIoTApplicationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Deploy a new Azure IoT Central application based on the Verizon ARM template within the specified Azure Active Directory account.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Targets.CreateAzureCentralIoTApplication(new CreateAzureCentralIoTApplicationRequest
    {
        BillingaccountId = "some example string",
        Body = new CreateIoTApplicationRequest
        {
            AppName = "newarmapp1",
            BillingAccountId = "0000123456-00001",
            ClientId = "UUID",
            ClientSecret = "client secret",
            EmailIDs = "email@domain.com",
            Resourcegroup = "Myresourcegroup",
            SampleIoTcApp = "{app ID}",
            SubscriptionId = "{subscription ID}",
            TenantId = "{tenant ID}",
        },
    });
    // TODO: Handle 'response' of type CreateIoTApplicationResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CreateAzureCentralIoTApplicationRequest](src/Verizon/Requests/Targets/CreateAzureCentralIoTApplicationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CreateIoTApplicationResponse](src/Verizon/Models/CreateIoTApplicationResponse.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Verizon/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Target&gt; CreateTarget(CreateTargetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Define a target to receive data streams, alerts, or callbacks. After creating the target resource, use its ID in a subscription to set up a data stream.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Targets.CreateTarget(new CreateTargetOperationRequest
    {
        Body = new CreateTargetRequest
        {
            Accountidentifier = new AccountIdentifier { Billingaccountid = "0000000000-00001" },
            Billingaccountid = "0000000000-00001",
            Kind = "ts.target",
            Address = "https://your_IoT_Central_Application.azureiotcentral.com",
            Addressscheme = "streamazureiot",
            Fields = new CreateTargetRequestFields
            {
                Httpheaders = new FieldsHttpHeaders
                {
                    Authorization = "SharedAccessSignature sr=d1f9b6bf-1380-41f6-b757-d9805e48392b&sig=EF5tnXClw3MWkb84OkIOUhMH%2FaS1DRD2nXT69QR8RD8%3D&skn=TSCCtoken&se=1648827260410",
                },
                Devicetypes = ["cHeAssetTracker", "cHeAssetTrackerV2", "tgAssetTracker", "tgAssetTrackerV2"],
            },
        },
    });
    // TODO: Handle 'response' of type Target
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CreateTargetOperationRequest](src/Verizon/Requests/Targets/CreateTargetOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Target](src/Verizon/Models/Target.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Verizon/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task DeleteTarget(DeleteTargetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Remove a target from a ThingSpace account.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.Targets.DeleteTarget(new DeleteTargetOperationRequest
    {
        Body = new DeleteTargetRequest
        {
            Accountidentifier = new AccountIdentifier { Billingaccountid = "0000000000-00001" },
            Resourceidentifier = new ResourceIdentifier { Id = "2e61a17d-8fd1-6816-e995-e4c2528bf535" },
        },
    });
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeleteTargetOperationRequest](src/Verizon/Requests/Targets/DeleteTargetOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Verizon/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GenerateExternalIdResult&gt; GenerateTargetExternalId(GenerateTargetExternalIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Create a unique string that ThingSpace will pass to AWS for increased security.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Targets.GenerateTargetExternalId(new GenerateTargetExternalIdRequest
    {
        Body = new GenerateExternalIdRequest
        {
            Accountidentifier = new AccountIdentifier { Billingaccountid = "0000000000-00001" },
        },
    });
    // TODO: Handle 'response' of type GenerateExternalIdResult
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GenerateTargetExternalIdRequest](src/Verizon/Requests/Targets/GenerateTargetExternalIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GenerateExternalIdResult](src/Verizon/Models/GenerateExternalIdResult.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Verizon/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;Target&gt;&gt; QueryTarget(QueryTargetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Search for targets by property values. Returns an array of all matching target resources.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Targets.QueryTarget(new QueryTargetOperationRequest
    {
        Body = new QueryTargetRequest
        {
            Accountidentifier = new AccountIdentifier { Billingaccountid = "1223334444-00001" },
            Resourceidentifier = new ResourceIdentifier { Id = "dd1682d3-2d80-cefc-f3ee-25154800beff" },
        },
    });
    // TODO: Handle 'response' of type IReadOnlyList<Target>
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[QueryTargetOperationRequest](src/Verizon/Requests/Targets/QueryTargetOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[Target](src/Verizon/Models/Target.cs)&gt;</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Verizon/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## ThingSpaceQualityOfServiceApiActions

> Source: [ThingSpaceQualityOfServiceApiActions](src/Verizon/Api/ThingSpaceQualityOfServiceApiActions.cs)

<details>
<summary><code>Task&lt;Success201&gt; CreateAThingSpaceQualityOfServiceApiSubscription(CreateAThingSpaceQualityOfServiceApiSubscriptionRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates a QoS elevation subscription ID and activates the subscription.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ThingSpaceQualityOfServiceApiActions.CreateAThingSpaceQualityOfServiceApiSubscription(
        new CreateAThingSpaceQualityOfServiceApiSubscriptionRequest
        {
            Body = new SubscribeRequest
            {
                AccountName = "some example string",
                DeviceInfo = [new QoSdeviceInfo { DeviceId = new QoSdeviceId(), FlowInfo = [new FlowInfo()] }],
            },
        });
    // TODO: Handle 'response' of type Success201
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CreateAThingSpaceQualityOfServiceApiSubscriptionRequest](src/Verizon/Requests/ThingSpaceQualityOfServiceApiActions/CreateAThingSpaceQualityOfServiceApiSubscriptionRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Success201](src/Verizon/Models/Success201.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Verizon/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Success201&gt; StopAThingSpaceQualityOfServiceApiSubscription(StopAThingSpaceQualityOfServiceApiSubscriptionRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Stops an active ThingSpace Quality of Service API subscription using the account name and the subscription ID.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ThingSpaceQualityOfServiceApiActions.StopAThingSpaceQualityOfServiceApiSubscription(
        new StopAThingSpaceQualityOfServiceApiSubscriptionRequest
        {
            AccountName = "0000123456-00001",
            QosSubscriptionId = "QoS subscription ID",
        });
    // TODO: Handle 'response' of type Success201
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[StopAThingSpaceQualityOfServiceApiSubscriptionRequest](src/Verizon/Requests/ThingSpaceQualityOfServiceApiActions/StopAThingSpaceQualityOfServiceApiSubscriptionRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Success201](src/Verizon/Models/Success201.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Verizon/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## UpdatePricePlanTriggers

> Source: [UpdatePricePlanTriggers](src/Verizon/Api/UpdatePricePlanTriggers.cs)

<details>
<summary><code>Task&lt;TriggerResponse&gt; UpdateTriggerRules(UpdateTriggerRulesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates a usage trigger at the account level, device level or a price plan trigger for all devices on the account

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.UpdatePricePlanTriggers.UpdateTriggerRules(new UpdateTriggerRulesRequest
    {
        Body = new AccountLevelUpdateTriggerRequest
        {
            TriggerId = "b9cc1da6-ffff-eeee-gggg-7eba8859ab5e",
            TriggerName = "name of the trigger",
            EcpdId = "Verizon profile ID",
            TriggerCategory = TriggerCategory.AccountUsage,
            DataTrigger = new DataTrigger1(),
            Notification = new Notificationarray
            {
                NotificationType = "PerEvent",
                Callback = true,
                EmailNotification = false,
                NotificationGroupName = "NotificationGroupName",
                NotificationFrequencyFactor = 3,
                NotificationFrequencyInterval = "Daily",
                ExternalEmailRecipients = "ExternalEmailRecipients",
                SmsNotification = true,
                SmsNumbers = [
                    new Cellphonenumber { Number = "10-digit mobile number", Carrier = "mobile service provider" },
                    new Cellphonenumber { Number = "10-digit mobile number", Carrier = "mobile service provider" },
                ],
                Reminder = true,
                Severity = "Notice",
            },
            Active = Active.True,
        },
    });
    // TODO: Handle 'response' of type TriggerResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UpdateTriggerRulesRequest](src/Verizon/Requests/UpdatePricePlanTriggers/UpdateTriggerRulesRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TriggerResponse](src/Verizon/Models/TriggerResponse.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Verizon/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## UpdateTriggers

> Source: [UpdateTriggers](src/Verizon/Api/UpdateTriggers.cs)

<details>
<summary><code>Task&lt;Success&gt; UpdateAllAvailableTriggers(UpdateAllAvailableTriggersRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates the promotional triggers for pseudo-MDN.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.UpdateTriggers.UpdateAllAvailableTriggers(new UpdateAllAvailableTriggersRequest());
    // TODO: Handle 'response' of type Success
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UpdateAllAvailableTriggersRequest](src/Verizon/Requests/UpdateTriggers/UpdateAllAvailableTriggersRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Success](src/Verizon/Models/Success.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Verizon/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## UsageTriggerManagement

> Source: [UsageTriggerManagement](src/Verizon/Api/UsageTriggerManagement.cs)

<details>
<summary><code>Task&lt;UsageTriggerResponse&gt; CreateNewTrigger(CreateNewTriggerRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Create a new usage trigger, which will send an alert when the number of device location service transactions reaches a specified percentage of the monthly subscription amount.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.UsageTriggerManagement.CreateNewTrigger(new CreateNewTriggerRequest
    {
        Body = new UsageTriggerAddRequest
        {
            TriggerName = "95% usage alert",
            AccountName = "0212312345-00001",
            ServiceName = ServiceName.Location,
            ThresholdValue = "95",
            AllowExcess = true,
            SendSmsNotification = true,
            SmsPhoneNumbers = "5551231234",
            SendEmailNotification = true,
            EmailAddresses = "you@theinternet.com",
        },
    });
    // TODO: Handle 'response' of type UsageTriggerResponse
}
catch (ApiException<CreateNewTriggerError> ex)
{
    if (ex.Error.TryGetDeviceLocationResult(out var error))
    {
        // TODO: Handle 'error' of type DeviceLocationResult
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CreateNewTriggerRequest](src/Verizon/Requests/UsageTriggerManagement/CreateNewTriggerRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UsageTriggerResponse](src/Verizon/Models/UsageTriggerResponse.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[CreateNewTriggerError](src/Verizon/Errors/CreateNewTriggerError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeviceLocationSuccessResult&gt; DeleteTrigger(DeleteTriggerRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

eletes the specified usage trigger from the given account

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.UsageTriggerManagement.DeleteTrigger(new DeleteTriggerRequest
    {
        AccountName = "0212312345-00001",
        TriggerId = "595f5c44-c31c-4552-8670-020a1545a84d",
    });
    // TODO: Handle 'response' of type DeviceLocationSuccessResult
}
catch (ApiException<DeleteTriggerError> ex)
{
    if (ex.Error.TryGetDeviceLocationResult(out var error))
    {
        // TODO: Handle 'error' of type DeviceLocationResult
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeleteTriggerRequest](src/Verizon/Requests/UsageTriggerManagement/DeleteTriggerRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeviceLocationSuccessResult](src/Verizon/Models/DeviceLocationSuccessResult.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[DeleteTriggerError](src/Verizon/Errors/DeleteTriggerError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UsageTriggerResponse&gt; UpdateTrigger(UpdateTriggerOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Update an existing usage trigger

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.UsageTriggerManagement.UpdateTrigger(new UpdateTriggerOperationRequest
    {
        TriggerId = "595f5c44-c31c-4552-8670-020a1545a84d",
        Body = new UsageTriggerUpdateRequest { AccountName = "1000012345-00001", ThresholdValue = "95" },
    });
    // TODO: Handle 'response' of type UsageTriggerResponse
}
catch (ApiException<UpdateTriggerError> ex)
{
    if (ex.Error.TryGetDeviceLocationResult(out var error))
    {
        // TODO: Handle 'error' of type DeviceLocationResult
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UpdateTriggerOperationRequest](src/Verizon/Requests/UsageTriggerManagement/UpdateTriggerOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UsageTriggerResponse](src/Verizon/Models/UsageTriggerResponse.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[UpdateTriggerError](src/Verizon/Errors/UpdateTriggerError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## WirelessNetworkPerformance

> Source: [WirelessNetworkPerformance](src/Verizon/Api/WirelessNetworkPerformance.cs)

<details>
<summary><code>Task&lt;WnpRequestResponse&gt; DeviceExperience30DaysHistory(DeviceExperience30DaysHistoryRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

A report of a specific device's service scores over a 30 day period.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.WirelessNetworkPerformance.DeviceExperience30DaysHistory(
        new DeviceExperience30DaysHistoryRequest
        {
            Body = new GetDeviceExperienceScoreHistoryRequest
            {
                AccountName = "0000123456-00001",
                DeviceId = new DeviceIdentifier { Kind = "iccid", Id = "01234567899876543210", Mdn = "0123456789" },
            },
        });
    // TODO: Handle 'response' of type WnpRequestResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeviceExperience30DaysHistoryRequest](src/Verizon/Requests/WirelessNetworkPerformance/DeviceExperience30DaysHistoryRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[WnpRequestResponse](src/Verizon/Models/WnpRequestResponse.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Verizon/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;WnpRequestResponse&gt; DeviceExperienceBulkLatest(DeviceExperienceBulkLatestRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Run a report to view the latest device experience score for specific devices.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.WirelessNetworkPerformance.DeviceExperienceBulkLatest(
        new DeviceExperienceBulkLatestRequest
        {
            Body = new GetDeviceExperienceScoreBulkRequest
            {
                AccountName = "0000123456-00001",
                DeviceList = [new DeviceIdentifier { Kind = "iccid", Id = "01234567899876543210", Mdn = "0123456789" }],
            },
        });
    // TODO: Handle 'response' of type WnpRequestResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeviceExperienceBulkLatestRequest](src/Verizon/Requests/WirelessNetworkPerformance/DeviceExperienceBulkLatestRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[WnpRequestResponse](src/Verizon/Models/WnpRequestResponse.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Verizon/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;WnpRequestResponse&gt; Domestic4GAnd5GNationwideNetworkCoverage(Domestic4GAnd5GNationwideNetworkCoverageRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Run a report for FWA Address qualification or to determine network types available and available coverage. Network types covered include: CAT-M, NB-IOT, LTE, LTE-AWS, 5GNW, MMWAVE and C-BAND.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.WirelessNetworkPerformance.Domestic4GAnd5GNationwideNetworkCoverage(
        new Domestic4GAnd5GNationwideNetworkCoverageRequest
        {
            Body = new GetWirelessCoverageRequest
            {
                AccountName = "0000123456-00001",
                RequestType = "FWA",
                LocationType = "ADDRESS",
                Locations = new Locationscoord(),
                NetworkTypesList = [new NetworkTypeObject { NetworkType = "LTE" }],
            },
        });
    // TODO: Handle 'response' of type WnpRequestResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[Domestic4GAnd5GNationwideNetworkCoverageRequest](src/Verizon/Requests/WirelessNetworkPerformance/Domestic4GAnd5GNationwideNetworkCoverageRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[WnpRequestResponse](src/Verizon/Models/WnpRequestResponse.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Verizon/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;WnpRequestResponse&gt; NearRealTimeNetworkConditions(NearRealTimeNetworkConditionsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

WNP Query for current network condition.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.WirelessNetworkPerformance.NearRealTimeNetworkConditions(
        new NearRealTimeNetworkConditionsRequest
        {
            Body = new GetNetworkConditionsRequest
            {
                AccountName = "0000123456-00001",
                LocationType = "LONGLAT",
                Coordinates = new Coordinates { Latitude = "-33.84819", Longitude = "151.22049" },
            },
        });
    // TODO: Handle 'response' of type WnpRequestResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[NearRealTimeNetworkConditionsRequest](src/Verizon/Requests/WirelessNetworkPerformance/NearRealTimeNetworkConditionsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[WnpRequestResponse](src/Verizon/Models/WnpRequestResponse.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Verizon/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;WnpRequestResponse&gt; SiteProximity(SiteProximityRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Identify the direction and general distance of nearby cell sites and the technology supported by the equipment.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.WirelessNetworkPerformance.SiteProximity(new SiteProximityRequest
    {
        Body = new GetNetworkConditionsRequest
        {
            AccountName = "0000123456-00001",
            LocationType = "LONGLAT",
            Coordinates = new Coordinates { Latitude = "-33.84819", Longitude = "151.22049" },
        },
    });
    // TODO: Handle 'response' of type WnpRequestResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SiteProximityRequest](src/Verizon/Requests/WirelessNetworkPerformance/SiteProximityRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[WnpRequestResponse](src/Verizon/Models/WnpRequestResponse.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Verizon/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## DeviceRoleController

> Source: [DeviceRoleController](src/Verizon/Api/DeviceRoleController.cs)

<details>
<summary><code>Task&lt;IReadOnlyList&lt;DeviceRole&gt;&gt; GetAclRulesByVendorId(GetAclRulesByVendorIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This API allows the user to get the access control rules defined for them.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DeviceRoleController.GetAclRulesByVendorId(new GetAclRulesByVendorIdRequest
    {
        VendorId = "TestVendor",
    });
    // TODO: Handle 'response' of type IReadOnlyList<DeviceRole>
}
catch (ApiException<GetAclRulesByVendorIdError> ex)
{
    if (ex.Error.TryGetString(out var error))
    {
        // TODO: Handle 'error' of type string
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetAclRulesByVendorIdRequest](src/Verizon/Requests/DeviceRoleController/GetAclRulesByVendorIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[DeviceRole](src/Verizon/Models/DeviceRole.cs)&gt;</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[GetAclRulesByVendorIdError](src/Verizon/Errors/GetAclRulesByVendorIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## EUiccDeviceProfileManagement

> Source: [EUiccDeviceProfileManagement](src/Verizon/Api/EUiccDeviceProfileManagement.cs)

<details>
<summary><code>Task&lt;RequestResponse&gt; DeleteLocalProfile(DeleteLocalProfileRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Delete a local profile from eUICC devices. If the local profile is enabled, it will first be disabled and the boot or default profile will be enabled.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.EUiccDeviceProfileManagement.DeleteLocalProfile(new DeleteLocalProfileRequest
    {
        Body = new ProfileChangeStateRequest
        {
            Devices = [
                new DeviceList
                {
                    DeviceIds = [
                        new DeviceId { Id = "678912789123453456784008666456", Kind = "eid" },
                        new DeviceId { Id = "78425989148000000840", Kind = "iccid" },
                    ],
                },
            ],
            AccountName = "1223334444-00001",
            SmsrOid = "1.3.6.1.4.1.31746.1.500.200.101.5",
        },
    });
    // TODO: Handle 'response' of type RequestResponse
}
catch (ApiException<DeleteLocalProfileError> ex)
{
    if (ex.Error.TryGetRestErrorResponse(out var error))
    {
        // TODO: Handle 'error' of type RestErrorResponse
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeleteLocalProfileRequest](src/Verizon/Requests/EUiccDeviceProfileManagement/DeleteLocalProfileRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RequestResponse](src/Verizon/Models/RequestResponse.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[DeleteLocalProfileError](src/Verizon/Errors/DeleteLocalProfileError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RequestResponse&gt; DisableLocalProfile(DisableLocalProfileRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Disable a local profile on eUICC devices. The default or boot profile will become the enabled profile.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.EUiccDeviceProfileManagement.DisableLocalProfile(new DisableLocalProfileRequest
    {
        Body = new ProfileChangeStateRequest
        {
            Devices = [
                new DeviceList
                {
                    DeviceIds = [
                        new DeviceId { Id = "678912789123453456784008666456", Kind = "eid" },
                        new DeviceId { Id = "78425989148000000840", Kind = "iccid" },
                    ],
                },
            ],
            AccountName = "1223334444-00001",
            SmsrOid = "1.3.6.1.4.1.31746.1.500.200.101.5",
        },
    });
    // TODO: Handle 'response' of type RequestResponse
}
catch (ApiException<DisableLocalProfileError> ex)
{
    if (ex.Error.TryGetRestErrorResponse(out var error))
    {
        // TODO: Handle 'error' of type RestErrorResponse
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DisableLocalProfileRequest](src/Verizon/Requests/EUiccDeviceProfileManagement/DisableLocalProfileRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RequestResponse](src/Verizon/Models/RequestResponse.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[DisableLocalProfileError](src/Verizon/Errors/DisableLocalProfileError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeviceManagementResult&gt; DownloadLocalProfileToDisable(DownloadLocalProfileToDisableRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Downloads an eUICC local profile to devices and leaves the profile disabled.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.EUiccDeviceProfileManagement.DownloadLocalProfileToDisable(
        new DownloadLocalProfileToDisableRequest
        {
            Body = new ProfileChangeStateRequest
            {
                Devices = [
                    new DeviceList
                    {
                        DeviceIds = [
                            new DeviceId { Id = "678912789123453456784008666456", Kind = "eid" },
                            new DeviceId { Id = "78425989148000000840", Kind = "iccid" },
                        ],
                    },
                ],
                AccountName = "1223334444-00001",
                SmsrOid = "1.3.6.1.4.1.31746.1.500.200.101.5",
            },
        });
    // TODO: Handle 'response' of type DeviceManagementResult
}
catch (ApiException<DownloadLocalProfileToDisableError> ex)
{
    if (ex.Error.TryGetConnectivityManagementResult(out var error))
    {
        // TODO: Handle 'error' of type ConnectivityManagementResult
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DownloadLocalProfileToDisableRequest](src/Verizon/Requests/EUiccDeviceProfileManagement/DownloadLocalProfileToDisableRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeviceManagementResult](src/Verizon/Models/DeviceManagementResult.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[DownloadLocalProfileToDisableError](src/Verizon/Errors/DownloadLocalProfileToDisableError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeviceManagementResult&gt; DownloadLocalProfileToEnable(DownloadLocalProfileToEnableRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Downloads an eUICC local profile to devices and enables the profile.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.EUiccDeviceProfileManagement.DownloadLocalProfileToEnable(
        new DownloadLocalProfileToEnableRequest
        {
            Body = new ProfileChangeStateRequest
            {
                Devices = [
                    new DeviceList
                    {
                        DeviceIds = [
                            new DeviceId { Id = "678912789123453456784008666456", Kind = "eid" },
                            new DeviceId { Id = "78425989148000000840", Kind = "iccid" },
                        ],
                    },
                ],
                AccountName = "1223334444-00001",
                SmsrOid = "1.3.6.1.4.1.31746.1.500.200.101.5",
            },
        });
    // TODO: Handle 'response' of type DeviceManagementResult
}
catch (ApiException<DownloadLocalProfileToEnableError> ex)
{
    if (ex.Error.TryGetConnectivityManagementResult(out var error))
    {
        // TODO: Handle 'error' of type ConnectivityManagementResult
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DownloadLocalProfileToEnableRequest](src/Verizon/Requests/EUiccDeviceProfileManagement/DownloadLocalProfileToEnableRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeviceManagementResult](src/Verizon/Models/DeviceManagementResult.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[DownloadLocalProfileToEnableError](src/Verizon/Errors/DownloadLocalProfileToEnableError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RequestResponse&gt; EnableLocalProfile(EnableLocalProfileRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Enable a local profile that has been downloaded to eUICC devices.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.EUiccDeviceProfileManagement.EnableLocalProfile(new EnableLocalProfileRequest
    {
        Body = new ProfileChangeStateRequest
        {
            Devices = [
                new DeviceList
                {
                    DeviceIds = [
                        new DeviceId { Id = "678912789123453456784008666456", Kind = "eid" },
                        new DeviceId { Id = "78425989148000000840", Kind = "iccid" },
                    ],
                },
            ],
            AccountName = "1223334444-00001",
            SmsrOid = "1.3.6.1.4.1.31746.1.500.200.101.5",
        },
    });
    // TODO: Handle 'response' of type RequestResponse
}
catch (ApiException<EnableLocalProfileError> ex)
{
    if (ex.Error.TryGetRestErrorResponse(out var error))
    {
        // TODO: Handle 'error' of type RestErrorResponse
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[EnableLocalProfileRequest](src/Verizon/Requests/EUiccDeviceProfileManagement/EnableLocalProfileRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RequestResponse](src/Verizon/Models/RequestResponse.cs)</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[EnableLocalProfileError](src/Verizon/Errors/EnableLocalProfileError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## MapMessageController

> Source: [MapMessageController](src/Verizon/Api/MapMessageController.cs)

<details>
<summary><code>Task DeleteMapMessage(DeleteMapMessageRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Removes a map message for the specified region and intersection ID.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.MapMessageController.DeleteMapMessage(new DeleteMapMessageRequest
    {
        RegionId = "0",
        I10Nid = "58399",
    });
}
catch (ApiException<DeleteMapMessageError> ex)
{
    if (ex.Error.TryGetMdmErrorResponse(out var error))
    {
        // TODO: Handle 'error' of type MdmErrorResponse
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeleteMapMessageRequest](src/Verizon/Requests/MapMessageController/DeleteMapMessageRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[DeleteMapMessageError](src/Verizon/Errors/DeleteMapMessageError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;string&gt; DownloadMapMessages(DownloadMapMessagesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This endpoint is deprecated. (Use /api/v2/mapdata/query for new integrations).

This endpoint allows user to download SAE J2735 or ETSI MAP messages in ASN.1 UPER base64 encoded format. The area for the MAP messages is needed to be defined in the query.


**Required request header:** `Accept` — specifies the response format. Omitting this header will result in a `400 Bad Request`. Supported values:
- `text/plain` — ASN.1 UPER base64-encoded MAP messages (one per line)
- `application/json` — JSON-encoded MAP messages

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.MapMessageController.DownloadMapMessages(new DownloadMapMessagesRequest
    {
        Geofence = new GeofencePolygon
        {
            Type = EtxMapMessageGeofenceGeometry.Polygon,
            Coordinates = [
                [-77.479395d, 38.990773d],
                [-77.114566d, 38.99944d],
                [-77.100228d, 38.817204d],
                [-77.418059d, 38.827754d],
                [-77.479395d, 38.990773d],
            ],
        },
        VendorId = "VzMapManager",
    });
    // TODO: Handle 'response' of type string
}
catch (ApiException<DownloadMapMessagesError> ex)
{
    if (ex.Error.TryGetMdmErrorResponse(out var error))
    {
        // TODO: Handle 'error' of type MdmErrorResponse
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DownloadMapMessagesRequest](src/Verizon/Requests/MapMessageController/DownloadMapMessagesRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>string</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[DownloadMapMessagesError](src/Verizon/Errors/DownloadMapMessagesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;string&gt; IngestMapMessages(IngestMapMessagesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This endpoint allows the user to upload map messages in ASN.1 UPER base64 encoded format or JER (JSON) formats. The MAP data message can have more than one intersections in it.
Both SAE and ETSI defined MAP messages are supported. The SAE type MAP messages have to be wrapped in a MessageFrame, as defined in the SAE J2735 standard.
The ETSI type MAP messages are expected as MAPEM structures that include the ETSI header, as defined in the ETSI TS 103 301 standard.
Note: The user needs to authenticate with their ThingSpace credentials using the Access/Bearer and Session/M2M tokens in order to call this API.


**Required request header:** `Content-Type` — specifies the format of the request body. Omitting or sending an unsupported value will result in a `415 Unsupported Media Type`. Supported values:
- `text/plain` — ASN.1 UPER base64-encoded MAP message
- `application/json` — JSON representation of the MAP message

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.MapMessageController.IngestMapMessages(new IngestMapMessagesRequest
    {
        VendorId = "VzMapManager",
        MapDataMessageStandard = EtxMessageStandardEnum.Sae,
        Body = new EtxMapDataIngestRequest { MessageId = 1, Value = value },
    });
    // TODO: Handle 'response' of type string
}
catch (ApiException<IngestMapMessagesError> ex)
{
    if (ex.Error.TryGetMdmErrorResponse(out var error))
    {
        // TODO: Handle 'error' of type MdmErrorResponse
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[IngestMapMessagesRequest](src/Verizon/Requests/MapMessageController/IngestMapMessagesRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>string</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[IngestMapMessagesError](src/Verizon/Errors/IngestMapMessagesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;object&gt;&gt; QueryMapMessages(QueryMapMessagesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This endpoint allows users to download SAE J2735 or ETSI MAP messages as a JSON list. 
Depending on the expectedType parameter, the response contains either ASN.1 UPER base64-encoded messages with their respective region and intersection IDs, or fully decoded JSON messages. 
The area for MAP message retrieval must be defined in the request body using one of two methods: 
An array of region and intersection ID pairs, or a GeoJSON geofence specification.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.MapMessageController.QueryMapMessages(new QueryMapMessagesRequest
    {
        VendorId = "VzMapManager",
        Body = new EtxMapMessageIntersectionCoordinates
        {
            MessageStandard = EtxMessageStandardEnum.Sae,
            RegionIntersectionPairs = [new RegionIntersectionPair { RegionId = 100, IntersectionId = 5233 }],
            ExpectedType = EtxExpectedTypeEnum.Base64,
            PageSize = 50,
        },
    });
    // TODO: Handle 'response' of type IReadOnlyList<object>
}
catch (ApiException<QueryMapMessagesError> ex)
{
    if (ex.Error.TryGetMdmErrorResponse(out var error))
    {
        // TODO: Handle 'error' of type MdmErrorResponse
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[QueryMapMessagesRequest](src/Verizon/Requests/MapMessageController/QueryMapMessagesRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;object&gt;</code>

**OnError**: <code>[ApiException](src/Verizon/Core/Exceptions/ApiException.cs)&lt;[QueryMapMessagesError](src/Verizon/Errors/QueryMapMessagesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

