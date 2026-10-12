using Verizon.Models;

namespace Verizon.Requests.GlobalReporting;

/// <summary>
/// The inputs of the RetrieveGlobalList operation.
/// </summary>
public sealed record RetrieveGlobalListRequest
{
    /// <summary>
    /// Device List
    /// </summary>
    public required ESimGlobalDeviceList Body { get; init; }
}
