using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBarang.Models
{
    public class BarangContext
    {
        string consStr = "Server=localhost;Port=5432;Username=postgres;Password=dianeka@05;Database=Databarang;CommandTimeout=10";

        public List<Barang> Read()
        {
            List<Barang> listbarang = new List<Barang>();
            string query = @"SELECT * FROM Barang";
            using (NpgsqlConnection conn = new NpgsqlConnection(consStr))
            {
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Barang barang = new Barang();
                            barang.Nama = (string)reader["nama_barang"];
                            barang.Harga = (double)(reader["harga_barang"]);
                            barang.jenisBarang = (string)reader["jenis_barang"];
                            listbarang.Add(barang);
                        }
                    }
                    return listbarang;
                }
            }
        }

        public bool Insert(Barang barang)
        {
            bool isSuccess = false;
            string query = "INSERT INTO Barang (nama_barang, harga_barang, jenis_barang) VALUES (@Nama, @Harga, @JenisBarang)";
            using (NpgsqlConnection conn = new NpgsqlConnection(consStr))
            {
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Nama", barang.Nama);
                    cmd.Parameters.AddWithValue("@Harga", barang.Harga);
                    cmd.Parameters.AddWithValue("@JenisBarang", barang.jenisBarang);

                    int eksekusi = cmd.ExecuteNonQuery();
                    isSuccess = eksekusi > 0;
                }
            }
            return isSuccess;
        }
    }
}
