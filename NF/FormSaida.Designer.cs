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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnImportar = new System.Windows.Forms.Button();
            this.txtArquivoExcel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLocalizarArquivoExcel = new System.Windows.Forms.Button();
            this.ofd1 = new System.Windows.Forms.OpenFileDialog();
            this.btnSqlServer = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvDados = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.SuspendLayout();
            // 
            // btnImportar
            // 
            this.btnImportar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnImportar.Location = new System.Drawing.Point(612, 31);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(206, 42);
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
            this.btnSqlServer.Location = new System.Drawing.Point(867, 31);
            this.btnSqlServer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSqlServer.Name = "btnSqlServer";
            this.btnSqlServer.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(186)))), ((int)(((byte)(167)))));
            this.btnSqlServer.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(186)))), ((int)(((byte)(167)))));
            this.btnSqlServer.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSqlServer.selected = false;
            this.btnSqlServer.Size = new System.Drawing.Size(247, 42);
            this.btnSqlServer.TabIndex = 161;
            this.btnSqlServer.Text = "Importar Dados";
            this.btnSqlServer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSqlServer.Textcolor = System.Drawing.Color.White;
            this.btnSqlServer.TextFont = new System.Drawing.Font("Open Sans ExtraBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSqlServer.Click += new System.EventHandler(this.btnSqlServer_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(650, 351);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(426, 55);
            this.label3.TabIndex = 164;
            this.label3.Text = "NOTAS DE SAIDA";
            // 
            // dgvDados
            // 
            this.dgvDados.AllowUserToAddRows = false;
            this.dgvDados.AllowUserToDeleteRows = false;
            this.dgvDados.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvDados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDados.BackgroundColor = System.Drawing.Color.White;
            this.dgvDados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDados.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDados.DoubleBuffered = true;
            this.dgvDados.EnableHeadersVisualStyles = false;
            this.dgvDados.GridColor = System.Drawing.Color.White;
            this.dgvDados.HeaderBgColor = System.Drawing.Color.White;
            this.dgvDados.HeaderForeColor = System.Drawing.Color.Black;
            this.dgvDados.Location = new System.Drawing.Point(14, 89);
            this.dgvDados.MultiSelect = false;
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.ReadOnly = true;
            this.dgvDados.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(186)))), ((int)(((byte)(167)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDados.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDados.RowHeadersVisible = false;
            this.dgvDados.RowHeadersWidth = 62;
            this.dgvDados.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgvDados.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDados.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvDados.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(10, 0, 10, 5);
            this.dgvDados.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvDados.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvDados.RowTemplate.DividerHeight = 1;
            this.dgvDados.RowTemplate.Height = 70;
            this.dgvDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDados.Size = new System.Drawing.Size(540, 550);
            this.dgvDados.TabIndex = 165;
            // 
            // FormSaida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 651);
            this.Controls.Add(this.dgvDados);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSqlServer);
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
        private System.Windows.Forms.OpenFileDialog ofd1;
        private Bunifu.Framework.UI.BunifuFlatButton btnSqlServer;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvDados;
    }
}

