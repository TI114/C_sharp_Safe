using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace safeNamespace
{
    public interface IObserver
    {
        void Update(IState state);
    }
}
