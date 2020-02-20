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
        public void FormatarTabela()
        {


            dgvResultado.Columns["codigo"].HeaderText = "Cod.Entrada";
            dgvResultado.Columns["codigo1"].HeaderText = "Cod.Saida";

            dgvResultado.Columns["quantidade"].HeaderText = "Qtd.Entrada";
            dgvResultado.Columns["quantidade1"].HeaderText = "Qtd.Saida";

        }


    }
}

