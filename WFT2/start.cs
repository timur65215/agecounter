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
    public partial class start : Form
    {
        public start()
        {
            InitializeComponent();
        }

        private void start_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            rus rus = new rus();
            rus.Show();
        }

        private void englishl_Click(object sender, EventArgs e)
        {
            Hide();
            eng eng = new eng();
            eng.Show();
        }

        private void ukranianl_Click(object sender, EventArgs e)
        {
            Hide();
            ukr ukr = new ukr();
            ukr.Show();
        }
    }
}
