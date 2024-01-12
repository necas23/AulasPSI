using System;

namespace Descompressor
{
    class Program
    {
        static void Main(string[] args)
        {
            int resposta = 0;
            string line;
            string ficheiro = "ficheiro.txt";
            Console.WriteLine("Para comprimir o ficheiro insira 1, para descomprimir o ficheiro insira 2");
            
            resposta = Convert.ToInt32(Console.ReadLine());

            if(resposta == 1){
              Console.WriteLine("Escolheu comprimir o ficheiro!");
              Comprimir(ficheiro);
            }
        }
      
        private static void Comprimir(string ficheiro)
        {
            string line;

            FileStream fs = new FileStream(ficheiro, FileMode.Create,           
            FileAccess.Write);

            GZipStream gzs = new GZipStream(fs, CompressionLevel.Optimal);

            StreamWriter sw = new StreamWriter(gzs);

            while ((line = Console.ReadLine()).Length > 0)
            {
                sw.WriteLine(line);
            }

            sw.Close();

        }
        
          private static void Descomprimir(string ficheiro)
          {
                
          }
    }
}
