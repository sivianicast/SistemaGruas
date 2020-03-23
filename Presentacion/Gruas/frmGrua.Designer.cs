namespace Presentacion.Gruas
{
    partial class frmGrua
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbEstadogGrua = new System.Windows.Forms.ComboBox();
            this.cbIdChofer = new System.Windows.Forms.ComboBox();
            this.tbUbicacion = new System.Windows.Forms.TextBox();
            this.tbIdGrua = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.bntClear = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.dgGruas = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgGruas)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbEstadogGrua);
            this.groupBox1.Controls.Add(this.cbIdChofer);
            this.groupBox1.Controls.Add(this.tbUbicacion);
            this.groupBox1.Controls.Add(this.tbIdGrua);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.bntClear);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(21, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(301, 253);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // cbEstadogGrua
            // 
            this.cbEstadogGrua.FormattingEnabled = true;
            this.cbEstadogGrua.Location = new System.Drawing.Point(114, 155);
            this.cbEstadogGrua.Name = "cbEstadogGrua";
            this.cbEstadogGrua.Size = new System.Drawing.Size(121, 21);
            this.cbEstadogGrua.TabIndex = 15;
            // 
            // cbIdChofer
            // 
            this.cbIdChofer.FormattingEnabled = true;
            this.cbIdChofer.Location = new System.Drawing.Point(114, 57);
            this.cbIdChofer.Name = "cbIdChofer";
            this.cbIdChofer.Size = new System.Drawing.Size(121, 21);
            this.cbIdChofer.TabIndex = 14;
            // 
            // tbUbicacion
            // 
            this.tbUbicacion.Location = new System.Drawing.Point(114, 105);
            this.tbUbicacion.Name = "tbUbicacion";
            this.tbUbicacion.Size = new System.Drawing.Size(121, 20);
            this.tbUbicacion.TabIndex = 13;
            // 
            // tbIdGrua
            // 
            this.tbIdGrua.Enabled = false;
            this.tbIdGrua.Location = new System.Drawing.Point(114, 14);
            this.tbIdGrua.Name = "tbIdGrua";
            this.tbIdGrua.Size = new System.Drawing.Size(100, 20);
            this.tbIdGrua.TabIndex = 12;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(203, 218);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(60, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Estado Grua";
            // 
            // bntClear
            // 
            this.bntClear.Location = new System.Drawing.Point(29, 218);
            this.bntClear.Name = "bntClear";
            this.bntClear.Size = new System.Drawing.Size(63, 23);
            this.bntClear.TabIndex = 2;
            this.bntClear.Text = "Clear";
            this.bntClear.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ubicacion";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(114, 218);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(64, 23);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Id Chofer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Id Grua";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(539, 26);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(350, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Buscar";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(419, 28);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(100, 20);
            this.tbSearch.TabIndex = 13;
            // 
            // dgGruas
            // 
            this.dgGruas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgGruas.Location = new System.Drawing.Point(353, 54);
            this.dgGruas.Name = "dgGruas";
            this.dgGruas.Size = new System.Drawing.Size(528, 384);
            this.dgGruas.TabIndex = 14;
            // 
            // frmGrua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 450);
            this.Controls.Add(this.dgGruas);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmGrua";
            this.Text = "Administracion Gruas";
            this.Load += new System.EventHandler(this.frmGrua_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgGruas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bntClear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbEstadogGrua;
        private System.Windows.Forms.ComboBox cbIdChofer;
        private System.Windows.Forms.TextBox tbUbicacion;
        private System.Windows.Forms.TextBox tbIdGrua;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.DataGridView dgGruas;
    }
}