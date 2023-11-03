using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EntradaYsalida1
{
    class Program
    {
        static void Main(string[] args)
        {
            TextWriter otexto = new StreamWriter("prueba.txt");//sobre escribe o crea;
           
            otexto.WriteLine("Programador developer");
            otexto.WriteLine("ariel");
            otexto.Close();//cierra el archivo

            Console.ReadKey();

            
        }
    }
}
