using System.Text.Json.Serialization;

namespace SignalRc.Models;

public class SignalRcDeltaModel : SignalRcModelBase
{
    [JsonPropertyName("updates")]
    public List<RcDeltaUpdateEntryModel> Updates { get; set; }
}