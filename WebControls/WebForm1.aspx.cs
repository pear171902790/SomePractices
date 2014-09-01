using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newtonsoft.Json;

namespace WebControls
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Txt.Text = "aaa";
            var a = Table1;
        }
        

        protected void Add_Row(object sender, EventArgs e)
        {
            if (Session["trs"] != null)
            {
                var list = Session["trs"] as List<TableRow>;
                Table1.Rows.Clear();
                list.ForEach(r=>Table1.Rows.Add(r));
            }
            var tc = new TableCell() { Text = "haha" };
            var tr = new TableRow();
            tr.Cells.Add(tc);
            Table1.Rows.Add(tr);
            var trs = new List<TableRow>();
            for (var i = 0; i < Table1.Rows.Count; i++)
            {
                trs.Add(Table1.Rows[i]);
            }
            Session["trs"] = trs;

        }

        protected void Add_Row2(object sender, EventArgs e)
        {
//            if (!string.IsNullOrEmpty(Hid1.Value))
//            {
//                var list =Convert.ToByte()
//                Table1.Rows.Clear();
//                list.ForEach(r => Table1.Rows.Add(r));
//            }
            var tc = new TableCell() { Text = "haha" };
            var tr = new TableRow();
            tr.Cells.Add(tc);
            Table1.Rows.Add(tr);
            var trs = new List<TableRow>();
            for (var i = 0; i < Table1.Rows.Count; i++)
            {
                trs.Add(Table1.Rows[i]);
            }
            var formatter=new BinaryFormatter();
            var ms=new MemoryStream();
            formatter.Serialize(ms,trs);
            Hid1.Value = Convert.ToBase64String(ms.ToArray());
        }
    }
}