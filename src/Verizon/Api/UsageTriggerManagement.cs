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
using Verizon.Requests.UsageTriggerManagement;

namespace Verizon.Api;

public sealed class UsageTriggerManagement
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal UsageTriggerManagement(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Create a new usage trigger
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="UsageTriggerResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="CreateNewTriggerError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Create a new usage trigger, which will send an alert when the number of device location service transactions reaches a specified percentage of the monthly subscription amount.
    /// </remarks>
    public Task<UsageTriggerResponse> CreateNewTrigger(CreateNewTriggerRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.SubscriptionServer("/usage/triggers"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<UsageTriggerResponse>(),
            CreateNewTriggerError.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Deletes a usage trigger
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeviceLocationSuccessResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="DeleteTriggerError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// eletes the specified usage trigger from the given account
    /// </remarks>
    public Task<DeviceLocationSuccessResult> DeleteTrigger(DeleteTriggerRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.SubscriptionServer("/usage/accounts/{accountName}/triggers/{triggerId}"),
            [new TemplateParam("accountName", request.AccountName), new TemplateParam("triggerId", request.TriggerId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<DeviceLocationSuccessResult>(),
            DeleteTriggerError.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Change the settings of an existing usage trigger
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="UsageTriggerResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="UpdateTriggerError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Update an existing usage trigger
    /// </remarks>
    public Task<UsageTriggerResponse> UpdateTrigger(UpdateTriggerOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.SubscriptionServer("/usage/triggers/{triggerId}"),
            [new TemplateParam("triggerId", request.TriggerId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<UsageTriggerResponse>(),
            UpdateTriggerError.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);
}
