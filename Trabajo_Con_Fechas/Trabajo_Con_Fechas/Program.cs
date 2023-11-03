using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
namespace Trabajo_Con_Fechas
{
    class Program
    {
        static void Main(string[] args)
        {

            int dg = 29;
            int mg = 2;
            int ag = 2020;

            DateTime fg = new DateTime(ag, mg, dg);
            Console.WriteLine("La fecha generada en formato corto es:" + fg);

            //como saber la fecha actual .now

            DateTime fa = DateTime.Now;
            Console.WriteLine(" la fecha actual es " + fa);

            //para convertir una fecha en una cadena de string con formato corto .ToShowrtDateString();

            string strfa = fa.ToShortDateString();

            Console.WriteLine("La fecha actual en formato corto es:" + strfa);


            //para convertir una fecha en una cadena de string formato largo .ToLongDateString();

            strfa = fa.ToLongDateString();

            Console.WriteLine("fecha con formato mas largo: " + strfa + " " + DateTime.Now);

            //para tomar la hora de una fecha y convertirla en una cadena de string con formato corto ToShortTimeString();
            strfa = fa.ToShortTimeString();

            Console.WriteLine("la hora actual en formato corto es: " + strfa);

            // dia mes año de una fecha en tipo de dato int day,Month,year
            int dia = fa.Day;
            int mes = fa.Month;
            int year = fa.Year;

            Console.WriteLine("hoy es {0}, del mes {1} y del año {2}", dia, mes, year);

            /* para tomar el dia de la semana en letras de una fecha y convertirla
             en una cadena de string dayofweek por lo general nos va aparecer en ingles*/

            strfa = fa.DayOfWeek.ToString();
            Console.WriteLine("el dia de la semana actual es: " + strfa);

            /*para tomar el dia de la semana en letra de una fecha y convertirla en una cadena de string
             dayofweek y mostrarlo en otro idioma */

            Console.WriteLine("el dia de la semana en letras dia del mes en nro de mes en letra");
            Console.WriteLine(fa.ToString("dddd dd MMMM", CultureInfo.CreateSpecificCulture("es-AR")));//pt-BR

            //dia de la semana en letras


            Console.WriteLine("el dia de la semana en letra");
            Console.WriteLine(fa.ToString("dddd", CultureInfo.CreateSpecificCulture("es-AR")));//pt-BR

            Console.WriteLine("el dia de la semana abreviado");
            Console.WriteLine(fa.ToString("ddd", CultureInfo.CreateSpecificCulture("es-AR")));//pt-BR

            //tomar solo el mes en letra
            Console.WriteLine("mes en numeros  mes en letra");
            Console.WriteLine(fa.ToString("MMMM", CultureInfo.CreateSpecificCulture("es-AR")));//pt-BR

            Console.WriteLine("mes en numero de letras Abreviado");
            Console.WriteLine(fa.ToString("MMM", CultureInfo.CreateSpecificCulture("es-AR")));//pt-BR


            //nunero del dua del año

            int ct = fa.DayOfYear;

            Console.WriteLine("hoy es el dia nro {0} del actual es: ", ct);

            //Añadir dias,mes,años y una fecha
            DateTime fm = fa;

            fm = fm.AddDays(3);//agrega 3 dias
            fm = fm.AddMonths(5);//agrega 5 meses
            fm = fm.AddYears(-1);//resta un año;
            fm = fm.AddHours(1);//agrega una hora
            fm = fm.AddMinutes(15);//

            Console.WriteLine("la fecha actual es: " + fa);//por defecto muestra fecha y hora;
            Console.WriteLine("La fecha modificada es:" + fm);//por defecto muestra fecha y hora;

            //como saber si un año es biciesto funcion IsLeapYear(int year) devuelve true o false

            if (DateTime.IsLeapYear(ag))
            {
                Console.WriteLine("el año {0} es un año biciesto", year);
                Console.WriteLine("El dia 29 de febrero de este año cae o caera el dia");
                Console.WriteLine(fg.ToString("dddd", CultureInfo.CreateSpecificCulture("es-AR")));

            }
            else
            {
                Console.WriteLine("El año {0} no es un año biciesto",year);
            }

            //intervalos de tiempo TimeSpan
            //la unica operacion matematica disponible entre fecha es la resta entre solo 2 fechas esta resta no
            //da otra fecha,lo que da es un intervalo de tiempo 

            TimeSpan intervalo = fa - fm;
            Console.WriteLine("el intervalo entre las fechas es: "+intervalo);

            int dayintervalo = intervalo.Days;

            Console.WriteLine("componente de duas del intervalo entre las fechas es: "+dayintervalo);

            int horasIntervalo = intervalo.Hours;

            Console.WriteLine("componentes horas intervalo entre las fechas es: "+horasIntervalo);

            int minutosIntervalos = intervalo.Minutes;

            Console.WriteLine("componentes minutos intervalos entre las fechas es :"+minutosIntervalos);

            //total de dias de un intervalo
            double td = intervalo.TotalDays;//devuelve la cantidad  expresada  en dias enteros y fraccion

            Console.WriteLine("la cantidad de dias y fraccion del intervalo es: "+td);

            //para obtener la cantidad de dias sin fraccion  usamos la funcion matematica truncate
            td = Math.Truncate(td);
            Console.WriteLine("la cantidad de duas dek intervalo es: "+td);

         
            

            Console.ReadKey();




        }
        static public Int32 CalcularEdad(DateTime FechaNacimiento) 
        {
            int yearActual = DateTime.Now.Year;
            int yearNac = FechaNacimiento.Year;
            int edad = yearActual - yearNac;

            //NRO DEL DIA DEL AÑO ACTUAL

            int diasYearActual = DateTime.Now.DayOfYear;//TRAE DIA DEL AÑO HASTA HOY
            //que numero del dia del año que nacio
            int diaYearNac = FechaNacimiento.DayOfYear;


            if (diasYearActual < diaYearNac)
                edad--;

            return edad;


        }

        public Int32[] Antiguedad(DateTime FechaIngreso)
        {
            Int32[] yearDay = new Int32[2];
            /*Vector devolver antiguedad*/

            //datos de la fecha de ingreso;

            int afi = FechaIngreso.Year;
            int mfi = FechaIngreso.Month;
            int dfi = FechaIngreso.Day;
            int dafi = FechaIngreso.DayOfYear;//nro del dia del año de ingreso

            //año actual;
            int afa = DateTime.Now.Year;
            int dfa = DateTime.Now.DayOfYear;
            int AntYear = afa - afi;
            Int32 AntDias = 0;

            if (!DateTime.IsLeapYear(afa)) 
            {
                if((dfi==29)&&(mfi==2))
                dfi=28;
                
            }

            DateTime FechaAux = new DateTime(afa, mfi, dfi);

            int dafa = FechaAux.DayOfYear;

            if (dfa >= dfi)

                AntDias = dfa - dfi;


            else 
            {
                if (DateTime.IsLeapYear(afa - 1))

                    AntDias = 366 - dafi + dfa;
                else
                    AntDias = 365 - dafi + dfa;
                
            }

            yearDay[0] = AntYear;
            yearDay[1] = AntYear;

            return yearDay;

        }

    }
}
