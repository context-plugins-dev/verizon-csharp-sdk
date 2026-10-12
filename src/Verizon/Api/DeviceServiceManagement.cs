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
using Verizon.Requests.DeviceServiceManagement;

namespace Verizon.Api;

/// <summary>
/// Check status and enable or disable service for Hyper Precise
/// </summary>
public sealed class DeviceServiceManagement
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal DeviceServiceManagement(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Get a hyper precise status
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="BullseyeServiceResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetDeviceHyperPreciseStatusError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Gets the list of a status for hyper-precise location devices.
    /// </remarks>
    public Task<BullseyeServiceResult> GetDeviceHyperPreciseStatus(GetDeviceHyperPreciseStatusRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.HyperPreciseLocation("/devices/services"),
            [],
            [new Param("imei", request.Imei), new Param("accountNumber", request.AccountNumber)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<BullseyeServiceResult>(),
            GetDeviceHyperPreciseStatusError.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Enable or disable hyper-precise
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="BullseyeServiceResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="UpdateDeviceHyperPreciseStatusError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Enable/disable hyper-precise service for a device.
    /// </remarks>
    public Task<BullseyeServiceResult> UpdateDeviceHyperPreciseStatus(UpdateDeviceHyperPreciseStatusRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.HyperPreciseLocation("/devices/services"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<BullseyeServiceResult>(),
            UpdateDeviceHyperPreciseStatusError.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);
}
