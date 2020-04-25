using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pg_225_exc_handling
{
    class BelowOrEqualToZeroException : Exception
    {
        public BelowOrEqualToZeroException()
            : base() { }
        public BelowOrEqualToZeroException(string message)
            : base() { }
    }
}
