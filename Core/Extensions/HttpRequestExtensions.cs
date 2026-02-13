using System.Net.Http.Headers;
using PnzApi.Core.Models;

namespace PnzApi.Core.Extensions;

public static class HttpRequestExtensions
{
    extension(HttpRequestHeaders requestHeaders)
    {
        public void Add(IReadOnlyCollection<HeaderParam> headers)
        {
            foreach (var header in headers.Where(h => h.Value != null))
                    requestHeaders.Add(header.Key, header.Value);
        }
    }
}