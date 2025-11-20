using System.Text.Json.Serialization;

namespace SignalRc.Models;

public class RcDeltaValueModel
{
    [JsonPropertyName("path")]
    public string Path { get; set; }

    [JsonPropertyName("value")]
    public object? Value { get; set; }
}