using Verizon.Models;

namespace Verizon.Requests.SessionManagement;

/// <summary>
/// The inputs of the ResetConnectivityManagementPassword operation.
/// </summary>
public sealed record ResetConnectivityManagementPasswordRequest
{
    /// <summary>
    /// Request with current password that needs to be reset.
    /// </summary>
    public required SessionResetPasswordRequest Body { get; init; }
}
