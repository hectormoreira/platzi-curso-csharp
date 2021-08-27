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
                    WriteLine($"Nombre {curso.Nombre  }, Id  {curso.UniqueId}");
                }
            }
            else
            {
                WriteLine("No existe escuela o no existen cursos");
            }
            Printer.DibujarLinea(20);
        }
    }
}
