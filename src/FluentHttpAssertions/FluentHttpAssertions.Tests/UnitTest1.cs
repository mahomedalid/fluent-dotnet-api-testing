using Newtonsoft.Json.Linq;

namespace FluentHttpAssertions.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var api = new ApiEndpoint();

            api
                .Post()
                .ShouldSucceed()
                .WithStatusCode(System.Net.HttpStatusCode.OK)
                .Or()
                .WithStatusCode(System.Net.HttpStatusCode.Accepted)
                .And()
                .Response.ReadAsStringAsync();
        }
    }
}