using Modul7_GudangOOP.Models;
using Modul7_GudangOOP.Services;
using Modul7_GudangOOP.Interfaces;

class Program
{
    static void Main()
    {
        Barang a = new Barang("BRG001", "Pensil", 50, "Alat Tulis");
        var inputService = new InputBarang();
        Barang b = inputService.AmbilInput();

        IBarangPrinter printer = new PencetakBarang();
        printer.Cetak(b);

        List<Barang> simpanBarang = new List<Barang>
        {
           a, b
        };

        string path = Path.Combine(Directory.GetCurrentDirectory(), "data_barang.txt");

        File.WriteAllText(path, "Kode\tNama\tStok\n");

        foreach (var barang in simpanBarang)
        {
            File.AppendAllText("data_barang.txt",
        $"{barang.KodeBarang}\t{barang.NamaBarang}\t{barang.JumlahStok}\n");
        }

        Console.WriteLine($"File disimpan di: {path}");

        if (File.Exists("data_barang.txt"))
        {
            var isi = File.ReadAllLines("data_barang.txt");
            foreach (var baris in isi)
            {
                Console.WriteLine(baris);
            }
        }

    }
}