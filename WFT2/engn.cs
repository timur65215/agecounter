using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WFT2
{
    public partial class engn : Form
    {
        public engn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void nexteng2_Click(object sender, EventArgs e)
        {
            int sb2;
            sb2 = Convert.ToInt32(dobbox.Text);
            if (sb2 > 127 || sb2 < -128)
            {
                MessageBox.Show($"Wrong value, try again:");
                sb2 = 0;
            }

            int dob;
            dob = Convert.ToSByte(sb2);
            if (dob > 31 || dob <= 0)
            {
                Console.WriteLine($"Wrong value, try again:");
            }

            int sb3;
            sb3 = Convert.ToInt32(mobbox.Text);
            if (sb3 > 127 || sb3 < -128)
            {
                MessageBox.Show($"Wrong value, try again:");
                sb3 = 0;
            }

            sbyte mob;
            mob = Convert.ToSByte(sb3);
            if (mob > 12 || mob <= 0)
            {
                MessageBox.Show($"Wrong value, try again");
            }

            int sb4;
            sb4 = Convert.ToInt32(yobbox.Text);
            if (sb4 > 32767 || sb4 < -32768)
            {
                MessageBox.Show($"Wrong value, try again:");
                sb4 = 0;
            }

            short yob;
            yob = Convert.ToInt16(sb4);
            if (yob <= 0)
            {
                MessageBox.Show($"Wrong value, try again:");
                yob = 1;
            }

            DateTime ddob = new DateTime(yob, mob, dob);
            DateTime now = DateTime.Now;
            TimeSpan diff1 = now - ddob;
            int yy = diff1.Days / 365;
            MessageBox.Show($"Your age is {yy}!");
            return;
        }
    }
}
