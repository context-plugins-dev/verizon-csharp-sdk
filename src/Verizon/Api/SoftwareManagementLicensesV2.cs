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
using Verizon.Requests.SoftwareManagementLicensesV2;

namespace Verizon.Api;

/// <summary>
/// License status and assignment.
/// </summary>
public sealed class SoftwareManagementLicensesV2
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal SoftwareManagementLicensesV2(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Assign FOTA licenses to devices
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V2LicensesAssignedRemovedResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="AssignLicensesToDevices2Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This endpoint allows user to assign licenses to a list of devices.
    /// </remarks>
    public Task<V2LicensesAssignedRemovedResult> AssignLicensesToDevices2(AssignLicensesToDevices2Request request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.SoftwareManagementV2("/licenses/{account}/assign"),
            [new TemplateParam("account", request.Account)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<V2LicensesAssignedRemovedResult>(),
            AssignLicensesToDevices2Error.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Create a list of license cancellation candidate devices
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V2ListOfLicensesToRemoveResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="CreateListOfLicensesToRemove2Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The license cancel endpoint allows user to create a list of license cancellation candidate devices.
    /// </remarks>
    public Task<V2ListOfLicensesToRemoveResult> CreateListOfLicensesToRemove2(CreateListOfLicensesToRemove2Request request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.SoftwareManagementV2("/licenses/{account}/cancel"),
            [new TemplateParam("account", request.Account)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<V2ListOfLicensesToRemoveResult>(),
            CreateListOfLicensesToRemove2Error.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Delete a previously created cancel candidate device list
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="FotaV2SuccessResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="DeleteListOfLicensesToRemove2Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This endpoint allows user to delete a created cancel candidate device list.
    /// </remarks>
    public Task<FotaV2SuccessResult> DeleteListOfLicensesToRemove2(DeleteListOfLicensesToRemove2Request request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.SoftwareManagementV2("/licenses/{account}/cancel"),
            [new TemplateParam("account", request.Account)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<FotaV2SuccessResult>(),
            DeleteListOfLicensesToRemove2Error.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Summarize FOTA licenses assignment
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V2LicenseSummary"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetAccountLicenseStatus2Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The endpoint allows user to list license usage.
    /// </remarks>
    public Task<V2LicenseSummary> GetAccountLicenseStatus2(GetAccountLicenseStatus2Request request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.SoftwareManagementV2("/licenses/{account}"),
            [new TemplateParam("account", request.Account)],
            [new Param("lastSeenDeviceId", request.LastSeenDeviceId)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<V2LicenseSummary>(),
            GetAccountLicenseStatus2Error.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Retrieve a list of license cancellation candidate devices
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V2ListOfLicensesToRemove"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="ListLicensesToRemove2Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The license cancel endpoint allows user to list registered license cancellation candidate devices.
    /// </remarks>
    public Task<V2ListOfLicensesToRemove> ListLicensesToRemove2(ListLicensesToRemove2Request request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.SoftwareManagementV2("/licenses/{account}/cancel"),
            [new TemplateParam("account", request.Account)],
            [new Param("startIndex", request.StartIndex)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<V2ListOfLicensesToRemove>(),
            ListLicensesToRemove2Error.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Remove licenses from devices
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V2LicensesAssignedRemovedResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RemoveLicensesFromDevices2Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This endpoint allows user to remove licenses from a list of devices.
    /// </remarks>
    public Task<V2LicensesAssignedRemovedResult> RemoveLicensesFromDevices2(RemoveLicensesFromDevices2Request request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.SoftwareManagementV2("/licenses/{account}/remove"),
            [new TemplateParam("account", request.Account)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<V2LicensesAssignedRemovedResult>(),
            RemoveLicensesFromDevices2Error.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);
}
