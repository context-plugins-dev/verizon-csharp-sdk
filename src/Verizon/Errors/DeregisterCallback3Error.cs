using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;

namespace Verizon.Errors;

public sealed class DeregisterCallback3Error : ApiError
{
    private readonly Optional<RawError> _noContentValue;

    private DeregisterCallback3Error(Optional<RawError> noContentValue, Optional<RawError> fallback) : base(fallback)
    {
        _noContentValue = noContentValue;
    }

    private static DeregisterCallback3Error AsNoContent(RawError value) => new(Optional<RawError>.Some(value), default);

    private static DeregisterCallback3Error AsFallback(RawError value) => new(default, Optional<RawError>.Some(value));

    public bool TryGetNoContent(out RawError value) => _noContentValue.TryGetValue(out value);

    private static Task<DeregisterCallback3Error> Create(FailedResponse response) =>
        response.StatusCode switch
        {
            400 => response.RawBody().As(AsNoContent),
            _ => response.RawBody().As(AsFallback)
        };

    internal static ApiErrorResponse<DeregisterCallback3Error> Response { get; } = new(Create);
}
