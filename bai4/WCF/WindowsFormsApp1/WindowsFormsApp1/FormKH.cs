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
    public partial class FormKH : Form
    {
        public FormKH()
        {
            InitializeComponent();
        }

        Service1Client client = new Service1Client();

        private void FormKH_Load(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            List<Khachhang> khachhangs = client.Loadkh().ToList();

            foreach(var sp in khachhangs)
            {
                ListViewItem lv = new ListViewItem(Convert.ToInt32(sp.makh).ToString());
                lv.SubItems.Add(sp.tenkh);
                lv.SubItems.Add(Convert.ToDateTime(sp.ngaysinh).ToString("dd/MM/yyyy"));
                listView1.Items.Add(lv);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Khachhang khachhang = new Khachhang
            {
                tenkh = textBoxTenKH.Text,
                ngaysinh = Convert.ToDateTime(dateTimePickerNS.Text),
            };
            client.Insertkh(khachhang);
            listView1.Items.Clear();
            var customers = client.Loadkh().ToList();
            foreach (var sp in customers)
            {
                ListViewItem lv = new ListViewItem(Convert.ToInt32(sp.makh).ToString());
                lv.SubItems.Add(sp.tenkh);
                lv.SubItems.Add(Convert.ToDateTime(sp.ngaysinh).ToString("dd/MM/yyyy"));
                listView1.Items.Add(lv);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Khachhang khachhang = new Khachhang
            {
                makh = Convert.ToInt32(label1.Text),
                tenkh = textBoxTenKH.Text,
                ngaysinh = Convert.ToDateTime(dateTimePickerNS.Text),
            };
            client.Updatekh(khachhang);
            listView1.Items.Clear();
            var customers = client.Loadkh().ToList();
            foreach (var sp in customers)
            {
                ListViewItem lv = new ListViewItem(Convert.ToInt32(sp.makh).ToString());
                lv.SubItems.Add(sp.tenkh);
                lv.SubItems.Add(Convert.ToDateTime(sp.ngaysinh).ToString("dd/MM/yyyy"));
                listView1.Items.Add(lv);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Khachhang khachhang = new Khachhang
            {
                makh = Convert.ToInt32(label1.Text),
                tenkh = textBoxTenKH.Text,
                ngaysinh = Convert.ToDateTime(dateTimePickerNS.Text),
            };
            client.Deletekh(khachhang);
            listView1.Items.Clear();
            var customers = client.Loadkh().ToList();
            foreach (var sp in customers)
            {
                ListViewItem lv = new ListViewItem(Convert.ToInt32(sp.makh).ToString());
                lv.SubItems.Add(sp.tenkh);
                lv.SubItems.Add(Convert.ToDateTime(sp.ngaysinh).ToString("dd/MM/yyyy"));
                listView1.Items.Add(lv);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var khachhangs = client.Loadkh().ToList();

            if(listView1.SelectedItems.Count > 0)
            {
                ListViewItem lv = listView1.SelectedItems[0];

                label1.Text = lv.SubItems[0].ToString();
                textBoxTenKH.Text = lv.SubItems[1].ToString();
                dateTimePickerNS.Text = lv.SubItems[2].ToString();
            }
        }
    }
}
