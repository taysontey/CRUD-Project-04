using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Projeto.DAL.Persistence;
using Projeto.Entity.Entities;

namespace Projeto.Web.Pages.Jogador_Pages
{
    public partial class Cadastro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                dropDownList();
                dropDownTimes.Items.Insert(0, new ListItem("Escolha um Time", ""));
                dropDownTimes.SelectedIndex = 0;
            }
        }

        protected void dropDownList()
        {
            TimeDal d = new TimeDal();
            dropDownTimes.DataSource = d.FindAll();
            dropDownTimes.DataTextField = "Nome";
            dropDownTimes.DataValueField = "IdTime";
            dropDownTimes.DataBind();
        }

        protected void btnCadastro_Click(object sender, EventArgs e)
        {
            try
            {
                Jogador j = new Jogador();
                j.Nome = txtNome.Text;
                j.Apelido = txtApelido.Text;
                j.Posicao = txtPosicao.Text;
                j.DataNascimento = Convert.ToDateTime(txtDataNascimento.Text);
                j.IdTime = Convert.ToInt32(dropDownTimes.SelectedValue);

                JogadorDal d = new JogadorDal();
                d.Insert(j);

                lblMensagem.Text = "Jogador " + j.Nome + ", cadastrado com sucesso.";

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
            txtApelido.Text = string.Empty;
            txtPosicao.Text = string.Empty;
            txtDataNascimento.Text = string.Empty;
            dropDownTimes.SelectedIndex = 0;
        }
    }
}