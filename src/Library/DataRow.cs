using System;
using System.Collections.Generic;
using System.Linq;

namespace Library
{
    public class DataRow
    {
        private Dictionary<DataColumn, object> _data = new Dictionary<DataColumn, object>();

        public object this[DataColumn dataColumn]
        {
            get
            {
                object obj = null;

                if (_data.TryGetValue(dataColumn, out obj))
                    return _data[dataColumn];
                else
                    throw new InvalidOperationException();
            }
            set
            {
                object obj = null;

                if (_data.TryGetValue(dataColumn, out obj))
                    _data[dataColumn] = value;
                else
                    _data.Add(dataColumn, value);
            }
        }

        public object this[int index]
        {
            get
            {
                int i = 0;
                foreach (DataColumn column in _data.Keys)
                {
                    if (i == index)
                        return _data[column];
                    i++;
                }

                throw new InvalidOperationException();
            }
            set
            {
                var pair = _data.Skip(index).Take(1).Single();

                DataColumn col = new DataColumn(pair.Key.ColumnName.ToString(), pair.Key.Type);

                _data[col] = value;
            }
        }
    }
}