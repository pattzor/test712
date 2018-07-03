using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySQLLibrary;

namespace Ovning30
{
    public partial class index2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string contactTable = "<table class=\"table table-striped table-hover\"><thead><tr><td>Firstname</td><td>Lastname</td><td>SSN</td></tr></thead>";

            contactTable += "<tbody>";

            foreach (var p in SQL.GetAllContacts())
            {
                contactTable += $"<tr><td><a href='/Contact.aspx?cid={p.ID}'>{p.Firstname}</a></td><td>{p.Lastname}</td><td>{p.SSN}</td></tr>";
            }

            contactTable += "</tbody>";
            contactTable += "</table>";

            LiteralContacts.Text = contactTable;
        }
    }
}