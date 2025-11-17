namespace Modul7_GudangOOP.Services;

using Modul7_GudangOOP.Models;
using Modul7_GudangOOP.Helpers;
using System;

public class InputBarang
{
    public Barang AmbilInput()
    {
        Console.Write("Kode: ");
        string kode = Console.ReadLine();
        Console.Write("Nama: ");
        string nama = Console.ReadLine();

        int stok = InputHelper.AmbilStokValid();

        Console.Write("Kategori: ");
        string kategori = Console.ReadLine();

        return new Barang(kode, nama, stok, kategori);
    }
}
