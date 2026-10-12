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
using Verizon.Requests.IntelligenceServiceController;

namespace Verizon.Api;

/// <summary>
/// ThingSpace Intelligence is an offering of integrated connectivity and service management.
/// </summary>
public sealed class IntelligenceServiceController
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal IntelligenceServiceController(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Retrieve Windows
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AsynchronousRequestResultforplanner"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="SetConnectionPlannerError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieves available device windows for Connection Planner.
    /// </remarks>
    public Task<AsynchronousRequestResultforplanner> SetConnectionPlanner(SetConnectionPlannerRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Thingspace("/v1/intelligence/device/connection-planner"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<AsynchronousRequestResultforplanner>(),
            SetConnectionPlannerError.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Device Status for Connection Planner
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GetDeviceStatusesResponseforplanner"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="StatusConnectionPlannerError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieves the device status for the Connection Planner service.
    /// </remarks>
    public Task<GetDeviceStatusesResponseforplanner> StatusConnectionPlanner(StatusConnectionPlannerRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Thingspace("/v1/intelligence/device/connection-planner/status"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<GetDeviceStatusesResponseforplanner>(),
            StatusConnectionPlannerError.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);
}
