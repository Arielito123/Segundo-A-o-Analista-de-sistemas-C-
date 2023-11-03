using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlumnosLegajoClass
{
    class Alumnos
    {
        #region atributos privados
        Int32[] legajos;
        Int32[] cant_m_aprobadas;
        #endregion

        #region encapsulamiento
        public Int32[] Legajos
        {
            get { return legajos; }
            set { legajos = value; }
        }

        public Int32[] Cant_m_aprobadas
        {
            get { return cant_m_aprobadas; }
            set { cant_m_aprobadas = value; }
        }
        #endregion


        #region acciones/metodos

        public Int32 buscarLegajo(Int32 x)
        {
            Int32 i = 0, k = 0;

            while (k == 0 && i < Legajos.Length)
            {
                if (x == Legajos[i])

                    k = 1;

                else
                    i++;
            }

            if (k == 0)

                i = -1;

            return i;

        }

       

        public Int32 generarAprobados(Int32[] g_aprobados,Int32 [] cant_m_aprox)
        {
            int j = 0,i=0;
            for ( i = 0; i <Legajos.Length; i++)
            {
                if (Cant_m_aprobadas[i] > 25)
                {
                    g_aprobados[j] = Legajos[i];
                    cant_m_aprox[j] = Cant_m_aprobadas[i];
                    j++;
                }



            }

            return j;
        }


        public void Ordenar() 
        {
            Int32 k = 0, i = 0, x = Legajos.Length,aux1=0,aux2=0;

            while (k == 0) 
            {
                k = 1;
                x--;

                for (i = 0; i < x; i++) 
                {
                    if (Legajos[i] > Legajos[i + 1]) 
                    {
                        aux1 = legajos[i];
                        Legajos[i] = Legajos[i + 1];
                        Legajos[i + 1] = aux1;

                        aux2 = Cant_m_aprobadas[i];
                        Cant_m_aprobadas[i] = Cant_m_aprobadas[i + 1];
                        Cant_m_aprobadas[i + 1] = aux1;
                    }
                }

            }


        }



        #endregion


    }
}
