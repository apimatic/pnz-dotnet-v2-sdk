using PnzApi.Core.Configuration;

namespace PnzApi;

public class PnzApiClientOptions
{
    public RetryOptions RetryOptions { get; } = RetryOptions.Default();
}
