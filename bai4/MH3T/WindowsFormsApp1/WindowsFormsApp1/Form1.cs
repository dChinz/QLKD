using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormKH formKH = new FormKH();
            formKH.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormHH formHH = new FormHH();
            formHH.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormHD formHD = new FormHD();
            formHD.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormReport formReport = new FormReport();
            formReport.ShowDialog();
        }
    }
}
