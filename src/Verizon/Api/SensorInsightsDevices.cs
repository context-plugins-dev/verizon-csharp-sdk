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
using Verizon.Requests.SensorInsightsDevices;

namespace Verizon.Api;

/// <summary>
/// Device tasks and information
/// </summary>
public sealed class SensorInsightsDevices
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal SensorInsightsDevices(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Set device configuration
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DtoDeviceActionSetResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="SensorInsightsDeviceActionSetRequestError"/> when the server returns an error response.</exception>
    public Task<DtoDeviceActionSetResponse> SensorInsightsDeviceActionSetRequest(SensorInsightsDeviceActionSetRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Thingspace("/dm/v1/devices/actions/set"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<DtoDeviceActionSetResponse>(),
            SensorInsightsDeviceActionSetRequestError.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get last reported information for a device
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DtoLastReportedTimeResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="SensorInsightsLastReportedTimeRequestError"/> when the server returns an error response.</exception>
    public Task<DtoLastReportedTimeResponse> SensorInsightsLastReportedTimeRequest(SensorInsightsLastReportedTimeRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Thingspace("/dm/v1/devices/lastreported"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<DtoLastReportedTimeResponse>(),
            SensorInsightsLastReportedTimeRequestError.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// List the device experience
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="UserDeviceExperienceHistory"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="SensorInsightsListDeviceExperienceHistoryRequestError"/> when the server returns an error response.</exception>
    public Task<IReadOnlyList<UserDeviceExperienceHistory>> SensorInsightsListDeviceExperienceHistoryRequest(SensorInsightsListDeviceExperienceHistoryRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Thingspace("/dm/v1/devices/experience/actions/query"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<IReadOnlyList<UserDeviceExperienceHistory>>(),
            SensorInsightsListDeviceExperienceHistoryRequestError.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// List all device details on the account
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="DtoExpandedDeviceResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="SensorInsightsListDevicesRequestError"/> when the server returns an error response.</exception>
    public Task<IReadOnlyList<DtoExpandedDeviceResponse>> SensorInsightsListDevicesRequest(SensorInsightsListDevicesRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Thingspace("/dm/v1/devices/actions/query"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<IReadOnlyList<DtoExpandedDeviceResponse>>(),
            SensorInsightsListDevicesRequestError.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// List the network experience
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="UserNetworkExperienceHistory"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="SensorInsightsListNetworkExperienceHistoryRequestError"/> when the server returns an error response.</exception>
    public Task<IReadOnlyList<UserNetworkExperienceHistory>> SensorInsightsListNetworkExperienceHistoryRequest(SensorInsightsListNetworkExperienceHistoryRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Thingspace("/dm/v1/devices/networkexperience/actions/query"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<IReadOnlyList<UserNetworkExperienceHistory>>(),
            SensorInsightsListNetworkExperienceHistoryRequestError.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Partially update a device
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ResourceDevice"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="SensorInsightsPatchDeviceRequestError"/> when the server returns an error response.</exception>
    public Task<ResourceDevice> SensorInsightsPatchDeviceRequest(SensorInsightsPatchDeviceRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Thingspace("/dm/v1/devices"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            JsonRequest.Create(request.Body),
            JsonResponse.Create<ResourceDevice>(),
            SensorInsightsPatchDeviceRequestError.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);
}
