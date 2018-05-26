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
    public partial class Control : Form
    {
        public Control()
        {
            InitializeComponent();
        }

        Safe safe;


        private void BtnCreate_Click(object sender, EventArgs e)
        {
            if (TbPassword.Text != "")
            {
                safe = new Safe(TbPassword.Text);

            }
            else
            {
                safe = new Safe();
            }
            BtnCreate.Enabled = false;
            Form1 form1 = new Form1();
            Form2 form2 = new Form2();
            form1.Show();
            form2.Show();
            safe.Attach(form1, safe.GetStatus());
            safe.Attach(form2, safe.GetStatus());
        }

        private void BtnCloseOpen_Click(object sender, EventArgs e)
        {
            if (safe.GetStatus() == safeNamespace.Close.GetInstance())
            {
                if (safe.ValidPassword(TbPassword.Text))
                {
                    safe.SetStatus(Open.GetInstance());
                }
            }
            else
            {
                safe.SetStatus(safeNamespace.Close.GetInstance());
            }
            safe.Notify(safe.GetStatus());
        }
    }
}
