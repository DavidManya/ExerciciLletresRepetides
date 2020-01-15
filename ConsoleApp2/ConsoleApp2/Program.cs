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
            char[] lletresnom = { 'D', 'A', 'V', 'I', 'D' };
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
            listLletres.Add(new Lletres { Id = 6, Lletra = '8', Tipus = "NUMERO" });

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

            //Fase 3
            IDictionary<string, int> dict = new Dictionary<string, int>(StringComparer.InvariantCultureIgnoreCase);
           
            //Omplir el Dictionary amb els valors de la llista, amb les lletres i el nombre de vegades que apareixen
            foreach (Lletres p in listLletres)
            {
                if (p.Tipus != "NUMERO")
                {
                    if (dict.ContainsKey(p.Lletra.ToString()))
                    {
                        dict[p.Lletra.ToString()] ++;
                    }
                    else
                    {
                        dict.Add(p.Lletra.ToString(), 1);
                    }
                }
            }
            foreach (KeyValuePair<string, int> entrada in dict)
            {
                Console.WriteLine($"La lletra {entrada.Key} apareix {entrada.Value} vegades");
            }
        }
    }
}
