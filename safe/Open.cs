using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace safeNamespace
{
    class Open : IState
    {
        private static IState status;

        private Open()
        {

        }

        public static IState GetInstance()
        {
            if(status == null)
            {
                status = new Open();
            }
            return status;
        }

        public void SafeClose(Safe safe)
        {
            status = Close.GetInstance();
        }

        public void SafeOpen(Safe safe)
        {
            // stays empty
        }
    }
}
