using System;

internal class Program
{
    private static void Main(string[] args)
    {

        {
            int kenar1, kenar2,cevre,alan;

            Console.WriteLine("kenar1");
            kenar1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("kenar2");
            kenar2 = Convert.ToInt32(Console.ReadLine());

           
            cevre = 2 * (kenar1 + kenar2);
            Console.WriteLine("cevre");

            Console.WriteLine(cevre);
            
            alan = kenar1 * cevre;
            Console.WriteLine("alan");
            Console.WriteLine(alan);
            
            
            
            
        }
    }

}