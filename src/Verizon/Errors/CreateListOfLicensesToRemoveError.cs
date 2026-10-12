using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;
using Verizon.Models;

namespace Verizon.Errors;

public sealed class CreateListOfLicensesToRemoveError : ApiError
{
    private readonly Optional<FotaV1Result> _fotaV1ResultValue;

    private CreateListOfLicensesToRemoveError(Optional<FotaV1Result> fotaV1ResultValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _fotaV1ResultValue = fotaV1ResultValue;
    }

    private static CreateListOfLicensesToRemoveError AsFotaV1Result(FotaV1Result value) =>
        new(Optional<FotaV1Result>.Some(value), default);

    private static CreateListOfLicensesToRemoveError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetFotaV1Result(out FotaV1Result value) => _fotaV1ResultValue.TryGetValue(out value);

    private static Task<CreateListOfLicensesToRemoveError> Create(FailedResponse response) =>
        response.StatusCode switch
        {
            400 => response.Json<FotaV1Result>().As(AsFotaV1Result),
            _ => response.RawBody().As(AsFallback)
        };

    internal static ApiErrorResponse<CreateListOfLicensesToRemoveError> Response { get; } = new(Create);
}
