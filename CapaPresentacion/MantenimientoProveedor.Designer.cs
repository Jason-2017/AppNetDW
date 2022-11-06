namespace CapaPresentacion
{
    partial class MantenimientoProveedor
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblMantProvAccError = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnMantProvEliminar = new System.Windows.Forms.Button();
            this.btnMantProvModificar = new System.Windows.Forms.Button();
            this.btnMantProvAgregar = new System.Windows.Forms.Button();
            this.dgvMantProv = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMantProvNomRazSocial = new System.Windows.Forms.TextBox();
            this.txtMantProvNIT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMantProv)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.dgvMantProv);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1031, 483);
            this.panel1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.lblMantProvAccError);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(527, 419);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(492, 48);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Acciones / Errores";
            // 
            // lblMantProvAccError
            // 
            this.lblMantProvAccError.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMantProvAccError.AutoSize = true;
            this.lblMantProvAccError.Location = new System.Drawing.Point(6, 19);
            this.lblMantProvAccError.Name = "lblMantProvAccError";
            this.lblMantProvAccError.Size = new System.Drawing.Size(44, 16);
            this.lblMantProvAccError.TabIndex = 0;
            this.lblMantProvAccError.Text = "label3";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.btnMantProvEliminar);
            this.groupBox2.Controls.Add(this.btnMantProvModificar);
            this.groupBox2.Controls.Add(this.btnMantProvAgregar);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(17, 418);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(503, 49);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Acciones";
            // 
            // btnMantProvEliminar
            // 
            this.btnMantProvEliminar.ForeColor = System.Drawing.Color.Black;
            this.btnMantProvEliminar.Location = new System.Drawing.Point(266, 13);
            this.btnMantProvEliminar.Name = "btnMantProvEliminar";
            this.btnMantProvEliminar.Size = new System.Drawing.Size(86, 30);
            this.btnMantProvEliminar.TabIndex = 2;
            this.btnMantProvEliminar.Text = "Eliminar";
            this.btnMantProvEliminar.UseVisualStyleBackColor = true;
            // 
            // btnMantProvModificar
            // 
            this.btnMantProvModificar.ForeColor = System.Drawing.Color.Black;
            this.btnMantProvModificar.Location = new System.Drawing.Point(173, 13);
            this.btnMantProvModificar.Name = "btnMantProvModificar";
            this.btnMantProvModificar.Size = new System.Drawing.Size(86, 30);
            this.btnMantProvModificar.TabIndex = 1;
            this.btnMantProvModificar.Text = "Modificar";
            this.btnMantProvModificar.UseVisualStyleBackColor = true;
            // 
            // btnMantProvAgregar
            // 
            this.btnMantProvAgregar.ForeColor = System.Drawing.Color.Black;
            this.btnMantProvAgregar.Location = new System.Drawing.Point(80, 13);
            this.btnMantProvAgregar.Name = "btnMantProvAgregar";
            this.btnMantProvAgregar.Size = new System.Drawing.Size(86, 30);
            this.btnMantProvAgregar.TabIndex = 0;
            this.btnMantProvAgregar.Text = "Agregar";
            this.btnMantProvAgregar.UseVisualStyleBackColor = true;
            this.btnMantProvAgregar.Click += new System.EventHandler(this.btnMantProvAgregar_Click);
            // 
            // dgvMantProv
            // 
            this.dgvMantProv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMantProv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMantProv.Location = new System.Drawing.Point(17, 165);
            this.dgvMantProv.Name = "dgvMantProv";
            this.dgvMantProv.RowHeadersWidth = 51;
            this.dgvMantProv.RowTemplate.Height = 24;
            this.dgvMantProv.Size = new System.Drawing.Size(1002, 247);
            this.dgvMantProv.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtMantProvNomRazSocial);
            this.groupBox1.Controls.Add(this.txtMantProvNIT);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(17, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1002, 142);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Proveedor";
            // 
            // txtMantProvNomRazSocial
            // 
            this.txtMantProvNomRazSocial.Location = new System.Drawing.Point(173, 53);
            this.txtMantProvNomRazSocial.Name = "txtMantProvNomRazSocial";
            this.txtMantProvNomRazSocial.Size = new System.Drawing.Size(330, 22);
            this.txtMantProvNomRazSocial.TabIndex = 3;
            // 
            // txtMantProvNIT
            // 
            this.txtMantProvNIT.Location = new System.Drawing.Point(173, 22);
            this.txtMantProvNIT.Name = "txtMantProvNIT";
            this.txtMantProvNIT.Size = new System.Drawing.Size(330, 22);
            this.txtMantProvNIT.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre o Razón Social";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "NIT:";
            // 
            // MantenimientoProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1056, 508);
            this.Controls.Add(this.panel1);
            this.Name = "MantenimientoProveedor";
            this.Text = "Mantenimiento Proveedor";
            this.Load += new System.EventHandler(this.MantenimientoProveedor_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMantProv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnMantProvEliminar;
        private System.Windows.Forms.Button btnMantProvModificar;
        private System.Windows.Forms.Button btnMantProvAgregar;
        private System.Windows.Forms.DataGridView dgvMantProv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMantProvNomRazSocial;
        private System.Windows.Forms.TextBox txtMantProvNIT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblMantProvAccError;
    }
}