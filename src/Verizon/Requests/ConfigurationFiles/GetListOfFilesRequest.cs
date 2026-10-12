namespace Verizon.Requests.ConfigurationFiles;

/// <summary>
/// The inputs of the GetListOfFiles operation.
/// </summary>
public sealed record GetListOfFilesRequest
{
    /// <summary>
    /// Account identifier.
    /// </summary>
    public required string Acc { get; init; }

    /// <summary>
    /// Filter the distributionType to only retrieve files for a specific distribution type.
    /// </summary>
    public required string DistributionType { get; init; }
}
