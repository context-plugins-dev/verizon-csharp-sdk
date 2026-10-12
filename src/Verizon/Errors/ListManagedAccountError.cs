using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;
using Verizon.Models;

namespace Verizon.Errors;

public sealed class ListManagedAccountError : ApiError
{
    private readonly Optional<DeviceLocationResult> _deviceLocationResultValue;

    private ListManagedAccountError(Optional<DeviceLocationResult> deviceLocationResultValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _deviceLocationResultValue = deviceLocationResultValue;
    }

    private static ListManagedAccountError AsDeviceLocationResult(DeviceLocationResult value) =>
        new(Optional<DeviceLocationResult>.Some(value), default);

    private static ListManagedAccountError AsFallback(RawError value) => new(default, Optional<RawError>.Some(value));

    public bool TryGetDeviceLocationResult(out DeviceLocationResult value) =>
        _deviceLocationResultValue.TryGetValue(out value);

    private static Task<ListManagedAccountError> Create(FailedResponse response) =>
        response.StatusCode switch
        {
            400 => response.Json<DeviceLocationResult>().As(AsDeviceLocationResult),
            _ => response.RawBody().As(AsFallback)
        };

    internal static ApiErrorResponse<ListManagedAccountError> Response { get; } = new(Create);
}
