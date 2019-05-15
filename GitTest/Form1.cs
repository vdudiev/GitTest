using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GitTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


       



        private void button1_Click(object sender, EventArgs e)
        {
            int n = 100;
            while (n <= 1000000000)
            {
                StreamWriter sr = new StreamWriter("stat.txt", true);
                DateTime timeStart = DateTime.Now;
                labelTimeStart.Text = timeStart.ToString();
                labelPara.Text = n.ToString();
                this.Refresh();
                countOfDel(n);
                DateTime timeEnd = DateTime.Now;
                labelTimeEnd.Text = timeEnd.ToString();
                TimeSpan timeDelta = timeEnd - timeStart;
                labelTimeDelta.Text = timeDelta.ToString();
                sr.WriteLine(timeDelta + "\t" + n);                    
                sr.Close();
                n *= 10;
            }
        }
    
        
        

        int countOfDel(int N)
        {
            int s = 0;
            for (int i = 1; i < Math.Sqrt(N); i++)
            {
                if (N % i == 0)
                {
                    s++;
                }
            }
            return s;
        }

        private void buttonChart_Click(object sender, EventArgs e)
        {
            StreamReader srt = new StreamReader("stat.txt");
            while (!srt.EndOfStream)
            {
                string[] s = srt.ReadLine().Split();
                string ss = s[0].Split(':')[2];
                ss= ss.Replace('.', ',');
                double t = Convert.ToDouble(ss);
                double n = Convert.ToDouble(s[1]);

                chartFunction.Series[0].Points.AddXY(n,t);
            }
        }
    }
}


