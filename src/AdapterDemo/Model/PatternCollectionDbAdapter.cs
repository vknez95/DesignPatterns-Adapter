using System;
using System.Collections.Generic;
using System.Linq;
using AdapterDemo.Interfaces;
using AdapterDemo.Library;
using Library;
using Library.Interfaces;

namespace AdapterDemo.Model
{
    internal class PatternCollectionDbAdapter : IDbDataAdapter
    {
        private readonly IEnumerable<Pattern> _patterns;

        public PatternCollectionDbAdapter(IEnumerable<Pattern> patterns)
        {
            _patterns = patterns;
        }

        public int Fill(DataSet dataSet)
        {
            var myDataTable = new DataTable();

            myDataTable.Columns.Add(new DataColumn("Id", typeof(int)));
            myDataTable.Columns.Add(new DataColumn("Name", typeof(string)));
            myDataTable.Columns.Add(new DataColumn("Description", typeof(string)));

            foreach (Pattern pattern in _patterns)
            {
                var myRow = myDataTable.NewRow();
                myRow[0] = pattern.Id;
                myRow[1] = pattern.Name;
                myRow[2] = pattern.Description;
                myDataTable.Rows.Add(myRow);
            }

            dataSet.Tables.Add(myDataTable);
            dataSet.AcceptChanges();

            return myDataTable.Rows.Count;
        }
    }
}