using Verizon.Models;

namespace Verizon.Requests.Billing;

/// <summary>
/// The inputs of the CancelManagedAccountAction operation.
/// </summary>
public sealed record CancelManagedAccountActionRequest
{
    /// <summary>
    /// Service name and list of accounts to add
    /// </summary>
    public required ManagedAccountCancelRequest Body { get; init; }
}
