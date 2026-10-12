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
using Verizon.Requests.DeviceReports;

namespace Verizon.Api;

/// <summary>
/// Check device usage
/// </summary>
public sealed class DeviceReports
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal DeviceReports(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// An aggregated asynchronous sessions and usage report for a user specified selection of devices and date range
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AggregatedReportCallbackResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="CalculateAggregatedReportAsynchronousError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Calculate aggregated report per day with number of sessions and usage information. User will receive an asynchronous callback for the specified list of devices (Max 10000) and date range (Max 180 days).
    /// </remarks>
    public Task<AggregatedReportCallbackResult> CalculateAggregatedReportAsynchronous(CalculateAggregatedReportAsynchronousRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.HyperPreciseLocation("/report/async/aggregate"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<AggregatedReportCallbackResult>(),
            CalculateAggregatedReportAsynchronousError.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// An aggregated sessions and usage report for a user specified selection of devices and date range
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AggregateSessionReport"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="CalculateAggregatedReportSynchronousError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Calculate aggregated report per day with number of sessions and usage information. User will receive synchronous response for specified list of devices (Max 10) and date range (Max 180 days).
    /// </remarks>
    public Task<AggregateSessionReport> CalculateAggregatedReportSynchronous(CalculateAggregatedReportSynchronousRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.HyperPreciseLocation("/report/aggregate"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<AggregateSessionReport>(),
            CalculateAggregatedReportSynchronousError.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// A daily usage report for a single device for a specified date range (up to 180 days).
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SessionReport"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetSessionsReportError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Detailed report of session duration and number of bytes transferred per day.
    /// </remarks>
    public Task<SessionReport> GetSessionsReport(GetSessionsReportRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.HyperPreciseLocation("/report/sessions"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<SessionReport>(),
            GetSessionsReportError.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);
}
