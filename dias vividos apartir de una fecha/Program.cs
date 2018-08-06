using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dias_vividos_apartir_de_una_fecha
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime localDate = DateTime.Now;
            cabeza();
            int dia, mes, ano, cad, cad1 = 0;
            int year = localDate.Year;
            Console.Write("\n Digite día de nacimiento: ");
            dia = int.Parse(Console.ReadLine());
            Console.Write("\n Digite mes de nacimiento: ");
            mes = int.Parse(Console.ReadLine());
            Console.Write("\n Digite año completo de nacimiento: ");
            ano = int.Parse(Console.ReadLine());

            if (mes == 4 || mes == 6 || mes == 9 || mes == 11)
            {
                cad1 = (30 - dia) + (30 * 3) + (31 * 7) + (28);

                cad = (year - ano) * cad1;

                Console.Write(" Los días vividos son: {0}", cad);

            }
            else
            {
                if (mes == 1 || mes == 3 || mes == 5 || mes == 7 || mes == 8 || mes == 10 || mes == 12)
                    cad1 = (31 - dia) + (30 * 4) + (31 * 6) + (28);

                cad = (year - ano) * cad1;

                Console.Write("\n Los días vividos son: {0}", cad);

            }
            if (mes == 2)
            {
                cad1 = (28 - dia) + (30 * 4) + (31 * 7);

                cad = (year - ano) * cad1;

                Console.Write("\n Los días vividos son: {0}", cad);

            }
            Console.ReadKey();//ReadKey es una funcion que lee que se oprimio una tecla.
            Console.Clear();//Clear es la funcion para limpiar pantalla.
        }
        static void cabeza()//funcion para decirle al usuario que la clave debe ser de 4 digitos
        {
            Console.Clear();//Clear es la funcion para limpiar pantalla.
            Console.Write("\n       UNIVERSIDAD NACIONAL ABIERTA Y A DISTANCIA");//la funcion Write basicamente lo que hace es mostrar en la consola la cadena de caracteres.
            Console.Write("\n              Trabajo colaborativo: Fase 2");
            Console.Write("\n                       Algorítmos");
            Console.Write("\n                  Problema 10: fase 2");
        }
    }
}
