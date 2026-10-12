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
using Verizon.Requests.MapMessageController;

namespace Verizon.Api;

/// <summary>
/// Endpoints for ingesting, querying, and deleting V2X MAP messages.
/// </summary>
public sealed class MapMessageController
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal MapMessageController(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Delete map message
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="DeleteMapMessageError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Removes a map message for the specified region and intersection ID.
    /// </remarks>
    public Task DeleteMapMessage(DeleteMapMessageRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.ImpServer("/api/v2/mapdata/regionid/{regionId}/i10nid/{i10nid}"),
            [new TemplateParam("regionId", request.RegionId), new TemplateParam("i10nid", request.I10Nid)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            VoidResponse.Instance,
            DeleteMapMessageError.Response,
            [_auth.ThingspaceOauth, _auth.SessionToken],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Download SAE J2735 or ETSI MAP messages in ASN.1 UPER base64 encoded format for the given area.
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="string"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="DownloadMapMessagesError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This endpoint is deprecated. (Use /api/v2/mapdata/query for new integrations).
    /// <para>
    /// This endpoint allows user to download SAE J2735 or ETSI MAP messages in ASN.1 UPER base64 encoded format. The area for the MAP messages is needed to be defined in the query.
    /// </para>
    /// <para>
    ///
    /// <b>Required request header:</b> <c>Accept</c> — specifies the response format. Omitting this header will result in a <c>400 Bad Request</c>. Supported values:
    /// - <c>text/plain</c> — ASN.1 UPER base64-encoded MAP messages (one per line)
    /// - <c>application/json</c> — JSON-encoded MAP messages
    /// </para>
    /// </remarks>
    public Task<string> DownloadMapMessages(DownloadMapMessagesRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.ImpServer("/api/v2/mapdata"),
            [],
            [new Param("Geofence", request.Geofence)],
            [new HeaderParam("VendorID", request.VendorId)],
            HttpMethod.Get,
            EmptyBody.Instance,
            PlainTextResponse.CreateString(),
            DownloadMapMessagesError.Response,
            [_auth.ThingspaceOauth, _auth.SessionToken],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Upload SAE J2735 MAP messages in ASN.1 UPER or JER (JSON) base64 encoded format format.
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="string"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="IngestMapMessagesError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This endpoint allows the user to upload map messages in ASN.1 UPER base64 encoded format or JER (JSON) formats. The MAP data message can have more than one intersections in it.
    /// Both SAE and ETSI defined MAP messages are supported. The SAE type MAP messages have to be wrapped in a MessageFrame, as defined in the SAE J2735 standard.
    /// The ETSI type MAP messages are expected as MAPEM structures that include the ETSI header, as defined in the ETSI TS 103 301 standard.
    /// Note: The user needs to authenticate with their ThingSpace credentials using the Access/Bearer and Session/M2M tokens in order to call this API.
    /// <para>
    ///
    /// <b>Required request header:</b> <c>Content-Type</c> — specifies the format of the request body. Omitting or sending an unsupported value will result in a <c>415 Unsupported Media Type</c>. Supported values:
    /// - <c>text/plain</c> — ASN.1 UPER base64-encoded MAP message
    /// - <c>application/json</c> — JSON representation of the MAP message
    /// </para>
    /// </remarks>
    public Task<string> IngestMapMessages(IngestMapMessagesRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.ImpServer("/api/v2/mapdata"),
            [],
            [],
            [
                new HeaderParam("VendorID", request.VendorId),
                new HeaderParam("MessageStandard", request.MapDataMessageStandard),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            PlainTextResponse.CreateString(),
            IngestMapMessagesError.Response,
            [_auth.ThingspaceOauth, _auth.SessionToken],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Retrieve SAE J2735 or ETSI MAP messages as a Json list of ASN.1 UPER base64 encoded message with respective region and intersectionIds for the given area.
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="object"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="QueryMapMessagesError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This endpoint allows users to download SAE J2735 or ETSI MAP messages as a JSON list.
    /// Depending on the expectedType parameter, the response contains either ASN.1 UPER base64-encoded messages with their respective region and intersection IDs, or fully decoded JSON messages.
    /// The area for MAP message retrieval must be defined in the request body using one of two methods:
    /// An array of region and intersection ID pairs, or a GeoJSON geofence specification.
    /// </remarks>
    public Task<IReadOnlyList<object>> QueryMapMessages(QueryMapMessagesRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.ImpServer("/api/v2/mapdata/query"),
            [],
            [],
            [new HeaderParam("VendorID", request.VendorId), new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<IReadOnlyList<object>>(),
            QueryMapMessagesError.Response,
            [_auth.ThingspaceOauth, _auth.SessionToken],
            requestOptions,
            cancellationToken);
}
