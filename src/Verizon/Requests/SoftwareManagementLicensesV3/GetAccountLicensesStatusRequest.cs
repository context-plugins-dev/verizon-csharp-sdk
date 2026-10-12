namespace Verizon.Requests.SoftwareManagementLicensesV3;

/// <summary>
/// The inputs of the GetAccountLicensesStatus operation.
/// </summary>
public sealed record GetAccountLicensesStatusRequest
{
    /// <summary>
    /// Account identifier.
    /// </summary>
    public required string Acc { get; init; }

    /// <summary>
    /// Last seen device identifier.
    /// </summary>
    public string? LastSeenDeviceId { get; init; }
}
