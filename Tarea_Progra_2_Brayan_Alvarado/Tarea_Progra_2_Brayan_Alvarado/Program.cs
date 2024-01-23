using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasetipoDatos
{
    internal class Program
    {
        static void Main(string[] args) //Metodo principal, de donde inicia el programa a correr
        {
         
            Console.WriteLine("=========================================");
            Console.WriteLine("Digite el numero de cedula del empleado: ");
            int cedula = int.Parse(Console.ReadLine());

            Console.WriteLine("=========================================");
            Console.WriteLine("Digite el nombre del empleado: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("=========================================");
            Console.WriteLine("");



            Console.WriteLine("=========================================");
            Console.WriteLine("Digite la cantidad de horas laboradas por el empleado: ");
            int horasLaboradas = int.Parse(Console.ReadLine());
            Console.WriteLine("=========================================");


            Console.WriteLine("=========================================");
            Console.WriteLine("Digite el precio por hora para el empleado: ");
            int precioPorHora = int.Parse(Console.ReadLine());
            Console.WriteLine("=========================================");

            Console.WriteLine("=========================================");
            Console.WriteLine("Digite el tipo del empleado: ");
            int tipoDeEmpleado = int.Parse(Console.ReadLine());
            Console.WriteLine("=========================================");

            double salarioOrdinario = horasLaboradas * precioPorHora;
            double deduccionCCSS = 0.91;

            switch (tipoDeEmpleado)
            {
                case 1:
                    Console.WriteLine("El tipo de empleado es: Operario");
                    Console.WriteLine("=========================================");
                    double aumentoOperario = 0.15;
                    double salarioOrdinarioOperario = horasLaboradas * precioPorHora;
                    double salarioBrutoOperario = (salarioOrdinarioOperario * aumentoOperario) + salarioOrdinarioOperario;
                    double salarioNetoOperario = salarioBrutoOperario - deduccionCCSS;
                    Console.WriteLine("=========================================");
                    Console.WriteLine("El aumento es de : " + aumentoOperario);
                    Console.WriteLine("=========================================");
                    Console.WriteLine("El salario bruto es: " + salarioBrutoOperario);
                    Console.WriteLine("=========================================");
                    Console.WriteLine("El salario neto es: " + salarioNetoOperario);
                    Console.WriteLine("=========================================");

                    break;

                case 2:
                    Console.WriteLine("El tipo de empleado es: Tecnico");
                    Console.WriteLine("=========================================");
                    double aumentoTecnico = 0.10;
                    double salarioOrdinarioTecnico = horasLaboradas * precioPorHora;
                    double salarioBrutoTecnico = (salarioOrdinarioTecnico * aumentoTecnico) + salarioOrdinarioTecnico;
                    double salarioNetoTecnico = salarioBrutoTecnico - deduccionCCSS;
                    Console.WriteLine("=========================================");
                    Console.WriteLine("El aumento es de : " + aumentoTecnico);
                    Console.WriteLine("=========================================");
                    Console.WriteLine("El salario bruto es: " + salarioBrutoTecnico);
                    Console.WriteLine("=========================================");
                    Console.WriteLine("El salario neto es: " + salarioNetoTecnico);
                    Console.WriteLine("=========================================");

                    break;

                case 3:
                    Console.WriteLine("El tipo de empleado es: Profesional");
                    Console.WriteLine("=========================================");
                    double aumentoProfesional = 0.05;
                    double salarioOrdinarioProfesional = horasLaboradas * precioPorHora;
                    double salarioBrutoProfesional = (salarioOrdinarioProfesional * aumentoProfesional) + salarioOrdinarioProfesional;
                    double salarioNetoProfesional= salarioBrutoProfesional - deduccionCCSS;
                    Console.WriteLine("=========================================");
                    Console.WriteLine("El sumento es de : " + aumentoProfesional);
                    Console.WriteLine("=========================================");
                    Console.WriteLine("El salario bruto es: " + salarioBrutoProfesional);
                    Console.WriteLine("=========================================");
                    Console.WriteLine("El salario neto es: " + salarioNetoProfesional);
                    Console.WriteLine("=========================================");
                    break;

                default:
                    Console.WriteLine("=========================================");
                    Console.WriteLine("Esto no es una opcion valida");
                    Console.WriteLine("=========================================");
                    break;
            }


            Console.WriteLine("La cedula del empleado es: " + cedula);
            Console.WriteLine("=========================================");

            Console.WriteLine("El nombre del empleado es: " + nombre);
            Console.WriteLine("=========================================");

            Console.WriteLine("El salario por hora del empleado es: " + precioPorHora);
            Console.WriteLine("=========================================");

            Console.WriteLine("La cantidad de horas laboradas por el empleado son: " + horasLaboradas);
            Console.WriteLine("=========================================");

            Console.WriteLine("El salario ordinario es: " + (salarioOrdinario));
            Console.WriteLine("=========================================");

            Console.WriteLine("La deduccion de la CCSS es: " + deduccionCCSS);
            Console.WriteLine("=========================================");

            Console.WriteLine("=========================================");




        }
    }
}


