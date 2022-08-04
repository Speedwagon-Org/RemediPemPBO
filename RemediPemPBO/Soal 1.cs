using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RemediPemPBO
{
    public partial class Soal_1 : Form
    {
        List<Ajar> listBukuAjar = new List<Ajar>();
        List<Komik> listBukuKomik = new List<Komik>();
        List<string> bookTypeList = new List<string>();
        public Soal_1()
        {
            
            InitializeComponent();
            bukuAjar.Checked = true;
            containerKomik.Enabled = false;
            containerAjar.Enabled = true;
            bidangComboBox.SelectedIndex = 0;
        }

        private void bukuAjar_CheckedChanged(object sender, EventArgs e)
        {
            containerKomik.Enabled = false;
            containerAjar.Enabled = true;
        }

        private void komik_CheckedChanged(object sender, EventArgs e)
        {
            containerAjar.Enabled = false;
            containerKomik.Enabled =true;
        }

        private void tambahBuku_Click(object sender, EventArgs e)
        {
            if (!listBox1.Items.Contains(kodeBuku.Text))
            {
                listBox1.Items.Add(kodeBuku.Text);
                if (bukuAjar.Checked)
                {
                    listBukuAjar.Add(
                        new Ajar(
                            judulBuku.Text,
                            kodeBuku.Text,
                            bidangComboBox.Text,
                            Int32.Parse(edisiNum.Value.ToString())
                            )
                        );
                    bookTypeList.Add("Ajar");
                }
                else if (komik.Checked)
                {
                    listBukuKomik.Add(
                        new Komik(
                            judulBuku.Text,
                            kodeBuku.Text,
                            dalamNegeri.Checked ? dalamNegeri.Text : luarNegeri.Text
                            )
                        );
                    bookTypeList.Add("Komik");
                }
            } else
            {
                MessageBox.Show("Harap untuk  mengisi kode unik!");
            }
            
        }

        private void detail_Click(object sender, EventArgs e)
        {
            foreach(Ajar buku in listBukuAjar)
            {
                if (buku.Kode == listBox1.Text)
                {
                    MessageBox.Show( buku.infoBuku(), "Info Buku Ajar");
                    break;
                }
            }
            foreach (Komik buku in listBukuKomik)
            {
                if (buku.Kode == listBox1.Text)
                {
                    MessageBox.Show(buku.infoBuku(), "Info Buku Komik");
                    break;
                }
            }

        }
    }
}
