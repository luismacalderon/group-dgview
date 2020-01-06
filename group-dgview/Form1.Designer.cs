namespace group_dgview
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.chkAgrupar = new System.Windows.Forms.CheckBox();
            this.chkContraerColapsar = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(495, 291);
            this.dataGridView1.TabIndex = 0;
            // 
            // chkAgrupar
            // 
            this.chkAgrupar.AutoSize = true;
            this.chkAgrupar.Location = new System.Drawing.Point(13, 23);
            this.chkAgrupar.Name = "chkAgrupar";
            this.chkAgrupar.Size = new System.Drawing.Size(63, 17);
            this.chkAgrupar.TabIndex = 1;
            this.chkAgrupar.Text = "Agrupar";
            this.chkAgrupar.UseVisualStyleBackColor = true;
            this.chkAgrupar.CheckedChanged += new System.EventHandler(this.chkAgrupar_CheckedChanged);
            // 
            // chkContraerColapsar
            // 
            this.chkContraerColapsar.AutoSize = true;
            this.chkContraerColapsar.Location = new System.Drawing.Point(112, 23);
            this.chkContraerColapsar.Name = "chkContraerColapsar";
            this.chkContraerColapsar.Size = new System.Drawing.Size(153, 17);
            this.chkContraerColapsar.TabIndex = 1;
            this.chkContraerColapsar.Text = "Contraer / Colapsar grupos";
            this.chkContraerColapsar.UseVisualStyleBackColor = true;
            this.chkContraerColapsar.CheckedChanged += new System.EventHandler(this.chkContraerColapsar_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(519, 349);
            this.Controls.Add(this.chkContraerColapsar);
            this.Controls.Add(this.chkAgrupar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Master Solutions - Luis Calderón - Enero 2020";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox chkAgrupar;
        private System.Windows.Forms.CheckBox chkContraerColapsar;
    }
}

