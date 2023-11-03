using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductoStockClass
{
    class producto
    {
        #region carga
        private Int32[] codigobarra;


        private Int32[] cantidad_disponible;

        #endregion

        #region encapsulado
        public Int32[] Codigobarra
        {
            get { return codigobarra; }
            set { codigobarra = value; }
        }


        public Int32[] Cantidad_disponible
        {
            get { return cantidad_disponible; }
            set { cantidad_disponible = value; }
        }
        #endregion

        #region constructor

        public producto() 
        { 
        }

        #endregion



        public Int32 buscar(int x) 
        {
            int k=0, i=0;

            while (k == 0 && i < Codigobarra.Length)
            {
                if (x == Codigobarra[i])
                {
                    k = 1;
                }

                else 
                {
                    i++;
                }
            }

            if (k == 0) 
            {
                i = -1;
            }

            return i;
        }


        public void ordernar()
        {
            int k = 0, i = 0,x=3,auxc=0,auxca=0;

            
            
                while (k == 0) 
                {
                    k = 1;
                    x--;

                    for (i = 0; i < x; i++) 
                    {
                        if (Codigobarra[i] > Codigobarra[i + 1]) 
                        {
                            k = 0;
                            auxc = Codigobarra[i];
                            Codigobarra[i] = Codigobarra[i+1];
                            Codigobarra[i+1] = auxc;
                            
                            auxca = Cantidad_disponible[i];
                            Cantidad_disponible[i] = Cantidad_disponible[i + 1];
                            Cantidad_disponible[i + 1] = auxca;



                        }
                    }
                }
            
       
           

        

        
        
        

    }
        
        public int generar(int[] vectorgenerado)
        {
            int i=0,j=0;

            for (i = 0; i < Codigobarra.Length; i++) 
            {
                if (Cantidad_disponible[i] < 10) 
                {
                    vectorgenerado[j] = Codigobarra[i];
                    j++;
                }
            }
            return j;
        }
    }
}
