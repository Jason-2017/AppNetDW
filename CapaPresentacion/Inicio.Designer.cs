namespace CapaPresentacion
{
    partial class Inicio
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Contraseña = new System.Windows.Forms.TextBox();
            this.Usuario = new System.Windows.Forms.TextBox();
            this.btnIniciarS = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(275, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Contraseña";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(275, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Usuario";
            // 
            // Contraseña
            // 
            this.Contraseña.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contraseña.Location = new System.Drawing.Point(497, 306);
            this.Contraseña.Name = "Contraseña";
            this.Contraseña.PasswordChar = '*';
            this.Contraseña.Size = new System.Drawing.Size(303, 34);
            this.Contraseña.TabIndex = 6;
            // 
            // Usuario
            // 
            this.Usuario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usuario.Location = new System.Drawing.Point(498, 248);
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(302, 34);
            this.Usuario.TabIndex = 5;
            this.Usuario.TextChanged += new System.EventHandler(this.Usuario_TextChanged);
            // 
            // btnIniciarS
            // 
            this.btnIniciarS.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarS.Location = new System.Drawing.Point(447, 401);
            this.btnIniciarS.Name = "btnIniciarS";
            this.btnIniciarS.Size = new System.Drawing.Size(201, 43);
            this.btnIniciarS.TabIndex = 5;
            this.btnIniciarS.Text = "Iniciar sesión";
            this.btnIniciarS.UseVisualStyleBackColor = true;
            this.btnIniciarS.Click += new System.EventHandler(this.btnIniciarS_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.Seguro;
            this.pictureBox1.Location = new System.Drawing.Point(36, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(230, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1018, 604);
            this.Controls.Add(this.btnIniciarS);
            this.Controls.Add(this.Contraseña);
            this.Controls.Add(this.Usuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Inicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Contraseña;
        private System.Windows.Forms.TextBox Usuario;
        private System.Windows.Forms.Button btnIniciarS;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}