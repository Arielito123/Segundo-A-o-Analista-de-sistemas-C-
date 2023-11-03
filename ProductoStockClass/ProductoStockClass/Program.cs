using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductoStockClass
{
    class Program
    {
        static void Main(string[] args)
        {
            #region objetos/variables
            const int longitud=3;
            int [] codigo=new int[longitud];
            int[] cantidad = new int[longitud];
            int[] generar = new int[longitud];
            #endregion

            #region cargaInformacion
            for (int i = 0; i < codigo.Length; i++) 
            {
                Console.WriteLine("Ingrese el codigo de barra del producto");
                codigo[i]  = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ingrese la cantidad de  producto");
                cantidad[i] = Convert.ToInt32(Console.ReadLine());

            }
            #endregion
            
            #region instanciar clase
            producto Oproducto = new producto();
            Oproducto.Codigobarra = codigo;
            Oproducto.Cantidad_disponible = cantidad;
            #endregion
           
            #region parteBusqueda
            Console.WriteLine("Ingrese un producto a buscar");
            int buscar = Convert.ToInt32(Console.ReadLine());
            int pos = 0;
            while (buscar != 0) 
            {
                 pos = Oproducto.buscar(buscar);
                
                if (pos == -1)
                {
                    Console.WriteLine("No ha sido encontrado");
                    
                }
                else
                {
                    Console.WriteLine("Ingrese la cantidad que deseas comprar" + " " + Oproducto.Cantidad_disponible[pos]);
                    int cantidadCompra = Convert.ToInt32(Console.ReadLine());


                    if (cantidadCompra > Oproducto.Cantidad_disponible[pos])
                    {
                        Console.WriteLine("No se puede hacer esa comprar supera el limite");
                    }
                    else 
                    {
                        Oproducto.Cantidad_disponible[pos] = Oproducto.Cantidad_disponible[pos] - cantidadCompra;
                    }
                }

                 Console.WriteLine("Ingrese otro producto a buscar");
                 buscar = Convert.ToInt32(Console.ReadLine());
            }
            #endregion

            #region ParteGenerar
            int  gen = Oproducto.generar(generar);
           Console.WriteLine("-------------------------------------------------------------------------");
           Console.WriteLine("Elementos con menos de 10 unidades");
            
            for (int i = 0; i < gen; i++) 

            {
                Console.WriteLine(" Codigo Barra: "+generar[i] + " " + "stock:"+ Oproducto.Cantidad_disponible[i]);
            }
            Console.WriteLine("cantidad de elementos generados con menos de 10 unidades"+gen);
            #endregion

            #region ParteOrdenar
            Oproducto.ordernar();
            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine("Elemento ordenados por codigo de barra arrastrando el stock");

            for (int i = 0; i < Oproducto.Codigobarra.Length; i++) 
            {
                Console.WriteLine(Oproducto.Codigobarra[i] + " " + Oproducto.Cantidad_disponible[i]);
            }
            #endregion
            
            Console.ReadKey();
            
        }
    }
}
