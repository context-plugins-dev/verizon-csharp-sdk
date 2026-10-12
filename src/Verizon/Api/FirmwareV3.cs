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
using Verizon.Requests.FirmwareV3;

namespace Verizon.Api;

/// <summary>
/// State of Firmware across devices in the account.
/// </summary>
public sealed class FirmwareV3
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal FirmwareV3(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Get a list of available firmware
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="FirmwarePackage"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="ListAvailableFirmware2Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This endpoint allows user to list the firmware of an account.
    /// </remarks>
    public Task<IReadOnlyList<FirmwarePackage>> ListAvailableFirmware2(ListAvailableFirmware2Request request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.SoftwareManagementV3("/firmware/{acc}"),
            [new TemplateParam("acc", request.Acc)],
            [new Param("protocol", request.Protocol)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<FirmwarePackage>>(),
            ListAvailableFirmware2Error.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Report device firmware (asynchronous)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeviceFirmwareVersionUpdateResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="ReportDeviceFirmwareError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Ask a device to report its firmware version asynchronously.
    /// </remarks>
    public Task<DeviceFirmwareVersionUpdateResult> ReportDeviceFirmware(ReportDeviceFirmwareRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.SoftwareManagementV3("/firmware/{acc}/async/{deviceId}"),
            [new TemplateParam("acc", request.Acc), new TemplateParam("deviceId", request.DeviceId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            EmptyBody.Instance,
            JsonResponse.Create<DeviceFirmwareVersionUpdateResult>(),
            ReportDeviceFirmwareError.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// synchronize device firmware
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeviceFirmwareList"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="SynchronizeDeviceFirmwareError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Synchronize ThingSpace with the FOTA server for up to 100 devices.
    /// </remarks>
    public Task<DeviceFirmwareList> SynchronizeDeviceFirmware(SynchronizeDeviceFirmwareRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.SoftwareManagementV3("/firmware/{acc}/devices"),
            [new TemplateParam("acc", request.Acc)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<DeviceFirmwareList>(),
            SynchronizeDeviceFirmwareError.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);
}
