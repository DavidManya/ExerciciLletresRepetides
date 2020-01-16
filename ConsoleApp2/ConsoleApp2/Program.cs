using System;
using System.Collections.Generic;

public class Nom
{
    public char Lletra { get; set; }
    public string Tipus { get; set; }
}

public class Cognom
{
    public char Lletra { get; set; }
    public string Tipus { get; set; }
}

public class Complert
{
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
            char[] Nomchar = { 'D', 'A', 'V', 'I', 'D' };
            for (int i = 0; i < Nomchar.Length; i++)
            {
                Console.WriteLine(Nomchar[i]);
            }

            //Fase 2
            string missatge;

            // Crear una llista amb el nom
            List<Nom> listNom = new List<Nom>();
            listNom.Add(new Nom { Lletra = 'D', Tipus = "CONSONANT" });
            listNom.Add(new Nom { Lletra = 'A', Tipus = "VOCAL" });
            listNom.Add(new Nom { Lletra = 'V', Tipus = "CONSONANT" });
            listNom.Add(new Nom { Lletra = 'I', Tipus = "VOCAL" });
            listNom.Add(new Nom { Lletra = 'D', Tipus = "CONSONANT" });
            //listNom.Add(new Nom { Lletra = '8', Tipus = "NUMERO" });

            foreach (Nom p in listNom)
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
           
            //Omplir un Dictionary amb els valors de la llista, amb les Nom i el nombre de vegades que apareixen
            foreach (Nom p in listNom)
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
            //Fase 4
            // Crear una llista amb el cognom
            List<Cognom> listCognom = new List<Cognom>();
            listCognom.Add(new Cognom { Lletra = 'M', Tipus = "CONSONANT" });
            listCognom.Add(new Cognom { Lletra = 'A', Tipus = "VOCAL" });
            listCognom.Add(new Cognom { Lletra = 'N', Tipus = "CONSONANT" });
            listCognom.Add(new Cognom { Lletra = 'Y', Tipus = "CONSONANT" });
            listCognom.Add(new Cognom { Lletra = 'À', Tipus = "VOCAL" });

            //Afegim un caracter en blanc al nom per separar-ho del cognom un cop junts
            listNom.Add(new Nom { Lletra = ' ', Tipus = "ESPAI" });

            //Crear una llista amb el nom sencer
            List<Complert> listComplert = new List<Complert>();

            foreach (Nom p in listNom)
            {
                listComplert.Add(new Complert { Lletra = p.Lletra, Tipus = p.Tipus });
            }

            foreach (Cognom p in listCognom)
            {
                listComplert.Add(new Complert { Lletra = p.Lletra, Tipus = p.Tipus });
            }

            foreach (Complert p in listComplert)
            {
                missatge = p.Lletra.ToString();
                Console.WriteLine(missatge);
            }
        }
    }
}
