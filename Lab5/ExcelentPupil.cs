using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    internal class ExcelentPupil : Pupil
    {
        public override void Study()
        {
            base.Study();
            Console.Write("Відмінно.");
        }
        public override void Read()
        {
            base.Read();
            Console.Write("Багато.");
        }
        public override void Write()
        {
            base.Write();
            Console.Write("Якісно.");
        }
        public override void Relax()
        {
            base.Relax();
            Console.Write("Мало.");
        }
    }
}
