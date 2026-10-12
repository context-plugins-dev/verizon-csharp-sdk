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
using Verizon.Requests.Billing;

namespace Verizon.Api;

public sealed class Billing
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal Billing(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Adds a list of accounts for managed billing to a primary account.
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ManagedAccountsAddResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="AddAccountError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This endpoint allows user to add managed accounts to a primary account.
    /// </remarks>
    public Task<ManagedAccountsAddResponse> AddAccount(AddAccountRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.SubscriptionServer("/managedaccounts/actions/add"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<ManagedAccountsAddResponse>(),
            AddAccountError.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Cancel a managed service for an account.
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ManagedAccountCancelResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="CancelManagedAccountActionError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Deactivates a managed billing service relationship between a managed account and the primary account.
    /// </remarks>
    public Task<ManagedAccountCancelResponse> CancelManagedAccountAction(CancelManagedAccountActionRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.SubscriptionServer("/managedaccounts/actions/cancel"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<ManagedAccountCancelResponse>(),
            CancelManagedAccountActionError.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get the list of all managed accounts
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ManagedAccountsGetAllResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="ListManagedAccountError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This endpoint allows user to retrieve the list of all accounts managed by a primary account.
    /// </remarks>
    public Task<ManagedAccountsGetAllResponse> ListManagedAccount(ListManagedAccountRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.SubscriptionServer("/managedaccounts/{accountName}/service/{serviceName}"),
            [
                new TemplateParam("accountName", request.AccountName),
                new TemplateParam("serviceName", request.ServiceName),
            ],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ManagedAccountsGetAllResponse>(),
            ListManagedAccountError.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Activate a specific managed account
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ManagedAccountsProvisionResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="ManagedAccountActionError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Activates a managed billing service relationship between a managed account and the primary account.
    /// </remarks>
    public Task<ManagedAccountsProvisionResponse> ManagedAccountAction(ManagedAccountActionRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.SubscriptionServer("/managedaccounts/actions/provision"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<ManagedAccountsProvisionResponse>(),
            ManagedAccountActionError.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);
}
