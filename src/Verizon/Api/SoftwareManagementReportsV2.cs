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
using Verizon.Requests.SoftwareManagementReportsV2;

namespace Verizon.Api;

/// <summary>
/// Status of a campaign per device.
/// </summary>
public sealed class SoftwareManagementReportsV2
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal SoftwareManagementReportsV2(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Get a campaign device status.
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V2CampaignDevice"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetCampaignDeviceStatusError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The report endpoint allows user to get the full list of device of a campaign.
    /// </remarks>
    public Task<V2CampaignDevice> GetCampaignDeviceStatus(GetCampaignDeviceStatusRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.SoftwareManagementV2("/reports/{account}/campaigns/{campaignId}/devices"),
            [new TemplateParam("account", request.Account), new TemplateParam("campaignId", request.CampaignId)],
            [new Param("lastSeenDeviceId", request.LastSeenDeviceId)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<V2CampaignDevice>(),
            GetCampaignDeviceStatusError.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get campaign history for specified status.
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V2CampaignHistory"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetCampaignHistoryByStatusError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The report endpoint allows user to get campaign history of an account for specified status.
    /// </remarks>
    public Task<V2CampaignHistory> GetCampaignHistoryByStatus(GetCampaignHistoryByStatusRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.SoftwareManagementV2("/reports/{account}/campaigns"),
            [new TemplateParam("account", request.Account)],
            [
                new Param("campaignStatus", request.CampaignStatus),
                new Param("lastSeenCampaignId", request.LastSeenCampaignId),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<V2CampaignHistory>(),
            GetCampaignHistoryByStatusError.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get device software upgrade history
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="DeviceSoftwareUpgrade"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetDeviceFirmwareUpgradeHistory2Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The endpoint allows user to get software upgrade history of a device based on device IMEI.
    /// </remarks>
    public Task<IReadOnlyList<DeviceSoftwareUpgrade>> GetDeviceFirmwareUpgradeHistory2(GetDeviceFirmwareUpgradeHistory2Request request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.SoftwareManagementV2("/reports/{account}/devices/{deviceId}"),
            [new TemplateParam("account", request.Account), new TemplateParam("deviceId", request.DeviceId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<DeviceSoftwareUpgrade>>(),
            GetDeviceFirmwareUpgradeHistory2Error.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get account devices information
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V2AccountDeviceList"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="ListAccountDevices2Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The device endpoint gets devices information of an account.
    /// </remarks>
    public Task<V2AccountDeviceList> ListAccountDevices2(ListAccountDevices2Request request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.SoftwareManagementV2("/devices/{account}"),
            [new TemplateParam("account", request.Account)],
            [
                new Param("lastSeenDeviceId", request.LastSeenDeviceId),
                new Param("distributionType", request.DistributionType),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<V2AccountDeviceList>(),
            ListAccountDevices2Error.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get a list of available software
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="SoftwarePackage"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="ListAvailableSoftwareError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This endpoint allows user to list a certain type of software of an account.
    /// </remarks>
    public Task<IReadOnlyList<SoftwarePackage>> ListAvailableSoftware(ListAvailableSoftwareRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.SoftwareManagementV2("/software/{account}"),
            [new TemplateParam("account", request.Account)],
            [new Param("distributionType", request.DistributionType)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<SoftwarePackage>>(),
            ListAvailableSoftwareError.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);
}
