using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fase 1
            char[] lletresnom = { 'D', 'A', 'V', 'I', 'D', 'M', 'A', 'Ñ', 'Á', 'Á', 'L', 'V', 'A', 'R', 'E', 'Z' };
            for (int i = 0; i < lletresnom.Length; i++)
            {
                Console.WriteLine(lletresnom[i]);
            }
        }
    }
}
