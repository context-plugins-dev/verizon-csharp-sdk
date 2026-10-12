using Verizon.Models;

namespace Verizon.Requests.UsageTriggerManagement;

/// <summary>
/// The inputs of the CreateNewTrigger operation.
/// </summary>
public sealed record CreateNewTriggerRequest
{
    /// <summary>
    /// License assignment.
    /// </summary>
    public UsageTriggerAddRequest? Body { get; init; }
}
