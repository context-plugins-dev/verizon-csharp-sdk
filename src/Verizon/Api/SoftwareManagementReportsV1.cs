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
using Verizon.Requests.SoftwareManagementReportsV1;

namespace Verizon.Api;

/// <summary>
/// Status and history information.
/// </summary>
public sealed class SoftwareManagementReportsV1
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal SoftwareManagementReportsV1(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Returns the upgrade history of the specified device from the previous six months.
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="DeviceUpgradeHistory"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetDeviceFirmwareUpgradeHistoryError"/> when the server returns an error response.</exception>
    public Task<IReadOnlyList<DeviceUpgradeHistory>> GetDeviceFirmwareUpgradeHistory(GetDeviceFirmwareUpgradeHistoryRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.SoftwareManagementV1("/reports/{account}/devices/{deviceId}"),
            [new TemplateParam("account", request.Account), new TemplateParam("deviceId", request.DeviceId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<DeviceUpgradeHistory>>(),
            GetDeviceFirmwareUpgradeHistoryError.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get list of devices in the account
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeviceListQueryResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="ListAccountDevicesError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns an array of all devices in the specified account. Each device object includes information needed for managing firmware, including the device make and model, MDN and IMEI, and current firmware version.
    /// </remarks>
    public Task<DeviceListQueryResult> ListAccountDevices(ListAccountDevicesRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.SoftwareManagementV1("/devices/{account}/index/{startIndex}"),
            [new TemplateParam("account", request.Account), new TemplateParam("startIndex", request.StartIndex)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<DeviceListQueryResult>(),
            ListAccountDevicesError.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Returns a list of all upgrades with a specified status.
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="UpgradeListQueryResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="ListUpgradesForSpecifiedStatusError"/> when the server returns an error response.</exception>
    public Task<UpgradeListQueryResult> ListUpgradesForSpecifiedStatus(ListUpgradesForSpecifiedStatusRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.SoftwareManagementV1("/reports/{account}/status/{upgradeStatus}/index/{startIndex}"),
            [
                new TemplateParam("account", request.Account),
                new TemplateParam("upgradeStatus", request.UpgradeStatus),
                new TemplateParam("startIndex", request.StartIndex),
            ],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<UpgradeListQueryResult>(),
            ListUpgradesForSpecifiedStatusError.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);
}
