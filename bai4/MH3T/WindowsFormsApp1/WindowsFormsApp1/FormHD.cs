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
    public partial class FormHD : Form
    {
        public FormHD()
        {
            InitializeComponent();
        }

        BUS_HD bushd = new BUS_HD();
        Hoadon hd = new Hoadon();
        BUS_HH bushh = new BUS_HH();
        BUS_KH buskh = new BUS_KH();    

        private void FormHD_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bushd.Loadhd();

            comboBoxMahang.DataSource = bushh.Loadhh();
            comboBoxMahang.DisplayMember = "mahang";
            comboBoxMahang.ValueMember = "mahang";
            comboBoxMahang.SelectedIndex = -1;

            comboBoxMakh.DataSource = buskh.Loadkh();
            comboBoxMakh.DisplayMember = "makh";
            comboBoxMakh.ValueMember = "makh";
            comboBoxMakh.SelectedIndex = -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int SL = bushd.GetSL(comboBoxMahang.Text);
            if(SL < Convert.ToInt32(textBoxSoluong.Text))
            {
                MessageBox.Show("so qua lon");
                return;
            }
            Hoadon hd = new Hoadon(DateTime.Now, Convert.ToInt32(comboBoxMakh.Text), Convert.ToInt32(comboBoxMahang.Text), Convert.ToInt32(textBoxSoluong.Text));
            bushd.Insert(hd);
            int SL_new = SL - Convert.ToInt32(textBoxSoluong.Text);
            bushd.UpdateSL(comboBoxMahang.Text, SL_new);
            dataGridView1.DataSource = bushd.Loadhd();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int SL = bushd.GetSL(comboBoxMahang.Text);
            if (SL < Convert.ToInt32(textBoxSoluong.Text))
            {
                MessageBox.Show("so qua lon");
                return;
            }
            int SL_old = bushd.GetSL_2(label1.Text);
            Hoadon hd = new Hoadon(Convert.ToInt32(label1.Text) ,DateTime.Now, Convert.ToInt32(comboBoxMakh.Text), Convert.ToInt32(comboBoxMahang.Text), Convert.ToInt32(textBoxSoluong.Text));
            bushd.Update(hd);
            int SL_new = SL + SL_old - Convert.ToInt32(textBoxSoluong.Text);
            bushd.UpdateSL(comboBoxMahang.Text, SL_new);
            dataGridView1.DataSource = bushd.Loadhd();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int SL = bushd.GetSL(comboBoxMahang.Text);
            if (SL < Convert.ToInt32(textBoxSoluong.Text))
            {
                MessageBox.Show("so qua lon");
                return;
            }
            int SL_old = bushd.GetSL_2(label1.Text);
            Hoadon hd = new Hoadon(Convert.ToInt32(label1.Text), DateTime.Now, Convert.ToInt32(comboBoxMakh.Text), Convert.ToInt32(comboBoxMahang.Text), Convert.ToInt32(textBoxSoluong.Text));
            bushd.Delete(hd);
            int SL_new = SL + SL_old;
            bushd.UpdateSL(comboBoxMahang.Text, SL_new);
            dataGridView1.DataSource = bushd.Loadhd();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            label1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            label2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            comboBoxMakh.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            comboBoxMahang.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBoxSoluong.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }
    }
}
