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
    public partial class Consulta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
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

        protected void gridJogador_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }

        protected void gridJogador_RowEditing(object sender, GridViewEditEventArgs e)
        {

        }

        protected void gridJogador_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {

        }

        protected void gridJogador_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {

        }
    }
}