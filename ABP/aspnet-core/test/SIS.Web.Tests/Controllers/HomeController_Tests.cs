using System.Threading.Tasks;
using SIS.Models.TokenAuth;
using SIS.Web.Controllers;
using Shouldly;
using Xunit;

namespace SIS.Web.Tests.Controllers
{
    public class HomeController_Tests: SISWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}