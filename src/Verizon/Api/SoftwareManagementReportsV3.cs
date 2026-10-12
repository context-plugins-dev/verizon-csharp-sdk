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
using Verizon.Requests.SoftwareManagementReportsV3;

namespace Verizon.Api;

/// <summary>
/// Status of a campaign per device.
/// </summary>
public sealed class SoftwareManagementReportsV3
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal SoftwareManagementReportsV3(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Get a campaign device status
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V3CampaignDevice"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetCampaignDeviceStatus2Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieve a list of all devices in a campaign and the status of each device.
    /// </remarks>
    public Task<V3CampaignDevice> GetCampaignDeviceStatus2(GetCampaignDeviceStatus2Request request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.SoftwareManagementV3("/reports/{acc}/campaigns/{campaignId}/devices"),
            [new TemplateParam("acc", request.Acc), new TemplateParam("campaignId", request.CampaignId)],
            [new Param("lastSeenDeviceId", request.LastSeenDeviceId)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<V3CampaignDevice>(),
            GetCampaignDeviceStatus2Error.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get firmware campaign status
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V3CampaignHistory"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetCampaignHistoryByStatus2Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieve a list of campaigns for an account that have a specified campaign status.
    /// </remarks>
    public Task<V3CampaignHistory> GetCampaignHistoryByStatus2(GetCampaignHistoryByStatus2Request request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.SoftwareManagementV3("/reports/{acc}/firmware/campaigns"),
            [new TemplateParam("acc", request.Acc)],
            [
                new Param("campaignStatus", request.CampaignStatus),
                new Param("lastSeenCampaignId", request.LastSeenCampaignId),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<V3CampaignHistory>(),
            GetCampaignHistoryByStatus2Error.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get device campaign history
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="DeviceFirmwareUpgrade"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetDeviceFirmwareUpgradeHistory3Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieve campaign history for a specific device.
    /// </remarks>
    public Task<IReadOnlyList<DeviceFirmwareUpgrade>> GetDeviceFirmwareUpgradeHistory3(GetDeviceFirmwareUpgradeHistory3Request request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.SoftwareManagementV3("/reports/{acc}/devices/{deviceId}"),
            [new TemplateParam("acc", request.Acc), new TemplateParam("deviceId", request.DeviceId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<DeviceFirmwareUpgrade>>(),
            GetDeviceFirmwareUpgradeHistory3Error.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);
}
