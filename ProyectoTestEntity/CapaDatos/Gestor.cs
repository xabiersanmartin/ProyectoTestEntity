using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Gestor
    {
        TestXabierSanMartinEntities TestXabierSanMartinEntities;

        public Gestor(out string msg)
        {
            msg = "";
            try
            {
                TestXabierSanMartinEntities = new TestXabierSanMartinEntities();
            }
            catch (Exception ex)
            {
                msg = "No se a podido conectar con la base de datos, contacte con el administrador, código de error: "+ex.Message;
            }
        }

        public List<Categoria> DevolverCategorias()
        {
            return TestXabierSanMartinEntities.Categorias.ToList();
        }

        public string AnadirCategoria (string nombreCategoria)
        {

            Categoria buscarCategoria = TestXabierSanMartinEntities.Categorias.ToList().Where(cat => cat.Descripcion.ToLower() == nombreCategoria.ToLower()).SingleOrDefault();

            if (String.IsNullOrWhiteSpace(nombreCategoria))
            {
                return "El nombre de la categoría no puede estar vacio";
            }
            
            if (buscarCategoria != null)
            {
                return "No puedes añadir una categoría que ya existe";
            }

            Categoria nuevaCategoria = new Categoria(nombreCategoria);

            try
            {
                TestXabierSanMartinEntities.Categorias.Add(nuevaCategoria);

                int cambios = TestXabierSanMartinEntities.SaveChanges();
                if (cambios == 0) return "Error al añadir";
                return "Categoría añadida correctamente";
            }
            catch (Exception ex)
            {
                return "Error al añadir la categoría mensaje de error: "+ex.Message;
            }
        }

    }
}
