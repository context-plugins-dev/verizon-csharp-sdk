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
using Verizon.Requests.AccountServiceController;

namespace Verizon.Api;

/// <summary>
/// Account Information for a specified Account Name.
/// </summary>
public sealed class AccountServiceController
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal AccountServiceController(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Retrieve Account Information
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GetAccountInformationResponseforplanner"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetAccountInformationUsingGetError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns aaccount information associated with a specified account.
    /// </remarks>
    public Task<GetAccountInformationResponseforplanner> GetAccountInformationUsingGet(GetAccountInformationUsingGetRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Thingspace("/v1/accounts/{accountName}"),
            [new TemplateParam("accountName", request.AccountName)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<GetAccountInformationResponseforplanner>(),
            GetAccountInformationUsingGetError.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);
}
