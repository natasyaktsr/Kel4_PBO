using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kel4_PBO.Model
{
    public class Transaksi
    {
        public string id_transaksi { get; set; }
        public string nama_barang { get; set; }
        public int harga_jual { get; set; }
        public int jumlah { get; set; }
        public int total_harga { get; set; }

    }

}
