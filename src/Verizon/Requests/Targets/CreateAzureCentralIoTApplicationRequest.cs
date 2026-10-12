using Verizon.Models;

namespace Verizon.Requests.Targets;

/// <summary>
/// The inputs of the CreateAzureCentralIoTApplication operation.
/// </summary>
public sealed record CreateAzureCentralIoTApplicationRequest
{
    /// <summary>
    /// TThe ThingSpace ID of the authenticating billing account.
    /// </summary>
    public required string BillingaccountId { get; init; }

    /// <summary>
    /// The request body must include the UUID of the subscription that you want to update plus any properties that you want to change.
    /// </summary>
    public required CreateIoTApplicationRequest Body { get; init; }
}
