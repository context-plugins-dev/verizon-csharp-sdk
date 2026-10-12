using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;
using Verizon.Models;

namespace Verizon.Errors;

public sealed class DeleteTriggerError : ApiError
{
    private readonly Optional<DeviceLocationResult> _deviceLocationResultValue;

    private DeleteTriggerError(Optional<DeviceLocationResult> deviceLocationResultValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _deviceLocationResultValue = deviceLocationResultValue;
    }

    private static DeleteTriggerError AsDeviceLocationResult(DeviceLocationResult value) =>
        new(Optional<DeviceLocationResult>.Some(value), default);

    private static DeleteTriggerError AsFallback(RawError value) => new(default, Optional<RawError>.Some(value));

    public bool TryGetDeviceLocationResult(out DeviceLocationResult value) =>
        _deviceLocationResultValue.TryGetValue(out value);

    private static Task<DeleteTriggerError> Create(FailedResponse response) =>
        response.StatusCode switch
        {
            400 => response.Json<DeviceLocationResult>().As(AsDeviceLocationResult),
            _ => response.RawBody().As(AsFallback)
        };

    internal static ApiErrorResponse<DeleteTriggerError> Response { get; } = new(Create);
}
