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
using Verizon.Requests.ClientLogging;

namespace Verizon.Api;

/// <summary>
/// Device logs stored on the device itself.
/// </summary>
public sealed class ClientLogging
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal ClientLogging(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Turn logging off for the device specified
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="DisableDeviceLoggingError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Disables logging for a specific device.
    /// </remarks>
    public Task DisableDeviceLogging(DisableDeviceLoggingRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.SoftwareManagementV2("/logging/{account}/devices/{deviceId}"),
            [new TemplateParam("account", request.Account), new TemplateParam("deviceId", request.DeviceId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            VoidResponse.Instance,
            DisableDeviceLoggingError.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Turn logging off for a list of devices.
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="DisableLoggingForDevicesError"/> when the server returns an error response.</exception>
    public Task DisableLoggingForDevices(DisableLoggingForDevicesRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.SoftwareManagementV2("/logging/{account}/devices"),
            [new TemplateParam("account", request.Account)],
            [new Param("deviceIds", request.DeviceIds)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            VoidResponse.Instance,
            DisableLoggingForDevicesError.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Turn logging on for the device specified
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeviceLoggingStatus"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="EnableDeviceLoggingError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Enables logging for a specific device.
    /// </remarks>
    public Task<DeviceLoggingStatus> EnableDeviceLogging(EnableDeviceLoggingRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.SoftwareManagementV2("/logging/{account}/devices/{deviceId}"),
            [new TemplateParam("account", request.Account), new TemplateParam("deviceId", request.DeviceId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            EmptyBody.Instance,
            JsonResponse.Create<DeviceLoggingStatus>(),
            EnableDeviceLoggingError.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Turn logging on for the list of devices
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="DeviceLoggingStatus"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="EnableLoggingForDevicesError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Each customer may have a maximum of 20 devices enabled for logging.
    /// </remarks>
    public Task<IReadOnlyList<DeviceLoggingStatus>> EnableLoggingForDevices(EnableLoggingForDevicesRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.SoftwareManagementV2("/logging/{account}/devices"),
            [new TemplateParam("account", request.Account)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<DeviceLoggingStatus>>(),
            EnableLoggingForDevicesError.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get logs for the device specified
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="DeviceLog"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="ListDeviceLogsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Gets logs for a specific device.
    /// </remarks>
    public Task<IReadOnlyList<DeviceLog>> ListDeviceLogs(ListDeviceLogsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.SoftwareManagementV2("/logging/{account}/devices/{deviceId}/logs"),
            [new TemplateParam("account", request.Account), new TemplateParam("deviceId", request.DeviceId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<DeviceLog>>(),
            ListDeviceLogsError.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Returns an array of all devices in the specified account for which logging is enabled.
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="DeviceLoggingStatus"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="ListDevicesWithLoggingEnabledError"/> when the server returns an error response.</exception>
    public Task<IReadOnlyList<DeviceLoggingStatus>> ListDevicesWithLoggingEnabled(ListDevicesWithLoggingEnabledRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.SoftwareManagementV2("/logging/{account}/devices"),
            [new TemplateParam("account", request.Account)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<DeviceLoggingStatus>>(),
            ListDevicesWithLoggingEnabledError.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);
}
