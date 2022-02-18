using blazorapp.Pages;
using Xunit;
using Bunit;
using static Bunit.ComponentParameterFactory;

namespace blazortest
{
    public class CounterComponentTest
    {
        public CounterComponentTest()
        {
        }

        [Fact]
        void CounterComponentHelloTest()
        {
            using var ctx = new TestContext();
            // Arrange - renders the Counter component
            var cut = ctx.RenderComponent<Counter>();

            // Assert 
            // Here we specify expected HTML from CUT. 
            var expectedHtml = @"<h1>Counter</h1>
                        <p>Current count: 0</p>
                        <button class=""btn-primary btn"">Click me</button>";

            // Here we use the HTML diffing library to assert that the rendered HTML
            // from CUT is semantically the same as the expected HTML string above.
            cut.MarkupMatches(expectedHtml);
        }
    }
}