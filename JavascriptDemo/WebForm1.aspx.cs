using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JavascriptDemo
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected A A { get; set; }
        protected string Json { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            var js = new JavaScriptSerializer();
            if (Request.HttpMethod == "GET")
            {
                A = new A()
                    {
                        B = new List<Tuple<string, string>>()
                            {
                                new Tuple<string, string>("11", "22"),
                                new Tuple<string, string>("33", "44")
                            },
                        C = new C()
                    };
                
                //Json = js.Serialize(A);
                Json = Newtonsoft.Json.JsonConvert.SerializeObject(A);
               // var a = js.Deserialize<A>(Json);
                var a=Newtonsoft.Json.JsonConvert.DeserializeObject<A>(Json);
            }
            else
            {
                var sr = new StreamReader(Request.InputStream);
                var str = sr.ReadToEnd();
                var a = js.Deserialize<A>(str);
            }
        }
    }

    public class A
    {
        public List<Tuple<string, string>> B { get; set; }
        public IC C { get; set; }
    }

    public interface IC
    {
        void Cc();
    }

    public class C : IC
    {
        public void Cc()
        {
        }
    }
}