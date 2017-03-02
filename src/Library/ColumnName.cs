namespace Library
{
    public class ColumnName
    {
        private readonly string _name;

        public ColumnName(string name)
        {
            _name = name;
        }

        public override string ToString()
        {
            return _name;
        }

        public string PadRight(int padding)
        {
            if (padding < 0)
                return ToString();
            else
                return ToString() + new string(' ', padding);
        }
    }
}