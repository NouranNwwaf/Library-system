using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgectVB
{
    internal class verifyException:Exception
    {
        public verifyException()
        { }
        public verifyException(string message) : base(message)
        { }
    }
}
