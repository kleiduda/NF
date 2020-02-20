namespace NF
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnImportar = new System.Windows.Forms.Button();
            this.txtArquivoExcel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLocalizarArquivoExcel = new System.Windows.Forms.Button();
            this.ofd1 = new System.Windows.Forms.OpenFileDialog();
            this.btnSqlServer = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dtCadastros = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtCadastros)).BeginInit();
            this.SuspendLayout();
            // 
            // btnImportar
            // 
            this.btnImportar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnImportar.Location = new System.Drawing.Point(705, 29);
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
            this.txtArquivoExcel.Location = new System.Drawing.Point(17, 38);
            this.txtArquivoExcel.Name = "txtArquivoExcel";
            this.txtArquivoExcel.Size = new System.Drawing.Size(542, 20);
            this.txtArquivoExcel.TabIndex = 156;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 159;
            this.label2.Text = "Arquivo a ser importado";
            // 
            // btnLocalizarArquivoExcel
            // 
            this.btnLocalizarArquivoExcel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnLocalizarArquivoExcel.Location = new System.Drawing.Point(565, 38);
            this.btnLocalizarArquivoExcel.Name = "btnLocalizarArquivoExcel";
            this.btnLocalizarArquivoExcel.Size = new System.Drawing.Size(24, 21);
            this.btnLocalizarArquivoExcel.TabIndex = 157;
            this.btnLocalizarArquivoExcel.Text = "...";
            this.btnLocalizarArquivoExcel.UseVisualStyleBackColor = true;
            this.btnLocalizarArquivoExcel.Click += new System.EventHandler(this.btnLocalizarArquivoExcel_Click);
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
            this.btnSqlServer.Location = new System.Drawing.Point(578, 563);
            this.btnSqlServer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSqlServer.Name = "btnSqlServer";
            this.btnSqlServer.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(186)))), ((int)(((byte)(167)))));
            this.btnSqlServer.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(186)))), ((int)(((byte)(167)))));
            this.btnSqlServer.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSqlServer.selected = false;
            this.btnSqlServer.Size = new System.Drawing.Size(452, 42);
            this.btnSqlServer.TabIndex = 161;
            this.btnSqlServer.Text = "Importar Dados";
            this.btnSqlServer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSqlServer.Textcolor = System.Drawing.Color.White;
            this.btnSqlServer.TextFont = new System.Drawing.Font("Open Sans ExtraBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSqlServer.Click += new System.EventHandler(this.btnSqlServer_Click);
            // 
            // dtCadastros
            // 
            this.dtCadastros.AllowUserToAddRows = false;
            this.dtCadastros.AllowUserToDeleteRows = false;
            this.dtCadastros.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtCadastros.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dtCadastros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtCadastros.BackgroundColor = System.Drawing.Color.White;
            this.dtCadastros.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtCadastros.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtCadastros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dtCadastros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtCadastros.DefaultCellStyle = dataGridViewCellStyle7;
            this.dtCadastros.DoubleBuffered = true;
            this.dtCadastros.EnableHeadersVisualStyles = false;
            this.dtCadastros.GridColor = System.Drawing.Color.White;
            this.dtCadastros.HeaderBgColor = System.Drawing.Color.White;
            this.dtCadastros.HeaderForeColor = System.Drawing.Color.Black;
            this.dtCadastros.Location = new System.Drawing.Point(14, 82);
            this.dtCadastros.MultiSelect = false;
            this.dtCadastros.Name = "dtCadastros";
            this.dtCadastros.ReadOnly = true;
            this.dtCadastros.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(186)))), ((int)(((byte)(167)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtCadastros.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dtCadastros.RowHeadersVisible = false;
            this.dtCadastros.RowHeadersWidth = 62;
            this.dtCadastros.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dtCadastros.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtCadastros.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dtCadastros.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(10, 0, 10, 5);
            this.dtCadastros.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtCadastros.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dtCadastros.RowTemplate.DividerHeight = 1;
            this.dtCadastros.RowTemplate.Height = 70;
            this.dtCadastros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtCadastros.Size = new System.Drawing.Size(540, 523);
            this.dtCadastros.TabIndex = 162;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(687, 284);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 73);
            this.label1.TabIndex = 163;
            this.label1.Text = "ENTRADA";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 651);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtCadastros);
            this.Controls.Add(this.btnSqlServer);
            this.Controls.Add(this.btnImportar);
            this.Controls.Add(this.txtArquivoExcel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLocalizarArquivoExcel);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dtCadastros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnImportar;
        private System.Windows.Forms.TextBox txtArquivoExcel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLocalizarArquivoExcel;
        private System.Windows.Forms.OpenFileDialog ofd1;
        private Bunifu.Framework.UI.BunifuFlatButton btnSqlServer;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dtCadastros;
        private System.Windows.Forms.Label label1;
    }
}

