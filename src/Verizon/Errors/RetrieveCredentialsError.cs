using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;
using Verizon.Models;

namespace Verizon.Errors;

public sealed class RetrieveCredentialsError : ApiError
{
    private readonly Optional<ErrorResponseModel> _errorResponseModelValue;

    private readonly Optional<RawError> _noContentValue;

    private RetrieveCredentialsError(Optional<ErrorResponseModel> errorResponseModelValue,
        Optional<RawError> noContentValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _errorResponseModelValue = errorResponseModelValue;
        _noContentValue = noContentValue;
    }

    private static RetrieveCredentialsError AsErrorResponseModel(ErrorResponseModel value) =>
        new(Optional<ErrorResponseModel>.Some(value), default, default);

    private static RetrieveCredentialsError AsNoContent(RawError value) =>
        new(default, Optional<RawError>.Some(value), default);

    private static RetrieveCredentialsError AsFallback(RawError value) =>
        new(default, default, Optional<RawError>.Some(value));

    public bool TryGetErrorResponseModel(out ErrorResponseModel value) =>
        _errorResponseModelValue.TryGetValue(out value);

    public bool TryGetNoContent(out RawError value) => _noContentValue.TryGetValue(out value);

    private static Task<RetrieveCredentialsError> Create(FailedResponse response) =>
        response.StatusCode switch
        {
            400 => response.Json<ErrorResponseModel>().As(AsErrorResponseModel),
            401 => response.RawBody().As(AsNoContent),
            _ => response.RawBody().As(AsFallback)
        };

    internal static ApiErrorResponse<RetrieveCredentialsError> Response { get; } = new(Create);
}
