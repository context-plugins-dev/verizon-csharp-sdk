using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;
using Verizon.Models;

namespace Verizon.Errors;

public sealed class UpdateConfigurationError : ApiError
{
    private readonly Optional<ResponseError> _responseErrorValue;

    private UpdateConfigurationError(Optional<ResponseError> responseErrorValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _responseErrorValue = responseErrorValue;
    }

    private static UpdateConfigurationError AsResponseError(ResponseError value) =>
        new(Optional<ResponseError>.Some(value), default);

    private static UpdateConfigurationError AsFallback(RawError value) => new(default, Optional<RawError>.Some(value));

    public bool TryGetResponseError(out ResponseError value) => _responseErrorValue.TryGetValue(out value);

    private static Task<UpdateConfigurationError> Create(FailedResponse response) =>
        response.StatusCode switch
        {
            400 or 403 or 404 or 429 => response.Json<ResponseError>().As(AsResponseError),
            _ => response.RawBody().As(AsFallback)
        };

    internal static ApiErrorResponse<UpdateConfigurationError> Response { get; } = new(Create);
}
