using Verizon.Models;

namespace Verizon.Requests.SessionManagement;

/// <summary>
/// The inputs of the StartConnectivityManagementSession operation.
/// </summary>
public sealed record StartConnectivityManagementSessionRequest
{
    /// <summary>
    /// Request to initiate a session.
    /// </summary>
    public LogInRequest? Body { get; init; }
}
