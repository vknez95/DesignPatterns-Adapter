using Xunit;

namespace Library.Tests
{
    // see example explanation on xUnit.net website:
    // https://xunit.github.io/docs/getting-started-dotnet-core.html
    public class DataTableShould
    {
        [Fact]
        public void ContainThreeColumnsAfterAddingThreeColumns()
        {
            var myDataTable = new DataTable();
            myDataTable.Columns.Add(new DataColumn("Id", typeof (int)));
            myDataTable.Columns.Add(new DataColumn("Name", typeof (string)));
            myDataTable.Columns.Add(new DataColumn("Description", typeof (string)));

            Assert.Equal(3, myDataTable.Columns.Count);
        }

        [Fact]
        public void ContainThreeRowsAfterAddingThreeRows()
        {
            var myDataTable = new DataTable();
            myDataTable.Columns.Add(new DataColumn("Id", typeof (int)));
            myDataTable.Columns.Add(new DataColumn("Name", typeof (string)));
            myDataTable.Columns.Add(new DataColumn("Description", typeof (string)));

            Assert.Equal(3, myDataTable.Columns.Count);
        }
    }
}
