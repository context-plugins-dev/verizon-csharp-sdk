using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;
using Verizon.Models;

namespace Verizon.Errors;

public sealed class GetCampaignInformation2Error : ApiError
{
    private readonly Optional<FotaV3Result> _fotaV3ResultValue;

    private GetCampaignInformation2Error(Optional<FotaV3Result> fotaV3ResultValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _fotaV3ResultValue = fotaV3ResultValue;
    }

    private static GetCampaignInformation2Error AsFotaV3Result(FotaV3Result value) =>
        new(Optional<FotaV3Result>.Some(value), default);

    private static GetCampaignInformation2Error AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetFotaV3Result(out FotaV3Result value) => _fotaV3ResultValue.TryGetValue(out value);

    private static Task<GetCampaignInformation2Error> Create(FailedResponse response) =>
        response.StatusCode switch
        {
            400 => response.Json<FotaV3Result>().As(AsFotaV3Result),
            _ => response.RawBody().As(AsFallback)
        };

    internal static ApiErrorResponse<GetCampaignInformation2Error> Response { get; } = new(Create);
}
