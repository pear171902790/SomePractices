using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebControls
{
    public partial class UpdatePanel : System.Web.UI.Page
    {
        protected string Str { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                Str = "Ajaxed";
            }
        }

        protected void Btn2_Click(object sender, EventArgs e)
        {
            Txt1.Text = "111";
            Txt2.Text = "222";
        }
    }
}