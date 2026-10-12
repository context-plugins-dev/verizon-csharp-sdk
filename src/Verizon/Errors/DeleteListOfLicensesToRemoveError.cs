using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;

namespace Verizon.Errors;

public sealed class DeleteListOfLicensesToRemoveError : ApiError
{
    private readonly Optional<RawError> _noContentValue;

    private DeleteListOfLicensesToRemoveError(Optional<RawError> noContentValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _noContentValue = noContentValue;
    }

    private static DeleteListOfLicensesToRemoveError AsNoContent(RawError value) =>
        new(Optional<RawError>.Some(value), default);

    private static DeleteListOfLicensesToRemoveError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetNoContent(out RawError value) => _noContentValue.TryGetValue(out value);

    private static Task<DeleteListOfLicensesToRemoveError> Create(FailedResponse response) =>
        response.StatusCode switch
        {
            400 => response.RawBody().As(AsNoContent),
            _ => response.RawBody().As(AsFallback)
        };

    internal static ApiErrorResponse<DeleteListOfLicensesToRemoveError> Response { get; } = new(Create);
}
