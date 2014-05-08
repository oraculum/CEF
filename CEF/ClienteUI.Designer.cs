namespace CEF
{
    partial class ClienteUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClienteUI));
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.txtIE = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtUF = new System.Windows.Forms.TextBox();
            this.txtCEP = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnNext = new System.Windows.Forms.Button();
            this.txtFantasia = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(12, 29);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(72, 23);
            this.txtCodigo.TabIndex = 0;
            this.txtCodigo.Leave += new System.EventHandler(this.txtCodigo_Leave);
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(122, 30);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(333, 23);
            this.txtNome.TabIndex = 1;
            this.txtNome.Leave += new System.EventHandler(this.txtNome_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "CNPJ";
            // 
            // txtCNPJ
            // 
            this.txtCNPJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCNPJ.Location = new System.Drawing.Point(12, 115);
            this.txtCNPJ.Mask = "00,000,000/0000-00";
            this.txtCNPJ.Name = "txtCNPJ";
            this.txtCNPJ.Size = new System.Drawing.Size(133, 23);
            this.txtCNPJ.TabIndex = 3;
            // 
            // txtIE
            // 
            this.txtIE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIE.Location = new System.Drawing.Point(277, 115);
            this.txtIE.Name = "txtIE";
            this.txtIE.Size = new System.Drawing.Size(178, 23);
            this.txtIE.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(274, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Inscrição estadual";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Endereço";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndereco.Location = new System.Drawing.Point(12, 157);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(387, 23);
            this.txtEndereco.TabIndex = 5;
            // 
            // txtNumero
            // 
            this.txtNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.Location = new System.Drawing.Point(408, 157);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(47, 23);
            this.txtNumero.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(405, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Num";
            // 
            // txtComplemento
            // 
            this.txtComplemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComplemento.Location = new System.Drawing.Point(12, 199);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(210, 23);
            this.txtComplemento.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Complemento";
            // 
            // txtBairro
            // 
            this.txtBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairro.Location = new System.Drawing.Point(233, 199);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(224, 23);
            this.txtBairro.TabIndex = 8;
            this.txtBairro.Leave += new System.EventHandler(this.txtBairro_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(230, 183);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Bairro";
            // 
            // txtCidade
            // 
            this.txtCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidade.Location = new System.Drawing.Point(12, 241);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(305, 23);
            this.txtCidade.TabIndex = 9;
            this.txtCidade.Text = "Volta Redonda";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 225);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Cidade";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(321, 225);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "UF";
            // 
            // txtUF
            // 
            this.txtUF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUF.Location = new System.Drawing.Point(324, 241);
            this.txtUF.Name = "txtUF";
            this.txtUF.Size = new System.Drawing.Size(47, 23);
            this.txtUF.TabIndex = 10;
            this.txtUF.Text = "RJ";
            // 
            // txtCEP
            // 
            this.txtCEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCEP.Location = new System.Drawing.Point(380, 241);
            this.txtCEP.Mask = "00000-000";
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(75, 23);
            this.txtCEP.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(377, 225);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "CEP";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(12, 270);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 12;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(94, 270);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 13;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.Location = new System.Drawing.Point(175, 270);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(75, 23);
            this.btnApagar.TabIndex = 14;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(256, 270);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 15;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 310);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(468, 22);
            this.statusStrip1.TabIndex = 27;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(94, 30);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(23, 23);
            this.btnNext.TabIndex = 28;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // txtFantasia
            // 
            this.txtFantasia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFantasia.Location = new System.Drawing.Point(12, 72);
            this.txtFantasia.Name = "txtFantasia";
            this.txtFantasia.Size = new System.Drawing.Size(439, 23);
            this.txtFantasia.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 56);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 13);
            this.label12.TabIndex = 29;
            this.label12.Text = "Nome fantasia";
            // 
            // ClienteUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 332);
            this.Controls.Add(this.txtFantasia);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtCEP);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtUF);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtComplemento);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtIE);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCNPJ);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ClienteUI";
            this.Text = "Cliente";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txtCNPJ;
        private System.Windows.Forms.TextBox txtIE;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtUF;
        private System.Windows.Forms.MaskedTextBox txtCEP;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.TextBox txtFantasia;
        private System.Windows.Forms.Label label12;
    }
}