using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace safe
{
    class Close : IState
    {
        private static IState status;

        private Close()
        {

        }

        public static IState GetInstance()
        {
            if (status == null)
            {
                status = new Close();
            }
            return status;
        }

        public void safeClose(Safe safe)
        {
            // stays empty
        }

        public void safeOpen(Safe safe)
        {
            // todo: implement
        }
    }
}
