using System;

namespace hafta_1_alistirma_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dikdörtgenin alanını ve çevresini hesaplayarak ekranda gösteren program
            Console.Write("Kısa Kenar : ");
            int k_kenar = int.Parse(Console.ReadLine());
            Console.Write("Uzun Kenar : ");
            int u_kenar = int.Parse(Console.ReadLine());
            Console.WriteLine("Alan : " + (u_kenar * k_kenar));
            Console.WriteLine("Çevre : " + (u_kenar + k_kenar) * 2);
            Console.ReadKey();
        }
    }
}
