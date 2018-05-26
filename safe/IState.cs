using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace safe
{
    public interface IState
    {
        void SafeClose(Safe safe);
        void SafeOpen(Safe safe);
    }
}
