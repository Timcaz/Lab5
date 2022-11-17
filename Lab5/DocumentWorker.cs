using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab5
{
    internal class DocumentWorker
    {
        private static string path;
        private FileStream fs;
        public virtual void OpenDocument()
        {
            Console.Write("Напишіть назву файла(у теці з виконувальним файлом): ");
            path = Console.ReadLine();
            if(path == null) { Console.WriteLine("Введіть шлях!"); return; }
            if (!File.Exists(path)) { Console.WriteLine("Файла не існує!"); return; }
            fs = new FileStream(Path, FileMode.Open, FileAccess.Read);
            Console.WriteLine("Документ відкритий");
            byte[] buf = new byte[1024];
            int c;
            while ((c = fs.Read(buf, 0, buf.Length)) > 0)
            {
                Console.WriteLine(Encoding.UTF8.GetString(buf, 0, c));
            }
            fs.Close();
        }
        protected static string Path { get { return path; } set { path = value; } }
        protected FileStream Fs { get { return fs; } set { fs = value; } }
        public virtual void EditDocument()
        {
            Console.WriteLine("Правка документа доступна у версії Про");
        }
        public virtual void SaveDocument()
        {
            Console.WriteLine("Збереження документа доступне у версії Про");
        }
        public virtual void ShowLicense()
        {
            Console.WriteLine("Ви використовуєте безкоштовну версію.");
        }
    }
}
