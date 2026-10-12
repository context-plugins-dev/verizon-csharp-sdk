using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;
using Verizon.Models;

namespace Verizon.Errors;

public sealed class GetAccountInformationUsingGetError : ApiError
{
    private readonly Optional<RestErrorResponseforplanner> _restErrorResponseforplannerValue;

    private readonly Optional<AuthRestErrorResponseforplanner> _authRestErrorResponseforplannerValue;

    private GetAccountInformationUsingGetError(Optional<RestErrorResponseforplanner> restErrorResponseforplannerValue,
        Optional<AuthRestErrorResponseforplanner> authRestErrorResponseforplannerValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _restErrorResponseforplannerValue = restErrorResponseforplannerValue;
        _authRestErrorResponseforplannerValue = authRestErrorResponseforplannerValue;
    }

    private static GetAccountInformationUsingGetError AsRestErrorResponseforplanner(RestErrorResponseforplanner value) =>
        new(Optional<RestErrorResponseforplanner>.Some(value), default, default);

    private static GetAccountInformationUsingGetError AsAuthRestErrorResponseforplanner(AuthRestErrorResponseforplanner value) =>
        new(default, Optional<AuthRestErrorResponseforplanner>.Some(value), default);

    private static GetAccountInformationUsingGetError AsFallback(RawError value) =>
        new(default, default, Optional<RawError>.Some(value));

    public bool TryGetRestErrorResponseforplanner(out RestErrorResponseforplanner value) =>
        _restErrorResponseforplannerValue.TryGetValue(out value);

    public bool TryGetAuthRestErrorResponseforplanner(out AuthRestErrorResponseforplanner value) =>
        _authRestErrorResponseforplannerValue.TryGetValue(out value);

    private static Task<GetAccountInformationUsingGetError> Create(FailedResponse response) =>
        response.StatusCode switch
        {
            400 or 403 or 404 or 406 or 429 => response.Json<RestErrorResponseforplanner>().As(
                AsRestErrorResponseforplanner),
            401 => response.Json<AuthRestErrorResponseforplanner>().As(AsAuthRestErrorResponseforplanner),
            _ => response.RawBody().As(AsFallback)
        };

    internal static ApiErrorResponse<GetAccountInformationUsingGetError> Response { get; } = new(Create);
}
