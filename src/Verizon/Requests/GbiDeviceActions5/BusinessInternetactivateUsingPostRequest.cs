using Verizon.Models;

namespace Verizon.Requests.GbiDeviceActions5;

/// <summary>
/// The inputs of the BusinessInternetactivateUsingPost operation.
/// </summary>
public sealed record BusinessInternetactivateUsingPostRequest
{
    /// <summary>
    /// Activate 5G BI service. Defining &lt;code&gt;publicIpRestriction&lt;/code&gt; as "Unrestricted" or "Restricted" is required for activating as Public Static. Leave  &lt;code&gt;publicIpRestriction&lt;/code&gt; undefined to activate as Public Dynamic. Removing &lt;code&gt;publicIpRestriction&lt;/code&gt; from the request will activate as Mobile Private Network (MPN).
    /// </summary>
    public required GbiactivateRequest5 Body { get; init; }
}
