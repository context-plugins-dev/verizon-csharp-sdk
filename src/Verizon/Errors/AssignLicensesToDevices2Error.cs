using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;
using Verizon.Models;

namespace Verizon.Errors;

public sealed class AssignLicensesToDevices2Error : ApiError
{
    private readonly Optional<FotaV2Result> _fotaV2ResultValue;

    private AssignLicensesToDevices2Error(Optional<FotaV2Result> fotaV2ResultValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _fotaV2ResultValue = fotaV2ResultValue;
    }

    private static AssignLicensesToDevices2Error AsFotaV2Result(FotaV2Result value) =>
        new(Optional<FotaV2Result>.Some(value), default);

    private static AssignLicensesToDevices2Error AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetFotaV2Result(out FotaV2Result value) => _fotaV2ResultValue.TryGetValue(out value);

    private static Task<AssignLicensesToDevices2Error> Create(FailedResponse response) =>
        response.StatusCode switch
        {
            400 => response.Json<FotaV2Result>().As(AsFotaV2Result),
            _ => response.RawBody().As(AsFallback)
        };

    internal static ApiErrorResponse<AssignLicensesToDevices2Error> Response { get; } = new(Create);
}
