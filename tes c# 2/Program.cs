// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;
using System.Runtime.InteropServices;

public class Program
{
    public static void Main(string[] args){
        Console.WriteLine("Nama Barang :");
        string namaBarang = Console.ReadLine();

        Console.WriteLine("Harga Barang");
        int hargaBarang = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Kuantitas Barang");
        int kuantitiBarang = Convert.ToInt32(Console.ReadLine());

        int totalHarga = hargaBarang * kuantitiBarang;

         Console.WriteLine("RRTOTO");
         Console.WriteLine("===========");

         Console.WriteLine("Nama Barang      : " + namaBarang);
         Console.WriteLine("Harga Barang     : " + hargaBarang);
         Console.WriteLine("Kuantitas Barang : " + kuantitiBarang);
         Console.WriteLine("Total            : " + totalHarga);
         Console.WriteLine("===========");


        if( totalHarga >= 100000){
            int discount = totalHarga * 2 / 100;
            int potongHarga = totalHarga - discount;
            Console.WriteLine("Selamat anda mendapat potongan harga menjadi :" + potongHarga);
        } else{
            Console.WriteLine("Terimakasih sudah berbelanja disini");
        }

    }
}
