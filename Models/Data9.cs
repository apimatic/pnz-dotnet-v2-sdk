using System.Text.Json.Serialization;

namespace PnzApi.Models;

public record Data9
{
    [JsonPropertyName("ScheduledPayment")]
    public IReadOnlyList<ScheduledPaymentModel>? ScheduledPayment { get; init; }
}
