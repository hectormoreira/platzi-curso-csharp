using System;
using System.Collections.Generic;
using System.Linq;
using CoreEscuela.Entidades;

namespace CoreEscuela.App
{
    public sealed class EscuelaEngine
    {
        public Escuela Escuela { get; set; }

        public EscuelaEngine()
        {
        }

        public void Inicializar()
        {
            Escuela =
                new Escuela("Platzi Academy",
                    2012,
                    TiposEscuela.Secundaria,
                    pais: "Colombia",
                    ciudad: "Bogotá");
            CargarCursos();
            CargarAsignaturas();
            CargarEvaluaciones();
        }

        public Dictionary<string, IEnumerable<ObjetoEscuelaBase>> GetDiccionarioObjetos(){
            var diccionario = new Dictionary<string, IEnumerable<ObjetoEscuelaBase>>();
            
            diccionario.Add("Escuela", new[]{Escuela});
            diccionario.Add("Cursos", Escuela.Cursos.Cast<ObjetoEscuelaBase>());
            return diccionario;
        }

        public IReadOnlyList<ObjetoEscuelaBase>
        GetObjetosEscuela(
            bool traeEvaluaciones = true,
            bool traeAlumnos = true,
            bool traeAsignaturas = true,
            bool traeCursos = true
        )
        {
            return GetObjetosEscuela(out int dummy,
            out dummy,
            out dummy,
            out dummy);
        }

        public IReadOnlyList<ObjetoEscuelaBase>
        GetObjetosEscuela(
            out int conteoEvaluaciones,
            bool traeEvaluaciones = true,
            bool traeAlumnos = true,
            bool traeAsignaturas = true,
            bool traeCursos = true
        )
        {
            return GetObjetosEscuela(out conteoEvaluaciones,
            out int dummy,
            out dummy,
            out dummy);
        }

        public IReadOnlyList<ObjetoEscuelaBase>
        GetObjetosEscuela(
            out int conteoEvaluaciones,
            out int conteoCursos,
            bool traeEvaluaciones = true,
            bool traeAlumnos = true,
            bool traeAsignaturas = true,
            bool traeCursos = true
        )
        {
            return GetObjetosEscuela(out conteoEvaluaciones,
            out conteoCursos,
            out int dummy,
            out dummy);
        }

        public IReadOnlyList<ObjetoEscuelaBase>
        GetObjetosEscuela(
            out int conteoEvaluaciones,
            out int conteoCursos,
            out int conteoAsignaturas,
            bool traeEvaluaciones = true,
            bool traeAlumnos = true,
            bool traeAsignaturas = true,
            bool traeCursos = true
        )
        {
            return GetObjetosEscuela(out conteoEvaluaciones,
            out conteoCursos,
            out conteoAsignaturas,
            out int dummy);
        }

        public IReadOnlyList<ObjetoEscuelaBase>
        GetObjetosEscuela(
            out int conteoEvaluaciones,
            out int conteoCursos,
            out int conteoAsignaturas,
            out int conteoAlumnos,
            bool traeEvaluaciones = true,
            bool traeAlumnos = true,
            bool traeAsignaturas = true,
            bool traeCursos = true
        )
        {
            conteoEvaluaciones = conteoAsignaturas = conteoAlumnos = 0;

            var listObj = new List<ObjetoEscuelaBase>();
            listObj.Add (Escuela);

            if (traeCursos)
            {
                listObj.AddRange(Escuela.Cursos);
            }

            conteoCursos = Escuela.Cursos.Count;
            foreach (var curso in Escuela.Cursos)
            {
                conteoAsignaturas += curso.Asignaturas.Count;
                conteoAlumnos += curso.Alumnos.Count;

                if (traeAsignaturas)
                {
                    listObj.AddRange(curso.Asignaturas);
                }

                if (traeAlumnos)
                {
                    listObj.AddRange(curso.Alumnos);
                }

                if (traeEvaluaciones)
                {
                    foreach (var alumno in curso.Alumnos)
                    {
                        listObj.AddRange(alumno.Evaluaciones);
                        conteoEvaluaciones += alumno.Evaluaciones.Count;
                    }
                }
            }
            return listObj.AsReadOnly();
        }


#region Metodos de carga

        private void CargarEvaluaciones()
        {
            foreach (var curso in Escuela.Cursos)
            {
                foreach (var asignatura in curso.Asignaturas)
                {
                    foreach (var alumno in curso.Alumnos)
                    {
                        var rnd = new Random(System.Environment.TickCount);
                        for (int i = 0; i < 5; i++)
                        {
                            var evaluacion =
                                new Evaluacion {
                                    Asignatura = asignatura,
                                    Nombre = $"{asignatura.Nombre} Ev#{i + 1}",
                                    Nota = (float)(5 * rnd.NextDouble()),
                                    Alumno = alumno
                                };
                            alumno.Evaluaciones.Add (evaluacion);
                        }
                    }
                }
            }
        }

        private void CargarAsignaturas()
        {
            foreach (var curso in Escuela.Cursos)
            {
                List<Asignatura> listaAsignaturas =
                    new List<Asignatura>()
                    {
                        new Asignatura { Nombre = "Matemáticas" },
                        new Asignatura { Nombre = "Educación Física" },
                        new Asignatura { Nombre = "Castellano" },
                        new Asignatura { Nombre = "Ciencias Naturales" }
                    };
                curso.Asignaturas = listaAsignaturas;
            }
        }

        private List<Alumno> GenerarAlumnosAlAzar(int cantidad)
        {
            string[] nombre1 =
            {
                "Alba",
                "Felipa",
                "Eusebio",
                "Farid",
                "Donald",
                "Alvaro",
                "Nicolás"
            };
            string[] apellido1 =
            {
                "Ruiz",
                "Sarmiento",
                "Uribe",
                "Maduro",
                "Trump",
                "Toledo",
                "Herrera"
            };
            string[] nombre2 =
            {
                "Freddy",
                "Anabel",
                "Rick",
                "Murty",
                "Silvana",
                "Diomedes",
                "Nicomedes",
                "Teodoro"
            };

            var listaAlumnos =
                from n1 in nombre1
                from n2 in nombre2
                from a1 in apellido1
                select new Alumno { Nombre = $"{n1} {n2} {a1}" };

            return listaAlumnos
                .OrderBy((al) => al.UniqueId)
                .Take(cantidad)
                .ToList();
        }

        private void CargarCursos()
        {
            Escuela.Cursos =
                new List<Curso>()
                {
                    new Curso()
                    { Nombre = "101", Jornada = TiposJornada.Mañana },
                    new Curso()
                    { Nombre = "201", Jornada = TiposJornada.Mañana },
                    new Curso()
                    { Nombre = "301", Jornada = TiposJornada.Mañana },
                    new Curso()
                    { Nombre = "401", Jornada = TiposJornada.Tarde },
                    new Curso() { Nombre = "501", Jornada = TiposJornada.Tarde }
                };
            Random rnd = new Random();
            foreach (var curso in Escuela.Cursos)
            {
                int cantidadRandom = rnd.Next(5, 20);
                curso.Alumnos = GenerarAlumnosAlAzar(cantidadRandom);
            }
        }
#endregion
    }
}
