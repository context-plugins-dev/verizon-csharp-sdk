using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;
using Verizon.Models;

namespace Verizon.Errors;

public sealed class GetAccountDeviceInformationError : ApiError
{
    private readonly Optional<FotaV3Result> _fotaV3ResultValue;

    private GetAccountDeviceInformationError(Optional<FotaV3Result> fotaV3ResultValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _fotaV3ResultValue = fotaV3ResultValue;
    }

    private static GetAccountDeviceInformationError AsFotaV3Result(FotaV3Result value) =>
        new(Optional<FotaV3Result>.Some(value), default);

    private static GetAccountDeviceInformationError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetFotaV3Result(out FotaV3Result value) => _fotaV3ResultValue.TryGetValue(out value);

    private static Task<GetAccountDeviceInformationError> Create(FailedResponse response) =>
        response.StatusCode switch
        {
            400 => response.Json<FotaV3Result>().As(AsFotaV3Result),
            _ => response.RawBody().As(AsFallback)
        };

    internal static ApiErrorResponse<GetAccountDeviceInformationError> Response { get; } = new(Create);
}
