﻿using CapaDatos;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    static class Program
    {
        public static Acceso acceso = new Acceso();
        public static Gestor gestor;
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            string msg = "";
            gestor = new Gestor(out msg);
            if (msg != "")
            {
                MessageBox.Show(msg);
                return;
            }
            Application.Run(new FrmPrincipal());
        }
    }
}
