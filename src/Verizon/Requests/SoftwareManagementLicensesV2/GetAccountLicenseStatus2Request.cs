namespace Verizon.Requests.SoftwareManagementLicensesV2;

/// <summary>
/// The inputs of the GetAccountLicenseStatus2 operation.
/// </summary>
public sealed record GetAccountLicenseStatus2Request
{
    /// <summary>
    /// Account identifier.
    /// </summary>
    public required string Account { get; init; }

    /// <summary>
    /// Last seen device identifier.
    /// </summary>
    public string? LastSeenDeviceId { get; init; }
}
