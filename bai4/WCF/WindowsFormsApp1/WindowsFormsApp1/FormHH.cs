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
    public partial class FormHH : Form
    {
        public FormHH()
        {
            InitializeComponent();
        }

        Service1Client client = new Service1Client();

        private void FormHH_Load(object sender, EventArgs e)
        {
            List<Hanghoa> hanghoas = client.Loadhh().ToList();

            foreach(var hh in hanghoas)
            {
                ListViewItem lv = new ListViewItem(Convert.ToInt32(hh.mahang).ToString());
                lv.SubItems.Add(hh.tenhang);
                lv.SubItems.Add(hh.chungloai);
                lv.SubItems.Add(Convert.ToDouble(hh.dongia).ToString());
                lv.SubItems.Add(Convert.ToInt32(hh.soluong).ToString());
                listView1.Items.Add(lv);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hanghoa hanghoa = new Hanghoa
            {
                tenhang = textBoxTenhang.Text,
                chungloai = textBoxChungloai.Text,
                dongia = (float)Convert.ToDouble(textBoxDonGia.Text),
                soluong = Convert.ToInt32(textBoxSoLuong.Text),
            };
            client.Inserthh(hanghoa);
            listView1.Items.Clear();
            var hanghoas = client.Loadhh().ToList();
            foreach (var hh in hanghoas)
            {
                ListViewItem lv = new ListViewItem(Convert.ToInt32(hh.mahang).ToString());
                lv.SubItems.Add(hh.tenhang);
                lv.SubItems.Add(hh.chungloai);
                lv.SubItems.Add(Convert.ToDouble(hh.dongia).ToString());
                lv.SubItems.Add(Convert.ToInt32(hh.soluong).ToString());
                listView1.Items.Add(lv);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hanghoa hanghoa = new Hanghoa
            {
                mahang = Convert.ToInt32(label1.Text),
                tenhang = textBoxTenhang.Text,
                chungloai = textBoxChungloai.Text,
                dongia = (float)Convert.ToDouble(textBoxDonGia.Text),
                soluong = Convert.ToInt32(textBoxSoLuong.Text),
            };
            client.Updatehh(hanghoa);
            listView1.Items.Clear();
            var hanghoas = client.Loadhh().ToList();
            foreach (var hh in hanghoas)
            {
                ListViewItem lv = new ListViewItem(Convert.ToInt32(hh.mahang).ToString());
                lv.SubItems.Add(hh.tenhang);
                lv.SubItems.Add(hh.chungloai);
                lv.SubItems.Add(Convert.ToDouble(hh.dongia).ToString());
                lv.SubItems.Add(Convert.ToInt32(hh.soluong).ToString());
                listView1.Items.Add(lv);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hanghoa hanghoa = new Hanghoa
            {
                mahang = Convert.ToInt32(label1.Text),
                tenhang = textBoxTenhang.Text,
                chungloai = textBoxChungloai.Text,
                dongia = (float)Convert.ToDouble(textBoxDonGia.Text),
                soluong = Convert.ToInt32(textBoxSoLuong.Text),
            };
            client.Deletehh(hanghoa);
            listView1.Items.Clear();
            var hanghoas = client.Loadhh().ToList();
            foreach (var hh in hanghoas)
            {
                ListViewItem lv = new ListViewItem(Convert.ToInt32(hh.mahang).ToString());
                lv.SubItems.Add(hh.tenhang);
                lv.SubItems.Add(hh.chungloai);
                lv.SubItems.Add(Convert.ToDouble(hh.dongia).ToString());
                lv.SubItems.Add(Convert.ToInt32(hh.soluong).ToString());
                listView1.Items.Add(lv);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count > 0)
            {
                ListViewItem lv = listView1.SelectedItems[0];

                textBoxTenhang.Text = lv.SubItems[0].ToString();
                textBoxChungloai.Text = lv.SubItems[1].ToString();
                textBoxDonGia.Text = lv.SubItems[2].ToString();
                textBoxSoLuong.Text = lv.SubItems[3].ToString();
            }
        }
    }
}
