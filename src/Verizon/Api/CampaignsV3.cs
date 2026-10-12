using System;
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
using Verizon.Requests.CampaignsV3;

namespace Verizon.Api;

/// <summary>
/// Schedule, retrieve or cancel scheduled FOTA campaigns.
/// </summary>
public sealed class CampaignsV3
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal CampaignsV3(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Cancel a previously scheduled firmware campaign. This api is allowed before the campaign StartDate
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="FotaV3SuccessResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="CancelCampaign2Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This endpoint allows user to cancel a firmware campaign. A firmware campaign already started can not be cancelled.
    /// </remarks>
    public Task<FotaV3SuccessResult> CancelCampaign2(CancelCampaign2Request request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.SoftwareManagementV3("/campaigns/{accountName}/{campaignId}"),
            [
                new TemplateParam("accountName", request.AccountName),
                new TemplateParam("campaignId", request.CampaignId),
            ],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<FotaV3SuccessResult>(),
            CancelCampaign2Error.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Retrieve campaign level information
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Campaign"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetCampaignInformation2Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This endpoint allows the user to retrieve campaign level information for a specified campaign.
    /// </remarks>
    public Task<Campaign> GetCampaignInformation2(GetCampaignInformation2Request request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.SoftwareManagementV3("/campaigns/{accountName}/{campaignId}"),
            [
                new TemplateParam("accountName", request.AccountName),
                new TemplateParam("campaignId", request.CampaignId),
            ],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Campaign>(),
            GetCampaignInformation2Error.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Schedule a firmware upgrade
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="FirmwareCampaign"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="ScheduleCampaignFirmwareUpgrade2Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This endpoint allows a user to schedule a firmware upgrade for a list of devices.
    /// </remarks>
    public Task<FirmwareCampaign> ScheduleCampaignFirmwareUpgrade2(ScheduleCampaignFirmwareUpgrade2Request request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.SoftwareManagementV3("/campaigns/firmware/{accountName}"),
            [new TemplateParam("accountName", request.AccountName)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<FirmwareCampaign>(),
            ScheduleCampaignFirmwareUpgrade2Error.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Change firmware campaign dates and time windows. This api is allowed before the campaign StartDate
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="FirmwareCampaign"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="UpdateCampaignDates2Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This endpoint allows user to change campaign dates and time windows. Fields which need to remain unchanged should be also provided.
    /// </remarks>
    public Task<FirmwareCampaign> UpdateCampaignDates2(UpdateCampaignDates2Request request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.SoftwareManagementV3("/campaigns/firmware/{acc}/{campaignId}/dates"),
            [new TemplateParam("acc", request.Acc), new TemplateParam("campaignId", request.CampaignId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<FirmwareCampaign>(),
            UpdateCampaignDates2Error.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Add or Remove devices to an existing firmware campaign. This api is allowed before the campaign StartDate
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V3AddOrRemoveDeviceResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="UpdateCampaignFirmwareDevices2Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This endpoint allows user to Add or Remove devices to an existing campaign.
    /// </remarks>
    public Task<V3AddOrRemoveDeviceResult> UpdateCampaignFirmwareDevices2(UpdateCampaignFirmwareDevices2Request request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.SoftwareManagementV3("/campaigns/firmware/{acc}/{campaignId}"),
            [new TemplateParam("acc", request.Acc), new TemplateParam("campaignId", request.CampaignId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<V3AddOrRemoveDeviceResult>(),
            UpdateCampaignFirmwareDevices2Error.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);
}
