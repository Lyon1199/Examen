using System;

namespace examen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Singleton.Instance.mensaje);

            Singleton.Instance.mensaje = "LISTA DE ESTUDIANTES DE CURSO";
            Singleton.Instance.mensaje = "Estudiante 1: Juan";
            Console.WriteLine(Singleton.Instance.mensaje);
            // muestra el nombre del primer estudiante

            Singleton.Instance.mensaje = "Estudiante 2: Liam";
            Console.WriteLine(Singleton.Instance.mensaje);
            // muestra el nombre del segundo estudiante

            Singleton.Instance.mensaje = "Estudiante 3: Fernando";
            Console.WriteLine(Singleton.Instance.mensaje);
            // muestra el nombre del tercer estudiante

            Singleton.Instance.mensaje = "Estudiante 4: Xavier";
            Console.WriteLine(Singleton.Instance.mensaje);
            // muestra el nombre del cuarto estudiante

            Singleton.Instance.mensaje = "Estudiante 5: Edward";
            Console.WriteLine(Singleton.Instance.mensaje);
            //muestra el nombre del quinto estudiante

            Singleton.Instance.mensaje = "Estudiante 6: Julio";
            Console.WriteLine(Singleton.Instance.mensaje);
            // muestra el nombre del sexto estudiante 

            Singleton.Instance.mensaje = "Estudiante 7: Aida";
            Console.WriteLine(Singleton.Instance.mensaje);
            //muestra el nombre del septimo estudiante

            Singleton.Instance.mensaje = "Estudiante 8: Carmen";
            Console.WriteLine(Singleton.Instance.mensaje);
            //muestra el nombre del octavo estudiante

            Singleton.Instance.mensaje = "Estudiante 9: Sonia";
            Console.WriteLine(Singleton.Instance.mensaje);
            //muestra el nombre del noveno estudiante

            Singleton.Instance.mensaje = "Estudiante 10: Liliana";
            Console.WriteLine(Singleton.Instance.mensaje);
            //muestra el nombre del decimo estudiante

        }










    }
}
