using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;
using Verizon.Models;

namespace Verizon.Errors;

public sealed class UpdateAnomalyDetectionTriggerError : ApiError
{
    private readonly Optional<IntelligenceResult> _intelligenceResultValue;

    private UpdateAnomalyDetectionTriggerError(Optional<IntelligenceResult> intelligenceResultValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _intelligenceResultValue = intelligenceResultValue;
    }

    private static UpdateAnomalyDetectionTriggerError AsIntelligenceResult(IntelligenceResult value) =>
        new(Optional<IntelligenceResult>.Some(value), default);

    private static UpdateAnomalyDetectionTriggerError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetIntelligenceResult(out IntelligenceResult value) =>
        _intelligenceResultValue.TryGetValue(out value);

    private static Task<UpdateAnomalyDetectionTriggerError> Create(FailedResponse response) =>
        response.StatusCode switch
        {
            400 or 401 or 403 or 404 or 406 or 429 => response.Json<IntelligenceResult>().As(AsIntelligenceResult),
            _ => response.RawBody().As(AsFallback)
        };

    internal static ApiErrorResponse<UpdateAnomalyDetectionTriggerError> Response { get; } = new(Create);
}
