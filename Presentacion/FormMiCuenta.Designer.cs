namespace Presentacion
{
    partial class FormMiCuenta
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtModNombre = new System.Windows.Forms.TextBox();
            this.txtModApellido = new System.Windows.Forms.TextBox();
            this.txtModTelefono = new System.Windows.Forms.TextBox();
            this.txtModContra = new System.Windows.Forms.TextBox();
            this.btnModificarUsuario = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "* Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(433, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "* Apellido:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(175, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "* Telefono:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(413, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "* Contraseña: ";
            // 
            // txtModNombre
            // 
            this.txtModNombre.Location = new System.Drawing.Point(251, 118);
            this.txtModNombre.Name = "txtModNombre";
            this.txtModNombre.Size = new System.Drawing.Size(100, 20);
            this.txtModNombre.TabIndex = 6;
            // 
            // txtModApellido
            // 
            this.txtModApellido.Location = new System.Drawing.Point(493, 118);
            this.txtModApellido.Name = "txtModApellido";
            this.txtModApellido.Size = new System.Drawing.Size(100, 20);
            this.txtModApellido.TabIndex = 7;
            // 
            // txtModTelefono
            // 
            this.txtModTelefono.Location = new System.Drawing.Point(251, 216);
            this.txtModTelefono.Name = "txtModTelefono";
            this.txtModTelefono.Size = new System.Drawing.Size(100, 20);
            this.txtModTelefono.TabIndex = 8;
            // 
            // txtModContra
            // 
            this.txtModContra.Location = new System.Drawing.Point(493, 216);
            this.txtModContra.Name = "txtModContra";
            this.txtModContra.Size = new System.Drawing.Size(100, 20);
            this.txtModContra.TabIndex = 10;
            // 
            // btnModificarUsuario
            // 
            this.btnModificarUsuario.Location = new System.Drawing.Point(375, 390);
            this.btnModificarUsuario.Name = "btnModificarUsuario";
            this.btnModificarUsuario.Size = new System.Drawing.Size(75, 23);
            this.btnModificarUsuario.TabIndex = 11;
            this.btnModificarUsuario.Text = "Modificar";
            this.btnModificarUsuario.UseVisualStyleBackColor = true;
            this.btnModificarUsuario.Click += new System.EventHandler(this.btnModificarUsuario_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(281, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(251, 24);
            this.label6.TabIndex = 12;
            this.label6.Text = "MODIFICAR INFORMACION";
            // 
            // FormMiCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(834, 505);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnModificarUsuario);
            this.Controls.Add(this.txtModContra);
            this.Controls.Add(this.txtModTelefono);
            this.Controls.Add(this.txtModApellido);
            this.Controls.Add(this.txtModNombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMiCuenta";
            this.Text = "0";
            this.Load += new System.EventHandler(this.FormCuenta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtModNombre;
        private System.Windows.Forms.TextBox txtModApellido;
        private System.Windows.Forms.TextBox txtModTelefono;
        private System.Windows.Forms.TextBox txtModContra;
        private System.Windows.Forms.Button btnModificarUsuario;
        private System.Windows.Forms.Label label6;
    }
}