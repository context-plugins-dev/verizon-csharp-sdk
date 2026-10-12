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
using Verizon.Requests.DeviceMonitoring;

namespace Verizon.Api;

/// <summary>
/// Monitor device reachability and connection status.
/// </summary>
public sealed class DeviceMonitoring
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal DeviceMonitoring(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Register for notification reports based on the request type.
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RequestResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="DeviceReachabilityError"/> when the server returns an error response.</exception>
    public Task<RequestResponse> DeviceReachability(DeviceReachabilityRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Thingspace("/m2m/v1/diagnostics/basic/devicereachability"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<RequestResponse>(),
            DeviceReachabilityError.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Stop Device Reachability monitors.
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RequestResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="StopDeviceReachabilityError"/> when the server returns an error response.</exception>
    public Task<RequestResponse> StopDeviceReachability(StopDeviceReachabilityRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Thingspace("/m2m/v1/diagnostics/basic/devicereachability"),
            [],
            [new Param("stopreachabilitypayload", request.Stopreachabilitypayload)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<RequestResponse>(),
            StopDeviceReachabilityError.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);
}
