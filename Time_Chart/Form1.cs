using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            for (int i = 1; i < a; i++)
                if (a % i == 0) count++;
            return count;

        }
        private void buttonStart_Click(object sender, EventArgs e)
        {
            int n = 100;
            while (n <= 1000000000)
            {
                StreamWriter sr = new StreamWriter("stat.txt", true);
                DateTime timeStart = DateTime.Now;
                labelTimeStart.Text = timeStart.ToString();
                labelParam.Text = n.ToString();
                this.Refresh();
                countDivides(n);
                DateTime timeEnd = DateTime.Now;
                TimeSpan timeDelta = timeEnd - timeStart;
                labelTimeEnd.Text = timeEnd.ToString();
                labelTimeDelta.Text = timeDelta.ToString();
                sr.WriteLine(timeDelta + "\t" + n);
                sr.Close();
                n *= 10;
            }
        }
    }

      

   
    }
