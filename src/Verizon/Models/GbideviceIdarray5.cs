using System.Collections.Generic;
using System.Text.Json.Serialization;
using Verizon.Core.Models;
using Verizon.Models.AnyOf;

namespace Verizon.Models;

public record GbideviceIdarray5
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("deviceId")]
    public IReadOnlyList<DeviceId1>? DeviceId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
