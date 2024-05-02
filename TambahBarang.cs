using DataBarang.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBarang
{
    public partial class TambahBarang : Form
    {
        public TambahBarang()
        {
            InitializeComponent();
        }

        public Barang GetBarang()
        {
            Barang barang = new Barang();
            barang.Nama = NamaBarang.Text;
            barang.Harga = Convert.ToDouble(HargaBarang.Text);
            barang.jenisBarang = JenisBarang.Text;
            return barang;
        }

        private void simpanBarang_Click(object sender, EventArgs e)
        {
            Barang barang = GetBarang();
            BarangContext barangContext = new BarangContext();
            if (barangContext.Insert(barang))
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Gagal menyimpan data");
            }
        }
    }
}
