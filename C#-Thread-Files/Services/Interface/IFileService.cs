using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Thread_Files.Services.Interface
{
    internal interface IFileService
    {
        Task WriteToExistFileAsync(string path, string text);
        Task<string> ReadFromFileAsync(string path);
        Task WriteToNewFile(string path, string text);
        Task DeleteAsync(string path);
    }

}
