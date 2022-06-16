namespace P_Imc
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblAltura = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.mskbxAltura = new System.Windows.Forms.MaskedTextBox();
            this.mskbxPeso = new System.Windows.Forms.MaskedTextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(21, 27);
            this.lblAltura.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(52, 21);
            this.lblAltura.TabIndex = 0;
            this.lblAltura.Text = "Altura";
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(21, 85);
            this.lblPeso.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(42, 21);
            this.lblPeso.TabIndex = 1;
            this.lblPeso.Text = "Peso";
            // 
            // mskbxAltura
            // 
            this.mskbxAltura.Location = new System.Drawing.Point(100, 22);
            this.mskbxAltura.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.mskbxAltura.Mask = "0.00";
            this.mskbxAltura.Name = "mskbxAltura";
            this.mskbxAltura.Size = new System.Drawing.Size(337, 29);
            this.mskbxAltura.TabIndex = 2;
            this.mskbxAltura.Validated += new System.EventHandler(this.mskbxAltura_Validated);
            // 
            // mskbxPeso
            // 
            this.mskbxPeso.Location = new System.Drawing.Point(100, 80);
            this.mskbxPeso.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.mskbxPeso.Mask = "90.0";
            this.mskbxPeso.Name = "mskbxPeso";
            this.mskbxPeso.Size = new System.Drawing.Size(337, 29);
            this.mskbxPeso.TabIndex = 3;
            this.mskbxPeso.Validated += new System.EventHandler(this.mskbxPeso_Validated);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(23, 142);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(414, 39);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(23, 191);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(414, 38);
            this.btnLimpar.TabIndex = 5;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(23, 239);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(414, 40);
            this.btnFechar.TabIndex = 6;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 726);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.mskbxPeso);
            this.Controls.Add(this.mskbxAltura);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.lblAltura);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.Text = "IMC";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.MaskedTextBox mskbxAltura;
        private System.Windows.Forms.MaskedTextBox mskbxPeso;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnFechar;
    }
}

