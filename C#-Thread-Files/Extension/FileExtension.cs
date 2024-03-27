using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Thread_Files.Extension
{
    internal static class FileExtension
    {
        public static string GenerateFullPath(this string path,string fileName)
        {
            return $"{path}\\{fileName}";
        }
    }
}
