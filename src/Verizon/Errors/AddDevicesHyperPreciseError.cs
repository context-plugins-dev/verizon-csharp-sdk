using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;
using Verizon.Models;

namespace Verizon.Errors;

public sealed class AddDevicesHyperPreciseError : ApiError
{
    private readonly Optional<HyperPreciseLocationResult> _hyperPreciseLocationResultValue;

    private AddDevicesHyperPreciseError(Optional<HyperPreciseLocationResult> hyperPreciseLocationResultValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _hyperPreciseLocationResultValue = hyperPreciseLocationResultValue;
    }

    private static AddDevicesHyperPreciseError AsHyperPreciseLocationResult(HyperPreciseLocationResult value) =>
        new(Optional<HyperPreciseLocationResult>.Some(value), default);

    private static AddDevicesHyperPreciseError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetHyperPreciseLocationResult(out HyperPreciseLocationResult value) =>
        _hyperPreciseLocationResultValue.TryGetValue(out value);

    private static Task<AddDevicesHyperPreciseError> Create(FailedResponse response) =>
        response.StatusCode switch
        {
            400 or 401 or 403 or 404 or 405 or 406 or 429 or 500 => response.Json<HyperPreciseLocationResult>().As(
                AsHyperPreciseLocationResult),
            _ => response.RawBody().As(AsFallback)
        };

    internal static ApiErrorResponse<AddDevicesHyperPreciseError> Response { get; } = new(Create);
}
