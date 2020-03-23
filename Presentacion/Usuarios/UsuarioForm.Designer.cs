namespace Presentacion.Usuarios
{
    partial class UsuarioForm
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
            this.nombreUsuarioslbl = new System.Windows.Forms.Label();
            this.claveUsuarioslbl = new System.Windows.Forms.Label();
            this.estadoUsuarioslbl = new System.Windows.Forms.Label();
            this.nombreUsuariotextBox = new System.Windows.Forms.TextBox();
            this.claveUsuariotxt = new System.Windows.Forms.TextBox();
            this.estadoUsuariotxt = new System.Windows.Forms.TextBox();
            this.perfilUsuariolbl = new System.Windows.Forms.Label();
            this.perfilUsuarioscbo = new System.Windows.Forms.ComboBox();
            this.Deletebtn = new System.Windows.Forms.Button();
            this.UpdateUsuariobtn = new System.Windows.Forms.Button();
            this.AddUsuariobtn = new System.Windows.Forms.Button();
            this.BuscarUsuariobtn = new System.Windows.Forms.Button();
            this.BusquedaUsuarioslbl = new System.Windows.Forms.Label();
            this.busacarUsuariotxt = new System.Windows.Forms.TextBox();
            this.UsuariosdataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.UsuariosdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // nombreUsuarioslbl
            // 
            this.nombreUsuarioslbl.AutoSize = true;
            this.nombreUsuarioslbl.Location = new System.Drawing.Point(22, 37);
            this.nombreUsuarioslbl.Name = "nombreUsuarioslbl";
            this.nombreUsuarioslbl.Size = new System.Drawing.Size(44, 13);
            this.nombreUsuarioslbl.TabIndex = 0;
            this.nombreUsuarioslbl.Text = "Nombre";
            // 
            // claveUsuarioslbl
            // 
            this.claveUsuarioslbl.AutoSize = true;
            this.claveUsuarioslbl.Location = new System.Drawing.Point(22, 71);
            this.claveUsuarioslbl.Name = "claveUsuarioslbl";
            this.claveUsuarioslbl.Size = new System.Drawing.Size(34, 13);
            this.claveUsuarioslbl.TabIndex = 1;
            this.claveUsuarioslbl.Text = "Clave";
            // 
            // estadoUsuarioslbl
            // 
            this.estadoUsuarioslbl.AutoSize = true;
            this.estadoUsuarioslbl.Location = new System.Drawing.Point(22, 114);
            this.estadoUsuarioslbl.Name = "estadoUsuarioslbl";
            this.estadoUsuarioslbl.Size = new System.Drawing.Size(40, 13);
            this.estadoUsuarioslbl.TabIndex = 2;
            this.estadoUsuarioslbl.Text = "Estado";
            // 
            // nombreUsuariotextBox
            // 
            this.nombreUsuariotextBox.Location = new System.Drawing.Point(98, 29);
            this.nombreUsuariotextBox.Name = "nombreUsuariotextBox";
            this.nombreUsuariotextBox.Size = new System.Drawing.Size(100, 20);
            this.nombreUsuariotextBox.TabIndex = 3;
            // 
            // claveUsuariotxt
            // 
            this.claveUsuariotxt.Location = new System.Drawing.Point(98, 71);
            this.claveUsuariotxt.Name = "claveUsuariotxt";
            this.claveUsuariotxt.Size = new System.Drawing.Size(100, 20);
            this.claveUsuariotxt.TabIndex = 4;
            // 
            // estadoUsuariotxt
            // 
            this.estadoUsuariotxt.Location = new System.Drawing.Point(98, 114);
            this.estadoUsuariotxt.Name = "estadoUsuariotxt";
            this.estadoUsuariotxt.Size = new System.Drawing.Size(100, 20);
            this.estadoUsuariotxt.TabIndex = 5;
            // 
            // perfilUsuariolbl
            // 
            this.perfilUsuariolbl.AutoSize = true;
            this.perfilUsuariolbl.Location = new System.Drawing.Point(22, 158);
            this.perfilUsuariolbl.Name = "perfilUsuariolbl";
            this.perfilUsuariolbl.Size = new System.Drawing.Size(30, 13);
            this.perfilUsuariolbl.TabIndex = 6;
            this.perfilUsuariolbl.Text = "Perfil";
            // 
            // perfilUsuarioscbo
            // 
            this.perfilUsuarioscbo.FormattingEnabled = true;
            this.perfilUsuarioscbo.Location = new System.Drawing.Point(98, 158);
            this.perfilUsuarioscbo.Name = "perfilUsuarioscbo";
            this.perfilUsuarioscbo.Size = new System.Drawing.Size(121, 21);
            this.perfilUsuarioscbo.TabIndex = 7;
            this.perfilUsuarioscbo.SelectedIndexChanged += new System.EventHandler(this.ComboPerfilSelected);
            this.perfilUsuarioscbo.SelectedValueChanged += new System.EventHandler(this.ComboPerfilSelected);
            // 
            // Deletebtn
            // 
            this.Deletebtn.Location = new System.Drawing.Point(12, 213);
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.Size = new System.Drawing.Size(75, 23);
            this.Deletebtn.TabIndex = 8;
            this.Deletebtn.Text = "Delete";
            this.Deletebtn.UseVisualStyleBackColor = true;
            this.Deletebtn.Click += new System.EventHandler(this.Deletebtn_Click);
            // 
            // UpdateUsuariobtn
            // 
            this.UpdateUsuariobtn.Location = new System.Drawing.Point(98, 213);
            this.UpdateUsuariobtn.Name = "UpdateUsuariobtn";
            this.UpdateUsuariobtn.Size = new System.Drawing.Size(75, 23);
            this.UpdateUsuariobtn.TabIndex = 9;
            this.UpdateUsuariobtn.Text = "Update";
            this.UpdateUsuariobtn.UseVisualStyleBackColor = true;
            this.UpdateUsuariobtn.Click += new System.EventHandler(this.UpdateUsuariobtn_Click);
            // 
            // AddUsuariobtn
            // 
            this.AddUsuariobtn.Location = new System.Drawing.Point(189, 213);
            this.AddUsuariobtn.Name = "AddUsuariobtn";
            this.AddUsuariobtn.Size = new System.Drawing.Size(75, 23);
            this.AddUsuariobtn.TabIndex = 10;
            this.AddUsuariobtn.Text = "Add";
            this.AddUsuariobtn.UseVisualStyleBackColor = true;
            this.AddUsuariobtn.Click += new System.EventHandler(this.AddUsuariobtn_Click);
            // 
            // BuscarUsuariobtn
            // 
            this.BuscarUsuariobtn.Location = new System.Drawing.Point(550, 214);
            this.BuscarUsuariobtn.Name = "BuscarUsuariobtn";
            this.BuscarUsuariobtn.Size = new System.Drawing.Size(75, 23);
            this.BuscarUsuariobtn.TabIndex = 11;
            this.BuscarUsuariobtn.Text = "Buscar";
            this.BuscarUsuariobtn.UseVisualStyleBackColor = true;
            this.BuscarUsuariobtn.Click += new System.EventHandler(this.BuscarUsuariobtn_Click);
            // 
            // BusquedaUsuarioslbl
            // 
            this.BusquedaUsuarioslbl.AutoSize = true;
            this.BusquedaUsuarioslbl.Location = new System.Drawing.Point(353, 218);
            this.BusquedaUsuarioslbl.Name = "BusquedaUsuarioslbl";
            this.BusquedaUsuarioslbl.Size = new System.Drawing.Size(55, 13);
            this.BusquedaUsuarioslbl.TabIndex = 12;
            this.BusquedaUsuarioslbl.Text = "Busqueda";
            // 
            // busacarUsuariotxt
            // 
            this.busacarUsuariotxt.Location = new System.Drawing.Point(425, 216);
            this.busacarUsuariotxt.Name = "busacarUsuariotxt";
            this.busacarUsuariotxt.Size = new System.Drawing.Size(100, 20);
            this.busacarUsuariotxt.TabIndex = 13;
            // 
            // UsuariosdataGridView
            // 
            this.UsuariosdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsuariosdataGridView.Location = new System.Drawing.Point(323, 29);
            this.UsuariosdataGridView.Name = "UsuariosdataGridView";
            this.UsuariosdataGridView.RowHeadersVisible = false;
            this.UsuariosdataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UsuariosdataGridView.Size = new System.Drawing.Size(330, 170);
            this.UsuariosdataGridView.TabIndex = 14;
            this.UsuariosdataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UsuariosdataGridView_CellClick);
            this.UsuariosdataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UsuariosdataGridView_CellContentClick);
            // 
            // UsuarioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UsuariosdataGridView);
            this.Controls.Add(this.busacarUsuariotxt);
            this.Controls.Add(this.BusquedaUsuarioslbl);
            this.Controls.Add(this.BuscarUsuariobtn);
            this.Controls.Add(this.AddUsuariobtn);
            this.Controls.Add(this.UpdateUsuariobtn);
            this.Controls.Add(this.Deletebtn);
            this.Controls.Add(this.perfilUsuarioscbo);
            this.Controls.Add(this.perfilUsuariolbl);
            this.Controls.Add(this.estadoUsuariotxt);
            this.Controls.Add(this.claveUsuariotxt);
            this.Controls.Add(this.nombreUsuariotextBox);
            this.Controls.Add(this.estadoUsuarioslbl);
            this.Controls.Add(this.claveUsuarioslbl);
            this.Controls.Add(this.nombreUsuarioslbl);
            this.Name = "UsuarioForm";
            this.Text = "UsuarioForm";
            this.Load += new System.EventHandler(this.UsuarioForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UsuariosdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nombreUsuarioslbl;
        private System.Windows.Forms.Label claveUsuarioslbl;
        private System.Windows.Forms.Label estadoUsuarioslbl;
        private System.Windows.Forms.TextBox nombreUsuariotextBox;
        private System.Windows.Forms.TextBox claveUsuariotxt;
        private System.Windows.Forms.TextBox estadoUsuariotxt;
        private System.Windows.Forms.Label perfilUsuariolbl;
        private System.Windows.Forms.ComboBox perfilUsuarioscbo;
        private System.Windows.Forms.Button Deletebtn;
        private System.Windows.Forms.Button UpdateUsuariobtn;
        private System.Windows.Forms.Button AddUsuariobtn;
        private System.Windows.Forms.Button BuscarUsuariobtn;
        private System.Windows.Forms.Label BusquedaUsuarioslbl;
        private System.Windows.Forms.TextBox busacarUsuariotxt;
        private System.Windows.Forms.DataGridView UsuariosdataGridView;
    //    private System.Windows.Forms.TextBox pruebatxt;
    //    private System.Windows.Forms.Button button1;
    }
}