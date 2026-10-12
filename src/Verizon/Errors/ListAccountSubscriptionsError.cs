using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;
using Verizon.Models;

namespace Verizon.Errors;

public sealed class ListAccountSubscriptionsError : ApiError
{
    private readonly Optional<SecurityResult> _securityResultValue;

    private ListAccountSubscriptionsError(Optional<SecurityResult> securityResultValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _securityResultValue = securityResultValue;
    }

    private static ListAccountSubscriptionsError AsSecurityResult(SecurityResult value) =>
        new(Optional<SecurityResult>.Some(value), default);

    private static ListAccountSubscriptionsError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetSecurityResult(out SecurityResult value) => _securityResultValue.TryGetValue(out value);

    private static Task<ListAccountSubscriptionsError> Create(FailedResponse response) =>
        response.StatusCode switch
        {
            400 or 401 or 403 or 404 or 406 or 429 => response.Json<SecurityResult>().As(AsSecurityResult),
            _ => response.RawBody().As(AsFallback)
        };

    internal static ApiErrorResponse<ListAccountSubscriptionsError> Response { get; } = new(Create);
}
