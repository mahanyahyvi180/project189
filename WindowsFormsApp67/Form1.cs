using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp67
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] x = new int[] { 10, 20, 30, 40 };
            for (int i = 0; i < x.GetUpperBound(0); i++)
                listBox1.Items.Add(x[i]);
        }
    }
}
