using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebControls
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected bool A { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            A = true;
            Txt1.Text = "22222";
        }
    }
}