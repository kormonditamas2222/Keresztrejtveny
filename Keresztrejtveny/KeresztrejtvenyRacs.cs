using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Keresztrejtveny
{
    internal class KeresztrejtvenyRacs
    {
        private List<string> adatsorok;
        private char[,] racs;
        private int[,] sorszamok;

        public KeresztrejtvenyRacs(string forras)
        {
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
                for (int j = 0; i < OszlopokDb; j++)
                {
                    racs[i, j] = adatsorok[i][j];
                }
            }
        }
    }
}
