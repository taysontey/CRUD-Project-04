using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Projeto.Entity.Entities;
using Projeto.DAL.Persistence;

namespace Projeto.Web.Pages.Time_Pages
{
    public partial class Cadastro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCadastro_Click(object sender, EventArgs e)
        {
            try
            {
                Time t = new Time();
                t.Nome = txtNome.Text;
                t.DataFundacao = DateTime.Parse(txtDataFundacao.Text);

                TimeDal d = new TimeDal();
                d.Insert(t);

                lblMensagem.Text = "Time " + t.Nome + ", cadastrado com sucesso.";

                LimparCampos();

            }
            catch (Exception ex)
            {
                lblMensagem.Text = ex.Message;
            }
        }

        protected void LimparCampos()
        {
            txtNome.Text = string.Empty;
            txtDataFundacao.Text = string.Empty;
        }
    }
}