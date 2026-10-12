using Verizon.Models;

namespace Verizon.Requests.Billing;

/// <summary>
/// The inputs of the AddAccount operation.
/// </summary>
public sealed record AddAccountRequest
{
    /// <summary>
    /// Service name and list of accounts to add
    /// </summary>
    public required ManagedAccountsAddRequest Body { get; init; }
}
