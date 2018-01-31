using System.IO;

namespace Task_1Services
{
    public interface IFileService
    {
        FileStream OpenFile(string path);
        void SaveFile(byte[] file, string path);
        void DeleteFile(string path);
        void CopyFile(string pathSource, string pathDest);
    }
}
