using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_vector_con_poo
{
    class Stock1
    {
        #region Atributos;
        private Int32[] vectorPrincipal;
        private Int32[] vectorSecundario;
        #endregion

        #region Encapsulado

        public Int32[] VectorPrincipal
        {
            get { return vectorPrincipal; }
            set { vectorPrincipal = value; }
        }

        public Int32[] VectorSecundario
        {
            get { return vectorSecundario; }
            set { vectorSecundario = value; }
        }

        #endregion

        #region constructor
        public Stock1()
        {
        }
        #endregion

        #region Acciones
        int Buscar_CBarra(int x)
        {
            int k = 0, i = 0;
            // Este ciclo recorre el vector "vec1" buscando el valor "x"
            while (k == 0 && i < VectorPrincipal.Length)
            {
                // Si encuentra el valor, asigna "k=1" para indicar que se encontró y termina el ciclo
                if (VectorPrincipal[i] == x)
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

        public int Generar(int[] vec3)
        {
            int j = 0, i = 0;// Inicializamos los contadores j e i en cero

            while (i < VectorPrincipal.Length)  // Iteramos mientras i sea menor que el tamaño del vector vec1.
            {
                if (VectorSecundario[i] < 10)// Si el valor en la posición i de vec2 es menor que 10, ejecutamos el bloque de código siguiente
                {
                    vec3[j] = VectorPrincipal[i];// Asignamos el valor de la posición i de vec1 a la posición j de vec3.

                    j++;// Incrementamos el contador j en 1.
                }

                i++;// Incrementamos el contador i en 1, independientemente de si se cumple la condición del if o no.

            }

            return j; // Devolvemos el valor final de j, que representa el número de elementos en el vector vec3.
        }

        #endregion
    }
}