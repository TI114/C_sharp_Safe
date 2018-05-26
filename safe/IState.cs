using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace safeNamespace
{
    public interface IState
    {
        void SafeClose(Safe safe);
        void SafeOpen(Safe safe);
    }
}
