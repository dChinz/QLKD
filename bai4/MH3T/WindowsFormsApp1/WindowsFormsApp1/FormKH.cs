using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace WindowsFormsApp1
{
    public partial class FormKH : Form
    {
        public FormKH()
        {
            InitializeComponent();
        }

        BUS_KH buskh = new BUS_KH();
        Khachhang kh = new Khachhang();

        private void FormKH_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.DataSource = buskh.Loadkh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Khachhang kh = new Khachhang(textBoxTenKH.Text, Convert.ToDateTime(dateTimePickerNS.Text));
            buskh.Insert(kh);
            dataGridView1.DataSource = buskh.Loadkh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Khachhang kh = new Khachhang(Convert.ToInt32(label1.Text), textBoxTenKH.Text, Convert.ToDateTime(dateTimePickerNS.Text));
            buskh.Update(kh);
            dataGridView1.DataSource = buskh.Loadkh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Khachhang kh = new Khachhang(Convert.ToInt32(label1.Text), textBoxTenKH.Text, Convert.ToDateTime(dateTimePickerNS.Text));
            buskh.Delete(kh);
            dataGridView1.DataSource = buskh.Loadkh();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            label1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBoxTenKH.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString().Trim();
            dateTimePickerNS.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }
    }
}
