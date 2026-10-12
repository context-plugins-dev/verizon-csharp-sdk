using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Verizon.Core;
using Verizon.Core.Authentication;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Exceptions;
using Verizon.Core.Models;
using Verizon.Core.Request;
using Verizon.Core.Response;
using Verizon.Models;
using Verizon.Requests.GbiDeviceActions5;

namespace Verizon.Api;

/// <summary>
/// Activate devices or retrieve device attributes.
/// </summary>
public sealed class GbiDeviceActions5
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal GbiDeviceActions5(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Change a Device's service plan.
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GbiRequestResponse5"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Change a device's service plan to use 5G BI.
    /// </remarks>
    public Task<GbiRequestResponse5> BusinessInternetServiceplanchange(BusinessInternetServiceplanchangeRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Thingspace("/actions/plan"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<GbiRequestResponse5>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.ThingspaceOauth, _auth.VzM2MToken)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Activate a device.
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GbiRequestResponse5"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Uses the device's ICCID and IMEI to activate service.
    /// </remarks>
    public Task<GbiRequestResponse5> BusinessInternetactivateUsingPost(BusinessInternetactivateUsingPostRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Thingspace("/actions/activate"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<GbiRequestResponse5>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.ThingspaceOauth, _auth.VzM2MToken)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// List the 5G BI information for a device by ICCID.
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GbideviceDetailsresponse5"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Uses the decive's Integrated Circuit Card Identification Number (ICCID) to retrive and display the device's properties.
    /// </remarks>
    public Task<GbideviceDetailsresponse5> BusinessInternetlistDeviceInformation(BusinessInternetlistDeviceInformationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Thingspace("/actions/list"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<GbideviceDetailsresponse5>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.ThingspaceOauth, _auth.VzM2MToken)],
            requestOptions,
            cancellationToken);
}
