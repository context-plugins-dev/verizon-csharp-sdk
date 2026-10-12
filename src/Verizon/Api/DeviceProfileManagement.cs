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
using Verizon.Requests.DeviceProfileManagement;

namespace Verizon.Api;

public sealed class DeviceProfileManagement
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal DeviceProfileManagement(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Activate a device for a profile.
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RequestResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="ActivateDeviceThroughProfileError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Uses the profile to bring the device under management.
    /// </remarks>
    public Task<RequestResponse> ActivateDeviceThroughProfile(ActivateDeviceThroughProfileRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Thingspace("/m2m/v1/devices/profile/actions/activate_enable"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<RequestResponse>(),
            ActivateDeviceThroughProfileError.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Activate a device.
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RequestResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="ProfileToActivateDeviceError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Uses the profile to activate the device.
    /// </remarks>
    public Task<RequestResponse> ProfileToActivateDevice(ProfileToActivateDeviceRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Thingspace("/m2m/v1/devices/profile/actions/activate"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<RequestResponse>(),
            ProfileToActivateDeviceError.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Deactivate a device.
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RequestResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="ProfileToDeactivateDeviceError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Uses the profile to deactivate the device.
    /// </remarks>
    public Task<RequestResponse> ProfileToDeactivateDevice(ProfileToDeactivateDeviceRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Thingspace("/m2m/v1/devices/profile/actions/deactivate"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<RequestResponse>(),
            ProfileToDeactivateDeviceError.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Set the fallback attribute.
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RequestResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="ProfileToSetFallbackAttributeError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Allows the profile to set the fallback attribute to the device.
    /// </remarks>
    public Task<RequestResponse> ProfileToSetFallbackAttribute(ProfileToSetFallbackAttributeRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Thingspace("/m2m/v1/devices/profile/actions/setfallbackattribute"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<RequestResponse>(),
            ProfileToSetFallbackAttributeError.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);
}
