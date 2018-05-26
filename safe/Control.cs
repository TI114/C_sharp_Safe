using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace safe
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
                BtnCreate.Enabled = false;
                
            }
            else
            {
                safe = new Safe();
                MessageBox.Show("WTF!");
            }

        }

        private void BtnCloseOpen_Click(object sender, EventArgs e)
        {

        }
    }
}
