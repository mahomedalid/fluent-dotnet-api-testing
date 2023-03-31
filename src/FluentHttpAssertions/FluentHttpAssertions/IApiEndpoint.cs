namespace FluentHttpAssertions
{
    public interface IApiEndpoint
    {
        public IHttpResponse Post(string uri, HttpContent httpContent);

        public IHttpResponse Put(string uri, HttpContent httpContent);

        public IHttpResponse Get(string uri);

        public IHttpResponse Delete(string uri);
    }
}