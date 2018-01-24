using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace Groot.IntegrationTest
{
    public class GuardianTest
    {
        private HttpClient Client;
        private TestServer Server;

        public GuardianTest()
        {
            //arrange
            Server = new TestServer(new WebHostBuilder().UseStartup<Startup>());
            Client = Server.CreateClient();
        }

        [Fact]
        public async Task IndexShouldReturnOkStatus()
        {
            //act
            var response = await Client.GetAsync("/groot?message=somethimg");

            //assert
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task IndexShouldReturnBadRequestStatus()
        {
            //act
            var response = await Client.GetAsync("/groot");

            //assert
            Assert.Equal(HttpStatusCode.BadRequest, response.StatusCode);
        }
    }
}
