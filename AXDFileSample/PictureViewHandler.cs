using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace AXDFileSample
{
    public class PictureViewHandler : IHttpHandler
    {
        public bool IsReusable => false;

        public void ProcessRequest(HttpContext context)
        {
            context.Response.Write("<html><head><title>Pictures</title></head>");
            context.Response.Write("<body>");
            context.Response.Write(GetPageContent(context));
            context.Response.Write("</body></html>");
        }

        private string GetPageContent(HttpContext context)
        {
            string path = context.Request.PhysicalPath;
            List<System.IO.FileInfo> files = GetAllImages(path);
            System.Text.StringBuilder htmlBuilder = new System.Text.StringBuilder();
            foreach(FileInfo fileInfo in files)
            {
                htmlBuilder.AppendFormat("<img src='{0}' alt='this is image'/><br/><br/>", fileInfo.Name);
            }
            return htmlBuilder.ToString();
        }

        private List<FileInfo> GetAllImages(string path)
        {
            List<FileInfo> images = new List<FileInfo>();
            List<string> extensions = new List<string>() { "*.bmp", "*.jpg", "*.png", "*.gif" };
            string folderPath = path.Replace("\\view.axd", string.Empty);
            DirectoryInfo dir = new DirectoryInfo(folderPath);
            foreach (string ext in extensions)
            {
                FileInfo[] files = dir.GetFiles(ext);
                if (files.Length>0)
                {
                    images.AddRange(files);
                }
            }
            return images;
        }
    }
}