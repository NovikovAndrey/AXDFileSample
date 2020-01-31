using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AXDFileSample
{
    public class PictureViewHandler : IHttpHandler
    {
        public bool IsReusable => false;

        public void ProcessRequest(HttpContext context)
        {
            
        }
    }
}