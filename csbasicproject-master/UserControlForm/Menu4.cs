using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserControlForm
{
    public partial class Menu4 : UserControl
    {
        public Menu4()
        {
            InitializeComponent();
        }

        private void Menu4_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;


            listView1.Columns.Add("a",100);
            listView1.Columns.Add("b",50);
            listView1.Columns.Add("c",30);
            listView1.Columns.Add("d",40);

            ListViewItem item1 = new ListViewItem(new String[] { "1", "2", "3", "4" });
            ListViewItem item2 = new ListViewItem(new String[] { "1", "2", "3", "4" });
            ListViewItem item3 = new ListViewItem(new String[] { "1", "2", "3", "4" });
            ListViewItem item4 = new ListViewItem(new String[] { "1", "2", "3", "4" });

            listView1.Items.Add(item1);
            listView1.Items.Add(item2);
            listView1.Items.Add(item3);
            listView1.Items.Add(item4);
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show(Application.StartupPath);
            this.BackgroundImage = Image.FromFile(Application.StartupPath+$@"\..\..\Resources\Penguins.jpg");
        }
    }
}
