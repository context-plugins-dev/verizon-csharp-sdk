using Verizon.Models;

namespace Verizon.Requests.SensorInsightsDeviceProfile;

/// <summary>
/// The inputs of the DeleteAProfile operation.
/// </summary>
public sealed record DeleteAProfileRequest
{
    /// <summary>
    /// payload for the delete request
    /// </summary>
    public required DtoConfigurationProfileDelete Deleterequest { get; init; }
}
