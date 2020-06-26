using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserControlForm
{
    public partial class BForm : Form
    {
        public string Button1
        {
            get { return button1.Text; }
            set { button1.Text = value; }
        }
        public BForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.af.TextBox1 = "ㅁㄴㅇㄻㄴㅇㄹㄴㅁㅇㄹ";
            Console.WriteLine(); Console.WriteLine();
        }
    }
}
