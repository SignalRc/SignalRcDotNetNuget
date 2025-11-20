using System.Text.Json.Serialization;

namespace SignalRc;

/// <summary>
/// Represents a numeric metric with a unit string.
/// </summary>
public class MetricWithUnitModel
{
    [JsonPropertyName("value")]
    public double Value { get; set; }

    [JsonPropertyName("unit")]
    public string? Unit { get; set; }
}