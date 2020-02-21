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
    public partial class FormResultado : Form
    {
        Microsoft.Office.Interop.Excel.Application XcelApp = new Microsoft.Office.Interop.Excel.Application();
        protected Conection Con = new Conection();
        protected SqlCommand Comando = new SqlCommand();
        protected SqlDataReader LerLinhas;
        public FormResultado()
        {
            InitializeComponent();
        }
        private void FormResultado_Load(object sender, EventArgs e)
        {
            listarCadastros();
            listarCadastrosSoEntrada();
            listarCadastrosSaida();
            FormatarTabela();
        }

        public void listarCadastros()
        {
            Comando.Connection = Con.OpenConection();
            Comando.CommandText = "select e.codigo, e.quantidade, e.data, s.codigo, s.quantidade, (e.quantidade - s.quantidade) as Saldo from tb_entrada e inner join tb_saida s ON e.codigo = s.codigo";
            Comando.CommandType = CommandType.Text;

            SqlDataAdapter SqlDat = new SqlDataAdapter(Comando);
            DataTable DtResult = new DataTable();
            SqlDat.Fill(DtResult);
            dgvResultado.DataSource = DtResult;
        }
        public void listarCadastrosSoEntrada()
        {
            Comando.Connection = Con.OpenConection();
            Comando.CommandText = "select * from tb_entrada where codigo not in (select codigo from tb_saida)";
            Comando.CommandType = CommandType.Text;

            SqlDataAdapter SqlDat = new SqlDataAdapter(Comando);
            DataTable DtResult = new DataTable();
            SqlDat.Fill(DtResult);
            dgvSoentrada.DataSource = DtResult;
        }
        public void listarCadastrosSaida()
        {
            Comando.Connection = Con.OpenConection();
            Comando.CommandText = "select * from tb_saida where codigo not in (select codigo from tb_entrada)";
            Comando.CommandType = CommandType.Text;

            SqlDataAdapter SqlDat = new SqlDataAdapter(Comando);
            DataTable DtResult = new DataTable();
            SqlDat.Fill(DtResult);
            dgvSaida.DataSource = DtResult;
        }
        public void FormatarTabela()
        {


            dgvResultado.Columns["codigo"].HeaderText = "Cod.Entrada";
            dgvResultado.Columns["codigo1"].HeaderText = "Cod.Saida";

            dgvResultado.Columns["quantidade"].HeaderText = "Qtd.Entrada";
            dgvResultado.Columns["quantidade1"].HeaderText = "Qtd.Saida";

        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            if (dgvResultado.Rows.Count > 0)
            {
                try
                {
                    XcelApp.Application.Workbooks.Add(Type.Missing);
                    for (int i = 1; i < dgvResultado.Columns.Count + 1; i++)
                    {
                        XcelApp.Cells[1, i] = dgvResultado.Columns[i - 1].HeaderText;
                    }
                    //
                    for (int i = 0; i < dgvResultado.Rows.Count - 1; i++)
                    {
                        for (int j = 0; j < dgvResultado.Columns.Count; j++)
                        {
                            XcelApp.Cells[i + 2, j + 1] = dgvResultado.Rows[i].Cells[j].Value.ToString();
                        }
                    }
                    //
                    XcelApp.Columns.AutoFit();
                    //
                    XcelApp.Visible = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro : " + ex.Message);
                    XcelApp.Quit();
                }
            }
        }

        private void btnSoEntrada_Click(object sender, EventArgs e)
        {
            if (dgvSoentrada.Rows.Count > 0)
            {
                try
                {
                    XcelApp.Application.Workbooks.Add(Type.Missing);
                    for (int i = 1; i < dgvSoentrada.Columns.Count + 1; i++)
                    {
                        XcelApp.Cells[1, i] = dgvSoentrada.Columns[i - 1].HeaderText;
                    }
                    //
                    for (int i = 0; i < dgvSoentrada.Rows.Count - 1; i++)
                    {
                        for (int j = 0; j < dgvSoentrada.Columns.Count; j++)
                        {
                            XcelApp.Cells[i + 2, j + 1] = dgvSoentrada.Rows[i].Cells[j].Value.ToString();
                        }
                    }
                    //
                    XcelApp.Columns.AutoFit();
                    //
                    XcelApp.Visible = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro : " + ex.Message);
                    XcelApp.Quit();
                }
            }
        }

        private void btnSaida_Click(object sender, EventArgs e)
        {
            if (dgvSaida.Rows.Count > 0)
            {
                try
                {
                    XcelApp.Application.Workbooks.Add(Type.Missing);
                    for (int i = 1; i < dgvSaida.Columns.Count + 1; i++)
                    {
                        XcelApp.Cells[1, i] = dgvSaida.Columns[i - 1].HeaderText;
                    }
                    //
                    for (int i = 0; i < dgvSaida.Rows.Count - 1; i++)
                    {
                        for (int j = 0; j < dgvSaida.Columns.Count; j++)
                        {
                            XcelApp.Cells[i + 2, j + 1] = dgvSaida.Rows[i].Cells[j].Value.ToString();
                        }
                    }
                    //
                    XcelApp.Columns.AutoFit();
                    //
                    XcelApp.Visible = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro : " + ex.Message);
                    XcelApp.Quit();
                }
            }
        }
    }
}

