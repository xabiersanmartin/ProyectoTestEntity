//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entidades
{
    using System;
    using System.Collections.Generic;
    
    public partial class Pregunta : IEquatable<Pregunta>
    {
        public int IdPregunta { get; set; }
        public string Enunciado { get; set; }
        public bool RespV { get; set; }
        public int IdTest { get; set; }

        public virtual Test Test { get; set; }

        public Pregunta()
        {
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Pregunta);
        }

        public bool Equals(Pregunta other)
        {
            return other != null &&
                   IdPregunta == other.IdPregunta;
        }

        public override int GetHashCode()
        {
            return -53795870 + IdPregunta.GetHashCode();
        }
    }
}