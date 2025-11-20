using System.Text.Json.Serialization;

namespace SignalRc.Models;

/// <summary>
/// Represents all telemetry-related metrics for a car.
/// </summary>
public class DataModel
{
    [JsonPropertyName("speed")]
    public MetricWithUnitModel Speed { get; set; } = new();

    [JsonPropertyName("rpm")]
    public MetricModel Rpm { get; set; } = new();

    [JsonPropertyName("battery")]
    public MetricWithUnitModel Battery { get; set; } = new();

    [JsonPropertyName("signal")]
    public MetricWithUnitModel Signal { get; set; } = new();

    [JsonPropertyName("temperature")]
    public MetricWithUnitModel Temperature { get; set; } = new();
}