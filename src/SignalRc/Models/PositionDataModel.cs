using System.Text.Json.Serialization;

namespace SignalRc.Models;

/// <summary>
/// Container for a position vector.
/// </summary>
public class PositionDataModel
{
    [JsonPropertyName("value")]
    public PositionModel Value { get; set; } = new();
}