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
using Verizon.Requests.AccountDevices;

namespace Verizon.Api;

/// <summary>
/// Device information for an account.
/// </summary>
public sealed class AccountDevices
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal AccountDevices(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Retrieve account device information such as reported firmware on the devices.
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V3AccountDeviceList"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetAccountDeviceInformationError"/> when the server returns an error response.</exception>
    public Task<V3AccountDeviceList> GetAccountDeviceInformation(GetAccountDeviceInformationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.SoftwareManagementV3("/devices/{acc}"),
            [new TemplateParam("acc", request.Acc)],
            [new Param("lastSeenDeviceId", request.LastSeenDeviceId), new Param("protocol", request.Protocol)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<V3AccountDeviceList>(),
            GetAccountDeviceInformationError.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get account device information for a list of devices
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeviceListResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="ListAccountDevicesInformationError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieve device information for a list of devices on an account.
    /// </remarks>
    public Task<DeviceListResult> ListAccountDevicesInformation(ListAccountDevicesInformationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.SoftwareManagementV3("/devices/{acc}"),
            [new TemplateParam("acc", request.Acc)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<DeviceListResult>(),
            ListAccountDevicesInformationError.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);
}
