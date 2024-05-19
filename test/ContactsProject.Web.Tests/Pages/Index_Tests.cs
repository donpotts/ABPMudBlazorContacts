using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace ContactsProject.Pages;

public class Index_Tests : ContactsProjectWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
