namespace NF
{
    partial class FormSaida
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnImportar = new System.Windows.Forms.Button();
            this.txtArquivoExcel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLocalizarArquivoExcel = new System.Windows.Forms.Button();
            this.dgvDados = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.ofd1 = new System.Windows.Forms.OpenFileDialog();
            this.btnSqlServer = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.SuspendLayout();
            // 
            // btnImportar
            // 
            this.btnImportar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnImportar.Location = new System.Drawing.Point(700, 30);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(206, 36);
            this.btnImportar.TabIndex = 158;
            this.btnImportar.Text = "Validar Arquivo";
            this.btnImportar.UseVisualStyleBackColor = true;
            this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
            // 
            // txtArquivoExcel
            // 
            this.txtArquivoExcel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtArquivoExcel.Location = new System.Drawing.Point(12, 39);
            this.txtArquivoExcel.Name = "txtArquivoExcel";
            this.txtArquivoExcel.Size = new System.Drawing.Size(542, 20);
            this.txtArquivoExcel.TabIndex = 156;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 159;
            this.label2.Text = "Arquivo a ser importado";
            // 
            // btnLocalizarArquivoExcel
            // 
            this.btnLocalizarArquivoExcel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnLocalizarArquivoExcel.Location = new System.Drawing.Point(560, 39);
            this.btnLocalizarArquivoExcel.Name = "btnLocalizarArquivoExcel";
            this.btnLocalizarArquivoExcel.Size = new System.Drawing.Size(24, 21);
            this.btnLocalizarArquivoExcel.TabIndex = 157;
            this.btnLocalizarArquivoExcel.Text = "...";
            this.btnLocalizarArquivoExcel.UseVisualStyleBackColor = true;
            this.btnLocalizarArquivoExcel.Click += new System.EventHandler(this.btnLocalizarArquivoExcel_Click);
            // 
            // dgvDados
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvDados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDados.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvDados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.DoubleBuffered = true;
            this.dgvDados.EnableHeadersVisualStyles = false;
            this.dgvDados.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dgvDados.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.dgvDados.Location = new System.Drawing.Point(12, 118);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDados.Size = new System.Drawing.Size(542, 520);
            this.dgvDados.TabIndex = 160;
            // 
            // ofd1
            // 
            this.ofd1.FileName = "ofd1";
            // 
            // btnSqlServer
            // 
            this.btnSqlServer.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(186)))), ((int)(((byte)(167)))));
            this.btnSqlServer.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSqlServer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(186)))), ((int)(((byte)(167)))));
            this.btnSqlServer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSqlServer.BorderRadius = 0;
            this.btnSqlServer.ButtonText = "Importar Dados";
            this.btnSqlServer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSqlServer.DisabledColor = System.Drawing.Color.Gray;
            this.btnSqlServer.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSqlServer.Iconimage = null;
            this.btnSqlServer.Iconimage_right = null;
            this.btnSqlServer.Iconimage_right_Selected = null;
            this.btnSqlServer.Iconimage_Selected = null;
            this.btnSqlServer.IconMarginLeft = 0;
            this.btnSqlServer.IconMarginRight = 0;
            this.btnSqlServer.IconRightVisible = true;
            this.btnSqlServer.IconRightZoom = 0D;
            this.btnSqlServer.IconVisible = true;
            this.btnSqlServer.IconZoom = 90D;
            this.btnSqlServer.IsTab = false;
            this.btnSqlServer.Location = new System.Drawing.Point(573, 596);
            this.btnSqlServer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSqlServer.Name = "btnSqlServer";
            this.btnSqlServer.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(186)))), ((int)(((byte)(167)))));
            this.btnSqlServer.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(186)))), ((int)(((byte)(167)))));
            this.btnSqlServer.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSqlServer.selected = false;
            this.btnSqlServer.Size = new System.Drawing.Size(416, 42);
            this.btnSqlServer.TabIndex = 161;
            this.btnSqlServer.Text = "Importar Dados";
            this.btnSqlServer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSqlServer.Textcolor = System.Drawing.Color.White;
            this.btnSqlServer.TextFont = new System.Drawing.Font("Open Sans ExtraBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSqlServer.Click += new System.EventHandler(this.btnSqlServer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(687, 288);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 73);
            this.label1.TabIndex = 162;
            this.label1.Text = "SAIDA";
            // 
            // FormSaida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 651);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSqlServer);
            this.Controls.Add(this.dgvDados);
            this.Controls.Add(this.btnImportar);
            this.Controls.Add(this.txtArquivoExcel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLocalizarArquivoExcel);
            this.Name = "FormSaida";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnImportar;
        private System.Windows.Forms.TextBox txtArquivoExcel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLocalizarArquivoExcel;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvDados;
        private System.Windows.Forms.OpenFileDialog ofd1;
        private Bunifu.Framework.UI.BunifuFlatButton btnSqlServer;
        private System.Windows.Forms.Label label1;
    }
}

