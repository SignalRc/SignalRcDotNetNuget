using System.Text.Json.Serialization;

namespace SignalRc.Models;

public class RcDeltaUpdateEntryModel
{
    [JsonPropertyName("timestamp")]
    public required DateTime Timestamp { get; set; }

    [JsonPropertyName("values")]
    public required List<RcDeltaValueModel> Values { get; set; }
}