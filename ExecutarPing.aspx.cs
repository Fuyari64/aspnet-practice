using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.NetworkInformation;
using SI2022Noturno;


namespace Projeto3._1
{
    public partial class ExecutarPing : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Enviar_Click(object sender, EventArgs e)
        {
            try
            {
                Ping execPing = new Ping();
                PingReply response = execPing.Send(Endereco.Text);

                if (response.Status == IPStatus.Success)
                {
                    Resultado.Text = "Status: "    +    response.Status.ToString() + "<br>";
                    Resultado.Text += "Endereço: " +    response.Address.ToString() + "<br>";
                    Resultado.Text += "Tempo: "    +    response.RoundtripTime.ToString() + "ms" + "<br>";
                    Resultado.Text += "Bytes: "    +    response.Buffer.Length.ToString() + "<br>";
                    Resultado.Text += "Nós: "      +    response.Options.Ttl.ToString() + "<br>";
                    Resultado.ForeColor = System.Drawing.Color.Green;
                } else
                {
                    Resultado.Text = "Falha na execução<br>";
                    Resultado.ForeColor = System.Drawing.Color.Red;
                }

            } catch (Exception err)
            {
                Resultado.Text = err.Message;
                Resultado.ForeColor = System.Drawing.Color.Red;

                TratamentoExcecao tratamentoExcecao = new TratamentoExcecao();
                tratamentoExcecao.GravarErro(err);
            }

        }
    }
}