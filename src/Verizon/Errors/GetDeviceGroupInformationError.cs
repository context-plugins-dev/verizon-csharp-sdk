using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;
using Verizon.Models;

namespace Verizon.Errors;

public sealed class GetDeviceGroupInformationError : ApiError
{
    private readonly Optional<ConnectivityManagementResult> _connectivityManagementResultValue;

    private GetDeviceGroupInformationError(Optional<ConnectivityManagementResult> connectivityManagementResultValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _connectivityManagementResultValue = connectivityManagementResultValue;
    }

    private static GetDeviceGroupInformationError AsConnectivityManagementResult(ConnectivityManagementResult value) =>
        new(Optional<ConnectivityManagementResult>.Some(value), default);

    private static GetDeviceGroupInformationError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetConnectivityManagementResult(out ConnectivityManagementResult value) =>
        _connectivityManagementResultValue.TryGetValue(out value);

    private static Task<GetDeviceGroupInformationError> Create(FailedResponse response) =>
        response.StatusCode switch
        {
            400 => response.Json<ConnectivityManagementResult>().As(AsConnectivityManagementResult),
            _ => response.RawBody().As(AsFallback)
        };

    internal static ApiErrorResponse<GetDeviceGroupInformationError> Response { get; } = new(Create);
}
