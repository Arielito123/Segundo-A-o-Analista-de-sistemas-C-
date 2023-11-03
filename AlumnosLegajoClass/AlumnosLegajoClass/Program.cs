using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlumnosLegajoClass
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Consignas
            /*Ejercicio n° 13
En una universidad se ingresan los siguientes datos de 5 alumnos: Número de legajo y la
cantidad de materias aprobadas. Al terminar los llamados a mesas de finales de diciembre, se
ingresa número de legajo y cantidad de materias que aprobó el alumno en ese llamado. Este
conjunto de datos finaliza con un legajo 0.
Se pide:
 Buscar el legajo y si existe actualizar la cantidad de materias aprobadas.
Al finalizar las actualizaciones generar un vector con los alumnos que aprobaron más de 25
materias, y mostrar si Existe en pantalla el vector generado.
 Emitir un listado ordenado por numero de legajo de menor a mayor con arrastre de la
cantidad de materias aprobadas. */
            #endregion

            #region creando variables/Objetos
            const Int32 longitud = 3;
            Int32 buscarL;
            Int32 [] numero_legajo= new Int32[longitud];
            Int32[] numero_materias_apro = new Int32[longitud];
            Int32[] vector_g_apro = new Int32[longitud];
            Int32[] vector_m_apro = new Int32[longitud];
            #endregion

            #region carga de datos
            for (int i = 0; i < numero_legajo.Length; i++) 
            {
                Console.WriteLine("Ingrese numero de legajo del alumno" +" "+ "["+(i + 1)+"]");
                numero_legajo[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" ");
                Console.WriteLine("Ingrese la cantidad de materias aprobadas" +" "+ "[" + (i + 1) + "]");
                numero_materias_apro[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" ");
            }
            #endregion

            #region instanciando la clase
            Alumnos Oalumnos = new Alumnos();
            Oalumnos.Legajos = numero_legajo;
            Oalumnos.Cant_m_aprobadas = numero_materias_apro;
            #endregion
            
            Console.WriteLine("Ingrese el numero de legajo que deseas encontrar para actualizar {0} para terminar");
             buscarL= Convert.ToInt32(Console.ReadLine());

            while (buscarL!= 0) 
            {
                int pos = Oalumnos.buscarLegajo(buscarL);

                if (pos == -1)
                {
                    Console.WriteLine("no se encontro el numero de legajo");

                }

                else 
                {
                    Console.WriteLine("ingrese la actualizacion de materias aprobadas");
                    Int32 cantidadApro = Convert.ToInt32(Console.ReadLine());

                  Oalumnos.Cant_m_aprobadas[pos] = Oalumnos.Cant_m_aprobadas[pos]+ cantidadApro;

                   
                }

                Console.WriteLine("Ingrese el numero de legajo que deseas encontrar para actualizar {0} para terminar");
                buscarL = Convert.ToInt32(Console.ReadLine());
            }

            int gen = Oalumnos.generarAprobados(vector_g_apro,vector_m_apro);

            Console.WriteLine("alumnos con mas de 25 materias aprobadas");

            for (int i = 0; i < gen; i++) 
            {
                Console.WriteLine(" Legajo: " +vector_g_apro[i] + " "+"cantidad materias aprobado" + vector_m_apro[i]);    
            }

            Console.WriteLine("cantidad de alumnos con mas de 25 materias: "+gen);

            Oalumnos.Ordenar();

            for (int i = 0; i < Oalumnos.Legajos.Length; i++) 
            {
                Console.WriteLine("legajo:"+"["+(i+1)+"]"+Oalumnos.Legajos[i]+" materia "+Oalumnos.Cant_m_aprobadas[i]);
            }


                Console.ReadKey();


        }
    }
}
