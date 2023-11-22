using System;

namespace Uppgift_5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] siffror = new int[3];
            Console.WriteLine("Skriv in ett heltal");
            siffror[0] = 5;
            siffror[1] = 3;
            siffror[2] = int.Parse(Console.ReadLine());
            Console.Write(siffror[0]);
            Console.Write(siffror[1]);
            Console.Write(siffror[2]);
        }

    }

}