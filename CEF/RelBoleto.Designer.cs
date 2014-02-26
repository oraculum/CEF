namespace CEF
{
    partial class RelBoleto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RelBoleto));
            this.label1 = new System.Windows.Forms.Label();
            this.txtDataIN = new System.Windows.Forms.MaskedTextBox();
            this.txtDataFN = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.rbtAbertas = new System.Windows.Forms.RadioButton();
            this.rbtPagas = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vencimento Inicial";
            // 
            // txtDataIN
            // 
            this.txtDataIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataIN.Location = new System.Drawing.Point(16, 30);
            this.txtDataIN.Mask = "00/00/0000";
            this.txtDataIN.Name = "txtDataIN";
            this.txtDataIN.Size = new System.Drawing.Size(100, 26);
            this.txtDataIN.TabIndex = 1;
            this.txtDataIN.ValidatingType = typeof(System.DateTime);
            // 
            // txtDataFN
            // 
            this.txtDataFN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataFN.Location = new System.Drawing.Point(127, 30);
            this.txtDataFN.Mask = "00/00/0000";
            this.txtDataFN.Name = "txtDataFN";
            this.txtDataFN.Size = new System.Drawing.Size(100, 26);
            this.txtDataFN.TabIndex = 3;
            this.txtDataFN.ValidatingType = typeof(System.DateTime);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Vencimento Final";
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(12, 68);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(122, 33);
            this.btnPrint.TabIndex = 4;
            this.btnPrint.Text = "Imprimir";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // rbtAbertas
            // 
            this.rbtAbertas.AutoSize = true;
            this.rbtAbertas.Checked = true;
            this.rbtAbertas.Location = new System.Drawing.Point(248, 13);
            this.rbtAbertas.Name = "rbtAbertas";
            this.rbtAbertas.Size = new System.Drawing.Size(61, 17);
            this.rbtAbertas.TabIndex = 5;
            this.rbtAbertas.TabStop = true;
            this.rbtAbertas.Text = "Abertas";
            this.rbtAbertas.UseVisualStyleBackColor = true;
            this.rbtAbertas.CheckedChanged += new System.EventHandler(this.rbtAbertas_CheckedChanged);
            // 
            // rbtPagas
            // 
            this.rbtPagas.AutoSize = true;
            this.rbtPagas.Location = new System.Drawing.Point(248, 39);
            this.rbtPagas.Name = "rbtPagas";
            this.rbtPagas.Size = new System.Drawing.Size(55, 17);
            this.rbtPagas.TabIndex = 6;
            this.rbtPagas.Text = "Pagas";
            this.rbtPagas.UseVisualStyleBackColor = true;
            this.rbtPagas.CheckedChanged += new System.EventHandler(this.rbtPagas_CheckedChanged);
            // 
            // RelBoleto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 123);
            this.Controls.Add(this.rbtPagas);
            this.Controls.Add(this.rbtAbertas);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.txtDataFN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDataIN);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RelBoleto";
            this.Text = "Relatório de boletos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtDataIN;
        private System.Windows.Forms.MaskedTextBox txtDataFN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.RadioButton rbtAbertas;
        private System.Windows.Forms.RadioButton rbtPagas;
    }
}