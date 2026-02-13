using System.Text.Json.Serialization;

namespace PnzApi.Models;

public record MerchantDetails
{
    [JsonPropertyName("MerchantName")]
    public string? MerchantName { get; init; }

    [JsonPropertyName("MerchantCategoryCode")]
    public string? MerchantCategoryCode { get; init; }
}
