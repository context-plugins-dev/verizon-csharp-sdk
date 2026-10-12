namespace Verizon.Requests.MapMessageController;

/// <summary>
/// The inputs of the DeleteMapMessage operation.
/// </summary>
public sealed record DeleteMapMessageRequest
{
    /// <summary>
    /// Region ID to filter the map messages.
    /// </summary>
    public required string RegionId { get; init; }

    /// <summary>
    /// Intersection ID to filter the map messages.
    /// </summary>
    public required string I10Nid { get; init; }
}
