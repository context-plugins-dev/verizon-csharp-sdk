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
using Verizon.Requests.DevicesLocationSubscriptions;

namespace Verizon.Api;

/// <summary>
/// Get an account's location service subscription status and usage.
/// </summary>
public sealed class DevicesLocationSubscriptions
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal DevicesLocationSubscriptions(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Get a location subscription status
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeviceLocationSubscription"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetLocationServiceSubscriptionStatusError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This subscriptions endpoint retrieves an account's current location subscription status.
    /// </remarks>
    public Task<DeviceLocationSubscription> GetLocationServiceSubscriptionStatus(GetLocationServiceSubscriptionStatusRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.DeviceLocation("/subscriptions/{accountName}"),
            [new TemplateParam("accountName", request.AccountName)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<DeviceLocationSubscription>(),
            GetLocationServiceSubscriptionStatusError.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Obtain billable usage for accounts during a specified date range
    /// </summary>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="object"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetLocationServiceUsageError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This endpoint allows user to search for billable usage for accounts based on the provided date range.
    /// </remarks>
    public Task<object> GetLocationServiceUsage(RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.DeviceLocation("/usage"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<object>(),
            GetLocationServiceUsageError.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);
}
