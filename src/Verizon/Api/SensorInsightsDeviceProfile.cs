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
using Verizon.Requests.SensorInsightsDeviceProfile;

namespace Verizon.Api;

/// <summary>
/// Create and manage device profile information
/// </summary>
public sealed class SensorInsightsDeviceProfile
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal SensorInsightsDeviceProfile(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Create device profile
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="DtoProfileResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="CreateAProfileError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Create a device profile
    /// </remarks>
    public Task<IReadOnlyList<DtoProfileResponse>> CreateAProfile(CreateAProfileRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Thingspace("/dm/v1/deviceConfigurationProfiles"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<IReadOnlyList<DtoProfileResponse>>(),
            CreateAProfileError.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Delete device profile
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="DtoProfileResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="DeleteAProfileError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Delete a device profile
    /// </remarks>
    public Task<IReadOnlyList<DtoProfileResponse>> DeleteAProfile(DeleteAProfileRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Thingspace("/dm/v1/deviceConfigurationProfiles"),
            [],
            [],
            [
                new HeaderParam("deleterequest", request.Deleterequest),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<DtoProfileResponse>>(),
            DeleteAProfileError.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Query device profile
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="DtoProfileResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="QueryAProfileError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query a device profile for an individual device
    /// </remarks>
    public Task<IReadOnlyList<DtoProfileResponse>> QueryAProfile(QueryAProfileRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Thingspace("/dm/v1/deviceConfigurationProfiles/actions/query"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<IReadOnlyList<DtoProfileResponse>>(),
            QueryAProfileError.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Partially update device profile
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="DtoProfileResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="UpdateAProfileError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Partially update a device profile
    /// </remarks>
    public Task<IReadOnlyList<DtoProfileResponse>> UpdateAProfile(UpdateAProfileRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Thingspace("/dm/v1/deviceConfigurationProfiles"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            JsonRequest.Create(request.Body),
            JsonResponse.Create<IReadOnlyList<DtoProfileResponse>>(),
            UpdateAProfileError.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);
}
