using System.Text.Json.Serialization;

namespace SignalRc.Models;

public class SignalRcModelBase
{
    [JsonPropertyName("type")] 
    public string Type { get; set; } = string.Empty;
   
    [JsonPropertyName("version")] 
    public string Version { get; set; } = string.Empty;

    // Guid as string, validated externally according to schema pattern
    [JsonPropertyName("self")] 
    public string Self { get; set; } = string.Empty;
}