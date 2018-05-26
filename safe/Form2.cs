using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace safeNamespace
{
    public partial class Form2 : Form, IObserver
    {
        public Form2()
        {
            InitializeComponent();
        }

        public void LoadPictureOpen()
        {
            string PfadBild = @"./../../Open_Safe.png";
            StreamReader SR = new StreamReader(PfadBild);
            Bitmap Bild = new Bitmap(SR.BaseStream);
            SR.Close();
            this.pictureBox1.Size = new System.Drawing.Size(Bild.Size.Width, Bild.Size.Height);
            this.pictureBox1.Image = Bild;
        }

        public void LoadPictureClose()
        {
            string PfadBild = @"./../../Closed_Safe.png";
            StreamReader SR = new StreamReader(PfadBild);
            Bitmap Bild = new Bitmap(SR.BaseStream);
            SR.Close();
            this.pictureBox1.Size = new System.Drawing.Size(Bild.Size.Width, Bild.Size.Height);
            this.pictureBox1.Image = Bild;
        }

        public void Update(IState state)
        {
            if (state == safeNamespace.Close.GetInstance())
            {
                LoadPictureClose();
            }
            else
            {
                LoadPictureOpen();
            }


        }
    }
}
