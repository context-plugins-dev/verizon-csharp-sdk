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
using Verizon.Requests.ConfigurationFiles;

namespace Verizon.Api;

public sealed class ConfigurationFiles
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal ConfigurationFiles(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Retrieves a list of available files.
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RetrievesAvailableFilesResponseList"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetListOfFilesError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// You can retrieve a list of configuration or supplementary of files for an account.
    /// </remarks>
    public Task<RetrievesAvailableFilesResponseList> GetListOfFiles(GetListOfFilesRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.SoftwareManagementV2("/files/{acc}"),
            [new TemplateParam("acc", request.Acc)],
            [new Param("distributionType", request.DistributionType)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<RetrievesAvailableFilesResponseList>(),
            GetListOfFilesError.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Uploads a configuration supplementary file for an account.
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="UploadConfigurationFilesResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="UploadConfigFileError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Uploads a configuration/supplementary file for an account. ThingSpace generates a fileName after the upload and is returned in the response.
    /// </remarks>
    public Task<UploadConfigurationFilesResponse> UploadConfigFile(UploadConfigFileRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.SoftwareManagementV2("/files/{acc}"),
            [new TemplateParam("acc", request.Acc)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormRequest.Create(
                new MultipartParam("fileupload", request.Fileupload),
                new MultipartParam("fileVersion", request.FileVersion),
                new MultipartParam("make", request.Make),
                new MultipartParam("model", request.Model),
                new MultipartParam("localTargetPath", request.LocalTargetPath)),
            JsonResponse.Create<UploadConfigurationFilesResponse>(),
            UploadConfigFileError.Response,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            cancellationToken);
}
