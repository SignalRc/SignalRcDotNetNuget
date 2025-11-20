using System.Text.Json.Serialization;

namespace SignalRc.Models;

/// <summary>
/// Root model representing the full telemetry state.
/// </summary>
public class SignalRcModel
{
        [JsonPropertyName("version")]
        public string Version { get; set; } = string.Empty;

        // Guid as string, validated externally according to schema pattern
        [JsonPropertyName("self")]
        public string Self { get; set; } = string.Empty;

        // Cars identified by GUID or other string keys
        [JsonPropertyName("cars")]
        public Dictionary<string, CarStateModel> Cars { get; set; } = new();
}