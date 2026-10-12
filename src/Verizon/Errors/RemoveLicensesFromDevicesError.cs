using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;
using Verizon.Models;

namespace Verizon.Errors;

public sealed class RemoveLicensesFromDevicesError : ApiError
{
    private readonly Optional<FotaV1Result> _fotaV1ResultValue;

    private RemoveLicensesFromDevicesError(Optional<FotaV1Result> fotaV1ResultValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _fotaV1ResultValue = fotaV1ResultValue;
    }

    private static RemoveLicensesFromDevicesError AsFotaV1Result(FotaV1Result value) =>
        new(Optional<FotaV1Result>.Some(value), default);

    private static RemoveLicensesFromDevicesError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetFotaV1Result(out FotaV1Result value) => _fotaV1ResultValue.TryGetValue(out value);

    private static Task<RemoveLicensesFromDevicesError> Create(FailedResponse response) =>
        response.StatusCode switch
        {
            400 => response.Json<FotaV1Result>().As(AsFotaV1Result),
            _ => response.RawBody().As(AsFallback)
        };

    internal static ApiErrorResponse<RemoveLicensesFromDevicesError> Response { get; } = new(Create);
}
