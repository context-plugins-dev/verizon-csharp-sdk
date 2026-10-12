using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;
using Verizon.Models;

namespace Verizon.Errors;

public sealed class ScheduleFileUpgradeError : ApiError
{
    private readonly Optional<FotaV2Result> _fotaV2ResultValue;

    private ScheduleFileUpgradeError(Optional<FotaV2Result> fotaV2ResultValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _fotaV2ResultValue = fotaV2ResultValue;
    }

    private static ScheduleFileUpgradeError AsFotaV2Result(FotaV2Result value) =>
        new(Optional<FotaV2Result>.Some(value), default);

    private static ScheduleFileUpgradeError AsFallback(RawError value) => new(default, Optional<RawError>.Some(value));

    public bool TryGetFotaV2Result(out FotaV2Result value) => _fotaV2ResultValue.TryGetValue(out value);

    private static Task<ScheduleFileUpgradeError> Create(FailedResponse response) =>
        response.StatusCode switch
        {
            400 => response.Json<FotaV2Result>().As(AsFotaV2Result),
            _ => response.RawBody().As(AsFallback)
        };

    internal static ApiErrorResponse<ScheduleFileUpgradeError> Response { get; } = new(Create);
}
