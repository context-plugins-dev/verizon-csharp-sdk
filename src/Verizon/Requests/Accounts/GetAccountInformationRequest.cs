namespace Verizon.Requests.Accounts;

/// <summary>
/// The inputs of the GetAccountInformation operation.
/// </summary>
public sealed record GetAccountInformationRequest
{
    /// <summary>
    /// Account name.
    /// </summary>
    public required string Aname { get; init; }
}
