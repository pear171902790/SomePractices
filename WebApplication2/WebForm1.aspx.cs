using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class WebForm1 : System.Web.UI.Page
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
            Rpt.DataSource = Db.Persons;
            Rpt.DataBind();
        }

        protected void Rpt_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            switch (e.CommandName)
            {
                case "Delete":
                    Delete(e);
                    break;
                    
            }
            Init();
        }

        private void Delete(RepeaterCommandEventArgs e)
        {
            var id = Convert.ToInt32(e.CommandArgument);
            var person = Db.Persons.SingleOrDefault(p => p.Id == id);
            Db.Persons.Remove(person);
        }
    }

    public static class Db
    {
        public static List<Person> Persons= new List<Person>()
            {
                new Person(){Id=1,Name="aa",Age=12},
                new Person(){Id=2,Name="bb",Age=13},
                new Person(){Id=3,Name="cc",Age=14},
                new Person(){Id=4,Name="dd",Age=15},
                new Person(){Id=5,Name="ee",Age=16},
                new Person(){Id=6,Name="ff",Age=17}
            };
    }

    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}