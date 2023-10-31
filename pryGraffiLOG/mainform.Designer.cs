namespace pryGraffiLOG
{
    partial class mainform
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblEstadoConexion = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnConectarBase = new System.Windows.Forms.Button();
            this.btnTraerDatos = new System.Windows.Forms.Button();
            this.DataGridViewLOG = new System.Windows.Forms.DataGridView();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewLOG)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblEstadoConexion});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblEstadoConexion
            // 
            this.lblEstadoConexion.Name = "lblEstadoConexion";
            this.lblEstadoConexion.Size = new System.Drawing.Size(112, 17);
            this.lblEstadoConexion.Text = "Estado de Conexión";
            // 
            // btnConectarBase
            // 
            this.btnConectarBase.Location = new System.Drawing.Point(12, 12);
            this.btnConectarBase.Name = "btnConectarBase";
            this.btnConectarBase.Size = new System.Drawing.Size(112, 27);
            this.btnConectarBase.TabIndex = 1;
            this.btnConectarBase.Text = "Conectar a la Base";
            this.btnConectarBase.UseVisualStyleBackColor = true;
            this.btnConectarBase.Click += new System.EventHandler(this.btnConectarBase_Click);
            // 
            // btnTraerDatos
            // 
            this.btnTraerDatos.Location = new System.Drawing.Point(12, 45);
            this.btnTraerDatos.Name = "btnTraerDatos";
            this.btnTraerDatos.Size = new System.Drawing.Size(112, 27);
            this.btnTraerDatos.TabIndex = 2;
            this.btnTraerDatos.Text = "Traer Datos";
            this.btnTraerDatos.UseVisualStyleBackColor = true;
            this.btnTraerDatos.Click += new System.EventHandler(this.btnTraerDatos_Click);
            // 
            // DataGridViewLOG
            // 
            this.DataGridViewLOG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewLOG.Location = new System.Drawing.Point(12, 90);
            this.DataGridViewLOG.Name = "DataGridViewLOG";
            this.DataGridViewLOG.Size = new System.Drawing.Size(240, 150);
            this.DataGridViewLOG.TabIndex = 3;
            // 
            // mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DataGridViewLOG);
            this.Controls.Add(this.btnTraerDatos);
            this.Controls.Add(this.btnConectarBase);
            this.Controls.Add(this.statusStrip1);
            this.Name = "mainform";
            this.Text = "Formulario principal";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewLOG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblEstadoConexion;
        private System.Windows.Forms.Button btnConectarBase;
        private System.Windows.Forms.Button btnTraerDatos;
        private System.Windows.Forms.DataGridView DataGridViewLOG;
    }
}

