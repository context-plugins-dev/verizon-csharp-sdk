using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;
using Verizon.Models;

namespace Verizon.Errors;

public sealed class UnregisterEtxClientsError : ApiError
{
    private readonly Optional<EtxRespondingError> _etxRespondingErrorValue;

    private UnregisterEtxClientsError(Optional<EtxRespondingError> etxRespondingErrorValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _etxRespondingErrorValue = etxRespondingErrorValue;
    }

    private static UnregisterEtxClientsError AsEtxRespondingError(EtxRespondingError value) =>
        new(Optional<EtxRespondingError>.Some(value), default);

    private static UnregisterEtxClientsError AsFallback(RawError value) => new(default, Optional<RawError>.Some(value));

    public bool TryGetEtxRespondingError(out EtxRespondingError value) =>
        _etxRespondingErrorValue.TryGetValue(out value);

    private static Task<UnregisterEtxClientsError> Create(FailedResponse response) =>
        response.StatusCode switch
        {
            400 or 401 or 403 or 429 or 503 => response.Json<EtxRespondingError>().As(AsEtxRespondingError),
            _ => response.RawBody().As(AsFallback)
        };

    internal static ApiErrorResponse<UnregisterEtxClientsError> Response { get; } = new(Create);
}
