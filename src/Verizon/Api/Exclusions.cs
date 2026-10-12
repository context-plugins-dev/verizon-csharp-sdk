using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Verizon.Core;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Exceptions;
using Verizon.Core.Models;
using Verizon.Core.Request;
using Verizon.Core.Response;
using Verizon.Errors;
using Verizon.Models;
using Verizon.Requests.Exclusions;

namespace Verizon.Api;

/// <summary>
/// Exclude devices from location services.
/// </summary>
public sealed class Exclusions
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal Exclusions(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Retrieve the consent record for devices on an account
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GetAccountDeviceConsent"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Get the consent settings for the entire account or device list in an account.
    /// </remarks>
    public Task<GetAccountDeviceConsent> DevicesLocationGetConsentAsync(DevicesLocationGetConsentAsyncRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.DeviceLocation("/devicelocations/action/consents"),
            [],
            [new Param("accountName", request.AccountName), new Param("deviceId", request.DeviceId)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<GetAccountDeviceConsent>(),
            RawErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Create the consent record for an account
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ConsentTransactionId"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Create a consent record to use location services as an asynchronous request.
    /// </remarks>
    public Task<ConsentTransactionId> DevicesLocationGiveConsentAsync(DevicesLocationGiveConsentAsyncRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.DeviceLocation("/devicelocations/action/consents"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<ConsentTransactionId>(),
            RawErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Updates a consent record for an account
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ConsentTransactionId"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Update the location services consent record for an entire account.
    /// </remarks>
    public Task<ConsentTransactionId> DevicesLocationUpdateConsent(DevicesLocationUpdateConsentRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.DeviceLocation("/devicelocations/action/consents"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<ConsentTransactionId>(),
            RawErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Update account consent exclusion
    /// </summary>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeviceLocationSuccessResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="ExcludeDevicesError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This consents endpoint sets a new exclusion list.
    /// </remarks>
    public Task<DeviceLocationSuccessResult> ExcludeDevices(RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.DeviceLocation("/consents"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<DeviceLocationSuccessResult>(),
            ExcludeDevicesError.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get a consent exclusion
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DevicesConsentResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="ListExcludedDevicesError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This consents endpoint retrieves a list of excluded devices in an account.
    /// </remarks>
    public Task<DevicesConsentResult> ListExcludedDevices(ListExcludedDevicesRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.DeviceLocation("/consents/{accountName}/index/{startIndex}"),
            [
                new TemplateParam("accountName", request.AccountName),
                new TemplateParam("startIndex", request.StartIndex),
            ],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<DevicesConsentResult>(),
            ListExcludedDevicesError.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Remove devices from exclusion list
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeviceLocationSuccessResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RemoveDevicesFromExclusionListError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Removes devices from the exclusion list so that they can be located with Device Location Services requests.
    /// </remarks>
    public Task<DeviceLocationSuccessResult> RemoveDevicesFromExclusionList(RemoveDevicesFromExclusionListRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.DeviceLocation("/consents"),
            [],
            [new Param("accountName", request.AccountName), new Param("deviceList", request.DeviceList)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<DeviceLocationSuccessResult>(),
            RemoveDevicesFromExclusionListError.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);
}
