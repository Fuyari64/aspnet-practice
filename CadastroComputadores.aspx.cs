using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataServices.DataBase;
using System.Data;


namespace Projeto3._1
{
    public partial class CadastroComputadores : System.Web.UI.Page
    {
        DAO db = new DAO();
        Model.Computadores computador = new Model.Computadores();

        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                LoadDB();
            }
        }

        protected void LoadDB() 
        { 
            db.ConnectionString = App_Code.AppSettings.connectionString;
            db.DataProviderName = DAO.ProviderName.OleDb;

            string comandoSQL = "SELECT * FROM Computadores ORDER BY Identificacao ASC";

            //System.Data.DataTable tb = (System.Data.DataTable)db.Query(comandoSQL);
            ExibirComputadores.DataSource = (System.Data.DataTable)db.Query(comandoSQL);
            ExibirComputadores.DataBind();

            //tb.Dispose();
        }

        protected void InserirEditar_Click(object sender, EventArgs e)
        {
            if(Identificacao.Text.Trim() == "")
            {
                Mensagem.Text = "Digite a identificação";
            }
            else
            {
                if (ComputadorID.Text == "")
                {
                    //Insert
                    computador.Identificacao = Identificacao.Text;
                    computador.Anotacoes = Anotacoes.Text;
                    computador.Status = int.Parse(Status.SelectedValue);

                    db.ConnectionString = App_Code.AppSettings.connectionString;
                    db.DataProviderName = DAO.ProviderName.OleDb;

                    db.Insert(computador, "ComputadorID");
                }
                else
                {
                    //Update
                    computador.Identificacao = Identificacao.Text;
                    computador.Anotacoes = Anotacoes.Text;
                    computador.Status = int.Parse(Status.SelectedValue);

                    db.ConnectionString = App_Code.AppSettings.connectionString;
                    db.DataProviderName = DAO.ProviderName.OleDb;

                    db.Update(computador, "ComputadorID", ComputadorID.Text);
                }
                LimparControles();
                LoadDB();
            }
        }

        protected void Excluir_Click(object sender, EventArgs e)
        {
            string comandoSQL = "DELETE from Computadores WHERE ComputadorID =" + ComputadorID.Text;

            db.ConnectionString = App_Code.AppSettings.connectionString;
            db.DataProviderName = DAO.ProviderName.OleDb;
            db.Query(comandoSQL);

            LimparControles();
            LoadDB();
        }

        protected void LimparControles()
        {
            Mensagem.Text = "";
            ComputadorID.Text = "";
            Identificacao.Text = "";
            Anotacoes.Text = "";
            Status.SelectedValue = "1";
            InserirEditar.Text = "Inserir";
            Excluir.Visible = false;
            Cancelar.Visible = false;
        }

        protected void ExibirComputadores_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComputadorID.Text = ExibirComputadores.SelectedRow.Cells[1].Text;

            db.ConnectionString = App_Code.AppSettings.connectionString;
            db.DataProviderName = DAO.ProviderName.OleDb;

            string comandoSQL = "SELECT * FROM Computadores WHERE ComputadorID =" + db.Filter(ComputadorID.Text);

            System.Data.DataTable tb = (System.Data.DataTable)db.Query(comandoSQL);

            Identificacao.Text = tb.Rows[0]["Identificacao"].ToString();
            Anotacoes.Text = tb.Rows[0]["Anotacoes"].ToString();
            Status.SelectedValue = tb.Rows[0]["Status"].ToString();

            Excluir.Visible = true;
            InserirEditar.Text = "Editar";

        }

        protected void Buscar_Click(object sender, EventArgs e)
        {

            db.ConnectionString = App_Code.AppSettings.connectionString;
            db.DataProviderName = DAO.ProviderName.OleDb;

            string comandoSQL = "SELECT * FROM Computadores WHERE Identificacao LIKE '%" + db.Filter(BuscarComputador.Text) + "%'";

            ExibirComputadores.DataSource = (System.Data.DataTable)db.Query(comandoSQL);
            ExibirComputadores.DataBind();

            Cancelar.Visible = true;

        }

        protected void Cancelar_Click(object sender, EventArgs e)
        {
            BuscarComputador.Text = "";
            LimparControles();
            LoadDB();
        }
    }
}