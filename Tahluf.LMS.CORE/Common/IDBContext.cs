using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;

namespace Tahluf.LMS.CORE.Common
{
    public interface IDBContext
    {
        public DbConnection Connection { get; }
    }
}
