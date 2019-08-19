using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace CasoPropuesto1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["neptuno"].ConnectionString);
        public void ListaClientes()
        {
            using (SqlDataAdapter df = new SqlDataAdapter("Usp_ListaClientes_Neptuno", cn))
            {
                df.SelectCommand.CommandType = CommandType.StoredProcedure;
                using (DataSet Da = new DataSet())
                {
                    df.Fill(Da, "Clientes");
                    DgClientes.DataSource = Da.Tables["Clientes"];
                    txtTotal.Text = Da.Tables["Clientes"].Rows.Count.ToString();
                }
            }
        }

        public void BusquedaClientes()
        {
            using (SqlDataAdapter Df = new SqlDataAdapter("Usp_ListaClientes_Neptuno_3", cn))
            {
                SqlParameter sqlParameter = new SqlParameter();
                sqlParameter.Value = txtFiltro.Text;
                sqlParameter.SqlDbType = SqlDbType.VarChar;
                sqlParameter.Size = 100;
                sqlParameter.ParameterName = "@NombreContacto";

                Df.SelectCommand.Parameters.Add(sqlParameter);
                Df.SelectCommand.CommandType = CommandType.StoredProcedure;

                using (DataSet Da = new DataSet())
                {
                    Df.Fill(Da, "Clientes");
                    DgClientes.DataSource = Da.Tables["Clientes"];
                    txtTotal.Text = Da.Tables["Clientes"].Rows.Count.ToString();
                }
            }
        }

        private void Label1_Click(object sender, EventArgs e){}
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'neptunoDataSet.clientes' Puede moverla o quitarla según sea necesario.

            //this.clientesTableAdapter.Fill(this.neptunoDataSet.clientes);
            ListaClientes();
        }

        private void BtnFiltro_Click(object sender, EventArgs e)
        {
            BusquedaClientes();
        }

        private void LblFiltro_Click(object sender, EventArgs e)
        {

        }
    }
}
