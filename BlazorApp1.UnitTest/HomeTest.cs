using BlazorApp1;
using BlazorApp1.Pages;
using Bunit;
using System.Diagnostics.Metrics;
using Xunit;

namespace BlazorApp1.UnitTest
{
    public class HomeTest: TestContext
    {
        [Fact]
        public void Test1()
        {
            var cut = RenderComponent<Home>();

            cut.MarkupMatches("<h1>Hello, world!</h1>");
        }
    }
}