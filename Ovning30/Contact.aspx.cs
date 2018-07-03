using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySQLLibrary;

namespace Ovning30
{
    public partial class Contact : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if(Session["something"] == null)
            {
                Session["something"] = "Nåt kul";
            }

            if(Request["cid"] != null)
            {
                int cid = Convert.ToInt32(Request["cid"].ToString());

                Person p = SQL.GetAllContacts().Find(c => c.ID == cid);

                if(p != null)
                {
                    LiteralContactInfo.Text = $"<h1>{p.Firstname} {p.Lastname} {p.SSN}</h1>";
                }

                LiteralContactInfo.Text += Session["something"].ToString();
            }
        }
    }
}