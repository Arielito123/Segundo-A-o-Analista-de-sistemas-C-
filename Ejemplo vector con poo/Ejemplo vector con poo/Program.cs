using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductoStock1._0
{
    class Program
    {
        static void Main(string[] args)
        {
            const int longitud = 3;
            int[] Codigo_Barra = new int[longitud];
            int[] Cantidad_Disponible = new int[longitud];
            int[] VectorGenerado = new int[longitud];

            for (int i = 0; i < Codigo_Barra.Length; i++) //cargamos nuestros dos elementos con un ciclo for
            {
                Console.WriteLine("Ingrese codigo de barra de un producto " + i);
                Codigo_Barra[i] = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ingrese la cantidad de stock a ese Codigo de barra" + " " + Codigo_Barra[i]);
                Cantidad_Disponible[i] = Convert.ToInt32(Console.ReadLine());
            }

            int buscarCodigoBarra;//generamos una variable para buscar un codigo de barra

            Console.WriteLine("(Las ventas del dia terminaran si en la busqueda de codigo colocas 0)");

            Console.WriteLine(" ");

            Console.WriteLine("Ingrese el codigo de barra que desees Encontrar");
            buscarCodigoBarra = Convert.ToInt32(Console.ReadLine());

            int pos = 0, cantidad_Vendido;//genero fos variable una tendra mi metodo y la otra la cantida vendida


            while (buscarCodigoBarra != 0) //Mientras mi variable sea distinto de cero seguira haciendo lo siguiente
            {
                //cargamos nuestro metodo y se lo damos a la variable que generamos
                pos = Buscar_CBarra(Codigo_Barra, buscarCodigoBarra);

                if (pos == -1)//preguntamos si pos vale -1 entonces no habra encontrado nada
                {
                    Console.WriteLine("El codigo de barra ingresado anteriormente no existe");
                }
                else // si es falso entonces lo habra encontrado
                {
                    Console.WriteLine("La cantidad de productos en ese codigo de barra es de:" + Cantidad_Disponible[pos]);
                    cantidad_Vendido = Convert.ToInt32(Console.ReadLine());

                    if (cantidad_Vendido > Cantidad_Disponible[pos])//si la cantidad de vendido es mayor a la del stock 
                    {
                        Console.WriteLine("NO hay stock disponible para seguir vendiendo");
                        /*cantidad_Vendido = Cantidad_Disponible[pos];//generamos variable para asignarle el mismo valor
                        //asi no se resta el stock aunque ya no haya*/
                    }

                    else  //si lo de arriba no se cumple
                    {
                        Cantidad_Disponible[pos] = Cantidad_Disponible[pos] - cantidad_Vendido;//sigue habiendo stock se restara y 
                        //cantidad tendra el valor de la resta de ambos
                    }







                }

                Console.WriteLine("Ingrese el codigo de barra que desees Encontrar");
                buscarCodigoBarra = Convert.ToInt32(Console.ReadLine());


            }
            Console.Clear();


            int GeneradorVector = Generar(Codigo_Barra, Cantidad_Disponible, VectorGenerado);//creamos una variable para guardar nuestro metodo

            Console.WriteLine("Los codigos de barra con menos de 10 unidades son:");

            for (int i = 0; i < GeneradorVector; i++)//recorremos el for con nuesta variable generada por el metodo
            {
                Console.WriteLine(Codigo_Barra[i]);//mostramos los codigos con menos de 10 unidades
            }

            //mencionamos cuantos codigos de barra con menos de 10 undiades existeb
            Console.WriteLine(" los codigos de barra con menos de 10 unidades fueron de: " + GeneradorVector + " elementos ");


            Ordenar(Codigo_Barra, Cantidad_Disponible);//llamamos a nuestro metodo ordenar y le pasamos parametros

            Console.WriteLine("Codigo de barras ordenados de menor a mayor junto a sus stock disponible");


            for (int i = 0; i < Codigo_Barra.Length; i++)
            {
                //mostramos el codigo de barra ya ordenado de menor a mayor junto al stock disponible en ese momento
                Console.WriteLine(" Codigo barra: " + Codigo_Barra[i] + " " + " Cantidad de stock Disponible: " + Cantidad_Disponible[i]);
            }


            Console.ReadKey();
        }

        static int Buscar_CBarra(int[] vec1, int x)
        {
            int k = 0, i = 0;
            // Este ciclo recorre el vector "vec1" buscando el valor "x"
            while (k == 0 && i < vec1.Length)
            {
                // Si encuentra el valor, asigna "k=1" para indicar que se encontró y termina el ciclo
                if (vec1[i] == x)
                {
                    k = 1;
                }
                else
                {
                    // Si no encuentra el valor, sigue buscando en la siguiente posición del vector
                    i++;
                }
            }

            // Si no se encontró el valor, devuelve -1
            if (k == 0)
            {
                i = -1;
            }
            // Si se encontró el valor, devuelve la posición del vector donde se encuentra
            return i;
        }

        static int Generar(int[] vec1, int[] vec2, int[] vec3)
        {
            int j = 0, i = 0;// Inicializamos los contadores j e i en cero

            while (i < vec1.Length)  // Iteramos mientras i sea menor que el tamaño del vector vec1.
            {
                if (vec2[i] < 10)// Si el valor en la posición i de vec2 es menor que 10, ejecutamos el bloque de código siguiente
                {
                    vec3[j] = vec1[i];// Asignamos el valor de la posición i de vec1 a la posición j de vec3.

                    j++;// Incrementamos el contador j en 1.
                }

                i++;// Incrementamos el contador i en 1, independientemente de si se cumple la condición del if o no.

            }

            return j; // Devolvemos el valor final de j, que representa el número de elementos en el vector vec3.
        }

        static void Ordenar(int[] vec1, int[] vec2)
        {
            int i = 0, k = 0, x = vec1.Length, aux = 0;

            // Ciclo principal de ordenamiento
            while (k == 0)
            {
                k = 1;
                x--;

                // Ciclo interno de comparación y ordenamiento
                for (i = 0; i < x; i++)
                {
                    if (vec1[i] > vec1[i + 1])
                    {

                        k = 0; // Se indica que hubo cambios en la iteración actual

                        // Se realiza el intercambio de elementos de vec1

                        aux = vec1[i];
                        vec1[i] = vec1[i + 1];
                        vec1[i + 1] = aux;

                        // Se realiza el intercambio de elementos correspondientes de vec2
                        aux = vec2[i];
                        vec2[i] = vec2[i + 1];
                        vec2[i + 1] = aux;
                    }
                }
            }
        }
    }
}

