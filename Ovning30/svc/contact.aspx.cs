using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySQLLibrary;
using Newtonsoft.Json;

namespace Ovning30.svc
{
    public partial class contact : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request["action"] != null)
            {
                string action = Request["action"].ToString();

                if (action == "getAllContacts")
                {
                    List<Person> contacts = SQL.GetAllContacts();

                    JSONLiteral.Text = JsonConvert.SerializeObject(contacts);
                }


                // contact.aspx?action=addContact&firstName=KAlle&Lastname=Olsson ....

                if(action == "addContact")
                {
                    string firstName = Request["firstName"] != null ? Request["firstName"].ToString() : "";

                    // Add to SQL, return something


                    JSONLiteral.Text = JsonConvert.SerializeObject("ok");
                }
            }
        }
    }
}