
namespace CircodeApps3
{
    partial class FormMediaConsumo
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
            this.lblDistancia = new System.Windows.Forms.Label();
            this.txtDistancia = new System.Windows.Forms.TextBox();
            this.txtLitros = new System.Windows.Forms.TextBox();
            this.lblLitros = new System.Windows.Forms.Label();
            this.lblMedia = new System.Windows.Forms.Label();
            this.lblGasto = new System.Windows.Forms.Label();
            this.lblConsumo = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblCombustivel = new System.Windows.Forms.Label();
            this.cbxCombustivel = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(210, 25);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblDistancia
            // 
            this.lblDistancia.AutoSize = true;
            this.lblDistancia.Location = new System.Drawing.Point(12, 9);
            this.lblDistancia.Name = "lblDistancia";
            this.lblDistancia.Size = new System.Drawing.Size(126, 13);
            this.lblDistancia.TabIndex = 1;
            this.lblDistancia.Text = "Distância Percorrida (Km)";
            // 
            // txtDistancia
            // 
            this.txtDistancia.Location = new System.Drawing.Point(12, 25);
            this.txtDistancia.Name = "txtDistancia";
            this.txtDistancia.Size = new System.Drawing.Size(162, 20);
            this.txtDistancia.TabIndex = 2;
            // 
            // txtLitros
            // 
            this.txtLitros.Location = new System.Drawing.Point(12, 75);
            this.txtLitros.Name = "txtLitros";
            this.txtLitros.Size = new System.Drawing.Size(162, 20);
            this.txtLitros.TabIndex = 4;
            // 
            // lblLitros
            // 
            this.lblLitros.AutoSize = true;
            this.lblLitros.Location = new System.Drawing.Point(12, 59);
            this.lblLitros.Name = "lblLitros";
            this.lblLitros.Size = new System.Drawing.Size(126, 13);
            this.lblLitros.TabIndex = 3;
            this.lblLitros.Text = "Litros Consumidos (Litros)";
            // 
            // lblMedia
            // 
            this.lblMedia.AutoSize = true;
            this.lblMedia.Location = new System.Drawing.Point(12, 161);
            this.lblMedia.Name = "lblMedia";
            this.lblMedia.Size = new System.Drawing.Size(101, 13);
            this.lblMedia.TabIndex = 5;
            this.lblMedia.Text = "Média de Consumo:";
            // 
            // lblGasto
            // 
            this.lblGasto.AutoSize = true;
            this.lblGasto.Location = new System.Drawing.Point(9, 193);
            this.lblGasto.Name = "lblGasto";
            this.lblGasto.Size = new System.Drawing.Size(65, 13);
            this.lblGasto.TabIndex = 6;
            this.lblGasto.Text = "Gasto Total:";
            // 
            // lblConsumo
            // 
            this.lblConsumo.AutoSize = true;
            this.lblConsumo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsumo.Location = new System.Drawing.Point(119, 161);
            this.lblConsumo.Name = "lblConsumo";
            this.lblConsumo.Size = new System.Drawing.Size(0, 13);
            this.lblConsumo.TabIndex = 7;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(80, 193);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 13);
            this.lblTotal.TabIndex = 8;
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(210, 72);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 9;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblCombustivel
            // 
            this.lblCombustivel.AutoSize = true;
            this.lblCombustivel.Location = new System.Drawing.Point(12, 109);
            this.lblCombustivel.Name = "lblCombustivel";
            this.lblCombustivel.Size = new System.Drawing.Size(64, 13);
            this.lblCombustivel.TabIndex = 10;
            this.lblCombustivel.Text = "Combústivel";
            // 
            // cbxCombustivel
            // 
            this.cbxCombustivel.FormattingEnabled = true;
            this.cbxCombustivel.Items.AddRange(new object[] {
            "Gasolina",
            "Álcool"});
            this.cbxCombustivel.Location = new System.Drawing.Point(12, 125);
            this.cbxCombustivel.Name = "cbxCombustivel";
            this.cbxCombustivel.Size = new System.Drawing.Size(162, 21);
            this.cbxCombustivel.TabIndex = 11;
            // 
            // FormMediaConsumo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 229);
            this.Controls.Add(this.cbxCombustivel);
            this.Controls.Add(this.lblCombustivel);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblConsumo);
            this.Controls.Add(this.lblGasto);
            this.Controls.Add(this.lblMedia);
            this.Controls.Add(this.txtLitros);
            this.Controls.Add(this.lblLitros);
            this.Controls.Add(this.txtDistancia);
            this.Controls.Add(this.lblDistancia);
            this.Controls.Add(this.btnCalcular);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMediaConsumo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cálculo da Média de Consumo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblDistancia;
        private System.Windows.Forms.TextBox txtDistancia;
        private System.Windows.Forms.TextBox txtLitros;
        private System.Windows.Forms.Label lblLitros;
        private System.Windows.Forms.Label lblMedia;
        private System.Windows.Forms.Label lblGasto;
        private System.Windows.Forms.Label lblConsumo;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblCombustivel;
        private System.Windows.Forms.ComboBox cbxCombustivel;
    }
}