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
    public partial class AForm : Form
    {

        public string TextBox1 {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }

        public AForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Form1.bf.Button1);
            Form1.bf.Button1 = "버튼글자바뀜";
            MessageBox.Show(Form1.bf.Button1);
        }
    }
}
