using System;
using Xunit;

namespace Library.Tests
{
    // see example explanation on xUnit.net website:
    // https://xunit.github.io/docs/getting-started-dotnet-core.html
    public class DataRowShould
    {
        private DataRow _dataRow = new DataRow();

        [Fact]
        public void AddAndRetrieveValuesIndexedByDataColumn()
        {
            DataColumn dataColumn = new DataColumn("Age", typeof(int));
            _dataRow[dataColumn] = 5;

            Assert.Equal(5, _dataRow[dataColumn]);
        }

        [Fact]
        public void OverwritePreviouslyAddedValueIndexedByDataColumn()
        {
            DataColumn dataColumn = new DataColumn("Age", typeof(int));
            _dataRow[dataColumn] = 5;
            _dataRow[dataColumn] = 3;

            Assert.Equal(3, _dataRow[dataColumn]);
        }

        [Fact]
        public void RetrieveValueByIndex()
        {
            DataColumn dataColumn = new DataColumn("Age", typeof(int));
            _dataRow[dataColumn] = 5;

            Assert.Equal(5, _dataRow[0]);
        }

        [Fact]
        public void SetValueByIndex()
        {
            DataColumn dataColumn = new DataColumn("Age", typeof(int));
            _dataRow[dataColumn] = 5;
            _dataRow[0] = 3;

            Assert.Equal(3, _dataRow[0]);
        }

        [Fact]
        public void SetMultipleValuesByIndex()
        {
            DataColumn dataColumn = new DataColumn("Age", typeof(int));
            _dataRow[dataColumn] = 5;

            DataColumn dataColumn2 = new DataColumn("LastName", typeof(string));
            _dataRow[dataColumn2] = "Knezevic";

            _dataRow[0] = 3;
            _dataRow[1] = "Knele";

            Assert.Equal("Knele", _dataRow[1]);
        }
    }
}
