using System;
using System.Text.Json.Serialization;
using Verizon.Core.Enum;

namespace Verizon.Servers;

[JsonConverter(typeof(StringEnumConverter<ServerEnvironment>))]
public sealed record ServerEnvironment : ClosedStringEnum<ServerEnvironment>
{
    private ServerEnvironment(string value) : base(value)
    {
    }

    public static readonly ServerEnvironment Production = new("Production");

    public static readonly ServerEnvironment Staging = new("Staging");

    public static readonly ServerEnvironment Dev = new("Dev");

    public static readonly ServerEnvironment Qa = new("Qa");

    public static readonly ServerEnvironment MockServerForLimitedAvailabilitySeeQuickStart = new(
        "Mock server for limited availability, see quick start");

    public static ServerEnvironment Default() => Production;

    internal TResult Match<TResult>(Func<TResult> onProduction,
        Func<TResult> onStaging,
        Func<TResult> onDev,
        Func<TResult> onQa,
        Func<TResult> onMockServerForLimitedAvailabilitySeeQuickStart) =>
        this switch
        {
            _ when this == Production => onProduction(),
            _ when this == Staging => onStaging(),
            _ when this == Dev => onDev(),
            _ when this == Qa => onQa(),
            _ when this ==
                MockServerForLimitedAvailabilitySeeQuickStart => onMockServerForLimitedAvailabilitySeeQuickStart(),
            _ => throw new InvalidOperationException($"{nameof(ServerEnvironment)} holds no known value.")
        };
}
