using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;
using Verizon.Models;

namespace Verizon.Errors;

public sealed class UnregisterDiagnosticsCallbackError : ApiError
{
    private readonly Optional<DeviceDiagnosticsResult> _deviceDiagnosticsResultValue;

    private UnregisterDiagnosticsCallbackError(Optional<DeviceDiagnosticsResult> deviceDiagnosticsResultValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _deviceDiagnosticsResultValue = deviceDiagnosticsResultValue;
    }

    private static UnregisterDiagnosticsCallbackError AsDeviceDiagnosticsResult(DeviceDiagnosticsResult value) =>
        new(Optional<DeviceDiagnosticsResult>.Some(value), default);

    private static UnregisterDiagnosticsCallbackError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetDeviceDiagnosticsResult(out DeviceDiagnosticsResult value) =>
        _deviceDiagnosticsResultValue.TryGetValue(out value);

    private static Task<UnregisterDiagnosticsCallbackError> Create(FailedResponse response) =>
        response.StatusCode switch
        {
            400 => response.Json<DeviceDiagnosticsResult>().As(AsDeviceDiagnosticsResult),
            _ => response.RawBody().As(AsFallback)
        };

    internal static ApiErrorResponse<UnregisterDiagnosticsCallbackError> Response { get; } = new(Create);
}
