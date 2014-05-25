using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Project> list=new List<Project>()
                {
                    new Project()
                        {
                            Name = "aa",Price = 23.5
                        },
                        new Project()
                        {
                            Name = "aa",Price = 23.5
                        },
                        new Project()
                        {
                            Name = "aa",Price = 23.5
                        },
                        new Project()
                        {
                            Name = "aa",Price = 23.5
                        },
                        new Project()
                        {
                            Name = "aa",Price = 23.5
                        },
                        new Project()
                        {
                            Name = "aa",Price = 23.5
                        },
                        new Project()
                        {
                            Name = "aa",Price = 23.5
                        },
                        new Project()
                        {
                            Name = "aa",Price = 23.5
                        },
                        new Project()
                        {
                            Name = "aa",Price = 23.5
                        }
                };
            Response.Write(list.Sum(p => p.Price));

        }
    }

    public class Project
    {
        public string Name { get; set; }
        public double Price { get; set; }
    }
}