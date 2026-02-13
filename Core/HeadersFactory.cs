using PnzApi.Core.Models;

namespace PnzApi.Core;

public class HeadersFactory
{
    private readonly IReadOnlyCollection<HeaderParam> _defaultHeaders;

    public HeadersFactory(IReadOnlyCollection<HeaderParam> defaultHeaders) =>
        _defaultHeaders = defaultHeaders;

    public IReadOnlyCollection<HeaderParam> Create(IReadOnlyCollection<HeaderParam> headerParameters) =>
        _defaultHeaders.Concat(headerParameters).ToList();
}