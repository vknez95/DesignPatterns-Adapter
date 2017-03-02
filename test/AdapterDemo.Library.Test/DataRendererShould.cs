using System;
using System.IO;
using System.Linq;
using Stubs;
using Xunit;

namespace AdapterDemo.Library.Test
{
    // see example explanation on xUnit.net website:
    // https://xunit.github.io/docs/getting-started-dotnet-core.html
    public class DataRendererShould
    {
        [Fact]
        public void RenderOneRowGivenStubDataAdapter()
        {
            var myRenderer = new DataRenderer(new StubDbAdapter());

            var writer = new StringWriter();
            myRenderer.Render(writer);

            string result = writer.ToString();
            Console.Write(result);

            int lineCount = result.Count(c => c == '\n');
            Assert.Equal(4, lineCount);
        }
    }
}
