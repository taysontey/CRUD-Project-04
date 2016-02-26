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
            if(!IsPostBack)
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

        protected void gridTime_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }

        protected void gridTime_RowEditing(object sender, GridViewEditEventArgs e)
        {

        }

        protected void gridTime_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {

        }

        protected void gridTime_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {

        }
    }
}