using Bunit;
using BlazorApp1.Pages;

namespace BlazorApp1.UnitTest
{
    public class CounterTest : TestContext
    {
        [Fact]
        public void CounterComponentTest()
        {
            //Arrange 
            //Assert
            var cut = RenderComponent<Counter>();
            cut.Render();
        }

        [Fact]
        public void CounterWIllIncrementWhenExecuted()
        {
            //Arrange 
            var counter = new Counter();
            var countValue = counter.currentCount;

            //Act
            counter.IncrementCount();

            //Assert
            Assert.Equal(1, countValue+1);
        }
    }
}
