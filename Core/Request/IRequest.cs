namespace PnzApi.Core.Request;

public interface IRequest
{
    HttpContent? Get();
    
    bool CanRetry { get; }
}