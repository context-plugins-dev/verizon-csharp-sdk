using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;

namespace Verizon.Errors;

public sealed class GetAclRulesByVendorIdError : ApiError
{
    private readonly Optional<string> _stringValue;

    private GetAclRulesByVendorIdError(Optional<string> stringValue, Optional<RawError> fallback) : base(fallback)
    {
        _stringValue = stringValue;
    }

    private static GetAclRulesByVendorIdError AsString(string value) => new(Optional<string>.Some(value), default);

    private static GetAclRulesByVendorIdError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    private static Task<GetAclRulesByVendorIdError> Create(FailedResponse response) =>
        response.StatusCode switch
        {
            400 or 401 or 403 or 406 or 429 => response.Scalar(s => s).As(AsString),
            _ => response.RawBody().As(AsFallback)
        };

    internal static ApiErrorResponse<GetAclRulesByVendorIdError> Response { get; } = new(Create);
}
