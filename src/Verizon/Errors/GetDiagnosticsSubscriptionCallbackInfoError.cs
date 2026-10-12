using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;
using Verizon.Models;

namespace Verizon.Errors;

public sealed class GetDiagnosticsSubscriptionCallbackInfoError : ApiError
{
    private readonly Optional<DeviceDiagnosticsResult> _deviceDiagnosticsResultValue;

    private GetDiagnosticsSubscriptionCallbackInfoError(Optional<DeviceDiagnosticsResult> deviceDiagnosticsResultValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _deviceDiagnosticsResultValue = deviceDiagnosticsResultValue;
    }

    private static GetDiagnosticsSubscriptionCallbackInfoError AsDeviceDiagnosticsResult(DeviceDiagnosticsResult value) =>
        new(Optional<DeviceDiagnosticsResult>.Some(value), default);

    private static GetDiagnosticsSubscriptionCallbackInfoError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetDeviceDiagnosticsResult(out DeviceDiagnosticsResult value) =>
        _deviceDiagnosticsResultValue.TryGetValue(out value);

    private static Task<GetDiagnosticsSubscriptionCallbackInfoError> Create(FailedResponse response) =>
        response.StatusCode switch
        {
            400 => response.Json<DeviceDiagnosticsResult>().As(AsDeviceDiagnosticsResult),
            _ => response.RawBody().As(AsFallback)
        };

    internal static ApiErrorResponse<GetDiagnosticsSubscriptionCallbackInfoError> Response { get; } = new(Create);
}
