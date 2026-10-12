using Verizon.Models;

namespace Verizon.Requests.WirelessNetworkPerformance;

/// <summary>
/// The inputs of the DeviceExperience30DaysHistory operation.
/// </summary>
public sealed record DeviceExperience30DaysHistoryRequest
{
    /// <summary>
    /// Request for a device's 30 day experience.
    /// </summary>
    public required GetDeviceExperienceScoreHistoryRequest Body { get; init; }
}
