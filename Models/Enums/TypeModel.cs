using System.Text.Json.Serialization;
using Verizon.Core.Enum;

namespace Verizon.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<TypeModel>))]
public sealed record TypeModel : StringEnum<TypeModel>
{
    private TypeModel(string value) : base(value)
    {
    }

    public static readonly TypeModel FeatureCollection = new("FeatureCollection");

    public static TypeModel FromValue(string value) => FromValueCore(value);
}
