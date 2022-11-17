using System.Runtime.CompilerServices;

namespace Lab5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // #1
            Printer printer = new Printer();
            printer.Print("say");
            Printer2 printer2 = new Printer2();
            printer2.Print("say");

            // #2
            Pupil pup0 = new ExcelentPupil();
            Pupil pup1 = new BadPupil();
            ClassRoom classRoom = new ClassRoom(pup0, pup1);
            classRoom.ShowPup();

            // #3
            DocumentWorker worker;
            const string proKey = "A11C2363A28643BB";
            const string expertKey = "30BCC145D8FEBBA8";
            string getKey;
            Console.Write("Введіть ключ версії Про/Експерт(звичайна версія безкоштовна):");
            getKey = Console.ReadLine();
            switch (getKey)
            {
                case proKey:
                    worker = new ProDocumentWorker();
                    worker.ShowLicense();
                    break;
                case expertKey:
                    worker = new ExpertDocumentWorker();
                    worker.ShowLicense();
                    break;
                default:
                    worker = new DocumentWorker();
                    worker.ShowLicense();
                    break;
            }
            worker.OpenDocument();
            worker.EditDocument();
        }
    }
}