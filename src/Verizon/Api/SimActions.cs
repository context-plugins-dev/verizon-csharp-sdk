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
using Verizon.Requests.SimActions;

namespace Verizon.Api;

/// <summary>
/// Activate and Deactivate the SIM.
/// </summary>
public sealed class SimActions
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal SimActions(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Get a new activation code.
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ESimRequestResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="NewactivatecodeError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// System assign a new activation code to reactivate a deactivated device. <b>Note:</b> the previously assigned ICCID must be used to request a new activation code.
    /// </remarks>
    public Task<ESimRequestResponse> Newactivatecode(NewactivatecodeRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Thingspace("/m2m/v1/devices/profile/actions/renew_activation_code"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<ESimRequestResponse>(),
            NewactivatecodeError.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Activate a SIM.
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ESimRequestResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="SetactivateUsingPostError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Uses the profile to activate the SIM.
    /// </remarks>
    public Task<ESimRequestResponse> SetactivateUsingPost(SetactivateUsingPostRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Thingspace("/m2m/v1/devices/profile/actions/activate"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<ESimRequestResponse>(),
            SetactivateUsingPostError.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Deactivate a SIM.
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ESimRequestResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="SetdeactivateUsingPostError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Uses the profile to deactivate the SIM.
    /// </remarks>
    public Task<ESimRequestResponse> SetdeactivateUsingPost(SetdeactivateUsingPostRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Thingspace("/m2m/v1/devices/profile/actions/deactivate"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<ESimRequestResponse>(),
            SetdeactivateUsingPostError.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);
}
