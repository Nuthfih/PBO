using Modul4_GudangOOP.Models;

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

        ItemGudang item1 = new BarangKimia("KIM001", "Asam Sulfat");
        ItemGudang item2 = new BarangMakanan("MAK001", "Indomie", DateTime.Parse("2026-02-12"));

        item1.CetakInfo();
        Console.WriteLine(item1.EvaluasiResiko());

        item2.CetakInfo();
        Console.WriteLine(item2.EvaluasiResiko());

        if (item2 is IPeriksaKadaluarsa periksa)
        {
            Console.WriteLine(periksa.ApakahKadaluarsa() ? "Kadaluarsa" : "Masih Berlaku");
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