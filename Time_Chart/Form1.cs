using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Time_Chart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        int countDivides(int a)
        {
            int count = 0;
            for (int i = 0; i < a; i++)
                if (a % i == 0) count++;
            return count;

        }
        private void buttonStart_Click(object sender, EventArgs e)
        {
            DateTime timeStart = DateTime.Now;
            labelTimeStart.Text = timeStart.ToString();
        }
    }
}
