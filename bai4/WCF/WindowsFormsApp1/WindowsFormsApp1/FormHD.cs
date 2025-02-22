using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.ServiceReference1;

namespace WindowsFormsApp1
{
    public partial class FormHD : Form
    {
        public FormHD()
        {
            InitializeComponent();
        }

        Service1Client client = new Service1Client();

        private void FormHD_Load(object sender, EventArgs e)
        {
            List<Hoadon> hoadons = client.Loadhd().ToList();
            foreach(var hd in hoadons)
            {
                ListViewItem lv = new ListViewItem(Convert.ToInt32(hd.mahd).ToString());
                lv.SubItems.Add(Convert.ToDateTime(hd.ngaymua).ToString("dd/MM/yyyy"));
                lv.SubItems.Add(Convert.ToInt32(hd.makh).ToString());
                lv.SubItems.Add(Convert.ToInt32(hd.mahang).ToString());
                lv.SubItems.Add(Convert.ToInt32(hd.soluong).ToString());
                listView1.Items.Add(lv);
            }

            List<ServiceReference1.Khachhang> khachhangs = client.Loadkh().ToList();
            comboBoxMakh.DataSource = khachhangs;
            comboBoxMakh.DisplayMember = "makh";
            comboBoxMakh.ValueMember = "makh";
            comboBoxMakh.SelectedIndex = -1;

            List<ServiceReference1.Hanghoa> hanghoas = client.Loadhh().ToList();
            comboBoxMahang.DataSource = hanghoas;
            comboBoxMahang.DisplayMember = "mahang";
            comboBoxMahang.ValueMember = "mahang";
            comboBoxMahang.SelectedIndex = -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int SL = client.GetSL(comboBoxMahang.Text);
            if (SL < Convert.ToInt32(textBoxSoluong.Text))
            {
                MessageBox.Show("so qua lon");
                return;
            }
            Hoadon hoadon = new Hoadon
            {
                ngaymua = DateTime.Now,
                makh = Convert.ToInt32(comboBoxMakh.Text),
                mahang = Convert.ToInt32(comboBoxMahang.Text),
                soluong = Convert.ToInt32(textBoxSoluong.Text),
            };
            client.Inserthd(hoadon);
            int SL_new = SL - Convert.ToInt32(textBoxSoluong.Text);
            client.UpdateSL(comboBoxMahang.Text, SL_new);
            listView1.Items.Clear();
            var hoadons = client.Loadhd().ToList();
            foreach (var hd in hoadons)
            {
                ListViewItem lv = new ListViewItem(Convert.ToInt32(hd.mahd).ToString());
                lv.SubItems.Add(Convert.ToDateTime(hd.ngaymua).ToString("dd/MM/yyyy"));
                lv.SubItems.Add(Convert.ToInt32(hd.makh).ToString());
                lv.SubItems.Add(Convert.ToInt32(hd.mahang).ToString());
                lv.SubItems.Add(Convert.ToInt32(hd.soluong).ToString());
                listView1.Items.Add(lv);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int SL = client.GetSL(comboBoxMahang.Text);
            if (SL < Convert.ToInt32(textBoxSoluong.Text))
            {
                MessageBox.Show("so qua lon");
                return;
            }
            Hoadon hoadon = new Hoadon
            {
                mahd = Convert.ToInt32(label1.Text),
                ngaymua = DateTime.Now,
                makh = Convert.ToInt32(comboBoxMakh.Text),
                mahang = Convert.ToInt32(comboBoxMahang.Text),
                soluong = Convert.ToInt32(textBoxSoluong.Text),
            };
            client.Updatehd(hoadon);
            int SL_old = client.GetSL_2(label1.Text);
            int SL_new = SL + SL_old - Convert.ToInt32(textBoxSoluong.Text);
            client.UpdateSL(comboBoxMahang.Text, SL_new);
            listView1.Items.Clear();
            var hoadons = client.Loadhd().ToList();
            foreach (var hd in hoadons)
            {
                ListViewItem lv = new ListViewItem(Convert.ToInt32(hd.mahd).ToString());
                lv.SubItems.Add(Convert.ToDateTime(hd.ngaymua).ToString("dd/MM/yyyy"));
                lv.SubItems.Add(Convert.ToInt32(hd.makh).ToString());
                lv.SubItems.Add(Convert.ToInt32(hd.mahang).ToString());
                lv.SubItems.Add(Convert.ToInt32(hd.soluong).ToString());
                listView1.Items.Add(lv);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int SL = client.GetSL(comboBoxMahang.Text);
            Hoadon hoadon = new Hoadon
            {
                mahd = Convert.ToInt32(label1.Text),
                ngaymua = DateTime.Now,
                makh = Convert.ToInt32(comboBoxMakh.Text),
                mahang = Convert.ToInt32(comboBoxMahang.Text),
                soluong = Convert.ToInt32(textBoxSoluong.Text),
            };
            client.Deletehd(hoadon);
            int SL_new = SL + Convert.ToInt32(textBoxSoluong.Text);
            client.UpdateSL(comboBoxMahang.Text, SL_new);
            listView1.Items.Clear();
            var hoadons = client.Loadhd().ToList();
            foreach (var hd in hoadons)
            {
                ListViewItem lv = new ListViewItem(Convert.ToInt32(hd.mahd).ToString());
                lv.SubItems.Add(Convert.ToDateTime(hd.ngaymua).ToString("dd/MM/yyyy"));
                lv.SubItems.Add(Convert.ToInt32(hd.makh).ToString());
                lv.SubItems.Add(Convert.ToInt32(hd.mahang).ToString());
                lv.SubItems.Add(Convert.ToInt32(hd.soluong).ToString());
                listView1.Items.Add(lv);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count > 0)
            {
                ListViewItem lv = listView1.SelectedItems[0];
                label1.Text = lv.SubItems[0].Text;
                label2.Text = lv.SubItems[1].Text;
                comboBoxMakh.Text = lv.SubItems[2].Text;
                comboBoxMahang.Text = lv.SubItems[3].Text;
                textBoxSoluong.Text = lv.SubItems[4].Text;
            }
        }
    }
}
