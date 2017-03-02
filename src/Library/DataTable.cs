using System.Collections.Generic;

namespace Library
{
    public class DataTable
    {
        public DataTable()
        {
            Columns = new List<DataColumn>();
            Rows = new List<DataRow>();
        }

        public DataRow NewRow()
        {
            return new DataRowBuilder(Columns).BuildRow();
        }

        public IList<DataColumn> Columns { get; set; }
        public IList<DataRow> Rows { get; set; }
    }
}