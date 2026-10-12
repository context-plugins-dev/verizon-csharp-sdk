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
using Verizon.Requests.AccountRequests;

namespace Verizon.Api;

/// <summary>
/// Get the status of asynchronous reqeusts.
/// </summary>
public sealed class AccountRequests
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal AccountRequests(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Returns the status of an asynchronous request
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AsynchronousRequestResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetCurrentAsynchronousRequestStatusError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the current status of an asynchronous request that was made for a single device.
    /// </remarks>
    public Task<AsynchronousRequestResult> GetCurrentAsynchronousRequestStatus(GetCurrentAsynchronousRequestStatusRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Thingspace("/m2m/v1/accounts/{aname}/requests/{requestId}/status"),
            [new TemplateParam("aname", request.Aname), new TemplateParam("requestId", request.RequestId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<AsynchronousRequestResult>(),
            GetCurrentAsynchronousRequestStatusError.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);
}
