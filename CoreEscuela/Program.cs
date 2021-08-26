using System;
using CoreEscuela.Entidades;
using static System.Console;
namespace etapa1
{
    class Program
    {
        static void Main(string[] args)
        {
            var escuela = new Escuela("Platzi Academy", 2012, TiposEscuela.Secundaria, pais: "Colombia", ciudad: "Bogotá");

            escuela.Cursos = new Curso[]{
                new Curso(){ Nombre = "101" },
                new Curso(){ Nombre = "201" },
                new Curso(){ Nombre = "301" }
            };

            ImprimirCursosEscuela(escuela);

            bool rta = 10 == 10;//true
            int cantidad = 10;

            if (rta == false)
            {
                WriteLine("Se cumplio la condición #1");
            }
            else if (cantidad > 15)
            {
                WriteLine("Se cumplio la condición #2");
            }
            else
            {
                WriteLine("No Se cumplio la condición");
            }

            if(cantidad > 5 && rta == false)
            {
                WriteLine("Se cumplio la condición #3");
            }

            
            if(cantidad > 5 && rta )
            {
                WriteLine("Se cumplio la condición #4");
            }

            cantidad = 10;
            if(
                (cantidad > 15 || !rta) 
                && (cantidad % 5 == 0 )
            )
            {
                WriteLine("Se cumplio la condición #5");
            }
        }

        private static void ImprimirCursosEscuela(Escuela escuela)
        {
            WriteLine("|===============================|");
            WriteLine("|==== Cursos de la escuela =====|");
            WriteLine("|===============================|");

            if (escuela?.Cursos != null)
            {
                foreach (var curso in escuela.Cursos)
                {
                    WriteLine($"Nombre {curso.Nombre  }, Id  {curso.UniqueId}");
                }
            }
            else
            {
                WriteLine("No existe escuela o no existen cursos");
            }
            WriteLine("|===============================|");
        }

        private static void ImprimirCursosWhile(Curso[] arregloCursos)
        {
            int contador = 0;
            while (contador < arregloCursos.Length)
            {
                WriteLine($"Nombre {arregloCursos[contador].Nombre  }, Id  {arregloCursos[contador].UniqueId}");
                contador++;
            }
        }

        private static void ImprimirCursosDoWhile(Curso[] arregloCursos)
        {
            int contador = 0;
            do
            {
                WriteLine($"Nombre {arregloCursos[contador].Nombre  }, Id  {arregloCursos[contador].UniqueId}");
                contador++;
            } while (contador < arregloCursos.Length);
        }

        private static void ImprimirCursosFor(Curso[] arregloCursos)
        {
            for (int i = 0; i < arregloCursos.Length; i++)
            {
                WriteLine($"Nombre {arregloCursos[i].Nombre  }, Id  {arregloCursos[i].UniqueId}");
            }
        }

        private static void ImprimirCursosForEach(Curso[] arregloCursos)
        {
            foreach (var curso in arregloCursos)
            {
                WriteLine($"Nombre {curso.Nombre  }, Id  {curso.UniqueId}");
            }
        }
    }
}
