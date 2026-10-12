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
using Verizon.Requests.SoftwareManagementLicensesV1;

namespace Verizon.Api;

/// <summary>
/// Assign Software Management Services license to devices <b>Note:</b>These endpoints have been deprecated. Please use the <b>v3</b> endpoints.
/// </summary>
public sealed class SoftwareManagementLicensesV1
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal SoftwareManagementLicensesV1(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Assign licenses to devices
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1LicensesAssignedRemovedResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="AssignLicensesToDevicesError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Assigns licenses to a specified list of devices so that firmware upgrades can be scheduled for those devices.
    /// </remarks>
    public Task<V1LicensesAssignedRemovedResult> AssignLicensesToDevices(AssignLicensesToDevicesRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.SoftwareManagementV1("/licenses/{account}/assign"),
            [new TemplateParam("account", request.Account)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<V1LicensesAssignedRemovedResult>(),
            AssignLicensesToDevicesError.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Creates a list of devices from which licenses will be removed if the number of MRC licenses becomes less than the number of assigned licenses.
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1ListOfLicensesToRemoveResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="CreateListOfLicensesToRemoveError"/> when the server returns an error response.</exception>
    public Task<V1ListOfLicensesToRemoveResult> CreateListOfLicensesToRemove(CreateListOfLicensesToRemoveRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.SoftwareManagementV1("/licenses/{account}/cancel"),
            [new TemplateParam("account", request.Account)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<V1ListOfLicensesToRemoveResult>(),
            CreateListOfLicensesToRemoveError.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Remove all devices from the cancellation candidate list
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="DeleteListOfLicensesToRemoveError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Deletes the entire list of cancellation candidate devices.
    /// </remarks>
    public Task DeleteListOfLicensesToRemove(DeleteListOfLicensesToRemoveRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.SoftwareManagementV1("/licenses/{account}/cancel"),
            [new TemplateParam("account", request.Account)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            VoidResponse.Instance,
            DeleteListOfLicensesToRemoveError.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get cancellation candidate list
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1ListOfLicensesToRemove"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="ListLicensesToRemoveError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a list of devices from which licenses will be removed if the number of MRC licenses becomes less than the number of assigned licenses.
    /// </remarks>
    public Task<V1ListOfLicensesToRemove> ListLicensesToRemove(ListLicensesToRemoveRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.SoftwareManagementV1("/licenses/{account}/cancel/index/{startIndex}"),
            [new TemplateParam("account", request.Account), new TemplateParam("startIndex", request.StartIndex)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<V1ListOfLicensesToRemove>(),
            ListLicensesToRemoveError.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Remove licenses from device
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1LicensesAssignedRemovedResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RemoveLicensesFromDevicesError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Remove unused licenses from device.
    /// </remarks>
    public Task<V1LicensesAssignedRemovedResult> RemoveLicensesFromDevices(RemoveLicensesFromDevicesRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.SoftwareManagementV1("/licenses/{account}/remove"),
            [new TemplateParam("account", request.Account)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<V1LicensesAssignedRemovedResult>(),
            RemoveLicensesFromDevicesError.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);
}
