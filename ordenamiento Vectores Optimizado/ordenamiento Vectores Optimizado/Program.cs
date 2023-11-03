using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ordenamiento_Vectores_Optimizado
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] v = new int[5];
            int aux = 0;

            Console.WriteLine("Ingrese 5 numeros");
            for (int i = 0; i < 5; i++) 
            {
               
                v[i] = int.Parse(Console.ReadLine());
            }
            int k = 0;
            int x = 5;

            while (k == 0) 
            {
                k = 1;
                x--;

                for(int i=0;i<x;i++)
                {
                 if(v[i]>v[i+1])
                 {
                     k = 0;
                     aux = v[i];
                     v[i] = v[i + 1];
                     v[i + 1] = aux;
                 }
                }
            }

            for (int i = 0; i < 5; i++) 
            {
                Console.WriteLine(v[i]+"Pos"+i);
            }
            Console.ReadKey();
          
        }
    }
}
