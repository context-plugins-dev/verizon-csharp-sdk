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
using Verizon.Requests.SensorInsightsNotificationGroups;

namespace Verizon.Api;

/// <summary>
/// Create and manage groups to recieve notifications and alerts
/// </summary>
public sealed class SensorInsightsNotificationGroups
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal SensorInsightsNotificationGroups(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Add users to a notification group
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="SensorInsightsAddUsersToNotificationGroupRequestError"/> when the server returns an error response.</exception>
    public Task SensorInsightsAddUsersToNotificationGroupRequest(SensorInsightsAddUsersToNotificationGroupRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Thingspace("/dm/v1/notificationGroups/actions/add-users"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            VoidResponse.Instance,
            SensorInsightsAddUsersToNotificationGroupRequestError.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Create a notification group
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DtoNotificationGroupResponseEntity"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="SensorInsightsCreateNotificationGroupRequestError"/> when the server returns an error response.</exception>
    public Task<DtoNotificationGroupResponseEntity> SensorInsightsCreateNotificationGroupRequest(SensorInsightsCreateNotificationGroupRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Thingspace("/dm/v1/notificationGroups"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<DtoNotificationGroupResponseEntity>(),
            SensorInsightsCreateNotificationGroupRequestError.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Delete a notification group
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="SensorInsightsDeleteNotificationGroupError"/> when the server returns an error response.</exception>
    public Task SensorInsightsDeleteNotificationGroup(SensorInsightsDeleteNotificationGroupRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Thingspace("/dm/v1/notificationGroups"),
            [],
            [new Param("payload", request.Payload)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            VoidResponse.Instance,
            SensorInsightsDeleteNotificationGroupError.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Retrieve a notification group
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="DtoNotificationGroupResponseEntity"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="SensorInsightsListNotificationGroupRequestError"/> when the server returns an error response.</exception>
    public Task<IReadOnlyList<DtoNotificationGroupResponseEntity>> SensorInsightsListNotificationGroupRequest(SensorInsightsListNotificationGroupRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Thingspace("/dm/v1/notificationGroups/actions/query"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<IReadOnlyList<DtoNotificationGroupResponseEntity>>(),
            SensorInsightsListNotificationGroupRequestError.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Remove users from a notification group
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="SensorInsightsRemoveUsersFromNotificationGroupRequestError"/> when the server returns an error response.</exception>
    public Task SensorInsightsRemoveUsersFromNotificationGroupRequest(SensorInsightsRemoveUsersFromNotificationGroupRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Thingspace("/dm/v1/notificationGroups/actions/remove-users"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            VoidResponse.Instance,
            SensorInsightsRemoveUsersFromNotificationGroupRequestError.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Partially update a notification group
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DtoNotificationGroupResponseEntity"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="SensorInsightsUpdateNotificationGroupRequestError"/> when the server returns an error response.</exception>
    public Task<DtoNotificationGroupResponseEntity> SensorInsightsUpdateNotificationGroupRequest(SensorInsightsUpdateNotificationGroupRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Thingspace("/dm/v1/notificationGroups"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            JsonRequest.Create(request.Body),
            JsonResponse.Create<DtoNotificationGroupResponseEntity>(),
            SensorInsightsUpdateNotificationGroupRequestError.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);
}
