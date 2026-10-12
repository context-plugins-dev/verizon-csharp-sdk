using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;
using Verizon.Models;

namespace Verizon.Errors;

public sealed class DisableLocalProfileError : ApiError
{
    private readonly Optional<RestErrorResponse> _restErrorResponseValue;

    private DisableLocalProfileError(Optional<RestErrorResponse> restErrorResponseValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _restErrorResponseValue = restErrorResponseValue;
    }

    private static DisableLocalProfileError AsRestErrorResponse(RestErrorResponse value) =>
        new(Optional<RestErrorResponse>.Some(value), default);

    private static DisableLocalProfileError AsFallback(RawError value) => new(default, Optional<RawError>.Some(value));

    public bool TryGetRestErrorResponse(out RestErrorResponse value) => _restErrorResponseValue.TryGetValue(out value);

    private static Task<DisableLocalProfileError> Create(FailedResponse response) =>
        response.StatusCode switch
        {
            400 => response.Json<RestErrorResponse>().As(AsRestErrorResponse),
            _ => response.RawBody().As(AsFallback)
        };

    internal static ApiErrorResponse<DisableLocalProfileError> Response { get; } = new(Create);
}
