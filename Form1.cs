using DataBarang.Models;

namespace DataBarang
{
    public partial class DataBarang : Form
    {
        private BarangContext barangContext;
        public DataBarang()
        {
            InitializeComponent();
            barangContext = new BarangContext();
            LoadData();
        }

        public void LoadData()
        {
            BarangContext barangContext = new BarangContext();
            List<Barang> listbarang = barangContext.Read();
            dataProdukView.DataSource = listbarang;
        }

        private void tmbBarang_Click(object sender, EventArgs e)
        {
            TambahBarang tambahBarang = new TambahBarang();
            Barang barang2 = tambahBarang.GetBarang();
            if (barangContext.Insert(barang2))
            {
                MessageBox.Show("Barang berhasil ditambahkan");
                LoadData();
            }
            else
            {
                MessageBox.Show("Gagal menambahkan data");
            }
        }
    }
}
