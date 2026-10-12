using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;
using Verizon.Models;

namespace Verizon.Errors;

public sealed class ProfileToDeactivateDeviceError : ApiError
{
    private readonly Optional<RestErrorResponse> _restErrorResponseValue;

    private ProfileToDeactivateDeviceError(Optional<RestErrorResponse> restErrorResponseValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _restErrorResponseValue = restErrorResponseValue;
    }

    private static ProfileToDeactivateDeviceError AsRestErrorResponse(RestErrorResponse value) =>
        new(Optional<RestErrorResponse>.Some(value), default);

    private static ProfileToDeactivateDeviceError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetRestErrorResponse(out RestErrorResponse value) => _restErrorResponseValue.TryGetValue(out value);

    private static Task<ProfileToDeactivateDeviceError> Create(FailedResponse response) =>
        response.StatusCode switch
        {
            400 => response.Json<RestErrorResponse>().As(AsRestErrorResponse),
            _ => response.RawBody().As(AsFallback)
        };

    internal static ApiErrorResponse<ProfileToDeactivateDeviceError> Response { get; } = new(Create);
}
