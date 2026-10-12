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
using Verizon.Requests.GlobalReporting;

namespace Verizon.Api;

/// <summary>
/// Use these endpoints to determine the status of requests or the history of device provisioning.
/// </summary>
public sealed class GlobalReporting
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal GlobalReporting(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Retrieve global device list.
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ESimRequestResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RetrieveGlobalListError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieve a list of all devices associated with an account.
    /// </remarks>
    public Task<ESimRequestResponse> RetrieveGlobalList(RetrieveGlobalListRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Thingspace("/m2m/v2/devices/actions/list"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<ESimRequestResponse>(),
            RetrieveGlobalListError.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Retrieve Device Provisioning History.
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ESimRequestResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="DeviceprovhistoryUsingPostError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieve the provisioning history of a specific device or devices.
    /// </remarks>
    public Task<ESimRequestResponse> DeviceprovhistoryUsingPost(DeviceprovhistoryUsingPostRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Thingspace("/m2m/v2/devices/history/actions/list"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<ESimRequestResponse>(),
            DeviceprovhistoryUsingPostError.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);
}
