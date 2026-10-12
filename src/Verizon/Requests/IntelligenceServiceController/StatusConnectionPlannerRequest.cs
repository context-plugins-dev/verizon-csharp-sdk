using Verizon.Models;

namespace Verizon.Requests.IntelligenceServiceController;

/// <summary>
/// The inputs of the StatusConnectionPlanner operation.
/// </summary>
public sealed record StatusConnectionPlannerRequest
{
    public GetDeviceStatusesRequestforplanner? Body { get; init; }
}
