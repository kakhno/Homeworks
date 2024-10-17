using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework10._1
{
    internal abstract class FileWorker
    {
        public int FileMaxStorage { get; set; }

        public string FileType { get; set; }

        public abstract string GetFileType();

        public FileWorker(int FileMaxStorage) 
        {
            this.FileMaxStorage = FileMaxStorage;
        }

        public void SetFileType(string type) 
        {
            FileType = type;
        }

        public virtual void Write()
        {
            Console.WriteLine($"I can write to {FileType} file with max storage {FileMaxStorage}");
        }

        public void Read()
        {
            Console.WriteLine($"I can read from {FileType} file with max storage {FileMaxStorage}");
        }

        public void Delete()
        {
            Console.WriteLine($"I can delete from {FileType} file with max storage {FileMaxStorage}");
        }
        
        public void Edit()
        {
            Console.WriteLine($"I can edit {FileType} file with max storage {FileMaxStorage}");
        }


    }

    internal class Nextclass : FileWorker
    {
        public Nextclass(int FileMaxStorage) : base(FileMaxStorage)
        {
            SetFileType(".txt");
        }

        public override string GetFileType()
        {
            return FileType;
        }
    }
}
