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
using Verizon.Requests.FirmwareV1;

namespace Verizon.Api;

/// <summary>
/// Schedule and monitor firmware upgrades.
/// </summary>
public sealed class FirmwareV1
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal FirmwareV1(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Cancel a scheduled firmware upgrade.
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="FotaV1SuccessResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="CancelScheduledFirmwareUpgradeError"/> when the server returns an error response.</exception>
    public Task<FotaV1SuccessResult> CancelScheduledFirmwareUpgrade(CancelScheduledFirmwareUpgradeRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.SoftwareManagementV1("/upgrades/{accountName}/upgrade/{upgradeId}"),
            [new TemplateParam("accountName", request.AccountName), new TemplateParam("upgradeId", request.UpgradeId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<FotaV1SuccessResult>(),
            CancelScheduledFirmwareUpgradeError.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get list of available firmware
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="Firmware"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="ListAvailableFirmwareError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Lists all device firmware images available for an account, based on the devices registered to that account.
    /// </remarks>
    public Task<IReadOnlyList<Firmware>> ListAvailableFirmware(ListAvailableFirmwareRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.SoftwareManagementV1("/firmware/{account}"),
            [new TemplateParam("account", request.Account)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<Firmware>>(),
            ListAvailableFirmwareError.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get information about a firmware upgrade
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="FirmwareUpgrade"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="ListFirmwareUpgradeDetailsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns information about a specified upgrade, include the target date of the upgrade, the list of devices in the upgrade, and the status of the upgrade for each device.
    /// </remarks>
    public Task<FirmwareUpgrade> ListFirmwareUpgradeDetails(ListFirmwareUpgradeDetailsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.SoftwareManagementV1("/upgrades/{accountName}/upgrade/{upgradeId}"),
            [new TemplateParam("accountName", request.AccountName), new TemplateParam("upgradeId", request.UpgradeId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<FirmwareUpgrade>(),
            ListFirmwareUpgradeDetailsError.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Schedule a firmware upgrade
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="FirmwareUpgrade"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="ScheduleFirmwareUpgradeError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Schedules a firmware upgrade for devices.
    /// </remarks>
    public Task<FirmwareUpgrade> ScheduleFirmwareUpgrade(ScheduleFirmwareUpgradeRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.SoftwareManagementV1("/upgrades"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<FirmwareUpgrade>(),
            ScheduleFirmwareUpgradeError.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Change the device list for a scheduled upgrade
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="FirmwareUpgradeChangeResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="UpdateFirmwareUpgradeDevicesError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Add or remove devices from a scheduled upgrade.
    /// </remarks>
    public Task<FirmwareUpgradeChangeResult> UpdateFirmwareUpgradeDevices(UpdateFirmwareUpgradeDevicesRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.SoftwareManagementV1("/upgrades/{accountName}/upgrade/{upgradeId}"),
            [new TemplateParam("accountName", request.AccountName), new TemplateParam("upgradeId", request.UpgradeId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            EmptyBody.Instance,
            JsonResponse.Create<FirmwareUpgradeChangeResult>(),
            UpdateFirmwareUpgradeDevicesError.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);
}
