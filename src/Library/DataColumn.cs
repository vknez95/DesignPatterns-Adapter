using System;

namespace Library
{
    public class DataColumn
    {
        public DataColumn(string columnName, Type type)
        {
            if (columnName == null || type == null)
                throw new ArgumentException();

            ColumnName = new ColumnName(columnName);
            Type = type;
        }

        public ColumnName ColumnName { get; private set; }
        public Type Type { get; private set; }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            if (ColumnName.ToString() == ((DataColumn)obj).ColumnName.ToString() &&
                Type == ((DataColumn)obj).Type)
                return true;

            return false;
        }

        public override int GetHashCode()
        {
            return (ColumnName + Type.FullName).GetHashCode();
        }
    }
}