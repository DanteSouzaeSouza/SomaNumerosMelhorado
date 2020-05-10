namespace SomaNumerosMelhorado
{
    partial class FrmSoma
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
            this.lblNum = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblSoma = new System.Windows.Forms.Label();
            this.txtSoma = new System.Windows.Forms.TextBox();
            this.lblMultiplo = new System.Windows.Forms.Label();
            this.txtMultiplo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Location = new System.Drawing.Point(12, 12);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(66, 13);
            this.lblNum.TabIndex = 0;
            this.lblNum.Text = "Qtde. Somar";
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(97, 9);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(175, 20);
            this.txtNum.TabIndex = 1;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(15, 61);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(200, 61);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblSoma
            // 
            this.lblSoma.AutoSize = true;
            this.lblSoma.Location = new System.Drawing.Point(12, 87);
            this.lblSoma.Name = "lblSoma";
            this.lblSoma.Size = new System.Drawing.Size(34, 13);
            this.lblSoma.TabIndex = 0;
            this.lblSoma.Text = "Soma";
            // 
            // txtSoma
            // 
            this.txtSoma.Location = new System.Drawing.Point(15, 103);
            this.txtSoma.Name = "txtSoma";
            this.txtSoma.Size = new System.Drawing.Size(260, 20);
            this.txtSoma.TabIndex = 5;
            // 
            // lblMultiplo
            // 
            this.lblMultiplo.AutoSize = true;
            this.lblMultiplo.Location = new System.Drawing.Point(12, 36);
            this.lblMultiplo.Name = "lblMultiplo";
            this.lblMultiplo.Size = new System.Drawing.Size(43, 13);
            this.lblMultiplo.TabIndex = 0;
            this.lblMultiplo.Text = "Múltiplo";
            // 
            // txtMultiplo
            // 
            this.txtMultiplo.Location = new System.Drawing.Point(97, 33);
            this.txtMultiplo.Name = "txtMultiplo";
            this.txtMultiplo.Size = new System.Drawing.Size(175, 20);
            this.txtMultiplo.TabIndex = 2;
            // 
            // FrmSoma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 135);
            this.Controls.Add(this.txtMultiplo);
            this.Controls.Add(this.lblMultiplo);
            this.Controls.Add(this.txtSoma);
            this.Controls.Add(this.lblSoma);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.lblNum);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSoma";
            this.Text = "Digite até qual número Somar!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblSoma;
        private System.Windows.Forms.TextBox txtSoma;
        private System.Windows.Forms.Label lblMultiplo;
        private System.Windows.Forms.TextBox txtMultiplo;
    }
}

