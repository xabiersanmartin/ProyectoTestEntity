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
    }
}
