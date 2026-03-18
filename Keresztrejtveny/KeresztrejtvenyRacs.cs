using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;

namespace Keresztrejtveny
{
    internal class KeresztrejtvenyRacs
    {
        private List<string> adatsorok;
        private char[,] racs;
        private int[,] sorszamok;

        public KeresztrejtvenyRacs(string forras)
        {
            adatsorok = new List<string>();
            BeolvasAdatsorok(forras);
            racs = new char[SorokDb, OszlopokDb];
            sorszamok = new int[SorokDb, OszlopokDb];
            FeltoltRacs();
        }
        public int OszlopokDb => adatsorok[0].Length;
        public int SorokDb => adatsorok.Count;
        private void BeolvasAdatsorok(string forras)
        {
            foreach (var sor in File.ReadAllLines(forras))
            {
                adatsorok.Add(sor);
            }
        }
        private void FeltoltRacs()
        {
            for (int i = 0; i < SorokDb; i++)
            {
                for (int j = 0; j < OszlopokDb; j++)
                {
                    racs[i, j] = adatsorok[i][j];
                }
            }
        }
        public void Megjelenites()
        {
            char[,] atalakitottRacs = new char[SorokDb, OszlopokDb * 2];
            for (int i = 0; i < SorokDb; i++)
            {
                for (int j = 0; j < OszlopokDb; j++)
                {
                    if (racs[i,j] == '#')
                    {
                        atalakitottRacs[i, j * 2] = '#';
                        atalakitottRacs[i, j * 2 + 1] = '#';
                    }
                    else
                    {
                        atalakitottRacs[i, j * 2] = '[';
                        atalakitottRacs[i, j * 2 + 1] = ']';
                    }
                }
            }
            Console.Write("\t");
            for (int i = 0; i < SorokDb; i++)
            {
                for (int j = 0; j < OszlopokDb * 2; j++)
                {
                    Console.Write(atalakitottRacs[i, j]);
                }
                Console.WriteLine();
                Console.Write("\t");
            }
        }
        public int LeghosszabbFuggolegesSzo()
        {
            int max = 0;
            int counter = 0;
            for (int i = 0; i < OszlopokDb; i++)
            {
                for (int j = 0; j < SorokDb; j++)
                {
                    if (racs[i, j] == '-')
                    {
                        counter++;
                    }
                    else
                    {
                        max = counter;
                        counter = 0;
                    }
                }
            }
            return max;
        }
    }
}
