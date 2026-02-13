namespace PnzApi.Core.Request;

public class EmptyBody : IRequest
{
    public static EmptyBody Instance { get; } =  new();

    public HttpContent? Get() => null;

    public bool CanRetry => true;
}