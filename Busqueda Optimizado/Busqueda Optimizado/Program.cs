using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Busqueda_Optimizado
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] v = new int[5];//declaramos un vector de 5 posiciones
            int k = 0, i;//inicializamos 2 variables de control
            
            Console.WriteLine("Ingreses 5 numeros");
            
            for ( i = 0; i < 5; i++) //cargamos los elementos
            {
                v[i] = int.Parse(Console.ReadLine()); 
            }

         
            Console.WriteLine("que numero deseas Buscar");
            int x=int.Parse(Console.ReadLine());
            k = 0;//llevamos a k a 0
            i = 0;  //lo mismo con i

            while (k == 0 && i < 5) //hacer mientras k sea igual a cero e i menor a 5
            {
                if (v[i] == x)//preguntamos si x es igual a vector si es asu
                {
                    k = 1;//k pasa a valer uno si no
                }

                else 
                {
                    i++;// i se incrementa buscando otro
                }

            }


            if (k == 0)//k vale 0
            {
                Console.WriteLine("No se encontro");
            }
            else
            {
                Console.WriteLine(" posicion "+i+"el numero del vector es"+v[i]);// si es falso lo encontro
            }


            Console.ReadKey();
        }
    }
}
