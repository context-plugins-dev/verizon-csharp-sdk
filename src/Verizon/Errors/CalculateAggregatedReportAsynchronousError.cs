using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;
using Verizon.Models;

namespace Verizon.Errors;

public sealed class CalculateAggregatedReportAsynchronousError : ApiError
{
    private readonly Optional<HyperPreciseLocationResult> _hyperPreciseLocationResultValue;

    private CalculateAggregatedReportAsynchronousError(Optional<HyperPreciseLocationResult> hyperPreciseLocationResultValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _hyperPreciseLocationResultValue = hyperPreciseLocationResultValue;
    }

    private static CalculateAggregatedReportAsynchronousError AsHyperPreciseLocationResult(HyperPreciseLocationResult value) =>
        new(Optional<HyperPreciseLocationResult>.Some(value), default);

    private static CalculateAggregatedReportAsynchronousError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetHyperPreciseLocationResult(out HyperPreciseLocationResult value) =>
        _hyperPreciseLocationResultValue.TryGetValue(out value);

    private static Task<CalculateAggregatedReportAsynchronousError> Create(FailedResponse response) =>
        response.StatusCode switch
        {
            400 or 401 or 403 or 404 or 409 or 500 => response.Json<HyperPreciseLocationResult>().As(
                AsHyperPreciseLocationResult),
            _ => response.RawBody().As(AsFallback)
        };

    internal static ApiErrorResponse<CalculateAggregatedReportAsynchronousError> Response { get; } = new(Create);
}
