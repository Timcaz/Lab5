using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    internal class BadPupil : Pupil
    {
        public override void Study()
        {
            base.Study();
            Console.Write("Погано.");
        }
        public override void Read()
        {
            base.Read();
            Console.Write("Мало.");
        }
        public override void Write()
        {
            base.Write();
            Console.Write("Нічого.");
        }
        public override void Relax()
        {
            base.Relax();
            Console.Write("Багато.");
        }
    }
}
