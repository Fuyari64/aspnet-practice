using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SI2022Noturno;

namespace Projeto3._1
{
    public partial class ExibirExcecoes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TratamentoExcecao tratamentoExcecao = new TratamentoExcecao();
            Excecoes.Text = tratamentoExcecao.LerErros().Replace("\n", "<br>");
        }

        protected void Limpar_Click(object sender, EventArgs e)
        {
            TratamentoExcecao tratamentoExcecao = new TratamentoExcecao();
            tratamentoExcecao.ApagarLog();
            Excecoes.Text = "";
        }
    }
}