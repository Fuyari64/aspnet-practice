using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
// PACOTES PARA ENVIAR O EMAIL
using System.Net.Mail;
using System.Net;
using SI2022Noturno;


namespace Projeto3._1
{
    public partial class FaleConosco : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Enviar_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. VALIDAR OS DADOS
            
                if(SeuNome.Text.Trim() == "")
                {
                    MensagemErro.Text = "Digite seu nome";
                }
                else if(SeuEmail.Text.Trim() == "")
                {
                    MensagemErro.Text = "Digite seu email";
                }
                else if(Mensagem.Text.Trim() == "")
                {
                    MensagemErro.Text = "Digite uma mensagem";
                }
                else
                {
                    // 2. CONSTRUIR O E-MAIL
                    MailMessage email = new MailMessage();
                    email.To.Add("contato@seudominio.com.br");
                    MailAddress from = new MailAddress("contato@seudominio.com.br");
                    email.From = from;
                    email.Subject = "Email enviado pela pagina de contato";
                    email.Body =  "Nome: " + SeuNome.Text + "\n";
                    email.Body += "Email: " + SeuEmail.Text + "\n";
                    email.Body += "Mensagem: " + Mensagem.Text + "\n";

                    // 3 . ENVIAR O EMAIL
                    SmtpClient smtp = new SmtpClient();
                    smtp.Host = "smtp.seudominio.com.br";
                    smtp.Credentials = new NetworkCredential("contato@seudominio.com.br", "suasenha");
                    smtp.Send(email);
                    // fim
                }
            }
            catch (Exception err)
            {
                MensagemErro.Text = "Houve uma falha ao enviar o email";

                TratamentoExcecao tratamentoExcecao = new TratamentoExcecao();

                // 4. gravar exceção no arquivo logerros.txt
                tratamentoExcecao.GravarErro(err);
            }
        }
    }
}