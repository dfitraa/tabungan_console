using System;

namespace Tabungan
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabungan tabungan = new Tabungan(0);
        Menu:
            Console.Clear();
            Console.WriteLine("Pilih fitur yang anda ingin gunakan");
            Console.WriteLine("1. Menabung");
            Console.WriteLine("2. Cek Saldo");
            Console.WriteLine("3. Ambil Uang");
            Console.WriteLine("4. Ambil Uang (Dollar)");
            Console.WriteLine("5. Keluar");
            Console.Write("Pilih: ");

            int pilihMenu = Convert.ToInt32(Console.ReadLine());
            switch (pilihMenu)
            {
                case 1:
                    Console.Write("Masukkan uang (Biaya Admin Rp.5000) : Rp ");
                    int tabung = Convert.ToInt32(Console.ReadLine());
                    bool hasil = tabungan.simpanUang(tabung);
                    if (hasil)
                    {
                        Console.WriteLine("Berhasil");
                    }
                    else
                    {
                        Console.WriteLine("Gagal, uang yang ditabung harus lebih dari Rp.5000");
                    }
                    Console.ReadLine();
                    goto Menu;

                case 2:
                    Console.Write("Saldo Anda: Rp ");
                    Console.Write(tabungan.cekSaldo());
                    Console.ReadLine();
                    goto Menu;

                case 3:
                    Console.Write("Masukkan uang yang diambil: Rp ");
                    int ambilRupiah = Convert.ToInt32(Console.ReadLine());
                    bool hasilRupiah = tabungan.ambilRupiah(ambilRupiah);
                    if (hasilRupiah)
                    {
                        Console.WriteLine("Berhasil");
                    }
                    else
                    {
                        Console.WriteLine("Gagal, uang yang diambil kurang");
                    }
                    Console.ReadLine();
                    goto Menu;

                case 4:
                    Console.Write("Masukkan uang yang ingin diambil (Dollar) : $ ");
                    int ambilDollar = Convert.ToInt32(Console.ReadLine());
                    bool hasilDollar = tabungan.ambilDollar(ambilDollar);
                    if (hasilDollar)
                    {
                        Console.WriteLine("Berhasil");
                    }
                    else
                    {
                        Console.WriteLine("Gagal, uang yang diambil kurang");
                    }
                    Console.ReadLine();
                    goto Menu;
                default:
                    break;
            }

        }
    }
}
