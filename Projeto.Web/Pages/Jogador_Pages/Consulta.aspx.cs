using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Projeto.DAL.Persistence;
using Projeto.Entity.Entities;
using System.Data;

namespace Projeto.Web.Pages.Jogador_Pages
{
    public partial class Consulta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                gridBind();
            }
        }

        protected void gridBind()
        {
            JogadorDal d = new JogadorDal();
            gridJogador.DataSource = d.FindAll();
            gridJogador.DataBind();
        }

        protected void gridJogador_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gridJogador.EditIndex = e.NewEditIndex;
            gridBind();
        }

        protected void gridJogador_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gridJogador.EditIndex = -1;
            gridBind();
        }

        protected void gridJogador_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            try
            {
                int index = gridJogador.EditIndex;
                GridViewRow row = gridJogador.Rows[index];

                Jogador j = new Jogador();
                j.IdJogador = Convert.ToInt32(gridJogador.DataKeys[e.RowIndex].Value.ToString());
                j.Nome = Convert.ToString(((TextBox)(row.Cells[1].Controls[0])).Text);
                j.Apelido = Convert.ToString(((TextBox)(row.Cells[2].Controls[0])).Text);
                j.DataNascimento = Convert.ToDateTime(((TextBox)(row.Cells[3].Controls[0])).Text);
                j.Posicao = Convert.ToString(((TextBox)(row.Cells[4].Controls[0])).Text);
                j.IdTime = Convert.ToInt32((gridJogador.Rows[e.RowIndex].FindControl("dropDownTimes") as DropDownList).SelectedItem.Value);

                JogadorDal d = new JogadorDal();
                d.Update(j);

                lblMensagem.Text = "Jogador Atualizado.";

                gridJogador.EditIndex = -1;
                gridBind();
            }
            catch (Exception ex)
            {
                lblMensagem.Text = ex.Message;
            }
        }

        protected void gridJogador_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if(e.Row.RowType == DataControlRowType.DataRow)
            {
                if((e.Row.RowState & DataControlRowState.Edit) > 0)
                {
                    DropDownList dropDown = (DropDownList)e.Row.FindControl("dropDownTimes");
                    TimeDal d = new TimeDal();
                    dropDown.DataSource = d.FindAll();
                    dropDown.DataTextField = "Nome";
                    dropDown.DataValueField = "IdTime";
                    dropDown.DataBind();
                    dropDown.Items.Insert(0, new ListItem("Escolha um Time", ""));
                    dropDown.SelectedIndex = 0;
                }
            }
        }

        protected void gridJogador_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                JogadorDal d = new JogadorDal();
                d.Delete(Convert.ToInt32(gridJogador.DataKeys[e.RowIndex].Value.ToString()));

                lblMensagem.Text = "Jogador excluído.";

                gridBind();
            }
            catch (Exception ex)
            {
                lblMensagem.Text = ex.Message;
            }
        }
    }
}