using Verizon.Models;

namespace Verizon.Requests.IntelligenceServiceController;

/// <summary>
/// The inputs of the SetConnectionPlanner operation.
/// </summary>
public sealed record SetConnectionPlannerRequest
{
    public GetDevicesWindowsRequestforplanner? Body { get; init; }
}
