using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace GorselFinalProject
{
    public partial class Form1 : Form
    {
        ListViewItem list = new ListViewItem();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.Columns.Add("TC KİMLİK NO", 125);
            listView1.Columns.Add("AD VE SOYAD", 95);
            listView1.Columns.Add("ADRES", 125);
            listView1.Columns.Add("AKTİFLİK", 65);

            /* DATALAR */
            string[] defaultData1 = { "12345678910", "Doğukan Karasansar", "İstanbul / Gelişim Üniversitesi", "Aktif" };
            string[] defaultData2 = { "12346622910", "Esra Aybar", "İstanbul / Gelişim Üniversitesi", "Aktif Değil" };
            string[] defaultData3 = { "1234662210", "Damla Sekmen", "İstanbul / Gelişim Üniversitesi", "Aktif" };

            listView1.Items.Add(new ListViewItem(defaultData1));
            listView1.Items.Add(new ListViewItem(defaultData2));
            listView1.Items.Add(new ListViewItem(defaultData3));
        }
    }
}
