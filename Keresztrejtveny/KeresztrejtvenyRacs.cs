using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keresztrejtveny
{
    internal class KeresztrejtvenyRacs
    {
        private List<string> adatsorok;
        private char[,] racs;
        private int[,] sorszamok;

        public KeresztrejtvenyRacs(string forras)
        {

        }
        public int OszlopokDb => adatsorok[0].Length;
        public int SorokDb => adatsorok.Count;
        private void BeolvasAdatsorok(string forras)
        {

        }
    }
}
