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
using Verizon.Requests.SensorInsightsSmartAlerts;

namespace Verizon.Api;

/// <summary>
/// Rules based alerts
/// </summary>
public sealed class SensorInsightsSmartAlerts
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal SensorInsightsSmartAlerts(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Bulk update smart alerts
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="UserSmartAlert"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="SensorInsightsBulkUpdateError"/> when the server returns an error response.</exception>
    public Task<UserSmartAlert> SensorInsightsBulkUpdate(SensorInsightsBulkUpdateRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Thingspace("/dm/v1/smartAlerts/actions/bulkupdate"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<UserSmartAlert>(),
            SensorInsightsBulkUpdateError.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Retrieve a smart alert
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="UserSmartAlert"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="SensorInsightsListSmartAlertsRequestError"/> when the server returns an error response.</exception>
    public Task<IReadOnlyList<UserSmartAlert>> SensorInsightsListSmartAlertsRequest(SensorInsightsListSmartAlertsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Thingspace("/dm/v1/smartAlerts/actions/query"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<IReadOnlyList<UserSmartAlert>>(),
            SensorInsightsListSmartAlertsRequestError.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Partially update a smart alert
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="UserSmartAlert"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="SensorInsightsPatchSmartAlertRequestError"/> when the server returns an error response.</exception>
    public Task<UserSmartAlert> SensorInsightsPatchSmartAlertRequest(SensorInsightsPatchSmartAlertRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Thingspace("/dm/v1/smartAlerts"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            JsonRequest.Create(request.Body),
            JsonResponse.Create<UserSmartAlert>(),
            SensorInsightsPatchSmartAlertRequestError.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);
}
