using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;
using Verizon.Models;

namespace Verizon.Errors;

public sealed class GetCampaignHistoryByStatus2Error : ApiError
{
    private readonly Optional<FotaV3Result> _fotaV3ResultValue;

    private GetCampaignHistoryByStatus2Error(Optional<FotaV3Result> fotaV3ResultValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _fotaV3ResultValue = fotaV3ResultValue;
    }

    private static GetCampaignHistoryByStatus2Error AsFotaV3Result(FotaV3Result value) =>
        new(Optional<FotaV3Result>.Some(value), default);

    private static GetCampaignHistoryByStatus2Error AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetFotaV3Result(out FotaV3Result value) => _fotaV3ResultValue.TryGetValue(out value);

    private static Task<GetCampaignHistoryByStatus2Error> Create(FailedResponse response) =>
        response.StatusCode switch
        {
            400 => response.Json<FotaV3Result>().As(AsFotaV3Result),
            _ => response.RawBody().As(AsFallback)
        };

    internal static ApiErrorResponse<GetCampaignHistoryByStatus2Error> Response { get; } = new(Create);
}
