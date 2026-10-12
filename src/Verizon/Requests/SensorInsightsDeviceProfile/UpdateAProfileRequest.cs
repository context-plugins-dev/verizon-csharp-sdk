using Verizon.Models;

namespace Verizon.Requests.SensorInsightsDeviceProfile;

/// <summary>
/// The inputs of the UpdateAProfile operation.
/// </summary>
public sealed record UpdateAProfileRequest
{
    public required DtoConfigurationProfilePath Body { get; init; }
}
