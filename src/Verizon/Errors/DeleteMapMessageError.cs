using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;
using Verizon.Models;

namespace Verizon.Errors;

public sealed class DeleteMapMessageError : ApiError
{
    private readonly Optional<MdmErrorResponse> _mdmErrorResponseValue;

    private DeleteMapMessageError(Optional<MdmErrorResponse> mdmErrorResponseValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _mdmErrorResponseValue = mdmErrorResponseValue;
    }

    private static DeleteMapMessageError AsMdmErrorResponse(MdmErrorResponse value) =>
        new(Optional<MdmErrorResponse>.Some(value), default);

    private static DeleteMapMessageError AsFallback(RawError value) => new(default, Optional<RawError>.Some(value));

    public bool TryGetMdmErrorResponse(out MdmErrorResponse value) => _mdmErrorResponseValue.TryGetValue(out value);

    private static Task<DeleteMapMessageError> Create(FailedResponse response) =>
        response.StatusCode switch
        {
            400 or 401 or 403 or 404 or 429 or 503 => response.Json<MdmErrorResponse>().As(AsMdmErrorResponse),
            _ => response.RawBody().As(AsFallback)
        };

    internal static ApiErrorResponse<DeleteMapMessageError> Response { get; } = new(Create);
}
