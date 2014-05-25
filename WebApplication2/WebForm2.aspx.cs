using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Init();
            }
            
        }
        private void Init()
        {
            Lv.DataSource = Db.Persons;
            Lv.DataBind();
        }

        protected void Lv_ItemDeleting(object sender, ListViewDeleteEventArgs e)
        {
            var id = Convert.ToInt32(Lv.DataKeys[e.ItemIndex].Value);
            var person = Db.Persons.SingleOrDefault(p => p.Id == id);
            Db.Persons.Remove(person);
            Init();
        }

       
    }
}