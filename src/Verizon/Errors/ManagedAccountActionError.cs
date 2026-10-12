using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;
using Verizon.Models;

namespace Verizon.Errors;

public sealed class ManagedAccountActionError : ApiError
{
    private readonly Optional<DeviceLocationResult> _deviceLocationResultValue;

    private ManagedAccountActionError(Optional<DeviceLocationResult> deviceLocationResultValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _deviceLocationResultValue = deviceLocationResultValue;
    }

    private static ManagedAccountActionError AsDeviceLocationResult(DeviceLocationResult value) =>
        new(Optional<DeviceLocationResult>.Some(value), default);

    private static ManagedAccountActionError AsFallback(RawError value) => new(default, Optional<RawError>.Some(value));

    public bool TryGetDeviceLocationResult(out DeviceLocationResult value) =>
        _deviceLocationResultValue.TryGetValue(out value);

    private static Task<ManagedAccountActionError> Create(FailedResponse response) =>
        response.StatusCode switch
        {
            400 => response.Json<DeviceLocationResult>().As(AsDeviceLocationResult),
            _ => response.RawBody().As(AsFallback)
        };

    internal static ApiErrorResponse<ManagedAccountActionError> Response { get; } = new(Create);
}
