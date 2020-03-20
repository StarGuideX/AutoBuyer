using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AutoBuyer
{
    public static class FileHelper
    {
        public static void CheckDirectory(string path) 
        {
            if (Directory.Exists(path) == false)
            {
                Directory.CreateDirectory(path);
            }
        }
    }
}
