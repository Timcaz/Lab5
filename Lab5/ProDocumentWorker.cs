using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace Lab5
{
    internal class ProDocumentWorker : DocumentWorker
    {
        private string dataToFile;
        protected StreamWriter file;
        protected string DataToFile { get { return dataToFile; } set { dataToFile = value; } }
        public override void EditDocument()
        {
            Console.Write("Напишіть назву файла(у теці з виконувальним файлом): ");
            Path = Console.ReadLine();
            file = new(Path, append: true);
            Console.WriteLine("Напішить щоб додати в кінець файлу дані: ");
            DataToFile = Console.ReadLine();
            Console.WriteLine("Документ відредаговано");
            SaveDocument();
        }
        public override void SaveDocument()
        {
            file.WriteLineAsync(DataToFile);
            Console.WriteLine("Документ збережено у старому форматі, збереження в інших форматах доступне у версії Експерт");
        }
        public override void ShowLicense()
        {
            Console.WriteLine("Ви використовуєте Про версію.");
        }
    }
}
