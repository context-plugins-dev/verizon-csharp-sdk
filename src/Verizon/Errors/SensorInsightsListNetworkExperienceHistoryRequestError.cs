using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;
using Verizon.Models;

namespace Verizon.Errors;

public sealed class SensorInsightsListNetworkExperienceHistoryRequestError : ApiError
{
    private readonly Optional<ManagementError400> _managementError400Value;

    private readonly Optional<ManagementError> _managementErrorValue;

    private readonly Optional<ManagementError403> _managementError403Value;

    private readonly Optional<ManagementError404> _managementError404Value;

    private readonly Optional<ManagementError500> _managementError500Value;

    private SensorInsightsListNetworkExperienceHistoryRequestError(Optional<ManagementError400> managementError400Value,
        Optional<ManagementError> managementErrorValue,
        Optional<ManagementError403> managementError403Value,
        Optional<ManagementError404> managementError404Value,
        Optional<ManagementError500> managementError500Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _managementError400Value = managementError400Value;
        _managementErrorValue = managementErrorValue;
        _managementError403Value = managementError403Value;
        _managementError404Value = managementError404Value;
        _managementError500Value = managementError500Value;
    }

    private static SensorInsightsListNetworkExperienceHistoryRequestError AsManagementError400(ManagementError400 value) =>
        new(Optional<ManagementError400>.Some(value), default, default, default, default, default);

    private static SensorInsightsListNetworkExperienceHistoryRequestError AsManagementError(ManagementError value) =>
        new(default, Optional<ManagementError>.Some(value), default, default, default, default);

    private static SensorInsightsListNetworkExperienceHistoryRequestError AsManagementError403(ManagementError403 value) =>
        new(default, default, Optional<ManagementError403>.Some(value), default, default, default);

    private static SensorInsightsListNetworkExperienceHistoryRequestError AsManagementError404(ManagementError404 value) =>
        new(default, default, default, Optional<ManagementError404>.Some(value), default, default);

    private static SensorInsightsListNetworkExperienceHistoryRequestError AsManagementError500(ManagementError500 value) =>
        new(default, default, default, default, Optional<ManagementError500>.Some(value), default);

    private static SensorInsightsListNetworkExperienceHistoryRequestError AsFallback(RawError value) =>
        new(default, default, default, default, default, Optional<RawError>.Some(value));

    public bool TryGetManagementError400(out ManagementError400 value) =>
        _managementError400Value.TryGetValue(out value);

    public bool TryGetManagementError(out ManagementError value) => _managementErrorValue.TryGetValue(out value);

    public bool TryGetManagementError403(out ManagementError403 value) =>
        _managementError403Value.TryGetValue(out value);

    public bool TryGetManagementError404(out ManagementError404 value) =>
        _managementError404Value.TryGetValue(out value);

    public bool TryGetManagementError500(out ManagementError500 value) =>
        _managementError500Value.TryGetValue(out value);

    private static Task<SensorInsightsListNetworkExperienceHistoryRequestError> Create(FailedResponse response) =>
        response.StatusCode switch
        {
            400 => response.Json<ManagementError400>().As(AsManagementError400),
            401 or 406 or 415 or 429 => response.Json<ManagementError>().As(AsManagementError),
            403 => response.Json<ManagementError403>().As(AsManagementError403),
            404 => response.Json<ManagementError404>().As(AsManagementError404),
            500 => response.Json<ManagementError500>().As(AsManagementError500),
            _ => response.RawBody().As(AsFallback)
        };

    internal static ApiErrorResponse<SensorInsightsListNetworkExperienceHistoryRequestError> Response { get; } = new(
        Create);
}
