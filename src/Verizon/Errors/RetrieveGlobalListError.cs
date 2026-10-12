using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;
using Verizon.Models;

namespace Verizon.Errors;

public sealed class RetrieveGlobalListError : ApiError
{
    private readonly Optional<ESimRestErrorResponse> _eSimRestErrorResponseValue;

    private RetrieveGlobalListError(Optional<ESimRestErrorResponse> eSimRestErrorResponseValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _eSimRestErrorResponseValue = eSimRestErrorResponseValue;
    }

    private static RetrieveGlobalListError AsESimRestErrorResponse(ESimRestErrorResponse value) =>
        new(Optional<ESimRestErrorResponse>.Some(value), default);

    private static RetrieveGlobalListError AsFallback(RawError value) => new(default, Optional<RawError>.Some(value));

    public bool TryGetESimRestErrorResponse(out ESimRestErrorResponse value) =>
        _eSimRestErrorResponseValue.TryGetValue(out value);

    private static Task<RetrieveGlobalListError> Create(FailedResponse response) =>
        response.StatusCode switch
        {
            400 or 401 or 403 or 404 or 406 or 429 => response.Json<ESimRestErrorResponse>().As(
                AsESimRestErrorResponse),
            _ => response.RawBody().As(AsFallback)
        };

    internal static ApiErrorResponse<RetrieveGlobalListError> Response { get; } = new(Create);
}
