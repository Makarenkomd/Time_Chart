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
            for (int i = 1; i < Math.Sqrt(a); i++)
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

        private void buttonChart_Click(object sender, EventArgs e)
        {
           // chartFunction.Series[0].Points.AddXY(10, 10);
         //   chartFunction.Series[0].Points.AddXY(100, 20);
//chartFunction.Series[0].Points.AddXY(200, 100);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("stat.txt");
            StreamReader sr1 = new StreamReader("stat1.txt");
           
            while (!sr.EndOfStream)
            {
                string[] s = sr.ReadLine().Split();
                string ss = s[0].Split(':')[2];
                double t = Convert.ToDouble(ss.Replace('.', ','));
                int n = Convert.ToInt32(s[1]);
                chart1.Series[0].Points.AddXY(n, t);

                s = sr1.ReadLine().Split();
                ss = s[0].Split(':')[2];
                t = Convert.ToDouble(ss.Replace('.', ','));
                n = Convert.ToInt32(s[1]);
                chart1.Series[1].Points.AddXY(n, t);

            }
            sr.Close();
            sr1.Close();
            }
        }
    }

      

   

