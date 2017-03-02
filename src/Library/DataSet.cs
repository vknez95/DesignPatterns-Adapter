using System.Collections.Generic;

namespace Library
{
    public class DataSet
    {
        public IList<DataTable> Tables { get; set; } = new List<DataTable>();
        public void AcceptChanges()
        {
        }
    }
}