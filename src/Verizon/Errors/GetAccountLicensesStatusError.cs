using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;
using Verizon.Models;

namespace Verizon.Errors;

public sealed class GetAccountLicensesStatusError : ApiError
{
    private readonly Optional<FotaV3Result> _fotaV3ResultValue;

    private GetAccountLicensesStatusError(Optional<FotaV3Result> fotaV3ResultValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _fotaV3ResultValue = fotaV3ResultValue;
    }

    private static GetAccountLicensesStatusError AsFotaV3Result(FotaV3Result value) =>
        new(Optional<FotaV3Result>.Some(value), default);

    private static GetAccountLicensesStatusError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetFotaV3Result(out FotaV3Result value) => _fotaV3ResultValue.TryGetValue(out value);

    private static Task<GetAccountLicensesStatusError> Create(FailedResponse response) =>
        response.StatusCode switch
        {
            400 => response.Json<FotaV3Result>().As(AsFotaV3Result),
            _ => response.RawBody().As(AsFallback)
        };

    internal static ApiErrorResponse<GetAccountLicensesStatusError> Response { get; } = new(Create);
}
