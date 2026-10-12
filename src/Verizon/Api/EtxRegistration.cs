using System;
using System.Collections.Generic;
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
using Verizon.Requests.EtxRegistration;

namespace Verizon.Api;

/// <summary>
/// Manage device registration and connection.
/// </summary>
public sealed class EtxRegistration
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal EtxRegistration(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Retrieve the certificate of a device or a software service in the ETX system.
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ClientPersistenceResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetEtxClientCertificateError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// With this API call the user can check the certificate of the device. At least one of the DeviceID, IMEI, ICCID or IMSI is required to make the call.
    /// <para>
    /// Note: The user needs to authenticate with their ThingSpace credentials using the Access/Bearer and Session/M2M tokens in order to call this API.
    /// </para>
    /// </remarks>
    public Task<ClientPersistenceResponse> GetEtxClientCertificate(GetEtxClientCertificateRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.ImpServer("/api/v2/clients/registration"),
            [],
            [new Param("ID", request.Id)],
            [
                new HeaderParam("VendorID", request.VendorId),
                new HeaderParam("X-Transaction-Id", request.XTransactionId),
            ],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ClientPersistenceResponse>(),
            GetEtxClientCertificateError.Response,
            [_auth.ThingspaceOauth, _auth.SessionToken],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Retrieve MQTT URL for device or software service connection to the Message Exchange
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ConnectionResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetEtxConnectionUrlError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// With this API call the device or software service requests the MQTT URL for the location that it needs to connect. To determine the proper URL the device or software service needs to provide its ID (the one that was provided in the registration request), location (GPS coordinates), and whether it is on the Verizon cellular network or not.
    /// <para>
    /// Note: The user needs to authenticate with their ThingSpace credentials using the Access/Bearer and Session/M2M tokens in order to call this API.
    /// </para>
    /// </remarks>
    public Task<ConnectionResponse> GetEtxConnectionUrl(GetEtxConnectionUrlRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.ImpServer("/api/v2/clients/connection"),
            [],
            [],
            [
                new HeaderParam("VendorID", request.VendorId),
                new HeaderParam("X-Transaction-Id", request.XTransactionId),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<ConnectionResponse>(),
            GetEtxConnectionUrlError.Response,
            [_auth.ThingspaceOauth, _auth.SessionToken],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Retrieve MQTT URL for device or software service connection to the Message Exchange with muti-MECs support
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ConnectionResponseV3"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetEtxConnectionUrlMultiMecError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// With this API call the device or software service requests the MQTT URL for the location that it needs to connect. To determine the proper URL the device or software service needs to provide its ID (the one that was provided in the registration request), location (GPS coordinates), and whether it is on the Verizon cellular network or not.
    /// <para>
    /// If there are multiple MECs that serve the location of the client all options are provided in the response, and the client is free to choose which MEC they want to connect.
    /// </para>
    /// <para>
    /// Note: The user needs to authenticate with their ThingSpace credentials using the Access/Bearer and Session/M2M tokens in order to call this API.
    /// </para>
    /// </remarks>
    public Task<ConnectionResponseV3> GetEtxConnectionUrlMultiMec(GetEtxConnectionUrlMultiMecRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.ImpServer("/api/v3/clients/connection"),
            [],
            [],
            [
                new HeaderParam("VendorID", request.VendorId),
                new HeaderParam("X-Transaction-Id", request.XTransactionId),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<ConnectionResponseV3>(),
            GetEtxConnectionUrlMultiMecError.Response,
            [_auth.ThingspaceOauth, _auth.SessionToken],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Retrieve devices by vendor and optional filters
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="DevicesResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="QueryEtxDevicesError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This API allows retrieving devices by vendor ID and optional filters. The request should include the VendorID and any filters to apply.
    /// </remarks>
    public Task<IReadOnlyList<DevicesResponse>> QueryEtxDevices(QueryEtxDevicesRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.ImpServer("/api/v1/clients/query"),
            [],
            [],
            [
                new HeaderParam("X-Transaction-Id", request.XTransactionId),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<IReadOnlyList<DevicesResponse>>(),
            QueryEtxDevicesError.Response,
            [_auth.ThingspaceOauth, _auth.SessionToken],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Register a device or a software service to the ETX system.
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ClientRegistrationResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RegisterEtxClientError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// With this API call the user (client) registers its device or software service to the ETX system. Therefore, when a connection is initiated from the device or software service to the ETX system along with the credential provided by this registration call, then the connection will be authorized.
    /// <list type="bullet">
    ///   <item><description>The user can register multiple devices or software services, which can all be used at the same time.</description></item>
    ///   <item><description>There rules set in the system that limit the type and subtype of the clients that are allowed to be registered under the VendorID. The rules are created based ont he agreement between the Vendor and Verizon.</description></item>
    ///   <item><description>The user will only be able to register a limited number of devices or software services under the same VendorID. This registration limit is specified by the agreement between the Vendor and Verizon.</description></item>
    /// </list>
    /// <para>
    /// Note: The user needs to authenticate with their ThingSpace credentials using the Access/Bearer and Session/M2M tokens in order to call this API.
    /// </para>
    /// </remarks>
    public Task<ClientRegistrationResponse> RegisterEtxClient(RegisterEtxClientRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.ImpServer("/api/v2/clients/registration"),
            [],
            [],
            [
                new HeaderParam("X-Transaction-Id", request.XTransactionId),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<ClientRegistrationResponse>(),
            RegisterEtxClientError.Response,
            [_auth.ThingspaceOauth, _auth.SessionToken],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Renew a device certificate or complete the registration for a device with pending certificate
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ClientRegistrationResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RenewEtxClientCertificateError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// With this API call the user (client) can:
    /// - renew the certificate of a device or software service in the ETX system if the original certificate has expired. If the client's certificate expired or going to expire within 30 days and new certificate will be issued. If the certificate expires more than 30 days, the current certificate will be returned to the client.
    /// - complete its device or software service registration to the ETX system if the original registration request was not successful because of a pending certificate generation. Whenever the user receives a "client registration is pending" response (HTTP 202) from POST /clients/registration call. The client should initiate this PUT API call to finish the registration process and get the required certificate.
    /// <para>
    /// Note: The user needs to authenticate with their ThingSpace credentials using the Access/Bearer and Session/M2M tokens in order to call this API.
    /// </para>
    /// </remarks>
    public Task<ClientRegistrationResponse> RenewEtxClientCertificate(RenewEtxClientCertificateRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.ImpServer("/api/v2/clients/registration"),
            [],
            [],
            [
                new HeaderParam("DeviceID", request.DeviceId),
                new HeaderParam("VendorID", request.VendorId),
                new HeaderParam("X-Transaction-Id", request.XTransactionId),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Put,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<ClientRegistrationResponse>(),
            RenewEtxClientCertificateError.Response,
            [_auth.ThingspaceOauth, _auth.SessionToken],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Unregister a list of devices and software services from the ETX system.
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="UnregisterEtxClientsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// With this API call the user (client) can unregister its devices and software services from the ETX system. The unregistered devices and services will no longer be able to use the ETX Message Exchange.
    /// <para>
    /// Note: The user needs to authenticate with their ThingSpace credentials using the Access/Bearer and Session/M2M tokens in order to call this API.
    /// </para>
    /// </remarks>
    public Task UnregisterEtxClients(UnregisterEtxClientsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.ImpServer("/api/v2/clients/registration"),
            [],
            [new Param("DeviceIDs", request.DeviceIDs)],
            [
                new HeaderParam("VendorID", request.VendorId),
                new HeaderParam("X-Transaction-Id", request.XTransactionId),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Delete,
            EmptyBody.Instance,
            VoidResponse.Instance,
            UnregisterEtxClientsError.Response,
            [_auth.ThingspaceOauth, _auth.SessionToken],
            requestOptions,
            cancellationToken);
}
