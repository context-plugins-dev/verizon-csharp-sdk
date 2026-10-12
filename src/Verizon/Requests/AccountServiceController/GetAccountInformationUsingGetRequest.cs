namespace Verizon.Requests.AccountServiceController;

/// <summary>
/// The inputs of the GetAccountInformationUsingGet operation.
/// </summary>
public sealed record GetAccountInformationUsingGetRequest
{
    /// <summary>
    /// The account's numeric name, including leading zeroes.
    /// </summary>
    public required string AccountName { get; init; }
}
