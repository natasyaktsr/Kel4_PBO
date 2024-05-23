using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Transactions;

namespace Kel4_PBO.Model
{
    public class RepositoryTransaksi
    {
        private string connectionString = "Server=localhost;Port=5432;Database=kinkapp;User Id=postgres;password=lmj#191104";

        public List<Transaksi> GetAll()
        {
            var transaksi = new List<Transaksi>();
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                var command = new NpgsqlCommand("SELECT t.id_transaksi, b.nama_barang, b.harga_jual, dt.jumlah, dt.total_harga\nFROM detail_transaksi dt\nJOIN barang b on (b.id_barang = dt.id_barang)\nJOIN transaksi t on (t.id_transaksi = dt.id_transaksi)\n", connection);
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    transaksi.Add(new Transaksi
                    {
                        id_transaksi= (string)reader["id_transaksi"],
                        nama_barang = (string)reader["nama_barang"],
                        harga_jual = (int)reader["harga_jual"],
                        jumlah = (int)reader["jumlah"],
                        total_harga = (int)reader["total_harga"]
                    });
                }
            }
            return transaksi;
        }

       public void Add(Transaksi transaksi)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                var command = new NpgsqlCommand(
                    "INSERT INTO Transaksi (id_transaksi, nama_barang, harga_jual, jumlah, total_harga) VALUES (@IdTransaksi, @NamaBarang, @HargaJual, @Jumlah, @TotalHarga)",
                    connection);
                command.Parameters.AddWithValue("@IdTransaksi", transaksi.id_transaksi);
                command.Parameters.AddWithValue("@NamaBarang", transaksi.nama_barang);
                command.Parameters.AddWithValue("@HargaJual", transaksi.harga_jual);
                command.Parameters.AddWithValue("@Jumlah", transaksi.jumlah);
                command.Parameters.AddWithValue("@TotalHarga", transaksi.total_harga);
                command.ExecuteNonQuery();
            }
        }

        public void Update(Transaksi transaksi)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                var command = new NpgsqlCommand(
                    "UPDATE Transaksi SET id_karyawan = @IdKaryawan,  = @Date, Description = @Description WHERE Id = @Id",
                    connection);
                command.Parameters.AddWithValue("@Id", transaction.Id);
                command.Parameters.AddWithValue("@Amount", transaction.Amount);
                command.Parameters.AddWithValue("@Date", transaction.Date);
                command.Parameters.AddWithValue("@Description", transaction.Description);
                command.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                var command = new NpgsqlCommand("DELETE FROM Transactions WHERE Id = @Id", connection);
                command.Parameters.AddWithValue("@Id", id);
                command.ExecuteNonQuery();
            }
        }
    } 
}
