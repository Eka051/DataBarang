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
            //BarangContext barangContext = new BarangContext();
            List<Barang> listbarang = barangContext.Read();
            dataProdukView.DataSource = listbarang;
        }

        private void tmbBarang_Click(object sender, EventArgs e)
        {
            using (TambahBarang tmbBarang = new TambahBarang())
            {
                if (tmbBarang.ShowDialog() == DialogResult.OK)
                {
                    LoadData();
                }
            }
        }
    }
}
