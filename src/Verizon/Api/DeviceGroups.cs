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
using Verizon.Requests.DeviceGroups;

namespace Verizon.Api;

/// <summary>
/// Manage device groups.
/// </summary>
public sealed class DeviceGroups
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal DeviceGroups(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Creates a new device group and optionally adds a set of devices to that group.
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ConnectivityManagementSuccessResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="CreateDeviceGroupError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Create a new device group and optionally add devices to the group. Device groups can make it easier to manage similar devices and to get reports on their usage.
    /// </remarks>
    public Task<ConnectivityManagementSuccessResult> CreateDeviceGroup(CreateDeviceGroupOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Thingspace("/m2m/v1/groups"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<ConnectivityManagementSuccessResult>(),
            CreateDeviceGroupError.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Deletes a device group. Devices in the group are moved to the default device group and are not deleted from the account.
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ConnectivityManagementSuccessResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="DeleteDeviceGroupError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Deletes a device group from the account. Devices in the group are moved to the default device group and are not deleted from the account.
    /// </remarks>
    public Task<ConnectivityManagementSuccessResult> DeleteDeviceGroup(DeleteDeviceGroupRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Thingspace("/m2m/v1/groups/{aname}/name/{gname}"),
            [new TemplateParam("aname", request.Aname), new TemplateParam("gname", request.Gname)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<ConnectivityManagementSuccessResult>(),
            DeleteDeviceGroupError.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Returns the name, description, and list of devices in a device group.
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeviceGroupDevicesData"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetDeviceGroupInformationError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// When HTTP status is 202, a URL will be returned in the Location header of the form /groups/{aname}/name/{gname}/?next={token}. This URL can be used to request the next set of groups.
    /// </remarks>
    public Task<DeviceGroupDevicesData> GetDeviceGroupInformation(GetDeviceGroupInformationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Thingspace("/m2m/v1/groups/{aname}/name/{gname}"),
            [new TemplateParam("aname", request.Aname), new TemplateParam("gname", request.Gname)],
            [new Param("next", request.Next)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<DeviceGroupDevicesData>(),
            GetDeviceGroupInformationError.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Returns a list of device groups in an account
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="DeviceGroup"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="ListDeviceGroupsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a list of all device groups in a specified account.
    /// </remarks>
    public Task<IReadOnlyList<DeviceGroup>> ListDeviceGroups(ListDeviceGroupsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Thingspace("/m2m/v1/groups/{aname}"),
            [new TemplateParam("aname", request.Aname)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<DeviceGroup>>(),
            ListDeviceGroupsError.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Make changes to a device group, including changing the name and description, and adding or removing devices.
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ConnectivityManagementSuccessResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="UpdateDeviceGroupError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Make changes to a device group, including changing the name and description, and adding or removing devices.
    /// </remarks>
    public Task<ConnectivityManagementSuccessResult> UpdateDeviceGroup(UpdateDeviceGroupRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Thingspace("/m2m/v1/groups/{aname}/name/{gname}"),
            [new TemplateParam("aname", request.Aname), new TemplateParam("gname", request.Gname)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<ConnectivityManagementSuccessResult>(),
            UpdateDeviceGroupError.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);
}
