namespace NF
{
    partial class FormResultado
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ofd1 = new System.Windows.Forms.OpenFileDialog();
            this.dgvResultado = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.btnExcel = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dgvSoentrada = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.btnSoEntrada = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dgvSaida = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.btnSaida = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSoentrada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaida)).BeginInit();
            this.SuspendLayout();
            // 
            // ofd1
            // 
            this.ofd1.FileName = "ofd1";
            // 
            // dgvResultado
            // 
            this.dgvResultado.AllowUserToAddRows = false;
            this.dgvResultado.AllowUserToDeleteRows = false;
            this.dgvResultado.AllowUserToResizeRows = false;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvResultado.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle25;
            this.dgvResultado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvResultado.BackgroundColor = System.Drawing.Color.White;
            this.dgvResultado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvResultado.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvResultado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle26;
            this.dgvResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvResultado.DefaultCellStyle = dataGridViewCellStyle27;
            this.dgvResultado.DoubleBuffered = true;
            this.dgvResultado.EnableHeadersVisualStyles = false;
            this.dgvResultado.GridColor = System.Drawing.Color.White;
            this.dgvResultado.HeaderBgColor = System.Drawing.Color.White;
            this.dgvResultado.HeaderForeColor = System.Drawing.Color.Black;
            this.dgvResultado.Location = new System.Drawing.Point(12, 90);
            this.dgvResultado.MultiSelect = false;
            this.dgvResultado.Name = "dgvResultado";
            this.dgvResultado.ReadOnly = true;
            this.dgvResultado.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle28.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle28.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(186)))), ((int)(((byte)(167)))));
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvResultado.RowHeadersDefaultCellStyle = dataGridViewCellStyle28;
            this.dgvResultado.RowHeadersVisible = false;
            this.dgvResultado.RowHeadersWidth = 62;
            this.dgvResultado.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgvResultado.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvResultado.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvResultado.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(10, 0, 10, 5);
            this.dgvResultado.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvResultado.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvResultado.RowTemplate.DividerHeight = 1;
            this.dgvResultado.RowTemplate.Height = 70;
            this.dgvResultado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResultado.Size = new System.Drawing.Size(1124, 279);
            this.dgvResultado.TabIndex = 142;
            // 
            // btnExcel
            // 
            this.btnExcel.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(186)))), ((int)(((byte)(167)))));
            this.btnExcel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(186)))), ((int)(((byte)(167)))));
            this.btnExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExcel.BorderRadius = 0;
            this.btnExcel.ButtonText = "Exportar Dados";
            this.btnExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcel.DisabledColor = System.Drawing.Color.Gray;
            this.btnExcel.Iconcolor = System.Drawing.Color.Transparent;
            this.btnExcel.Iconimage = null;
            this.btnExcel.Iconimage_right = null;
            this.btnExcel.Iconimage_right_Selected = null;
            this.btnExcel.Iconimage_Selected = null;
            this.btnExcel.IconMarginLeft = 0;
            this.btnExcel.IconMarginRight = 0;
            this.btnExcel.IconRightVisible = true;
            this.btnExcel.IconRightZoom = 0D;
            this.btnExcel.IconVisible = true;
            this.btnExcel.IconZoom = 90D;
            this.btnExcel.IsTab = false;
            this.btnExcel.Location = new System.Drawing.Point(876, 23);
            this.btnExcel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(186)))), ((int)(((byte)(167)))));
            this.btnExcel.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(186)))), ((int)(((byte)(167)))));
            this.btnExcel.OnHoverTextColor = System.Drawing.Color.White;
            this.btnExcel.selected = false;
            this.btnExcel.Size = new System.Drawing.Size(260, 42);
            this.btnExcel.TabIndex = 162;
            this.btnExcel.Text = "Exportar Dados";
            this.btnExcel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnExcel.Textcolor = System.Drawing.Color.White;
            this.btnExcel.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // dgvSoentrada
            // 
            this.dgvSoentrada.AllowUserToAddRows = false;
            this.dgvSoentrada.AllowUserToDeleteRows = false;
            this.dgvSoentrada.AllowUserToResizeRows = false;
            dataGridViewCellStyle29.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvSoentrada.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle29;
            this.dgvSoentrada.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSoentrada.BackgroundColor = System.Drawing.Color.White;
            this.dgvSoentrada.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSoentrada.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle30.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle30.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSoentrada.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle30;
            this.dgvSoentrada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle31.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle31.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle31.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle31.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle31.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle31.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSoentrada.DefaultCellStyle = dataGridViewCellStyle31;
            this.dgvSoentrada.DoubleBuffered = true;
            this.dgvSoentrada.EnableHeadersVisualStyles = false;
            this.dgvSoentrada.GridColor = System.Drawing.Color.White;
            this.dgvSoentrada.HeaderBgColor = System.Drawing.Color.White;
            this.dgvSoentrada.HeaderForeColor = System.Drawing.Color.Black;
            this.dgvSoentrada.Location = new System.Drawing.Point(12, 454);
            this.dgvSoentrada.MultiSelect = false;
            this.dgvSoentrada.Name = "dgvSoentrada";
            this.dgvSoentrada.ReadOnly = true;
            this.dgvSoentrada.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle32.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle32.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle32.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle32.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(186)))), ((int)(((byte)(167)))));
            dataGridViewCellStyle32.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle32.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSoentrada.RowHeadersDefaultCellStyle = dataGridViewCellStyle32;
            this.dgvSoentrada.RowHeadersVisible = false;
            this.dgvSoentrada.RowHeadersWidth = 62;
            this.dgvSoentrada.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgvSoentrada.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvSoentrada.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvSoentrada.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(10, 0, 10, 5);
            this.dgvSoentrada.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvSoentrada.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvSoentrada.RowTemplate.DividerHeight = 1;
            this.dgvSoentrada.RowTemplate.Height = 70;
            this.dgvSoentrada.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSoentrada.Size = new System.Drawing.Size(554, 294);
            this.dgvSoentrada.TabIndex = 163;
            // 
            // btnSoEntrada
            // 
            this.btnSoEntrada.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(186)))), ((int)(((byte)(167)))));
            this.btnSoEntrada.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSoEntrada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(186)))), ((int)(((byte)(167)))));
            this.btnSoEntrada.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSoEntrada.BorderRadius = 0;
            this.btnSoEntrada.ButtonText = "So tem na entrada";
            this.btnSoEntrada.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSoEntrada.DisabledColor = System.Drawing.Color.Gray;
            this.btnSoEntrada.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSoEntrada.Iconimage = null;
            this.btnSoEntrada.Iconimage_right = null;
            this.btnSoEntrada.Iconimage_right_Selected = null;
            this.btnSoEntrada.Iconimage_Selected = null;
            this.btnSoEntrada.IconMarginLeft = 0;
            this.btnSoEntrada.IconMarginRight = 0;
            this.btnSoEntrada.IconRightVisible = true;
            this.btnSoEntrada.IconRightZoom = 0D;
            this.btnSoEntrada.IconVisible = true;
            this.btnSoEntrada.IconZoom = 90D;
            this.btnSoEntrada.IsTab = false;
            this.btnSoEntrada.Location = new System.Drawing.Point(13, 404);
            this.btnSoEntrada.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSoEntrada.Name = "btnSoEntrada";
            this.btnSoEntrada.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(186)))), ((int)(((byte)(167)))));
            this.btnSoEntrada.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(186)))), ((int)(((byte)(167)))));
            this.btnSoEntrada.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSoEntrada.selected = false;
            this.btnSoEntrada.Size = new System.Drawing.Size(260, 42);
            this.btnSoEntrada.TabIndex = 164;
            this.btnSoEntrada.Text = "So tem na entrada";
            this.btnSoEntrada.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSoEntrada.Textcolor = System.Drawing.Color.White;
            this.btnSoEntrada.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSoEntrada.Click += new System.EventHandler(this.btnSoEntrada_Click);
            // 
            // dgvSaida
            // 
            this.dgvSaida.AllowUserToAddRows = false;
            this.dgvSaida.AllowUserToDeleteRows = false;
            this.dgvSaida.AllowUserToResizeRows = false;
            dataGridViewCellStyle33.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvSaida.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle33;
            this.dgvSaida.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSaida.BackgroundColor = System.Drawing.Color.White;
            this.dgvSaida.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSaida.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle34.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle34.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle34.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle34.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle34.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle34.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSaida.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle34;
            this.dgvSaida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle35.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle35.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle35.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle35.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle35.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle35.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSaida.DefaultCellStyle = dataGridViewCellStyle35;
            this.dgvSaida.DoubleBuffered = true;
            this.dgvSaida.EnableHeadersVisualStyles = false;
            this.dgvSaida.GridColor = System.Drawing.Color.White;
            this.dgvSaida.HeaderBgColor = System.Drawing.Color.White;
            this.dgvSaida.HeaderForeColor = System.Drawing.Color.Black;
            this.dgvSaida.Location = new System.Drawing.Point(582, 454);
            this.dgvSaida.MultiSelect = false;
            this.dgvSaida.Name = "dgvSaida";
            this.dgvSaida.ReadOnly = true;
            this.dgvSaida.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle36.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle36.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle36.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle36.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle36.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(186)))), ((int)(((byte)(167)))));
            dataGridViewCellStyle36.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle36.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSaida.RowHeadersDefaultCellStyle = dataGridViewCellStyle36;
            this.dgvSaida.RowHeadersVisible = false;
            this.dgvSaida.RowHeadersWidth = 62;
            this.dgvSaida.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgvSaida.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvSaida.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvSaida.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(10, 0, 10, 5);
            this.dgvSaida.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvSaida.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvSaida.RowTemplate.DividerHeight = 1;
            this.dgvSaida.RowTemplate.Height = 70;
            this.dgvSaida.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSaida.Size = new System.Drawing.Size(554, 294);
            this.dgvSaida.TabIndex = 165;
            // 
            // btnSaida
            // 
            this.btnSaida.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(186)))), ((int)(((byte)(167)))));
            this.btnSaida.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSaida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(186)))), ((int)(((byte)(167)))));
            this.btnSaida.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSaida.BorderRadius = 0;
            this.btnSaida.ButtonText = "So tem na saida";
            this.btnSaida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaida.DisabledColor = System.Drawing.Color.Gray;
            this.btnSaida.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSaida.Iconimage = null;
            this.btnSaida.Iconimage_right = null;
            this.btnSaida.Iconimage_right_Selected = null;
            this.btnSaida.Iconimage_Selected = null;
            this.btnSaida.IconMarginLeft = 0;
            this.btnSaida.IconMarginRight = 0;
            this.btnSaida.IconRightVisible = true;
            this.btnSaida.IconRightZoom = 0D;
            this.btnSaida.IconVisible = true;
            this.btnSaida.IconZoom = 90D;
            this.btnSaida.IsTab = false;
            this.btnSaida.Location = new System.Drawing.Point(876, 404);
            this.btnSaida.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSaida.Name = "btnSaida";
            this.btnSaida.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(186)))), ((int)(((byte)(167)))));
            this.btnSaida.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(186)))), ((int)(((byte)(167)))));
            this.btnSaida.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSaida.selected = false;
            this.btnSaida.Size = new System.Drawing.Size(260, 42);
            this.btnSaida.TabIndex = 166;
            this.btnSaida.Text = "So tem na saida";
            this.btnSaida.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSaida.Textcolor = System.Drawing.Color.White;
            this.btnSaida.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaida.Click += new System.EventHandler(this.btnSaida_Click);
            // 
            // FormResultado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 760);
            this.Controls.Add(this.btnSaida);
            this.Controls.Add(this.dgvSaida);
            this.Controls.Add(this.btnSoEntrada);
            this.Controls.Add(this.dgvSoentrada);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.dgvResultado);
            this.Name = "FormResultado";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormResultado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSoentrada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaida)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog ofd1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvResultado;
        private Bunifu.Framework.UI.BunifuFlatButton btnExcel;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvSoentrada;
        private Bunifu.Framework.UI.BunifuFlatButton btnSoEntrada;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvSaida;
        private Bunifu.Framework.UI.BunifuFlatButton btnSaida;
    }
}

