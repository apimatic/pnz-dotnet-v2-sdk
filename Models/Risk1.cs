using System.Text.Json.Serialization;

namespace PnzApi.Models;

public record Risk1
{
    [JsonPropertyName("GeoLocation")]
    public GeoLocation2? GeoLocation { get; init; }

    [JsonPropertyName("PaymentContextCode")]
    public PaymentContextCode? PaymentContextCode { get; init; }

    [JsonPropertyName("MerchantCategoryCode")]
    public string? MerchantCategoryCode { get; init; }

    [JsonPropertyName("MerchantCustomerIdentification")]
    public string? MerchantCustomerIdentification { get; init; }

    [JsonPropertyName("DeliveryAddress")]
    public DeliveryAddress2? DeliveryAddress { get; init; }

    [JsonPropertyName("EndUserAppName")]
    public string? EndUserAppName { get; init; }

    [JsonPropertyName("EndUserAppVersion")]
    public string? EndUserAppVersion { get; init; }

    [JsonPropertyName("MerchantName")]
    public string? MerchantName { get; init; }

    [JsonPropertyName("MerchantNZBN")]
    public string? MerchantNzbn { get; init; }
}
