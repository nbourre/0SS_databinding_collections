using System;
using System.Collections.Generic;
using System.Text;

namespace Model_used
{
    public interface IDataService <T>
    {
        public IEnumerable<T> GetAll();
    }
}
