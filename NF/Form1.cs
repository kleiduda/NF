using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

using System.Threading;
namespace NF
{
    public partial class Form1 : Form
    {
        string arquivoExcel = "@produtos.xlsx";
        protected Conection Con = new Conection();
        protected SqlCommand Comando = new SqlCommand();
        protected SqlDataReader LerLinhas;

        public Form1()
        {
            InitializeComponent();
        }

        //public void ValidateData()
        //{
        //    decimal total = 0;
        //    foreach (DataGridViewRow row in dgvDados.Rows)
        //    {
        //        for (int i = 0; i < row.Cells.Count; i++)
        //        {
        //            if (row.Cells[i].Value == null || row.Cells[i].Value == DBNull.Value || String.IsNullOrWhiteSpace(row.Cells[i].Value.ToString()))
        //            {
        //                lblError.Text = Convert.ToString(row.Cells.Count);
        //            }

        //        }
        //    }
        //}
        private DataTable GetTabelaExcel(string arquivoExcel)
        {
            DataTable dt = new DataTable();
            try
            {
                //pega a extensão do arquivo
                string Ext = Path.GetExtension(arquivoExcel);
                string connectionString = "";
                //verifica a versão do Excel pela extensão
                if (Ext == ".xls")
                { //para o  Excel 97-03    
                    connectionString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source =" + arquivoExcel + "; Extended Properties = 'Excel 8.0;HDR=YES'";
                }
                else if (Ext == ".xlsx")
                { //para o  Excel 07 e superior
                    connectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source =" + arquivoExcel + "; Extended Properties = 'Excel 8.0;HDR=YES'";
                }
                OleDbConnection conn = new OleDbConnection(connectionString);
                OleDbCommand cmd = new OleDbCommand();
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter();
                cmd.Connection = conn;
                conn.Open();
                DataTable dtSchema;
                dtSchema = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                string nomePlanilha = dtSchema.Rows[0]["TABLE_NAME"].ToString();
                conn.Close();
                //le todos os dados da planilha para o Data Table    
                conn.Open();
                cmd.CommandText = "SELECT * From [" + nomePlanilha + "]";
                dataAdapter.SelectCommand = cmd;
                dataAdapter.Fill(dt);
                conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dt;
        }

        private void CarregaDadosExcel()
        {
            try
            {
                //limpa o combobox
                //cboBusca.Items.Clear();
                //converte os dados do Excel para um DataTable
                DataTable dt = GetTabelaExcel(arquivoExcel);
                //ajusta a largura das colunas aos dados
                dgvDados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dgvDados.DataSource = dt;
                //No total de registros
                //lblValidate.Text = "Seu arquivo tem " + (dgvDados.Rows.Count).ToString() + " linhas para serem importadas.";
                string[] listaNomeColunas = dt.Columns.OfType<DataColumn>().Select(x => x.ColumnName).ToArray();

                //Adiciona os nomes das colunas no Combobox
                //cboBusca.Items.AddRange(listaNomeColunas);
                //if (cboBusca.Items.Count > 0)
                //    cboBusca.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro :" + ex.Message);
            }
        }

        private void btnLocalizarArquivoExcel_Click(object sender, EventArgs e)
        {
            DialogResult drResult = ofd1.ShowDialog();

            if (drResult == System.Windows.Forms.DialogResult.OK)
                txtArquivoExcel.Text = ofd1.FileName;
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtArquivoExcel.Text) && File.Exists(txtArquivoExcel.Text))
            {
                arquivoExcel = txtArquivoExcel.Text;
                CarregaDadosExcel();
                //ValidateData();
                btnSqlServer.Visible = true;
            }
            else
            {
                CarregaDadosExcel();
            }
        }


        private void btnSqlServer_Click(object sender, EventArgs e)
        {
            try
            {
                string rpta = "";
                if (dgvDados.RowCount < 0)
                {
                    MessageBox.Show("Nao ha dados para importar");
                }
                else
                {
                    for (int i = 0; i < dgvDados.Rows.Count; i++)
                    {
                        Comando.Connection = Con.OpenConection();
                        Comando.CommandText = "Inc_upd_entrada";
                        Comando.CommandType = CommandType.StoredProcedure;

                        Comando.Parameters.AddWithValue("@codigo", Convert.ToString(dgvDados.Rows[i].Cells["codigo"].Value.ToString().TrimEnd()));
                        Comando.Parameters.AddWithValue("@quantidade", Convert.ToString(dgvDados.Rows[i].Cells["quantidade"].Value.ToString().TrimEnd()));
                        Comando.Parameters.AddWithValue("@data", Convert.ToString(dgvDados.Rows[i].Cells["data"].Value.ToString().TrimEnd()));

                        Comando.ExecuteNonQuery();
                        Comando.Parameters.Clear();

                        //rpta = BImportProduct.ImportProduct(
                        //    Convert.ToString(dgvDados.Rows[i].Cells["code"].Value.ToString().TrimEnd()),
                        //    Convert.ToString(dgvDados.Rows[i].Cells["code2"].Value.ToString().TrimEnd()),
                        //    Convert.ToString(dgvDados.Rows[i].Cells["description"].Value.ToString().TrimEnd()),
                        //    Convert.ToString(dgvDados.Rows[i].Cells["detail_description"].Value.ToString().TrimEnd()),
                        //    Convert.ToDecimal(dgvDados.Rows[i].Cells["price"].Value.ToString().TrimEnd()),
                        //    Convert.ToInt32(dgvDados.Rows[i].Cells["category_id"].Value.ToString().TrimEnd()),
                        //    Convert.ToInt32(dgvDados.Rows[i].Cells["product_stock"].Value.ToString().TrimEnd()),
                        //    Convert.ToInt32(dgvDados.Rows[i].Cells["product_stock_future"].Value.ToString().TrimEnd()),
                        //    Convert.ToInt32(dgvDados.Rows[i].Cells["qtd_min"].Value.ToString().TrimEnd()),
                        //    Convert.ToInt32(dgvDados.Rows[i].Cells["multiple"].Value.ToString().TrimEnd()),
                        //    Convert.ToString(dgvDados.Rows[i].Cells["image"].Value.ToString().TrimEnd()),
                        //    Convert.ToInt32(dgvDados.Rows[i].Cells["is_kit"].Value.ToString().TrimEnd()),
                        //    Convert.ToInt32(dgvDados.Rows[i].Cells["ipi"].Value.ToString().TrimEnd()),
                        //    Convert.ToInt32(dgvDados.Rows[i].Cells["id_branch"].Value.ToString().TrimEnd()),
                        //    Convert.ToDateTime(dgvDados.Rows[i].Cells["product_stock_date"].Value.ToString().TrimEnd()),
                        //    Convert.ToDateTime(dgvDados.Rows[i].Cells["product_stock_future_date"].Value.ToString().TrimEnd()));

                        //ProgressBar.Value = i * ProgressBar.MaximumValue / dgvDados.Rows.Count + 1;
                        //lblProgres.Text = i.ToString() + " Linhas Importadas";
                        ////lblProgres.Update();
                        //circleProgres.Value = i * ProgressBar.MaximumValue / dgvDados.Rows.Count + 1;
                        //circleProgres.Update();

                        ////Application.DoEvents();
                        //ProgressBar.Show();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
    }
}

