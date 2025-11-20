using System.Text.Json.Serialization;

namespace SignalRc;

/// <summary>
/// Represents a numeric metric without unit (e.g., RPM).
/// </summary>
public class MetricModel
{
    [JsonPropertyName("value")]
    public double Value { get; set; }
}