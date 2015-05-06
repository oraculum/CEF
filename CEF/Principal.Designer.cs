namespace CEF
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelFilial = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusVersion = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnEnvelope = new System.Windows.Forms.Button();
            this.btnConfig = new System.Windows.Forms.Button();
            this.btnRetorno = new System.Windows.Forms.Button();
            this.btnRelatorio = new System.Windows.Forms.Button();
            this.btnBaixar = new System.Windows.Forms.Button();
            this.btnGerar = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelFilial,
            this.statusVersion});
            this.statusStrip1.Location = new System.Drawing.Point(0, 271);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(443, 24);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelFilial
            // 
            this.toolStripStatusLabelFilial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.toolStripStatusLabelFilial.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabelFilial.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.toolStripStatusLabelFilial.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripStatusLabelFilial.Name = "toolStripStatusLabelFilial";
            this.toolStripStatusLabelFilial.Size = new System.Drawing.Size(214, 19);
            this.toolStripStatusLabelFilial.Spring = true;
            this.toolStripStatusLabelFilial.Text = "Oraculum Ltda";
            // 
            // statusVersion
            // 
            this.statusVersion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.statusVersion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.statusVersion.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.statusVersion.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.statusVersion.Name = "statusVersion";
            this.statusVersion.Size = new System.Drawing.Size(214, 19);
            this.statusVersion.Spring = true;
            this.statusVersion.Text = "toolStripStatusLabel1";
            // 
            // btnEnvelope
            // 
            this.btnEnvelope.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnvelope.Image = global::CEF.Properties.Resources.envelope;
            this.btnEnvelope.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEnvelope.Location = new System.Drawing.Point(13, 183);
            this.btnEnvelope.Name = "btnEnvelope";
            this.btnEnvelope.Size = new System.Drawing.Size(135, 79);
            this.btnEnvelope.TabIndex = 7;
            this.btnEnvelope.Text = "Envelope";
            this.btnEnvelope.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEnvelope.UseVisualStyleBackColor = true;
            this.btnEnvelope.Click += new System.EventHandler(this.btnEnvelope_Click);
            // 
            // btnConfig
            // 
            this.btnConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfig.Image = global::CEF.Properties.Resources.configuracoes;
            this.btnConfig.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnConfig.Location = new System.Drawing.Point(294, 98);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(135, 79);
            this.btnConfig.TabIndex = 5;
            this.btnConfig.Text = "Configurações";
            this.btnConfig.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnConfig.UseVisualStyleBackColor = true;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // btnRetorno
            // 
            this.btnRetorno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetorno.Image = global::CEF.Properties.Resources.retorno;
            this.btnRetorno.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRetorno.Location = new System.Drawing.Point(295, 13);
            this.btnRetorno.Name = "btnRetorno";
            this.btnRetorno.Size = new System.Drawing.Size(135, 79);
            this.btnRetorno.TabIndex = 4;
            this.btnRetorno.Text = "Retorno";
            this.btnRetorno.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRetorno.UseVisualStyleBackColor = true;
            this.btnRetorno.Click += new System.EventHandler(this.btnRetorno_Click);
            // 
            // btnRelatorio
            // 
            this.btnRelatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelatorio.Image = global::CEF.Properties.Resources.relatorio;
            this.btnRelatorio.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRelatorio.Location = new System.Drawing.Point(153, 97);
            this.btnRelatorio.Name = "btnRelatorio";
            this.btnRelatorio.Size = new System.Drawing.Size(135, 79);
            this.btnRelatorio.TabIndex = 3;
            this.btnRelatorio.Text = "Relatório";
            this.btnRelatorio.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRelatorio.UseVisualStyleBackColor = true;
            this.btnRelatorio.Click += new System.EventHandler(this.btnRelatorio_Click);
            // 
            // btnBaixar
            // 
            this.btnBaixar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaixar.Image = global::CEF.Properties.Resources.baixar;
            this.btnBaixar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBaixar.Location = new System.Drawing.Point(13, 98);
            this.btnBaixar.Name = "btnBaixar";
            this.btnBaixar.Size = new System.Drawing.Size(135, 79);
            this.btnBaixar.TabIndex = 2;
            this.btnBaixar.Text = "Baixar";
            this.btnBaixar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBaixar.UseVisualStyleBackColor = true;
            this.btnBaixar.Click += new System.EventHandler(this.btnBaixar_Click);
            // 
            // btnGerar
            // 
            this.btnGerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerar.Image = global::CEF.Properties.Resources.gerar;
            this.btnGerar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGerar.Location = new System.Drawing.Point(154, 12);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(135, 79);
            this.btnGerar.TabIndex = 1;
            this.btnGerar.Text = "Gerar";
            this.btnGerar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // btnCliente
            // 
            this.btnCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCliente.Image = global::CEF.Properties.Resources.cliente;
            this.btnCliente.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCliente.Location = new System.Drawing.Point(13, 13);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(135, 79);
            this.btnCliente.TabIndex = 0;
            this.btnCliente.Text = "Cliente";
            this.btnCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 295);
            this.Controls.Add(this.btnEnvelope);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnConfig);
            this.Controls.Add(this.btnRetorno);
            this.Controls.Add(this.btnRelatorio);
            this.Controls.Add(this.btnBaixar);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.btnCliente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Principal";
            this.Text = "CEF";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.Button btnBaixar;
        private System.Windows.Forms.Button btnRelatorio;
        private System.Windows.Forms.Button btnRetorno;
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelFilial;
        private System.Windows.Forms.ToolStripStatusLabel statusVersion;
        private System.Windows.Forms.Button btnEnvelope;
    }
}

