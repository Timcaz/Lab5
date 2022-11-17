using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    internal class GoodPupil : Pupil 
    {
        public override void Study()
        {
            base.Study();
            Console.Write("Нормально.");
        }
        public override void Read()
        {
            base.Read();
            Console.Write("Середньо.");
        }
        public override void Write()
        {
            base.Write();
            Console.Write("Трохи.");
        }
        public override void Relax()
        {
            base.Relax();
            Console.Write("Нормально.");
        }
    }
}
