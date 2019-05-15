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
            for (int i = 1; i < N/2; i++)
            {
                if (N % i == 0)
                {
                    s++;
                }
            }
            return s;
        }
    }
}


