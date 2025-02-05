using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_2025_I_P1_TAREA1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //LLAMADO AL PROCEDIMIENTO
            /*string nombre;
            Console.WriteLine("Introduzca su nombre: ");
            nombre = Console.ReadLine();
            saludar(nombre);*/

            //LLAMADO A FUNCION
            double numero1, numero2, suma;
            Console.WriteLine("Ingrese el numero 1: ");
            numero1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el numero 2: ");
            numero2 = double.Parse(Console.ReadLine());
            suma = sumar(numero1, numero2);
            Console.WriteLine($"La suma de {numero1} y {numero2} = {suma}");
            Console.ReadLine();

        }
        //PROCEDIMENTO: NO RETORNA NADA
        //IMPLEMETACION: SIEMPRE SON void y pueden tener Parametros()
        static void saludar(string pNombre)//FIRMA
        {
            Console.WriteLine($"Hola {pNombre}!!!!!!");//IMPLEMENTACION
        }
        //FUNCIONES: RETORNAN UN VALOR DEL TIPO PRIMITIVO
        //IMPLEMENTACION: SIEMPRE RETORNAN UN TIPO DE DATO PRIMITIVO Y PUEDEN TENER PARAMETROS()
        static double sumar(double pNumero1, double pNumero2)
        {
            //IMPLEMENTACION INICIO
            double suma = 0;
            suma = pNumero1 + pNumero2;
            return suma;
            //IMPLEMENTACION FIN

        }
    }
    
}
