using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySQLLibrary;

namespace Ovning30
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                foreach (var p in SQL.GetAllContacts())
                {
                    ListBoxContacts.Items.Add($"{p.Firstname} {p.Lastname}");
                }
            }
        }

        protected void ListBoxContacts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ListBoxContacts.SelectedIndex >= 0)
            {
                Person p = SQL.GetAllContacts()[ListBoxContacts.SelectedIndex];

                TextBoxFirstname.Text = p.Firstname;
                TextBoxLastname.Text = p.Lastname;
                TextBoxSSN.Text = p.SSN;

                //LiteralInfo.Text = "javascript:alert('ERROR');";
            }
        }
    }
}