using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity1_Algoritma_MuhammadFahrizal
{
    class Program
    {
        // Deklarasi array int dengan ukuran 20
        private int[] a = new int[20];

        //Deklarasi variable int untuk menyimpan banyaknya data pada array
        private int n;

        // Fungsi / method untuk menerima masukan
        public void read()
        {
            //Menerima angka untuk menentukan banyaknya data yang disimpan padqa array
            while (true)
            {
                Console.Write("Masukan banyaknya elemen pada array: ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 20)
                    break;
                else
                    Console.WriteLine("\nArray dapat mempunyai maksimal 20 elemen.\n");
            }
            Console.WriteLine("");
            Console.WriteLine("-----------------------");
            Console.WriteLine(" Masukkan elemen array ");
            Console.WriteLine("-----------------------");

            //Pengguna memasukan elemen pada array
            for (int i = 0; i < n; i++)
            {
                Console.Write("<" + (1 + 1) + ">");
                string s1 = Console.ReadLine();
                a[i] = Int32.Parse(s1);
            }
        }

        public void display()
        {
            // Menampilkan array yang tersusun 
            Console.WriteLine("");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine(" Element array yang telah tersusun ");
            Console.WriteLine("-------------------------------------");
            for (int j = 0; j < n; j++)
            {
                Console.WriteLine(a[j]);
            }
            Console.WriteLine("");
        }
        public void BubbleSortArray()
        {
            for (int i = 1; i < n; i++) // for n-1 passes
            {
                // pada pass i, bandingkan n-1 elemen pertama dengan elemen selanjutnya 
                for (int j = 0; j < n - 1; j++)
                {
                    if (a[j] > a[j + 1]) // jika elemen tidak dalam urutan yang benar
                    {
                        //tuar elemen 
                        int temp;
                        temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                    }
                }
            }
        }


        
          static void Main(string[] args)
          {
                // Creating the object of the BubbleSort class
                Program myList = new Program();

                // Pemanggilan fungsi untuk menerima elemen array
                myList.read();

                // Pemanggilan fungsi untuk mengurutkan array 
                myList.BubbleSortArray();

                //pemanggilan fungsi untuk menampilkan array yang tersusun
                myList.display();

                //exit
                Console.WriteLine("\nTekan Tombol Apa Saja Untuk Keluar");
                Console.Read();
          }
       
    }
}
