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
using Verizon.Requests.DiagnosticsCallbacks;

namespace Verizon.Api;

public sealed class DiagnosticsCallbacks
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal DiagnosticsCallbacks(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Get the registered callback information of diagnostics subscription
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="DeviceDiagnosticsCallback"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetDiagnosticsSubscriptionCallbackInfoError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This endpoint allows user to get the registered callback information of an existing diagnostics subscription.
    /// </remarks>
    public Task<IReadOnlyList<DeviceDiagnosticsCallback>> GetDiagnosticsSubscriptionCallbackInfo(GetDiagnosticsSubscriptionCallbackInfoRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.DeviceDiagnostics("/callbacks"),
            [],
            [new Param("accountName", request.AccountName)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<DeviceDiagnosticsCallback>>(),
            GetDiagnosticsSubscriptionCallbackInfoError.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Register callbacks (custom headers)
    /// </summary>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeviceDiagnosticsCallback"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RegisterDiagnosticsCallbackUrlError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This endpoint allows user update the callback HTTPS address of an existing diagnostics subscription.
    /// </remarks>
    public Task<DeviceDiagnosticsCallback> RegisterDiagnosticsCallbackUrl(RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.DeviceDiagnostics("/callbacks"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<DeviceDiagnosticsCallback>(),
            RegisterDiagnosticsCallbackUrlError.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Delete a previously registered Callback
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeviceDiagnosticsCallback"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="UnregisterDiagnosticsCallbackError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This endpoint allows user to delete a registered callback URL and credential.
    /// </remarks>
    public Task<DeviceDiagnosticsCallback> UnregisterDiagnosticsCallback(UnregisterDiagnosticsCallbackRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.DeviceDiagnostics("/callbacks"),
            [],
            [new Param("accountName", request.AccountName), new Param("serviceName", request.ServiceName)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<DeviceDiagnosticsCallback>(),
            UnregisterDiagnosticsCallbackError.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);
}
