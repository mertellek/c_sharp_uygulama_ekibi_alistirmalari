using System;

namespace hafta_1_alistirma_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Girilen sayının tek mi çift mi olduğunu bulan program.
            Console.Write("Sayı giriniz: ");
            int sayi = int.Parse(Console.ReadLine());
            
            if (sayi%2==0) Console.WriteLine(sayi + " sayısı çifttir.");
            else Console.WriteLine(sayi + " sayısı tektir.");
            Console.ReadKey();
        }
    }
}
