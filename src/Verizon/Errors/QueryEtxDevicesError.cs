using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;
using Verizon.Models;

namespace Verizon.Errors;

public sealed class QueryEtxDevicesError : ApiError
{
    private readonly Optional<EtxRespondingError> _etxRespondingErrorValue;

    private QueryEtxDevicesError(Optional<EtxRespondingError> etxRespondingErrorValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _etxRespondingErrorValue = etxRespondingErrorValue;
    }

    private static QueryEtxDevicesError AsEtxRespondingError(EtxRespondingError value) =>
        new(Optional<EtxRespondingError>.Some(value), default);

    private static QueryEtxDevicesError AsFallback(RawError value) => new(default, Optional<RawError>.Some(value));

    public bool TryGetEtxRespondingError(out EtxRespondingError value) =>
        _etxRespondingErrorValue.TryGetValue(out value);

    private static Task<QueryEtxDevicesError> Create(FailedResponse response) =>
        response.StatusCode switch
        {
            400 or 401 or 500 => response.Json<EtxRespondingError>().As(AsEtxRespondingError),
            _ => response.RawBody().As(AsFallback)
        };

    internal static ApiErrorResponse<QueryEtxDevicesError> Response { get; } = new(Create);
}
