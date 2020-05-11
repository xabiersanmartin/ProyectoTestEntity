namespace CapaPresentacion
{
    partial class FrmAnadirCategoria
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNombreCategoria = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAnadirCategoria = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lstCategorias = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtNombreCategoria
            // 
            this.txtNombreCategoria.Location = new System.Drawing.Point(199, 226);
            this.txtNombreCategoria.Name = "txtNombreCategoria";
            this.txtNombreCategoria.Size = new System.Drawing.Size(262, 22);
            this.txtNombreCategoria.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(134, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "AÑADIR CATEGORÍA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre categoría";
            // 
            // btnAnadirCategoria
            // 
            this.btnAnadirCategoria.Location = new System.Drawing.Point(258, 304);
            this.btnAnadirCategoria.Name = "btnAnadirCategoria";
            this.btnAnadirCategoria.Size = new System.Drawing.Size(97, 44);
            this.btnAnadirCategoria.TabIndex = 3;
            this.btnAnadirCategoria.Text = "&Añadir Categoría";
            this.btnAnadirCategoria.UseVisualStyleBackColor = true;
            this.btnAnadirCategoria.Click += new System.EventHandler(this.btnAnadirCategoria_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(12, 477);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(97, 44);
            this.btnVolver.TabIndex = 4;
            this.btnVolver.Text = "&Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(762, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(356, 37);
            this.label3.TabIndex = 5;
            this.label3.Text = "CATEGORÍAS EXISTENTES";
            // 
            // lstCategorias
            // 
            this.lstCategorias.FormattingEnabled = true;
            this.lstCategorias.ItemHeight = 16;
            this.lstCategorias.Location = new System.Drawing.Point(808, 179);
            this.lstCategorias.Name = "lstCategorias";
            this.lstCategorias.Size = new System.Drawing.Size(290, 212);
            this.lstCategorias.TabIndex = 6;
            // 
            // FrmAnadirCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 533);
            this.Controls.Add(this.lstCategorias);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnAnadirCategoria);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombreCategoria);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FrmAnadirCategoria";
            this.Text = "Formulario añadir categoría";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmAnadirCategoria_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombreCategoria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAnadirCategoria;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstCategorias;
    }
}