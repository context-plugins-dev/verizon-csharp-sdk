using Verizon.Models;

namespace Verizon.Requests.Billing;

/// <summary>
/// The inputs of the ManagedAccountAction operation.
/// </summary>
public sealed record ManagedAccountActionRequest
{
    /// <summary>
    /// Service name and list of accounts to add
    /// </summary>
    public required ManagedAccountsProvisionRequest Body { get; init; }
}
