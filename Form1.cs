using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace problem2_1.calapini_bscpe1_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int numbers = random.Next(1, 100);
            label1.Text = numbers.ToString();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            label1.Text = "000";
        }
    }
}
