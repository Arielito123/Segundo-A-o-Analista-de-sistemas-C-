using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Entrada_y_salida_3
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter otexto = File.AppendText("Prueba.txt");
            otexto.WriteLine("Hola Sistemas");
            otexto.WriteLine("¿Como estan?");
            otexto.Close();

            TextReader otexto1 = new StreamReader ("Prueba.txt");
            Console.WriteLine(otexto1.ReadToEnd());
            
            Console.ReadKey();


        }
    }
}
