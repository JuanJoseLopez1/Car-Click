namespace Presentacion
{
    partial class FormPagPrincipal
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
            this.dgvPublicacionesPagP = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPublicacionesPagP)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPublicacionesPagP
            // 
            this.dgvPublicacionesPagP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPublicacionesPagP.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPublicacionesPagP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPublicacionesPagP.Location = new System.Drawing.Point(12, 49);
            this.dgvPublicacionesPagP.Name = "dgvPublicacionesPagP";
            this.dgvPublicacionesPagP.Size = new System.Drawing.Size(810, 444);
            this.dgvPublicacionesPagP.TabIndex = 0;
            this.dgvPublicacionesPagP.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPublicacionesPagP_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Actualizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormPagPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 505);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvPublicacionesPagP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPagPrincipal";
            this.Text = "FormPagPrincipal";
            this.Load += new System.EventHandler(this.FormPagPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPublicacionesPagP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPublicacionesPagP;
        private System.Windows.Forms.Button button1;
    }
}