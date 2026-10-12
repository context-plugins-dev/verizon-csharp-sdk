using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;
using Verizon.Models;

namespace Verizon.Errors;

public sealed class ListAccountDevicesError : ApiError
{
    private readonly Optional<FotaV1Result> _fotaV1ResultValue;

    private ListAccountDevicesError(Optional<FotaV1Result> fotaV1ResultValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _fotaV1ResultValue = fotaV1ResultValue;
    }

    private static ListAccountDevicesError AsFotaV1Result(FotaV1Result value) =>
        new(Optional<FotaV1Result>.Some(value), default);

    private static ListAccountDevicesError AsFallback(RawError value) => new(default, Optional<RawError>.Some(value));

    public bool TryGetFotaV1Result(out FotaV1Result value) => _fotaV1ResultValue.TryGetValue(out value);

    private static Task<ListAccountDevicesError> Create(FailedResponse response) =>
        response.StatusCode switch
        {
            400 => response.Json<FotaV1Result>().As(AsFotaV1Result),
            _ => response.RawBody().As(AsFallback)
        };

    internal static ApiErrorResponse<ListAccountDevicesError> Response { get; } = new(Create);
}
