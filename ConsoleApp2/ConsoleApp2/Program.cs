using System;
using System.Collections.Generic;

public class Lletres
{
    public int Id { get; set; }
    public char Lletra { get; set; }
    public string Tipus { get; set; }
}

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fase 1
            char[] lletresnom = { 'D', 'A', 'V', 'I', 'D', 'M', 'A', 'Ñ', 'A', 'A', 'L', 'V', 'A', 'R', 'E', 'Z' };
            for (int i = 0; i < lletresnom.Length; i++)
            {
                Console.WriteLine(lletresnom[i]);
            }

            //Fase 2
            string missatge;

            // Crear una llista
            List<Lletres> listLletres = new List<Lletres>();
            listLletres.Add(new Lletres { Id = 1, Lletra = 'D', Tipus = "CONSONANT" });
            listLletres.Add(new Lletres { Id = 2, Lletra = 'A', Tipus = "VOCAL" });
            listLletres.Add(new Lletres { Id = 3, Lletra = 'V', Tipus = "CONSONANT" });
            listLletres.Add(new Lletres { Id = 4, Lletra = 'I', Tipus = "VOCAL" });
            listLletres.Add(new Lletres { Id = 5, Lletra = 'D', Tipus = "CONSONANT" });
            listLletres.Add(new Lletres { Id = 6, Lletra = 'M', Tipus = "CONSONANT" });
            listLletres.Add(new Lletres { Id = 7, Lletra = 'A', Tipus = "VOCAL" });
            listLletres.Add(new Lletres { Id = 8, Lletra = 'Ñ', Tipus = "CONSONANT" });
            listLletres.Add(new Lletres { Id = 9, Lletra = 'A', Tipus = "VOCAL" });
            listLletres.Add(new Lletres { Id = 10, Lletra = 'A', Tipus = "VOCAL" });
            listLletres.Add(new Lletres { Id = 11, Lletra = 'L', Tipus = "CONSONANT" });
            listLletres.Add(new Lletres { Id = 12, Lletra = 'V', Tipus = "CONSONANT" });
            listLletres.Add(new Lletres { Id = 13, Lletra = 'A', Tipus = "VOCAL" });
            listLletres.Add(new Lletres { Id = 14, Lletra = 'R', Tipus = "CONSONANT" });
            listLletres.Add(new Lletres { Id = 15, Lletra = 'E', Tipus = "VOCAL" });
            listLletres.Add(new Lletres { Id = 16, Lletra = 'Z', Tipus = "CONSONANT" });
            listLletres.Add(new Lletres { Id = 17, Lletra = '8', Tipus = "NUMERO" });

            foreach (Lletres p in listLletres)
            {
                if (p.Tipus == "NUMERO")
                {
                    missatge = "Els noms de persones no contenen números!";
                }
                else
                {
                    missatge = p.Tipus;
                }
                Console.WriteLine(missatge);
            }
        }
    }
}
