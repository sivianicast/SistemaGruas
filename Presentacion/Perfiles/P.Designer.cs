namespace Presentacion.Perfiles
{
    partial class P
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
            this.nombrePerfillbl = new System.Windows.Forms.Label();
            this.nombrePerfiltxt = new System.Windows.Forms.TextBox();
            this.PerfilesdataGridView = new System.Windows.Forms.DataGridView();
            this.AgregarPerfilesbtn = new System.Windows.Forms.Button();
            this.ActualizarPerfilesbtn = new System.Windows.Forms.Button();
            this.eliminarPerfilesbtn = new System.Windows.Forms.Button();
            this.busquedalbl = new System.Windows.Forms.Label();
            this.buscarPerfiltxt = new System.Windows.Forms.TextBox();
            this.buscarPerfil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PerfilesdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // nombrePerfillbl
            // 
            this.nombrePerfillbl.AutoSize = true;
            this.nombrePerfillbl.Location = new System.Drawing.Point(27, 36);
            this.nombrePerfillbl.Name = "nombrePerfillbl";
            this.nombrePerfillbl.Size = new System.Drawing.Size(44, 13);
            this.nombrePerfillbl.TabIndex = 0;
            this.nombrePerfillbl.Text = "Nombre";
            // 
            // nombrePerfiltxt
            // 
            this.nombrePerfiltxt.Location = new System.Drawing.Point(90, 33);
            this.nombrePerfiltxt.Name = "nombrePerfiltxt";
            this.nombrePerfiltxt.Size = new System.Drawing.Size(100, 20);
            this.nombrePerfiltxt.TabIndex = 1;
            // 
            // PerfilesdataGridView
            // 
            this.PerfilesdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PerfilesdataGridView.Location = new System.Drawing.Point(90, 105);
            this.PerfilesdataGridView.Name = "PerfilesdataGridView";
            this.PerfilesdataGridView.Size = new System.Drawing.Size(231, 150);
            this.PerfilesdataGridView.TabIndex = 2;
            this.PerfilesdataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PerfilesDataGridViewCell_click);
            this.PerfilesdataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PerfilesDataGridView_cellContentClick);
            // 
            // AgregarPerfilesbtn
            // 
            this.AgregarPerfilesbtn.Location = new System.Drawing.Point(215, 31);
            this.AgregarPerfilesbtn.Name = "AgregarPerfilesbtn";
            this.AgregarPerfilesbtn.Size = new System.Drawing.Size(75, 23);
            this.AgregarPerfilesbtn.TabIndex = 3;
            this.AgregarPerfilesbtn.Text = "Agregar";
            this.AgregarPerfilesbtn.UseVisualStyleBackColor = true;
            this.AgregarPerfilesbtn.Click += new System.EventHandler(this.AgregarPerfilesbtn_Click);
            // 
            // ActualizarPerfilesbtn
            // 
            this.ActualizarPerfilesbtn.Location = new System.Drawing.Point(344, 105);
            this.ActualizarPerfilesbtn.Name = "ActualizarPerfilesbtn";
            this.ActualizarPerfilesbtn.Size = new System.Drawing.Size(75, 23);
            this.ActualizarPerfilesbtn.TabIndex = 4;
            this.ActualizarPerfilesbtn.Text = "Actualizar";
            this.ActualizarPerfilesbtn.UseVisualStyleBackColor = true;
            this.ActualizarPerfilesbtn.Click += new System.EventHandler(this.ActualizarPerfilesbtn_Click_1);
            // 
            // eliminarPerfilesbtn
            // 
            this.eliminarPerfilesbtn.Location = new System.Drawing.Point(344, 147);
            this.eliminarPerfilesbtn.Name = "eliminarPerfilesbtn";
            this.eliminarPerfilesbtn.Size = new System.Drawing.Size(75, 23);
            this.eliminarPerfilesbtn.TabIndex = 5;
            this.eliminarPerfilesbtn.Text = "Eliminar";
            this.eliminarPerfilesbtn.UseVisualStyleBackColor = true;
            this.eliminarPerfilesbtn.Click += new System.EventHandler(this.eliminarPerfilesbtn_Click_1);
            // 
            // busquedalbl
            // 
            this.busquedalbl.AutoSize = true;
            this.busquedalbl.Location = new System.Drawing.Point(87, 277);
            this.busquedalbl.Name = "busquedalbl";
            this.busquedalbl.Size = new System.Drawing.Size(55, 13);
            this.busquedalbl.TabIndex = 6;
            this.busquedalbl.Text = "Busqueda";
            // 
            // buscarPerfiltxt
            // 
            this.buscarPerfiltxt.Location = new System.Drawing.Point(148, 274);
            this.buscarPerfiltxt.Name = "buscarPerfiltxt";
            this.buscarPerfiltxt.Size = new System.Drawing.Size(142, 20);
            this.buscarPerfiltxt.TabIndex = 7;
            // 
            // buscarPerfil
            // 
            this.buscarPerfil.Location = new System.Drawing.Point(331, 277);
            this.buscarPerfil.Name = "buscarPerfil";
            this.buscarPerfil.Size = new System.Drawing.Size(75, 23);
            this.buscarPerfil.TabIndex = 8;
            this.buscarPerfil.Text = "Buscar";
            this.buscarPerfil.UseVisualStyleBackColor = true;
            this.buscarPerfil.Click += new System.EventHandler(this.buscarPerfil_Click);
            // 
            // P
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 316);
            this.Controls.Add(this.buscarPerfil);
            this.Controls.Add(this.buscarPerfiltxt);
            this.Controls.Add(this.busquedalbl);
            this.Controls.Add(this.eliminarPerfilesbtn);
            this.Controls.Add(this.ActualizarPerfilesbtn);
            this.Controls.Add(this.AgregarPerfilesbtn);
            this.Controls.Add(this.PerfilesdataGridView);
            this.Controls.Add(this.nombrePerfiltxt);
            this.Controls.Add(this.nombrePerfillbl);
            this.Name = "P";
            this.Text = "Perfiles";
            ((System.ComponentModel.ISupportInitialize)(this.PerfilesdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nombrePerfillbl;
        private System.Windows.Forms.TextBox nombrePerfiltxt;
        private System.Windows.Forms.DataGridView PerfilesdataGridView;
        private System.Windows.Forms.Button AgregarPerfilesbtn;
        private System.Windows.Forms.Button ActualizarPerfilesbtn;
        private System.Windows.Forms.Button eliminarPerfilesbtn;
        private System.Windows.Forms.Label busquedalbl;
        private System.Windows.Forms.TextBox buscarPerfiltxt;
        private System.Windows.Forms.Button buscarPerfil;
    }
}