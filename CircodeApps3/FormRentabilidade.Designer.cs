
namespace CircodeApps3
{
    partial class FormRentabilidade
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
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblDeposito = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblValor2 = new System.Windows.Forms.Label();
            this.lblRendimento = new System.Windows.Forms.Label();
            this.lblValor3 = new System.Windows.Forms.Label();
            this.lblRendimento2 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTotal2 = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(206, 25);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblDeposito
            // 
            this.lblDeposito.AutoSize = true;
            this.lblDeposito.Location = new System.Drawing.Point(12, 9);
            this.lblDeposito.Name = "lblDeposito";
            this.lblDeposito.Size = new System.Drawing.Size(88, 13);
            this.lblDeposito.TabIndex = 1;
            this.lblDeposito.Text = "Valor Depositado";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(12, 25);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(176, 20);
            this.txtValor.TabIndex = 2;
            // 
            // lblValor2
            // 
            this.lblValor2.AutoSize = true;
            this.lblValor2.Location = new System.Drawing.Point(15, 117);
            this.lblValor2.Name = "lblValor2";
            this.lblValor2.Size = new System.Drawing.Size(91, 13);
            this.lblValor2.TabIndex = 3;
            this.lblValor2.Text = "Valor Depositado:";
            // 
            // lblRendimento
            // 
            this.lblRendimento.AutoSize = true;
            this.lblRendimento.Location = new System.Drawing.Point(15, 154);
            this.lblRendimento.Name = "lblRendimento";
            this.lblRendimento.Size = new System.Drawing.Size(67, 13);
            this.lblRendimento.TabIndex = 4;
            this.lblRendimento.Text = "Rendimento:";
            // 
            // lblValor3
            // 
            this.lblValor3.AutoSize = true;
            this.lblValor3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor3.Location = new System.Drawing.Point(124, 117);
            this.lblValor3.Name = "lblValor3";
            this.lblValor3.Size = new System.Drawing.Size(0, 13);
            this.lblValor3.TabIndex = 5;
            // 
            // lblRendimento2
            // 
            this.lblRendimento2.AutoSize = true;
            this.lblRendimento2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRendimento2.Location = new System.Drawing.Point(89, 154);
            this.lblRendimento2.Name = "lblRendimento2";
            this.lblRendimento2.Size = new System.Drawing.Size(0, 13);
            this.lblRendimento2.TabIndex = 6;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(15, 189);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(34, 13);
            this.lblTotal.TabIndex = 7;
            this.lblTotal.Text = "Total:";
            // 
            // lblTotal2
            // 
            this.lblTotal2.AutoSize = true;
            this.lblTotal2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal2.Location = new System.Drawing.Point(65, 189);
            this.lblTotal2.Name = "lblTotal2";
            this.lblTotal2.Size = new System.Drawing.Size(0, 13);
            this.lblTotal2.TabIndex = 8;
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(206, 75);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 9;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // FormRentabilidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 229);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.lblTotal2);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblRendimento2);
            this.Controls.Add(this.lblValor3);
            this.Controls.Add(this.lblRendimento);
            this.Controls.Add(this.lblValor2);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.lblDeposito);
            this.Controls.Add(this.btnCalcular);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormRentabilidade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rentabilidade Anual da Poupança";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblDeposito;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblValor2;
        private System.Windows.Forms.Label lblRendimento;
        private System.Windows.Forms.Label lblValor3;
        private System.Windows.Forms.Label lblRendimento2;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTotal2;
        private System.Windows.Forms.Button btnSair;
    }
}