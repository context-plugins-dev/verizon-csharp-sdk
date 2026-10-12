using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;
using Verizon.Models;

namespace Verizon.Errors;

public sealed class DownloadLocalProfileToEnableError : ApiError
{
    private readonly Optional<ConnectivityManagementResult> _connectivityManagementResultValue;

    private DownloadLocalProfileToEnableError(Optional<ConnectivityManagementResult> connectivityManagementResultValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _connectivityManagementResultValue = connectivityManagementResultValue;
    }

    private static DownloadLocalProfileToEnableError AsConnectivityManagementResult(ConnectivityManagementResult value) =>
        new(Optional<ConnectivityManagementResult>.Some(value), default);

    private static DownloadLocalProfileToEnableError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetConnectivityManagementResult(out ConnectivityManagementResult value) =>
        _connectivityManagementResultValue.TryGetValue(out value);

    private static Task<DownloadLocalProfileToEnableError> Create(FailedResponse response) =>
        response.StatusCode switch
        {
            400 => response.Json<ConnectivityManagementResult>().As(AsConnectivityManagementResult),
            _ => response.RawBody().As(AsFallback)
        };

    internal static ApiErrorResponse<DownloadLocalProfileToEnableError> Response { get; } = new(Create);
}
