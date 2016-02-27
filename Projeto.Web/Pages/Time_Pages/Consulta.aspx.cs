using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Projeto.DAL.Persistence;
using Projeto.Entity.Entities;

namespace Projeto.Web.Pages.Time_Pages
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
            TimeDal d = new TimeDal();
            gridTime.DataSource = d.FindAll();
            gridTime.DataBind();
        }

        protected void gridTime_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gridTime.EditIndex = e.NewEditIndex;
            gridBind();
        }

        protected void gridTime_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gridTime.EditIndex = -1;
            gridBind();
        }

        protected void gridTime_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            try
            {
                int index = gridTime.EditIndex;
                GridViewRow row = gridTime.Rows[index];

                Time t = new Time();
                t.IdTime = Convert.ToInt32(gridTime.DataKeys[e.RowIndex].Value.ToString());
                t.Nome = Convert.ToString(((TextBox)(row.Cells[1].Controls[0])).Text);
                t.DataFundacao = Convert.ToDateTime(((TextBox)(row.Cells[2].Controls[0])).Text);

                TimeDal d = new TimeDal();
                d.Update(t);

                lblMensagem.Text = "Time Atualizado.";

                gridTime.EditIndex = -1;
                gridBind();
            }
            catch (Exception ex)
            {
                lblMensagem.Text = ex.Message;
            }
        }

        protected void gridTime_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                TimeDal d = new TimeDal();
                d.Delete(Convert.ToInt32(gridTime.DataKeys[e.RowIndex].Value.ToString()));

                lblMensagem.Text = "Time excluído.";

                gridBind();
            }
            catch (Exception ex)
            {
                lblMensagem.Text = ex.Message;
            }
        }
    }
}