using System;
using System.Collections.Generic;
using CoreEscuela.Entidades;
using static System.Console;
namespace etapa1
{
    class Program
    {
        static void Main(string[] args)
        {
            var escuela = new Escuela("Platzi Academy", 2012, TiposEscuela.Secundaria, pais: "Colombia", ciudad: "Bogotá");

            escuela.Cursos = new List<Curso>(){
                new Curso(){ Nombre = "101", Jornada = TiposJornada.Mañana },
                new Curso(){ Nombre = "201", Jornada = TiposJornada.Mañana },
                new Curso(){ Nombre = "301", Jornada = TiposJornada.Mañana }
            };

            escuela.Cursos.Add(new Curso() { Nombre = "102", Jornada = TiposJornada.Tarde });
            escuela.Cursos.Add(new Curso() { Nombre = "202", Jornada = TiposJornada.Tarde });

            var otraColleccion = new List<Curso>(){
                new Curso(){ Nombre = "401", Jornada = TiposJornada.Mañana },
                new Curso(){ Nombre = "501", Jornada = TiposJornada.Mañana },
                new Curso(){ Nombre = "502", Jornada = TiposJornada.Tarde }
            };            
            escuela.Cursos.AddRange(otraColleccion);
            

            ImprimirCursosEscuela(escuela);
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
