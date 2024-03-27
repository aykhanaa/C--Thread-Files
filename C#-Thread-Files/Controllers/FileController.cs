using C__Thread_Files.Extension;
using C__Thread_Files.Services;
using C__Thread_Files.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Thread_Files.Controllers
{
    internal class FileController
    {
        private readonly IFileService _fileService;

        public FileController()
        {
            _fileService=new FileService();
        }
        public async Task ReadDataAsync()
        {
            string result = await _fileService.ReadFromFileAsync("C:\\Users\\Hp\\Desktop\\C#-Thread\\file2.txt");
            Console.WriteLine(result);
        }
        //C:\\Users\\Hp\\Desktop\\C#-Thread
        public async Task CreatFileWithContentAsync()
        {
            Console.WriteLine("Add path:");
            string path = Console.ReadLine();

            Console.WriteLine("Add file name:");
            string fileName = Console.ReadLine();

            Console.WriteLine("Add your text:");
            string text = Console.ReadLine();

            string resultPath = path.GenerateFullPath(fileName);
            await _fileService.WriteToExistFileAsync(resultPath, text);
        }

        public async Task DeleteAsync()
        {
            await _fileService.DeleteAsync("C:\\Users\\Hp\\Desktop\\C#-Thread\\file7.txt");
        }
    }
}
