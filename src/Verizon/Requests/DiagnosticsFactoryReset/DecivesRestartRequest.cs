using Verizon.Models;

namespace Verizon.Requests.DiagnosticsFactoryReset;

/// <summary>
/// The inputs of the DecivesRestart operation.
/// </summary>
public sealed record DecivesRestartRequest
{
    /// <summary>
    /// A request to perform a device reboot.
    /// </summary>
    public required DeviceResetRequest Body { get; init; }
}
