using System;

namespace Juego01b
{
    class Program
    {
        static void Main(string[] args)
        {
            int miliseg = DateTime.Now.Millisecond;
            int dado = miliseg % 100 + 1;
            Console.WriteLine("El numero del dado es: "+dado);

        }
    }
}
