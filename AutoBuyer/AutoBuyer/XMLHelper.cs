using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Linq;

namespace AutoBuyer
{
    public static class XMLHelper
    {
        /// <summary>
        /// d:/aaa/a.xml
        /// </summary>
        /// <param name="path"></param>
        public static void Create(string path) 
        {
            XDocument document = new XDocument();
            document.Declaration = new XDeclaration("1.0", "utf-8", "yes");
            FileHelper.CheckDirectory(Path.GetDirectoryName(path));
            document.Save(path,SaveOptions.None);
        }

        public static void ss(XDocument document) 
        {
            document.Add();
        }
    }
}
