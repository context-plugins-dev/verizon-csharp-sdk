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
using Verizon.Requests.ConnectivityCallbacks;

namespace Verizon.Api;

/// <summary>
/// Manage subscriptions to asynchronous webhook messages.
/// </summary>
public sealed class ConnectivityCallbacks
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal ConnectivityCallbacks(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Stops the platform from sending callback messages for the specified account and service.
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CallbackActionResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="DeregisterCallbackError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Stops ThingSpace from sending callback messages for the specified account and service.
    /// </remarks>
    public Task<CallbackActionResult> DeregisterCallback(DeregisterCallbackRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Thingspace("/m2m/v1/callbacks/{aname}/name/{sname}"),
            [new TemplateParam("aname", request.Aname), new TemplateParam("sname", request.Sname)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<CallbackActionResult>(),
            DeregisterCallbackError.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Returns the name and endpoint URL of all callback listening services registered for a given account.
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="ConnectivityManagementCallback"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="ListRegisteredCallbacksError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the name and endpoint URL of the callback listening services registered for a given account.
    /// </remarks>
    public Task<IReadOnlyList<ConnectivityManagementCallback>> ListRegisteredCallbacks(ListRegisteredCallbacksRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Thingspace("/m2m/v1/callbacks/{aname}"),
            [new TemplateParam("aname", request.Aname)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<ConnectivityManagementCallback>>(),
            ListRegisteredCallbacksError.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Registers a URL where an account will receive RESTFul messages from a platform callback service.
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CallbackActionResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RegisterCallbackError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// You are responsible for creating and running a listening process on your server at that URL.
    /// </remarks>
    public Task<CallbackActionResult> RegisterCallback(RegisterCallbackOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Thingspace("/m2m/v1/callbacks/{aname}"),
            [new TemplateParam("aname", request.Aname)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<CallbackActionResult>(),
            RegisterCallbackError.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);
}
