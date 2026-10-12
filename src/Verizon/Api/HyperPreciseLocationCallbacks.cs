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
using Verizon.Requests.HyperPreciseLocationCallbacks;

namespace Verizon.Api;

/// <summary>
/// Manage callback listeners for Hyper Precise
/// </summary>
public sealed class HyperPreciseLocationCallbacks
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal HyperPreciseLocationCallbacks(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Deregister a Callback Listener
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="DeregisterCallback6Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Stops ThingSpace from sending callback messages for the specified account and listener name.
    /// </remarks>
    public Task DeregisterCallback6(DeregisterCallback6Request request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.HyperPreciseLocation("/callbacks"),
            [],
            [new Param("accountNumber", request.AccountNumber), new Param("service", request.Service)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            VoidResponse.Instance,
            DeregisterCallback6Error.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get registered callback listener
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="CallbackCreated"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="ListRegisteredCallbacks6Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Find registered callback listener for account by account number.
    /// </remarks>
    public Task<IReadOnlyList<CallbackCreated>> ListRegisteredCallbacks6(ListRegisteredCallbacks6Request request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.HyperPreciseLocation("/callbacks"),
            [],
            [new Param("accountNumber", request.AccountNumber)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<CallbackCreated>>(),
            ListRegisteredCallbacks6Error.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Register a Callback Listener URL
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CallbackRegistered"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RegisterCallback6Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Registers a URL at which an account receives asynchronous responses and other messages from a ThingSpace Platform callback service. The messages are REST messages. You are responsible for creating and running a listening process on your server at that URL to receive and parse the messages.
    /// </remarks>
    public Task<CallbackRegistered> RegisterCallback6(RegisterCallback6Request request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.HyperPreciseLocation("/callbacks"),
            [],
            [new Param("accountNumber", request.AccountNumber)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<CallbackRegistered>(),
            RegisterCallback6Error.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);
}
