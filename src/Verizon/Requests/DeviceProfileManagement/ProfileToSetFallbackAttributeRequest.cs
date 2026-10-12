using Verizon.Models;

namespace Verizon.Requests.DeviceProfileManagement;

/// <summary>
/// The inputs of the ProfileToSetFallbackAttribute operation.
/// </summary>
public sealed record ProfileToSetFallbackAttributeRequest
{
    /// <summary>
    /// Device Profile Query
    /// </summary>
    public required SetFallbackAttributeRequest Body { get; init; }
}
