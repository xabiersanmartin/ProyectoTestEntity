using CapaDatos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Acceso
    {
        Gestor nuevoAcceso = new Gestor(out string msg);

        public List<Categoria> DevolverCategorias()
        {
            return nuevoAcceso.DevolverCategorias();
        }

        public string AnadirCategoria(string nombreCategoria)
        {
            return nuevoAcceso.AnadirCategoria(nombreCategoria);
        }
    }
}
