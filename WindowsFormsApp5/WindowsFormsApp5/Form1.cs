using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            inputan.CharacterCasing = CharacterCasing.Upper;
            char[] input = inputan.Text.ToCharArray();
            char[] alpha1 = awal.Text.ToCharArray();
            char[] alpha2 = akhir.Text.ToCharArray();
            char alfa1 = Convert.ToChar(awal.Text);
            char alfa2 = alpha2[0];
            int range = alfa2 - alfa1;
            string hasil = " ";
            char spasi1 = '/';
            char space = ' ';
            string huruf = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            char[] charhuruf = huruf.ToCharArray();
            if (range < 0)
            {
                range += 26 ;
            }
            for (int i = 0 ; i < inputan.Text.Length ; i++)
            {
                for (int j = 0 ; j < 26 ; j++)
                {
                    if (charhuruf[j] == input[i])
                    {
                        int baru = j + range;
                        if (baru >= 26)
                        {
                            baru -= 26;
                        }
                        input[i] = charhuruf[baru];
                        hasil += input[i];                       
                        input[i] = spasi1;
                    }
                    if (input[i] == space)
                    {
                        hasil   += " ";                                           
                        input[i] = spasi1;
                    }
                }
            }
            labelOutput.Text = hasil;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

        
    

