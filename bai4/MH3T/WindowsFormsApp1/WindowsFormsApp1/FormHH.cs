using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;

namespace WindowsFormsApp1
{
    public partial class FormHH : Form
    {
        public FormHH()
        {
            InitializeComponent();
        }

        BUS_HH bushh = new BUS_HH();
        Hanghoa hh = new Hanghoa();

        private void FormHH_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bushh.Loadhh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hanghoa hh = new Hanghoa(textBoxTenhang.Text, textBoxChungloai.Text,(float)Convert.ToDouble(textBoxDonGia.Text), Convert.ToInt32(textBoxSoLuong.Text));
            bushh.Insert(hh);
            dataGridView1.DataSource = bushh.Loadhh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hanghoa hh = new Hanghoa(Convert.ToInt32(label1.Text),textBoxTenhang.Text, textBoxChungloai.Text, (float)Convert.ToDouble(textBoxDonGia.Text), Convert.ToInt32(textBoxSoLuong.Text));
            bushh.Update(hh);
            dataGridView1.DataSource = bushh.Loadhh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hanghoa hh = new Hanghoa(Convert.ToInt32(label1.Text), textBoxTenhang.Text, textBoxChungloai.Text, (float)Convert.ToDouble(textBoxDonGia.Text), Convert.ToInt32(textBoxSoLuong.Text));
            bushh.Delete(hh);
            dataGridView1.DataSource = bushh.Loadhh();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            label1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBoxTenhang.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBoxChungloai.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBoxDonGia.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBoxSoLuong.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }
    }
}
