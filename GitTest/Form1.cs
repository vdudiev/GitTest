using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            DateTime timeStart = DateTime.Now;
            labelTimeStart.Text = timeStart.ToString();
            this.Refresh();
            countOfDel(1000000000);
            DateTime timeEnd = DateTime.Now;
            labelTimeEnd.Text = timeEnd.ToString();
            TimeSpan timeDelta = timeEnd - timeStart;
            labelTimeDelta.Text = timeDelta.ToString();
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
