using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace 자연선1택
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            fchart.Series[0].Points.Add(20, 20, 20);


            Application.DoEvents();
            Thread.Sleep(100);
            
        }

        private void chart2_Click(object sender, EventArgs e)
        {

        }
    }
}
