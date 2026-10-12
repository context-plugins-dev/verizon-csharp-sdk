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
using Verizon.Requests.SessionManagement;

namespace Verizon.Api;

/// <summary>
/// Start and end Connectivity Management sessions.
/// </summary>
public sealed class SessionManagement
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal SessionManagement(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Ends a Connectivity Management session.
    /// </summary>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="LogOutRequest"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="EndConnectivityManagementSessionError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Ends a Connectivity Management session.
    /// </remarks>
    public Task<LogOutRequest> EndConnectivityManagementSession(RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Thingspace("/m2m/v1/session/logout"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<LogOutRequest>(),
            EndConnectivityManagementSessionError.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Returns a new, randomly generated password for the current username
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SessionResetPasswordResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="ResetConnectivityManagementPasswordError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The new password is effective immediately. Passwords do not expire, but Verizon recommends changing your password every 90 days.
    /// </remarks>
    public Task<SessionResetPasswordResult> ResetConnectivityManagementPassword(ResetConnectivityManagementPasswordRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Thingspace("/m2m/v1/session/password/actions/reset"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<SessionResetPasswordResult>(),
            ResetConnectivityManagementPasswordError.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Initiates a Connectivity Management session and returns a session token required in subsequent API requests.
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="LogInResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="StartConnectivityManagementSessionError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Initiates a Connectivity Management session and returns a VZ-M2M session token that is required in subsequent API requests.
    /// </remarks>
    public Task<LogInResult> StartConnectivityManagementSession(StartConnectivityManagementSessionRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Thingspace("/m2m/v1/session/login"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<LogInResult>(),
            StartConnectivityManagementSessionError.Response,
            [_auth.ThingspaceOauth],
            requestOptions,
            cancellationToken);
}
