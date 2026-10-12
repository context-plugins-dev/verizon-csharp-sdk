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
using Verizon.Requests.CampaignsV2;

namespace Verizon.Api;

/// <summary>
/// Schedule, retrieve or cancel scheduled FOTA campaigns.
/// </summary>
public sealed class CampaignsV2
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal CampaignsV2(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Cancel a previously scheduled software upgrade
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="FotaV2SuccessResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="CancelCampaignError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This endpoint allows user to cancel software upgrade. A software upgrade already started can not be cancelled.
    /// </remarks>
    public Task<FotaV2SuccessResult> CancelCampaign(CancelCampaignRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.SoftwareManagementV2("/campaigns/{account}/{campaignId}"),
            [new TemplateParam("account", request.Account), new TemplateParam("campaignId", request.CampaignId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<FotaV2SuccessResult>(),
            CancelCampaignError.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get information of a software upgrade.
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CampaignSoftware"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetCampaignInformationError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This endpoint allows user to get information of a software upgrade.
    /// </remarks>
    public Task<CampaignSoftware> GetCampaignInformation(GetCampaignInformationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.SoftwareManagementV2("/campaigns/{account}/{campaignId}"),
            [new TemplateParam("account", request.Account), new TemplateParam("campaignId", request.CampaignId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<CampaignSoftware>(),
            GetCampaignInformationError.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Schedule a software upgrade
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CampaignSoftware"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="ScheduleCampaignFirmwareUpgradeError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This endpoint allows user to schedule a software upgrade.
    /// </remarks>
    public Task<CampaignSoftware> ScheduleCampaignFirmwareUpgrade(ScheduleCampaignFirmwareUpgradeRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.SoftwareManagementV2("/campaigns/{account}"),
            [new TemplateParam("account", request.Account)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<CampaignSoftware>(),
            ScheduleCampaignFirmwareUpgradeError.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Schedules a file upgrade.
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="UploadAndScheduleFileResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="ScheduleFileUpgradeError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// You can upload configuration files and schedule them in a campaign to devices.
    /// </remarks>
    public Task<UploadAndScheduleFileResponse> ScheduleFileUpgrade(ScheduleFileUpgradeRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.SoftwareManagementV2("/campaigns/files/{acc}"),
            [new TemplateParam("acc", request.Acc)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<UploadAndScheduleFileResponse>(),
            ScheduleFileUpgradeError.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Schedules a software upgrade for HTTP devices.
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="UploadAndScheduleFileResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="ScheduleSwUpgradeHttpDevicesError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Campaign time windows for downloading and installing software are available as long as the device OEM supports this.
    /// </remarks>
    public Task<UploadAndScheduleFileResponse> ScheduleSwUpgradeHttpDevices(ScheduleSwUpgradeHttpDevicesRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.SoftwareManagementV2("/campaigns/software/{acc}"),
            [new TemplateParam("acc", request.Acc)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<UploadAndScheduleFileResponse>(),
            ScheduleSwUpgradeHttpDevicesError.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Change campaign dates and time windows
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CampaignSoftware"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="UpdateCampaignDatesError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This endpoint allows user to change campaign dates and time windows. Fields which need to remain unchanged should be also provided.
    /// </remarks>
    public Task<CampaignSoftware> UpdateCampaignDates(UpdateCampaignDatesRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.SoftwareManagementV2("/campaigns/{account}/{campaignId}/dates"),
            [new TemplateParam("account", request.Account), new TemplateParam("campaignId", request.CampaignId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            EmptyBody.Instance,
            JsonResponse.Create<CampaignSoftware>(),
            UpdateCampaignDatesError.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Add or Remove device to existing software upgrade
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V2AddOrRemoveDeviceResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="UpdateCampaignFirmwareDevicesError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This endpoint allows user to Add or Remove devices to an existing software upgrade.
    /// </remarks>
    public Task<V2AddOrRemoveDeviceResult> UpdateCampaignFirmwareDevices(UpdateCampaignFirmwareDevicesRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.SoftwareManagementV2("/campaigns/{account}/{campaignId}"),
            [new TemplateParam("account", request.Account), new TemplateParam("campaignId", request.CampaignId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            EmptyBody.Instance,
            JsonResponse.Create<V2AddOrRemoveDeviceResult>(),
            UpdateCampaignFirmwareDevicesError.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);
}
