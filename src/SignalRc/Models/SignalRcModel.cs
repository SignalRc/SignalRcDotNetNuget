using System.Text.Json.Serialization;

namespace SignalRc.Models;

/// <summary>
/// Root model representing the full telemetry state.
/// </summary>
public class SignalRcModel : SignalRcModelBase
{
    // Cars identified by GUID or other string keys
    [JsonPropertyName("vehicles")] 
    public Dictionary<string, VehicleStateModel> Vehicles { get; set; } = new();
    
}