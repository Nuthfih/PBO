using Modul5_GudangOOP.Models;
using System.Security.Cryptography.X509Certificates;

class Program
{
    public static T CariData<T>(List<T> list, Func<T, bool> predicate)
    {
        return list.Find(new Predicate<T>(predicate));
    }
    static void Main()
    {
        Barang[] daftarBarang = new Barang[]
        {
            new Barang("BRG001", "Kotak Kayu", 80, "Kemasan"),
            new BarangElektronik("ELK001", "Laptop", 10, "Elektronik", 75)
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

        List<Barang> listBarang = new List<Barang>();
        listBarang.Add(new Barang("BRG002", "Karton", 100, "Kemasan"));
        listBarang.Add(new Barang("BRG003", "Peti", 50, "Penyimpanan"));

        foreach (var barang in listBarang)
        {
            barang.TampilkanInfo();
        }

        var hasil = listBarang.Find(b => b.KodeBarang == "BRG003");
        if (hasil != null) hasil.TampilkanInfo();

        Dictionary<string, Barang> indeksBarang = new Dictionary<string, Barang>();
        indeksBarang["BRG004"] = new Barang("BRG004", "Bubble Wrap", 200, "Kemasan");

        if (indeksBarang.ContainsKey("BRG004"))
            indeksBarang["BRG004"].TampilkanInfo();

        Barang hasilList = CariData(listBarang, b => b.Kategori == "Penyimpanan");

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