namespace FluentHttpAssertions
{
    public class ApiEndpoint : IApiEndpoint
    {
        public IHttpResponse Get(string uri)
        {
            throw new NotImplementedException();
        }

        public IHttpResponse Post(string uri, HttpContent httpContent)
        {
            throw new NotImplementedException();
        }

        public IHttpResponse Put(string uri, HttpContent httpContent)
        {
            throw new NotImplementedException();
        }

        public IHttpResponse Delete(string uri)
        {
            throw new NotImplementedException();
        }
    }
}