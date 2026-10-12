using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;
using Verizon.Models;

namespace Verizon.Errors;

public sealed class GetConfigurationListError : ApiError
{
    private readonly Optional<ResponseError> _responseErrorValue;

    private GetConfigurationListError(Optional<ResponseError> responseErrorValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _responseErrorValue = responseErrorValue;
    }

    private static GetConfigurationListError AsResponseError(ResponseError value) =>
        new(Optional<ResponseError>.Some(value), default);

    private static GetConfigurationListError AsFallback(RawError value) => new(default, Optional<RawError>.Some(value));

    public bool TryGetResponseError(out ResponseError value) => _responseErrorValue.TryGetValue(out value);

    private static Task<GetConfigurationListError> Create(FailedResponse response) =>
        response.StatusCode switch
        {
            403 or 404 or 429 => response.Json<ResponseError>().As(AsResponseError),
            _ => response.RawBody().As(AsFallback)
        };

    internal static ApiErrorResponse<GetConfigurationListError> Response { get; } = new(Create);
}
