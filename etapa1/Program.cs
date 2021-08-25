using System;
using CoreEscuela.Entidades;

namespace etapa1
{
    class Program
    {
        static void Main(string[] args)
        {
            var escuela = new Escuela("Platzi Academy", 2012);
            escuela.Pais = "Colonbia";
            escuela.Ciudad = "Bogota";
            escuela.TipoEscuela = TiposEscuela.Primaria;
            Console.WriteLine(escuela);
        }
    }
}
