using System;
using System.IO;

namespace FileLoggerKata
{
    public interface IFileSystem
    {
        void Append(string path, string message);
        void Create(string path);
        bool Exists(string path);
        DateTime GetLastWriteTime(string path);
        void Rename(string currentPath, string newPath);
    }
    public class FileSystem : IFileSystem
    {
        public bool Exists(string path)
        {
            return File.Exists(path);
        }
        public void Create(string path)
        {
            File.AppendAllText(path,"");
        }
        public void Append(string path, string message)
        {
            File.AppendAllText(path, message);
            //Console.WriteLine("Append Method Here");
        }
        public DateTime GetLastWriteTime(string path)
        {
            return File.GetLastWriteTime(path);
        }
        public void Rename(string currentPath, string newPath)
        {
            if(File.Exists(newPath))
            {
                File.Delete(newPath);
                File.Move(currentPath, newPath);
            }
            else
            {
                File.Move(currentPath,newPath);
            }
        }

    }
}