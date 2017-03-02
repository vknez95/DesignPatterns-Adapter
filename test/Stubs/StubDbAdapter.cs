using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Library;
using Library.Interfaces;

namespace Stubs
{
    public class StubDbAdapter : IDbDataAdapter
    {
        public int Fill(DataSet dataSet)
        {
            var myDataTable = new DataTable();
            myDataTable.Columns.Add(new DataColumn("Id", typeof(int)));
            myDataTable.Columns.Add(new DataColumn("Name", typeof(string)));
            myDataTable.Columns.Add(new DataColumn("Description", typeof(string)));

            var myRow = myDataTable.NewRow();
            myRow[0] = 1;
            myRow[1] = "Adapter";
            myRow[2] = "Adapter Description";

            var myRow2 = myDataTable.NewRow();
            myRow2[0] = 2;
            myRow2[1] = "Chain of responsibility";
            myRow2[2] = "Chain of responsibility description";

            myDataTable.Rows.Add(myRow);
            myDataTable.Rows.Add(myRow2);

            dataSet.Tables.Add(myDataTable);
            dataSet.AcceptChanges();

            return 2;
        }
    }
}
