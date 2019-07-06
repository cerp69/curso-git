using System;

namespace Secao8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string mens;
            if (DateTime.Now.Hour < 12)
            {
                mens = "Bom dia!";
            }
            else if (DateTime.Now.Hour < 18)
            {
                mens = "Boa tarde!";
            }
            else
            {
                mens = "Boa noite!";
            }
            Console.WriteLine(mens);
            Console.WriteLine("Vai putada!");
        }
    }
}
