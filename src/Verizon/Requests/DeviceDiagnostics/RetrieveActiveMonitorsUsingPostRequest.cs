using Verizon.Models;

namespace Verizon.Requests.DeviceDiagnostics;

/// <summary>
/// The inputs of the RetrieveActiveMonitorsUsingPost operation.
/// </summary>
public sealed record RetrieveActiveMonitorsUsingPostRequest
{
    /// <summary>
    /// Retrieve Monitor Request.
    /// </summary>
    public required RetrieveMonitorsRequest Body { get; init; }
}
