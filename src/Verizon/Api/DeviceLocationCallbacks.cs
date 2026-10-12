using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Verizon.Core;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Exceptions;
using Verizon.Core.Models;
using Verizon.Core.Request;
using Verizon.Core.Response;
using Verizon.Errors;
using Verizon.Models;
using Verizon.Requests.DeviceLocationCallbacks;

namespace Verizon.Api;

/// <summary>
/// Receive notifications from the API.
/// </summary>
public sealed class DeviceLocationCallbacks
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal DeviceLocationCallbacks(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Cancel an Asyncronous report
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TransactionId"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Cancel an asynchronous report request.
    /// </remarks>
    public Task<TransactionId> CancelAsyncReport(CancelAsyncReportRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.DeviceLocation("/devicelocations/{txid}"),
            [new TemplateParam("txid", request.Txid)],
            [new Param("accountName", request.AccountName)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<TransactionId>(),
            RawErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Stop receiving a callback type.
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeviceLocationSuccessResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="DeregisterCallback2Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Deregister a URL to stop receiving callback messages.
    /// </remarks>
    public Task<DeviceLocationSuccessResult> DeregisterCallback2(DeregisterCallback2Request request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.DeviceLocation("/callbacks/{accountName}/name/{service}"),
            [new TemplateParam("accountName", request.AccountName), new TemplateParam("service", request.Service)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<DeviceLocationSuccessResult>(),
            DeregisterCallback2Error.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get registered callback URLs.
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="DeviceLocationCallback"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="ListRegisteredCallbacks2Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a list of all registered callback URLs for the account.
    /// </remarks>
    public Task<IReadOnlyList<DeviceLocationCallback>> ListRegisteredCallbacks2(ListRegisteredCallbacks2Request request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.DeviceLocation("/callbacks/{accountName}"),
            [new TemplateParam("accountName", request.AccountName)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<DeviceLocationCallback>>(),
            ListRegisteredCallbacks2Error.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Register a URL to receive callbacks
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CallbackRegistrationResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RegisterCallback2Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Provide a URL to receive messages from a ThingSpace callback service.
    /// </remarks>
    public Task<CallbackRegistrationResult> RegisterCallback2(RegisterCallback2Request request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.DeviceLocation("/callbacks/{accountName}"),
            [new TemplateParam("accountName", request.AccountName)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<CallbackRegistrationResult>(),
            RegisterCallback2Error.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);
}
