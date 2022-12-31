namespace C_Presentacion.FormulariosProyecto.Cliente
{
    partial class ConsultarCliente
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
            this.label13 = new System.Windows.Forms.Label();
            this.apellido = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.DTRegO = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DTRegO)).BeginInit();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(30, 44);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(92, 13);
            this.label13.TabIndex = 43;
            this.label13.Text = "Nombre(Opcional)";
            // 
            // apellido
            // 
            this.apellido.AutoSize = true;
            this.apellido.Location = new System.Drawing.Point(280, 44);
            this.apellido.Name = "apellido";
            this.apellido.Size = new System.Drawing.Size(106, 13);
            this.apellido.TabIndex = 42;
            this.apellido.Text = "Apellido(Obligatorio): ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(388, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(128, 20);
            this.textBox1.TabIndex = 41;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(128, 41);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(128, 20);
            this.txtBuscar.TabIndex = 40;
            // 
            // DTRegO
            // 
            this.DTRegO.BackgroundColor = System.Drawing.Color.White;
            this.DTRegO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTRegO.Location = new System.Drawing.Point(12, 77);
            this.DTRegO.Name = "DTRegO";
            this.DTRegO.Size = new System.Drawing.Size(543, 163);
            this.DTRegO.TabIndex = 39;
            // 
            // ConsultarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(592, 268);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.apellido);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.DTRegO);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ConsultarCliente";
            this.Text = "ConsultarCliente";
            ((System.ComponentModel.ISupportInitialize)(this.DTRegO)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label apellido;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.DataGridView DTRegO;
    }
}