using System;
using System.Threading;

namespace Pepe_esercizio1_Thread
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[100];
            Console.WriteLine("inserisci il numero da cercare!");
            int n = int.Parse(Console.ReadLine());
            riempiArray(array);
            Thread t = new Thread(() => ricercaArray(array, n));
            t.Start();
            Console.WriteLine("inserisci il numero da cercare!");
            int n2 = int.Parse(Console.ReadLine());
            ricercaArray(array,n2);
        }

        static void riempiArray(int[] array)
        {
            var random = new Random();

            for (int i = 0; i <= 99; i++)
                array[i] = (random.Next(0,100));

        }
        static void ricercaArray(int[] array,int n)
        {
            for (int i = 0; i <= 99; i++)
                if (array[i] == n)
                {
                    Console.WriteLine($"{n} trovato in posizione {i}!");
                }
            Console.WriteLine("Ricerca finita!");
        }
    }   
}
