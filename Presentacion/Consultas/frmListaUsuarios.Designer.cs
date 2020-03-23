namespace Presentacion.Consultas
{
	partial class frmListaUsuarios
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
            this.label1 = new System.Windows.Forms.Label();
            this.estadoUsuarioscbo = new System.Windows.Forms.ComboBox();
            this.UsuariosActivodataGridView1 = new System.Windows.Forms.DataGridView();
            this.buscarEstadoUsbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.UsuariosActivodataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Estado Usuario";
            // 
            // estadoUsuarioscbo
            // 
            this.estadoUsuarioscbo.FormattingEnabled = true;
            this.estadoUsuarioscbo.Location = new System.Drawing.Point(207, 55);
            this.estadoUsuarioscbo.Name = "estadoUsuarioscbo";
            this.estadoUsuarioscbo.Size = new System.Drawing.Size(121, 21);
            this.estadoUsuarioscbo.TabIndex = 1;
            // 
            // UsuariosActivodataGridView1
            // 
            this.UsuariosActivodataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsuariosActivodataGridView1.Location = new System.Drawing.Point(79, 151);
            this.UsuariosActivodataGridView1.Name = "UsuariosActivodataGridView1";
            this.UsuariosActivodataGridView1.Size = new System.Drawing.Size(417, 150);
            this.UsuariosActivodataGridView1.TabIndex = 2;
            this.UsuariosActivodataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UsuariosActivodataGridView1_CellContentClick);
            // 
            // buscarEstadoUsbtn
            // 
            this.buscarEstadoUsbtn.Location = new System.Drawing.Point(421, 55);
            this.buscarEstadoUsbtn.Name = "buscarEstadoUsbtn";
            this.buscarEstadoUsbtn.Size = new System.Drawing.Size(75, 23);
            this.buscarEstadoUsbtn.TabIndex = 3;
            this.buscarEstadoUsbtn.Text = "Buscar";
            this.buscarEstadoUsbtn.UseVisualStyleBackColor = true;
            this.buscarEstadoUsbtn.Click += new System.EventHandler(this.buscarEstadoUsbtn_Click);
            // 
            // frmListaUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buscarEstadoUsbtn);
            this.Controls.Add(this.UsuariosActivodataGridView1);
            this.Controls.Add(this.estadoUsuarioscbo);
            this.Controls.Add(this.label1);
            this.Name = "frmListaUsuarios";
            this.Text = "frmListaUsuarios";
            ((System.ComponentModel.ISupportInitialize)(this.UsuariosActivodataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox estadoUsuarioscbo;
        private System.Windows.Forms.DataGridView UsuariosActivodataGridView1;
        private System.Windows.Forms.Button buscarEstadoUsbtn;
    }
}