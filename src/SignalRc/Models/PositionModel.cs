using System.Text.Json.Serialization;

namespace SignalRc.Models;

/// <summary>
/// Represents cartesian coordinates.
/// </summary>
public class PositionModel
{
    [JsonPropertyName("x")]
    public double X { get; set; }

    [JsonPropertyName("y")]
    public double Y { get; set; }

    [JsonPropertyName("z")]
    public double? Z { get; set; }
}