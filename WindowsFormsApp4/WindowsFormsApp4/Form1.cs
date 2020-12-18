using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Reverse_Click(object sender, EventArgs e)
        {
            string a;
            a = textBox1.Text;           
            char[] baru = textBox1.Text.ToCharArray();
            Array.Reverse(baru);
            string output = new string(baru);



            Output.Text = output;

            if (a == string.Empty)
            {
                MessageBox.Show("inputnya di isi dong");
            }          
        }

        private void Urutkan_Click(object sender, EventArgs e)
        {
            string b;
            b = textBox1.Text;

            char[] baru2 = textBox1.Text.ToCharArray();
            Array.Sort(baru2);
            string output2 = new string(baru2);

            Output.Text = output2;

            if (b == string.Empty)
            {
                MessageBox.Show("inputnya di isi dong");
            }
        }
    }
}
