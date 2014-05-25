using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    public class MyModule:IHttpModule
    {
        public void Init(HttpApplication application)
        {
            application.EndRequest += (o, e) => application.Context.Response.Write("jiashangle");
        }

        public void Dispose()
        {
            
        }
    }
}