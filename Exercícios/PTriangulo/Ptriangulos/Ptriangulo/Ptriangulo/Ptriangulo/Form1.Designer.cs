namespace Ptriangulo
{
    partial class Form1
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
            this.lblA = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.lblC = new System.Windows.Forms.Label();
            this.txtbxA = new System.Windows.Forms.TextBox();
            this.txtbxB = new System.Windows.Forms.TextBox();
            this.txtbxC = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(14, 24);
            this.lblA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(61, 21);
            this.lblA.TabIndex = 0;
            this.lblA.Text = "Lado A:";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(14, 94);
            this.lblB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(60, 21);
            this.lblB.TabIndex = 1;
            this.lblB.Text = "Lado B:";
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Location = new System.Drawing.Point(14, 163);
            this.lblC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(61, 21);
            this.lblC.TabIndex = 2;
            this.lblC.Text = "Lado C:";
            // 
            // txtbxA
            // 
            this.txtbxA.Location = new System.Drawing.Point(75, 19);
            this.txtbxA.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbxA.Name = "txtbxA";
            this.txtbxA.Size = new System.Drawing.Size(530, 29);
            this.txtbxA.TabIndex = 3;
            this.txtbxA.Validated += new System.EventHandler(this.txtbxA_Validated);
            // 
            // txtbxB
            // 
            this.txtbxB.Location = new System.Drawing.Point(75, 89);
            this.txtbxB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbxB.Name = "txtbxB";
            this.txtbxB.Size = new System.Drawing.Size(530, 29);
            this.txtbxB.TabIndex = 4;
            this.txtbxB.Validated += new System.EventHandler(this.txtbxB_Validated);
            // 
            // txtbxC
            // 
            this.txtbxC.Location = new System.Drawing.Point(75, 158);
            this.txtbxC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbxC.Name = "txtbxC";
            this.txtbxC.Size = new System.Drawing.Size(530, 29);
            this.txtbxC.TabIndex = 5;
            this.txtbxC.Validated += new System.EventHandler(this.txtbxC_Validated);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(18, 216);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(590, 69);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(18, 315);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(590, 69);
            this.btnLimpar.TabIndex = 7;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(18, 413);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(590, 69);
            this.btnFechar.TabIndex = 8;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1026);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtbxC);
            this.Controls.Add(this.txtbxB);
            this.Controls.Add(this.txtbxA);
            this.Controls.Add(this.lblC);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblA);
            this.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Projeto Triângulos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.TextBox txtbxA;
        private System.Windows.Forms.TextBox txtbxB;
        private System.Windows.Forms.TextBox txtbxC;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnFechar;
    }
}

