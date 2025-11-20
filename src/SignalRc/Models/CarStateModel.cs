using System.Text.Json.Serialization;

namespace SignalRc.Models;

/// <summary>
/// Represents a single car and its state.
/// </summary>
public class CarStateModel
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("telemetry")]
    public DataModel Telemetry { get; set; } = new();

    [JsonPropertyName("position")]
    public DataModel Position { get; set; } = new();

    [JsonPropertyName("timestamp")]
    public DateTime Timestamp { get; set; }
}