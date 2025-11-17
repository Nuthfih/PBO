namespace Modul7_GudangOOP.Helpers
{
    public static class InputHelper
    {
        public static int AmbilStokValid()
        {
            while (true)
            {
                Console.Write("Jumlah Stok: ");
                string input = Console.ReadLine();
                if(int.TryParse(input, out int stok))
                {
                    if (stok >= 0)
                        return stok;
                    else
                        Console.WriteLine("Stok Tidak Boleh Negatif.");
                }
                else
                {
                    Console.WriteLine("Input harus berupa angka!");
                }
            }
        }
    }
}
