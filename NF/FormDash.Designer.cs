namespace NF
{
    partial class FormDash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDash));
            this.ofd1 = new System.Windows.Forms.OpenFileDialog();
            this.btnEntrada = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnResultado = new Bunifu.Framework.UI.BunifuThinButton2();
            this.SuspendLayout();
            // 
            // ofd1
            // 
            this.ofd1.FileName = "ofd1";
            // 
            // btnEntrada
            // 
            this.btnEntrada.ActiveBorderThickness = 1;
            this.btnEntrada.ActiveCornerRadius = 1;
            this.btnEntrada.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnEntrada.ActiveForecolor = System.Drawing.Color.White;
            this.btnEntrada.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.btnEntrada.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnEntrada.BackColor = System.Drawing.SystemColors.Control;
            this.btnEntrada.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEntrada.BackgroundImage")));
            this.btnEntrada.ButtonText = "Importar Entradas";
            this.btnEntrada.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEntrada.Font = new System.Drawing.Font("Open Sans SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrada.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnEntrada.IdleBorderThickness = 1;
            this.btnEntrada.IdleCornerRadius = 2;
            this.btnEntrada.IdleFillColor = System.Drawing.Color.White;
            this.btnEntrada.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnEntrada.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnEntrada.Location = new System.Drawing.Point(360, 282);
            this.btnEntrada.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEntrada.Name = "btnEntrada";
            this.btnEntrada.Size = new System.Drawing.Size(208, 107);
            this.btnEntrada.TabIndex = 5;
            this.btnEntrada.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEntrada.Click += new System.EventHandler(this.btnEntrada_Click);
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 1;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.bunifuThinButton21.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.bunifuThinButton21.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Importar Saidas";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Open Sans SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 2;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.bunifuThinButton21.Location = new System.Drawing.Point(598, 282);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(208, 107);
            this.bunifuThinButton21.TabIndex = 6;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // btnResultado
            // 
            this.btnResultado.ActiveBorderThickness = 1;
            this.btnResultado.ActiveCornerRadius = 1;
            this.btnResultado.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnResultado.ActiveForecolor = System.Drawing.Color.White;
            this.btnResultado.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.btnResultado.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnResultado.BackColor = System.Drawing.SystemColors.Control;
            this.btnResultado.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnResultado.BackgroundImage")));
            this.btnResultado.ButtonText = "Ver Resultado";
            this.btnResultado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResultado.Font = new System.Drawing.Font("Open Sans SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResultado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnResultado.IdleBorderThickness = 1;
            this.btnResultado.IdleCornerRadius = 2;
            this.btnResultado.IdleFillColor = System.Drawing.Color.White;
            this.btnResultado.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnResultado.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnResultado.Location = new System.Drawing.Point(477, 530);
            this.btnResultado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnResultado.Name = "btnResultado";
            this.btnResultado.Size = new System.Drawing.Size(208, 58);
            this.btnResultado.TabIndex = 7;
            this.btnResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnResultado.Click += new System.EventHandler(this.btnResultado_Click);
            // 
            // FormDash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 651);
            this.Controls.Add(this.btnResultado);
            this.Controls.Add(this.bunifuThinButton21);
            this.Controls.Add(this.btnEntrada);
            this.Name = "FormDash";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog ofd1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnEntrada;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private Bunifu.Framework.UI.BunifuThinButton2 btnResultado;
    }
}

