using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    internal class Pupil
    {
        public virtual void Study()
        {
            Console.Write("Вчиться...");
        }
        public virtual void Read()
        {
            Console.Write("Читає...");
        }
        public virtual void Write()
        {
            Console.Write("Пише...");
        }
        public virtual void Relax()
        {
            Console.Write("Відпочиває...");
        }
    }
}
