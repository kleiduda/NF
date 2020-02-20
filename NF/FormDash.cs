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
    public partial class FormDash : Form
    {
   
        public FormDash()
        {
            InitializeComponent();
        }

        private void btnEntrada_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            FormSaida frm = new FormSaida();
            frm.Show();
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            FormResultado frm = new FormResultado();
            frm.Show();
        }
    }
}

