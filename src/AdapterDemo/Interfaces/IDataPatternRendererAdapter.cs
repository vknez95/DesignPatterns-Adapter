using System.Collections.Generic;
using AdapterDemo.Model;

namespace AdapterDemo.Interfaces
{
    public interface IDataPatternRendererAdapter
    {
        string ListPatterns(IEnumerable<Pattern> patterns);
    }
}