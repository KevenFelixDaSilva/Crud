using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crud_1._0
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-NV5JKSN\SQLEXPRESS; integrated security=SSPI;initial catalog=db_projeto");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dt;



        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                string strSQL = "Select pl_placa from tbl_Cliente where pl_placa = " + txtPlaca.Text;
                cm.Connection = cn; 
                cm.CommandText = strSQL;
                dt = cm.ExecuteReader();
                if (dt.HasRows)
                {
                    MessageBox.Show("Placa ja cadratrada");
                }
                else
                {
                    if (!dt.IsClosed) { dt.Close(); }
                    strSQL = "insert into tbl_Cliente(nm_cliente,md_modelo,cr_cor,pl_placa)values(@cliente,@modelo,@cor,@placa)";
                    cm.Parameters.Add("@cliente",SqlDbType.VarChar).Value = txtNome.Text;
                    cm.Parameters.Add("@modelo", SqlDbType.VarChar).Value = txtModelo.Text;
                    cm.Parameters.Add("@cor", SqlDbType.VarChar).Value = txtCor.Text;
                    cm.Parameters.Add("@placa", SqlDbType.VarChar).Value = txtPlaca.Text;

                    cm.Connection = cn;
                    cm.CommandText = strSQL;

                    cm.ExecuteNonQuery();

                    MessageBox.Show("dados cadastrados com sucesso");

                    cm.Parameters.Clear();
                    cn.Close();
                }
            }

            catch(Exception erro)
            {
                MessageBox.Show(erro.Message);
                cn.Close();
            }
        }

        private void txtPlaca_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
