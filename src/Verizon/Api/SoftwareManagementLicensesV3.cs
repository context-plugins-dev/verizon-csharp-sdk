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
using Verizon.Requests.SoftwareManagementLicensesV3;

namespace Verizon.Api;

/// <summary>
/// License status and assignment.
/// </summary>
public sealed class SoftwareManagementLicensesV3
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal SoftwareManagementLicensesV3(RawClient rawClient, Server server, AuthSchemes auth)
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
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V3LicenseAssignedRemovedResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="AssignLicensesToDevices3Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This endpoint allows user to assign licenses to a list of devices.
    /// </remarks>
    public Task<V3LicenseAssignedRemovedResult> AssignLicensesToDevices3(AssignLicensesToDevices3Request request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.SoftwareManagementV3("/licenses/{acc}/assign"),
            [new TemplateParam("acc", request.Acc)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<V3LicenseAssignedRemovedResult>(),
            AssignLicensesToDevices3Error.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Summarize FOTA licenses assignment
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V3LicenseSummary"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetAccountLicensesStatusError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The endpoint allows user to list license usage.
    /// </remarks>
    public Task<V3LicenseSummary> GetAccountLicensesStatus(GetAccountLicensesStatusRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.SoftwareManagementV3("/licenses/{acc}"),
            [new TemplateParam("acc", request.Acc)],
            [new Param("lastSeenDeviceId", request.LastSeenDeviceId)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<V3LicenseSummary>(),
            GetAccountLicensesStatusError.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Remove licenses from devices
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V3LicenseAssignedRemovedResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RemoveLicensesFromDevices3Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This endpoint allows user to remove licenses from a list of devices.
    /// </remarks>
    public Task<V3LicenseAssignedRemovedResult> RemoveLicensesFromDevices3(RemoveLicensesFromDevices3Request request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.SoftwareManagementV3("/licenses/{acc}/remove"),
            [new TemplateParam("acc", request.Acc)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<V3LicenseAssignedRemovedResult>(),
            RemoveLicensesFromDevices3Error.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);
}
