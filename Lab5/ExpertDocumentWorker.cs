using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    internal class ExpertDocumentWorker : ProDocumentWorker
    {
        public override void SaveDocument()
        {
            string pathtmp = "";
            foreach(char CH in Path)
            {
                if(CH != '.')
                {
                    pathtmp += CH;
                }
                else
                {
                    break;
                }
            }
            Path = pathtmp + ".abc";
            file = new(Path, append: true);
            file.WriteLineAsync(DataToFile);
            Console.WriteLine("Документ збережений в новому форматі");
        }
        public override void ShowLicense()
        {
            Console.WriteLine("Ви використовуєте Експерт версію.");
        }
    }
}
