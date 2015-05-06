namespace CEF
{
    partial class GerarUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GerarUI));
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtValor_Contrato = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQtde = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtVencimento = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtObs1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtObs2 = new System.Windows.Forms.TextBox();
            this.txtObs3 = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblVencimentos = new System.Windows.Forms.Label();
            this.btnGerar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.txtValor_Bruto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.chkTravar = new System.Windows.Forms.CheckBox();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCliente
            // 
            this.txtCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCliente.Location = new System.Drawing.Point(12, 25);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(94, 26);
            this.txtCliente.TabIndex = 0;
            this.txtCliente.Leave += new System.EventHandler(this.txtCliente_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cliente";
            // 
            // txtValor_Contrato
            // 
            this.txtValor_Contrato.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor_Contrato.Location = new System.Drawing.Point(12, 71);
            this.txtValor_Contrato.Name = "txtValor_Contrato";
            this.txtValor_Contrato.Size = new System.Drawing.Size(94, 26);
            this.txtValor_Contrato.TabIndex = 1;
            this.txtValor_Contrato.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Valor contrato";
            // 
            // txtQtde
            // 
            this.txtQtde.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtde.Location = new System.Drawing.Point(12, 116);
            this.txtQtde.Name = "txtQtde";
            this.txtQtde.Size = new System.Drawing.Size(94, 26);
            this.txtQtde.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Qtde";
            // 
            // txtVencimento
            // 
            this.txtVencimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVencimento.Location = new System.Drawing.Point(112, 116);
            this.txtVencimento.Mask = "00/00/0000";
            this.txtVencimento.Name = "txtVencimento";
            this.txtVencimento.Size = new System.Drawing.Size(94, 26);
            this.txtVencimento.TabIndex = 4;
            this.txtVencimento.ValidatingType = typeof(System.DateTime);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(112, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Vencimento";
            // 
            // txtObs1
            // 
            this.txtObs1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObs1.Location = new System.Drawing.Point(12, 161);
            this.txtObs1.MaxLength = 50;
            this.txtObs1.Name = "txtObs1";
            this.txtObs1.Size = new System.Drawing.Size(373, 26);
            this.txtObs1.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Observações";
            // 
            // txtObs2
            // 
            this.txtObs2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObs2.Location = new System.Drawing.Point(12, 193);
            this.txtObs2.MaxLength = 50;
            this.txtObs2.Name = "txtObs2";
            this.txtObs2.Size = new System.Drawing.Size(373, 26);
            this.txtObs2.TabIndex = 6;
            // 
            // txtObs3
            // 
            this.txtObs3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObs3.Location = new System.Drawing.Point(12, 225);
            this.txtObs3.MaxLength = 50;
            this.txtObs3.Name = "txtObs3";
            this.txtObs3.Size = new System.Drawing.Size(373, 26);
            this.txtObs3.TabIndex = 7;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 302);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(397, 22);
            this.statusStrip1.TabIndex = 13;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblVencimentos);
            this.panel1.Location = new System.Drawing.Point(213, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(172, 133);
            this.panel1.TabIndex = 14;
            // 
            // lblVencimentos
            // 
            this.lblVencimentos.AutoSize = true;
            this.lblVencimentos.Location = new System.Drawing.Point(4, 3);
            this.lblVencimentos.Name = "lblVencimentos";
            this.lblVencimentos.Size = new System.Drawing.Size(35, 13);
            this.lblVencimentos.TabIndex = 0;
            this.lblVencimentos.Text = "label6";
            // 
            // btnGerar
            // 
            this.btnGerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerar.Location = new System.Drawing.Point(12, 257);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(83, 30);
            this.btnGerar.TabIndex = 8;
            this.btnGerar.Text = "Gerar";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(112, 257);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(83, 30);
            this.btnLimpar.TabIndex = 9;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // txtValor_Bruto
            // 
            this.txtValor_Bruto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor_Bruto.Location = new System.Drawing.Point(112, 71);
            this.txtValor_Bruto.Name = "txtValor_Bruto";
            this.txtValor_Bruto.Size = new System.Drawing.Size(94, 26);
            this.txtValor_Bruto.TabIndex = 2;
            this.txtValor_Bruto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(112, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Valor bruto";
            // 
            // chkTravar
            // 
            this.chkTravar.AutoSize = true;
            this.chkTravar.Location = new System.Drawing.Point(115, 25);
            this.chkTravar.Name = "chkTravar";
            this.chkTravar.Size = new System.Drawing.Size(89, 17);
            this.chkTravar.TabIndex = 10;
            this.chkTravar.Text = "Travar dados";
            this.chkTravar.UseVisualStyleBackColor = true;
            // 
            // GerarUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 324);
            this.Controls.Add(this.chkTravar);
            this.Controls.Add(this.txtValor_Bruto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.txtObs3);
            this.Controls.Add(this.txtObs2);
            this.Controls.Add(this.txtObs1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtVencimento);
            this.Controls.Add(this.txtQtde);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtValor_Contrato);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "GerarUI";
            this.Text = "Gerar Boleto";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtValor_Contrato;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtQtde;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txtVencimento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtObs1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtObs2;
        private System.Windows.Forms.TextBox txtObs3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lblVencimentos;
        private System.Windows.Forms.TextBox txtValor_Bruto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkTravar;

    }
}