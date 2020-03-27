namespace Presentacion
{
    partial class FormMisPublicaciones
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
            this.dgvPublicacionesP = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btnModPublicacion = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPublicacionesP)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPublicacionesP
            // 
            this.dgvPublicacionesP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPublicacionesP.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPublicacionesP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPublicacionesP.Location = new System.Drawing.Point(12, 40);
            this.dgvPublicacionesP.Name = "dgvPublicacionesP";
            this.dgvPublicacionesP.RowHeadersVisible = false;
            this.dgvPublicacionesP.Size = new System.Drawing.Size(810, 453);
            this.dgvPublicacionesP.TabIndex = 0;
            this.dgvPublicacionesP.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPublicacionesP_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(314, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mis publicaciones";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(141, 8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Eliminar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnModPublicacion
            // 
            this.btnModPublicacion.Location = new System.Drawing.Point(29, 8);
            this.btnModPublicacion.Name = "btnModPublicacion";
            this.btnModPublicacion.Size = new System.Drawing.Size(75, 23);
            this.btnModPublicacion.TabIndex = 5;
            this.btnModPublicacion.Text = "Modificar";
            this.btnModPublicacion.UseVisualStyleBackColor = true;
            this.btnModPublicacion.Click += new System.EventHandler(this.btnModPublicacion_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(747, 8);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 6;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // FormMisPublicaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 505);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnModPublicacion);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPublicacionesP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMisPublicaciones";
            this.Text = "FormPublicaciones";
            this.Load += new System.EventHandler(this.FormMisPublicaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPublicacionesP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPublicacionesP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnModPublicacion;
        private System.Windows.Forms.Button btnActualizar;
    }
}