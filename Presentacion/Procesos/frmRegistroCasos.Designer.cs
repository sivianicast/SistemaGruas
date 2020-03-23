namespace Presentacion.Procesos
{
	partial class frmRegistroCasos
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
            this.ubicacionCasolbl = new System.Windows.Forms.Label();
            this.kilometrajeCasolbl = new System.Windows.Forms.Label();
            this.GruaCasolbl = new System.Windows.Forms.Label();
            this.gruaCasotxt = new System.Windows.Forms.TextBox();
            this.ubicacionCasotxt = new System.Windows.Forms.TextBox();
            this.kilometrajeCasotxt = new System.Windows.Forms.TextBox();
            this.GruasCasodgv = new System.Windows.Forms.DataGridView();
            this.EstadoGrualbl = new System.Windows.Forms.Label();
            this.EstadoGruascbo = new System.Windows.Forms.ComboBox();
            this.cantidadServlbl = new System.Windows.Forms.Label();
            this.cabtServicioscbo = new System.Windows.Forms.ComboBox();
            this.buscarNumeroServiciosbtn = new System.Windows.Forms.Button();
            this.agregarCasobtn = new System.Windows.Forms.Button();
            this.modificarCasobtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GruasCasodgv)).BeginInit();
            this.SuspendLayout();
            // 
            // ubicacionCasolbl
            // 
            this.ubicacionCasolbl.AutoSize = true;
            this.ubicacionCasolbl.Location = new System.Drawing.Point(12, 42);
            this.ubicacionCasolbl.Name = "ubicacionCasolbl";
            this.ubicacionCasolbl.Size = new System.Drawing.Size(82, 13);
            this.ubicacionCasolbl.TabIndex = 0;
            this.ubicacionCasolbl.Text = "Ubicacion Caso";
            // 
            // kilometrajeCasolbl
            // 
            this.kilometrajeCasolbl.AutoSize = true;
            this.kilometrajeCasolbl.Location = new System.Drawing.Point(21, 78);
            this.kilometrajeCasolbl.Name = "kilometrajeCasolbl";
            this.kilometrajeCasolbl.Size = new System.Drawing.Size(58, 13);
            this.kilometrajeCasolbl.TabIndex = 1;
            this.kilometrajeCasolbl.Text = "Kilometraje";
            // 
            // GruaCasolbl
            // 
            this.GruaCasolbl.AutoSize = true;
            this.GruaCasolbl.Location = new System.Drawing.Point(36, 124);
            this.GruaCasolbl.Name = "GruaCasolbl";
            this.GruaCasolbl.Size = new System.Drawing.Size(30, 13);
            this.GruaCasolbl.TabIndex = 2;
            this.GruaCasolbl.Text = "Grua";
            // 
            // gruaCasotxt
            // 
            this.gruaCasotxt.Location = new System.Drawing.Point(110, 117);
            this.gruaCasotxt.Name = "gruaCasotxt";
            this.gruaCasotxt.Size = new System.Drawing.Size(76, 20);
            this.gruaCasotxt.TabIndex = 3;
            // 
            // ubicacionCasotxt
            // 
            this.ubicacionCasotxt.Location = new System.Drawing.Point(110, 42);
            this.ubicacionCasotxt.Name = "ubicacionCasotxt";
            this.ubicacionCasotxt.Size = new System.Drawing.Size(100, 20);
            this.ubicacionCasotxt.TabIndex = 4;
            // 
            // kilometrajeCasotxt
            // 
            this.kilometrajeCasotxt.Location = new System.Drawing.Point(110, 78);
            this.kilometrajeCasotxt.Name = "kilometrajeCasotxt";
            this.kilometrajeCasotxt.Size = new System.Drawing.Size(49, 20);
            this.kilometrajeCasotxt.TabIndex = 5;
            // 
            // GruasCasodgv
            // 
            this.GruasCasodgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GruasCasodgv.Location = new System.Drawing.Point(228, 42);
            this.GruasCasodgv.Name = "GruasCasodgv";
            this.GruasCasodgv.Size = new System.Drawing.Size(371, 95);
            this.GruasCasodgv.TabIndex = 6;
            this.GruasCasodgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GruasCasodgv_CellClick);
            // 
            // EstadoGrualbl
            // 
            this.EstadoGrualbl.AutoSize = true;
            this.EstadoGrualbl.Location = new System.Drawing.Point(225, 165);
            this.EstadoGrualbl.Name = "EstadoGrualbl";
            this.EstadoGrualbl.Size = new System.Drawing.Size(40, 13);
            this.EstadoGrualbl.TabIndex = 7;
            this.EstadoGrualbl.Text = "Estado";
            // 
            // EstadoGruascbo
            // 
            this.EstadoGruascbo.FormattingEnabled = true;
            this.EstadoGruascbo.Location = new System.Drawing.Point(271, 165);
            this.EstadoGruascbo.Name = "EstadoGruascbo";
            this.EstadoGruascbo.Size = new System.Drawing.Size(87, 21);
            this.EstadoGruascbo.TabIndex = 8;
            // 
            // cantidadServlbl
            // 
            this.cantidadServlbl.AutoSize = true;
            this.cantidadServlbl.Location = new System.Drawing.Point(380, 165);
            this.cantidadServlbl.Name = "cantidadServlbl";
            this.cantidadServlbl.Size = new System.Drawing.Size(87, 13);
            this.cantidadServlbl.TabIndex = 9;
            this.cantidadServlbl.Text = "Cant deServicios";
            // 
            // cabtServicioscbo
            // 
            this.cabtServicioscbo.FormattingEnabled = true;
            this.cabtServicioscbo.Location = new System.Drawing.Point(474, 165);
            this.cabtServicioscbo.Name = "cabtServicioscbo";
            this.cabtServicioscbo.Size = new System.Drawing.Size(41, 21);
            this.cabtServicioscbo.TabIndex = 10;
            // 
            // buscarNumeroServiciosbtn
            // 
            this.buscarNumeroServiciosbtn.Location = new System.Drawing.Point(540, 165);
            this.buscarNumeroServiciosbtn.Name = "buscarNumeroServiciosbtn";
            this.buscarNumeroServiciosbtn.Size = new System.Drawing.Size(59, 23);
            this.buscarNumeroServiciosbtn.TabIndex = 11;
            this.buscarNumeroServiciosbtn.Text = "Buscar";
            this.buscarNumeroServiciosbtn.UseVisualStyleBackColor = true;
            this.buscarNumeroServiciosbtn.Click += new System.EventHandler(this.buscarNumeroServiciosbtn_Click);
            // 
            // agregarCasobtn
            // 
            this.agregarCasobtn.Location = new System.Drawing.Point(15, 207);
            this.agregarCasobtn.Name = "agregarCasobtn";
            this.agregarCasobtn.Size = new System.Drawing.Size(75, 23);
            this.agregarCasobtn.TabIndex = 12;
            this.agregarCasobtn.Text = "Agregar";
            this.agregarCasobtn.UseVisualStyleBackColor = true;
            this.agregarCasobtn.Click += new System.EventHandler(this.agregarCasobtn_Click);
            // 
            // modificarCasobtn
            // 
            this.modificarCasobtn.Location = new System.Drawing.Point(96, 207);
            this.modificarCasobtn.Name = "modificarCasobtn";
            this.modificarCasobtn.Size = new System.Drawing.Size(75, 23);
            this.modificarCasobtn.TabIndex = 13;
            this.modificarCasobtn.Text = "Modificar";
            this.modificarCasobtn.UseVisualStyleBackColor = true;
            this.modificarCasobtn.Click += new System.EventHandler(this.modificarCasobtn_Click);
            // 
            // frmRegistroCasos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.modificarCasobtn);
            this.Controls.Add(this.agregarCasobtn);
            this.Controls.Add(this.buscarNumeroServiciosbtn);
            this.Controls.Add(this.cabtServicioscbo);
            this.Controls.Add(this.cantidadServlbl);
            this.Controls.Add(this.EstadoGruascbo);
            this.Controls.Add(this.EstadoGrualbl);
            this.Controls.Add(this.GruasCasodgv);
            this.Controls.Add(this.kilometrajeCasotxt);
            this.Controls.Add(this.ubicacionCasotxt);
            this.Controls.Add(this.gruaCasotxt);
            this.Controls.Add(this.GruaCasolbl);
            this.Controls.Add(this.kilometrajeCasolbl);
            this.Controls.Add(this.ubicacionCasolbl);
            this.Name = "frmRegistroCasos";
            this.Text = "frmRegistroCasos";
            ((System.ComponentModel.ISupportInitialize)(this.GruasCasodgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        #endregion

        private System.Windows.Forms.Label ubicacionCasolbl;
        private System.Windows.Forms.Label kilometrajeCasolbl;
        private System.Windows.Forms.Label GruaCasolbl;
        private System.Windows.Forms.TextBox gruaCasotxt;
        private System.Windows.Forms.TextBox ubicacionCasotxt;
        private System.Windows.Forms.TextBox kilometrajeCasotxt;
        private System.Windows.Forms.DataGridView GruasCasodgv;
        private System.Windows.Forms.Label EstadoGrualbl;
        private System.Windows.Forms.ComboBox EstadoGruascbo;
        private System.Windows.Forms.Label cantidadServlbl;
        private System.Windows.Forms.ComboBox cabtServicioscbo;
        private System.Windows.Forms.Button buscarNumeroServiciosbtn;
        private System.Windows.Forms.Button agregarCasobtn;
        private System.Windows.Forms.Button modificarCasobtn;
    }
}