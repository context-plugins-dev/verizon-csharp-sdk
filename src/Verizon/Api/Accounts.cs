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
using Verizon.Requests.Accounts;

namespace Verizon.Api;

/// <summary>
/// Get information about an account or account leads.
/// </summary>
public sealed class Accounts
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal Accounts(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Returns information about a specified account
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Account"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetAccountInformationError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns information about a specified account.
    /// </remarks>
    public Task<Account> GetAccountInformation(GetAccountInformationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Thingspace("/m2m/v1/accounts/{aname}"),
            [new TemplateParam("aname", request.Aname)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Account>(),
            GetAccountInformationError.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Returns information for all leads associated with the account
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AccountLeadsResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="ListAccountLeadsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// When HTTP status is 202, a URL will be returned in the Location header of the form /leads/{aname}?next={token}. This URL can be used to request the next set of leads.
    /// </remarks>
    public Task<AccountLeadsResult> ListAccountLeads(ListAccountLeadsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Thingspace("/m2m/v1/leads/{aname}"),
            [new TemplateParam("aname", request.Aname)],
            [new Param("next", request.Next)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<AccountLeadsResult>(),
            ListAccountLeadsError.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Returns an account's custom services and states
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AccountStatesAndServices"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="ListAccountStatesAndServicesError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a list and details of all custom services and states defined for a specified account.
    /// </remarks>
    public Task<AccountStatesAndServices> ListAccountStatesAndServices(ListAccountStatesAndServicesRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Thingspace("/m2m/v1/accounts/{aname}/statesandservices"),
            [new TemplateParam("aname", request.Aname)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<AccountStatesAndServices>(),
            ListAccountStatesAndServicesError.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);
}
