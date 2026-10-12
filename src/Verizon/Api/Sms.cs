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
using Verizon.Requests.Sms;

namespace Verizon.Api;

/// <summary>
/// Exchange Short Message Service (SMS) messages with devices.
/// </summary>
public sealed class Sms
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal Sms(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Retrieves queued SMS messages sent by all M2M MC devices associated with an account.
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SmsMessagesQueryResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="ListDevicesSmsMessagesError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// When HTTP status is 202, a URL will be returned in the Location header of the form /sms/{aname}/history?next={token}. This URL can be used to request the next set of messages.
    /// </remarks>
    public Task<SmsMessagesQueryResult> ListDevicesSmsMessages(ListDevicesSmsMessagesRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Thingspace("/m2m/v1/sms/{aname}/history"),
            [new TemplateParam("aname", request.Aname)],
            [new Param("next", request.Next)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SmsMessagesQueryResult>(),
            ListDevicesSmsMessagesError.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Sends an SMS message to one or more devices.
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeviceManagementResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="SendSmsToDeviceError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The messages are queued on the ThingSpace Platform and sent as soon as possible, but they may be delayed due to traffic and routing considerations.
    /// </remarks>
    public Task<DeviceManagementResult> SendSmsToDevice(SendSmsToDeviceRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Thingspace("/m2m/v1/sms"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<DeviceManagementResult>(),
            SendSmsToDeviceError.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Starts delivery of queued SMS messages for the specific account.
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ConnectivityManagementSuccessResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="StartQueuedSmsDeliveryError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Tells the ThingSpace Platform to start sending mobile-originated SMS messages through the EnhancedConnectivityService callback service. SMS messages from devices are queued until they are retrieved by your application, either by callback or synchronously with GET /sms/{accountName}/history.
    /// </remarks>
    public Task<ConnectivityManagementSuccessResult> StartQueuedSmsDelivery(StartQueuedSmsDeliveryRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Thingspace("/m2m/v1/sms/{aname}/startCallbacks"),
            [new TemplateParam("aname", request.Aname)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            EmptyBody.Instance,
            JsonResponse.Create<ConnectivityManagementSuccessResult>(),
            StartQueuedSmsDeliveryError.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);
}
