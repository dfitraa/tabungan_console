using System;

namespace Tabungan
{
    class Tabungan
    {
        private int saldo;

        public Tabungan(int initial_saldo)
        {
            saldo = initial_saldo;
        }

        public int cekSaldo()
        {
            return saldo;
        }

        public bool simpanUang(int jumlah)
        {
            if(biayaAdministrasi(jumlah) < 0)
            {
                return false;
            }
            else
            {
                jumlah = biayaAdministrasi(jumlah);
                saldo += jumlah;
                return true;
            }
        }

        public int biayaAdministrasi(int jumlah)
        {
            jumlah -= 5000;
            return jumlah;
        }

        public bool ambilRupiah(int jumlah)
        {
            if ((saldo - jumlah) < 0)
            {
                return false;
            }
            else
            {
                saldo -= jumlah;
                return true;
            }
        }

        public bool ambilDollar(int jumlah)
        {
            int administrasi = jumlah * 50;
            int konversiRupiah = jumlah * 15000;
            if((saldo - (konversiRupiah+administrasi)) < 0)
            {
                return false;
            }
            else
            {
                saldo = saldo - (konversiRupiah + administrasi);
                return true;
            }
        }
    }
}
