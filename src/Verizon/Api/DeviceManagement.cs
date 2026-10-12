using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Verizon.Core;
using Verizon.Core.Exceptions;
using Verizon.Core.Models;
using Verizon.Core.Request;
using Verizon.Core.Response;
using Verizon.Errors;
using Verizon.Models;
using Verizon.Requests.DeviceManagement;

namespace Verizon.Api;

/// <summary>
/// Manage device connectivity and get device history.
/// </summary>
public sealed class DeviceManagement
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal DeviceManagement(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Activates service for one or more devices.
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeviceManagementResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="ActivateServiceForDevicesError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// If the devices do not already exist in the account, this API resource adds them before activation.
    /// </remarks>
    public Task<DeviceManagementResult> ActivateServiceForDevices(ActivateServiceForDevicesRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Thingspace("/m2m/v1/devices/actions/activate"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<DeviceManagementResult>(),
            ActivateServiceForDevicesError.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Adds up to 200 new devices, without provisioning lines of service for them.
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="AddDevicesResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="AddDevicesError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Use this API if you want to manage some device settings before you are ready to activate service for the devices.
    /// </remarks>
    public Task<IReadOnlyList<AddDevicesResult>> AddDevices(AddDevicesOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Thingspace("/m2m/v1/devices/actions/add"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<IReadOnlyList<AddDevicesResult>>(),
            AddDevicesError.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Gets billed usage for for either multiple devices or an entire billing account.
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeviceManagementResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="BilledUsageInfoError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Gets billed usage for for either multiple devices or an entire billing account.
    /// </remarks>
    public Task<DeviceManagementResult> BilledUsageInfo(BilledUsageInfoRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Thingspace("/m2m/v1/devices/usage/actions/billedusage/list"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<DeviceManagementResult>(),
            BilledUsageInfoError.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Sets a new service plan for one or more devices.
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeviceManagementResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="ChangeDevicesServicePlanError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Changes the service plan for one or more devices.
    /// </remarks>
    public Task<DeviceManagementResult> ChangeDevicesServicePlan(ChangeDevicesServicePlanRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Thingspace("/m2m/v1/devices/actions/plan"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<DeviceManagementResult>(),
            ChangeDevicesServicePlanError.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Checks whether devices are available to be activated.
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeviceManagementResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="CheckDevicesAvailabilityForActivationError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Checks whether specified devices are registered by the manufacturer with the Verizon network and are available to be activated.
    /// </remarks>
    public Task<DeviceManagementResult> CheckDevicesAvailabilityForActivation(CheckDevicesAvailabilityForActivationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Thingspace("/m2m/v1/devices/availability/actions/list"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<DeviceManagementResult>(),
            CheckDevicesAvailabilityForActivationError.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Deactivates service for one or more devices.
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeviceManagementResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="DeactivateServiceForDevicesError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Deactivating service for a device may result in an early termination fee (ETF) being charged to the account, depending on the terms of the contract with Verizon. If your contract allows ETF waivers and if you want to use one for a particular deactivation, set the etfWaiver value to True.
    /// </remarks>
    public Task<DeviceManagementResult> DeactivateServiceForDevices(DeactivateServiceForDevicesRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Thingspace("/m2m/v1/devices/actions/deactivate"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<DeviceManagementResult>(),
            DeactivateServiceForDevicesError.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Deletes up to 200 deactive devices.
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="DeleteDevicesResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="DeleteDeactivatedDevicesError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Use this API to remove unneeded devices from an account.
    /// </remarks>
    public Task<IReadOnlyList<DeleteDevicesResult>> DeleteDeactivatedDevices(DeleteDeactivatedDevicesRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Thingspace("/m2m/v1/devices/actions/delete"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<IReadOnlyList<DeleteDevicesResult>>(),
            DeleteDeactivatedDevicesError.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// API for Uploading Devices to DMD.
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RequestResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="DeviceUploadError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Upload a device record
    /// </remarks>
    public Task<RequestResponse> DeviceUpload(DeviceUploadOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Thingspace("/m2m/v1/devices/actions/upload"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<RequestResponse>(),
            DeviceUploadError.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Check the status of real-time orders.
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeviceManagementResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="DeviceUploadStatusError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Checks the status of an activation order and lists where the order is in the provisioning process.
    /// </remarks>
    public Task<DeviceManagementResult> DeviceUploadStatus(DeviceUploadStatusRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Thingspace("/m2m/v1/devices/requests/status"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<DeviceManagementResult>(),
            DeviceUploadStatusError.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Returns basic diagnostic information about a specified device, including connectivity, provisioning, and billing status.
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeviceExtendedDiagnosticsResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetDeviceExtendedDiagnosticInformationError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns extended diagnostic information about a specified device, including connectivity, provisioning, billing and location status.
    /// </remarks>
    public Task<DeviceExtendedDiagnosticsResult> GetDeviceExtendedDiagnosticInformation(GetDeviceExtendedDiagnosticInformationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Thingspace("/m2m/v1/devices/extendeddiagnostics/actions/list"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<DeviceExtendedDiagnosticsResult>(),
            GetDeviceExtendedDiagnosticInformationError.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Request service suspension information about devices.
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeviceManagementResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetDeviceServiceSuspensionStatusError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns DeviceSuspensionStatus callback messages containing the current device state and information on how many days a device has been suspended and can continue to be suspended.
    /// </remarks>
    public Task<DeviceManagementResult> GetDeviceServiceSuspensionStatus(GetDeviceServiceSuspensionStatusRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Thingspace("/m2m/v1/devices/suspension/status"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<DeviceManagementResult>(),
            GetDeviceServiceSuspensionStatusError.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Requests the current PRL version for devices, which can help determine which devices need a PRL update.
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeviceManagementResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="ListCurrentDevicesPrlVersionError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// 4G and GSM devices do not have a PRL.
    /// </remarks>
    public Task<DeviceManagementResult> ListCurrentDevicesPrlVersion(ListCurrentDevicesPrlVersionRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Thingspace("/m2m/v1/devices/prl/actions/list"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<DeviceManagementResult>(),
            ListCurrentDevicesPrlVersionError.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Returns information about a specified device or a list of devices in an account.
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AccountDeviceListResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="ListDevicesInformationError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns information about a single device or information about all devices that match the given parameters. Returned information includes device provisioning state, service plan, MDN, MIN, and IP address.
    /// </remarks>
    public Task<AccountDeviceListResult> ListDevicesInformation(ListDevicesInformationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Thingspace("/m2m/v1/devices/actions/list"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<AccountDeviceListResult>(),
            ListDevicesInformationError.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Returns the provisioning history of a device during a specified time period.
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="DeviceProvisioningHistoryListResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="ListDevicesProvisioningHistoryError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the provisioning history of a specified device during a specified time period.
    /// </remarks>
    public Task<IReadOnlyList<DeviceProvisioningHistoryListResult>> ListDevicesProvisioningHistory(ListDevicesProvisioningHistoryRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Thingspace("/m2m/v1/devices/history/actions/list"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<IReadOnlyList<DeviceProvisioningHistoryListResult>>(),
            ListDevicesProvisioningHistoryError.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Obtain the usage history of a specific device.
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeviceUsageListResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="ListDevicesUsageHistoryError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the network data usage history of a device during a specified time period.
    /// </remarks>
    public Task<DeviceUsageListResult> ListDevicesUsageHistory(ListDevicesUsageHistoryRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Thingspace("/m2m/v1/devices/usage/actions/list"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<DeviceUsageListResult>(),
            ListDevicesUsageHistoryError.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Returns a list of all 4G devices with an ICCID that was not activated with the expected IMEI.
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeviceMismatchListResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="ListDevicesWithImeiIccidMismatchError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a list of all 4G devices with an ICCID (SIM) that was not activated with the expected IMEI (hardware) during a specified time frame.
    /// </remarks>
    public Task<DeviceMismatchListResult> ListDevicesWithImeiIccidMismatch(ListDevicesWithImeiIccidMismatchRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Thingspace("/m2m/v1/devices/actions/list/imeiiccidmismatch"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<DeviceMismatchListResult>(),
            ListDevicesWithImeiIccidMismatchError.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Move devices between accounts.
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeviceManagementResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="MoveDevicesWithinAccountsOfProfileError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Move active devices from one billing account to another within a customer profile.
    /// </remarks>
    public Task<DeviceManagementResult> MoveDevicesWithinAccountsOfProfile(MoveDevicesWithinAccountsOfProfileRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Thingspace("/m2m/v1/devices/actions/move"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<DeviceManagementResult>(),
            MoveDevicesWithinAccountsOfProfileError.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Restore service to one or more suspended devices.
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeviceManagementResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RestoreServiceForSuspendedDevicesError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Restores service to one or more suspended devices.
    /// </remarks>
    public Task<DeviceManagementResult> RestoreServiceForSuspendedDevices(RestoreServiceForSuspendedDevicesRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Thingspace("/m2m/v1/devices/actions/restore"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<DeviceManagementResult>(),
            RestoreServiceForSuspendedDevicesError.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Returns the total amount of data sent and the total number of SMS messages sent or received by a set of devices in a specified timeframe.
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeviceManagementResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RetrieveAggregateDeviceUsageHistoryError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The information is returned in a callback response, so you must register a URL for DeviceUsage callback messages using the POST /callbacks API.
    /// </remarks>
    public Task<DeviceManagementResult> RetrieveAggregateDeviceUsageHistory(RetrieveAggregateDeviceUsageHistoryRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Thingspace("/m2m/v1/devices/usage/actions/list/aggregate"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<DeviceManagementResult>(),
            RetrieveAggregateDeviceUsageHistoryError.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Returns a list of network connection events for a device during a specified time period.
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ConnectionHistoryResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RetrieveDeviceConnectionHistoryError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Each response includes a maximum of 500 records. To obtain more records, you can call the API multiple times, adjusting the earliest value each time to start where the previous request finished.
    /// </remarks>
    public Task<ConnectionHistoryResult> RetrieveDeviceConnectionHistory(RetrieveDeviceConnectionHistoryRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Thingspace("/m2m/v1/devices/connections/actions/listHistory"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<ConnectionHistoryResult>(),
            RetrieveDeviceConnectionHistoryError.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Suspends service for one or more devices.
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeviceManagementResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="SuspendServiceForDevicesError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Suspends service for one or more devices.
    /// </remarks>
    public Task<DeviceManagementResult> SuspendServiceForDevices(SuspendServiceForDevicesRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Thingspace("/m2m/v1/devices/actions/suspend"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<DeviceManagementResult>(),
            SuspendServiceForDevicesError.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Changes the identifier of a 3G or 4G device to match hardware changes made for a line of service.
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeviceManagementResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="UpdateDeviceIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Changes the identifier of a 3G or 4G device to match hardware changes made for a line of service. Use this request to transfer the line of service and the MDN to new hardware, or to change the MDN.
    /// </remarks>
    public Task<DeviceManagementResult> UpdateDeviceId(UpdateDeviceIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Thingspace("/m2m/v1/devices/{serviceType}/actions/deviceId"),
            [new TemplateParam("serviceType", request.ServiceType)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<DeviceManagementResult>(),
            UpdateDeviceIdError.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Changes the name and address associated with a device.
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeviceManagementResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="UpdateDevicesContactInformationError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Sends a CarrierService callback message for each device in the request when the contact information has been changed, or if there was a problem and the change could not be completed.
    /// </remarks>
    public Task<DeviceManagementResult> UpdateDevicesContactInformation(UpdateDevicesContactInformationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Thingspace("/m2m/v1/devices/actions/contactInfo"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<DeviceManagementResult>(),
            UpdateDevicesContactInformationError.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Changes or removes the costCenterCode value for one or more devices.
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeviceManagementResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="UpdateDevicesCostCenterCodeError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Changes or removes the CostCenterCode value or customer name and address (Primary Place of Use) for one or more devices.
    /// </remarks>
    public Task<DeviceManagementResult> UpdateDevicesCostCenterCode(UpdateDevicesCostCenterCodeRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Thingspace("/m2m/v1/devices/costCenter"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<DeviceManagementResult>(),
            UpdateDevicesCostCenterCodeError.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Updates one or more custom field values for devices.
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeviceManagementResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="UpdateDevicesCustomFieldsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Sends a CarrierService callback message for each device in the request when the custom fields have been changed, or if there was a problem and the change could not be completed.
    /// </remarks>
    public Task<DeviceManagementResult> UpdateDevicesCustomFields(UpdateDevicesCustomFieldsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Thingspace("/m2m/v1/devices/actions/customFields"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<DeviceManagementResult>(),
            UpdateDevicesCustomFieldsError.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Move devices to a new customer-defined state.
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeviceManagementResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="UpdateDevicesStateError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Changes the provisioning state of one or more devices to a specified customer-defined service and state.
    /// </remarks>
    public Task<DeviceManagementResult> UpdateDevicesState(UpdateDevicesStateRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Thingspace("/m2m/v1/devices/actions/gotostate"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<DeviceManagementResult>(),
            UpdateDevicesStateError.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Uploads and activates device.
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeviceManagementResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="UploadActivateDeviceError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Uploads and activates device identifiers and SKUs for new devices from OEMs to Verizon.
    /// </remarks>
    public Task<DeviceManagementResult> UploadActivateDevice(UploadActivateDeviceRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Thingspace("/m2m/v1/devices/actions/uploadactivate"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<DeviceManagementResult>(),
            UploadActivateDeviceError.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Allow you to associate a label to a device
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeviceManagementResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="UsageSegmentationLabelAssociationError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Allows you to associate your own usage segmentation label with a device.
    /// </remarks>
    public Task<DeviceManagementResult> UsageSegmentationLabelAssociation(UsageSegmentationLabelAssociationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Thingspace("/m2m/v1/devices/actions/usagesegmentationlabels"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<DeviceManagementResult>(),
            UsageSegmentationLabelAssociationError.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Allow you to remove the label associated with a device.
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeviceManagementResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="UsageSegmentationLabelDeletionError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Allow customers to remove the associated label from a device.
    /// </remarks>
    public Task<DeviceManagementResult> UsageSegmentationLabelDeletion(UsageSegmentationLabelDeletionRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Thingspace("/m2m/v1/devices/actions/usagesegmentationlabels"),
            [],
            [new Param("accountName", request.AccountName), new Param("LabelList", request.LabelList)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<DeviceManagementResult>(),
            UsageSegmentationLabelDeletionError.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);
}
