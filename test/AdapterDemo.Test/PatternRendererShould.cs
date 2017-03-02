using System;
using System.Collections.Generic;
using System.Linq;
using AdapterDemo.Model;
using Xunit;

namespace AdapterDemo.Test
{
    // see example explanation on xUnit.net website:
    // https://xunit.github.io/docs/getting-started-dotnet-core.html
    public class PatternRendererShould
    {
        [Fact]
        public void RenderTwoPatterns()
        {
            var myRenderer = new PatternRenderer();

            var myList = new List<Pattern>
            {
                new Pattern{ Id = 1, Name = "Pattern One", Description = "Pattern One Description" },
                new Pattern{ Id = 2, Name = "Pattern Two", Description = "Pattern Two Description" }
            };

            string result = myRenderer.ListPatterns(myList);

            Console.Write(result);

            int lineCount = result.Count(c => c == '\n');
            Assert.Equal(myList.Count + 2, lineCount);
        }
    }
}
