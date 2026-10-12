using Verizon.Models;

namespace Verizon.Requests.SensorInsightsDeviceProfile;

/// <summary>
/// The inputs of the CreateAProfile operation.
/// </summary>
public sealed record CreateAProfileRequest
{
    public required DtoConfigurationProfile Body { get; init; }
}
