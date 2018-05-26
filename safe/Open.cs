using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace safe
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

        public void safeClose(Safe safe)
        {
            // todo: implement logic
        }

        public void safeOpen(Safe safe)
        {
            // stays empty
        }
    }
}
