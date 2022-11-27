using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFT2
{
    public partial class eng : Form
    {
        public eng()
        {
            InitializeComponent();
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void nexteng1_Click(object sender, EventArgs e)
        {
            
            string name = textBox1.Text;
            

                int b;
                bool check = Int32.TryParse(name, out b);
                int x = 0;
                for (int i = 0; i < 10; i++)
                {
                    if (name.Contains(i.ToString()))
                    {
                        x = 1;
                    }
                }

                if ((x != 1) && (name.Length > 1))
                {
                Hide();
                MessageBox.Show("Welcome!, " + name + "!");
                engn engn = new engn();
                engn.Show();
            }
                else
                {
                MessageBox.Show("You can enter letters only!");
                eng eng = new eng();
                eng.Show();
                }

            Close();
        }
    }
}
