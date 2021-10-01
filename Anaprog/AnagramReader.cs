using System;
using System.Collections.Generic;
using System.IO;
using System. Diagnostics;
using System.Linq;
using System.Text;

namespace Anaprog
{
    public class AnagramReader
    {
        private static int SorterHash(string str)
        {
            char[] foo = str.ToArray();
            Array.Sort(foo);
            return new string(foo).GetHashCode();
        }

        private static void Main(string[] args)
        {
            // palabra a buscar.
            string newWord;

            // Cronometro.
            //var s1 = Stopwatch.StartNew();
            Stopwatch cronometro = new Stopwatch();
            cronometro.Start();

            // Lee el archivo txt a leer en la PC.
            //StreamReader sr = new StreamReader (@"C:\jordi\desktop\Anagram\wordlist.txt");
            StreamReader Lista = File.OpenText("wordlist.txt");

            // Lee palabras en el File.
            string[] Listado = Lista.ReadToEnd().Split("\r\n".ToCharArray());

            // Cuenta el numero de palabras.
            int[] hashes = new int[Listado.Count()];

            for (int i = 0; i <= Listado.GetUpperBound(0); i++)
            {
                hashes[i] = SorterHash(Listado[i]);
            }

            cronometro.Stop();

            Console.WriteLine("Se encontraron {0} palabras se cargaron en {1} ms",
            Listado.Count(), cronometro.Elapsed.TotalMilliseconds);

            newWord = Console.ReadLine();

            do
            {
                if (newWord != null)
                {
                    cronometro.Reset();
                    cronometro.Start();
                    newWord = newWord.ToLower();
                    StringBuilder anagrama = new StringBuilder();
                    int w1hash = SorterHash(newWord);

                    Console.WriteLine("Anagramas de la palabra {0} :", newWord);

                    for (int x = 0; x <= hashes.GetUpperBound(0); x++)
                    {
                        if (hashes[x] == w1hash && Listado[x] != newWord)
                        {
                            anagrama.AppendLine(Listado[x]);
                        }
                    }

                    cronometro.Stop();

                    Console.Write("- {0}", anagrama.ToString());

                    Console.WriteLine("Tiempo en que se encontraron: {0} ms",
                    cronometro.Elapsed.TotalMilliseconds);
                }
            }
            while (newWord != null);
        }
    }
}
