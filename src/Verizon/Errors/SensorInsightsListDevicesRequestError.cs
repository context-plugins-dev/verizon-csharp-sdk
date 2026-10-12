using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;
using Verizon.Models;

namespace Verizon.Errors;

public sealed class SensorInsightsListDevicesRequestError : ApiError
{
    private readonly Optional<ManagementError> _managementErrorValue;

    private SensorInsightsListDevicesRequestError(Optional<ManagementError> managementErrorValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _managementErrorValue = managementErrorValue;
    }

    private static SensorInsightsListDevicesRequestError AsManagementError(ManagementError value) =>
        new(Optional<ManagementError>.Some(value), default);

    private static SensorInsightsListDevicesRequestError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetManagementError(out ManagementError value) => _managementErrorValue.TryGetValue(out value);

    private static Task<SensorInsightsListDevicesRequestError> Create(FailedResponse response) =>
        response.StatusCode switch
        {
            400 or 401 or 403 or 404 or 406 or 415 or 429 or 500 => response.Json<ManagementError>().As(
                AsManagementError),
            _ => response.RawBody().As(AsFallback)
        };

    internal static ApiErrorResponse<SensorInsightsListDevicesRequestError> Response { get; } = new(Create);
}
