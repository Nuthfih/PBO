using Modul3_GudangOOP.Models;

class Program
{
    static void Main()
    {
        Barang[] daftarBarang = new Barang[]
        {
            new Barang("B001", "Kotak Kayu", 80, "Kemasan"),
            new BarangElektronik("E001", "Laptop", 10, "Elektronik", 75)
        };
        foreach (var barang in daftarBarang)
        {
            barang.TampilkanInfo();
        }
        //Barang b3 = new Barang();

        //Console.Write("Masukan Nama Barang: ");
        //b3.NamaBarang = Console.ReadLine();

        //Console.Write("Masukan Kode Barang: ");
        //b3.KodeBarang = Console.ReadLine();

        //Console.Write("Masukan Jumlah Stok: ");
        //b3.JumlahStok = int.Parse(Console.ReadLine());

        //Console.Write("Masukan Kategori: ");
        //b3.Kategori = Console.ReadLine();

        //b3.TampilkanInfo();
    }
}