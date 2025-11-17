using Modul7_GudangOOP.Models;
using Modul7_GudangOOP.Interfaces;

namespace Modul7_GudangOOP.Services
{
    public class PencetakBarang : IBarangPrinter
    {
        public void Cetak(Barang barang)
        {
            Console.WriteLine("==== INFORMASI BARANG ====");
            Console.WriteLine($"Kode     : {barang.KodeBarang}");
            Console.WriteLine($"Nama     : {barang.NamaBarang}");
            Console.WriteLine($"Stok     : {barang.JumlahStok}");
            Console.WriteLine($"Kategori : {barang.Kategori}");
            Console.WriteLine("==========================");
        }
    }
}
