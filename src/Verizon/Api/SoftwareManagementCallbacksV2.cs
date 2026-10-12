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
using Verizon.Requests.SoftwareManagementCallbacksV2;

namespace Verizon.Api;

/// <summary>
/// Find registered callbacks or create, update and delete a registered callback.
/// </summary>
public sealed class SoftwareManagementCallbacksV2
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal SoftwareManagementCallbacksV2(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Delete a previously registered Callback
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="FotaV2SuccessResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="DeregisterCallback4Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This endpoint allows user to delete a previously registered callback URL.
    /// </remarks>
    public Task<FotaV2SuccessResult> DeregisterCallback4(DeregisterCallback4Request request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.SoftwareManagementV2("/callbacks/{account}"),
            [new TemplateParam("account", request.Account)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<FotaV2SuccessResult>(),
            DeregisterCallback4Error.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get the registered callback information
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CallbackSummary"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="ListRegisteredCallbacks4Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This endpoint allows user to get the registered callback information.
    /// </remarks>
    public Task<CallbackSummary> ListRegisteredCallbacks4(ListRegisteredCallbacks4Request request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.SoftwareManagementV2("/callbacks/{account}"),
            [new TemplateParam("account", request.Account)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<CallbackSummary>(),
            ListRegisteredCallbacks4Error.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Create HTTPS callback address
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="FotaV2CallbackRegistrationResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RegisterCallback4Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This endpoint allows user to create the HTTPS callback address.
    /// </remarks>
    public Task<FotaV2CallbackRegistrationResult> RegisterCallback4(RegisterCallback4Request request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.SoftwareManagementV2("/callbacks/{account}"),
            [new TemplateParam("account", request.Account)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<FotaV2CallbackRegistrationResult>(),
            RegisterCallback4Error.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Update HTTPS callback address
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="FotaV2CallbackRegistrationResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="UpdateCallbackError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This endpoint allows user to update the HTTPS callback address.
    /// </remarks>
    public Task<FotaV2CallbackRegistrationResult> UpdateCallback(UpdateCallbackRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.SoftwareManagementV2("/callbacks/{account}"),
            [new TemplateParam("account", request.Account)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            EmptyBody.Instance,
            JsonResponse.Create<FotaV2CallbackRegistrationResult>(),
            UpdateCallbackError.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);
}
