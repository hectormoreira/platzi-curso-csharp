using System.Collections.Generic;
using System.Linq;
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

            
            //ImprimirCursosEscuela(engine.Escuela);



            // ob = evaluacion;
            // if (ob is Alumno)
            // {
            //     Alumno alumnoRecuperado = (Alumno)ob;
            // }
            // Alumno alumnoRecuperado2 = ob as Alumno;
            // int dummy = 0;
            // var listaObj =
            //     engine
            //         .GetObjetosEscuela(out int conteoEvaluaciones,
            //         out dummy,
            //         out dummy,
            //         out dummy);


            Dictionary<int, string> diccionario = new Dictionary<int, string>();
            diccionario.Add(10, "Lorem");
            diccionario.Add(11, "Ipsum");

            foreach (var item in diccionario)
            {
                WriteLine($"Key: {item.Key} - Value: {item.Value} ");
            }

            







        }

        private static void ImprimirCursosEscuela(Escuela escuela)
        {
            Printer.WriteTitle("Cursos de la escuela");

            if (escuela?.Cursos != null)
            {
                foreach (var curso in escuela.Cursos)
                {
                    Printer
                        .WriteTitle($"Nombre {curso.Nombre}, Id  {curso.UniqueId}");
                    ImprimirAlumnos(curso.Nombre, curso.Alumnos);
                }
            }
            else
            {
                WriteLine("No existe escuela o no existen cursos");
            }
            Printer.DrawLine(20);
        }

        private static void ImprimirAlumnos(
            string cursoName,
            List<Alumno> alumnos
        )
        {
            Printer.WriteTitle($"Alumnos del curso {cursoName}");

            foreach (var alumno in alumnos)
            {
                WriteLine($"Alumno: {alumno.Nombre}");
                ImprimirEvaluacionesAlumno(alumno.Nombre, alumno.Evaluaciones);
            }
        }

        private static void ImprimirEvaluacionesAlumno(
            string nombre,
            List<Evaluacion> evaluaciones
        )
        {
            Printer.WriteTitle($"Evaluacion del alumno {nombre}");

            foreach (var evaluacion in evaluaciones)
            {
                WriteLine($"Evaluacion de: {evaluacion.Nombre} - Nota: {evaluacion.Nota.ToString("0.00")}");
            }
        }
    }
}
