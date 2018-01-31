using System;
using System.IO;

namespace Task_1Services
{
    internal class FileService : IFileService
    {
        private static readonly Lazy<FileService> _lazy = new Lazy<FileService>(() => new FileService());

        private FileService()
        { }
        public static FileService GetInstance()
        {
            return _lazy.Value;
        }

        public FileStream OpenFile(string path)
        {
            return File.Open(path, FileMode.Open);
        }
        public void SaveFile(byte[] file, string path)
        {
            File.WriteAllBytes(path, file);
        }
        public void DeleteFile(string path)
        {
            File.Delete(path);
        }
        public void CopyFile(string pathSource, string pathDest)
        {
            File.Copy(pathSource, pathDest);
        }
    }
}
