using System.Collections.Generic;
using CoreEscuela.App;
using CoreEscuela.Entidades;
using CoreEscuela.Util;
using static System.Console;
namespace CoreEscuela
{
    class Program
    {
        static void Main(string[] args)
        {
            var engine = new EscuelaEngine();
            engine.Inicializar();
            Printer.WriteTitle("Bienvenidos a la escuela");
            Printer.Beep();
            ImprimirCursosEscuela(engine.Escuela);
        }

        private static void ImprimirCursosEscuela(Escuela escuela)
        {
            Printer.WriteTitle("Cursos de la escuela");

            if (escuela?.Cursos != null)
            {
                foreach (var curso in escuela.Cursos)
                {
                    Printer.WriteTitle($"Nombre {curso.Nombre  }, Id  {curso.UniqueId}");
                    ImprimirAlumnos(curso.Nombre, curso.Alumnos);
                }
            }
            else
            {
                WriteLine("No existe escuela o no existen cursos");
            }
            Printer.DibujarLinea(20);
        }

        private static void ImprimirAlumnos(string cursoName, List<Alumno> alumnos)
        {
            Printer.WriteTitle($"Alumnos del curso {cursoName}");

            foreach (var alumno in alumnos)
            {
                WriteLine($"Alumno: {alumno.Nombre}");
                ImprimirEvaluacionesAlumno(alumno.Nombre, alumno.Evaluaciones);
            }
        }

        private static void ImprimirEvaluacionesAlumno(string nombre, List<Evaluacion> evaluaciones)
        {
            Printer.WriteTitle($"Evaluacion del alumno {nombre}");

            foreach (var evaluacion in evaluaciones)
            {
                WriteLine($"Evaluacion de: {evaluacion.Nombre} - Nota: {evaluacion.Nota.ToString("0.00")}");
            }
        }
    }
}
