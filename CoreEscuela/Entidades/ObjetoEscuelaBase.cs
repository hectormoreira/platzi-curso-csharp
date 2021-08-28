using System;

namespace CoreEscuela.Entidades
{
    public abstract class ObjetoEscuelaBase
    {
        public ObjetoEscuelaBase()
        {
            UniqueId = Guid.NewGuid().ToString();
        }

        public string UniqueId { get; set; }

        public string Nombre { get; set; }
    }
}