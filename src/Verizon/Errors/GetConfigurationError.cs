using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;
using Verizon.Models;

namespace Verizon.Errors;

public sealed class GetConfigurationError : ApiError
{
    private readonly Optional<ResponseError> _responseErrorValue;

    private GetConfigurationError(Optional<ResponseError> responseErrorValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _responseErrorValue = responseErrorValue;
    }

    private static GetConfigurationError AsResponseError(ResponseError value) =>
        new(Optional<ResponseError>.Some(value), default);

    private static GetConfigurationError AsFallback(RawError value) => new(default, Optional<RawError>.Some(value));

    public bool TryGetResponseError(out ResponseError value) => _responseErrorValue.TryGetValue(out value);

    private static Task<GetConfigurationError> Create(FailedResponse response) =>
        response.StatusCode switch
        {
            403 or 404 or 429 => response.Json<ResponseError>().As(AsResponseError),
            _ => response.RawBody().As(AsFallback)
        };

    internal static ApiErrorResponse<GetConfigurationError> Response { get; } = new(Create);
}
