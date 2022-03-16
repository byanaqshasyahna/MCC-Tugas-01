using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCC_tugas1
{
    class sistemKasir
    {
        static void Main(string[] args)
        {

            int pilihan1;
            int pilihanMakan;
            int pilihanMinum;
            List<String> pesanan = new List<String>();


            Console.WriteLine("Welcome to My Shop");
            Console.WriteLine("Mau Pesan Apa? ");
            Console.WriteLine("1. Makanan\n" +
                "2. Minuman\n" +
                "3. Makanan dan Minuman\n");

            Console.Write("Pilih :");
            pilihan1 = Convert.ToInt32(Console.ReadLine());


            if (pilihan1 == 1)
            {
                menuMakanan();
                pilihanMakan = Convert.ToInt32(Console.ReadLine());
                pesanan.Add(reserve(pilihanMakan, 0));
            }
            else if (pilihan1 == 2)
            {
                menuMinuman();   
                pilihanMinum = Convert.ToInt32(Console.ReadLine());
                pesanan.Add(reserve(0, pilihanMinum));
            }
            else if (pilihan1 == 3) {

                menuMakanan();
                pilihanMakan = Convert.ToInt32(Console.ReadLine());
                pesanan.Add(reserve(pilihanMakan, 0));


                menuMinuman();
                pilihanMinum = Convert.ToInt32(Console.ReadLine());
                pesanan.Add(reserve(0, pilihanMinum));
            }

            Console.WriteLine(" ");
            Console.WriteLine("PESANAN ANDA");
            pesanan.ForEach(p => Console.WriteLine(p)) ;

            Console.Write("Total Harga : ");
            Console.WriteLine(harga(pesanan));
            
        }


        static String reserve(int makanan, int minuman) {
            String finalPesan = "Tidak ada Pesanan";

            switch (makanan)
            {
                case 1:
                    finalPesan = "Nasi Goreng";
                    break;
                case 2:
                    finalPesan = "Mie Goreng";
                    break;
            }

            switch (minuman)
            {
                case 1:
                    finalPesan = "Es Teh";
                    break;
                case 2:
                    finalPesan = "Air Putih";
                    break;
            }

            return finalPesan;
        }

        static void menuMakanan() {
            Console.WriteLine("Pilih Makanan");
            Console.WriteLine("1. Nasi Goreng\n" +
                "2. Mie Goreng");
            Console.Write("Pilih nomor: ");

        }

        static void menuMinuman()
        {
            Console.WriteLine("Pilih Minuman");
            Console.WriteLine("1. Es Teh\n" +
                "2. Air Putih");
            Console.Write("Pilih nomor: ");
        }

        static int harga(List<String> menu) {

            int totalHarga = 0;


            for (int i = 0; i < menu.Count; i++)
            {
                switch (menu[i])
                {
                    case "Nasi Goreng":
                        totalHarga += 15000;
                        break;

                    case "Mie Goreng":
                        totalHarga += 13000;
                        break;

                    case "Es Teh":
                        totalHarga += 3000;
                        break;

                    case "Air Putih":
                        totalHarga += 3000;
                        break;

                    default:
                        break;
                }
            }
            return totalHarga;
                }

    }
}
