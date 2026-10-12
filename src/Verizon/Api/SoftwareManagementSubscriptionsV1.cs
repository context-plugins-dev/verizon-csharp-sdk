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
using Verizon.Requests.SoftwareManagementSubscriptionsV1;

namespace Verizon.Api;

/// <summary>
/// View Software Management Services subscription status.
/// </summary>
public sealed class SoftwareManagementSubscriptionsV1
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal SoftwareManagementSubscriptionsV1(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Get account license information
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AccountLicenseInfo"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetAccountLicenseStatusError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns information about an account's Software Management Services licenses and a list of licensed devices.
    /// </remarks>
    public Task<AccountLicenseInfo> GetAccountLicenseStatus(GetAccountLicenseStatusRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.SoftwareManagementV1("/licenses/{account}/index/{startIndex}"),
            [new TemplateParam("account", request.Account), new TemplateParam("startIndex", request.StartIndex)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<AccountLicenseInfo>(),
            GetAccountLicenseStatusError.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get account subscription status
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1AccountSubscription"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetAccountSubscriptionStatusError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This subscriptions endpoint retrieves an account's current Software Management Service subscription status.
    /// </remarks>
    public Task<V1AccountSubscription> GetAccountSubscriptionStatus(GetAccountSubscriptionStatusRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.SoftwareManagementV1("/subscriptions/{account}"),
            [new TemplateParam("account", request.Account)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<V1AccountSubscription>(),
            GetAccountSubscriptionStatusError.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);
}
