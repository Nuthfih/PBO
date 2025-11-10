namespace Modul5_GudangOOP.Models;

public class Barang
{
    public string KodeBarang;
    public string NamaBarang;
    private int jumlahStok;
    public int JumlahStok
    {
        get => jumlahStok;
        set
        {
            if (value >= 0) jumlahStok = value;
        }
    }
    public string Kategori { get; set; }

    public string Status => JumlahStok > 50 ? "Stok Aman" : "Perlu Reorder";

    public Barang(string kode, string nama, int stok, string kategori)
    {
        KodeBarang = kode;
        NamaBarang = nama;
        JumlahStok = stok;
        Kategori = kategori;
    }

    public Barang()
    {
        KodeBarang = "NULL";
        NamaBarang = "Barang Baru";
        JumlahStok = 0;
        Kategori = "Umum";
    }

    public string StatusStok()
    {
        return JumlahStok > 50 ? "Stok Aman" : "Perlu Reorder";
    }

    public virtual void TampilkanInfo()
    {
        Console.WriteLine($"[{KodeBarang}] {NamaBarang} - Stok: {JumlahStok}, Kategori: {Kategori}");
    }
}