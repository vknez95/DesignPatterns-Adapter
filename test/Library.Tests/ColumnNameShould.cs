using Xunit;

namespace Library.Tests
{
    // see example explanation on xUnit.net website:
    // https://xunit.github.io/docs/getting-started-dotnet-core.html
    public class ColumnNameShould
    {
        private readonly string _name;
        private readonly ColumnName _columnName;

        public ColumnNameShould()
        {
            _name = "Number";
            _columnName = new ColumnName(_name);
        }

        [Fact]
        public void ReturnCorrectToStringValue()
        {
            Assert.Equal(_name, _columnName.ToString());
        }

        [Fact]
        public void ReturnCorrectToStringValueWithPadRight()
        {
            int padding = 5;

            Assert.Equal(_columnName + "     ", _columnName.PadRight(padding));
        }

        [Theory]
        [InlineData(-3),]
        [InlineData(-5)]
        public void ReturnToStringValueIfPaddingIsNegative(int padding)
        {
            Assert.Equal(_columnName + "", _columnName.PadRight(padding));
        }
    }
}
