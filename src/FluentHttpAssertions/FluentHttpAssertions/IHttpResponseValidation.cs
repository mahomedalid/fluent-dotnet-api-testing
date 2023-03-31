using Newtonsoft.Json.Linq;

namespace FluentHttpAssertions
{
    public interface IHttpResponseValidation
    {
        IHttpResponseValidation WithStatusCode(System.Net.HttpStatusCode statusCode);

        IHttpResponseValidation Or();

        IHttpResponseValidation And();

        HttpContent Response { get; }
    }
}