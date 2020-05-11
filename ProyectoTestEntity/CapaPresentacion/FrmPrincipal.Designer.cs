namespace CapaPresentacion
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPrincipal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.categoríasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.añadirCategoríaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarCategoríaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.añadirTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPrincipal
            // 
            this.btnPrincipal.Font = new System.Drawing.Font("Monotype Corsiva", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrincipal.Location = new System.Drawing.Point(322, 276);
            this.btnPrincipal.Name = "btnPrincipal";
            this.btnPrincipal.Size = new System.Drawing.Size(133, 66);
            this.btnPrincipal.TabIndex = 0;
            this.btnPrincipal.Text = "Formulario Principal";
            this.btnPrincipal.UseVisualStyleBackColor = true;
            this.btnPrincipal.Click += new System.EventHandler(this.btnPrincipal_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(145, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(486, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "BIENVENIDO AL PROGRAMA";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categoríasToolStripMenuItem,
            this.testsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // categoríasToolStripMenuItem
            // 
            this.categoríasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.añadirCategoríaToolStripMenuItem,
            this.modificarCategoríaToolStripMenuItem,
            this.eToolStripMenuItem});
            this.categoríasToolStripMenuItem.Name = "categoríasToolStripMenuItem";
            this.categoríasToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.categoríasToolStripMenuItem.Text = "Categorías";
            // 
            // testsToolStripMenuItem
            // 
            this.testsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.añadirTestToolStripMenuItem,
            this.modificarTestToolStripMenuItem,
            this.eliminarTestToolStripMenuItem});
            this.testsToolStripMenuItem.Name = "testsToolStripMenuItem";
            this.testsToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.testsToolStripMenuItem.Text = "Tests";
            // 
            // añadirCategoríaToolStripMenuItem
            // 
            this.añadirCategoríaToolStripMenuItem.Name = "añadirCategoríaToolStripMenuItem";
            this.añadirCategoríaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.añadirCategoríaToolStripMenuItem.Text = "Añadir categoría";
            this.añadirCategoríaToolStripMenuItem.Click += new System.EventHandler(this.añadirCategoríaToolStripMenuItem_Click);
            // 
            // modificarCategoríaToolStripMenuItem
            // 
            this.modificarCategoríaToolStripMenuItem.Name = "modificarCategoríaToolStripMenuItem";
            this.modificarCategoríaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.modificarCategoríaToolStripMenuItem.Text = "Modificar categoría";
            // 
            // eToolStripMenuItem
            // 
            this.eToolStripMenuItem.Name = "eToolStripMenuItem";
            this.eToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.eToolStripMenuItem.Text = "Eliminar categoría";
            // 
            // añadirTestToolStripMenuItem
            // 
            this.añadirTestToolStripMenuItem.Name = "añadirTestToolStripMenuItem";
            this.añadirTestToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.añadirTestToolStripMenuItem.Text = "Añadir Test";
            // 
            // modificarTestToolStripMenuItem
            // 
            this.modificarTestToolStripMenuItem.Name = "modificarTestToolStripMenuItem";
            this.modificarTestToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.modificarTestToolStripMenuItem.Text = "Modificar Test";
            // 
            // eliminarTestToolStripMenuItem
            // 
            this.eliminarTestToolStripMenuItem.Name = "eliminarTestToolStripMenuItem";
            this.eliminarTestToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.eliminarTestToolStripMenuItem.Text = "Eliminar Test";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPrincipal);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPrincipal";
            this.Text = "Formulario Bienvenida";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrincipal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem categoríasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem añadirCategoríaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarCategoríaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem añadirTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarTestToolStripMenuItem;
    }
}

