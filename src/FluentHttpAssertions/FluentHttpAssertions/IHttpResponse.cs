namespace FluentHttpAssertions
{
    public interface IHttpResponse
    {
        IHttpResponseValidation ShouldSucceed();

        IHttpResponseValidation ShouldFail();
    }
}