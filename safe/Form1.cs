using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace safeNamespace
{
    public partial class Form1 : Form, IObserver
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Update(IState state)
        {
            if (state == safeNamespace.Close.GetInstance())
            {
                this.BackColor = Color.Magenta;
            }
            else
            {
                this.BackColor = Color.LimeGreen;
            }
        }
    }
}
