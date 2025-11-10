namespace Modul1_GudangOOP.Models;

public class Barang
{
    public string KodeBarang;
    public string NamaBarang;
    public int JumlahStok;
    public string Kategori;

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

    public void TampilkanInfo()
    {
        Console.WriteLine($"[{KodeBarang}] {NamaBarang} - Stok: {JumlahStok}, Kategori: {Kategori}");
    }
}