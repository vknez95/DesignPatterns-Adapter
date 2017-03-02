using System;
using System.Collections.Generic;
using System.Linq;

namespace Library
{
    public class DataRowBuilder
    {
        private readonly IEnumerable<DataColumn> _columns;

        public DataRowBuilder(IEnumerable<DataColumn> columns)
        {
            if (columns == null || columns.Count() == 0)
                throw new ArgumentException();

            _columns = columns;
        }

        public DataRow BuildRow()
        {
            DataRow row = new DataRow();

            _columns.ToList().ForEach(column => row[column] = "");

            return row;
        }
    }
}