namespace Verizon.Requests.RetrieveTheTriggers;

/// <summary>
/// The inputs of the GetAllTriggersByAccountName operation.
/// </summary>
public sealed record GetAllTriggersByAccountNameRequest
{
    /// <summary>
    /// The account name
    /// </summary>
    public required string AccountName { get; init; }
}
