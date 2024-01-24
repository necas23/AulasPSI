using System;
using System.IO;

namespace EscreverBin
{
    class Program
    {
        static void Main(string[] args)
        {
            string v = "2";
            int dint = 5;
            double mreal = 2.5;

            string resposta = Console.ReadLine();
            string ficheiro = "ficheiro3.bin";
            BinaryWriter texto3 = new BinaryWriter(File.Open(resposta, FileMode.Create));

            texto3.Write(v);
            texto3.Write(dint);
            texto3.Write(mreal);
            texto3.Close();
        }
    }
}
